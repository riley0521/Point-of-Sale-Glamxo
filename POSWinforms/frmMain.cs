using MetroSet_UI.Forms;
using POSWinforms.Maintenance;
using POSWinforms.Models;
using POSWinforms.Transaction;
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
    public partial class frmMain : MetroSetForm
    {
        
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dddd MMMM dd, yyyy  hh:mm:ss tt");
            lblTime.Text = date;
        }

        private void userToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmUser().ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseHelper.frmLogin.Show();
        }

        private void positionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmPosition().ShowDialog();
        }

        private void categoryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new frmCategory().ShowDialog();
        }

        private void itemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var frm = new frmItem();
            frm.addMode();
            frm.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            User user = DatabaseHelper.user;
            Console.WriteLine(user.LastName + ", " + user.FirstName + " " + user.MiddleName);
        }

        private void transactionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmTransaction().ShowDialog();
        }

        private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmOrders().ShowDialog();
        }
    }
}
