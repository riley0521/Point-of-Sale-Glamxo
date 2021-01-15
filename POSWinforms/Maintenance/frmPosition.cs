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
    public partial class frmPosition : MetroSetForm
    {

        private Position position;

        public frmPosition()
        {
            InitializeComponent();
            txtDescription.Focus();
        }

        private void frmPosition_Load(object sender, EventArgs e)
        {
            LoadAllPositions();
        }

        private void LoadAllPositions()
        {
            var allPositions = from s in DatabaseHelper.db.tblPositions
                               select s;
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

        private void addPositionMode()
        {
            txtDescription.Text = "";
            txtID.ReadOnly = true;
            dgvPositions.ClearSelection();
            position = null;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(btnAdd.Text.Equals("Add"))
            {
                btnAdd.Text = "Save";
                addPositionMode();
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

                    MetroSetMessageBox.Show(this, "Position added successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            btnAdd.Text = "Add";
            txtID.ReadOnly = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void updatePosition()
        {

            var updatePosition = (from s in DatabaseHelper.db.tblPositions
                                 where s.ID == long.Parse(txtID.Text)
                                 select s).FirstOrDefault();

            if(updatePosition != null)
            {
                updatePosition.Position = txtDescription.Text;
                DatabaseHelper.db.SubmitChanges();
                MetroSetMessageBox.Show(this, "Position with ID: " + txtID.Text + " was updated successfully!",
                    "UPDATE POSITION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MetroSetMessageBox.Show(this, "No ID is selected",
                    "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            clearFields();
            LoadAllPositions();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                btnAdd.Text = "Add";
                updatePosition();
            }
        }

        private void setPosition(DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                position = new Position();
                position.ID = long.Parse(dgvPositions.Rows[e.RowIndex].Cells[0].Value.ToString());
                position.PosDescription = dgvPositions.Rows[e.RowIndex].Cells[1].Value.ToString();

                txtID.Text = position.ID.ToString();
                txtDescription.Text = position.PosDescription;

                txtID.ReadOnly = true;
                btnAdd.Text = "Add";
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void deletePosition()
        {

            var deletePosition = (from s in DatabaseHelper.db.tblPositions
                                  where s.ID == long.Parse(txtID.Text)
                                  select s).FirstOrDefault();

            if(deletePosition != null)
            {
                DialogResult dialogResult = MetroSetMessageBox.Show(this, "Would you like to delete this position?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {

                    DatabaseHelper.db.tblPositions.DeleteOnSubmit(deletePosition);
                    DatabaseHelper.db.SubmitChanges();
                    MetroSetMessageBox.Show(this, "Position with ID: " + txtID.Text + " was deleted successfully!",
                        "DELETE POSITION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }
            }
            else
            {
                MetroSetMessageBox.Show(this, "No ID is selected",
                    "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            clearFields();
            LoadAllPositions();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            btnAdd.Text = "Add";
            deletePosition();
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult;
            if(btnAdd.Text.Equals("Save"))
            {
                 dialogResult = MetroSetMessageBox.Show(this, "Would you like to cancel adding new position?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogResult == DialogResult.Yes)
                {
                    clearFields();
                }
            }
            else if (btnUpdate.Enabled || btnDelete.Enabled)
            {
                dialogResult = MetroSetMessageBox.Show(this, "Would you like to cancel updating/deleting position?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    clearFields();
                }
            }
            else
            {
                dialogResult = MetroSetMessageBox.Show(this, "Would you like to exit?",
                    "QUESTION", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
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
