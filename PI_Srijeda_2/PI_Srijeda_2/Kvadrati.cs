using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Srijeda_2
{
    class Kvadrati
    {
        public int Dimenzija { get; set; }
        public int Delay { get; set; }
        public string Znak { get; set; }
        public Kvadrati()
        {
            Console.WriteLine("Unesite dimenzije kvadrata : ");
            this.Dimenzija = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite znak ispisa kvadrata : ");
            this.Znak = Console.ReadLine();
            Console.WriteLine("Unesite vrijednost delaya između ispisa :");
            this.Delay = int.Parse(Console.ReadLine());
        }
        public static List<Kvadrati> Upis()
        {
            List<Kvadrati> listaKvadrata = new List<Kvadrati>();
            Console.WriteLine("Koliko elemenata zelite u listi? ");
            int velicinaListe = 0;
            velicinaListe = int.Parse(Console.ReadLine());
            for (int i = 0; i < velicinaListe; i++)
            {
                listaKvadrata.Add(new Kvadrati());
            }

            return listaKvadrata;
        }
        public static void Ispis(List<Kvadrati> listaKvadrata)
        {
            while (1 == 1)
            {


                foreach (Kvadrati kvadr in listaKvadrata)
                {
                    for (int i = 1; i <= kvadr.Dimenzija; i++)
                    {
                        
                        for (int j = 1; j < kvadr.Dimenzija; j++)
                        {
                            Console.Write(kvadr.Znak);
                        }
                        Console.WriteLine(kvadr.Znak);
                       
                    }
                    System.Threading.Thread.Sleep(kvadr.Delay);

                }
            }

        }
    }
}
