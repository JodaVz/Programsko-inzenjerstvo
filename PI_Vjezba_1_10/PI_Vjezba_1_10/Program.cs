using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int pomocniBroj = 0;
            List<int> lista = new List<int>(4);
            Console.WriteLine("Upisite 4 broja:");
            for (int i = 0; i <= 3; i++)
            {
                 pomocniBroj = int.Parse(Console.ReadLine());
                lista.Add(pomocniBroj);
            }
            lista.Sort();
            foreach (int broj in lista)
            {
                Console.WriteLine("Brojevi u listi su : " + broj);
            }
            Console.ReadKey();
        }
    }
}
