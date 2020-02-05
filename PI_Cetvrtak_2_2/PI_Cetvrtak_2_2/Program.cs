using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Cetvrtak_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<StanjeRacuna> listaRacuna = StanjeRacuna.Upis();
            StanjeRacuna.Ispis(listaRacuna);
            Console.ReadKey();

        }
    }
}
