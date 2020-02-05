using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_1_CClass
{
    class Program
    {
        static void Main(string[] args)
        {
            TriBroja tri = TriBroja.Unos();
            List<int> listb = Izracunaj.Izracunajbroj(tri);
            Ispis.IspisBrojeva(listb);




        }
    }
}
