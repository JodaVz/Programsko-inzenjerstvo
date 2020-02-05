using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_1_CClass
{
    class Izracunaj
    {
        public static List<int> Izracunajbroj(TriBroja b) {
            List<int> lista = new List<int>();
            for (int i = b.PrviBroj; i <= b.DrugiBroj; i++)
            {
                if (i % b.TreciBroj == 0)
                {
                    lista.Add(i);
                }

            }
            return lista;
        }
    }
}
