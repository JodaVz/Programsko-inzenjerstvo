using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_1
{
    class Brojevi
    {
        public float prviBroj { get; set; }
        public float drugiBroj { get; set; }
        public int silaznost { get; set; }
        public float razmak { get; set; }
       
        public Brojevi Upis() {
            Brojevi broj = new Brojevi();
            Console.WriteLine("Upisite prvi broj: ");
            broj.prviBroj = float.Parse(Console.ReadLine());
            Console.WriteLine("Upisite drugi broj: ");
            broj.drugiBroj = float.Parse(Console.ReadLine());
            Console.WriteLine("Odaberite uzlaznost ili silaznost (0 ili 1):");
            broj.silaznost = int.Parse(Console.ReadLine());
            Console.WriteLine("Odaberite razmak između brojeva : ");
            broj.razmak = float.Parse(Console.ReadLine());


            return broj;
        }
        public void Ispis(float prvi, float drugi, int odabir, float razmak)
        {
            Brojevi broj = new Brojevi();
            broj.prviBroj = prvi;
            broj.drugiBroj = drugi;
            broj.silaznost = odabir;
            broj.razmak = razmak;
            if (broj.silaznost == 0)
            {


                for (float i = broj.prviBroj; i < broj.drugiBroj; i = i + razmak)
                {
                    Console.WriteLine("Brojevi su: " + i);
                }
            }
            if (broj.silaznost == 1)
            {
                for (float i = broj.drugiBroj; i > broj.prviBroj; i = i - razmak)
                {
                    Console.WriteLine("Brojevi su: " + i);
                }
            }
        }
    }
}
