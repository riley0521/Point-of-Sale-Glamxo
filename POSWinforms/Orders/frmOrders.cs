using MetroSet_UI.Forms;
using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Linq.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace POSWinforms
{
    public partial class frmOrders : Form
    {
        private List<tblOrder> orders = new List<tblOrder>();

        public frmOrders()
        {
            InitializeComponent();
        }

        private void loadAllOrders(string searchedOrder)
        {
            orders.Clear();
            if (searchedOrder == null)
            {
                orders = (from order in DatabaseHelper.db.tblOrders
                            select order).ToList();
                
            }
            else 
            {
                orders = (from order in DatabaseHelper.db.tblOrders
                                    where SqlMethods.Like(order.ID.ToString(), "%" + searchedOrder + "%") ||
                                    SqlMethods.Like(order.CustomerID.ToString(), "%" + searchedOrder + "%")
                                    select order).ToList();
                
            }

            dgvOrders.Rows.Clear();
            foreach(var order in orders)
            {
                dgvOrders.Rows.Add(
                        order.ID,
                        order.CustomerID,
                        order.OrderStatus,
                        order.OrderDate.ToString("MM/dd/yyyy"),
                        order.Total.ToString("C2"),
                        order.Cash.ToString("C2"),
                        order.Change.ToString("C2")
                    );
            }
            dgvOrders.ClearSelection();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            loadAllOrders(null);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length == 0)
            {
                loadAllOrders(null);
            }
            else if(txtSearch.Text.Length > 0)
            {
                loadAllOrders(txtSearch.Text);
            }
            
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long selectedID = Convert.ToInt64(dgvOrders.Rows[e.RowIndex].Cells[0].Value);

                List<tblOrderDetail> orderDetails = (from orderDetail in DatabaseHelper.db.tblOrderDetails
                                                     where selectedID == orderDetail.OrderID
                                                     select orderDetail).ToList();
                frmOrderDetail frm = new frmOrderDetail();
                frm.setOrderDetail(orderDetails);
                frm.ShowDialog();
            }
        }
    }
}
