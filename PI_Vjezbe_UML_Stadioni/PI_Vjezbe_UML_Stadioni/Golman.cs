using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_UML_Stadioni
{
    class Golman:Zaposlenik
    {
        public string vrstaRukavica { get; set; }
        public Golman(string ime,string prezime,string rukavice)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.vrstaRukavica = rukavice;

        }
    }
}
