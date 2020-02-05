using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_5_Utorak_Relacije
{
    class Automobil
    {
        public string Ime { get; set; }
        public float Brzina { get; set; }
        public string Ukupno { get; set; }
        public Automobil(string ime,float brzina)
        {
            this.Ime = ime;
            this.Brzina = brzina;
            this.Ukupno = this.Ime + " " + this.Brzina;
        }
    }
}
