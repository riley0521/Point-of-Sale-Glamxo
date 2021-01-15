using MetroSet_UI.Forms;
using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWinforms.Transaction
{
    public partial class frmTransaction : MetroSetForm
    {
        private long invoiceNo = 1000000001;
        private long customerNo = 1;
        private double total = 0d;
        public frmTransaction()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void loadAllItemsFromCart()
        {
            if(DatabaseHelper.cartList.Count > 0)
            {
                dgvCart.Rows.Clear();
                total = 0d;
                foreach(var item in DatabaseHelper.cartList)
                {
                    //Console.WriteLine(item.ID);
                    total += item.Total;
                    dgvCart.Rows.Add(
                            item.ItemNumber,
                            item.ItemCode,
                            item.ItemDescription,
                            item.Quantity,
                            item.Price.ToString("0.00"),
                            item.Discount,
                            item.Total.ToString("0.00")
                        );
                }
                lbTotal.Text = total.ToString("0.00");
                dgvCart.ClearSelection();
            }
        }
        
        private void newTransaction()
        {
            var orderNumber = (from s in DatabaseHelper.db.tblOrders
                               orderby s.ID descending
                               select s.ID).FirstOrDefault();
            var customerNumber = (from s in DatabaseHelper.db.tblOrders
                                  orderby s.CustomerID descending
                                  select s.CustomerID).FirstOrDefault();
            if (orderNumber > 0)
            {
                invoiceNo += 1;
                lbInvoiceNo.Text = invoiceNo.ToString();
            }
            else
            {
                lbInvoiceNo.Text = invoiceNo.ToString();
            }

            if (customerNumber > 0)
            {
                customerNo += 1;
                lbCustomerNo.Text = customerNo.ToString();
            }
            else
            {
                lbCustomerNo.Text = customerNo.ToString();
            }
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            string fullName = DatabaseHelper.user.LastName + ", " + DatabaseHelper.user.FirstName + " " + DatabaseHelper.user.MiddleName;
            lbUser.Text = "User: " + fullName.Trim();
            lbPosition.Text = "Position: " + DatabaseHelper.user.Position;
            newTransaction();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string dateToday = DateTime.Now.ToString("dddd - MMMM dd, yyyy");
            string timeToday = DateTime.Now.ToString("hh:mm:ss tt");
            lbDate.Text = "Date: " + dateToday.Trim();
            lbTime.Text = "Time: " + timeToday.Trim();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new frmAddItem(invoiceNo).ShowDialog();
            loadAllItemsFromCart();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            DatabaseHelper.cartList.Clear();
            newTransaction();
            MetroSetMessageBox.Show(this, "Cart cleared!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
