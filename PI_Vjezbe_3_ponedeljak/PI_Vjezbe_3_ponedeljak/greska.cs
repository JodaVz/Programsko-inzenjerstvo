using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_3_ponedeljak
{
     public class greska : ApplicationException 
    {
        public string Poruka { get; set; }
        public greska(string poruka)
        {
           Poruka = poruka;
        }
    }
}
