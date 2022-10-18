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
    public partial class frmMonthlySalePurchaseDetailedReport : MetroForm
    {
        #region Variables
        public int ReportType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public bool? ModeType { get; set; }
        #endregion
        #region Forms Methods And Events
        public frmMonthlySalePurchaseDetailedReport()
        {
            InitializeComponent();
        }
        private void frmMonthlySalePurchaseDetailedReport_Load(object sender, EventArgs e)
        {
            grdMonthlyDetailedReports.AutoGenerateColumns = false;
            if (ReportType == 1)
            {
                lblPersonName.Text = "Supplier Name :";
            }
            else if (ReportType == 2)
            {
                lblPersonName.Text = "Supplier Name :";
            }
            else if (ReportType == 3)
            {
                lblPersonName.Text = "Customer Name :";
            }
            else
            {
                lblPersonName.Text = "Customer Name :";
            }
            lblCustomerName.Text = AccountName;
            lblStartDate.Text = StartDate.ToShortDateString();
            lblEndDate.Text = EndDate.ToShortDateString();
            if (ModeType == null)
            {
                lblTransactionType.Text = "Straight";
            }
            else
                lblTransactionType.Text = ModeType == true ? "Net" : "Credit";
            if (ReportType == 1)
            {
                lblReportType.Text = "Purchases";
            }
            else if (ReportType == 2)
            {
                lblReportType.Text = "Purchases Return";
            }
            else if (ReportType == 3)
            {
                lblReportType.Text = "Sales";
            }
            else
            {
                lblReportType.Text = "Sales Return";
            }
            FillData();
        }
        private void FillData()
        {
            var PManager = new PurchaseDetailBLL();
            var SManager = new SalesDetailBLL();
            List<TransactionsEL> list = new List<TransactionsEL>();
            if (ReportType == 1)
            {
                if(null == ModeType)
                    list = PManager.GetMonthlyStraightPurchasesWithDetail(Operations.IdProject, Operations.BookNo, AccountNo, StartDate, EndDate);
                else
                    list = PManager.GetMonthlyPurchasesWithDetail(Operations.IdProject, Operations.BookNo, AccountNo, ModeType.Value, StartDate, EndDate);
            }
            else if (ReportType == 2)
            {
                if(null == ModeType)
                    list = PManager.GetMonthlyStraightPurchasesReturnWithDetail(Operations.IdProject, Operations.BookNo, AccountNo, StartDate, EndDate);
                else
                    list = PManager.GetMonthlyPurchasesReturnWithDetail(Operations.IdProject, Operations.BookNo, AccountNo, ModeType.Value, StartDate, EndDate);
            }
            else if (ReportType == 3)
            {
                if(null == ModeType)
                    list = SManager.GetMonthlyStraightSalesReportWithDetail(Operations.IdProject, Operations.BookNo, AccountNo, StartDate, EndDate);
                else
                    list = SManager.GetMonthlySalesReportWithDetail(Operations.IdProject, Operations.BookNo, AccountNo, ModeType.Value, StartDate, EndDate);
            }
            else
            {
                if(null == ModeType)
                    list = SManager.GetMonthlyStraightSalesReturnReportWithDetail(Operations.IdProject, Operations.BookNo, AccountNo, StartDate, EndDate);
                else
                    list = SManager.GetMonthlySalesReturnReportWithDetail(Operations.IdProject, Operations.BookNo, AccountNo, ModeType.Value, StartDate, EndDate);
            }
            if (list.Count > 0)
            {
                grdMonthlyDetailedReports.DataSource = list;
                lblTotalAmount.Text = list.Sum(x => x.TotalAmount).ToString();
            }
        }
        #endregion 
    }
}
