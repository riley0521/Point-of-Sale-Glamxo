using MetroSet_UI.Forms;
using POSWinforms.Maintenance;
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
        public static long invoiceNo = 1000000001;
        public static long customerNo = 1;
        public static decimal total = 0;
        public static string fullName = "";

        private DateTime dateNow;
        private string dateToday = "";
        private string timeToday = "";

        private long ID;
        
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
                total = 0;
                foreach(var item in DatabaseHelper.cartList)
                {
                    Console.WriteLine(item.ID);
                    total += item.Total;
                    dgvCart.Rows.Add(
                            item.ItemCode,
                            item.ItemDescription,
                            item.Quantity,
                            item.Price.ToString("0.00"),
                            item.Discount,
                            item.Total.ToString("0.00")
                        );
                }
                lbTotal.Text = total.ToString("C2");
                dgvCart.ClearSelection();
                enableButtons(true);
            }
            else
            {
                dgvCart.Rows.Clear();
                total = 0;
                lbTotal.Text = total.ToString("C2");
                enableButtons(false);
            }
        }

        public void enableButtons(bool flag)
        {
            btnNewTransaction.Enabled = flag;
            btnRemoveItem.Enabled = flag;
            btnDiscountItem.Enabled = flag;
            btnPayment.Enabled = flag;
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
                orderNumber += 1;
                invoiceNo = orderNumber;
                lbInvoiceNo.Text = invoiceNo.ToString();
            }
            else
            {
                lbInvoiceNo.Text = invoiceNo.ToString();
            }

            if (customerNumber > 0)
            {
                customerNumber += 1;
                customerNo = customerNumber;
                lbCustomerNo.Text = customerNo.ToString();
            }
            else
            {
                lbCustomerNo.Text = customerNo.ToString();
            }
        }

        private void frmTransaction_Load(object sender, EventArgs e)
        {
            dateNow = DateTime.Now;
            fullName = DatabaseHelper.user.LastName + ", " + DatabaseHelper.user.FirstName + " " + DatabaseHelper.user.MiddleName;
            lbUser.Text = "User: " + fullName.Trim();
            lbPosition.Text = "Position: " + DatabaseHelper.user.Position;
            lbTotal.Text = 0.ToString("C2");
            newTransaction();
            enableButtons(false);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dateToday = DateTime.Now.ToString("dddd - MMMM dd, yyyy");
            timeToday = DateTime.Now.ToString("hh:mm:ss tt");
            lbDate.Text = "Date: " + dateToday.Trim();
            lbTime.Text = "Time: " + timeToday.Trim();
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            new frmSelectItem(invoiceNo).ShowDialog();
            loadAllItemsFromCart();
        }

        private void btnNewTransaction_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.cartList.Count > 0)
            {
                DialogResult dialogResult = MetroSetMessageBox.Show(this, "Are you sure want to add new transaction? Current transaction will be overwritten.", "EXIT FORM",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DatabaseHelper.cartList.Clear();
                    newTransaction();
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (DatabaseHelper.cartList.Count > 0)
            {
                DialogResult dialogResult = MetroSetMessageBox.Show(this, "Are you sure to exit this form? All items from you cart will be deleted.", "EXIT FORM",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    DatabaseHelper.cartList.Clear();
                }
                else
                {
                    return;
                }
            }
            Close();
        }

        private void dgvCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                ID = DatabaseHelper.cartList[e.RowIndex].ID;
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if(ID > 0)
            {
                DialogResult dialogResult = MetroSetMessageBox.Show(this, "Are you sure to delete this item?", "DELETE ITEM", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    OrderDetail currentItem = DatabaseHelper.cartList.Where(x => x.ID == ID).FirstOrDefault();
                    DatabaseHelper.cartList.Remove(currentItem);
                    MetroSetMessageBox.Show(this, "Item deleted from cart!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ID = 0;
                    loadAllItemsFromCart();
                }
            }
            else
            {
                MetroSetMessageBox.Show(this, "No item was selected!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnDiscountItem_Click(object sender, EventArgs e)
        {
            if(ID > 0)
            {
                string itemCode = DatabaseHelper.cartList.Where(x => x.ID == ID).Select(s => s.ItemCode).FirstOrDefault();
                var frm = new frmEditDiscount();
                frm.setItemCode(itemCode);
                frm.ShowDialog();
                ID = 0;
                loadAllItemsFromCart();
            }
            else
            {
                MetroSetMessageBox.Show(this, "No item was selected!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            var frm = new frmPayment();
            frm.setTotal(total, dateNow, timeToday);
            frm.ShowDialog();
            newTransaction();
            loadAllItemsFromCart();
        }

        private void dgvCart_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                var editQty = DatabaseHelper.cartList.Where(x => x.ID == ID).FirstOrDefault();
                var maxStock = (from s in DatabaseHelper.db.tblItems
                                where s.ItemCode == editQty.ItemCode
                                select s.Stocks).FirstOrDefault();
                

                if(dgvCart.Rows[e.RowIndex].Cells[2].Value == null)
                {
                    MessageBox.Show("You cannot leave this field empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loadAllItemsFromCart();
                    return;
                }

                int newQuantity = int.Parse(dgvCart.Rows[e.RowIndex].Cells[2].Value.ToString());

                if (newQuantity > 99)
                {
                    MessageBox.Show("You cannot add more than 99 items of the same type in cart.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loadAllItemsFromCart();
                    return;
                }
                if (newQuantity > maxStock)
                {
                    MessageBox.Show("You have reached the maximum number of stocks available.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    loadAllItemsFromCart();
                    return;
                }
                editQty.Quantity = newQuantity;
                editQty.Total = frmSelectItem.getGrandTotal(editQty.Price, newQuantity, editQty.Discount);
                loadAllItemsFromCart();
            }
        }
    }
}
