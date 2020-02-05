using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjeliteljVisekratnik
{
    class Program
    {
        static void Main(string[] args)
        {

            Brojevi broj = new Brojevi();
            while (true)
            {
                broj = broj.Upis();
           


                broj.Djelitelj(broj.prviBroj, broj.drugiBroj);
                broj.Visekratnik(broj.prviBroj, broj.drugiBroj);
            }



        }
    }
}
