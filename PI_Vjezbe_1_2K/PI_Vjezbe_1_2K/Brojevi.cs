using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_1_2K
{
    class Brojevi
    {
        public int prviBroj { get; set; }
        public int drugiBroj { get; set; }
        public int veciBroj { get; set; }
        public int manjiBroj { get; set; }


        public  int ProvjeraVeci(int prviB,int drugiB)
        {
            Brojevi b = new Brojevi();
            if (prviB > drugiB) {
                b.veciBroj = prviB;
                b.manjiBroj = drugiB;
            }
            if (prviB < drugiB) {
                b.manjiBroj = prviB;
                b.veciBroj = drugiB;
            }
            return b.veciBroj;
        }
        public  int ProvjeraManji(int prviB, int drugiB)
        {
            Brojevi b = new Brojevi();
            if (prviB > drugiB)
            {
                b.veciBroj = prviB;
                b.manjiBroj = drugiB;
            }
            if (prviB < drugiB)
            {
                b.manjiBroj = prviB;
                b.veciBroj = drugiB;
            }
            return b.manjiBroj;
        }
        public  void Ispis(int prviB, int drugiB) {
            for (int i = prviB; i <= drugiB; i++)
            {
                Console.WriteLine("Broj: " + i);
            }
            Console.ReadKey();
        }
    }
}
