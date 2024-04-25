using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Elf : Player
    {
        public Elf(string name) : base()
        {
            Name = name;
            Race = "Elf";
            Hp = 100;
            Lvl = 1;
        }
    }
}
