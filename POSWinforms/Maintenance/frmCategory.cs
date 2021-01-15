using MetroSet_UI.Forms;
using POSWinforms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POSWinforms.Maintenance
{
    public partial class frmCategory : MetroSetForm
    {
        private Category category;

        public frmCategory()
        {
            InitializeComponent();
        }

        private void txtItemCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemCode.Text))
            {
                e.Cancel = true;
                txtItemCode.Focus();
                errorProvider1.SetError(txtItemCode, "Please enter item code!");
            }
            else if (Regex.IsMatch(txtItemCode.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
                txtItemCode.Focus();
                errorProvider1.SetError(txtItemCode, "Please input letters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtItemCode, null);
            }
        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                txtDescription.Focus();
                errorProvider1.SetError(txtDescription, "Please enter the description!");
            }
            else if (Regex.IsMatch(txtDescription.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
                txtDescription.Focus();
                errorProvider1.SetError(txtDescription, "Please input letters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void clearFields()
        {
            category = null;
            dgvCategories.ClearSelection();
            btnAdd.Text = "Add";
            txtItemCode.Text = "";
            txtDescription.Text = "";
            btnUpdate.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("Add"))
            {
                btnAdd.Text = "Save";
                txtItemCode.ReadOnly = false;
                txtItemCode.Text = "";
                txtDescription.Text = "";
                btnUpdate.Enabled = false;
                category = null;
                dgvCategories.ClearSelection();
            }
            else if (btnAdd.Text.Equals("Save"))
            {

                // Save new category here.
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    var newCategory = new tblCategory
                    {
                        ItemCode = txtItemCode.Text,
                        ItemDescription = txtDescription.Text
                    };
                    DatabaseHelper.db.tblCategories.InsertOnSubmit(newCategory);
                    DatabaseHelper.db.SubmitChanges();

                    MetroSetMessageBox.Show(this, "Category added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAdd.Text = "Add";
                    clearFields();
                    LoadAllCategories();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var updateCategory = (from s in DatabaseHelper.db.tblCategories
                                     where s.ItemCode == txtItemCode.Text
                                     select s).FirstOrDefault();
                if(updateCategory != null)
                {
                    updateCategory.ItemDescription = txtDescription.Text;
                    DatabaseHelper.db.SubmitChanges();
                    MetroSetMessageBox.Show(this, "Item '" + updateCategory.ItemCode + "' successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    LoadAllCategories();
                }
            }
        }

        private void LoadAllCategories()
        {
            var allCategories = from s in DatabaseHelper.db.tblCategories
                                select s;
            dgvCategories.Rows.Clear();
            foreach(var category in allCategories)
            {
                dgvCategories.Rows.Add(
                        category.ItemCode,
                        category.ItemDescription
                    );
            }
            dgvCategories.ClearSelection();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            LoadAllCategories();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                category = new Category();
                category.ItemCode = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
                category.ItemDescription = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtItemCode.Text = category.ItemCode;
                txtDescription.Text = category.ItemDescription;
                btnUpdate.Enabled = true;

                txtItemCode.ReadOnly = true;
                btnAdd.Text = "Add";
            }
        }
    }
}
