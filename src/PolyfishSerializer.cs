
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Reflection;
using PolyMod.Api;
using UnityEngine;
using HarmonyLib;
using Il2CppInterop.Runtime.InteropTypes;


namespace PolyfishAI.src
{
    public static class PolyfishSerializer
    {
        public static string SerializeGameState(GameState gs)
        {
            return JsonSerializer.Serialize(ExtractGameState(gs));
        }
        
        public static string SerializeReplay(GameState gs, ReplayInterface ri)
        {
            try
            {
                if (ri == null || ri.timeline == null)
                    return "{\"error\": \"ReplayInterface or timeline is null\"}";

                var timeline = ri.timeline;
                var turnsCache = timeline.timelineDataCache;
                
                var turnsList = new List<object>();

                // Sort turns by key (turn number)
                var sortedTurnKeys = new List<int>();
                foreach (var key in turnsCache.Keys) sortedTurnKeys.Add(key);
                sortedTurnKeys.Sort();

                foreach (var turnNum in sortedTurnKeys)
                {
                    var turnData = turnsCache[turnNum];
                    var playersList = new List<object>();

                    // Sort players by byte ID
                    var playerCommandsDict = turnData.playerCommands;
                    var sortedPlayerIds = new List<byte>();
                    foreach (var pId in playerCommandsDict.Keys) sortedPlayerIds.Add(pId);
                    sortedPlayerIds.Sort();

                    foreach (var playerId in sortedPlayerIds)
                    {
                        var commandsList = playerCommandsDict[playerId];
                        var serializedCommands = new List<object>();

                        // commandsList is Il2CppSystem.Collections.Generic.List<Timeline.TimelineCommandData>
                        for (int i = 0; i < commandsList.Count; i++)
                        {
                            var cmdData = commandsList[i];
                            if (cmdData != null && cmdData.command != null)
                            {
                                serializedCommands.Add(SerializeCommand(cmdData.command));
                            }
                        }

                        playersList.Add(new
                        {
                            playerId = (int)playerId,
                            commands = serializedCommands
                        });
                    }

                    turnsList.Add(new
                    {
                        turn = turnNum,
                        players = playersList
                    });
                }

                var replayData = new { 
                    turns = turnsList,
                    gameState = SerializeGameState(gs)
                };

                return JsonSerializer.Serialize(replayData, new JsonSerializerOptions { WriteIndented = true });
            }
            catch (Exception ex)
            {
                PolyfishPlugin.Logger.LogError("[polyfish_ai] Replay serialization error: " + ex.Message + "\n" + ex.StackTrace);
                return "{\"error\": \"" + ex.Message + "\"}";
            }
        }

