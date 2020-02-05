using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_5
{
    class Kamate
    {
        public float Glavnica { get; set; }
        public float Kamata { get; set; }
        public int TrajanjeMjeseci { get; set; }
        public float Otplata { get; set; }
        public Kamate()
        {
            Console.WriteLine("Upišite početnu vrijednost glavnice : ");
            this.Glavnica = float.Parse(Console.ReadLine());
            Console.WriteLine("Upišite kamatu ( u postocima) : ");
            this.Kamata = (float.Parse(Console.ReadLine())/100);
            Console.WriteLine("Upišite trajanje u mjesecima : ");
            this.TrajanjeMjeseci = int.Parse(Console.ReadLine());
        }
        public static List<Kamate> Upis()
        {
            List<Kamate> listaK = new List<Kamate>();
            int velicinaListe = 0;
            Console.WriteLine("Upišite broj otplatnih planova");
            velicinaListe = int.Parse(Console.ReadLine());
            for (int i = 0; i < velicinaListe; i++)
            {
                Console.WriteLine("Upišite "+i+". otplatni plan");
                listaK.Add(new Kamate());
            }
            return listaK;
        }
        public static void Ispis(List<Kamate> listaK)
        {
            foreach (Kamate item in listaK)
            {
                Console.WriteLine("Otplatni plan pocetne glavnice "+item.Glavnica+", u trajanju od "+item.TrajanjeMjeseci+" i kamatom od "+item.Kamata+" iznosi "+Izracun(item.Glavnica,item.Kamata,item.TrajanjeMjeseci));
            }

        }
        public static float Izracun(float g,float k,int t)
        {
            float rezultat = ((g * k * t) / 1200);
            return rezultat;
        }
    }
}
