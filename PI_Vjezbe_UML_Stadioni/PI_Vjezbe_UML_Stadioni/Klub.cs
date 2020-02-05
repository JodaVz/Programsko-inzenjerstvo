using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_UML_Stadioni
{
    class Klub
    {
        public string ImeKluba { get; set; }
        public List<Tim> PopisTimova = new List<Tim>();
        public Klub(string ime)
        {
            this.ImeKluba = ime;
        }
    }
}
