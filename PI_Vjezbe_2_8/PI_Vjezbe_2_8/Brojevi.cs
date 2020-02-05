using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_8
{
    class Brojevi
    {
        public int prviBroj { get; set; }
        public int drugiBroj { get; set; }
        public Brojevi()
        {
            Console.WriteLine("Upišite prvi broj : ");
            this.prviBroj = int.Parse(Console.ReadLine());
            Console.WriteLine("Upišite drugi broj : ");
            this.drugiBroj = int.Parse(Console.ReadLine());
        }
        public static List<Brojevi> Upis()
        {
            List<Brojevi> listaBrojeva = new List<Brojevi>();
            int velicinaListe = 0;
            Console.WriteLine("Upišite broj elemenata");
            velicinaListe = int.Parse(Console.ReadLine());
            for (int i = 0; i < velicinaListe; i++)
            {
                Console.WriteLine("Dodajte novi par");
                listaBrojeva.Add(new Brojevi());
            }

            return listaBrojeva;

        }
        public static void Ispis(List<Brojevi> lista)
        {
            int veciBroj = 0;
            int manjiBroj = 0;
            foreach (Brojevi item in lista)
            {
                if (item.prviBroj > item.drugiBroj) {
                    veciBroj=item.prviBroj ;
                    manjiBroj=item.drugiBroj;
                }
                else
                {
                    veciBroj = item.drugiBroj;
                    manjiBroj = item.prviBroj;
                }
                for (int i = manjiBroj; i < veciBroj; i++)
                {


                    if (i % (lista.Count) == 0)
                    {
                        int n = lista.Count();
                        Console.Write(i + ",");
                    }
                    else
                    {
                        Console.Write("NULL,");
                    }
                }
                Console.WriteLine("Sljedeci par: ");
            }


        }
    }
}
