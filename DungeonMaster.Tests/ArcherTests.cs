using DungeonMaster.Heroes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Tests
{
    public class ArcherTests
    {
        [Fact]
        public void Archer_Creation_ValidName_NameSetCorrectly()
        {
            var hero = new Wizard("Legolas");
            Assert.Equal("Legolas", hero.Name);
        }

        [Fact]
        public void Archer_Creation_DefaultState_LevelSetToOne()
        {
            var hero = new Wizard("Legolas");
            Assert.Equal(1, hero.Level);
        }

        [Fact]
        public void Archer_LevelUp_IncrementsLevel()
        {
            var hero = new Wizard("Legolas");
            hero.LevelUp();
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Archer_LevelUp_StrengthAttributeCorrectlyIncremented()
        {
            var hero = new Archer("Legolas");
            hero.LevelUp();
            Assert.Equal(2, hero.TotalAttributes().Strength);
        }

        [Fact]
        public void Archer_LevelUp_DexterityAttributeCorrectlyIncremented()
        {
            var hero = new Archer("Legolas");
            hero.LevelUp();
            Assert.Equal(10, hero.TotalAttributes().Dexterity);
        }

        [Fact]
        public void Archer_LevelUp_IntelligenceAttributeCorrectlyIncremented()
        {
            var hero = new Archer("Legolas");
            hero.LevelUp();
            Assert.Equal(2, hero.TotalAttributes().Intelligence);
        }
    }
}
