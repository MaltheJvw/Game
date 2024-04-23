using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game
{
    internal class NPC : Base
    {
        public enum NPCType
        {
            Human,
            Elf,
            Orc,
            Dwarf,
            Goblin
        }
        public NPC(string name, int hp, int xp, NPCType type)
        {
            _name = name;
            _hp = hp;
            _xp = xp;
            Type = type;
        }
        public NPCType Type { get; set; }
        public int _xp { get; set; }

        public override string ToString()
        {
            return $"NPCName: {_name} HealthPoints : {_hp} XP: {_xp} Race: {Type} ";
        }
    }
}
