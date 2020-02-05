using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_5_Ponedeljak_Artikli
{
    class Artikl
    {
        public string Ime { get; set; }
        public int Kolicina { get; set; }
        public float Cijena { get; set; }
        public string Ukupno { get; set; }
        public Artikl(string ime,int kolicina,float cijena)
        {
            this.Ime = ime;
            this.Kolicina = kolicina;
            this.Cijena = cijena;
            this.Ukupno=this.Ime+" "+this.Cijena+"kn"+this.Kolicina+" komada ";
        }
    }
}
