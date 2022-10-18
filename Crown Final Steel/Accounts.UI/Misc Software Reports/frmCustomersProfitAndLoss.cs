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
using System.Collections;

namespace Accounts.UI
{
    public partial class frmCustomersProfitAndLoss : MetroForm
    {
        #region Variables
        DataTable dt;
        frmCustomersProfitAndLossDetail objProfitLoss;
        #endregion
        #region Form Methods And Events
        public frmCustomersProfitAndLoss()
        {
            InitializeComponent();
        }
        private void frmCustomersProfitAndLoss_Load(object sender, EventArgs e)
        {
            this.grdCustomers.AutoGenerateColumns = false;
        }
        #endregion
        #region Grid Methods And Events
        private void grdCustomers_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                e.Value = "Detail";
            }
        }
        private void grdCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                objProfitLoss = new frmCustomersProfitAndLossDetail();
                objProfitLoss.StartDate = dtStart.Value;
                objProfitLoss.EndDate = dtEnd.Value;
                objProfitLoss.AccountNo = Validation.GetSafeString(grdCustomers.Rows[e.RowIndex].Cells["colAccountNo"].Value);
                objProfitLoss.AccountName = Validation.GetSafeString(grdCustomers.Rows[e.RowIndex].Cells["colAccountName"].Value);
                objProfitLoss.ShowDialog();
            }
        }
        #endregion
        #region Win Controls Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new SalesDetailBLL();
            List<TransactionsEL> list = manager.GetCustomersProfitAndLostByDate(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                grdCustomers.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No Data Found Please...");
                grdCustomers.DataSource = null;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtSearch.Text);
            grdCustomers.DataSource = DV;
        }
        #endregion       
    }
}
