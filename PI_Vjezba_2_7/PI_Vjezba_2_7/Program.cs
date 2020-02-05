using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_2_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pravokutnik> listaP = new List<Pravokutnik>();
            listaP = Pravokutnik.Upis();
            Pravokutnik.Ispis(listaP);

        }
    }
}
