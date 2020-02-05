using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_UML_Stadioni
{
    class Tim
    {
        public string OznakaTima { get; set; }
        public List<Golman> PopisGolmana = new List<Golman>();
        public List<Trener> PopisTrenera = new List<Trener>();
        public List<Igrac> PopisIgraca = new List<Igrac>();
        public Tim(string ime)
        {
            this.OznakaTima = ime;
        }
    }
}
