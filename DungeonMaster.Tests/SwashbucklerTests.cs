using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Heroes;
using Xunit;

namespace DungeonMaster.Tests
{
    public class SwashbucklerTests
    {
        [Fact]
        public void Swashbuckler_Creation_ValidName_NameSetCorrectly()
        {
            var hero = new Wizard("Jack Sparrow");
            Assert.Equal("Jack Sparrow", hero.Name);
        }

        [Fact]
        public void Swashbuckler_Creation_DefaultState_LevelSetToOne()
        {
            var hero = new Wizard("Jack Sparrow");
            Assert.Equal(1, hero.Level);
        }

        [Fact]
        public void Swashbuckler_LevelUp_IncrementsLevel()
        {
            var hero = new Wizard("Jack Sparrow");
            hero.LevelUp();
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Swashbuckler_LevelUp_StrengthAttributeCorrectlyIncremented()
        {
            var hero = new Swashbuckler("Jack Sparrow");
            hero.LevelUp();
            Assert.Equal(2, hero.TotalAttributes().Strength);
        }

        [Fact]
        public void Swashbuckler_LevelUp_DexterityAttributeCorrectlyIncremented()
        {
            var hero = new Swashbuckler("Jack Sparrow");
            hero.LevelUp();
            Assert.Equal(10, hero.TotalAttributes().Dexterity);
        }

        [Fact]
        public void Swashbuckler_LevelUp_IntelligenceAttributeCorrectlyIncremented()
        {
            var hero = new Swashbuckler("Jack Sparrow");
            hero.LevelUp();
            Assert.Equal(2, hero.TotalAttributes().Intelligence);
        }
    }
}
