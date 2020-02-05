using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_Utorak_3
{
    class Osobe
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public List<Brojevi> listaBrojeva { get; set; }
        public Osobe(string i, string p)
        {
            this.Ime = i;
            this.Prezime = p;
            Console.WriteLine("Koliko brojeva ima osoba? ");
            int n = 0;
            listaBrojeva = new List<Brojevi>();
            n = int.Parse(Console.ReadLine());
            int pomocna = 0;
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine("Upišite "+(j+1)+". broj ");
                pomocna = int.Parse(Console.ReadLine());
                listaBrojeva.Add(new Brojevi(pomocna));
            }

        }
    }
}
