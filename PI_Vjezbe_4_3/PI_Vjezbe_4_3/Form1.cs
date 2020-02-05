using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_3
{
    public partial class Form1 : Form
    {
        string odabir = "";
        float odabraniBroj = 0;
        float trenutniRezultat = 0;
        List<Brojevi> listaB = new List<Brojevi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void OperacijaZbroji_CheckedChanged(object sender, EventArgs e)
        {
            odabir = "+";
        }

        private void OperacijaOduzmi_CheckedChanged(object sender, EventArgs e)
        {
            odabir = "-";
        }

        private void OperacijaPomnozi_CheckedChanged(object sender, EventArgs e)
        {
            odabir = "*";
        }

        private void OperacijaPodjeli_CheckedChanged(object sender, EventArgs e)
        {
            odabir = "/";
        }
        
private void PotvrdaUnosa_Click(object sender, EventArgs e)
        {

            odabraniBroj = float.Parse(unosBroja.Text);
            Brojevi broj = new Brojevi(odabraniBroj, odabir);
            listaB.Add(broj);
            prikazRezultata.Text = Brojevi.RezultatOperacije.ToString();
            listPovijestUnosa.Items.Add(broj.Broj+" "+broj.OdabranaOperacije+" = "+Brojevi.RezultatOperacije);
        }
    }
}
