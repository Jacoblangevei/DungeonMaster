﻿using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonMaster.Attributes;
using DungeonMaster.Equipment;

namespace DungeonMaster.Heroes
{
    public class Barbarian : Hero
    {
        // Barbarian can use Hatchet, Mace, and Sword
        protected override List<WeaponType> ValidWeaponTypes => new List<WeaponType> 
        { 
            WeaponType.Hatchet, 
            WeaponType.Mace, 
            WeaponType.Sword 
        };

        // Barbarian can use Mail and Plate
        protected override List<ArmorType> ValidArmorTypes => new List<ArmorType> 
        { 
            ArmorType.Mail, 
            ArmorType.Plate 
        };

        // Str: 5, Dex: 2, Int: 1
        public Barbarian(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(5, 2, 1); // Initial attributes for Barbarian
        }
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes += new HeroAttribute(3, 2, 1); // Increase attributes for each level up
        }
        public override string Display()
        {
            return "";
        }
    }
}
