using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_4
{
    class Kalkulator
    {
        public float prviBroj { get; set; }
        public float drugiBroj { get; set; }
        public float rezultat { get; set; }
        public string odabir { get; set; }
        //Konstruktor
        //Poziva se svaki put dok instanciramo novi objekt, sluzi umjesto Unos(), te ima isto ime kao i klasa
        public Kalkulator Upis()
        {
            Kalkulator broj = new Kalkulator();
            Console.WriteLine("Unesite prvi broj: ");
            broj.prviBroj = float.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            broj.drugiBroj = float.Parse(Console.ReadLine());
            Console.WriteLine("odaberite operator ( +,-,*,/) :" );
            broj.odabir = Console.ReadLine();
            broj.rezultat = 0;
            return broj;
        }
        public float Ispis(Kalkulator broj)
        {
            
            if (odabir == "+") rezultat = prviBroj + drugiBroj;
            if (odabir == "-") rezultat = prviBroj - drugiBroj;
            if (odabir == "*") rezultat = prviBroj * drugiBroj;
            if (odabir == "/") rezultat = prviBroj / drugiBroj;
           
            Console.WriteLine("Trenutni rezultat je : " + rezultat);
            return rezultat;




        }

    }
}
