using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_5_Utorak_Pravokutnik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            odabirOperacije.Items.Add("Povrsina");
            odabirOperacije.Items.Add("Opseg");
            

        }
        List<Pravokutnik> listaPravokutnika = new List<Pravokutnik>();



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void unosPravokutnikPotvrda_Click(object sender, EventArgs e)
        {
            listaPravokutnika.Add(new Pravokutnik(int.Parse(unosPravokutnikVisina.Text), int.Parse(unosPravokutnikSirina.Text)));
            popisPravokutnika.DataSource = null;
            popisPravokutnika.DataSource = listaPravokutnika;
            popisPravokutnika.DisplayMember = "Visina";
            
            
            
        }

        private void unosRacunaj_Click(object sender, EventArgs e)
        {
            Pravokutnik odabraniPravokutnik = null;
            
            
            odabraniPravokutnik = popisPravokutnika.SelectedItem as Pravokutnik;
            if (odabirOperacije.SelectedItem.ToString() == "Povrsina") {
                ispisRezultat.Text = odabraniPravokutnik.IzracunajPovrsinu(odabraniPravokutnik.Visina, odabraniPravokutnik.Sirina).ToString();
            }
            if (odabirOperacije.SelectedItem.ToString() == "Opseg")
            {
                ispisRezultat.Text = odabraniPravokutnik.IzracunajOpseg(odabraniPravokutnik.Visina, odabraniPravokutnik.Sirina).ToString();
            }
            pomocnitest.Text = (odabraniPravokutnik.Visina+" "+odabraniPravokutnik.Sirina).ToString();
            this.Size = new Size(odabraniPravokutnik.Visina, odabraniPravokutnik.Sirina);
        }
    }
}
