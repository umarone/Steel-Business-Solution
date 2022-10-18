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
using MetroFramework.Controls;
using Accounts.Common;
namespace Accounts.UI
{
    public partial class frmHeadsSetup : MetroForm
    {
        #region Variables
        public int Level { get; set; }
        public Int64? IdParent { get; set; }
        AccountsEL oelAccount = new AccountsEL();
        AccountsBLL objAccountsBLL = new AccountsBLL();
        int AccountType, levelOne, levelTwo, levelThree;
        Int64? IdAccount;
        string MiscAccount = "";
        bool? IsSystemHead;
        EntityoperationInfo infoResult = null;
        #endregion
        #region form Methods Events
        public frmHeadsSetup()
        {
            InitializeComponent();
        }
        private void frmHeadsSetup_Load(object sender, EventArgs e)
        {
            grdHeadsLevel2.AutoGenerateColumns = false;
            grdHeadsLevel3.AutoGenerateColumns = false;
            FillHeads(null, 1);
            FillByLevel(1);


        }
        private void frmHeadsSetup_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void FillHeads(Int64? Id, int level)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccountsByParent(Id, Operations.IdProject, Operations.IdCompany, level);
            if (list.Count > 0)
            {
                list.Insert(0, new AccountsEL() { IdAccount = 0, AccountName = "Select Head" });

                //cbxHeadsLevel3.SelectedIndex = -1;

                cbxHeadsLevel3.DataSource = list;
                cbxHeadsLevel3.DisplayMember = "AccountName";
                cbxHeadsLevel3.ValueMember = "IdAccount";

            }
        }
        private void FillChilds(Int64? IdParent, int level)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccountsByParent(IdParent, Operations.IdProject, Operations.IdCompany, level);
            if (list.Count > 0)
            {
                list.Insert(0, new AccountsEL() { IdAccount = 0, AccountName = "Select Head" });
                if (level == 3)
                {
                    cbxSubHeadsLevel3.DataSource = list;
                    cbxSubHeadsLevel3.DisplayMember = "AccountName";
                    cbxSubHeadsLevel3.ValueMember = "IdAccount";
                }
                else if (level == 3)
                {
                    //grdHeadsLevel2.DataSource = list;
                }
            }
            else
            { 
                //Nothing
            }
        }
        private void FillByLevel(int level)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccountByLevel(level);
            if (list.Count > 0)
            {
                list.Insert(0, new AccountsEL() { IdAccount = 0, AccountName = "Select Head" });

                //cbxHeadsLevel3.SelectedIndex = -1;

                cbxHeadsLevel2.DataSource = list;
                cbxHeadsLevel2.DisplayMember = "AccountName";
                cbxHeadsLevel2.ValueMember = "IdAccount";
            }
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            MetroTile ctrl = sender as MetroTile;
            if (ctrl != null)
            {
                if (ctrl.Name == "btnSaveLevel2")
                {
                    if (txtAccountNameLevel2.Text == string.Empty && txtAccountNumberLevel2.Text == string.Empty)
                    {
                        MessageBox.Show("Please Enter Account Name OR Account Number");
                        return;
                    }
                    oelAccount.IdParent = Validation.GetSafeLong(cbxHeadsLevel2.SelectedValue);
                }
                else
                {
                    if (txtAccountNameLevel3.Text == string.Empty && txtAccountNumberLevel3.Text == string.Empty)
                    {
                        MessageBox.Show("Please Enter Account Name OR Account Number");
                        return;
                    }
                    oelAccount.IdParent = Validation.GetSafeLong(cbxSubHeadsLevel3.SelectedValue);
                }
                oelAccount.UserId = Operations.UserID;
                oelAccount.IdCompany = null; //Operations.IdCompany;
                oelAccount.CreatedDateTime = DateTime.Now;
                if (!IdAccount.HasValue)
                {
                    oelAccount.IdAccount = 1;
                }
                else
                {
                    oelAccount.IdAccount = IdAccount.Value;
                }
                if (ctrl.Name == "btnSaveLevel2")
                {
                    oelAccount.AccountNo = Validation.GetSafeString(txtAccountNumberLevel2.Text);
                    oelAccount.PersonalAccountNo = "";
                    oelAccount.AccountName = txtAccountNameLevel2.Text;
                }
                else if (ctrl.Name == "btnSaveLevel3")
                {
                    oelAccount.AccountNo = Validation.GetSafeString(txtAccountNumberLevel3.Text);
                    oelAccount.PersonalAccountNo = "";
                    oelAccount.AccountName = txtAccountNameLevel3.Text;
                }
                if (ctrl.Name == "btnSaveLevel2")
                {
                    if (cbxHeadsLevel2.Text == "Assets")
                    {
                        oelAccount.IdHead = 1;
                    }
                    else if (cbxHeadsLevel2.Text == "Libilities")
                    {
                        oelAccount.IdHead = 2;
                    }
                    else if (cbxHeadsLevel2.Text == "Equity / Capital")
                    {
                        oelAccount.IdHead = 3;
                    }
                    else if (cbxHeadsLevel2.Text == "Revenue")
                    {
                        oelAccount.IdHead = 4;
                    }
                    else if (cbxHeadsLevel2.Text == "Expenses")
                    {
                        oelAccount.IdHead = 5;
                    }
                }
                else
                {
                    if (cbxHeadsLevel3.Text == "Assets")
                    {
                        oelAccount.IdHead = 1;
                    }
                    else if (cbxHeadsLevel3.Text == "Libilities")
                    {
                        oelAccount.IdHead = 2;
                    }
                    else if (cbxHeadsLevel3.Text == "Equity / Capital")
                    {
                        oelAccount.IdHead = 3;
                    }
                    else if (cbxHeadsLevel3.Text == "Revenue")
                    {
                        oelAccount.IdHead = 4;
                    }
                    else if (cbxHeadsLevel3.Text == "Expenses")
                    {
                        oelAccount.IdHead = 5;
                    }
                }
                oelAccount.IsActive = true;
                oelAccount.IsSystemAccount = false;
                if (ctrl.Name == "btnSaveLevel2")
                {
                    oelAccount.AccountType = cbxHeadsLevel2.Text;
                }
                else if (ctrl.Name == "btnSaveLevel3")
                {
                    oelAccount.AccountType = cbxSubHeadsLevel3.Text;
                }
                if (ctrl.Name == "btnSaveLevel2")
                {
                    oelAccount.IdLevel = 2;
                }
                else if (ctrl.Name == "btnSaveLevel3")
                {
                    oelAccount.IdLevel = 3;
                }

                oelAccount.Discription = "";

                if (MiscAccount == string.Empty)
                {
                    //if (!objAccountsBLL.CheckAccount(Validation.GetSafeLong(txtAccountNumber.Text), Operations.IdCompany))
                    {
                        infoResult = objAccountsBLL.InsertChartsOfAccounts(oelAccount);
                        if (infoResult.IsSuccess)
                        {
                            MessageBox.Show("Account Created Successfully...");
                            if (ctrl.Name == "btnSaveLevel2")
                            {
                                FillMaxAccountNo(2, Validation.GetSafeLong(cbxHeadsLevel2.SelectedValue));
                                FillGrid(2, Validation.GetSafeLong(cbxHeadsLevel2.SelectedValue));
                            }
                            else if (ctrl.Name == "btnSaveLevel3")
                            {
                                FillMaxAccountNo(3, Validation.GetSafeLong(cbxSubHeadsLevel3.SelectedValue));
                                FillGrid(3, Validation.GetSafeLong(cbxSubHeadsLevel3.SelectedValue));
                            }
                            //CbxHeads_SelectedIndexChanged(sender, e);
                            ClearControls();
                        }
                        else
                        {
                            MessageBox.Show("Some Problem Occured while Saving Account...");
                        }
                    }
                    //else
                    {
                        // MessageBox.Show("Account Already Exists...");
                    }
                }
                else
                {
                    infoResult = objAccountsBLL.UpdateChartsOfAccounts(oelAccount);
                    if (infoResult.IsSuccess)
                    {
                        MessageBox.Show("Account Updated Successfully...");
                        if (ctrl.Name == "btnSaveLevel2")
                        {
                            FillMaxAccountNo(2, Validation.GetSafeLong(cbxHeadsLevel2.SelectedValue));
                        }
                        else if (ctrl.Name == "btnSaveLevel3")
                        {
                            FillMaxAccountNo(3, Validation.GetSafeLong(cbxSubHeadsLevel3.SelectedValue));
                        }
                        ClearControls();
                    }
                    else
                    {
                        MessageBox.Show("Some Problem Occured while Saving Account...");
                    }
                }
            }
        }
        private void btnDeleteLevel2_Click(object sender, EventArgs e)
        {
            if (IsSystemHead.Value)
            {
                MessageBox.Show("This Is System Head And Can Not Be Deleted....");
            }
            else
            {
                var manager = new AccountsBLL();
                List<AccountsEL> list = manager.GetAccountsByParent(IdAccount, Operations.IdProject, Operations.IdCompany, 2);
                if (list.Count > 0)
                {
                    MessageBox.Show("This Head has Sibling Heads, So First Remove Sibiling Heads Then Remove Head");
                }
                else
                {
                    if (manager.DeleteChartOfAccount(IdAccount.Value).IsSuccess)
                    {
                        MessageBox.Show("Head Deleted Successfully....");
                        FillGrid(2, IdAccount.Value);
                    }
                }
            }
        }
        private void btnDeleteLevel3_Click(object sender, EventArgs e)
        {
            if (IsSystemHead.Value)
            {
                MessageBox.Show("This Is System Head And Can Not Be Deleted....");
            }
            else
            {
                var manager = new AccountsBLL();
                List<AccountsEL> list = manager.GetAccountsByParent(IdAccount, Operations.IdProject, Operations.IdCompany, 2);
                if (list.Count > 0)
                {
                    MessageBox.Show("This Head has Sibling Accounts, So First Remove Sibiling Accounts Then Remove Head");
                }
                else
                {
                    if (manager.DeleteChartOfAccount(IdAccount.Value).IsSuccess)
                    {
                        MessageBox.Show("Head Deleted Successfully....");
                        FillGrid(3, IdAccount.Value);
                    }
                }
            }
        }
        #endregion
        #region Misc Methods
        private void ClearControls()
        {
            txtAccountNameLevel2.Text = string.Empty;
            txtAccountNameLevel3.Text = string.Empty;
            MiscAccount = string.Empty;
            //txtHeadDiscription.Text = string.Empty;
            IdAccount = null;
        }
        private void FillMaxAccountNo(int Level, Int64 IdParent)
        {
            var manager = new AccountsBLL();
            string MaxAccountNo = manager.GetMaxAccountNo(levelOne, levelTwo, levelThree, Level, Operations.IdCompany, IdParent);
            //if (MaxAccountNo.HasValue)
            //{
            if (Level == 2)
            {
                txtAccountNumberLevel2.Text = MaxAccountNo;
            }
            else
            {
                txtAccountNumberLevel3.Text = MaxAccountNo;
            }

            //}
        }
        #endregion
        #region ComboBox Methods And Events
        private void CbxHeads_SelectedIndexChanged(object sender, EventArgs e)
        {
            var manager = new AccountsBLL();
            MetroFramework.Controls.MetroComboBox ctrl = sender as MetroFramework.Controls.MetroComboBox;
            if (ctrl != null)
            {
                if (Validation.GetSafeLong(ctrl.SelectedValue) != 0)
                {
                    if (ctrl.Name == "cbxHeadsLevel2")
                    {
                        if (Validation.GetSafeLong(ctrl.SelectedValue) != 0)
                        {
                            //FillHeads(Validation.GetSafeGuid(ctrl.SelectedValue), 2);
                            FillGrid(2, Validation.GetSafeLong(ctrl.SelectedValue));
                            levelOne = Validation.GetSafeInteger(manager.GetAccountsById(Validation.GetSafeLong(ctrl.SelectedValue))[0].AccountNo);
                            FillMaxAccountNo(2, Validation.GetSafeLong(ctrl.SelectedValue));
                        }
                    }
                    else if (ctrl.Name == "cbxHeadsLevel3" && Validation.GetSafeLong(ctrl.SelectedValue) > 0)
                    {
                        if (ctrl.SelectedValue != null)
                        {
                            FillChilds(Validation.GetSafeLong(ctrl.SelectedValue), 3);
                            //levelTwo = Validation.GetSafeInteger(manager.GetAccountsById(Validation.GetSafeGuid(ctrl.SelectedValue))[0].AccountNo);
                            //FillMaxAccountNo(Level, Validation.GetSafeGuid(ctrl.SelectedValue));
                        }
                    }
                    else if (ctrl.Name == "cbxSubHeadsLevel3")
                    {
                        if (ctrl.SelectedValue != null && Validation.GetSafeLong(ctrl.SelectedValue) > 0)
                        {
                            //FillHeads(Validation.GetSafeGuid(ctrl.SelectedValue), 3);
                            FillGrid(3, Validation.GetSafeLong(ctrl.SelectedValue));
                            levelTwo = Validation.GetSafeInteger(manager.GetAccountsById(Validation.GetSafeLong(ctrl.SelectedValue))[0].AccountNo);
                            FillMaxAccountNo(3, Validation.GetSafeLong(ctrl.SelectedValue));
                        }
                    }
                }
            }
        }
        private void FillGrid(int level, Int64? IdParent)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccountsByParent(IdParent, Operations.IdProject, Operations.IdCompany, level);
            if (level == 2)
            {
                if (list.Count > 0)
                {
                    grdHeadsLevel2.DataSource = list;
                }
                else
                {
                    grdHeadsLevel2.DataSource = null;
                }
            }
            else
            {
                if (list.Count > 0)
                {
                    grdHeadsLevel3.DataSource = list;
                }
                else
                {
                    grdHeadsLevel3.DataSource = null;
                }
            }
        }
        #endregion
        #region Both Grid Events
        private void grdHeadsLevel2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdAccount = Validation.GetSafeLong(grdHeadsLevel2.Rows[e.RowIndex].Cells["colAccountId"].Value);
            IsSystemHead = Validation.GetSafeBooleanNullable(grdHeadsLevel2.Rows[e.RowIndex].Cells["colIsSystemAccount"].Value);
            txtAccountNumberLevel2.Text = Validation.GetSafeString(grdHeadsLevel2.Rows[e.RowIndex].Cells["colAccountCode"].Value);
            txtAccountNameLevel2.Text = Validation.GetSafeString(grdHeadsLevel2.Rows[e.RowIndex].Cells["colACTitle"].Value);
            MiscAccount = "Raw";
            if (IsSystemHead.Value)
            {
                MessageBox.Show("This Is System Head, Cannot Be Deleted OR Updated...");
                txtAccountNumberLevel2.Enabled = false;
                txtAccountNameLevel2.Enabled = false;
            }
            else
            {
                txtAccountNumberLevel2.Enabled = true;
                txtAccountNameLevel2.Enabled = true;
            }
        }
        private void grdHeadsLevel3_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdAccount = Validation.GetSafeLong(grdHeadsLevel3.Rows[e.RowIndex].Cells["colLevel3IdAccount"].Value);
            IsSystemHead = Validation.GetSafeBooleanNullable(grdHeadsLevel3.Rows[e.RowIndex].Cells["colLevel3IsSystemAccount"].Value);
            txtAccountNumberLevel3.Text = Validation.GetSafeString(grdHeadsLevel3.Rows[e.RowIndex].Cells["colLevel3HeadCode"].Value);
            txtAccountNameLevel3.Text = Validation.GetSafeString(grdHeadsLevel3.Rows[e.RowIndex].Cells["colLevel3AcTitle"].Value);
            MiscAccount = "Raw";

            if (IsSystemHead.Value)
            {
                MessageBox.Show("This Is System Head, Cannot Be Deleted OR Updated...");
                txtAccountNumberLevel3.Enabled = false;
                txtAccountNameLevel3.Enabled = false;
            }
            else
            {
                txtAccountNumberLevel3.Enabled = true;
                txtAccountNameLevel3.Enabled = true;
            }
        }
        #endregion
    }
}
