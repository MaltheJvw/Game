using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game
{
    internal class Player : Base
    {

        public Player()
        {
            
            
        }
        public Player(string name, string race, int hp, int lvl)
        {
            Name = name;
            Race = race;
            Hp = hp;
            Lvl = lvl;
            inventory = new List<Equipment>();
        }

        private List<Equipment> inventory = new();
        public List<Equipment> Inventory
        {
            get { return inventory; }
        }
        public void AddEquipment(Equipment equipment)
        {
            inventory.Add(equipment);
        }

        public override string ToString()
        {
            return $"{Name} - {Race} - {Hp} - Inventory: {string.Join(", ", inventory.Select(e => e._weaponname))}";
        }
    }
}
