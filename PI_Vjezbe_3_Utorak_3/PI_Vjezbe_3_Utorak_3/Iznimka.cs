using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_Utorak_3
{
   public class Iznimka:ApplicationException
    {
        public string Poruka { get; set; }
        public Iznimka(string s)
        {
            Poruka = s;
        }
    }
}
