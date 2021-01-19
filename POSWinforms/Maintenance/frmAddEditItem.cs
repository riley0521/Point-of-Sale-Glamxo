using MetroSet_UI.Forms;
using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq.SqlClient;
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
        private decimal unitPrice = 0;
        private int quantity = 0;
        private int restockLevel = 0;
        private long newItemNo = 1;
        private tblItem item;
        private List<tblCategory> categories = new List<tblCategory>();
        public frmAddEditItem()
        {
            InitializeComponent();
            categories = (from s in DatabaseHelper.db.tblCategories
                          select s).ToList();
            foreach (var category in categories)
            {
                cmbCategory.Items.Add(category.ItemDescription);
            }
        }

        public void updateItem(tblItem item)
        {
            this.item = item;
            this.Text = "Update Item";
            cmbCategory.Enabled = false;
            txtCode.Enabled = false;

            string[] descriptionFromCode = item.ItemCode.Split('-');
            string description = categories.Where(x => x.ItemCode.Equals(descriptionFromCode[0])).Select(x => x.ItemDescription).FirstOrDefault();
            cmbCategory.SelectedIndex = cmbCategory.Items.IndexOf(description);

            unitPrice = item.UnitPrice;
            quantity = item.Stocks;
            restockLevel = item.ReStockLevel;

            txtCode.Text = item.ItemCode;
            txtDescription.Text = item.ItemDescription;
            txtSize.Text = item.Size;
            txtUnitPrice.Text = unitPrice.ToString();
            txtQuantity.Text = quantity.ToString();
            txtReProduceLevel.Text = restockLevel.ToString();
        }

        public void addItem()
        {
            this.Text = "Add Item";
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbCategory.SelectedIndex >= 0)
            {
                string letterCode = categories[cmbCategory.SelectedIndex].ItemCode;
                var itemNo = (from s in DatabaseHelper.db.tblItems
                              where SqlMethods.Like(s.ItemCode, "%" + letterCode + "%")
                              orderby s.ItemCode descending
                              select s.ItemNumber).FirstOrDefault();
                if (itemNo > 0)
                {
                    newItemNo = itemNo + 1;
                }
                else
                {
                    newItemNo = 1;
                }
                txtCode.Text = letterCode + "-" + newItemNo.ToString("000");
                itemCode = letterCode + "-" + newItemNo.ToString("000");
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
            saveItem();
        }

        private void saveItem()
        {
            if (cmbCategory.SelectedIndex < 0)
            {
                MetroSetMessageBox.Show(this, "Please choose a category!", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (this.Text.Equals("Add Item"))
                {
                    var newItem = new tblItem
                    {
                        ItemNumber = newItemNo,
                        ItemCode = itemCode,
                        ItemDescription = txtDescription.Text,
                        ReStockLevel = restockLevel,
                        Size = txtSize.Text,
                        Stocks = quantity,
                        UnitPrice = unitPrice
                    };
                    DatabaseHelper.db.tblItems.InsertOnSubmit(newItem);
                    DatabaseHelper.db.SubmitChanges();
                    MetroSetMessageBox.Show(this, "Item added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if (this.Text.Equals("Update Item"))
                {
                    item.ItemDescription = txtDescription.Text;
                    item.Size = txtSize.Text;
                    item.ReStockLevel = restockLevel;
                    item.Stocks = quantity;
                    item.UnitPrice = unitPrice;
                    DatabaseHelper.db.SubmitChanges();

                    MetroSetMessageBox.Show(this, "Item updated successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void cmbCategory_Validating(object sender, CancelEventArgs e)
        {
            if (cmbCategory.SelectedIndex < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbCategory, "Please choose a category!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbCategory, null);
            }
        }

        private void txtUnitPrice_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtUnitPrice.Text, out decimal price))
            {
                this.unitPrice = price;
            }
            else
            {
                txtUnitPrice.Text = "";
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int qty))
            {
                this.quantity = qty;
            }
            else
            {
                txtQuantity.Text = "";
            }
        }

        private void txtReProduceLevel_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(txtReProduceLevel.Text, out int level))
            {
                this.restockLevel = level;
            }
            else
            {
                txtReProduceLevel.Text = "";
            }
        }

        private void txtReProduceLevel_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                saveItem();
            }
        }
    }
}
