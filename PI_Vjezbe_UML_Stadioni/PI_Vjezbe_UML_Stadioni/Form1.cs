using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_UML_Stadioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        List<Stadion> PopisStadiona = new List<Stadion>();
       
        private void unosStadionPotvrda_Click(object sender, EventArgs e)
        {
            PopisStadiona.Add(new Stadion(unosStadion.Text, unosAdresa.Text));
            listaStadiona.DataSource = null;
            listaStadiona.DataSource = PopisStadiona;
            listaStadiona.DisplayMember = "ImeStadiona";
           // listaStadiona.ValueMember = "AdresaStadiona";
           
         
            
           
        }
    }
}
