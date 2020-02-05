using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_5_Utorak_Pravokutnik
{
    class Pravokutnik
    {
        public int Visina { get; set; }
        public int Sirina { get; set; }
        
        public Pravokutnik(int visina,int sirina)
        {
            this.Visina = visina;
            this.Sirina = sirina;
        }
        public int IzracunajOpseg(int visina,int sirina)
        {
            return (2 * visina) + (2 * sirina);

        }
        public int IzracunajPovrsinu(int visina,int sirina)
        {
            return (visina * sirina);
        }
    }
}
