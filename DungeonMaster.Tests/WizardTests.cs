using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Heroes;
using Xunit;

namespace DungeonMaster.Tests
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
            var hero = new Wizard("Khadgar");
            hero.LevelUp();
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Wizard_LevelUp_StrengthAttributeCorrectlyIncremented()
        {
            var hero = new Wizard("Khadgar");
            hero.LevelUp();
            Assert.Equal(2, hero.TotalAttributes().Strength);
        }

        [Fact]
        public void Wizard_LevelUp_DexterityAttributeCorrectlyIncremented()
        {
            var hero = new Wizard("Khadgar");
            hero.LevelUp();
            Assert.Equal(2, hero.TotalAttributes().Dexterity);
        }

        [Fact]
        public void Wizard_LevelUp_IntelligenceAttributeCorrectlyIncremented()
        {
            var hero = new Wizard("Khadgar");
            hero.LevelUp();
            Assert.Equal(10, hero.TotalAttributes().Intelligence);
        }
    }
}
