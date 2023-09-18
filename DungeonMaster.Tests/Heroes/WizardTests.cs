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
        // Display
        public void Wizard_Display_ShowsCorrectDetails()
        {
            var hero = new Wizard("Test Wizard");
            var expectedDisplay = "Name: Khadgar, Level: 1, Class: Wizard, Strength: 1, Dexterity: 1, Intelligence: 8";
            Assert.Equal(expectedDisplay, hero.Display());
        }
    }
}
