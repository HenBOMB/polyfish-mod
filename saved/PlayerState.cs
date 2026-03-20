#region Assembly GameLogicAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameLogicAssembly.dll
#endregion

using Polytopia.Data;
using PolytopiaBackendBase.Common;

public class PlayerState : Il2CppSystem.Object
{
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public PlayerState();
    public PlayerState(System.IntPtr pointer);

    public static byte NO_PLAYER_ID { get; set; }
    public static byte NATURE_PLAYER_ID { get; set; }
    public Il2CppSystem.Collections.Generic.List<byte> knownPlayers { get; set; }
    public Il2CppSystem.Collections.Generic.List<ImprovementData.Type> builtUniqueImprovements { get; set; }
    public Il2CppSystem.Collections.Generic.Dictionary<byte, DiplomacyRelation> relations { get; set; }
    public Il2CppSystem.Collections.Generic.List<DiplomacyMessage> messages { get; set; }
    public SkinType skinType { get; set; }
    public int currency { get; set; }
    public uint score { get; set; }
    public uint endScore { get; set; }
    public int cities { get; set; }
    public uint kills { get; set; }
    public uint casualities { get; set; }
    public uint wipeOuts { get; set; }
    public int wipedAtCommandIndex { get; set; }
    public byte killerId { get; set; }
    public uint killedTurn { get; set; }
    public int color { get; set; }
    public AIState aiState { get; set; }
    public Il2CppSystem.Collections.Generic.List<TechData> unlockedTechCache { get; set; }
    public bool blockTrainUnits { get; set; }
    public int capitalCountCache { get; set; }
    public OpinionManager opinions { get; set; }
    public byte Id { get; set; }
    public string UserName { get; set; }
    public Il2CppSystem.Nullable<Il2CppSystem.Guid> AccountId { get; set; }
    public bool AutoPlay { get; set; }
    public Il2CppSystem.Collections.Generic.Dictionary<byte, int> aggressions { get; set; }
    public Il2CppSystem.Collections.Generic.List<TaskBase> tasks { get; set; }
    public int Currency { get; set; }
    public TribeType climate { get; set; }
    public Il2CppSystem.Collections.Generic.List<TechData.Type> availableTech { get; set; }
    public byte _Id_k__BackingField { get; set; }
    public string _UserName_k__BackingField { get; set; }
    public bool _AutoPlay_k__BackingField { get; set; }
    public WorldCoordinates startTile { get; set; }
    public TribeType tribe { get; set; }
    public Il2CppSystem.Nullable<Il2CppSystem.Guid> _AccountId_k__BackingField { get; set; }
    public TribeType _climate { get; set; }
    public bool hasChosenTribe { get; set; }
    public int handicap { get; set; }
    public int resignedTurn { get; set; }
    public int resignedAtCommandIndex { get; set; }
    public TribeType tribeMix { get; set; }

    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public static bool AreDifferentPlayers(byte id, byte otherId);
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public void Deserialize(Il2CppSystem.IO.BinaryReader reader, int version);
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public string GetNameInternal();
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public float GetOpinion(GameState gameState, byte opponent);
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public int GetPlayerColor(int version, TribeType tribe, SkinType skin = SkinType.Default);
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public Il2CppSystem.Collections.Generic.List<Il2CppSystem.Collections.Generic.KeyValuePair<OpinionManager.Type, float>> GetReasons(GameState gameState, byte opponent);
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public SkinType GetSkinRaw();
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public int GetStupidity();
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public SkinType GetVisualSkin();
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public void MarkOpinionsDirty();
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public void Serialize(Il2CppSystem.IO.BinaryWriter writer, int version);
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public override string ToString();
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public void UpdateOpinions_Obsolete(GameState gameState);
}