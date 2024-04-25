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
            Name = name;
            Hp = hp;
            Xp = xp;
            Type = type;
        }
        public NPCType Type { get; set; }
        public int Xp { get; set; }

        public override string ToString()
        {
            return $"NPCName: {Name} HealthPoints : {Hp} XP: {Xp} Race: {Type} ";
        }
    }
}
