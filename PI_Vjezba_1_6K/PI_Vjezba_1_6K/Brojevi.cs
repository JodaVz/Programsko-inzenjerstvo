using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_6K
{
    class Brojevi
    {
        public int prviBroj { get; set; }
        public int sumaBrojeva { get; set; }

        public int Unos() {
            Brojevi broj = new Brojevi();
            Console.WriteLine("Unesite gornju granicu: ");
            broj.prviBroj = int.Parse(Console.ReadLine());
            return broj.prviBroj;


        }
        public void Izracun(int a)
        {
            Brojevi broj = new Brojevi();
            broj.prviBroj = a;
            int suma = 0;
            for (int i = 1; i < broj.prviBroj; i++)
            {
                Console.WriteLine("Broj je : " + i);
                suma = suma + i;
            }
            sumaBrojeva = suma;
            Console.WriteLine("Suma svih brojeva iznosi: " + sumaBrojeva);

            
            
        }
        


    }
}
