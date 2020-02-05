using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Dimenzija dimenzija = new Dimenzija();
            if (dimenzija.Sirina>1 && dimenzija.Visina>1)
            {
                Console.WindowHeight = 1;
                Console.WindowWidth = 1;
                for (int i = 1; i < dimenzija.Sirina; i++)
                {
                    Console.WindowWidth = i;
                    System.Threading.Thread.Sleep(10);
                   
                }
                for (int j = 1; j < dimenzija.Visina; j++)
                {
                    Console.WindowHeight = j;
                    System.Threading.Thread.Sleep(10);
                }

            }
            else
            {
                Console.WriteLine("Unjeli ste brojeve manje od 1");
            }
            Console.ReadKey();
        }
    }
}
