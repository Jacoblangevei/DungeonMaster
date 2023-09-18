using DungeonMaster.Heroes;
using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using Xunit;

namespace DungeonMaster.Tests.Heroes
{
    public class BarbarianTests
    {
        [Fact]
        public void Barbarian_Creation_ValidName_NameSetCorrectly()
        {
            var hero = new Barbarian("Conan");
            Assert.Equal("Conan", hero.Name);
        }

        [Fact]
        public void Barbarian_Creation_DefaultState_LevelSetToOne()
        {
            var hero = new Barbarian("Conan");
            Assert.Equal(1, hero.Level);
        }

        [Fact]
        public void Barbarian_LevelUp_IncrementsLevel()
        {
            // ARRANGE
            const string barbarianName = "Conan";
            var hero = new Barbarian(barbarianName);

            // ACT
            hero.LevelUp();

            // ASSERT
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Barbarian_LevelUp_StrengthAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string barbarianName = "Conan";
            var hero = new Barbarian(barbarianName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedStrength = 8;
            Assert.Equal(expectedStrength, attributesAfterLevelUp.Strength);
        }

        [Fact]
        public void Barbarian_LevelUp_DexterityAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string barbarianName = "Conan";
            var hero = new Barbarian(barbarianName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedDexterity = 4;
            Assert.Equal(expectedDexterity, attributesAfterLevelUp.Dexterity);
        }

        [Fact]
        public void Barbarian_LevelUp_IntelligenceAttributeCorrectlyIncremented()
        {
            // ARRANGE
            const string barbarianName = "Conan";
            var hero = new Barbarian(barbarianName);

            // ACT
            hero.LevelUp();

            // ASSERT
            var attributesAfterLevelUp = hero.TotalAttributes();
            var expectedIntelligence = 2;
            Assert.Equal(expectedIntelligence, attributesAfterLevelUp.Intelligence);
        }

        [Fact]
        public void Barbarian_DamageNoWeapon_EqualBaseDamage()
        {
            // ARRANGE
            var hero = new Barbarian("Conan");
            double expectedDamage = 1 * (1 + 5 / 99);

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Barbarian_DamageWithWeapon_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Barbarian("Conan");
            var hatchet = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            hero.Equip(hatchet);
            double expectedDamage = 2 * (1 + 5 / 99);

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Barbarian_DamageWithWeaponAndArmor_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Barbarian("Conan");
            var hatchet = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            var plateArmor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            hero.Equip(hatchet);
            hero.Equip(plateArmor);
            double expectedDamage = 2 * (1 + (5 + 1) / 99);

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

    }
}
