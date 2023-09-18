using DungeonMaster.Attributes;
    using DungeonMaster.Equipment;
    using DungeonMaster.Heroes;
    using Xunit;

namespace DungeonMaster.Tests
{
    public class HeroTests
    {
        // Wizard creation
        [Fact]
        public void Wizard_Creation_CorrectName()
        {
            var hero = new Wizard("Khadgar");
            Assert.Equal("Khadgar", hero.Name);
        }

        [Fact]
        public void Wizard_Creation_CorrectLevel()
        {
            var hero = new Wizard("Khadgar");
            Assert.Equal(1, hero.Level);
        }

        // Archer creation
        [Fact]
        public void Archer_Creation_CorrectName()
        {
            var hero = new Archer("Legolas");
            Assert.Equal("Legolas", hero.Name);
        }

        [Fact]
        public void Archer_Creation_CorrectLevel()
        {
            var hero = new Archer("Legolas");
            Assert.Equal(1, hero.Level);
        }

        // Barbarian creation
        [Fact]
        public void Barbarian_Creation_CorrectName()
        {
            var hero = new Barbarian("Conan");
            Assert.Equal("Test Barbarian", hero.Name);
        }

        [Fact]
        public void Barbarian_Creation_CorrectLevel()
        {
            var hero = new Barbarian("Conan");
            Assert.Equal(1, hero.Level);
        }

        // Swashbuckler creation
        [Fact]
        public void Swashbuckler_Creation_CorrectName()
        {
            var hero = new Swashbuckler("Jack Sparrow");
            Assert.Equal("Jack Sparrow", hero.Name);
        }

        [Fact]
        public void Swashbuckler_Creation_CorrectLevel()
        {
            var hero = new Swashbuckler("Jack Sparrow");
            Assert.Equal(1, hero.Level);
        }

        // HeroAttribute creation
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

        // Weapon creation
        [Fact]
        public void Weapon_Creation_CorrectName()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal("Common Hatchet", weapon.Name);
        }

        [Fact]
        public void Weapon_Creation_CorrectRequiredLevel()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal(1, weapon.RequiredLevel);
        }

        [Fact]
        public void Weapon_Creation_CorrectSlot()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal(Slot.Weapon, weapon.Slot);
        }

        [Fact]
        public void Barbarian_DamageNoWeapon_EqualBaseDamage()
        {
            var hero = new Barbarian("Conan");
            double expectedDamage = 1 * (1 + (5 / 100.0));
            Assert.Equal(expectedDamage, hero.Damage());
        }

        [Fact]
        public void Barbarian_DamageWithWeapon_EqualIncreasedDamage()
        {
            var hero = new Barbarian("TConan");
            var hatchet = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            hero.Equip(hatchet);
            double expectedDamage = 2 * (1 + (5 / 100.0));
            Assert.Equal(expectedDamage, hero.Damage());
        }

        [Fact]
        public void Barbarian_DamageWithWeaponAndArmor_EqualIncreasedDamage()
        {
            var hero = new Barbarian("Conan");
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
            const string wizardName = "Khadgar";
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
            const string wizardName = "Khadgar";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedStrength = 5;  
            Assert.Equal(expectedStrength, attributesAfterLevelUp.Strength);
        }

        [Fact]
        public void Wizard_LevelUp_IncrementsDexterityAttribute()
        {
            // ARRANGE
            const string wizardName = "Khadgar";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedDexterity = 6;  
            Assert.Equal(expectedDexterity, attributesAfterLevelUp.Dexterity);
        }

        [Fact]
        public void Wizard_LevelUp_IncrementsIntelligenceAttribute()
        {
            // ARRANGE
            const string wizardName = "Khadgar";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedIntelligence = 7;  
            Assert.Equal(expectedIntelligence, attributesAfterLevelUp.Intelligence);
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
        public void Wizard_Display_ShowsCorrectDetails()
        {
            var hero = new Wizard("Test Wizard");
            var expectedDisplay = "Name: Khadgar, Level: 1, Class: Wizard, Strength: 5, Dexterity: 4, Intelligence: 8"; 
            Assert.Equal(expectedDisplay, hero.Display());
        }

        [Fact]
        public void Archer_Display_ShowsCorrectDetails()
        {
            var hero = new Archer("Test Archer");
            var expectedDisplay = "Name: Test Archer, Level: 1, Class: Archer, Strength: 6, Dexterity: 5, Intelligence: 3"; // adjust as per your actual format
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