using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odabirte boju srca: ");
            string odabir = Console.ReadLine();
            if (odabir == "crvena") Console.ForegroundColor = ConsoleColor.Red;
            if (odabir == "plava") Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("    o o.o o   ");
            Console.WriteLine("  o         o      ");
            Console.WriteLine("  o         o       ");
            Console.WriteLine("   o       o         ");
            Console.WriteLine("     o    o       ");
            Console.WriteLine("       o         ");
            Console.ReadKey();
            Console.ResetColor();
            


        }
    }
}
