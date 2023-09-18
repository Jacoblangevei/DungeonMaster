using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Heroes;
using Xunit;

namespace DungeonMaster.Tests.EquipmentTests
{
    public class ArmorTests
    {
        [Fact]
        public void Armor_Creation_ValidName_NameSetCorrectly()
        {
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            Assert.Equal("Common Plate Chest", armor.Name);
        }

        [Fact]
        public void Armor_Creation_ValidRequiredLevel_LevelSetCorrectly()
        {
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            Assert.Equal(1, armor.RequiredLevel);
        }

        [Fact]
        public void Armor_Creation_ValidSlot_SlotSetCorrectly()
        {
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            Assert.Equal(Slot.Body, armor.Slot);
        }

        [Fact]
        public void Armor_Creation_ValidArmorType_ArmorTypeSetCorrectly()
        {
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            Assert.Equal(ArmorType.Plate, armor.Type);
        }

        [Fact]
        public void Armor_Creation_ValidAttributes_AttributesSetCorrectly()
        {
            var expectedAttributes = new HeroAttribute(1, 0, 0);
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, expectedAttributes);
            Assert.Equal(expectedAttributes, armor.ArmorAttribute);
        }
    }

}
