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
    public partial class frmAddEditUser : MetroSetForm
    {

        private string currentUsername = "";

        public frmAddEditUser()
        {
            InitializeComponent();

            var positions = from s in DatabaseHelper.db.tblPositions
                            select s;
            foreach(var pos in positions)
            {
                cmbPositions.Items.Add(pos.Position);
            }
        }

        public void addUser()
        {
            this.Text = "Add User";
            txtStaffID.ReadOnly = true;
            var staffID = (from s in DatabaseHelper.db.tblUsers
                          orderby s.ID descending
                          select s.ID).FirstOrDefault();
            if(staffID > 0)
            {
                long newUser = staffID + 1;
                txtStaffID.Text = newUser.ToString();
            }
            else
            {
                txtStaffID.Text = "1";
            }
        }

        public void updateUser(User user)
        {
            this.Text = "Update User";
            currentUsername = user.Username;
            txtStaffID.Enabled = false;
            txtStaffID.Text = user.ID.ToString();
            txtUsername.Text = user.Username;
            txtPassword.Text = user.Password;
            txtFirstName.Text = user.FirstName;
            txtLastName.Text = user.LastName;
            txtMI.Text = user.MiddleName;
            txtAddress.Text = user.Address;
            txtContactNo.Text = user.ContactNo;
            cmbPositions.SelectedIndex = cmbPositions.Items.IndexOf(user.Position);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                if (this.Text.Equals("Add User"))
                {
                    var newUser = new tblUser
                    {
                        ID = long.Parse(txtStaffID.Text),
                        Username = txtUsername.Text,
                        Password = txtPassword.Text,
                        Position = cmbPositions.SelectedItem.ToString(),
                        FirstName = txtFirstName.Text,
                        MiddleName = txtMI.Text,
                        LastName = txtLastName.Text,
                        Address = txtAddress.Text,
                        ContactNo = txtContactNo.Text
                    };
                    DatabaseHelper.db.tblUsers.InsertOnSubmit(newUser);
                    DatabaseHelper.db.SubmitChanges();
                    MetroSetMessageBox.Show(this, "User created successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else if(this.Text.Equals("Update User"))
                {
                    var updateUser = (from s in DatabaseHelper.db.tblUsers
                                     where s.ID == long.Parse(txtStaffID.Text)
                                     select s).FirstOrDefault();
                    updateUser.Username = txtUsername.Text;
                    updateUser.Password = txtPassword.Text;
                    updateUser.FirstName = txtFirstName.Text;
                    updateUser.MiddleName = txtMI.Text;
                    updateUser.LastName = txtLastName.Text;
                    updateUser.Address = txtAddress.Text;
                    updateUser.ContactNo = txtContactNo.Text;
                    updateUser.Position = cmbPositions.SelectedItem.ToString();

                    DatabaseHelper.db.SubmitChanges();
                    MetroSetMessageBox.Show(this, "User updated successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
            }
        }

        private void txtUsername_Validating(object sender, CancelEventArgs e)
        {
            var isUserUnique = (from s in DatabaseHelper.db.tblUsers
                                where s.Username == txtUsername.Text
                                select s).FirstOrDefault();
            if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Please enter your username!");
            }
            else if (this.Text.Equals("Update User"))
            {
                if(isUserUnique != null && !currentUsername.Equals(isUserUnique.Username))
                {
                    e.Cancel = false;
                    txtUsername.Focus();
                    errorProvider1.SetError(txtUsername, "Username already exists, try another!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtUsername, null);
                }
            }
            else if (isUserUnique != null)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtUsername, "Username already exists, try another!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtUsername, null);
            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Please enter your password!");
            }
            else if (txtPassword.Text.Length < 8)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPassword, "Password must be at least 8 characters long!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPassword, null);
            }
        }

        private void txtLastName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Please enter your last name!");
            }
            else if (Regex.IsMatch(txtLastName.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtLastName, "Please input letters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtLastName, null);
            }
        }

        private void txtFirstName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Please enter your first name!");
            }
            else if (Regex.IsMatch(txtFirstName.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFirstName, "Please input letters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFirstName, null);
            }
        }

        private void txtMI_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMI.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMI, "Please enter your middle initial!");
            }
            else if (Regex.IsMatch(txtMI.Text, @"^[0-9]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtMI, "Please input letters only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtMI, null);
            }
        }

        private void txtContactNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContactNo.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtContactNo, "Please enter your contact number!");
            }
            else if(Regex.IsMatch(txtContactNo.Text, @"^[a-zA-Z]+$"))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtContactNo, "Please input numbers only!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtContactNo, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtAddress, "Please enter your address!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtAddress, null);
            }
        }

        private void cmbPositions_Validating(object sender, CancelEventArgs e)
        {
            if (cmbPositions.SelectedIndex == -1)
            {
                e.Cancel = true;
                errorProvider1.SetError(cmbPositions, "Please select a position!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(cmbPositions, null);
            }
        }
    }
}
