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
    public partial class frmPosition : Form
    {

        private long ID;
        private List<tblPosition> allPositions = new List<tblPosition>();

        public frmPosition()
        {
            InitializeComponent();
            txtDescription.Focus();
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            dgvPositions.CellClick -= new DataGridViewCellEventHandler(dgvPositions_CellClick);
            LoadAllPositions();
        }

        private void LoadAllPositions()
        {
            allPositions.Clear();
            allPositions = (from s in DatabaseHelper.db.tblPositions
                               select s).ToList();
            dgvPositions.Rows.Clear();
            foreach(var pos in allPositions)
            {
                dgvPositions.Rows.Add(
                        pos.ID,
                        pos.Position
                    );
            }
            dgvPositions.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text.Equals("Add"))
            {
                btnAdd.Text = "Save";
                
                if(btnUpdate.Text.Equals("Save"))
                {
                    btnUpdate.Text = "Update";
                    txtDescription.Text = "";
                }
                btnClose.Text = "Cancel";
                dgvPositions.CellClick -= new DataGridViewCellEventHandler(dgvPositions_CellClick);
                dgvPositions.ClearSelection();
                txtID.Enabled = false;
                var nextID = (from s in DatabaseHelper.db.tblPositions
                             orderby s.ID descending
                             select s.ID).FirstOrDefault();
                if(nextID > 0)
                {
                    long newID = nextID + 1;
                    txtID.Text = newID.ToString();
                }
                else
                {
                    txtID.Text = "1";
                }
            }
            else if(btnAdd.Text.Equals("Save"))
            {

                // Save new position here.
                if (ValidateChildren(ValidationConstraints.Enabled))
                {
                    var newPos = new tblPosition
                    {
                        ID = long.Parse(txtID.Text),
                        Position = txtDescription.Text
                    };
                    DatabaseHelper.db.tblPositions.InsertOnSubmit(newPos);
                    DatabaseHelper.db.SubmitChanges();

                    MessageBox.Show(this, "Position added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAdd.Text = "Add";
                    clearFields();
                    LoadAllPositions();
                }
            }
                 
        }

        public void clearFields()
        {
            txtID.Text = "";
            txtDescription.Text = "";
        }

        private void updatePosition()
        {

            var updatePosition = allPositions.Where(x=> x.ID == ID).FirstOrDefault();

            if(updatePosition != null)
            {
                updatePosition.Position = txtDescription.Text;
                DatabaseHelper.db.SubmitChanges();
                MessageBox.Show(this, "Position with ID: " + txtID.Text + " was updated successfully!",
                    "UPDATE POSITION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show(this, "No ID is selected",
                    "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            clearFields();
            LoadAllPositions();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            if(btnUpdate.Text.Equals("Update"))
            {
                btnUpdate.Text = "Save";
                
                if (btnAdd.Text.Equals("Save"))
                {
                    btnAdd.Text = "Add";
                }
                btnClose.Text = "Cancel";
                dgvPositions.CellClick += new DataGridViewCellEventHandler(dgvPositions_CellClick);
            }
            else if(btnUpdate.Text.Equals("Save"))
            {
                DialogResult dialogResult = MessageBox.Show(this, "Would you like to update this position?",
                "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    if (ValidateChildren(ValidationConstraints.Enabled))
                    {
                        updatePosition();
                    }
                }
            }
        }

        private void setPosition(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                
                ID = long.Parse(dgvPositions.Rows[e.RowIndex].Cells[0].Value.ToString());

                txtID.Text = ID.ToString();
                txtDescription.Text = dgvPositions.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if(btnAdd.Text.Equals("Save"))
            {
                 dialogResult = MessageBox.Show(this, "Would you like to cancel adding new position?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    clearFields();
                    btnAdd.Text = "Add";
                    btnClose.Text = "Close";
                }
            }
            else if (btnUpdate.Text.Equals("Save"))
            {
                dialogResult = MessageBox.Show(this, "Would you like to cancel updating position?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    clearFields();
                    btnUpdate.Text = "Update";
                    btnClose.Text = "Close";
                }
            }
            else if(btnClose.Text.Equals("Close"))
            {
                if (txtDescription.Text.Length > 0)
                {
                    dialogResult = MessageBox.Show(this, "Would you like to exit?",
                        "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Close();
                    }
                }
                else
                {
                    Close();
                }
            }

        }

        private void txtDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                e.Cancel = true;
                txtDescription.Focus();
                errorProvider1.SetError(txtDescription, "Please enter position description!");
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

        private void dgvPositions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            setPosition(e);
        }
    }
}
