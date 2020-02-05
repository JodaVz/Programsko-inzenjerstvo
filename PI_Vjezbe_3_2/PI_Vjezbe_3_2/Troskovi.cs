using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_2
{
    class Troskovi
    {
        public float VrijednostTroska { get; set; }
        public string NazivTroska { get; set; }
        public Troskovi()
        {
            Console.WriteLine("Upišite ime troška: ");
            this.NazivTroska = Console.ReadLine();
            Console.WriteLine("Upišite vrijednost troška: ");
            this.VrijednostTroska = int.Parse(Console.ReadLine());
        }
        public static void Ispis(List<Troskovi> lista)
        {
            foreach (Troskovi item in lista)
            {
                Console.WriteLine("Kupili ste " + item.NazivTroska + " u vrijednosti od " + item.VrijednostTroska);
               
            }
            //fali pretraga nije mi jasno kaj je lik htel bas u programu, al nije biggy

        }
    }
}
