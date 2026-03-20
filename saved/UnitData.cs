#region Assembly GameLogicAssembly, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null
// GameLogicAssembly.dll
#endregion


namespace Polytopia.Data
{
    public class UnitData : Il2CppSystem.Object
    {
        [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
        [Il2CppInterop.Common.Attributes.CallerCountAttribute]
        public UnitData();
        public UnitData(System.IntPtr pointer);

        public int range { get; set; }
        public UnitData promotesTo { get; set; }
        public UnitData upgradesFrom { get; set; }
        public Il2CppSystem.Collections.Generic.List<TerrainData> movementTerrain { get; set; }
        public Il2CppSystem.Collections.Generic.List<UnitAbility.Type> unitAbilities { get; set; }
        public int attack { get; set; }
        public Type type { get; }
        public int movement { get; set; }
        public int growthRate { get; set; }
        public int defence { get; set; }
        public int health { get; set; }
        public int cost { get; set; }
        public bool hidden { get; set; }
        public int idx { get; set; }
        public WeaponEnum weapon { get; set; }
        public string displayName { get; }

        [Il2CppInterop.Common.Attributes.CachedScanResultsAttribute]
        [Il2CppInterop.Common.Attributes.CallerCountAttribute]
        public int getPromotionLimit(PlayerState player, GameState gameState);

        public enum WeaponEnum
        {
            None = 0,
            Club = 1,
            Sword = 2,
            Arrow = 3,
            Magic = 4,
            Gun = 5,
            Rock = 6,
            Claw = 7,
            FireBlow = 8,
            Trident = 9,
            IceArrow = 10,
            Poison = 11,
            Sting = 12,
            Dagger = 13,
            Burn = 14,
            Laser = 15,
            Pierce = 16,
            Water = 17
        }
        public enum Type
        {
            None = 0,
            Scout = 1,
            Warrior = 2,
            Rider = 3,
            Knight = 4,
            Defender = 5,
            Ship = 6,
            Battleship = 7,
            Catapult = 8,
            Archer = 9,
            MindBender = 10,
            Swordsman = 11,
            Giant = 12,
            Bunny = 13,
            Boat = 14,
            Polytaur = 15,
            Navalon = 16,
            DragonEgg = 17,
            BabyDragon = 18,
            FireDragon = 19,
            Amphibian = 20,
            Tridention = 21,
            Mooni = 22,
            BattleSled = 23,
            IceFortress = 24,
            IceArcher = 25,
            Crab = 26,
            Gaami = 27,
            Hexapod = 28,
            Doomux = 29,
            Phychi = 30,
            Kiton = 31,
            Exida = 32,
            Centipede = 33,
            Segment = 34,
            Raychi = 35,
            Shaman = 36,
            Dagger = 37,
            Cloak = 38,
            Cloak_Boat = 39,
            Pirate = 40,
            Bombership = 41,
            Scoutship = 42,
            Transportship = 43,
            Rammership = 44,
            Juggernaut = 45,
            MermaidWarrior = 46,
            MermaidArcher = 47,
            MermaidSwordsman = 48,
            MermaidDefender = 49,
            MermaidCloak = 50,
            MermaidDagger = 51,
            Jelly = 52,
            Shark = 53,
            Siren = 54,
            Aquapult = 55,
            Boomchi = 56,
            Island = 57,
            Ciru = 58,
            Mantis = 59,
            BugEgg = 60,
            Moth = 61,
            Larva = 62
        }
    }
}