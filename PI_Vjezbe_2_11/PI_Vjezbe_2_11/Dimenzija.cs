using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_11
{
    class Dimenzija
    {
        public int Visina { get; set; }
        public int Sirina { get; set; }
        public int trenutnaVisina { get; set; }
        public int trenutnaSirina { get; set; }
        public Dimenzija()
        {
            Console.WriteLine("Unesite visinu prozora");
            this.Visina = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite sirinu prozora");
            this.Sirina = int.Parse(Console.ReadLine());
        }

    }
}
