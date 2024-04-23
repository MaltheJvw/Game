using System.Dynamic;
using System.Security.Cryptography.X509Certificates;


namespace Game
{
    internal class Program : Base
    {
       
        static void Main(string[] args)
        {

            Player PC = new Player();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("╔══════════════════════════════════════════════════════════════════════╗");
            Console.WriteLine("║                A Very Normal Adventure - Totally Rad Edition!             ║");
            Console.WriteLine("╚══════════════════════════════════════════════════════════════════════╝");
            Console.ResetColor();
            Console.WriteLine("1: Start\n\n2: How to");

            string Menu = Console.ReadLine();

            switch(Menu)
            {
                case "1":
                    PC.PlayerCustomize();
                    break;
  
                default:
                    break;
            }
        }
        
    }
}
