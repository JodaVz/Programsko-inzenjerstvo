using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tjedan3Zad2
{
    public class Iznimka: ApplicationException
    {
        public Iznimka(string poruka)
        {
            DodatnaPoruka = poruka;
        }

        public string DodatnaPoruka { get; set; }
    }
}
