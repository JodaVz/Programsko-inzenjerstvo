using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_Ponedeljak_Palindromi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void upisRecenice_TextChanged(object sender, EventArgs e)
        {
            Recenice recenica = new Recenice(upisRecenice.Text);
            recenica.ProvjeraPalindroma(upisRecenice.Text);
            if (recenica.ProvjeraPalindroma(upisRecenice.Text) == true)
            {
                potvrdaRezultata.Text = "Recenica je palindrom";
            }
            else potvrdaRezultata.Text = "Recenica nije palindrom";
        }
    }
}
