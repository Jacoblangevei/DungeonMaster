using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Heroes
{
    using DungeonMaster.Attributes;
    using DungeonMaster.Equipment;
 
    public class Barbarian : Hero
    {
        protected override List<WeaponType> ValidWeaponTypes => new List<WeaponType> 
        { 
            WeaponType.Hatchet, 
            WeaponType.Mace, 
            WeaponType.Sword 
        };
        protected override List<ArmorType> ValidArmorTypes => new List<ArmorType> 
        { 
            ArmorType.Mail, 
            ArmorType.Plate 
        };

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
