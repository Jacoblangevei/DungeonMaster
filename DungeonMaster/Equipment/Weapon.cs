using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Equipment
{
    // Weapon type enum
    public enum WeaponType
    {
        Hatchet,
        Bow,
        Dagger,
        Mace,
        Staff,
        Sword,
        Wand
    }
    public class Weapon : Item
    {
        public WeaponType Type { get; private set; }
        public int WeaponDamage { get; private set; }

        // Constructor
        public Weapon(string name, int requiredLevel, WeaponType type, int weaponDamage)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Slot = Slot.Weapon;
            Type = type;
            WeaponDamage = weaponDamage;
        }
    }

    // Custom exception
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException(string message) : base(message) { }
    }
}
