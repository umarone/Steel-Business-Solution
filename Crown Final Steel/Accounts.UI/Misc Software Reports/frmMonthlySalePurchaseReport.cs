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
    public partial class frmMonthlyPurchasesReport : MetroForm
    {
        #region Variables
        public int ReportType { get; set; }
        frmMonthlySalePurchaseDetailedReport frmMonthlyData;
        #endregion
        #region Forms Methods And Events
        public frmMonthlyPurchasesReport()
        {
            InitializeComponent();
        }
        private void frmMonthlyPurchasesReport_Load(object sender, EventArgs e)
        {
            if (ReportType == 1)
            {
                this.Text = "Monthly Purchases Report";
                chkCredit.Text = "Credit Purchases";
                chkNet.Text = "Cash Purchases";
            }
            else if (ReportType == 2)
            {
                this.Text = "Monthly Purchases Return Report";
                chkCredit.Text = "Credit Purchases Return";
                chkNet.Text = "Cash Purchases Return";
            }
            else if (ReportType == 3)
            {
                this.Text = "Monthly Sales Report";
                chkCredit.Text = "Credit Sales";
                chkNet.Text = "Cash Sales";
            }
            else if (ReportType == 4)
            {
                this.Text = "Monthly Sales Return Report";
                chkCredit.Text = "Credit Sales Return";
                chkNet.Text = "Cash Sales Return";
            }
            grdMonthlyReports.AutoGenerateColumns = false;
        }
        #endregion
        #region Grid Events and Methods
        private void grdMonthlyReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = "View Detail";
            }
        }
        private void grdMonthlyReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                frmMonthlyData = new frmMonthlySalePurchaseDetailedReport();
                frmMonthlyData.ReportType = ReportType;
                if (chkSummary.Checked)
                    frmMonthlyData.ModeType = null;
                else
                    frmMonthlyData.ModeType = chkNet.Checked ? true : false;
                frmMonthlyData.StartDate = dtStart.Value;
                frmMonthlyData.EndDate = dtEnd.Value;
                frmMonthlyData.AccountNo = Validation.GetSafeString(grdMonthlyReports.Rows[e.RowIndex].Cells[0].Value);
                frmMonthlyData.AccountName = Validation.GetSafeString(grdMonthlyReports.Rows[e.RowIndex].Cells[1].Value);
                frmMonthlyData.ShowDialog();
            }
        }
        #endregion
        #region Win Controls Methods And Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var PManager = new PurchaseDetailBLL();
            var SManager = new SalesDetailBLL();
            List<TransactionsEL> list = new List<TransactionsEL>();
            if (chkNet.Checked == false && chkCredit.Checked == false && chkSummary.Checked == false)
            {
                MessageBox.Show("Please Check Data Mode...");
                return;
            }
            if (ReportType == 1)
            {
                if(chkSummary.Checked == false)
                    list = PManager.GetMonthlyPurchases(Operations.IdProject, Operations.BookNo, chkNet.Checked ? true : false , dtStart.Value,dtEnd.Value);
                else
                    list = PManager.GetMonthlyStraightPurchases(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            }
            else if (ReportType == 2)
            {
                if(chkSummary.Checked == false)
                    list = PManager.GetMonthlyPurchasesReturn(Operations.IdProject, Operations.BookNo, chkNet.Checked ? true : false, dtStart.Value, dtEnd.Value);
                else
                    list = PManager.GetMonthlyStraightPurchasesReturn(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            }
            else if (ReportType == 3)
            {
                if(chkSummary.Checked == false)
                    list = SManager.GetMonthlySalesReport(Operations.IdProject, Operations.BookNo, chkNet.Checked ? true : false, dtStart.Value, dtEnd.Value);
                else
                    list = SManager.GetMonthlyStraightSalesReport(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            }
            else
            {
                if(chkSummary.Checked == false)
                    list = SManager.GetMonthlySalesReturnReport(Operations.IdProject, Operations.BookNo, chkNet.Checked ? true : false, dtStart.Value, dtEnd.Value);
                else
                    list = SManager.GetMonthlyStraightSalesReturnReport(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            }
            if (list.Count > 0)
            {
                grdMonthlyReports.DataSource = list;
            }
            else
            {
                MessageBox.Show("No Record Found....");
                grdMonthlyReports.DataSource = null;
            }
        }
        private void chkNet_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNet.Checked)
            {
                chkCredit.Checked = false;
                chkSummary.Checked = false;
            }
        }
        private void chkCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCredit.Checked)
            {
                chkNet.Checked = false;
                chkSummary.Checked = false;
            }
        }
        private void chkSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSummary.Checked)
            {
                chkCredit.Checked = false;
                chkNet.Checked = false;
            }
        }
        #endregion
    }
}
