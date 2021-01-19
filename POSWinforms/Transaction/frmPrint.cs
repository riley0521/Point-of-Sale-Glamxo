using DevExpress.XtraEditors;
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

namespace POSWinforms.Transaction
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }

        public void printInvoice(long customerNo,
            long invoiceNo,
            string fullName,
            DateTime date,
            string time,
            decimal subTotal,
            decimal cash,
            decimal change,
            List<OrderDetail> cartList
            )
        {
            InvoiceCustomer report = new InvoiceCustomer();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;
            report.initData(customerNo, invoiceNo, fullName, date, time, subTotal, cash, change, cartList);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

        private void frmPrint_FormClosing(object sender, FormClosingEventArgs e)
        {
            DatabaseHelper.cartList.Clear();
        }
    }
}