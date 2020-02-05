using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        List<Govedo> listaGoveda = new List<Govedo>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Govedo tmpGovedo = new Govedo(textBox1.Text, comboBox1.SelectedItem.ToString(), comboBox2.SelectedItem.ToString());
            listaGoveda.Add(tmpGovedo);
            dataGridView1.DataSource = listaGoveda.Select(Govedo => new { Govedo.Naziv, Govedo.Spol, Govedo.Boja}).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = listaGoveda.Where(Govedo => Govedo.Spol.Equals(comboBox3.SelectedItem.ToString()[0])).Select(Govedo => new { Govedo.Naziv, Govedo.Spol, Govedo.Boja }).ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = listaGoveda.Where(Govedo => Govedo.Boja.Equals(comboBox4.SelectedItem.ToString()[0])).Select(Govedo => new { Govedo.Naziv, Govedo.Spol, Govedo.Boja }).ToList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = listaGoveda.Select(Govedo => new { Govedo.Naziv, Govedo.Spol, Govedo.Boja }).ToList();
        }
    }
}
