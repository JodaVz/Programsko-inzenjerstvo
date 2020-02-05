using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Boje boja = null;
        List<Boje> listaBoja = new List<Boje>();
        int i = 0;

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            boja = new Boje();
            boja.Crvena = int.Parse(textBox1.Text);
            boja.Zelena = int.Parse(textBox2.Text);
            boja.Plava = int.Parse(textBox3.Text);
            textBox1.Text = "0";
            textBox2.Text = "0";
            textBox3.Text = "0";
            listaBoja.Add(boja);

            listBox1.Items.Add("R: " + boja.Crvena + "  G: " + boja.Zelena + "  B: " + boja.Plava);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(listaBoja[i].Crvena, listaBoja[i].Zelena, listaBoja[i].Plava);
            i++;
            if (i == listaBoja.Count())
            {
                i = 0;
            }
        }
    }
}