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

namespace WindowsFormsApp21
{
    public partial class Form1 : Form
    {
        Operations op = new Operations();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item.GetType() == typeof(Button))
                {
                    Thread dretva = new Thread(new ParameterizedThreadStart(funkcija));
                    dretva.Start(item);
                }
            }
        }
        private void funkcija(object o)
        {
            Button btn = (Button)o;
            while (true)
            {
                btn.BeginInvoke((MethodInvoker)delegate
                {
                    btn.Location = op.GetRandomPoint(this.Width, this.Height);
                });
                Thread.Sleep(1000);
            }
        }
    }
}
