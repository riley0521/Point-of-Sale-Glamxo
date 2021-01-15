﻿using MetroSet_UI.Forms;
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

namespace POSWinforms
{
    public partial class frmLogin : MetroSetForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = "Username";
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if(txtUsername.Text.Equals("Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals("Password"))
            {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.UseSystemPasswordChar = false;
                txtPassword.Text = "Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.Length == 0 || txtPassword.Text.Length == 0
                || txtUsername.Text.Equals("Username") || txtPassword.Text.Equals("Password"))
            {
                MetroSetMessageBox.Show(this, "Please enter your username and password.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var user = (from s in DatabaseHelper.db.tblUsers
                           where s.Username == txtUsername.Text
                           select s).FirstOrDefault();

                if(user != null)
                {
                    if(user.Password.Equals(txtPassword.Text))
                    {
                        DatabaseHelper.user = new User()
                        {
                            ID = user.ID,
                            Address = user.Address,
                            ContactNo = user.ContactNo,
                            FirstName = user.FirstName,
                            LastName = user.LastName,
                            MiddleName = user.MiddleName,
                            Password = "",
                            Position = user.Position,
                            Username = user.Username
                        };
                        new frmMain().Show();
                        Hide();
                    }
                    else
                    {
                        MetroSetMessageBox.Show(this,"Invalid username or password.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MetroSetMessageBox.Show(this, "Invalid username or password.", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}