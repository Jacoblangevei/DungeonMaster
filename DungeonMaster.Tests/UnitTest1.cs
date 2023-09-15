using DungeonMaster.Attributes;
    using DungeonMaster.Equipment;
    using DungeonMaster.Heroes;
    using Xunit;

namespace DungeonMaster.Tests
{
    public class HeroTests
    {
        [Fact]
        public void Wizard_Creation_CorrectAttributes()
        {
            var hero = new Wizard("Test Wizard");
            Assert.Equal("Test Wizard", hero.Name);
            Assert.Equal(1, hero.Level);
            // To do: Add other assertions related to the Wizard attributes
        }

        [Fact]
        public void Archer_Creation_CorrectAttributes()
        {
            var hero = new Archer("Test Archer");
            Assert.Equal("Test Archer", hero.Name);
            Assert.Equal(1, hero.Level);
            // To do: Add other assertions related to the Wizard attributes
        }

        [Fact]
        public void Barbarian_Creation_CorrectAttributes()
        {
            var hero = new Barbarian("Test Barbarian");
            Assert.Equal("Test Barbarian", hero.Name);
            Assert.Equal(1, hero.Level);
            // To do: Add other assertions related to the Barbarian attributes
        }

        [Fact]
        public void Swashbuckler_Creation_CorrectAttributes()
        {
            var hero = new Swashbuckler ("Test Swashbuckler");
            Assert.Equal("Test Swashbuckler", hero.Name);
            Assert.Equal(1, hero.Level);
            // To do: Add other assertions related to the Barbarian attributes
        }


        [Fact]
        public void HeroAttribute_Addition_IncreasesCorrectly()
        {
            var attr1 = new HeroAttribute(1, 2, 3);
            var attr2 = new HeroAttribute(1, 2, 3);
            var result = attr1 + attr2;
            Assert.Equal(2, result.Strength);
            Assert.Equal(4, result.Dexterity);
            Assert.Equal(6, result.Intelligence);
        }

        [Fact]
        public void Weapon_Creation_CorrectAttributes()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal("Common Hatchet", weapon.Name);
            Assert.Equal(1, weapon.RequiredLevel);
            Assert.Equal(Slot.Weapon, weapon.Slot);
        }


        [Fact]
        public void Barbarian_DamageNoWeapon_EqualBaseDamage()
        {
            var hero = new Barbarian("Test Barbarian");
            double expectedDamage = 1 * (1 + (5 / 100.0));
            Assert.Equal(expectedDamage, hero.Damage());
        }

        [Fact]
        public void Barbarian_DamageWithWeapon_EqualIncreasedDamage()
        {
            var hero = new Barbarian("Test Barbarian");
            var hatchet = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            hero.Equip(hatchet);
            double expectedDamage = 2 * (1 + (5 / 100.0));
            Assert.Equal(expectedDamage, hero.Damage());
        }

        [Fact]
        public void Barbarian_DamageWithWeaponAndArmor_EqualIncreasedDamage()
        {
            var hero = new Barbarian("Test Barbarian");
            var hatchet = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            var plateArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            hero.Equip(hatchet);
            hero.Equip(plateArmor);
            double expectedDamage = 2 * (1 + ((5 + 1) / 100.0));
            Assert.Equal(expectedDamage, hero.Damage());
        }

        [Fact]
        public void Wizard_LevelUp_IncrementsLevel()
        {
            // ARRANGE
            const string wizardName = "Test Wizard";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Wizard_LevelUp_IncrementsStrengthAttribute()
        {
            // ARRANGE
            const string wizardName = "Test Wizard";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedStrength = 5;  // example value
            Assert.Equal(expectedStrength, attributesAfterLevelUp.Strength);
        }

        [Fact]
        public void Wizard_LevelUp_IncrementsDexterityAttribute()
        {
            // ARRANGE
            const string wizardName = "Test Wizard";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedDexterity = 6;  // example value
            Assert.Equal(expectedDexterity, attributesAfterLevelUp.Dexterity);
        }

        [Fact]
        public void Wizard_LevelUp_IncrementsIntelligenceAttribute()
        {
            // ARRANGE
            const string wizardName = "Test Wizard";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedIntelligence = 7;  // example value
            Assert.Equal(expectedIntelligence, attributesAfterLevelUp.Intelligence);
        }

        [Fact]
        public void Hero_EquipInvalidWeapon_ThrowsException()
        {
            var hero = new Barbarian("Test Barbarian");
            var invalidWeapon = new Weapon("Invalid Weapon", 5, WeaponType.Wand, 10);

            Assert.Throws<InvalidOperationException>(() => hero.Equip(invalidWeapon));
        }

        [Fact]
        public void Hero_EquipInvalidArmor_ThrowsException()
        {
            var hero = new Barbarian("Test Barbarian");
            var invalidArmor = new Armor("Invalid Armor", 5, Slot.Head, ArmorType.Cloth, new HeroAttribute(0, 0, 1)); // Assuming Barbarian can't equip Cloth armor

            Assert.Throws<InvalidOperationException>(() => hero.Equip(invalidArmor));
        }

        [Fact]
        public void Hero_TotalAttributes_NoEquipment()
        {
            var hero = new Barbarian("Test Barbarian");
            var totalAttributes = hero.TotalAttributes();
        }

    }

}