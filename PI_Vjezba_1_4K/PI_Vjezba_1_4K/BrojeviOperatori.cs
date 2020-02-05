using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_4K
{
    class BrojeviOperatori
    {
        public int prviBroj { get; set; }
        public int drugiBroj { get; set; }
        public string znak { get; set; }


        public static BrojeviOperatori Upis()
        {
            BrojeviOperatori brojevi = new BrojeviOperatori();
            Console.WriteLine("Upisite prvi broj");
            brojevi.prviBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisite drugi broj");
            brojevi.drugiBroj = int.Parse(Console.ReadLine());
            return brojevi;
        }



        public static string Odabir()
        {
            BrojeviOperatori oznaka = new BrojeviOperatori();
            Console.WriteLine("Odabire jedan od ponuđenih operatora + - * /");
            oznaka.znak = Console.ReadLine();
            return oznaka.znak;

        }

        

        public static void Izracun(int prviBroj, int drugiBroj, string odabir)
        {
            BrojeviOperatori brojevi = new BrojeviOperatori();
            brojevi.prviBroj = prviBroj;
            brojevi.drugiBroj = drugiBroj;
            brojevi.znak = odabir;
            if (brojevi.znak == "+") Console.WriteLine("Odabrali ste zbrajanje, rezultat je : " + (brojevi.prviBroj + brojevi.drugiBroj));
            if (brojevi.znak == "-") Console.WriteLine("Odabrali ste oduzimanje, rezultat je : " + (brojevi.prviBroj - brojevi.drugiBroj));
            if (brojevi.znak == "*") Console.WriteLine("Odabrali ste mnozenje, rezultat je : " + (brojevi.prviBroj * brojevi.drugiBroj));
            if (brojevi.znak == "/") Console.WriteLine("Odabrali ste djeljenje, rezultat je : " + (brojevi.prviBroj / brojevi.drugiBroj));
            Console.ReadKey();


        }

    }
}
