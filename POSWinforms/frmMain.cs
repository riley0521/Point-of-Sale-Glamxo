﻿using MetroSet_UI.Forms;
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
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();
            timer1.Start();
            string date = DateTime.Now.ToString("dddd MMMM dd, yyyy  hh:mm:ss tt");
            lbTime.Text = date;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString("dddd MMMM dd, yyyy  hh:mm:ss tt");
            lbTime.Text = date;
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
            frm.ShowDialog();
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