        private static Dictionary<string, object> ExtractGameState(GameState gs)
        {
            try
            {
                var settings = gs.Settings;
                var map = gs.Map;
                var size = settings.MapSize;
                var tiles = new Dictionary<int, object>();
                var structures = new Dictionary<int, object>();
                var resources = new Dictionary<int, object>();
                var _units = new Dictionary<int, List<object>>();
                var _cities = new Dictionary<int, List<object>>();

                var settingsDto = new Dictionary<string, object>
                {
                    ["version"] = gs.Version,
                    ["seed"] = gs.Seed,
                    ["turn"] = gs.CurrentTurn,
                    ["currentPlayerTurnId"] = gs.CurrentPlayerIndex,
                    ["size"] = settings.MapSize,
                    ["tileCount"] = settings.MapSize * settings.MapSize,
                    ["mapType"] = (int)settings.mapPreset,
                    ["mode"] = (int)settings.BaseGameMode,
                    ["gameName"] = settings.GameName,
                    ["winByCapital"] = settings.rules!.WinByCapital,
                    ["winByExtermination"] = settings.rules!.WinByExtermination,
                    ["_maxTribeCount"] = gs.PlayerStates.Count,
                };

                var root = new Dictionary<string, object>
                {
                    ["settings"] = settingsDto,
                    ["initialSeed"] = gs.Seed,
                };

                // 1. Pre-scan units to build ID-to-TribeIndex map (matches Rust's post_load mapping)
                var unitIdToIndex = new Dictionary<uint, int>();
                var tribeCounters = new Dictionary<int, int>();
                foreach (var tile in map.Tiles)
                {
                    var u = tile.unit;
                    if (u != null)
                    {
                        int owner = (int)u.owner;
                        if (!tribeCounters.ContainsKey(owner)) tribeCounters[owner] = 0;
                        unitIdToIndex[u.id] = tribeCounters[owner]++;
                    }
                }

                foreach (var tile in map.Tiles)
                {
                    int idx = tile.coordinates.Y * size + tile.coordinates.X; // in rust engine: y * width + x

                    var explorerList = new List<int>();
                    foreach (var e in tile.explorers) explorerList.Add((int)e);

                    var effectsList = new List<int>();
                    foreach (var e in tile.effects) effectsList.Add((int)e);

                    var t = new Dictionary<string, object?>
                    {
                        ["coords"] = new { x = tile.coordinates.X, y = tile.coordinates.Y, idx = idx },
                        ["rulingCityCoords"] = tile.rulingCityCoordinates.IsValid(size, size) ? new { x = tile.rulingCityCoordinates.X, y = tile.rulingCityCoordinates.Y, idx = tile.rulingCityCoordinates.Y * size + tile.rulingCityCoordinates.X } : null,
                        ["type"] = (int)tile.terrain,
                        ["explorers"] = explorerList,
                        ["hasRoad"] = tile.hasRoad,
                        ["hasRoute"] = tile.hasRoute,
                        ["capitalOf"] = (int)tile.capitalOf,
                        ["skinType"] = (int)tile.Skin,
                        ["climate"] = (int)tile.climate,
                        ["owner"] = (int)tile.owner,
                        ["effects"] = effectsList,
                    };

                    var imp = tile.improvement;
                    if (imp != null)
                    {
                        structures[idx] = new
                        {
                            type = (int)imp.type,
                            level = (int)imp.level,
                            founded = (int)imp.founded,
                        };

                        // Village & Owned = City
                        if ((int)imp.type == 1 && (int)imp.owner > 0)
                        {
                            if (!_cities.ContainsKey((int)imp.owner)) _cities[(int)imp.owner] = new List<object>();

                            var rewardsList = new List<int>();
                            foreach (var r in imp.rewards) rewardsList.Add((int)r);

                            _cities[(int)imp.owner].Add(new
                            {
                                owner = (int)imp.owner,
                                name = imp.name,
                                idx = idx,
                                population = (int)imp.population,
                                progress = (int)imp.xp,
                                borderSize = (int)imp.borderSize,
                                connectedToCapital = imp.connectedToCapitalOfPlayer == 1,
                                level = (int)imp.level,
                                production = (int)imp.production,
                                rewards = rewardsList,
                            });
                        }
                    }

                    var res = tile.resource;
                    if (res != null)
                    {
                        resources[idx] = new { type = (int)res.type };
                    }

                    var unit = tile.unit;
                    if (unit != null)
                    {
                        if (!_units.ContainsKey((int)unit.owner)) _units[(int)unit.owner] = new List<object>();

                        var unitEffects = new List<int>();
                        foreach (var e in unit.effects) unitEffects.Add((int)e);

                        var uDto = new Dictionary<string, object?>
                        {
                            ["owner"] = (int)unit.owner,
                            ["type"] = (int)unit.type,
                            ["hp"] = unit.health,
                            ["promoted"] = unit.promotionLevel != 0,
                            ["xp"] = unit.xp,
                            ["coords"] = new { x = unit.coordinates.X, y = unit.coordinates.Y, idx = idx },
                            ["prevCoords"] = unit.previousTurnEndCoordinates.IsValid(size, size) ? new { x = unit.previousTurnEndCoordinates.X, y = unit.previousTurnEndCoordinates.Y, idx = unit.previousTurnEndCoordinates.Y * size + unit.previousTurnEndCoordinates.X } : new { x = -1, y = -1, idx = -1 },
                            ["homeCoords"] = unit.home.IsValid(size, size) ? new { x = unit.home.X, y = unit.home.Y, idx = unit.home.Y * size + unit.home.X } : null,
                            ["flipped"] = unit.flipped,
                            ["direction"] = unit.direction,
                            ["createdTurn"] = unit.createdTurn,
                            ["passengerType"] = unit.passengerUnit != null ? (int)unit.passengerUnit.type : null,
                            ["moved"] = unit.moved,
                            ["attacked"] = unit.attacked,
                            ["effects"] = unitEffects,
                            ["converted"] = unit.birthClimate != gs.PlayerStates[unit.owner].climate,
                            ["attacksPerformed"] = 0,
                            ["parentUnitIdx"] = unit.HasLeader() && unitIdToIndex.TryGetValue(unit.leader, out int pIdx) ? (int?)pIdx : null,
                            ["childUnitIdx"] = unit.HasFollower() && unitIdToIndex.TryGetValue(unit.follower, out int cIdx) ? (int?)cIdx : null
                        };
                        _units[(int)unit.owner].Add(uDto);
                    }

                    tiles[idx] = t;
                }

                var tribes = new Dictionary<int, object>();

                foreach (var p in gs.PlayerStates)
                {
                    var tech = new List<int>();
                    foreach (var techType in p.availableTech) tech.Add((int)techType);

                    var relations = new Dictionary<string, object>();
                    if (p.relations != null)
                    {
                        foreach (var r in p.relations)
                        {
                            relations[r.Key.ToString()] = new
                            {
                                playerId = (int)r.Key,
                                state = (int)r.Value.State,
                                lastAttackTurn = r.Value.LastAttackTurn,
                                embassyLevel = r.Value.EmbassyLevel,
                                lastPeaceBrokenTurn = r.Value.LastPeaceBrokenTurn,
                                firstMeet = r.Value.FirstMeet,
                                embassyBuildTurn = r.Value.EmbassyBuildTurn,
                                previousAttackTurn = r.Value.PreviousAttackTurn
                            };
                        }
                    }

                    tribes[(int)p.Id] = new
                    {
                        id = (int)p.Id,
                        username = p.UserName,
                        builtUniqueImprovements = p.builtUniqueImprovements, // uncasted?
                        knownPlayers = p.knownPlayers, // uncasted?
                        bot = p.AutoPlay,
                        score = p.score,
                        stars = p.Currency,
                        type = (int)p.tribe,
                        killerId = (int)p.killerId,
                        killedTurn = p.killedTurn,
                        resignedTurn = p.resignedTurn,
                        startingTileCoords = new { x = p.startTile.X, y = p.startTile.Y, idx = p.startTile.Y * size + p.startTile.X },
                        kills = p.kills,
                        casualties = p.casualities,
                        tech_vanilla = tech,
                        relations = relations,
                        cities = _cities.ContainsKey((int)p.Id) ? _cities[(int)p.Id] : new List<object>(),
                        units = _units.ContainsKey((int)p.Id) ? _units[(int)p.Id] : new List<object>(),

                        attacked_this_turn = _units.ContainsKey((int)p.Id) && _units[(int)p.Id].Any(u => (bool)((Dictionary<string, object?>)u)["attacked"]),
                        pacifist_turns = 0,
                        conversions = 0,
                    };
                }

                root["tiles"] = tiles;
                root["tribes"] = tribes;
                root["resources"] = resources;
                root["structures"] = structures;

                return root;
            }
            catch (Exception ex)
            {
                PolyfishPlugin.Logger.LogError($"Serialization error: {ex.Message}\n{ex.StackTrace}");
                return new Dictionary<string, object> { ["error"] = "Replay serialization failed" };
            }
        }

