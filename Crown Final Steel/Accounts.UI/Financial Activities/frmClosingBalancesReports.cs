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
using Accounts.BLL;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmClosingBalancesReports : MetroForm
    {
        int AccountType, levelOne, levelTwo, levelThree;
        Int64? IdAccount = null;
        frmDetailedLedgerReport frmClosingBalanceReports;
        public frmClosingBalancesReports()
        {
            InitializeComponent();
        }
        private void frmClosingBalancesReports_Load(object sender, EventArgs e)
        {
            FillHeads(null, 1);
        }
        private void FillHeads(Int64? Id, int level)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccountsByParent(Id, Operations.IdProject, Operations.IdCompany, level);
            if (list.Count > 0)
            {
                if (level != 4)
                {
                    list.Insert(0, new AccountsEL() { IdAccount = 0, AccountName = "Select Head" });
                }

                //cbxHeadsLevel3.SelectedIndex = -1;
                if (level == 1)
                {
                    CbxHeadsLevel1.DataSource = list;
                    CbxHeadsLevel1.DisplayMember = "AccountName";
                    CbxHeadsLevel1.ValueMember = "IdAccount";
                }
                else if (level == 2)
                {
                    CbxHeadsLevel2.DataSource = list;
                    CbxHeadsLevel2.DisplayMember = "AccountName";
                    CbxHeadsLevel2.ValueMember = "IdAccount";
                }
                else if (level == 3)
                {
                    CbxHeadsLevel3.DataSource = list;
                    CbxHeadsLevel3.DisplayMember = "AccountName";
                    CbxHeadsLevel3.ValueMember = "IdAccount";
                }
            }
            else if (level == 2)
            {
                CbxHeadsLevel2.DataSource = null;
                ClearControls(level);
            }
            else if (level == 3)
            {
                CbxHeadsLevel3.DataSource = null;
                ClearControls(level);
            }
            else if (level == 4)
            {
                ClearControls(level);
            }
        }
        private void ClearControls(int Level)
        {
            
            if (Level == 2)
            {
                CbxHeadsLevel2.DataSource = null;
            }
            else if (Level == 3)
            {
                CbxHeadsLevel3.DataSource = null;
            }
            
            IdAccount = null;

        }
        private void CbxHeads_SelectedIndexChanged(object sender, EventArgs e)
        {
            var manager = new AccountsBLL();
            MetroFramework.Controls.MetroComboBox ctrl = sender as MetroFramework.Controls.MetroComboBox;
            if (ctrl != null)
            {
                if (Validation.GetSafeGuid(ctrl.SelectedValue) != null)
                {
                    if (ctrl.Name == "CbxHeadsLevel1")
                    {
                        if (ctrl.SelectedValue != null && Validation.GetSafeLong(ctrl.SelectedValue) > 0)
                        {
                            FillHeads(Validation.GetSafeLong(ctrl.SelectedValue), 2);
                            levelOne = Validation.GetSafeInteger(manager.GetAccountsById(Validation.GetSafeLong(ctrl.SelectedValue))[0].AccountNo);
                        }
                        else
                        {
                            CbxHeadsLevel2.DataSource = null;
                        }
                    }
                    else if (ctrl.Name == "CbxHeadsLevel2")
                    {
                        if (ctrl.SelectedValue != null && Validation.GetSafeLong(ctrl.SelectedValue) > 0)
                        {
                            FillHeads(Validation.GetSafeLong(ctrl.SelectedValue), 3);
                            levelTwo = Validation.GetSafeInteger(manager.GetAccountsById(Validation.GetSafeLong(ctrl.SelectedValue))[0].AccountNo);
                        }
                        else
                        {
                            CbxHeadsLevel3.DataSource = null;
                        }
                    }
                    else if (ctrl.Name == "CbxHeadsLevel3")
                    {
                        if (ctrl.SelectedValue != null && Validation.GetSafeLong(ctrl.SelectedValue) > 0)
                        {
                            FillHeads(Validation.GetSafeLong(ctrl.SelectedValue), 4);
                            levelThree = Validation.GetSafeInteger(manager.GetAccountsById(Validation.GetSafeLong(ctrl.SelectedValue))[0].AccountNo);
                        }

                    }
                }
            }
        }
        private void chkByType_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByType.Checked)
            {
                pnlTypes.Visible = true;
                chkHeadWise.Checked = false;
                pnlHeads.Visible = false;
            }
            else
            {
                pnlTypes.Visible = false;
                chkHeadWise.Checked = false;
                pnlHeads.Visible = false;
            }
        }
        private void chkHeadWise_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHeadWise.Checked)
            {
                pnlHeads.Visible = true;
                chkByType.Checked = false;
                pnlTypes.Visible = false;
            }
            else
            {
                pnlHeads.Visible = false;
                chkByType.Checked = false;
                pnlTypes.Visible = false;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmClosingBalanceReports = new frmDetailedLedgerReport();
            if (!chkDate.Checked)
            {
                if (pnlTypes.Visible)
                {
                    frmClosingBalanceReports.ReportType = "ClosingBalancesReport";
                    frmClosingBalanceReports.SubReportType = "ClosingReport";
                    frmClosingBalanceReports.AccountType = cbxCategories.Text;
                }
                else if (pnlHeads.Visible)
                {
                    frmClosingBalanceReports.ReportType = "ClosingBalancesReport";
                    frmClosingBalanceReports.IdHead = Validation.GetSafeLong(CbxHeadsLevel1.SelectedValue);
                    frmClosingBalanceReports.SubReportType = "ClosingReportByHead";
                    frmClosingBalanceReports.AccountType = CbxHeadsLevel3.Text;
                }
            }
            else
            {
                if (pnlTypes.Visible)
                {
                    frmClosingBalanceReports.ReportType = "ClosingBalanceReportWithDate";
                    frmClosingBalanceReports.StartDate = Convert.ToDateTime(StartDate.Value.ToShortDateString());
                    frmClosingBalanceReports.EndDate = Convert.ToDateTime(EndDate.Value.ToShortDateString());
                    frmClosingBalanceReports.SubReportType = "ClosingBalanceReportWithDate";
                    frmClosingBalanceReports.AccountType = cbxCategories.Text;
                }
                else if (pnlHeads.Visible)
                {
                    frmClosingBalanceReports.ReportType = "DetailReportWithDate";
                    frmClosingBalanceReports.IdHead = Validation.GetSafeLong(CbxHeadsLevel1.SelectedValue);
                    frmClosingBalanceReports.SubReportType = "ClosingReportByHeadWithDate";
                    frmClosingBalanceReports.StartDate = Convert.ToDateTime(StartDate.Value.ToShortDateString());
                    frmClosingBalanceReports.EndDate = Convert.ToDateTime(EndDate.Value.ToShortDateString());
                    frmClosingBalanceReports.AccountType = CbxHeadsLevel3.Text;
                }
            }
            frmClosingBalanceReports.ProjectName = Operations.ProjectName;
            frmClosingBalanceReports.ShowDialog();
        }
    }
}
