using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Brojevi> listaBrojeva = new List<Brojevi>();
            int velicinaListe = 0;
            Console.WriteLine("Upišite broj elemenata liste : ");
            velicinaListe = int.Parse(Console.ReadLine());
            for (int i = 0; i < velicinaListe; i++)
            {
                Console.WriteLine("Dodajte elemement na " + i + ". indexu ");
                listaBrojeva.Add(new Brojevi());
            }
            Brojevi.Ispis(listaBrojeva, velicinaListe);
            Console.ReadKey();
        }
    }
}
