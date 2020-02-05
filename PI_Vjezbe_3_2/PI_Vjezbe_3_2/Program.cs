using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Troskovi> listaTroskova = new List<Troskovi>();
            int provjera = 1;
            while (provjera==1)
            {
                listaTroskova.Add(new Troskovi());
                Console.WriteLine("Za dodavanje troškova pritisnite 1");
                Console.WriteLine("Za sumiranje pritisnite 0");
                provjera = int.Parse(Console.ReadLine());
            }
            Troskovi.Ispis(listaTroskova);
            Console.ReadKey();
        }
    }
}
