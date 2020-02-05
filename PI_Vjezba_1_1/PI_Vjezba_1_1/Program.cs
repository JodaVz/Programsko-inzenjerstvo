using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Upišite prvi broj");
            int Prvibroj;
            Prvibroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Upišite drugi broj");
            int Drugibroj;
            Drugibroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Upišite treći broj");
            int Trecibroj;
            Trecibroj = int.Parse(Console.ReadLine());
            for (int i = Prvibroj; i <=Drugibroj; i++)
            {
                if (i % Trecibroj==0)
                {
                    Console.WriteLine("Brojevi djeljivi s "+Trecibroj+"  su " + i);
                }
            }

            Console.ReadKey();

        }
    }
}
