using MetroSet_UI.Forms;
using POSWinforms.Maintenance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POSWinforms.Models;

namespace POSWinforms.Transaction
{
    public partial class frmAddItem : MetroSetForm
    {
        //double subTotal = Price * Quantity;
        //        if (Discount > 0)
        //        {

        //            double discountedTotal = subTotal - (subTotal * Discount / 100);
        //            return discountedTotal;
        //        }
        //        return subTotal;
        private int quantity = 1;
        private int discount = 0;
        private long nextID = 1;
        private long invoiceID = 0;
        private Item item;

        public frmAddItem(long invoiceID)
        {
            this.invoiceID = invoiceID;
            InitializeComponent();
            timer1.Start();
        }

        private void btnSelectItem_Click(object sender, EventArgs e)
        {
            var frm = new frmItem();
            frm.selectItemMode();
            frm.ShowDialog();
            if(DatabaseHelper.item != null)
            {
                item = DatabaseHelper.item;
                txtItemCode.Text = item.ItemCode;
                txtItemDescription.Text = item.ItemDescription;
                txtUnitPrice.Text = item.UnitPrice.ToString("0.00");

            }
        }

        private void quantitySelector_ValueChanged(object sender, EventArgs e)
        {
            if(quantitySelector.Value > 0)
            {
                quantity = (int)quantitySelector.Value;
            }
        }

        private void discountSelector_ValueChanged(object sender, EventArgs e)
        {
            if(discountSelector.Value > 0)
            {
                discount = (int)discountSelector.Value;
            }
            else
            {
                discount = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (item != null && quantity > 0)
            {
                double subTotal = item.UnitPrice * quantity;
                if (discount > 0)
                {
                    double discountedTotal = subTotal - (subTotal * discount / 100);
                    txtTotal.Text = discountedTotal.ToString("0.00");
                }
                else
                {
                    txtTotal.Text = subTotal.ToString("0.00");
                }
            }
            
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (item != null) {
                DatabaseHelper.cartList.Add(new OrderDetail
                {
                    ID = nextID,
                    ItemCode = item.ItemCode,
                    ItemDescription = item.ItemDescription,
                    ItemNumber = item.ItemNumber,
                    Discount = discount,
                    Quantity = quantity,
                    Price = item.UnitPrice,
                    Total = double.Parse(txtTotal.Text),
                    OrderID = invoiceID,
                });
                MetroSetMessageBox.Show(this, "Added to cart!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MetroSetMessageBox.Show(this, "No item was selected!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmAddItem_Load(object sender, EventArgs e)
        {
            if(DatabaseHelper.cartList.Count > 0)
            {
                nextID = DatabaseHelper.cartList.OrderByDescending(x => x.ID).Select(x => x.ID).FirstOrDefault();
                nextID += 1;
            }
        }
    }
}
