using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_1_3K
{
    class Program
    {
        static void Main(string[] args)
        {
            Brojevi broj = new Brojevi();
            //broj = Brojevi.Upis2();
            // Console.WriteLine("Konačan rezultat je :" +broj.desetice+broj.jedinice);
            broj.Upis();
            Console.ReadKey();
        }
    }
}
