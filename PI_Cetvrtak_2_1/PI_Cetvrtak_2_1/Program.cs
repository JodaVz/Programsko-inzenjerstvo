using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Cetvrtak_2_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //inic
            Console.WriteLine("Upišite veličinu polja : ");
            int velicinaPolja = int.Parse(Console.ReadLine());
            int[] poljeBrojeva = new int[velicinaPolja];
            //upis
            for (int i = 0; i < velicinaPolja; i++)
            {
                Console.WriteLine("Upišite broj na " + i + " indexu : ");
                poljeBrojeva[i] = int.Parse(Console.ReadLine());
            }

            //maybe logika? glupo zadatak

            //ispis
            int suma = 0;

            //JEBO TI PAS MATER I DVOSTRUKOM FORU
            for (int i = 0; i < velicinaPolja; i++)
            {
               
                for (int j = 1; j <= poljeBrojeva[i]; j++)
                {
                    Console.Write(j + ",");
                    suma = suma + j;
                    
                }
                Console.Write("=>" + suma+"\n");
                suma = 0;
            }
            Console.ReadKey();
            


            



        }
    }
}
