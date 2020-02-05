using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_4
{
    public partial class Form1 : Form
    {
        Tekstovi novi = new Tekstovi(null);
        public Form1()
        {
            InitializeComponent();
        }

        private void unosTeksta_TextChanged(object sender, EventArgs e)
        {
            ispisTeksta.Text = novi.Ispis(unosTeksta.Text);
        }
    }
}
