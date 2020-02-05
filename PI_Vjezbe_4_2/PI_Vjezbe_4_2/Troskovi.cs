using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_4_2
{
    class Troskovi
    {
        public string NazivTroska { get; set; }
        public float VrijednostTroska { get; set; }
        public Troskovi(string n,float v)
        {
            this.NazivTroska = n;
            this.VrijednostTroska = v;
        }
    }
}
