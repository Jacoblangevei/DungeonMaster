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
            var expectedStrength = 3;
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
            var expectedDexterity = 10;
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
            var expectedIntelligence = 2;
            Assert.Equal(expectedIntelligence, attributesAfterLevelUp.Intelligence);
        }

        [Fact]
        public void Swashbuckler_DamageNoWeapon_EqualBaseDamage()
        {
            // ARRANGE
            var hero = new Swashbuckler("Jack Sparrow");
            double expectedDamage = 1 * (1 + 5 / 99); 

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Swashbuckler_DamageWithDagger_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Swashbuckler("Jack Sparrow");
            var dagger = new Weapon("Iron Dagger", 1, WeaponType.Dagger, 2); 
            hero.Equip(dagger);
            double expectedDamage = 2 * (1 + 5 / 99); 

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Swashbuckler_DamageWithSword_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Swashbuckler("Jack Sparrow");
            var sword = new Weapon("Iron Sword", 1, WeaponType.Sword, 3);  
            hero.Equip(sword);
            double expectedDamage = 3 * (1 + 5 / 99); 

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Swashbuckler_DamageWithWeaponAndLeatherArmor_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Swashbuckler("Jack ");
            var dagger = new Weapon("Iron Dagger", 1, WeaponType.Dagger, 2);
            var leatherArmor = new Armor("Leather Pants", 1, Slot.Legs, ArmorType.Leather, new HeroAttribute(0, 1, 0));
            hero.Equip(dagger);
            hero.Equip(leatherArmor);
            double expectedDamage = 2 * (1 + (5 + 1) / 99);  

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

        [Fact]
        public void Swashbuckler_DamageWithWeaponAndMailArmor_EqualIncreasedDamage()
        {
            // ARRANGE
            var hero = new Swashbuckler("Jack Sparrow");
            var sword = new Weapon("Iron Sword", 1, WeaponType.Sword, 3);
            var mailArmor = new Armor("Mail Chestplate", 1, Slot.Body, ArmorType.Mail, new HeroAttribute(2, 0, 0));
            hero.Equip(sword);
            hero.Equip(mailArmor);
            double expectedDamage = 3 * (1 + (5 + 2) / 99);

            // ACT
            var actualDamage = hero.Damage();

            // ASSERT
            Assert.Equal(expectedDamage, actualDamage);
        }

    }
}
