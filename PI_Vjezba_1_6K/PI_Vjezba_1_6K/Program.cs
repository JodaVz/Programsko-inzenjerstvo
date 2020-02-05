using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_6K
{
    class Program
    {
        static void Main(string[] args)
        {

            Brojevi broj = new Brojevi();
            broj.prviBroj=broj.Unos();
            broj.Izracun(broj.prviBroj);
            Console.ReadKey();
        }
    }
}
