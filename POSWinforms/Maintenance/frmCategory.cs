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
        private List<tblCategory> allCategories = new List<tblCategory>();
        private string itemCode = "";

        public frmCategory()
        {
            InitializeComponent();
        }

        private void txtItemCode_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtItemCode.Text) && txtItemCode.Enabled)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtItemCode, "Please enter item code!");
            }
            else if (Regex.IsMatch(txtItemCode.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
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

            if (string.IsNullOrWhiteSpace(txtDescription.Text) && txtItemCode.Enabled)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Please enter the description!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void clearFields()
        {
            dgvCategories.ClearSelection();
            txtItemCode.Text = "";
            txtDescription.Text = "";
            txtItemCode.Enabled = false;
            btnClose.Text = "Close";
            dgvCategories.Focus();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Text.Equals("Add"))
            {
                btnAdd.Text = "Save";
                if (btnUpdate.Text.Equals("Save"))
                {
                    DialogResult dialogResult = MetroSetMessageBox.Show(this, "Would you like to cancel updating position?",
                        "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        btnUpdate.Text = "Update";
                        txtDescription.Text = "";
                    }
                    else
                    {
                        return;
                    }
                }
                txtItemCode.Enabled = true;
                btnClose.Text = "Cancel";
                dgvCategories.CellClick -= new DataGridViewCellEventHandler(dgvCategories_CellClick);
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
            if(btnUpdate.Text.Equals("Update"))
            {
                btnUpdate.Text = "Save";
                if (btnAdd.Text.Equals("Save"))
                {
                    DialogResult dialogResult = MetroSetMessageBox.Show(this, "Would you like to cancel adding category?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        btnAdd.Text = "Add";
                    }
                    else
                    {
                        return;
                    }
                }
                txtItemCode.Enabled = false;
                btnClose.Text = "Cancel";
                dgvCategories.CellClick += new DataGridViewCellEventHandler(dgvCategories_CellClick);
            }
            else if (btnUpdate.Text.Equals("Save"))
            {
                if (string.IsNullOrWhiteSpace(txtDescription.Text))
                {
                    MetroSetMessageBox.Show(this, "Please enter new description and do not leave that field empty.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var updateCategory = allCategories.Where(x => x.ItemCode.Equals(itemCode)).FirstOrDefault();
                if (updateCategory != null)
                {
                    DialogResult dialogResult = MetroSetMessageBox.Show(this, "Would you like to update this category?",
                        "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {

                        

                        if (ValidateChildren(ValidationConstraints.Enabled))
                        {
                            updateCategory.ItemDescription = txtDescription.Text;
                            DatabaseHelper.db.SubmitChanges();
                            MetroSetMessageBox.Show(this, "Item '" + updateCategory.ItemCode + "' successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            btnUpdate.Text = "Update";
                            clearFields();
                            LoadAllCategories();
                        }
                    }
                    
                }
                
                
            }
        }

        private void LoadAllCategories()
        {
            allCategories.Clear();
            allCategories = (from s in DatabaseHelper.db.tblCategories
                                select s).ToList();
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
            dgvCategories.CellClick -= new DataGridViewCellEventHandler(dgvCategories_CellClick);
            LoadAllCategories();
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                itemCode = dgvCategories.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtItemCode.Text = itemCode;
                txtDescription.Text = dgvCategories.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtItemCode.Enabled = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if (btnAdd.Text.Equals("Save"))
            {
                dialogResult = MetroSetMessageBox.Show(this, "Would you like to cancel adding new category?",
                   "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    clearFields();
                    btnAdd.Text = "Add";
                    btnClose.Text = "Close";
                }
            }
            else if (btnUpdate.Text.Equals("Save"))
            {
                dialogResult = MetroSetMessageBox.Show(this, "Would you like to cancel updating category?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    clearFields();
                    btnUpdate.Text = "Update";
                    btnClose.Text = "Close";
                }
            }
            else if (btnClose.Text.Equals("Close"))
            {
                dialogResult = MetroSetMessageBox.Show(this, "Would you like to exit?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Close();
                }
            }
        }
    }
}
