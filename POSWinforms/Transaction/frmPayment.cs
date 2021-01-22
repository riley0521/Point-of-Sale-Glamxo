using MetroSet_UI.Forms;
using POSWinforms.Models;
using POSWinforms.Transaction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    public partial class frmPayment : Form
    {

        private decimal total = 0;
        private decimal change = 1;
        private decimal cash = 0;

        private DateTime dateNow;
        private string timeToday = "";

        private List<Item> itemList = new List<Item>();

        public frmPayment()
        {
            InitializeComponent();
        }

        public void setTotal(decimal total, DateTime dateNow, string timeToday)
        {
            this.total = total;
            this.dateNow = dateNow;
            this.timeToday = timeToday;
            txtTotal.Text = total.ToString("0.00");
            var allItems = from s in DatabaseHelper.db.tblItems
                           select s;
            foreach(var item in allItems)
            {
                itemList.Add(new Item
                {
                    ID = item.ID,
                    ItemCode = item.ItemCode,
                    ItemDescription = item.ItemDescription,
                    ItemNumber = item.ItemNumber,
                    ReStockLevel = item.ReStockLevel,
                    Size = item.Size,
                    Stocks = item.Stocks,
                    UnitPrice = item.UnitPrice
                });
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (change <= 0 && txtCash.Text.Length > 0)
            {
                DialogResult dr = MessageBox.Show("Do you really want to continue? You cannot undo this action", "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dr == DialogResult.Yes)
                {
                    change = Math.Abs(change);

                    var newOrder = new tblOrder
                    {
                        ID = frmTransaction.invoiceNo,
                        CustomerID = frmTransaction.customerNo,
                        OrderStatus = "PAID",
                        OrderDate = DateTime.Parse(dateNow.ToString("MM/dd/yyyy")),
                        Total = total,
                        Cash = cash,
                        Change = change
                    };
                    DatabaseHelper.db.tblOrders.InsertOnSubmit(newOrder);
                    DatabaseHelper.db.SubmitChanges();

                    var st = (from tbl in itemList
                              join cart in DatabaseHelper.cartList on tbl.ItemCode equals cart.ItemCode
                              select new
                              {
                                  tbl.ItemCode,
                                  tbl.Stocks,
                                  cart.Quantity
                              }).ToList();

                    foreach (var item in st)
                    {
                        var reduceStock = (from s in DatabaseHelper.db.tblItems
                                           where s.ItemCode == item.ItemCode
                                           select s).First();
                        reduceStock.Stocks = (item.Stocks - item.Quantity);

                    }

                    DatabaseHelper.db.SubmitChanges();


                    foreach (var item in DatabaseHelper.cartList)
                    {
                        var newOrderDetail = new tblOrderDetail
                        {
                            ItemCode = item.ItemCode,
                            ItemNumber = item.ItemNumber,
                            ItemDescription = item.ItemDescription,
                            Quantity = item.Quantity,
                            Price = item.Price,
                            Discount = item.Discount,
                            Total = item.Total,
                            OrderID = frmTransaction.invoiceNo
                        };
                        DatabaseHelper.db.tblOrderDetails.InsertOnSubmit(newOrderDetail);
                    }
                    DatabaseHelper.db.SubmitChanges();

                    frmPrint frm = new frmPrint();
                    frm.printInvoice(
                           frmTransaction.customerNo,
                           frmTransaction.invoiceNo,
                           frmTransaction.fullName,
                           dateNow,
                           timeToday,
                           total,
                           cash,
                           change,
                           DatabaseHelper.cartList
                        );
                    MessageBox.Show("You can save this document", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frm.ShowDialog();
                    Close();
                }

            }
            else
            {
                MessageBox.Show("Please pay exact amount or more than the total amount", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            if(decimal.TryParse(txtCash.Text, out decimal cash))
            {
                this.cash = cash;
                change = total - cash;
                txtChange.Text = change.ToString("0.00");
            }
            else
            {
                change = 1;
                txtCash.Text = "";
            }
        }
    }
}
