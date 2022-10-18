using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.BLL;
using Accounts.EL;
using MetroFramework.Forms;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmAccountBalance : MetroForm
    {
        #region Variables
        frmAccountsBalanceReport frmAccountsBalanceReport;
        frmDetailedLedgerReport frmClosingBalanceReports;
        string AccountType = "";
        DataTable dt;
        #endregion
        #region Form Methods And Events
        public frmAccountBalance()
        {
            InitializeComponent();
        }
        private void frmAccountBalance_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            DgvAccountBalance.AutoGenerateColumns = false;
            StartBalanceDate.Enabled = false;
            EndBalanceDate.Enabled = false;
            CheckModulePermissions();
        }
        private void frmAccountBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void CheckModulePermissions()
        {
            List<UserModulesPermissionsEL> PermissionsList = UserPermissions.GetUserModulePermissionsByUserAndModuleId(Operations.UserID);
            if (PermissionsList != null && PermissionsList.Count > 0)
            {
                if (PermissionsList[0].Viewing == true)
                {
                    btnLoad.Enabled = true;
                }
                else
                {
                    btnLoad.Enabled = false;
                }
                
                if (PermissionsList[0].Printing == true)
                {
                    btnPrint.Enabled = true;
                }
                else
                {
                    btnPrint.Enabled = false;
                }                
            }
            //else
            //{
            //    btnSave.Enabled = false;
            //    btnDelete.Enabled = false;
            //    chkPosted.Checked = true;
            //    chkPosted.Enabled = true;
            //}
        }
        #endregion
        #region Controls Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> list = null;
            var manager = new TransactionBLL();
            if (rdCustomers.Checked)
            {
                AccountType = "Accounts Recieveables / Customers";
            }
            else if (rdSuppliers.Checked)
            {
                AccountType = "Accounts Payables";
            }
            else if (rdCash.Checked)
            {
                AccountType = "Cash Accounts";
            }
            else
            {
                AccountType = "Bank Accounts";
            }
            if (chkIncludeDate.Checked)
            {
                list = manager.GetDateWiseAccountsBalance(AccountType, Operations.IdProject, Operations.BookNo, StartBalanceDate.Value, EndBalanceDate.Value);
            }
            else
            {
                list = manager.GetAccountsBalance(AccountType, Operations.IdProject, Operations.BookNo);
            }
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                DgvAccountBalance.DataSource = dt;
            }
            else
            {
                DgvAccountBalance.DataSource = null;
            }
            
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmClosingBalanceReports = new frmDetailedLedgerReport();
            //frmAccountsBalanceReport = new frmAccountsBalanceReport();
            frmClosingBalanceReports.StartDate = StartBalanceDate.Value; //Convert.ToDateTime(StartBalanceDate.Value.ToShortDateString());
            frmClosingBalanceReports.EndDate = EndBalanceDate.Value; //Convert.ToDateTime(EndBalanceDate.Value.ToShortDateString());
            //if (chkIncludeDate.Checked)
            //{
            //    frmAccountsBalanceReport.IsDateWiseBalanceReport = true;
            //}
            //else
            //{
            //    frmAccountsBalanceReport.IsDateWiseBalanceReport = false;
            //}
            if (rdCustomers.Checked)
            {
                AccountType = "Accounts Recieveables / Customers";
            }
            else if (rdSuppliers.Checked)
            {
                AccountType = "Accounts Payables";
            }
            else if (rdCash.Checked)
            {
                AccountType = "Cash Accounts";
            }
            else
            {
                AccountType = "Bank Accounts";
            }
            if (chkIncludeDate.Checked)
            {
                frmClosingBalanceReports.ReportType = "ClosingBalancesReport";
                frmClosingBalanceReports.SubReportType = "ClosingBalanceReportWithDate";
            }
            else
            {
                frmClosingBalanceReports.ReportType = "ClosingBalancesReport";
                frmClosingBalanceReports.SubReportType = "ClosingReport";
            }
            frmClosingBalanceReports.AccountType = AccountType;
            frmClosingBalanceReports.ProjectName = Operations.ProjectName;
            frmClosingBalanceReports.ShowDialog();
        }
        private void rdStock_CheckedChanged(object sender, EventArgs e)
        {
            DgvAccountBalance.DataSource = null;
            lblTotal.Text = "";
            lblTotalAmount.Text = "";
        }
        private void chkIncludeDate_CheckedChanged(object sender, EventArgs e)
        {
            DgvAccountBalance.DataSource = null;
            if (chkIncludeDate.Checked)
            {
                StartBalanceDate.Enabled = true;
                EndBalanceDate.Enabled = true;
                DgvAccountBalance.Columns[1].Visible = true;
                DgvAccountBalance.Columns[0].Width = 300;
            }
            else
            {
                StartBalanceDate.Enabled = false;
                EndBalanceDate.Enabled = false;
                DgvAccountBalance.Columns[1].Visible = false;
                DgvAccountBalance.Columns[0].Width = 400;
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtSearch.Text);
            DgvAccountBalance.DataSource = DV;
        }
        #endregion
    }
}
