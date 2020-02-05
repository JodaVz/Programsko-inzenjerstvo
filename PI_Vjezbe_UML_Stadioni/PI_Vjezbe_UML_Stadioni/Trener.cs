using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_UML_Stadioni
{
    class Trener:Zaposlenik
    {
        public string VrstaKravate { get; set; }
        public Trener(string ime,string prezime,string kravata)
        {
            this.Ime = ime;
            this.Prezime = prezime;
            this.VrstaKravate = kravata;
        }
    }
}
