using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_ponedeljak
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Artikli> listaA = new List<Artikli>();
            int n = 0;
            while (1==1)
            {
                int odabir = 0;
                Console.WriteLine("Pritisnite 1. za novi unos u listu");
                Console.WriteLine("Pritisnite 2. za ispis elemenata");
                Console.WriteLine("Pritisnite 3. za pretragu po elementu");
                Console.WriteLine("Pritisnite 4. za juicy ciscenje ekrana");
                odabir = int.Parse(Console.ReadLine());
                if (odabir==1)
                {
                    
                    listaA.Add(new Artikli());


                }
                Console.WriteLine("U listi se nalazi "+listaA.Count);
                if (odabir == 2)
                {
                    foreach (Artikli item in listaA)
                    {
                        Console.WriteLine("Artikl "+item.NazivArtikla+" kosta "+item.CijenaArtikla);
                        
                    }
                }
                if (odabir == 3)
                {
                    string pretraga = "";
                    Console.WriteLine("Upišite pojam za pretragu : ");
                    pretraga = Console.ReadLine();
                    foreach (Artikli item in listaA)
                    {
                        if (pretraga==item.NazivArtikla)
                        {
                            Console.WriteLine("Traženi proizvod je " + item.NazivArtikla + " i kosta " + item.CijenaArtikla);
                        }
                    }
                }
                Console.WriteLine("U listi se nalazi " + listaA.Count);
               
                if (odabir==4)
                {
                    Console.Clear();
                }
            }
        }
    }
}
