#region Assembly GameLogicAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameLogicAssembly.dll
#endregion


namespace Polytopia.Data
{
    public class TerrainData : Il2CppSystem.Object
    {
        [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
        [Il2CppInterop.Common.Attributes.CallerCountAttribute]
        public TerrainData();
        public TerrainData(System.IntPtr pointer);

        public int idx { get; set; }
        public string displayName { get; }
        public Type type { get; }

        public enum Type
        {
            None = 0,
            Water = 1,
            Ocean = 2,
            Field = 3,
            Mountain = 4,
            Forest = 5,
            Ice = 6,
            Wetland = 7,
            Mangrove = 8
        }
    }
}