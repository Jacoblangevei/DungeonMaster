using DungeonMaster.Equipment;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonMaster.Attributes;
using System;
using static DungeonMaster.Equipment.Item;

namespace DungeonMaster.Heroes
    {
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
        public int Level { get; set; }
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

        public virtual void LevelUp()
        {
            Level++;
        }

        public void Equip(Weapon weapon)
        {
            if (Level < weapon.RequiredLevel)
                throw new InvalidWeaponException("Level too low to equip this weapon!");

            if (!ValidWeaponTypes.Contains(weapon.Type))
                throw new InvalidWeaponException("This hero cannot equip this type of weapon!");

            Equipment[Slot.Weapon] = weapon;
        }

        public void Equip(Armor armor)
        {
            if (Level < armor.RequiredLevel)
                throw new InvalidArmorException("Level too low to equip this armor!");

            if (!ValidArmorTypes.Contains(armor.Type))
                throw new InvalidArmorException("This hero cannot equip this type of armor!");

            Equipment[armor.Slot] = armor;
        }

        public int Damage()
        {
            int baseDamage = (Equipment[Slot.Weapon] as Weapon)?.WeaponDamage ?? 1;

            HeroAttribute totalAttr = TotalAttributes(); // 

            int damageAttribute = 0;

            if (this is Barbarian)
                damageAttribute = totalAttr.Strength;
            else if (this is Wizard)
                damageAttribute = totalAttr.Intelligence;
            else if (this is Archer || this is Swashbuckler)
                damageAttribute = totalAttr.Dexterity;

            int totalDamage = (int)(baseDamage * (1 + damageAttribute / 100.0));

            return totalDamage;
        }

        public HeroAttribute TotalAttributes()
        {
            var totalAttributes = LevelAttributes;

            foreach (var item in Equipment.Values)
            {
                if (item is Armor armorItem)
                    totalAttributes += armorItem.ArmorAttribute;
            }

            return totalAttributes;
        }

        public virtual string Display()
        {
            var totalAttr = TotalAttributes(); 

            StringBuilder displayInfo = new StringBuilder();
            displayInfo.AppendLine($"Name: {Name}");
            displayInfo.AppendLine($"Class: {GetType().Name}"); // Gets the actual class name (e.g. Archer, Wizard, etc.)
            displayInfo.AppendLine($"Level: {Level}");
            displayInfo.AppendLine($"Total Strength: {totalAttr.Strength}");
            displayInfo.AppendLine($"Total Dexterity: {totalAttr.Dexterity}");
            displayInfo.AppendLine($"Total Intelligence: {totalAttr.Intelligence}");
            displayInfo.AppendLine($"Damage: {Damage()}"); 

            return displayInfo.ToString();
        }
    }
}
