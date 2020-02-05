using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_Utorak_BrzinaRijeci
{
    public partial class Form1 : Form
    {
        DateTime pocetnoVrijeme;
        DateTime zavrsnoVrijeme;

        public Form1()
        {
            InitializeComponent();
        }

        private void upisRecenice_TextChanged(object sender, EventArgs e)
        {

        }

        private void upisProvjere_TextChanged(object sender, EventArgs e)
        {

        }

        private void gumbPotvrda_Click(object sender, EventArgs e)
        {

        }

        private void upisRecenice_Leave(object sender, EventArgs e)
        {
            zavrsnoVrijeme = DateTime.Now.Subtract(pocetnoVrijeme);
        }

        private void upisRecenice_Enter(object sender, EventArgs e)
        {
            pocetnoVrijeme = DateTime.Now;
        }
    }
}
