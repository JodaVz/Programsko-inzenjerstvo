using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using PIHelper;
using System.Windows.Forms;

namespace WindowsFormsApp20
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
                if (item.GetType() == typeof(TextBox))
                {
                    Thread dretva = new Thread(new ParameterizedThreadStart(funkcija));
                    dretva.Start(item);
                }
            }
        }
        private void funkcija(object o)
        {
            TextBox tb = (TextBox)o;
            tb.BeginInvoke((MethodInvoker)delegate
            {
                tb.BackColor = op.GetRandomColor();
            });
        }
    }
}
