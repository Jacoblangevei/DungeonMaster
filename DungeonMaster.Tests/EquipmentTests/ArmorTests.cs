using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using DungeonMaster.Heroes;
using Xunit;

namespace DungeonMaster.Tests.EquipmentTests
{
    public class ArmorTests
    {
        [Fact]
        //Common Plate Chest Tests
        public void Common_Plate_Chest_Armor_Creation_ValidName_NameSetCorrectly()
        {
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            Assert.Equal("Common Plate Chest", armor.Name);
        }

        [Fact]
        public void Armor_Creation_Plate_Chest_ValidRequiredLevel_LevelSetCorrectly()
        {
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            Assert.Equal(1, armor.RequiredLevel);
        }

        [Fact]
        public void Armor_Creation_Plate_Chest_ValidSlot_SlotSetCorrectly()
        {
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            Assert.Equal(Slot.Body, armor.Slot);
        }

        [Fact]
        public void Armor_Creation_Plate_ChestValidArmorType_ArmorTypeSetCorrectly()
        {
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, new HeroAttribute(1, 0, 0));
            Assert.Equal(ArmorType.Plate, armor.Type);
        }

        [Fact]
        public void Armor_Creation_Plate_ChestValidAttributes_AttributesSetCorrectly()
        {
            var expectedAttributes = new HeroAttribute(1, 0, 0);
            var armor = new Armor("Common Plate Chest", 1, Slot.Body, ArmorType.Plate, expectedAttributes);
            Assert.Equal(expectedAttributes, armor.ArmorAttribute);
        }

        [Fact]
        //Linen robe tests
        public void Linen_Robe_Armor_Creation_ValidName_NameSetCorrectly()
        {
            var armor = new Armor("Linen Robe", 1, Slot.Body, ArmorType.Cloth, new HeroAttribute(0, 0, 1));
            Assert.Equal("Linen Robe", armor.Name);
        }

        //Leather Pants Tests
        [Fact]
        public void Leather_Pants_Armor_Creation_ValidName_NameSetCorrectly()
        {
            var armor = new Armor("Leather Pants", 1, Slot.Legs, ArmorType.Leather, new HeroAttribute(1, 0, 0));
            Assert.Equal("Leather Pants", armor.Name);
        }

        [Fact]
        public void Armor_Creation_Leather_Pants_ValidRequiredLevel_LevelSetCorrectly()
        {
            var armor = new Armor("Leather Pants", 1, Slot.Legs, ArmorType.Leather, new HeroAttribute(1, 0, 0));
            Assert.Equal(1, armor.RequiredLevel);
        }

        [Fact]
        public void Armor_Creation_Leather_Pants_ValidSlot_SlotSetCorrectly()
        {
            var armor = new Armor("Leather Pants", 1, Slot.Legs, ArmorType.Leather, new HeroAttribute(1, 0, 0));
            Assert.Equal(Slot.Legs, armor.Slot);
        }

        [Fact]
        public void Armor_Creation_Leather_Pants_ValidArmorType_ArmorTypeSetCorrectly()
        {
            var armor = new Armor("Leather Pants", 1, Slot.Legs, ArmorType.Leather, new HeroAttribute(1, 0, 0));
            Assert.Equal(ArmorType.Leather, armor.Type);
        }

        [Fact]
        public void Armor_Creation_Leather_Pants_ValidAttributes_AttributesSetCorrectly()
        {
            var expectedAttributes = new HeroAttribute(1, 0, 0);
            var armor = new Armor("Leather Pants", 1, Slot.Legs, ArmorType.Leather, expectedAttributes);
            Assert.Equal(expectedAttributes, armor.ArmorAttribute);
        }
    }
}
