using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Utorak_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // RNG

            //Console.WriteLine("Upisite neki tekst");
            //string tekst = Console.ReadLine();
            //Console.WriteLine("Duljina teksta je : ");
            //Console.WriteLine(tekst.Length);
            //Console.ReadKey();
            //tekst = "";
            //string recenica = "";

            //duljina recenice

            //Console.WriteLine("Upišite zeljeni broj rijeci: ");
            //int BrojRijeci = int.Parse(Console.ReadLine());
            //for (int i = 0; i < BrojRijeci; i++)
            //{
            //    Console.WriteLine("Upišite " + i + ".tu riječ: ");
            //    tekst = Console.ReadLine();
            //    recenica += tekst + " ";
            //}
            //Console.WriteLine("Recenica je duljine:" + recenica.Length);
            //Console.WriteLine(recenica);
            //Console.ReadKey();

            //školski
            Console.WriteLine("Upišite željeni broj riječi :");
            int BrojRijeci = int.Parse(Console.ReadLine());
            string recenica = "";
            string[] rijeciURecenici = new string[BrojRijeci];
            for (int i = 0; i < BrojRijeci; i++)
            {
                Console.WriteLine("Upišite riječ na indeksu : " + i);
                rijeciURecenici[i] = Console.ReadLine();
            }
            for (int i = 0; i < BrojRijeci; i++)
            {
                Console.WriteLine("Rijec na indeksu " + i + " je dužine " + rijeciURecenici[i].Length);
                recenica += rijeciURecenici[i] + " ";
                Console.WriteLine("Recenica je duljine: " + recenica.Length);
            }
            Console.WriteLine("Recenica je duljine: " + recenica.Length);
            Console.ReadKey();
        }
    }
}
