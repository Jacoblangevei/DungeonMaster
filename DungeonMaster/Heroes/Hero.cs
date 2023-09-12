using DungeonMaster.Equipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Heroes
{
    using DungeonMaster.Attributes;
    using System;
    using System.Collections.Generic;
    using static DungeonMaster.Equipment.Item;

    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException(string message) : base(message) { }
    }

    public class InvalidArmorException : Exception
    {
        public InvalidArmorException(string message) : base(message) { }
    }

    public abstract class Hero
    {
        public string Name { get; private set; }
        public int Level { get; private set; }
        protected HeroAttribute LevelAttributes { get; set; }
        public Dictionary<Slot, Item> Equipment { get; private set; }
        protected abstract List<WeaponType> ValidWeaponTypes { get; }
        protected abstract List<ArmorType> ValidArmorTypes { get; }

        protected Hero(string name)
        {
            Name = name;
            Level = 1;
            LevelAttributes = new HeroAttribute(0, 0, 0);
            Equipment = new Dictionary<Slot, Item>
        {
            {Slot.Weapon, null},
            {Slot.Head, null},
            {Slot.Body, null},
            {Slot.Legs, null}
        };
        }

        public abstract void LevelUp();

        public void Equip(Weapon weapon)
        {
            // Add the weapon equipping logic, throw exception if invalid
        }

        public void Equip(Armor armor)
        {
            // Add the armor equipping logic, throw exception if invalid
        }

        public int Damage()
        {
            // Implement the damage calculation logic
            return 0;
        }

        public HeroAttribute TotalAttributes()
        {
            // Calculate total attributes and return
            return null;
        }

        public abstract string Display();
    }


}
