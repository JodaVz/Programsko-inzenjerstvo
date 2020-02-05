using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kamate> listaK = new List<Kamate>();
            
            listaK=Kamate.Upis();
            Kamate.Ispis(listaK);
            Console.ReadKey();
            
        }
    }
}
