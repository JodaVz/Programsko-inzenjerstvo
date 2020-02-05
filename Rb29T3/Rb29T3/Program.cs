using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rb29T3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pravokutnik> listaPrav = Pravokutnik.Upis();
            Pravokutnik.Ispis(listaPrav);
        }
    }
}
