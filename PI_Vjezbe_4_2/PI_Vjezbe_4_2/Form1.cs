using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_2
{
    public partial class Form1 : Form
    {
        
        string trosak = "";
        float cijena = 0;
        List<Troskovi> listaT = new List<Troskovi>();
        public Form1()
        {
            InitializeComponent();
        }

        private void KategorijaHrana_CheckedChanged(object sender, EventArgs e)
        {
            trosak = "Hrana";
        }

        private void KategorijaZabava_CheckedChanged(object sender, EventArgs e)
        {
            trosak = "Zabava";
        }

        private void KategorijaZdravlje_CheckedChanged(object sender, EventArgs e)
        {
            trosak = "Zdravlje";
        }

        private void KategorijaEdukacija_CheckedChanged(object sender, EventArgs e)
        {
            trosak = "Edukacija";
        }

        private void Potvrda_Click(object sender, EventArgs e)
        {
            cijena = float.Parse(UpisCijena.Text);
            Troskovi troskic = new Troskovi(trosak, cijena);
            listaT.Add(troskic);
            
            IspisTrosak.Text+=troskic.NazivTroska + " , " + troskic.VrijednostTroska +"\n";
           
        }
        

        
    }
}
