﻿using MetroSet_UI.Forms;
using POSWinforms.Maintenance;
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

namespace POSWinforms
{
    public partial class frmUser : MetroSetForm
    {

        private string username = "";
        private List<User> userList = new List<User>();

        public frmUser()
        {
            InitializeComponent();
        }

        private void LoadAllUsers(string searchedUser)
        {
            List<tblUser> allUsers = new List<tblUser>();
            if (searchedUser == null)
            {
                allUsers = (from s in DatabaseHelper.db.tblUsers
                            select s).ToList();
            }
            else 
            {
                 allUsers = (from s in DatabaseHelper.db.tblUsers
                                    where SqlMethods.Like(s.FirstName, "%" + searchedUser + "%") ||
                                    SqlMethods.Like(s.LastName, "%" + searchedUser + "%") ||
                                    SqlMethods.Like(s.MiddleName, "%" + searchedUser + "%") ||
                                    SqlMethods.Like(s.Position, "%" + searchedUser + "%") ||
                                    SqlMethods.Like(s.Username, "%" + searchedUser + "%")
                                    select s).ToList();
            }
            //var allUsers = from s in DatabaseHelper.db.tblUsers
            //               select s;
            dgvUsers.Rows.Clear();
            userList.Clear();
            foreach(var user in allUsers)
            {
                string fullName = (user.LastName + ", " + user.FirstName + " " + user.MiddleName).Trim();
                dgvUsers.Rows.Add(
                        user.ID,
                        fullName,
                        user.Position,
                        user.Username
                    );
                User addUser = new User();
                addUser.ID = user.ID;
                addUser.Username = user.Username;
                addUser.Password = user.Password;
                addUser.FirstName = user.FirstName;
                addUser.MiddleName = user.MiddleName;
                addUser.LastName = user.LastName;
                addUser.Address = user.Address;
                addUser.ContactNo = user.ContactNo;
                addUser.Position = user.Position;
                userList.Add(addUser);
            }
            dgvUsers.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new frmAddEditUser();
            frm.addUser();
            frm.ShowDialog();
            LoadAllUsers(null);
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            LoadAllUsers(null);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            

            User user = userList.Where(x => x.Username.Equals(username)).FirstOrDefault();

            if (user != null)
            {
                var frm = new frmAddEditUser();
                frm.updateUser(user);
                frm.ShowDialog();
                LoadAllUsers(null);
            }
            
        }

        private void dgvUsers_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {

                username = dgvUsers.Rows[e.RowIndex].Cells["colUsername"].Value.ToString();
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length == 0)
            {
                LoadAllUsers(null);
            }
            else if(txtSearch.Text.Length > 0)
            {
                LoadAllUsers(txtSearch.Text);
            }
        }
    }
}