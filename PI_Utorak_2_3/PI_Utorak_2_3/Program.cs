using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Utorak_2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite broj brojeva: ");
            int velicinaNiza = int.Parse(Console.ReadLine());
            float sumaBrojeva = 0;
            List<float> listaBrojeva = new List<float>();
            Console.WriteLine("------------------------------------------------");
            for (int i = 0; i < velicinaNiza; i++)
            {
                Console.WriteLine("Upišite broj na : " + i + " indexu");
                listaBrojeva.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("------------------------------------------------");
            foreach (float broj in listaBrojeva)
            {
                for (float i = (-broj);  i <= (broj*2);  i++)
                {
                    Console.WriteLine("Trenutna suma: " + sumaBrojeva);
                    Console.Write("Trenutni broj za zbrojit: " + i+" , ");
                    sumaBrojeva = sumaBrojeva + i;

                    
                }
                Console.WriteLine("Suma za " + broj + " iznosi : " + sumaBrojeva);
                sumaBrojeva = 0;
                Console.WriteLine("------------------------------------------------");
            }
            Console.ReadKey();
        }
    }
}
