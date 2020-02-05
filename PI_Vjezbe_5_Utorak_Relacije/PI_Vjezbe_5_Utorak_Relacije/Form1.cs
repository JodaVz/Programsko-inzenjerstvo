using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_5_Utorak_Relacije
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Automobil> listaAutomobila = new List<Automobil>();
        private void unosAutoPotvrda_Click(object sender, EventArgs e)
        {
            listaAutomobila.Add(new Automobil(unosAutoIme.Text, float.Parse(unosAutoBrzina.Text)));
            popisAuta.DataSource = null;
            popisAuta.DataSource = listaAutomobila;
            popisAuta.DisplayMember = "Ukupno";
        }
        List<Relacija> listaRelacija = new List<Relacija>();
        private void unosRelacijaPotvrda_Click(object sender, EventArgs e)
        {
            listaRelacija.Add(new Relacija(unosRelacijeIme.Text, float.Parse(unosRelacijeX.Text), float.Parse(unosRelacijeY.Text)));
            popisRelacija.DataSource = null;
            popisRelacija.DataSource = listaRelacija;
            popisRelacija.DisplayMember = "Ukupno";
        }
        Relacija prva;
        public void odabirPrva_Click(object sender, EventArgs e)
        {
                  prva= popisRelacija.SelectedItem as Relacija;
            testPrva.Text = prva.ImeRelacije;
        }
        Relacija druga;
        Relacija Finalna;
        public void odabirDruga_Click(object sender, EventArgs e)
        {
           
             druga= popisRelacija.SelectedItem as Relacija;
            testDruga.Text = druga.ImeRelacije;
             Finalna= Relacija.IzracunajUdaljenost(prva, druga);
            ispisRelacijaUdaljenost.Text = Finalna.ImeRelacije + " " + Finalna.KoordinataX + ":" + Finalna.KoordinataY;
        }
        Automobil odabraniAuto;
        private void odabirAutomobila_Click(object sender, EventArgs e)
        {
            odabraniAuto = popisAuta.SelectedItem as Automobil;
            ispisRezultat.Text = Relacija.Brzina(Finalna, odabraniAuto);
        }
    }
}
