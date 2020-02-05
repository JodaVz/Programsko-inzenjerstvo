using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DjeliteljVisekratnik
{
    class Brojevi
    {
        public int prviBroj { get; set; }
        public int drugiBroj { get; set; }
        
        public Brojevi Upis()
        {
            Brojevi broj = new Brojevi();

            Console.WriteLine("Upišite prvi broj: ");
            broj.prviBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Upišite drugi broj: ");
            broj.drugiBroj = int.Parse(Console.ReadLine());
           
            return (broj);


        }
        public void Djelitelj(int prvi,int drugi)
        {
            Brojevi broj = new Brojevi();
            broj.prviBroj = prvi;
            broj.drugiBroj = drugi;
            int najveciBroj = 0;
            int djelitelj = 0;
            if (broj.prviBroj < broj.drugiBroj) najveciBroj = broj.drugiBroj;
            if (broj.drugiBroj < broj.prviBroj) najveciBroj = broj.prviBroj;
            for (int i = 2; i < najveciBroj; i++)
            {
                if (broj.prviBroj % i == 0 && broj.drugiBroj % i == 0)
                {
                    djelitelj = i;
                   break;
                }
                
            }
            Console.WriteLine("Najmanji djelitelj brojeva " + broj.prviBroj + " i " + broj.drugiBroj + " je " + djelitelj);
            for (int i = 1; i < najveciBroj; i++)
            {
                if (broj.prviBroj % i == 0 && broj.drugiBroj % i == 0)
                {
                    djelitelj = i;
                    
                    
                }

            }
            Console.WriteLine("Najveci djelitelj brojeva " + broj.prviBroj + " i " + broj.drugiBroj + " je " + djelitelj);



        }

        public void Visekratnik(int prvi, int drugi)

        {
            Brojevi broj = new Brojevi();
            broj.prviBroj = prvi;
            broj.drugiBroj = drugi;
            int najveciBroj = broj.prviBroj*broj.drugiBroj;
            int visekratnik = 0;
           // if (broj.prviBroj < broj.drugiBroj) najveciBroj = broj.drugiBroj;
          //  if (broj.drugiBroj < broj.prviBroj) najveciBroj = broj.prviBroj;
            for (int i = najveciBroj; i >= Math.Max(broj.prviBroj,broj.drugiBroj); i--)
            {
                if(i%broj.prviBroj==0 && i % broj.drugiBroj == 0)
                {
                    visekratnik = i;
                   
                }
            }
            Console.WriteLine("Najmanji visekratnik brojeva " + broj.prviBroj + " i " + broj.drugiBroj + " je " + visekratnik);


        }
    }
}
