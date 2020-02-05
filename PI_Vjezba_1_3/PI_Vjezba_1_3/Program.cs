using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesite jedinice: ");
            int Jedinice = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite desetice: ");
            int Desetice = int.Parse(Console.ReadLine());
            int TrazeniBroj = (10 * Desetice + Jedinice) * 2;
            Console.WriteLine("Trazeni broj je:"+TrazeniBroj);
            Console.ReadKey();
            


        }
    }
}
