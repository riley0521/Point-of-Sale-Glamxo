﻿using DevExpress.XtraGrid.Views.Grid;
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
    public partial class frmItem : MetroSetForm
    {

        private List<tblItem> allItems = new List<tblItem>();
        private string itemCode = "";

        public frmItem()
        {
            InitializeComponent();
        }

        public void addMode()
        {
            dgvItems.CellDoubleClick -= new DataGridViewCellEventHandler(dgvItems_CellDoubleClick);
        }

        private void loadAllItems(string searchItem)
        {
            allItems.Clear();
            dgvItems.Rows.Clear();

            if (searchItem != null)
            {
                allItems = (from s in DatabaseHelper.db.tblItems
                               where s.ItemCode == txtSearch.Text ||
                               SqlMethods.Like(s.ItemDescription, "%" + txtSearch.Text + "%")
                               select s).ToList();
                
            }
            else
            {
                allItems = (from s in DatabaseHelper.db.tblItems
                               select s).ToList();
            }

            foreach (var item in allItems)
            {
                dgvItems.Rows.Add(
                        item.ItemNumber,
                        item.ItemCode,
                        item.ItemDescription,
                        item.Size,
                        item.UnitPrice.ToString("0.00"),
                        item.Stocks,
                        item.ReStockLevel
                    );
            }

            foreach (DataGridViewRow row in dgvItems.Rows)
            {
                row.DefaultCellStyle.ForeColor = Color.White;
                if(int.Parse(row.Cells["colQty"].Value.ToString()) <= int.Parse(row.Cells["colRepLvl"].Value.ToString())) {
                    row.DefaultCellStyle.BackColor = Color.OrangeRed;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Lime;
                }
                //More code here
            }

            dgvItems.ClearSelection();
        }

        private void frmItem_Load(object sender, EventArgs e)
        {
            loadAllItems(null);
        }

        private void metroSetButton1_Click(object sender, EventArgs e)
        {
            var frm = new frmAddEditItem();
            frm.addItem();
            frm.ShowDialog();
            loadAllItems(null);
        }

        private void metroSetButton2_Click(object sender, EventArgs e)
        {
            tblItem item = allItems.Where(x => x.ItemCode.Equals(itemCode)).FirstOrDefault();
            if (item != null)
            {
                var frm = new frmAddEditItem();
                frm.updateItem(item);
                frm.ShowDialog();
                loadAllItems(null);
            }
        }

        private void dgvItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                itemCode = dgvItems.Rows[e.RowIndex].Cells[1].Value.ToString();
            } 
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            if (itemCode.Length > 0)
            {
                var frm = new frmItemStockEdit();
                frm.setItemCode(itemCode);
                frm.ShowDialog();
                loadAllItems(null);
            }
            
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if(txtSearch.Text.Length == 0)
            {
                loadAllItems(null);
            }
            else
            {
                loadAllItems(txtSearch.Text);
            }
        }

        public void selectItemMode()
        {
            btnAdd.Visible = false;
            btnUpdate.Visible = false;
            btnStockIn.Visible = false;
        }

        private void dgvItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                itemCode = dgvItems.Rows[e.RowIndex].Cells[1].Value.ToString();
                DatabaseHelper.item = allItems.Where(x => x.ItemCode.Equals(itemCode)).FirstOrDefault();
                Close();
            }
        }
    }
}
