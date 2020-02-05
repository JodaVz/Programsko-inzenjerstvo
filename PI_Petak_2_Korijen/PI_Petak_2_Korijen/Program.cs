using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Petak_2_Korijen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koliko brojeva zelite?");
            int velicinaListe = int.Parse(Console.ReadLine());
            List<int> listaBrojeva = new List<int>();
            for (int i = 0; i < velicinaListe; i++)
            {
                Console.WriteLine("Upišite broj na " + i + " indexu: ");
                listaBrojeva.Add(int.Parse(Console.ReadLine()));
            }
            int korijenBroja = 0;
            foreach (int item in listaBrojeva)
            {
                for (int i = item; i >0; i--)
                {
                    if ((i*i)==item)
                    {
                        korijenBroja = i;
                       
                    }
                }
                if(korijenBroja!=0)Console.WriteLine("Korijen broja " + item + " je " + korijenBroja);
                if (korijenBroja == 0) Console.WriteLine("Ne postoji korijen broja "+item);




            }
            Console.ReadKey();
        }
    }
}
