using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_4
{
    class Program
    {
        //DRUKCE RESENO NEGO KAJE ZADATAK, ja radim a+b=rezultat, a ne rezultat=rezultat+a samo FYI
        static void Main(string[] args)
        {

            Kalkulator broj = new Kalkulator();
            float pomocna = 0;
            //broj = broj.Upis();
            while (true)
            {
                broj = broj.Upis();
                broj.Ispis(broj);
                pomocna = pomocna + broj.rezultat;
                Console.WriteLine("Prethodni rezultat je: " + pomocna);
            }


            Console.ReadKey();


        }
    }
}
