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
            _name = name;
            _race = race;
            _hp = hp;
            _lvl = lvl;
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
            return $"{_name} - {_race} - {_hp} - Inventory: {string.Join(", ", inventory.Select(e => e._weaponname))}";
        }
        public void PlayerCustomize()
        {
            string Input;
            Console.WriteLine("Make your Hero!");

            Console.Write("Name:");
            

            _name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Race");
            Console.WriteLine("1) Human");
            Console.WriteLine("2) Elf");
            Console.WriteLine("3) Orc");
            Console.WriteLine("4) Dwarf");
            Console.WriteLine("5) Goblin");



            string GetRace = Console.ReadLine();

            switch (GetRace)
            {
                case "1":
                    Information InformationHuman = new Information();
                    InformationHuman.Human();
                    Console.WriteLine("Is this your hero?");
                    Console.WriteLine("y/n");

                    Input = Console.ReadLine();

                    if (Input == "y")
                    {
                        _race = "Human";
                        _hp = 280;
                        _lvl = 1;
                        
                    }
                    else if (Input == "n")
                    {
                        Console.Clear();
                        PlayerCustomize();
                    }
                    break;

                case "2":
                    Information InformationElf = new Information();
                    InformationElf.Elf();     
                    Console.WriteLine("Is this your hero?");
                    Console.WriteLine("y/n");

                    Input = Console.ReadLine();

                    if (Input == "y")
                    {
                        _race = "Elf";
                        _hp = 180;
                        _lvl = 1;
                        
                    }
                    else if (Input == "n")
                    {
                        Console.Clear();
                        PlayerCustomize();
                    }
                    break;


                case "3":
                    Information InformationOrc = new Information();
                    InformationOrc.Orc();
                    Console.WriteLine("Is this your hero?");
                    Console.WriteLine("y/n");

                    Input = Console.ReadLine();

                    if (Input == "y")
                    {
                        _race = "Orc";
                        _hp = 340;
                        _lvl = 1;
                        
                    }
                    else if (Input == "n")
                    {
                        Console.Clear();
                        PlayerCustomize();
                    }
                    
                    break;
                    

                case "4":
                    Information InformationDwarf = new Information();
                    InformationDwarf.Dwarf();
                    Console.WriteLine("Is this your hero?");
                    Console.WriteLine("y/n");

                    Input = Console.ReadLine();

                    if (Input == "y")
                    {
                        _race = "Dwarf";
                        _hp = 300;
                        _lvl = 1;
                        
                    }
                    else if (Input == "n")
                    {
                        Console.Clear();
                        PlayerCustomize();
                    }
                    break;
                      

                case "5":
                    Information InformationGoblin = new Information();
                    InformationGoblin.Goblin();
                    Console.WriteLine("Is this your hero?");
                    Console.WriteLine("y/n");

                    Input = Console.ReadLine();

                    if (Input == "y")
                    {
                        _race = "Goblin";
                        _hp = 140;
                        _lvl = 1;
                        
                    }
                    else if (Input == "n")
                    {
                        Console.Clear();
                        PlayerCustomize();
                    }
                    break;
                
            }
        }
    }
}
