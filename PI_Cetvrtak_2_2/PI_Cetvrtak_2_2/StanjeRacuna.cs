using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Cetvrtak_2_2
{
    class StanjeRacuna
    {
        public int Mjesec { get; set; }
        public float NovacRacuna { get; set; }
        public StanjeRacuna()
        {
            Console.WriteLine("Upišite mjesec: ");
            this.Mjesec = int.Parse(Console.ReadLine());
            Console.WriteLine("Upišite stanje računa na željeni mjesec : ");
            this.NovacRacuna = float.Parse(Console.ReadLine());
        }
        public static List<StanjeRacuna> Upis() {
            List<StanjeRacuna> listaMjeseci = new List<StanjeRacuna>();
            Console.WriteLine("Upišite broj mjeseci : ");
            int brojMjeseci = int.Parse(Console.ReadLine());
            for (int i = 0; i < brojMjeseci; i++)
            {
                listaMjeseci.Add(new StanjeRacuna());
            }
            return listaMjeseci;
            
        }
        public static void Ispis(List<StanjeRacuna> lista) {
            foreach (StanjeRacuna item in lista)
            {
                Console.WriteLine(item.Mjesec + ".mjesec : " + item.NovacRacuna);
            }

        }
    }
}
