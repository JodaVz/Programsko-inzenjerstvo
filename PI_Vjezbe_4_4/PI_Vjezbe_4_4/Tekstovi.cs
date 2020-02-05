using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_4_4
{
    class Tekstovi
    {
        public string UnesenTekst { get; set; }
        public Tekstovi(string t)
        {
            this.UnesenTekst = t;
        }
        public string Ispis(string t)
        {
            string cudnaVarijabla = "";
            
            for (int i = 0; i < t.Count(); i++)
            {
                cudnaVarijabla = cudnaVarijabla + " " + t;
            }


            return cudnaVarijabla;
        }
    }
    
}
