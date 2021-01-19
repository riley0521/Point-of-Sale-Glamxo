using DevExpress.XtraReports.UI;
using POSWinforms.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

namespace POSWinforms.Transaction
{
    public partial class InvoiceCustomer : DevExpress.XtraReports.UI.XtraReport
    {
        public InvoiceCustomer()
        {
            InitializeComponent();
        }

        public void initData(
            long customerNo,
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
            pCustomerNo.Value = customerNo;
            pInvoiceNo.Value = invoiceNo;
            pName.Value = fullName;
            pDate.Value = date;
            pTime.Value = time;
            pSubTotal.Value = subTotal;
            pTotalAmount.Value = subTotal;
            pCash.Value = cash;
            pChange.Value = change;

            foreach(var item in cartList)
            {
                string[] firstWord = item.ItemDescription.Split(' ');
                item.ItemDescription = item.ItemCode + " " + firstWord[0];
            }

            objectDataSource1.DataSource = cartList;
        }
    }
}
