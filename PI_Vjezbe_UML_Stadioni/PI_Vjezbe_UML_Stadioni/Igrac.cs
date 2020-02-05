using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_UML_Stadioni
{
    class Igrac:Zaposlenik
    {
        public string VrstaKopacki { get; set; }
        public Igrac(string ime,string prezime,string kopacke)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.VrstaKopacki = kopacke;
        }
    }
}
