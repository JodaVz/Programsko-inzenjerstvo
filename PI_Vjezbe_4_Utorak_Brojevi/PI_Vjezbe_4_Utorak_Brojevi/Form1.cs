using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_4_Utorak_Brojevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> listaBrojeva = new List<int>();
        private void unosBroja_Click(object sender, EventArgs e)
        {
            string ispisNormalan = "";
            listaBrojeva.Add(int.Parse(unosBroj.Text));
            foreach (int item in listaBrojeva)
            {
                ispisNormalan += item.ToString()+",";
            }
            ispisNormalna.Text = ispisNormalan;
        }
        
        private void unosSortiraj_Click(object sender, EventArgs e)
        {
            
            string ispisSortiran = "";
            listaBrojeva.Sort();
            foreach (int item in listaBrojeva)
            {
                ispisSortiran += item.ToString() + ",";
            }
            ispisSortirana.Text = ispisSortiran;

        }
    }
}
