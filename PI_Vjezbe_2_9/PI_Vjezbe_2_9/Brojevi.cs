using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_2_9
{
    class Brojevi
    {

        public int prviBroj { get; set; }
        public int drugiBroj { get; set; }
        public Brojevi()
        {
            Console.WriteLine("Upišite prvi broj : ");
            this.prviBroj = int.Parse(Console.ReadLine());
            Console.WriteLine( "Upišite drugi broj : " );
            this.drugiBroj = int.Parse(Console.ReadLine());
        }
        public static List<Brojevi> Upis()
        {
            List<Brojevi> listaBrojeva = new List<Brojevi>();
            int velicinaListe = 0;
            Console.WriteLine("Unesite broj elemenata liste: ");
            velicinaListe = int.Parse(Console.ReadLine());
            for (int i = 0; i < velicinaListe; i++)
            {
                listaBrojeva.Add(new Brojevi());
            }
            return listaBrojeva;
        }
        public static void Ispis(List<Brojevi> lista)
        {
            foreach (Brojevi item in lista)
            {
                if (item.prviBroj>item.drugiBroj)
                {
                    Console.WriteLine(item.prviBroj+">"+item.drugiBroj);
                }

                if (item.prviBroj < item.drugiBroj)
                {
                    Console.WriteLine(item.prviBroj + "<" + item.drugiBroj);
                }

                if (item.prviBroj == item.drugiBroj)
                {
                    Console.WriteLine(item.prviBroj + "=" + item.drugiBroj);
                }



            }


        }
    }
}
