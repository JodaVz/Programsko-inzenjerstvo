using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_4K
{
    class Program
    {
        static void Main(string[] args)
        {
            BrojeviOperatori brojevi = new BrojeviOperatori();
            // BrojeviOperatori.Upis();
            while (true)
            {


                brojevi = BrojeviOperatori.Upis();
                Console.WriteLine("Upisali ste sljedece brojeve : " + brojevi.prviBroj + " " + brojevi.drugiBroj);
                brojevi.znak = BrojeviOperatori.Odabir();
                Console.WriteLine("Upisali ste sljedece brojeve : " + brojevi.prviBroj + " " + brojevi.drugiBroj);
                Console.WriteLine("Upisali ste sljedeći operator" + brojevi.znak);
                BrojeviOperatori.Izracun(brojevi.prviBroj, brojevi.drugiBroj, brojevi.znak);
            }

        }
    }
}
