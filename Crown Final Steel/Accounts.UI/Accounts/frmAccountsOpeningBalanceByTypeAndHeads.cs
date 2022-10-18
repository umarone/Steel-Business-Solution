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
using Accounts.Common;

using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmAccountsOpeningBalanceByTypeAndHeads : MetroForm
    {
        #region Variables
        int AccountType, levelOne, levelTwo, levelThree;
        Int64? IdAccount = null;
        DataTable dtOpeningBalances;
        #endregion
        #region Form Methods And Events
        public frmAccountsOpeningBalanceByTypeAndHeads()
        {
            InitializeComponent();
        }
        private void frmAccountsOpeningBalanceByTypeAndHeads_Load(object sender, EventArgs e)
        {
            grdOpeningBalances.AutoGenerateColumns = false;
            FillHeads(null, 1);
        }
        private void frmAccountsOpeningBalanceByTypeAndHeads_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
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
        #endregion
        #region Win Controls Methods And Events
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
                pnlGrid.Visible = false;
            }
            else
            {
                pnlTypes.Visible = false;
                chkHeadWise.Checked = false;
                pnlHeads.Visible = false;
                pnlGrid.Visible = false;
            }
        }
        private void chkHeadWise_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHeadWise.Checked)
            {
                pnlHeads.Visible = true;
                chkByType.Checked = false;
                pnlTypes.Visible = false;
                pnlGrid.Visible = false;
            }
            else
            {
                pnlHeads.Visible = false;
                chkByType.Checked = false;
                pnlTypes.Visible = false;
                pnlGrid.Visible = false;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new OpeningBalanceBLL();
            List<OpeningBalanceEL> list = null;
            if (chkByType.Checked)
            {
                list = manager.GetOpeningBalancesByType(Operations.IdProject, Operations.BookNo, cbxCategories.Text);
            }
            else
            {
                list = manager.GetOpeningBalancesByType(Operations.IdProject, Operations.BookNo, CbxHeadsLevel3.Text);
            }            
            if (list.Count > 0)
            {
                dtOpeningBalances = DataOperations.ToDataTable(list);
                pnlGrid.Visible = true;
                grdOpeningBalances.DataSource = dtOpeningBalances;
            }
            else
            {
                pnlGrid.Visible = false;
                grdOpeningBalances.DataSource = null;
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtOpeningBalances);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtFilter.Text);
            grdOpeningBalances.DataSource = DV;
        }
        #endregion
    }
}
