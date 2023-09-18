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

            Assert.Throws<InvalidOperationException>(() => hero.Equip(invalidWeapon));
        }

        [Fact]
        public void Hero_EquipInvalidArmor_ThrowsException()
        {
            var hero = new Barbarian("Test Barbarian");
            var invalidArmor = new Armor("Invalid Armor", 5, Slot.Head, ArmorType.Cloth, new HeroAttribute(0, 0, 1));

            Assert.Throws<InvalidOperationException>(() => hero.Equip(invalidArmor));
        }

        [Fact]
        public void Hero_TotalAttributes_NoEquipment()
        {
            var hero = new Barbarian("Conan");
            var totalAttributes = hero.TotalAttributes();
        }

        // Display Tests
        [Fact]
        public void Archer_Display_ShowsCorrectDetails()
        {
            var hero = new Archer("Test Archer");
            var expectedDisplay = "Name: Test Archer, Level: 1, Class: Archer, Strength: 6, Dexterity: 5, Intelligence: 3";
            Assert.Equal(expectedDisplay, hero.Display());
        }
        [Fact]
        public void Barbarian_Display_ShowsCorrectDetails()
        {
            var hero = new Wizard("Test Wizard");
            var expectedDisplay = "Name: Khadgar, Level: 1, Class: Wizard, Strength: 5, Dexterity: 4, Intelligence: 8";
            Assert.Equal(expectedDisplay, hero.Display());
        }
        [Fact]
        public void Swashbuckler_Display_ShowsCorrectDetails()
        {
            var hero = new Wizard("Test Wizard");
            var expectedDisplay = "Name: Khadgar, Level: 1, Class: Wizard, Strength: 5, Dexterity: 4, Intelligence: 8";
            Assert.Equal(expectedDisplay, hero.Display());
        }

    }

}