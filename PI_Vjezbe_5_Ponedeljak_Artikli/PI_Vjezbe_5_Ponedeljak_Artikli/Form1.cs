using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_5_Ponedeljak_Artikli
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Artikl> listaArtikla = new List<Artikl>();

        private void unosArtiklPotvrda_Click(object sender, EventArgs e)
        {
            string pomocnaIme = "";
            int pomocnaKolicina = 0;
            float pomocnaCijena = 0;
            bool potvrda = false;
            pomocnaIme = unosArtiklNaziv.Text;
            pomocnaKolicina = int.Parse(UnosArtiklKolicina.Text);
            pomocnaCijena = float.Parse(unosArtiklCijena.Text);
            //foreach (Artikl item in listaArtikla)
            //{
            //    if (item.Ime == pomocnaIme)
            //    {
            //        item.Kolicina = item.Kolicina + pomocnaKolicina;
            //        item.Cijena = item.Cijena + pomocnaCijena;
            //        potvrda = true;

            //    }
            //}
            //if(potvrda==false)
            //{
                listaArtikla.Add(new Artikl(pomocnaIme, pomocnaKolicina, pomocnaCijena));
            //}



            popisArtikala.DataSource = null;
            popisArtikala.DataSource = listaArtikla;
            popisArtikala.DisplayMember = "Ukupno";
         }
    }
}
