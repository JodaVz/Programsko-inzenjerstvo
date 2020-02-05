using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testna
{
    public class Proizvod
    {
        public string Naziv { get; set; }
        public float Cijena { get; set; }
        public int Kolicina { get; set; }
        public int MinimalnaKolicina { get; set; }
        public Proizvod(string naziv,float cijena,int kolicina,int minimalna)
        {
            this.Naziv = naziv;
            this.Cijena = cijena;
            this.Kolicina = kolicina;
            this.MinimalnaKolicina = minimalna;
        }
    }
}
