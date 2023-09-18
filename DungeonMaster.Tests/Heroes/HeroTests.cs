using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Heroes;
using Xunit;

namespace DungeonMaster.Tests.Heroes
{
    public class HeroTests
    {

        // HeroAttribute creation tests
        [Fact]
        public void HeroAttribute_Addition_IncreasesStrengthCorrectly()
        {
            var attr1 = new HeroAttribute(1, 2, 3);
            var attr2 = new HeroAttribute(1, 2, 3);
            var result = attr1 + attr2;
            Assert.Equal(2, result.Strength);
        }

        [Fact]
        public void HeroAttribute_Addition_IncreasesDexterityCorrectly()
        {
            var attr1 = new HeroAttribute(1, 2, 3);
            var attr2 = new HeroAttribute(1, 2, 3);
            var result = attr1 + attr2;
            Assert.Equal(4, result.Dexterity);
        }

        [Fact]
        public void HeroAttribute_Addition_IncreasesIntelligenceCorrectly()
        {
            var attr1 = new HeroAttribute(1, 2, 3);
            var attr2 = new HeroAttribute(1, 2, 3);
            var result = attr1 + attr2;
            Assert.Equal(6, result.Intelligence);
        }



        [Fact]
        public void Hero_EquipInvalidWeapon_ThrowsException()
        {
            var hero = new Barbarian("Conan");
            var invalidWeapon = new Weapon("Invalid Weapon", 5, WeaponType.Wand, 10);

            Assert.Throws<DungeonMaster.Heroes.InvalidWeaponException>(() => hero.Equip(invalidWeapon));
        }

        [Fact]
        public void Hero_EquipInvalidArmor_ThrowsException()
        {
            var hero = new Barbarian("Conan");
            var invalidArmor = new Armor("Invalid Armor", 5, Slot.Head, ArmorType.Cloth, new HeroAttribute(0, 0, 1));

            Assert.Throws<DungeonMaster.Heroes.InvalidArmorException>(() => hero.Equip(invalidArmor));
        }

        [Fact]
        public void Hero_TotalAttributes_NoEquipment()
        {
            var hero = new Barbarian("Conan");
            var totalAttributes = hero.TotalAttributes();
        }

    }

}