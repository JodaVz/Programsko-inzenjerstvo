using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite prvi broj: ");
            int prviBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            int drugiBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Odaberite jedan od ponuđenih operatora (+ - * /)");
            string odabir = Console.ReadLine();
            int odabrano = 0;
            if (odabir == "+") odabrano = 1;
            if (odabir == "-") odabrano = 2;
            if (odabir == "*") odabrano = 3;
            if (odabir == "/") odabrano = 4;
            
            switch (odabrano)
            {
                case 1:
                    Console.WriteLine("Odabrali ste zbrajanje: " + (prviBroj + drugiBroj));
                    break;
                case 2:
                    Console.WriteLine("Odabrali ste oduzimanje: " + (prviBroj - drugiBroj));
                    break;
                case 3:
                    Console.WriteLine("Odabrali ste mnozenje: " + (prviBroj * drugiBroj));
                    break;
                case 4:
                    Console.WriteLine("Odabrali ste djeljenje: " + (prviBroj / drugiBroj));
                    break;
                default:
                    break;
            }
            Console.ReadKey();

        }
    }
}
