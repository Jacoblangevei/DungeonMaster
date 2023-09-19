using DungeonMaster.Attributes;
using System;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DungeonMaster.Equipment;
using System.Collections.Generic;

namespace DungeonMaster.Heroes
{
    public class Wizard : Hero
    {
        // Wizard can use Staff and Wand
        protected override List<WeaponType> ValidWeaponTypes => new List<WeaponType> 
        { 
            WeaponType.Staff, 
            WeaponType.Wand 
        };

        // Wizard can use Cloth
        protected override List<ArmorType> ValidArmorTypes => new List<ArmorType> 
        { 
            ArmorType.Cloth 
        };

        // Str: 1, Dex: 1, Int: 8
        public Wizard(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(1, 1, 8); // Initial attributes for Wizard
        }
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes += new HeroAttribute(1, 1, 5); // Increase attributes for each level up
        }

        public override string Display()
        {
            return "";
        }
    }

}
