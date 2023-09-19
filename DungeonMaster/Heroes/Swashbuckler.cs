using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DungeonMaster.Attributes;
using DungeonMaster.Equipment;

namespace DungeonMaster.Heroes
{
    public class Swashbuckler : Hero
    {
        // Swashbuckler can use Dagger and Sword
        protected override List<WeaponType> ValidWeaponTypes => new List<WeaponType>
        {
            WeaponType.Dagger,
            WeaponType.Sword
        };

        // Swashbuckler can use Leather and Mail
        protected override List<ArmorType> ValidArmorTypes => new List<ArmorType>
        {
            ArmorType.Leather,
            ArmorType.Mail
        };

        // Str: 2, Dex: 6, Int: 1
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
            return "";
        }
    }
}