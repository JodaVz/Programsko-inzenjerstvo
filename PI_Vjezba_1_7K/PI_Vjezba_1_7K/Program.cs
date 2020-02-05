using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_7K
{
    class Program
    {
        static void Main(string[] args)
        {
            BrojeviTekst objekt = new BrojeviTekst();
            objekt.boja = objekt.OdabirBoje();
            objekt.tekst = objekt.UpisTeksta();
            objekt.Ispis(objekt.boja, objekt.tekst);
            Console.ReadKey();


        }
    }
}
