using DungeonMaster.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMaster.Equipment
{
    public abstract class Item
    {
        public string Name { get; protected set; }
        public int RequiredLevel { get; protected set; }
        public Slot Slot { get; protected set; }
    }

    public enum Slot
    {
        Weapon, 
        Head, 
        Body, 
        Legs
    }
}
