using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Heroes
{
    using DungeonMaster.Attributes;
    using DungeonMaster.Equipment;

    public class Swashbuckler : Hero
    {
        protected override List<WeaponType> ValidWeaponTypes => new List<WeaponType>
        {
            WeaponType.Dagger,
            WeaponType.Sword
        };
        protected override List<ArmorType> ValidArmorTypes => new List<ArmorType>
        {
            ArmorType.Leather,
            ArmorType.Mail
        };

        public Swashbuckler(string name) : base(name)
        {
            LevelAttributes = new HeroAttribute(2, 6, 1); // Initial attributes for Swashbuckler
        }
        public override void LevelUp()
        {
            Level += 1;
            LevelAttributes += new HeroAttribute(1, 4, 1); // Increase attributes for each level up
        }
        public override string Display()
        {
            // Work in progress
            return "";
        }
    }
}