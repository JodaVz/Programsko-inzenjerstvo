using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Brojevi> listaB = new List<Brojevi>();
            listaB = Brojevi.Upis();
            Brojevi.Ispis(listaB);
            Console.ReadKey();
        }
    }
}
