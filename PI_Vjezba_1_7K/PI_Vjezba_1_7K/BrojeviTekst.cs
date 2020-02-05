using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_7K
{
    class BrojeviTekst
    {
        public string tekst { get; set; }
        public string boja { get; set; }

        public string OdabirBoje() {
            BrojeviTekst boja = new BrojeviTekst();
            Console.WriteLine("Odaberite jednu od ponuđenih boja ( crvena,zelena,plava) : ");
            boja.boja = Console.ReadLine();
            return boja.boja;
            
        }
        public string UpisTeksta()
        {
            BrojeviTekst tekst = new BrojeviTekst();
            Console.WriteLine("Upišite željeni tekst: ");
            tekst.tekst = Console.ReadLine();
            return tekst.tekst;

        }
        public void Ispis(string boja, string tekst) {
            BrojeviTekst ispis = new BrojeviTekst();
            ispis.boja = boja;
            ispis.tekst = tekst;
            if (ispis.boja == "crvena") Console.ForegroundColor = ConsoleColor.Red;
            if (ispis.boja == "plava") Console.ForegroundColor = ConsoleColor.Blue;
            if (ispis.boja == "zelena") Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(ispis.tekst);
            

        }

    }
}
