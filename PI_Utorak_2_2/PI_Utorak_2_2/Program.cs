using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Utorak_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int provjera=1;
            while (provjera==1)
            {
                Console.WriteLine("Upišite broj rečenica: ");
                int brojRecenica = int.Parse(Console.ReadLine());
                string[] recenice = new string[brojRecenica];
                for (int i = 0; i < brojRecenica; i++)
                {
                    Console.WriteLine("Upišite vrijednost na indexu: " + i);
                    recenice[i] = Console.ReadLine();
                }
                Console.WriteLine("Upišite željenu riječ pretrage:");
                string pocetnaRijec = Console.ReadLine();
                for (int i = 0; i < brojRecenica; i++)
                {
                    if (recenice[i].StartsWith(pocetnaRijec)){
                        Console.WriteLine("Tražena rečenica je:");
                        Console.WriteLine(recenice[i]);
                    }
                }
            }


        }
    }
}
