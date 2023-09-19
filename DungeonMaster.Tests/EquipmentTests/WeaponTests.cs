using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Heroes;
using Xunit;

namespace DungeonMaster.Tests.EquipmentTests
{
    public class WeaponTests
    {
        //Common Hatchet Tests
        [Fact]
        public void Weapon_Creation_Hatchet_CorrectName()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal("Common Hatchet", weapon.Name);
        }

        [Fact]
        public void Weapon_Creation_Hatchet_CorrectRequiredLevel()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal(1, weapon.RequiredLevel);
        }

        [Fact]
        public void Weapon_Creation_Hatchet_CorrectSlot()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal(Slot.Weapon, weapon.Slot);
        }

        // Wooden Wand Tests
        [Fact]
        public void Weapon_Creation_WoodenWand_CorrectName()
        {
            var weapon = new Weapon("Wooden Wand", 1, WeaponType.Wand, 2);
            Assert.Equal("Wooden Wand", weapon.Name);
        }

        [Fact]
        public void Weapon_Creation_WoodenWand_CorrectRequiredLevel()
        {
            var weapon = new Weapon("Wooden Wand", 1, WeaponType.Wand, 2);
            Assert.Equal(1, weapon.RequiredLevel);
        }

        [Fact]
        public void Weapon_Creation_WoodenWand_CorrectSlot()
        {
            var weapon = new Weapon("Wooden Wand", 1, WeaponType.Wand, 2);
            Assert.Equal(Slot.Weapon, weapon.Slot);
        }

        // Iron Sword Tests
        [Fact]
        public void Weapon_Creation_IronSword_CorrectName()
        {
            var weapon = new Weapon("Iron Sword", 1, WeaponType.Sword, 3);
            Assert.Equal("Iron Sword", weapon.Name);
        }

        [Fact]
        public void Weapon_Creation_IronSword_CorrectRequiredLevel()
        {
            var weapon = new Weapon("Iron Sword", 1, WeaponType.Sword, 3);
            Assert.Equal(1, weapon.RequiredLevel);
        }

        [Fact]
        public void Weapon_Creation_IronSword_CorrectSlot()
        {
            var weapon = new Weapon("Iron Sword", 1, WeaponType.Sword, 3);
            Assert.Equal(Slot.Weapon, weapon.Slot);
        }

        //Wooden Bow Tests
        [Fact]
        public void Weapon_Creation_WoodenBow_CorrectName()
        {
            var weapon = new Weapon("Wooden Bow", 1, WeaponType.Bow, 2);
            Assert.Equal("Wooden Bow", weapon.Name);
        }

        [Fact]
        public void Weapon_Creation_WoodenBow_CorrectRequiredLevel()
        {
            var weapon = new Weapon("Wooden Bow", 1, WeaponType.Bow, 2);
            Assert.Equal(1, weapon.RequiredLevel);
        }

        [Fact]
        public void Weapon_Creation_WoodenBow_CorrectSlot()
        {
            var weapon = new Weapon("Wooden Bow", 1, WeaponType.Bow, 2);
            Assert.Equal(Slot.Weapon, weapon.Slot);
        }

        //Iron Dagger Tests
        [Fact]
        public void Weapon_Creation_IronDagger_CorrectName()
        {
            var weapon = new Weapon("Iron Dagger", 1, WeaponType.Dagger, 2);
            Assert.Equal("Iron Dagger", weapon.Name);
        }

        [Fact]
        public void Weapon_Creation_IronDagger_CorrectRequiredLevel()
        {
            var weapon = new Weapon("Iron Dagger", 1, WeaponType.Dagger, 2);
            Assert.Equal(1, weapon.RequiredLevel);
        }

        [Fact]
        public void Weapon_Creation_IronDagger_CorrectSlot()
        {
            var weapon = new Weapon("Iron Dagger", 1, WeaponType.Dagger, 2);
            Assert.Equal(Slot.Weapon, weapon.Slot);
        }
    }
}
