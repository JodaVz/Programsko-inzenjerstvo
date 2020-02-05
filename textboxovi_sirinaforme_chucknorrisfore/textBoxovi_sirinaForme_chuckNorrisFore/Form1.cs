using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

using PIHelper;

namespace textBoxovi_sirinaForme_chuckNorrisFore
{
    public partial class Form1 : Form
    {
        Operations dohvatiMetodu = new Operations();

        /*
         * Ispuniti formu sa TextBoxovima tako da je svaki TextBox širok koliko je i forma široka, 
         * a razmak izmedu svakog TextBoxa je 5 px. U svaki TextBox se mora generirati RandomJoke
         */

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height = 300;
            this.Width = 1200;

            

            for (int i = 0; i < this.Height; i=i+25)
            {
                TextBox novi = new TextBox();
                this.Controls.Add(novi);
                novi.Location = new Point(0, i);
                novi.Width = this.Width;

                Thread dretva = new Thread(new ParameterizedThreadStart(promijeniTekst));
                dretva.Start(novi);
            }
        }

        private void promijeniTekst(object podatak)
        {
            TextBox tb = podatak as TextBox;
            tb.Invoke((MethodInvoker)delegate
            {
                string tekst = dohvatiMetodu.GetRandomJoke();
                tb.Text = tekst;
            });

            TimeSpan proslo = TimeSpan.FromSeconds(5);
            DateTime pocetno = DateTime.Now;
            while (DateTime.Now-pocetno>proslo)
            {
                tb.Text = "";
            }

            /*
            while (true)
            {
                TextBox tb = podatak as TextBox;
                tb.Invoke((MethodInvoker)delegate 
                {
                    string tekst = dohvatiMetodu.GetRandomJoke();
                    tb.Text = tekst;
                });


                //System.Threading.Thread.Sleep(10000);
            }*/

        }
    }
}
