using DevExpress.XtraGrid.Views.Grid;
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

        private List<Item> itemList = new List<Item>();
        private long id = 0;

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
            List<tblItem> allItems = new List<tblItem>();
            dgvItems.Rows.Clear();
            itemList.Clear();

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
                        item.ID,
                        item.ItemNumber,
                        item.ItemCode,
                        item.ItemDescription,
                        item.Stocks,
                        item.Size,
                        item.UnitPrice,
                        item.ReStockLevel
                    );
                itemList.Add(new Item()
                {
                    ID = item.ID,
                    ItemNumber = item.ItemNumber,
                    ItemCode = item.ItemCode,
                    ItemDescription = item.ItemDescription,
                    Stocks = item.Stocks,
                    Size = item.Size,
                    UnitPrice = item.UnitPrice,
                    ReStockLevel = item.ReStockLevel
                });
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
            Item item = itemList.Where(x => x.ID == id).FirstOrDefault();
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
                id = long.Parse(dgvItems.Rows[e.RowIndex].Cells[0].Value.ToString());
            } 
        }

        private void metroSetButton3_Click(object sender, EventArgs e)
        {
            if (id > 0)
            {
                var frm = new frmItemStockEdit();
                frm.setID(id);
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
                id = long.Parse(dgvItems.Rows[e.RowIndex].Cells[0].Value.ToString());
                DatabaseHelper.item = itemList.Where(x => x.ID == id).FirstOrDefault();
                Close();
            }
        }
    }
}
