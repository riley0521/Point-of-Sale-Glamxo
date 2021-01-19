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
    public partial class frmItemStockEdit : MetroSetForm
    {

        private string itemCode = "";

        public frmItemStockEdit()
        {
            InitializeComponent();
        }

        public void setItemCode(string itemCode)
        {
            this.itemCode = itemCode;
        }

        private void txtQuantity_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                e.Cancel = true;
                MetroSetMessageBox.Show(this, "Please enter number of stocks that you would like to add.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(!int.TryParse(txtQuantity.Text, out int j))
            {
                e.Cancel = true;
                MetroSetMessageBox.Show(this, "Quantity must be number ex. 5", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                e.Cancel = false;

            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var editStocks = (from s in DatabaseHelper.db.tblItems
                             where s.ItemCode.Equals(itemCode)
                             select s).FirstOrDefault();
            if(editStocks != null)
            {
                editStocks.Stocks += int.Parse(txtQuantity.Text);
                DatabaseHelper.db.SubmitChanges();
                MetroSetMessageBox.Show(this, "Stocked in successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