        private static T? TryCast<T>(CommandBase cmd) where T : Il2CppObjectBase
        {
            if (cmd == null) return null;
            try { return cmd.Cast<T>(); } catch { return null; }
        }

        private static object SerializeCommand(CommandBase command)
        {
            var typeId = command.Id;
            var result = new Dictionary<string, object>
            {
                ["type"] = typeId,
                // ["playerId"] = (int)command.PlayerId
            };

            string tid = typeId?.ToLowerInvariant() ?? "";

            switch (tid)
            {
                case "move":
                    var move = TryCast<MoveCommand>(command)!;
                    result["unitId"] = move.UnitId;
                    result["from"] = SerializeCoords(move.From);
                    result["to"] = SerializeCoords(move.To);
                    break;

                case "train":
                    var train = TryCast<TrainCommand>(command)!;
                    result["unitType"] = (int)train.Type;
                    result["coords"] = SerializeCoords(train.Coordinates);
                    break;

                case "build":
                    var build = TryCast<BuildCommand>(command)!;
                    result["improvementType"] = (int)build.Type;
                    result["coords"] = SerializeCoords(build.Coordinates);
                    break;

                case "research":
                    var research = TryCast<ResearchCommand>(command)!;
                    result["techType"] = (int)research.Type;
                    break;

                case "attack":
                    var attack = TryCast<AttackCommand>(command)!;
                    result["unitId"] = attack.UnitId;
                    result["origin"] = SerializeCoords(attack.Origin);
                    result["target"] = SerializeCoords(attack.Target);
                    break;

                case "capture":
                    var capture = TryCast<CaptureCommand>(command)!;
                    result["unitId"] = capture.UnitId;
                    result["coords"] = SerializeCoords(capture.Coordinates);
                    break;

                case "cityreward":
                    var reward = TryCast<CityRewardCommand>(command)!;
                    result["reward"] = (int)reward.Reward;
                    result["coords"] = SerializeCoords(reward.Coordinates);
                    break;

                case "resign":
                    var resign = TryCast<ResignCommand>(command)!;
                    result["resignedPlayerId"] = (int)resign.ResignedPlayerId;
                    result["kickerPlayerId"] = (int)resign.KickerPlayerId;
                    result["wasKicked"] = resign.WasKicked;
                    break;

                case "examineruins":
                    var ruins = TryCast<ExamineRuinsCommand>(command)!;
                    result["coords"] = SerializeCoords(ruins.Coordinates);
                    break;
                
                case "promote":
                    var promote = TryCast<PromoteCommand>(command)!;
                    result["coords"] = SerializeCoords(promote.Coordinates);
                    break;
                    
                case "recover":
                    var recover = TryCast<RecoverCommand>(command)!;
                    result["coords"] = SerializeCoords(recover.Coordinates);
                    break;
                
                case "boost":
                    var boost = TryCast<BoostCommand>(command)!;
                    result["coords"] = SerializeCoords(boost.Coordinates);
                    break;
                    
                case "decompose":
                    var decompose = TryCast<DecomposeCommand>(command)!;
                    result["coords"] = SerializeCoords(decompose.Coordinates);
                    break;

                case "breakice":
                    var breakIce = TryCast<BreakIceCommand>(command)!;
                    result["coords"] = SerializeCoords(breakIce.Coordinates);
                    result["whatDoWeBreak"] = breakIce.whatDoWeBreak;
                    break;
                
                case "upgrade":
                    var upgrade = TryCast<UpgradeCommand>(command)!;
                    result["coords"] = SerializeCoords(upgrade.Coordinates);
                    result["type"] = upgrade.Type;
                    break;
                
                case "explode":
                    var explode = TryCast<ExplodeCommand>(command)!;
                    result["coords"] = SerializeCoords(explode.Coordinates);
                    break;
                
                case "disband":
                    var disband = TryCast<DisbandCommand>(command)!;
                    result["coords"] = SerializeCoords(disband.Coordinates);
                    break;

                case "destroy":
                    var destroy = TryCast<DestroyCommand>(command)!;
                    result["coords"] = SerializeCoords(destroy.Coordinates);
                    break;

                case "freezearea":
                    var freezeArea = TryCast<FreezeAreaCommand>(command)!;
                    result["coords"] = SerializeCoords(freezeArea.Coordinates);
                    break;

                case "breakpeace":
                    var breakPeace = TryCast<BreakPeaceCommand>(command)!;
                    result["coords"] = SerializeCoords(breakPeace.Coordinates);
                    result["opponentId"] = (int)breakPeace.OpponentId;
                    break;

                case "peacerequestresponse":
                    var peaceRequestResponse = TryCast<PeaceRequestResponseCommand>(command)!;
                    result["accepted"] = peaceRequestResponse.Accepted;
                    result["opponentId"] = (int)peaceRequestResponse.OpponentId;
                    break;
                
                case "establishembassy":
                    var establishEmbassy = TryCast<EstablishEmbassyCommand>(command)!;
                    result["coords"] = SerializeCoords(establishEmbassy.Coordinates);
                    result["opponentId"] = (int)establishEmbassy.OpponentId;
                    break;

                case "peacetreaty":
                    var peaceTreaty = TryCast<PeaceTreatyCommand>(command)!;
                    result["coords"] = SerializeCoords(peaceTreaty.Coordinates);
                    result["opponentId"] = (int)peaceTreaty.OpponentId;
                    break;

                case "destroyembassy":
                    var destroyEmbassy = TryCast<DestroyEmbassyCommand>(command)!;
                    result["coords"] = SerializeCoords(destroyEmbassy.Coordinates);
                    result["opponentId"] = (int)destroyEmbassy.OpponentId;
                    break;

                case "healothers":
                    var healOthers = TryCast<HealOthersCommand>(command)!;
                    result["coords"] = SerializeCoords(healOthers.Coordinates);
                    break;

                case "startmatch":
                case "endmatch":
                case "endturn":
                    break;

                default:
                    result["error"] = "Unknown command";
                    PolyfishPlugin.Logger.LogWarning($"Unknown/Unhandled command type ID: {tid} (Type: {command.GetType().Name})");
                    break;
            }

