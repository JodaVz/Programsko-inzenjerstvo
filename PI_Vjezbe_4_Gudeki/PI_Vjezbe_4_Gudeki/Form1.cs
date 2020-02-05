using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_Gudeki
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int pomocnaBoja = 0;
        private void unosBojeCrna_CheckedChanged(object sender, EventArgs e)
        {
            pomocnaBoja = 1;
        }

        private void unosBojeSiva_CheckedChanged(object sender, EventArgs e)
        {
            pomocnaBoja = 2;
        }

        private void unosBojeRoza_CheckedChanged(object sender, EventArgs e)
        {
            pomocnaBoja = 3;
        }
        int pomocnaSpol = 0;

        private void unosSpolMuski_CheckedChanged(object sender, EventArgs e)
        {
            pomocnaSpol = 1;
        }

        private void unosSpolZenski_CheckedChanged(object sender, EventArgs e)
        {
            pomocnaSpol = 2;
        }

        private void upisSpolNedorecen_CheckedChanged(object sender, EventArgs e)
        {
            pomocnaSpol = 3;
        }
        string pomocnaIme="";
        List<Gudek> listaGudeka = new List<Gudek>();
        private void unosPotvrda_Click(object sender, EventArgs e)
        {
            pomocnaIme = unosImeGudeka.Text;
            Gudek gudek = new Gudek(pomocnaIme, pomocnaSpol, pomocnaBoja);
            listaGudeka.Add(gudek);

            ispisSvihGudeka.Items.Add(gudek.ImeGudeka+" je "+gudek.BojaGudeka+" boje"+" i "+gudek.SpolGudek+" spola");
            

        }
        int pomocniBrojac = 1;
        private void filtarPoBoji_Click(object sender, EventArgs e)
        {
            ispisFiltrirano.Text = Gudek.FiltriranjePoBoji(listaGudeka, pomocniBrojac);
            pomocniBrojac++;
            if (pomocniBrojac>3)
            {
                pomocniBrojac = 1;
            }
        }

        private void ispisFiltrirano_TextChanged(object sender, EventArgs e)
        {

        }

        private void FiltarPoSpolu_Click(object sender, EventArgs e)
        {
            ispisFiltrirano.Text = Gudek.FiltriranjePoSpolu(listaGudeka, pomocniBrojac);
            pomocniBrojac++;
            if (pomocniBrojac > 3)
            {
                pomocniBrojac = 1;
            }
        }
    }
}
