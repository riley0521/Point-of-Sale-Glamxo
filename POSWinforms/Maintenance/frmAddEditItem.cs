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

namespace POSWinforms.Maintenance
{
    public partial class frmAddEditItem : MetroSetForm
    {

        private string itemCode = "";
        private long newItemNo = 0;
        public frmAddEditItem()
        {
            InitializeComponent();
        }

        public void updateItem(Item item)
        {
            this.Text = "Update Item";
            cmbCategory.Enabled = false;
            txtCode.Text = item.ItemCode + "-" + item.ItemNumber.ToString("000");
            txtDescription.Text = item.ItemDescription;
            txtSize.Text = item.Size;
            txtUnitPrice.Text = item.UnitPrice.ToString();
            txtQuantity.Text = item.Stocks.ToString();
            txtReProduceLevel.Text = item.ReStockLevel.ToString();
        }

        public void addItem()
        {
            this.Text = "Add Item";
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategory.SelectedIndex >= 0)
            {
                var itemNo = (from s in DatabaseHelper.db.tblItems
                              where s.ItemCode == cmbCategory.SelectedItem.ToString()
                              orderby s.ItemNumber descending
                              select s).FirstOrDefault();
                if (itemNo != null)
                {
                    newItemNo = itemNo.ID + 1;
                    itemCode = newItemNo.ToString("000");
                }
                else
                {
                    newItemNo = 1;
                    itemCode = newItemNo.ToString("000");
                }
                txtCode.Text = cmbCategory.SelectedItem.ToString() + "-" + itemCode;
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Please enter item description!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void txtSize_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSize.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtSize, "Please enter item size!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtSize, null);
            }
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQuantity, "Please enter item quantity!");
            }
            else if(!int.TryParse(txtQuantity.Text, out int j)) 
            {
                e.Cancel = true;
                errorProvider1.SetError(txtQuantity, "Quantity should be number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtQuantity, null);
            }
        }

        private void txtUnitPrice_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUnitPrice, "Please enter item price!");
            }
            else if (!double.TryParse(txtUnitPrice.Text, out double j))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUnitPrice, "Unit Price should be number ex. 12.50!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUnitPrice, null);
            }
        }

        private void txtReProduceLevel_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReProduceLevel.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtReProduceLevel, "Please enter item re-produce level!");
            }
            else if (!int.TryParse(txtReProduceLevel.Text, out int j))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtReProduceLevel, "Reproduce Level should be number ex. 10!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtReProduceLevel, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                if (this.Text.Equals("Add Item"))
                {
                    var newItem = new tblItem
                    {
                        ItemNumber = newItemNo,
                        ItemCode = cmbCategory.SelectedItem.ToString(),
                        ItemDescription = txtDescription.Text,
                        ReStockLevel = int.Parse(txtReProduceLevel.Text),
                        Size = txtSize.Text,
                        Stocks = int.Parse(txtQuantity.Text),
                        UnitPrice = double.Parse(txtUnitPrice.Text)
                    };
                    DatabaseHelper.db.tblItems.InsertOnSubmit(newItem);
                    DatabaseHelper.db.SubmitChanges();
                    MetroSetMessageBox.Show(this, "Item added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (this.Text.Equals("Update Item"))
                {
                    MetroSetMessageBox.Show(this, "Updating...", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void frmAddEditItem_Load(object sender, EventArgs e)
        {
            
            var allCategory = from s in DatabaseHelper.db.tblCategories
                           select s.ItemCode;
            foreach(var category in allCategory)
            {
                cmbCategory.Items.Add(category);
            }

        }
    }
}
