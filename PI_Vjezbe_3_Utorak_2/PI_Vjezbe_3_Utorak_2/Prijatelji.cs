using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_Utorak_2
{
    class Prijatelji
    {

        public string ImeFrenda { get; set; }
        public string PrezimeFrenda { get; set; }
        public float OcjenaFrenda { get; set; }
        public Prijatelji(string i,string p,float o)
        {
            this.ImeFrenda = i;
            this.PrezimeFrenda = p;
            this.OcjenaFrenda = o;
        }
        
    }
}
