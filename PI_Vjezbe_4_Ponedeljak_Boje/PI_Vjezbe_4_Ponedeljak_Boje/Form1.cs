using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_Ponedeljak_Boje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Boje> listaB = new List<Boje>();
        int crvena = 0;
        int zelena = 0;
        int plava = 0;
        int i = 0;
        private void potvrdaUnosa_Click(object sender, EventArgs e)
        {
            crvena = int.Parse(bojeUnosPCrvena.Text.ToString());
            zelena = int.Parse(bojeUnosZelena.Text.ToString());
            plava = int.Parse(bojeUnosPlava.Text.ToString());
            listaB.Add(new Boje(crvena, zelena, plava));
            ispisBoja.Items.Add("R:" + crvena + " G:" + zelena + " B:" + plava);

        }

        private void potvrdaPromjene_Click(object sender, EventArgs e)
        {

            BackColor = Color.FromArgb(listaB[i].CrvenaBoja, listaB[i].ZelenaBoja, listaB[i].PlavaBoja);
            i++;
            if (i == (listaB.Count)) i = 0;

        }


    }






    //System.Threading.Thread.Sleep(5000);




   
    
}
