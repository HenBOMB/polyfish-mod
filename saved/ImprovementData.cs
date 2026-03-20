#region Assembly GameLogicAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameLogicAssembly.dll
#endregion


namespace Polytopia.Data
{
    public class ImprovementData : Il2CppSystem.Object
    {
        [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
        [Il2CppInterop.Common.Attributes.CallerCountAttribute]
        public ImprovementData();
        public ImprovementData(System.IntPtr pointer);

        public string displayName { get; }
        public Il2CppSystem.Collections.Generic.List<GrowthRewards> growthRewards { get; set; }
        public int growthRate { get; set; }
        public int range { get; set; }
        public Il2CppSystem.Collections.Generic.List<TerrainData> routes { get; set; }
        public Il2CppSystem.Collections.Generic.List<AdjacencyImprovements> adjacencyImprovements { get; set; }
        public Il2CppSystem.Collections.Generic.List<AdjacencyRequirements> adjacencyRequirements { get; set; }
        public Il2CppSystem.Collections.Generic.List<TerrainRequirements> terrainRequirements { get; set; }
        public Il2CppSystem.Collections.Generic.List<Rewards> rewards { get; set; }
        public Il2CppSystem.Collections.Generic.List<Creates> creates { get; set; }
        public Il2CppSystem.Collections.Generic.List<ImprovementAbility.Type> improvementAbilities { get; set; }
        public int maxLevel { get; set; }
        public int borderSize { get; set; }
        public int work { get; set; }
        public int cost { get; set; }
        public bool hidden { get; set; }
        public int idx { get; set; }
        public Type type { get; }

        public enum Type
        {
            None = 0,
            City = 1,
            Ruin = 2,
            Road = 3,
            CustomsHouse = 4,
            Farm = 5,
            Windmill = 6,
            Fishing = 7,
            Port = 8,
            Hunting = 9,
            ClearForest = 10,
            BurnForest = 11,
            LumberHut = 12,
            Sawmill = 13,
            GrowForest = 14,
            HarvestFruit = 15,
            WhaleHunting = 16,
            Temple = 17,
            ForestTemple = 18,
            WaterTemple = 19,
            MountainTemple = 20,
            Mine = 21,
            Forge = 22,
            Monument1 = 23,
            Monument2 = 24,
            Monument3 = 25,
            Monument4 = 26,
            Monument5 = 27,
            Monument6 = 28,
            Monument7 = 29,
            EnchantAnimal = 30,
            EnchantWhale = 31,
            Sanctuary = 32,
            Outpost = 33,
            IceBank = 34,
            IceTemple = 35,
            PolarisClimate = 36,
            Fungi = 37,
            Algae = 38,
            Mycelium = 39,
            BurnSpores = 40,
            Clathrus = 41,
            HiddenSanctuary = 42,
            HarvestSpores = 43,
            NullBuilding = 44,
            Cultivate = 45,
            StarFishing = 46,
            LightHouse = 47,
            Bridge = 48,
            Aquafarm = 49,
            Market = 50,
            Atoll = 51,
            Canal = 52,
            Fertilize = 53,
            LandFill = 54,
            AlgaeSpawn = 55
        }
    }
}