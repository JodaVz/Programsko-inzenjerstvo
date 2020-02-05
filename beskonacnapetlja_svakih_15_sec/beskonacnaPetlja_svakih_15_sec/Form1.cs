using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PIHelper;
using System.Threading;

namespace beskonacnaPetlja_svakih_15_sec
{
    public partial class Form1 : Form
    {
        Operations dohvatiSliku = new Operations();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            while (true)
            {
                foreach (var item in this.Controls.OfType<PictureBox>())
                {
                    Thread dretva = new Thread(new ParameterizedThreadStart(mijenjajSliku));
                    dretva.Start(item);
                }
            }
        }

        private void mijenjajSliku(object podatak)
        {
            PictureBox picBox = podatak as PictureBox;
            Image slika = dohvatiSliku.GetRandomImage();
            picBox.BackgroundImage = slika;

            System.Threading.Thread.Sleep(10000);

            /*picBox.Invoke((MethodInvoker)delegate ()
            {
                Image slika = dohvatiSliku.GetRandomImage();
                picBox.BackgroundImage = slika;
            });*/
        }
    }
}
