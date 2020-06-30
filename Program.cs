using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void PrintGame(Game g)
        {
            Console.WriteLine(g._name);
            Console.WriteLine(g);
        }
        


        static void Main(string[] args)
        {
            Game sims = new Game();
            Console.WriteLine(sims);
            Game fifa = new Game("fifa2018", 5.5f);
            Console.WriteLine(fifa);
            Game gta = new Game("GTA5", 4, 6.87f, "USA");
            Console.WriteLine(gta);
            Game sonic = new Game("Sonic", "USA");
            Console.WriteLine(sonic);
            





        }

    }
}
   