using System;
using PIHelper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        Operations op = new Operations();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(PictureBox))
                {
                    Thread dretva = new Thread(new ParameterizedThreadStart(funkcija));
                    dretva.Start(item);
                }
            }
        }
        public void funkcija(object o)
        {
            PictureBox pb = (PictureBox) o;
            pb.BeginInvoke((MethodInvoker) delegate
            {
                pb.Image = op.GetRandomImage();
            });
        }
    }
}
