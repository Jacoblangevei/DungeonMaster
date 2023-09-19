using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Equipment
{
    public enum ArmorType
    {
        Cloth,
        Leather,
        Mail,
        Plate
    }
    
    public class Armor : Item
    {
        public ArmorType Type { get; private set; }
        public HeroAttribute ArmorAttribute { get; private set; }

        // Constructor
        public Armor(string name, int requiredLevel, Slot slot, ArmorType type, HeroAttribute armorAttribute)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = slot;
            Type = type;
            ArmorAttribute = armorAttribute;
        }
    }
    // Custom exception
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException(string message) : base(message) { }
    }
}
