using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            Brojevi broj = new Brojevi();
            broj=broj.Upis();
            broj.Ispis(broj.prviBroj, broj.drugiBroj, broj.silaznost, broj.razmak);
            Console.ReadKey();


        }
    }
}
