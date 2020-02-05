using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DNA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSpremi_Click(object sender, EventArgs e)
        {
            
            Baze baza = new Baze();
            //txtTest.Text = baza.Upis(txtBazaUpis.Text);
            List<string> listaBaza = new List<string>();
            listaBaza.Add(baza.Upis(txtBazaUpis.Text));
            lstListaBaza.Items.Add(baza.Upis(txtBazaUpis.Text));
            txtBazaUpis.Clear();
            
        }

        private void btnMutiraj_Click(object sender, EventArgs e)
        {
            Baze baza = new Baze();
            string[] genomi = { "A", "C", "T", "G" };
            Random rand = new Random();
            int odabir = rand.Next(1, 4);
            string randomGenomi = genomi[rand.Next(genomi.Length)];
            txtTestRandom.Text = randomGenomi;
            string promjenaElementa = "";
            switch (odabir)
            {
                case 1:
                    {
//Dodaj random element
                       // txtTest.Text = baza.Upis(randomGenomi);
                        List<string> listaBaza = new List<string>();
                        listaBaza.Add(baza.Upis(randomGenomi));
                        lstListaBaza.Items.Add(baza.Upis(randomGenomi));
                        break;
                    }
                case 2:
                    {
                        //Izbrisi random element
                        int duzina = rand.Next(lstListaBaza.Items.Count);
                        if (lstListaBaza.Items.Count > 0)
                        {
                            lstListaBaza.Items.RemoveAt(duzina);
                        }
                        break;
                    }
//txtTestRandom.Clear();
            default:
                    break;


        }
    }
    }
}
