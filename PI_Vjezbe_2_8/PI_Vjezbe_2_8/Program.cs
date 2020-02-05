using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Brojevi> lista = new List<Brojevi>();
            lista=Brojevi.Upis();
            Brojevi.Ispis(lista);
            Console.ReadLine();
        }
    }
}
