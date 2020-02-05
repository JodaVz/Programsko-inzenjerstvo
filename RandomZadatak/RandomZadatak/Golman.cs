using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomZadatak
{
    class Golman:Igrac
    {
        public string Rukavica { get; set; }
       
        public Golman(string rukavice,string ime,string prezime) : base(ime,prezime)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.Rukavica = rukavice;
        }
    }
}
