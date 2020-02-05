using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_1_2K
{
    class Program
    {
        static void Main(string[] args)
        {

           
            Brojevi brojevi = new Brojevi();
            Console.WriteLine("Unesite prvi broj: ");
            brojevi.prviBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite drugi broj: ");
            brojevi.drugiBroj = int.Parse(Console.ReadLine());
            // Brojevi.ProvjeraManji(brojevi.prviBroj, brojevi.drugiBroj);
            Console.WriteLine("Provjera prvog broja: " + brojevi.prviBroj);
            Console.WriteLine("Provjera drugog broja: " + brojevi.drugiBroj);
            brojevi.veciBroj = brojevi.ProvjeraVeci(brojevi.prviBroj, brojevi.drugiBroj);
            brojevi.manjiBroj = brojevi.ProvjeraManji(brojevi.prviBroj, brojevi.drugiBroj);
            Console.WriteLine("Provjera veceg broja: " + brojevi.veciBroj);
            Console.WriteLine("Provjera manjeg broja: " + brojevi.manjiBroj);
            brojevi.Ispis(brojevi.manjiBroj, brojevi.veciBroj);
            Console.ReadKey();


        }
    }
}
