using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite zeljeni tekst: \n");
            string zeljeniTekst=Console.ReadLine();
            Console.WriteLine("Unesite broj ponavljanja teksta: ");
            int brojPonavljanja= int.Parse(Console.ReadLine());
            for (int i = 1; i <= brojPonavljanja; i++)
            {
                Console.WriteLine(zeljeniTekst);
            }
            Console.ReadKey();
        }
    }
}
