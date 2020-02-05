using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrvaWindowsForma
{
    class Brojevi
    {
        public int prviBroj { get; set; }
        public int drugiBroj { get; set; }

        public Brojevi Upis(int prvi,int drugi)
        {
            Brojevi broj = new Brojevi();
            broj.prviBroj = prvi;
            broj.drugiBroj = drugi;
           // Console.WriteLine("Upišite prvi broj: ");
          //  broj.prviBroj = int.Parse();
          //  Console.WriteLine("Upišite drugi broj: ");
           // broj.drugiBroj = int.Parse(Console.ReadLine());

            return (broj);


        }
        public string Djelitelj(int prvi, int drugi)
        {
            Brojevi broj = new Brojevi();
            broj.prviBroj = prvi;
            broj.drugiBroj = drugi;
            int najveciBroj = 0;
            int djeliteljmax = 0;
            int djeliteljmin = 0;
            if (broj.prviBroj < broj.drugiBroj) najveciBroj = broj.drugiBroj;
            if (broj.drugiBroj < broj.prviBroj) najveciBroj = broj.prviBroj;
            for (int i = 2; i < najveciBroj; i++)
            {
                if (broj.prviBroj % i == 0 && broj.drugiBroj % i == 0)
                {
                    djeliteljmin = i;
                    break;
                }

            }
           // Console.WriteLine("Najmanji djelitelj brojeva " + broj.prviBroj + " i " + broj.drugiBroj + " je " + djeliteljmin);
            for (int i = 1; i < najveciBroj; i++)
            {
                if (broj.prviBroj % i == 0 && broj.drugiBroj % i == 0)
                {
                    djeliteljmax = i;


                }

            }
            return("Najmanji djelitelj brojeva " + broj.prviBroj + " i " + broj.drugiBroj + " je " + djeliteljmin+"Najveci djelitelj brojeva " + broj.prviBroj + " i " + broj.drugiBroj + " je " + djeliteljmax);



        }

        public string Visekratnik(int prvi, int drugi)

        {
            Brojevi broj = new Brojevi();
            broj.prviBroj = prvi;
            broj.drugiBroj = drugi;
            int najveciBroj = broj.prviBroj * broj.drugiBroj;
            int visekratnik = 0;
            // if (broj.prviBroj < broj.drugiBroj) najveciBroj = broj.drugiBroj;
            //  if (broj.drugiBroj < broj.prviBroj) najveciBroj = broj.prviBroj;
            for (int i = najveciBroj; i >= Math.Max(broj.prviBroj, broj.drugiBroj); i--)
            {
                if (i % broj.prviBroj == 0 && i % broj.drugiBroj == 0)
                {
                    visekratnik = i;

                }
            }
            return("Najmanji visekratnik brojeva " + broj.prviBroj + " i " + broj.drugiBroj + " je " + visekratnik);


        }
    }
}
