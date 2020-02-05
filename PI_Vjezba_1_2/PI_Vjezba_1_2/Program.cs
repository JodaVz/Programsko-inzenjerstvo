using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezba_1_2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Upisite prvi broj: ");
            int PrviBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Upisite drugi broj: ");
            int DrugiBroj = int.Parse(Console.ReadLine());
            int ManjiBroj=0; 
            int VeciBroj=0;
            if (PrviBroj < DrugiBroj) {
               
                ManjiBroj = PrviBroj;
                VeciBroj = DrugiBroj;
            }
            if (PrviBroj > DrugiBroj) {
               
                VeciBroj = PrviBroj;
                ManjiBroj = DrugiBroj;
            }
            Console.WriteLine("Brojevi od manjed do veceg su : ");
            for (int i = ManjiBroj; i <= VeciBroj; i++)
            {
                Console.WriteLine(i);

                }

            Console.ReadKey();
        }
    }
}
