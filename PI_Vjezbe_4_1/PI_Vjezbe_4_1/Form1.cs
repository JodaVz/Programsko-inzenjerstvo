using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GumbZaPretvorbu_Click(object sender, EventArgs e)
        {
            string binarniZapis = (PrviBit.Text + DrugiBit.Text + TreciBit.Text + CetvrtiBit.Text + PetiBit.Text + SestiBit.Text + SedmiBit.Text + OsmiBit.Text);
            Brojevi broj = new Brojevi(binarniZapis);
            IspisDekadskog.Text = broj.DekadskaVrijednost.ToString();
        }
    }
}
