using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonMaster.Attributes;
using DungeonMaster.Equipment;
using System.Collections.Generic;

namespace DungeonMaster.Heroes
{
    public class Archer : Hero
    {
        protected override List<WeaponType> ValidWeaponTypes => new List<WeaponType> { WeaponType.Bow };
        protected override List<ArmorType> ValidArmorTypes => new List<ArmorType> { ArmorType.Leather, ArmorType.Mail };

        public Archer(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(1, 7, 1); // Initial attributes for Archer
        }
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes += new HeroAttribute(1, 5, 1); // Increase attributes for each level up
        }
        public override string Display()
        {
            return "";
        }
    }
}
