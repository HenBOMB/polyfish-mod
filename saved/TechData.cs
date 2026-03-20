#region Assembly GameLogicAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameLogicAssembly.dll
#endregion


namespace Polytopia.Data
{
    public class TechData : Il2CppSystem.Object
    {
        [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
        [Il2CppInterop.Common.Attributes.CallerCountAttribute]
        public TechData();
        public TechData(System.IntPtr pointer);

        public int idx { get; set; }
        public int cost { get; set; }
        public Il2CppSystem.Collections.Generic.List<TechData> techUnlocks { get; set; }
        public Il2CppSystem.Collections.Generic.List<ImprovementData> improvementUnlocks { get; set; }
        public Il2CppSystem.Collections.Generic.List<UnitData> unitUnlocks { get; set; }
        public Il2CppSystem.Collections.Generic.List<PlayerAbility.Type> abilityUnlocks { get; set; }
        public Il2CppSystem.Collections.Generic.List<TaskData> taskUnlocks { get; set; }
        public Il2CppSystem.Collections.Generic.Dictionary<TerrainData.Type, int> movementUnlocks { get; set; }
        public Il2CppSystem.Collections.Generic.Dictionary<TerrainData.Type, int> defenceBonusUnlocks { get; set; }
        public string displayName { get; }
        public Type type { get; }

        public enum Type
        {
            Basic = 0,
            Riding = 1,
            FreeSpirit = 2,
            Chivalry = 3,
            Roads = 4,
            Trade = 5,
            Organization = 6,
            Shields = 7,
            Farming = 8,
            Construction = 9,
            Fishing = 10,
            Whaling = 11,
            Aquatism = 12,
            Sailing = 13,
            Navigation = 14,
            Hunting = 15,
            Forestry = 16,
            Mathematics = 17,
            Archery = 18,
            Spiritualism = 19,
            Climbing = 20,
            Meditation = 21,
            Philosophy = 22,
            Mining = 23,
            Smithery = 24,
            FreeDiving = 25,
            Spearing = 26,
            Riding2 = 27,
            ForestMagic = 28,
            WaterMagic = 29,
            Frostwork = 30,
            PolarWarfare = 31,
            Polarism = 32,
            Oceanology = 33,
            Shock = 35,
            Recycling = 36,
            Hydrology = 37,
            Diplomacy = 38,
            Aquaculture = 39,
            FishingSimple = 40,
            Sledding = 41,
            IceFishing = 42,
            Pescetism = 43,
            Ramming = 44,
            AquaBase = 45,
            MarineLife = 46,
            AquaFishing = 47,
            Waterways = 48,
            Rituals = 49,
            Mysticism = 50
        }
    }
}