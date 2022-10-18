using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using Accounts.EL;

namespace Accounts.UI
{
    public partial class frmDetailedJournalLedger : MetroForm
    {
        frmDetailedLedgerReport frmDetailedReport;
        public frmDetailedJournalLedger()
        {
            InitializeComponent();
        }
        private void frmDetailedJournalLedger_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            cbxCategories.SelectedIndex = 0;
            CheckModulePermissions();
        }
        private void CheckModulePermissions()
        {
            List<UserModulesPermissionsEL> PermissionsList = UserPermissions.GetUserModulePermissionsByUserAndModuleId(Operations.UserID);
            if (PermissionsList != null && PermissionsList.Count > 0)
            {
                if (PermissionsList[0].Printing == true)
                {
                    btnPrint.Enabled = true;
                }
                else
                {
                    btnPrint.Enabled = false;
                }
                if (PermissionsList[0].Deleting == true)
                {
                    //btnDelete.Enabled = true;
                }
                else
                {
                    //btnDelete.Enabled = false;
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (cbxCategories.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Type");
                return;
            }
            else
            {
                if (chkDate.Checked)
                {
                    frmDetailedReport = new frmDetailedLedgerReport();
                    frmDetailedReport.ReportType = "DetailReportWithDate";
                    if (chkClosingReport.Checked)
                    {
                        frmDetailedReport.SubReportType = "ClosingReport";
                    }
                    else
                    {
                        frmDetailedReport.SubReportType = "";
                    }
                    frmDetailedReport.AccountType = cbxCategories.Text;
                    frmDetailedReport.StartDate = Convert.ToDateTime(StartDate.Value.ToShortDateString());
                    frmDetailedReport.EndDate = Convert.ToDateTime(EndDate.Value.ToShortDateString());
                    frmDetailedReport.Show();
                }
                else
                {
                    frmDetailedReport = new frmDetailedLedgerReport();
                    frmDetailedReport.AccountType = cbxCategories.Text;
                    frmDetailedReport.ReportType = "DetailReport";
                    if (chkClosingReport.Checked)
                    {
                        frmDetailedReport.SubReportType = "ClosingReport";
                    }
                    else
                    {
                        frmDetailedReport.SubReportType = "";
                    }
                    frmDetailedReport.Show();
                }
            }
        }
    }
}
