using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Heroes;
using Xunit;

namespace DungeonMaster.Tests.Heroes
{
    public class SwashbucklerTests
    {
        [Fact]
        public void Swashbuckler_Creation_ValidName_NameSetCorrectly()
        {
            var hero = new Swashbuckler("Jack Sparrow");
            Assert.Equal("Jack Sparrow", hero.Name);
        }

        [Fact]
        public void Swashbuckler_Creation_DefaultState_LevelSetToOne()
        {
            var hero = new Swashbuckler("Jack Sparrow");
            Assert.Equal(1, hero.Level);
        }

        [Fact]
        public void Swashbuckler_LevelUp_IncrementsLevel()
        {
            // ARRANGE
            const string swashbucklerName = "Jack Sparrow";
            var hero = new Swashbuckler(swashbucklerName);

            // ACT
            hero.LevelUp();

            // ASSERT
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Swashbuckler_LevelUp_StrengthAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string swashbucklerName = "Jack Sparrow";
            var hero = new Swashbuckler(swashbucklerName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedStrength = 2;
            Assert.Equal(expectedStrength, attributesAfterLevelUp.Strength);
        }

        [Fact]
        public void Swashbuckler_LevelUp_DexterityAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string swashbucklerName = "Jack Sparrow";
            var hero = new Swashbuckler(swashbucklerName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedDexterity = 6;
            Assert.Equal(expectedDexterity, attributesAfterLevelUp.Dexterity);
        }

        [Fact]
        public void Swashbuckler_LevelUp_IntelligenceAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string swashbucklerName = "Jack Sparrow";
            var hero = new Swashbuckler(swashbucklerName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedIntelligence = 13;
            Assert.Equal(expectedIntelligence, attributesAfterLevelUp.Intelligence);
        }
    }
}
