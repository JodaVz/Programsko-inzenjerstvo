using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_4_3
{
    public class Brojevi
    {
        public float Broj { get; set; }
        public string OdabranaOperacije { get; set; }
        public static float RezultatOperacije { get; set; }
        public Brojevi(float b, string o)
        {
            
            this.Broj = b;
            this.OdabranaOperacije = o;
            if (this.OdabranaOperacije=="+")
            {
                RezultatOperacije = this.Broj + RezultatOperacije;
            }
            if (this.OdabranaOperacije == "-")
            {
                RezultatOperacije = RezultatOperacije-this.Broj ;
            }
            if (this.OdabranaOperacije == "*")
            {
                RezultatOperacije = this.Broj * RezultatOperacije;
            }
            if (this.OdabranaOperacije == "/")
            {
                RezultatOperacije =  RezultatOperacije/ this.Broj ;
            }
        }

    }
}
