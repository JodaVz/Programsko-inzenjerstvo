using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_4
{
    class Brojevi
    {
        public int BrojPonavljanja { get; set; }
        public string Tekst { get; set; }
        public Brojevi()
        {
            Console.WriteLine("Upišite željeni tekst :");
            this.Tekst = Console.ReadLine();
            Console.WriteLine("Upišite broj ponavljanja teksta : ");
            this.BrojPonavljanja = int.Parse(Console.ReadLine());
        }
        public static List<Brojevi> Upis()
        {
            List<Brojevi> listaB = new List<Brojevi>();
            int velicinaListe = 0;
            Console.WriteLine("Upišite broj elemenata");
            velicinaListe = int.Parse(Console.ReadLine());
            for (int i = 0; i < velicinaListe; i++)
            {
                Console.WriteLine("Upišite element na indexu "+i);
                listaB.Add(new Brojevi());
            }
            return listaB;

        }
        public static void Ispis(List<Brojevi> listaB)
        {
            foreach (Brojevi item in listaB)
            {
                for (int i = 0; i <item.BrojPonavljanja; i++)
                {
                    Console.Write(item.Tekst + ",");
                }
                Console.WriteLine(",");
            }


        }
    }
}
