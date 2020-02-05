using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Unesite jedan prirodan broj: ");
            int prviBroj = int.Parse(Console.ReadLine());
            int sumaBrojeva = 0;
            for (int i = 1; i <= prviBroj; i++)
            {
                Console.WriteLine("Broj: " + i+"\n");
                sumaBrojeva = sumaBrojeva + i;
                Console.Write("Trenutna suma brojeva iznosi: " + sumaBrojeva+"\n");
            }
            Console.ReadKey();
        }

    }
}
