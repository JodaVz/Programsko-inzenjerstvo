using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PI_Vjezbe_6_RandomPractive_MaloDretvice
{
    //SAM SEBI ZADATAJ NEKI KURAC PA PROBAJ STIPKAT DA VIDIS KAJ TE JEBALO
    //ARTIKL,RACUN, znas kak ide 
    //Spucaj sve to u dretve, smisli nekej dok resis ovo gornje
    //Pogledaj onaj problem s updejtom liste, i probaj to slozit u dretvu
    //probaj dodati novi window/novi tabi
    public partial class Form1 : Form
    {
        //probaj da dretva updejta datasource
        public Form1()
        {
            InitializeComponent();


        }
        //missclick
        private void label3_Click(object sender, EventArgs e)
        {

        }
         List<Artikl> listaArtikla = new List<Artikl>();
        private void unosArtiklPotvrda_Click(object sender, EventArgs e)
        {
            Thread dretva = new Thread(UpdateDretva); //needs work
            dretva.Start();
            string pomocnaIme = unosArtiklNaziv.Text;
            float pomocnaCijena = float.Parse(unosArtiklCijena.Text);
            int pomocnaKolicina = int.Parse(unosArtiklKolicina.Text);
            listaArtikla.Add(new Artikl(pomocnaIme, pomocnaCijena, pomocnaKolicina));
           // UpdateDretva();
            

        }
        public  void UpdateDretva()//needs work
        {
            
                popisArtikala.DataSource = null;
                popisArtikala.DataSource = listaArtikla;
                popisArtikala.DisplayMember = "Ukupno";
                MessageBox.Show("Test za dretvu");

            

        }
         public Artikl odabrani;
        private void popisArtikala_MouseDown(object sender, MouseEventArgs e)
        {
            odabrani = popisArtikala.SelectedItem as Artikl;
            ispisArtiklOdabrani.Text = odabrani.Ukupno;
            ispisOdabraniNaziv.Text = odabrani.Naziv;
        }//radi

        private void unosPromjenaPotvrdi_Click(object sender, EventArgs e)
        {
            foreach (Artikl item in listaArtikla)
            {
                if (odabrani.Naziv == item.Naziv)
                {
                    item.Cijena= float.Parse(unosNovaCijena.Text);
                    item.Kolicina=int.Parse(unosNovaKolicina.Text);
                    item.Ukupno= odabrani.Naziv + " kosta " + float.Parse(unosNovaCijena.Text) + " kuna ," + int.Parse(unosNovaKolicina.Text) + " komada kosta" + (float.Parse(unosNovaCijena.Text) * int.Parse(unosNovaKolicina.Text));

                    break;

                }
            }
            
            popisArtikala.DataSource = null;
            popisArtikala.DataSource = listaArtikla;
            popisArtikala.DisplayMember = "Ukupno";
        }//radi
    }
}
