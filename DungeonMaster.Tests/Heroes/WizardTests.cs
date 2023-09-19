using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Heroes;
using Xunit;

namespace DungeonMaster.Tests.Heroes
{
    public class WizardTests
    {
        [Fact]
        public void Wizard_Creation_ValidName_NameSetCorrectly()
        {
            var hero = new Wizard("Khadgar");
            Assert.Equal("Khadgar", hero.Name);
        }

        [Fact]
        public void Wizard_Creation_DefaultState_LevelSetToOne()
        {
            var hero = new Wizard("Khadgar");
            Assert.Equal(1, hero.Level);
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
        public void Wizard_LevelUp_StrengthAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string wizardName = "Khadgar";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedStrength = 2;
            Assert.Equal(expectedStrength, attributesAfterLevelUp.Strength);
        }

        [Fact]
        public void Wizard_LevelUp_DexterityAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string wizardName = "Khadgar";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedDexterity = 2;
            Assert.Equal(expectedDexterity, attributesAfterLevelUp.Dexterity);
        }

        [Fact]
        public void Wizard_LevelUp_IntelligenceAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string wizardName = "Khadgar";
            var hero = new Wizard(wizardName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedIntelligence = 13;
            Assert.Equal(expectedIntelligence, attributesAfterLevelUp.Intelligence);
        }

        [Fact]
        public void Wizard_DamageNoWeapon_EqualBaseDamage()
        {
            // ARRANGE
            var hero = new Wizard("Merlin");
            double expectedDamage = 1 * (1 + 5 / 99); 

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Wizard_DamageWithStaff_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Wizard("Merlin");
            var staff = new Weapon("Wooden Staff", 1, WeaponType.Staff, 3);  
            hero.Equip(staff);
            double expectedDamage = 3 * (1 + 5 / 99); 

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Wizard_DamageWithWand_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Wizard("Merlin");
            var wand = new Weapon("Wooden Wand", 1, WeaponType.Wand, 2); 
            hero.Equip(wand);
            double expectedDamage = 2 * (1 + 5 / 99);

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Wizard_DamageWithWeaponAndClothArmor_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Wizard("Merlin");
            var wand = new Weapon("Wooden Wand", 1, WeaponType.Wand, 2);
            var clothArmor = new Armor("Cloth Robe", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(0, 0, 1)); 
            hero.Equip(wand);
            hero.Equip(clothArmor);
            double expectedDamage = 2 * (1 + (5 + 1) / 99); 

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }
    }
}
