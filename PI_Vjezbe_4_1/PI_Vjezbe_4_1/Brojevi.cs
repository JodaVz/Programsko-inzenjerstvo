using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PI_Vjezbe_4_1
{
    class Brojevi
    {
        public int BinarnaVrijednost { get; set; }
        public int DekadskaVrijednost { get; set; }
        public Brojevi(string binarniZapis)
        {
            this.BinarnaVrijednost = int.Parse(binarniZapis);
            this.DekadskaVrijednost = Convert.ToInt32(binarniZapis, 2);
        }
    }
}