            return result;
        }

        private static object? GetVal(object obj, string name)
        {
            if (obj == null) return null;
            try
            {
                var type = obj.GetType();
                var flags = BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static | BindingFlags.FlattenHierarchy;
                
                // 1. Try exact match (with IgnoreCase)
                var prop = type.GetProperty(name, flags | BindingFlags.IgnoreCase);
                if (prop != null)
                {
                    var val = prop.GetValue(obj);
                    if (val is IntPtr) return null;
                    return val;
                }
                
                var field = type.GetField(name, flags | BindingFlags.IgnoreCase);
                if (field != null)
                {
                    var val = field.GetValue(obj);
                    if (val is IntPtr) return null;
                    return val;
                }

                // 2. Try matching the name as a substring
                foreach (var f in type.GetFields(flags))
                {
                    if (f.Name.Contains(name, StringComparison.OrdinalIgnoreCase))
                    {
                        var val = f.GetValue(obj);
                        if (val is IntPtr) continue; 
                        return val;
                    }
                }
            }
            catch { }
            return null;
        }

        private static object SerializeCoords(object coordsObj)
        {
            // Try explicit cast to WorldCoordinates first
            if (coordsObj is WorldCoordinates coords)
            {
                return new { x = coords.X, y = coords.Y };
            }

            // Fallback to reflection
            var x = GetVal(coordsObj, "X") ?? GetVal(coordsObj, "x");
            var y = GetVal(coordsObj, "Y") ?? GetVal(coordsObj, "y");
            
            return new { x, y };
        }
    
    }
}
