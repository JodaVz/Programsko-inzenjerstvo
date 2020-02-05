using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_UML_Stadioni
{
    class Stadion
    {
        public string ImeStadiona { get; set; }
        public string AdresaStadiona { get; set; }
        public List<Klub> PopisKlubova = new List<Klub>();
        public Stadion(string ime,string adresa)
        {
            this.ImeStadiona = ime;
            this.AdresaStadiona = adresa;
        }
    }
}
