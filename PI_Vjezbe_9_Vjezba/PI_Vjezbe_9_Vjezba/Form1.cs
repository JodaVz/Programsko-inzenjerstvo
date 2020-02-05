using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_9_Vjezba
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void miDataBrowseItems_MouseUp(object sender, MouseEventArgs e)
        {
            DataBrowseItems.frmBrowseOrders browseFormOrders = new DataBrowseItems.frmBrowseOrders();
            browseFormOrders.MdiParent = this;
            browseFormOrders.WindowState = FormWindowState.Maximized;
            browseFormOrders.Show();
        }
    }
}
