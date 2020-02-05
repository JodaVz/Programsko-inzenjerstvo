using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_8
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Upisite zeljeni tekst: ");
            string zeljeniTekst = Console.ReadLine();
            Console.WriteLine("Upisite zeljenu boju teksta:(crvena,plava,zelena");
            string bojaTeksta = Console.ReadLine();
            if (bojaTeksta == "crvena") Console.ForegroundColor = ConsoleColor.Red;
            if (bojaTeksta == "zelena") Console.ForegroundColor = ConsoleColor.Green;
            if (bojaTeksta == "plava") Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(zeljeniTekst);
            Console.ReadKey();
        }
    }
}
