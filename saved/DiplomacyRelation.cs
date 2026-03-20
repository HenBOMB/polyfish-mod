#region Assembly GameLogicAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameLogicAssembly.dll
#endregion


public class DiplomacyRelation : Il2CppSystem.Object
{
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public DiplomacyRelation();
    public DiplomacyRelation(System.IntPtr pointer);

    public static int DEFAULT_TURN { get; set; }
    public DiplomacyRelationState State { get; set; }
    public int LastAttackTurn { get; set; }
    public int EmbassyLevel { get; set; }
    public int LastPeaceBrokenTurn { get; set; }
    public int FirstMeet { get; set; }
    public int EmbassyBuildTurn { get; set; }
    public int PreviousAttackTurn { get; set; }

    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public void Deserialize(Il2CppSystem.IO.BinaryReader reader, int version);
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public void Serialize(Il2CppSystem.IO.BinaryWriter writer, int version);
}