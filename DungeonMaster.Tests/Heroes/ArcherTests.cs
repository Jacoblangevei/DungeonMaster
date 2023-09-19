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
            var expectedDexterity = 12;
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
            var expectedIntelligence = 2;
            Assert.Equal(expectedIntelligence, attributesAfterLevelUp.Intelligence);
        }

        [Fact]
        public void Archer_DamageNoWeapon_EqualBaseDamage()
        {
            // ARRANGE
            var hero = new Archer("Legolas");
            double expectedDamage = 1 * (1 + 5 / 99); 

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Archer_DamageWithWeapon_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Archer("Legolas");
            var bow = new Weapon("Wooden Bow", 1, WeaponType.Bow, 2); 
            hero.Equip(bow);
            double expectedDamage = 2 * (1 + 5 / 99);  

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Archer_DamageWithWeaponAndArmor_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Archer("Legolas");
            var bow = new Weapon("Wooden Bow", 1, WeaponType.Bow, 2);
            var leatherArmor = new Armor("Leather Chest", 1, Slot.Body, ArmorType.Leather, new HeroAttribute(0, 1, 0));
            hero.Equip(bow);
            hero.Equip(leatherArmor);
            double expectedDamage = 2 * (1 + (5 + 1) / 99); 

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

    }
}
