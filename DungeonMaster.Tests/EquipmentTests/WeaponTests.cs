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
        public void Weapon_Creation_CorrectName()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal("Common Hatchet", weapon.Name);
        }

        [Fact]
        public void Weapon_Creation_CorrectRequiredLevel()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal(1, weapon.RequiredLevel);
        }

        [Fact]
        public void Weapon_Creation_CorrectSlot()
        {
            var weapon = new Weapon("Common Hatchet", 1, WeaponType.Hatchet, 2);
            Assert.Equal(Slot.Weapon, weapon.Slot);
        }
    }
}
