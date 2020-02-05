using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_3
{
    class Brojevi
    {
        public int[] brojevi { get; set; }
        public int brojBrojeva { get; set; }
        public string tekst { get; set; }
        public Brojevi()
        {
            Console.WriteLine("Unesite velicinu polja: ");
            brojBrojeva = int.Parse(Console.ReadLine());
            brojevi = new int[brojBrojeva];
            for (int i = 0; i < brojBrojeva; i++)
            {
                Console.WriteLine("Upišite broj na indexu " + i);
                brojevi[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Unesite tekst: ");
            tekst = Console.ReadLine();
        }
        public void Ispis(Brojevi broj)
        {
            Console.WriteLine("--------REZULTAT--------");
            Console.WriteLine("------------------------");
            for (int i = 0; i < broj.brojBrojeva; i++)
            {
                Console.Write("Iteracija broj: " + (i+1) + "\n");
                for (int j = 0; j <= i; j++)
                {
                   
                    Console.Write(tekst + " ");
                }
                
                Console.Write("\n");
            }

        }

    }
}
