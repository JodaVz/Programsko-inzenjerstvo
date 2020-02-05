using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PI_Vjezbe_6_RandomNekiKurac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<int> listaBrojeva = new List<int>();
        Random rand = new Random();
        private void unosKreni_Click(object sender, EventArgs e)
        {
            //kaj radi prva dretva
            Thread prva = new Thread(() => {
               
                    Dodaj();
                    Thread.Sleep(200);
                
              


            });
            //kaj radi druga dretva
            Thread druga = new Thread(()=> {
               
                    int vrijednostNultog = listaBrojeva[0];
                    Makni();
                    Thread.Sleep(vrijednostNultog);
                
                
            });
            //pocetak prve
            prva.Start();
            //pocetak druge
            druga.Start();
            //cekaj da prva zavrsi
            prva.Join();
            //cekaj da druga zavrsi
            druga.Join();
            //popravi si prikaz u listi, jer nebu nist prikazivalo ovak, neda mi se vise
            popisBrojeva.DataSource = null;
            popisBrojeva.DataSource = listaBrojeva;

        }
        public  void Dodaj()
        {
            int broj = rand.Next(0,1000);
            listaBrojeva.Add(broj);
        }
        public  void Makni()
        {
           
            listaBrojeva.RemoveAt(0);

        }

    }
}
