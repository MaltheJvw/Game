using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Game 
{
    internal class Customization : Base
    {
        public Player RaceSelection()
        {
            string Input;
            
            Console.WriteLine("Make your Hero!");

            string playerName = Console.ReadLine();


            Name = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Race");
            Console.WriteLine("1) Human");
            Console.WriteLine("2) Elf");
            Console.WriteLine("3) Orc");
            Console.WriteLine("4) Dwarf");
            Console.WriteLine("5) Goblin");

            string selectedRace = Console.ReadLine();

            Player player = null;

            switch (selectedRace)
            {
                case "1":
                    Information InformationHuman = new Information();
                    InformationHuman.Human();
                    Console.WriteLine("Is this your hero?");
                    Console.WriteLine("y/n");

                    Input = Console.ReadLine();

                    if (Input == "y")
                    {
                        player = new Human(playerName);
                        break;

                    }
                    else if (Input == "n")
                    {
                        Console.Clear();
                        RaceSelection();
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
                        player = new Elf(playerName);
                        break;

                    }
                    else if (Input == "n")
                    {
                        Console.Clear();
                        RaceSelection();
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
                        player = new Elf(playerName);
                        break;

                    }
                    else if (Input == "n")
                    {
                        Console.Clear();
                        RaceSelection();
                    }

                    break;

                default:
                    Console.WriteLine("Invalid selection. Please try again.");
                    break;
            }

            return player;
        }
    }
}
