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
            var hero = new Wizard("Conan");
            Assert.Equal("Conan", hero.Name);
        }

        [Fact]
        public void Barbarian_Creation_DefaultState_LevelSetToOne()
        {
            var hero = new Wizard("Conan");
            Assert.Equal(1, hero.Level);
        }

        [Fact]
        public void Barbarian_LevelUp_IncrementsLevel()
        {
            var hero = new Wizard("Conan");
            hero.LevelUp();
            Assert.Equal(2, hero.Level);
        }

        [Fact]
        public void Barbarian_LevelUp_StrengthAttributeCorrectlyIncremented()
        {
            var hero = new Barbarian("Conan");
            hero.LevelUp();
            Assert.Equal(2, hero.TotalAttributes().Strength);
        }

        [Fact]
        public void Barbarian_LevelUp_DexterityAttributeCorrectlyIncremented()
        {
            var hero = new Barbarian("Conan");
            hero.LevelUp();
            Assert.Equal(10, hero.TotalAttributes().Dexterity);
        }

        [Fact]
        public void Barbarian_LevelUp_IntelligenceAttributeCorrectlyIncremented()
        {
            var hero = new Barbarian("Conan");
            hero.LevelUp();
            Assert.Equal(2, hero.TotalAttributes().Intelligence);
        }

        [Fact]
        public void Barbarian_DamageNoWeapon_EqualBaseDamage()
        {
            var hero = new Barbarian("Conan");
            double expectedDamage = 1 * (1 + 5 / 100.0);
            Assert.Equal(expectedDamage, hero.Damage());
        }

        [Fact]
        public void Barbarian_DamageWithWeapon_EqualIncreasedDamage()
        {
            var hero = new Barbarian("Conan");
            var hatchet = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            hero.Equip(hatchet);
            double expectedDamage = 2 * (1 + 5 / 100.0);
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
            double expectedDamage = 2 * (1 + (5 + 1) / 100.0);
            Assert.Equal(expectedDamage, hero.Damage());
        }
    }
}
