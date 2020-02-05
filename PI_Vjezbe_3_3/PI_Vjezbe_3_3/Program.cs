using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Kalkulator> listaK = new List<Kalkulator>();

            float pomocna = 0;
            int provjera = 1;
            while (provjera==1)
            {
             

                Console.WriteLine("Dodajte novi element ");
                Kalkulator calc = new Kalkulator();

                if (calc.Operator == "+")
                {
                    Kalkulator.RezultatOperacije += calc.Broj;
                }
                if (calc.Operator == "-")
                {
                    Kalkulator.RezultatOperacije -= calc.Broj;
                }
                if (calc.Operator == "*")
                {
                    Kalkulator.RezultatOperacije *= calc.Broj;
                }
                if (calc.Operator == "/")
                {
                    Kalkulator.RezultatOperacije /= calc.Broj;
                }
                pomocna = Kalkulator.RezultatOperacije;
                listaK.Add(calc);
                foreach (Kalkulator item in listaK)
                {
                    Console.WriteLine("Broj je bio "+item.Broj+", operacija je bila "+item.Operator+", te rezultat je "+ pomocna);
                }




                Console.WriteLine("Za nastavak upisa pritisnite 1, za izlazak pritisnite 0");
                provjera = int.Parse(Console.ReadLine());
               
            }
            Console.ReadKey();
        }
    }
}
