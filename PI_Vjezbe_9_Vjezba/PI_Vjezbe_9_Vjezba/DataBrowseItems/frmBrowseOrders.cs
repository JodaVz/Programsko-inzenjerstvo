using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_Vjezbe_9_Vjezba.DataBrowseItems
{
    public partial class frmBrowseOrders : Form
    {
        public frmBrowseOrders()
        {
            InitializeComponent();
        }

        private void ordersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ordersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.northwnd2016DataSet);

        }

        private void frmBrowseOrders_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwnd2016DataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.northwnd2016DataSet1.Products);
            // TODO: This line of code loads data into the 'northwnd2016DataSet.Order_Details' table. You can move, or remove it, as needed.

            // TODO: This line of code loads data into the 'northwnd2016DataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.northwnd2016DataSet.Orders);

        }

        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (ordersDataGridView.RowCount > 0)
            {
                int orderID =
               int.Parse(ordersDataGridView.CurrentRow.Cells[0].Value.ToString());

                this.order_DetailsTableAdapter.FillByOrderID(this.northwnd2016DataSet.Order_Details,
                orderID);
            }
        }
    }
}
