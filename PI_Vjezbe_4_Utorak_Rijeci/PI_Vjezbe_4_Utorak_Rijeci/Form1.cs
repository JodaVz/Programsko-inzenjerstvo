using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_Utorak_Rijeci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void gumbPotvrda_Click(object sender, EventArgs e)
        {
            Recenice recenica = new Recenice(unosRecenice.Text);
            ispisObratna.Text = recenica.Okretac(unosRecenice.Text);
            ispisSlova.Text = recenica.BrojacSlova(unosRecenice.Text).ToString();
            ispisRijeci.Text = recenica.BrojacRijeci(unosRecenice.Text).ToString();
            ispisPretraga.Text = recenica.Pretraga(unosRecenice.Text,unosPretraga.Text).ToString();


        }
    }
}
