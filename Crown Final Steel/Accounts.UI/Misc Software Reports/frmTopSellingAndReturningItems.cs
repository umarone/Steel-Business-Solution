using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.EL;
using Accounts.BLL;
using Accounts.Common;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmTopSellingAndReturningItems : MetroForm
    {
        DataTable dt;
        public frmTopSellingAndReturningItems()
        {
            InitializeComponent();
        }
        private void frmTopSellingAndReturningItems_Load(object sender, EventArgs e)
        {
            this.grdMostSelling.AutoGenerateColumns = false;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var Manager = new SalesDetailBLL();
            List<TransactionsEL> list = new List<TransactionsEL>();
            if (chkSales.Checked == false && chkReturned.Checked == false)
            {
                MessageBox.Show("Please Check Mode...");
                return;
            }
            if (chkSales.Checked)
            {
                list = Manager.GetTopSellingItemsByDate(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            }
            else
            {
                list = Manager.GetTopSellingReturnItemsByDate(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            }
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                grdMostSelling.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Record Found....");
                grdMostSelling.DataSource = null;
            }
        }
        private void chkSales_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSales.Checked)
            {
                chkReturned.Checked = false;
                grdMostSelling.DataSource = null;
            }
        }
        private void chkReturned_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReturned.Checked)
            {
                chkSales.Checked = false;
                grdMostSelling.DataSource = null;
            }
        }
        private void txtSearchItem_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("ItemName LIKE '%{0}%'", txtSearchItem.Text);
            grdMostSelling.DataSource = DV;
        }       
    }
}
