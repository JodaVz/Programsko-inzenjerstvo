using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_6_RandomPractive_MaloDretvice
{
    public class Artikl
    {

        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public int Kolicina { get; set; }
        public string Ukupno { get; set; }
        public Artikl(string naziv,float cijena,int kolicina)
        {
            this.Naziv = naziv;
            this.Cijena = cijena;
            this.Kolicina = kolicina;
            this.Ukupno = naziv + " kosta " + cijena + " kuna ," + kolicina + " komada kosta" + (cijena * kolicina);

        }
    }
}
