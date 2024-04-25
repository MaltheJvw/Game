using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    internal class Base
    {

        //Properties bruges ved DTO'er Data Transfer Object 
        public string Race {  get; set; }
  
        public string Name {  get; set; } //Auto generet propery med hiddet fielt 
        public int Hp {  get; set; }

        public int Lvl { get; set; }
        
    }
}
