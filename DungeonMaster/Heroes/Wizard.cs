using DungeonMaster.Attributes;
using System;
using System.Collections.Generic;
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
        protected override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Staff, WeaponType.Wand };
        protected override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Cloth };

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
