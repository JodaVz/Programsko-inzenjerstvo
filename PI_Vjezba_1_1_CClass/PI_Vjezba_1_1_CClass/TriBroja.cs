using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_1_CClass
{
    class TriBroja
    {
        public int PrviBroj { get; set; }
        public int DrugiBroj { get; set; }
        public int TreciBroj { get; set; }
        public static TriBroja Unos() {
            TriBroja broj = new TriBroja();
            Console.WriteLine("Unesite doljnju granicu");
            broj.PrviBroj=int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite gornju granicu");
            broj.DrugiBroj = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite djeljitelj");
            broj.TreciBroj = int.Parse(Console.ReadLine());
            return broj;
        }
    }
}
