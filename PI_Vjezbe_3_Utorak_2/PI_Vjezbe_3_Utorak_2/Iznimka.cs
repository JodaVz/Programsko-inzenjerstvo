using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_Utorak_2
{
    public class Iznimka:ApplicationException
    {
        public string DodatnaPoruka { get; set; }
        public Iznimka(string s)
        {
            DodatnaPoruka = s;
        }
    }
}
