using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Heroes;
using Xunit;

namespace DungeonMaster.Tests.Heroes
{
    public class ArcherTests
    {
        [Fact]
        public void Archer_Creation_ValidName_NameSetCorrectly()
        {
            var hero = new Archer("Legolas");
            Assert.Equal("Legolas", hero.Name);
        }

        [Fact]
        public void Archer_Creation_DefaultState_LevelSetToOne()
        {
            var hero = new Archer("Legolas");
            Assert.Equal(1, hero.Level);
        }

        [Fact]
        public void Archer_LevelUp_IncrementsLevel()
        {
            // ARRANGE
            const string archerName = "Legolas";
            var hero = new Archer(archerName);

            // ACT
            hero.LevelUp();

            // ASSERT
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Archer_LevelUp_StrengthAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string archerName = "Legolas";
            var hero = new Archer(archerName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedStrength = 2;
            Assert.Equal(expectedStrength, attributesAfterLevelUp.Strength);
        }

        [Fact]
        public void Archer_LevelUp_DexterityAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string archerName = "Legolas";
            var hero = new Archer(archerName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedDexterity = 6;
            Assert.Equal(expectedDexterity, attributesAfterLevelUp.Dexterity);
        }

        [Fact]
        public void Archer_LevelUp_IntelligenceAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string archerName = "Legolas";
            var hero = new Archer(archerName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedIntelligence = 13;
            Assert.Equal(expectedIntelligence, attributesAfterLevelUp.Intelligence);
        }
    }
}
