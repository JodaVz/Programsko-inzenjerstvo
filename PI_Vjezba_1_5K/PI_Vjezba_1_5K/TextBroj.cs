using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_5K
{
    class TextBroj
    {
        public string tekst { get; set; }
        public int broj { get; set; }

        public TextBroj Mnozenje() {
            TextBroj objekt = new TextBroj();
            Console.WriteLine("Upišite broj ponavljanja: ");
            objekt.broj = int.Parse(Console.ReadLine());
            Console.WriteLine("Upišite zeljeni tekst: ");
            objekt.tekst = Console.ReadLine();
            return objekt;
        }
        public  void Ispis(int b,string s)
        {
            for (int i = 0; i < b; i++)
            {
                Console.WriteLine(s);

            }
            Console.ReadKey();
        }
    }
}
