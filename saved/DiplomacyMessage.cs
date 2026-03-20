#region Assembly GameLogicAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameLogicAssembly.dll
#endregion


public class DiplomacyMessage : Il2CppSystem.Object
{
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public DiplomacyMessage();
    public DiplomacyMessage(System.IntPtr pointer);

    public DiplomacyMessageType Type { get; set; }
    public byte Sender { get; set; }

    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public void Deserialize(Il2CppSystem.IO.BinaryReader reader, int version);
    [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
    [Il2CppInterop.Common.Attributes.CallerCountAttribute]
    public void Serialize(Il2CppSystem.IO.BinaryWriter writer, int version);
}