using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Petak_2_Razlomci
{
    class Razlomci
    {
        public int Brojnik { get; set; }
        public int Nazivnik { get; set; }
        public Razlomci()
        {
            Console.WriteLine("Upišite brojnik: ");
            this.Brojnik = int.Parse(Console.ReadLine());
            Console.WriteLine("Upišite nazivnik: ");
            this.Nazivnik = int.Parse(Console.ReadLine());
        }

        public static List<Razlomci> Upis()
        {
            List<Razlomci> listaRazlomaka = new List<Razlomci>();
            int velicinaListe = 0;
            Console.WriteLine("Koliko razlomaka zelite? ");
            velicinaListe = int.Parse(Console.ReadLine());
            for (int i = 0; i < velicinaListe; i++)
            {
                Console.WriteLine("Upišite razlomak na indexu " + i);
                listaRazlomaka.Add(new Razlomci());
            }

            return listaRazlomaka;
        }
        public static void Ispis(List<Razlomci> lista)
        {
            foreach (Razlomci item in lista)
            {
                Console.WriteLine(item.Brojnik);
                Console.WriteLine("---");
                Console.WriteLine(item.Nazivnik);
            }



        }
        public static void Umnozak(List<Razlomci> lista)
        {
            int brojnik = 1;
            int nazivnik = 1;
            foreach (Razlomci item in lista)
            {
                brojnik = brojnik * item.Brojnik;
                nazivnik = nazivnik * item.Nazivnik;
                
                
            }
            Console.WriteLine("Umozak brojeva iznosi ");
            Console.WriteLine(brojnik);
            Console.WriteLine("---");
            Console.WriteLine(nazivnik );

        }
        public static void Kvocijent(List<Razlomci> lista)
        {
            
            int brojnik = lista[0].Brojnik;
            int nazivnik = lista[0].Nazivnik;

            foreach (Razlomci item in lista.Skip(1))
            {
                nazivnik = nazivnik * item.Brojnik;
                brojnik = brojnik * item.Nazivnik;
            }
            Console.WriteLine("Kvocijent brojeva iznosi ");
            Console.WriteLine(brojnik);
            Console.WriteLine("---");
            Console.WriteLine(nazivnik);

        }
    }
}
