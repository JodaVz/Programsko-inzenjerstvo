using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_Ponedeljak_Boje
{
    class Boje
    {
        public int CrvenaBoja { get; set; }
        public int ZelenaBoja { get; set; }
        public int PlavaBoja  { get; set; }
        

        public Boje(int r,int g,int b)
        {
            this.CrvenaBoja = r;
            this.ZelenaBoja = g;
            this.PlavaBoja = b;
        }
        

        
    }
}
