using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using PIHelper;

namespace PI_Vjezbe_6_G01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Operations operacija = new Operations();
        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(PictureBox))
                {

                    Thread dretva = new Thread(new ParameterizedThreadStart(Metoda));
                    dretva.Start(item);

                }
            }
        }

        public void Metoda(object o)
        {
            PictureBox pb = o as PictureBox;
            pb.Invoke((MethodInvoker)delegate {

                pb.BackgroundImage = operacija.GetRandomImage();

            });


        }
    }
}
