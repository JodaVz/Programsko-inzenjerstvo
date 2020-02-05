using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomZadatak
{
    class Igrac
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Igrac(string ime,string prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;

        }
    }
}
