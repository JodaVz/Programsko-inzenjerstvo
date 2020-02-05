using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrvaWindowsForma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Brojevi broj = new Brojevi();

            broj.prviBroj = int.Parse(textBox1.Text.ToString());
            broj.drugiBroj = int.Parse(textBox2.Text.ToString());
                broj = broj.Upis(broj.prviBroj,broj.drugiBroj);
                
            
                
                textBox3.Text=broj.Djelitelj(broj.prviBroj, broj.drugiBroj);
            textBox4.Text = broj.Visekratnik(broj.prviBroj, broj.drugiBroj);
                //broj.Visekratnik(broj.prviBroj, broj.drugiBroj);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
