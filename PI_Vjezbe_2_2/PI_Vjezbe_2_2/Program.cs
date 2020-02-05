using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Brojevi broj = new Brojevi();
         
         //   broj.poljeBrojeva = broj.Upis();
           // broj.Ispis(broj.poljeBrojeva);

            broj.listaBrojeva = broj.UpisLista();
            broj.IspisListe(broj.listaBrojeva);
            Console.ReadKey();


        }
    }
}
