﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Human : Player
    {
        public Human(string name) : base()
        {
            Name = name;
            Race = "Human";
            Hp = 100;
            Lvl = 1;
        } 


    }
}
