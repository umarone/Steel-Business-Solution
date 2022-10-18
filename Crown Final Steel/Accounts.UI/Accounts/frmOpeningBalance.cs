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
    public partial class frmOpeningBalance : MetroForm
    {
        frmFindAccounts frmAccount;
        int HeaderAccount;
        public frmOpeningBalance()
        {
            InitializeComponent();
        }
        private void frmOpeningBalance_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //DgvOpeningBalance.Columns[5].Visible = false;

            CheckModulePermissions();
            //DgvOpeningBalance.Enabled = false;
            FillEmployees();
        }
        private void FillEmployees()
        {
            var manager = new AccountsBLL();
            List<AccountsEL> listAccounts = manager.GetEmployeesAccounts(Operations.IdProject);

            cbxEmployees.DataSource = listAccounts;
            cbxEmployees.DisplayMember = "AccountName";
            cbxEmployees.ValueMember = "AccountNo";
        }
        private void CheckModulePermissions()
        {
            List<UserModulesPermissionsEL> PermissionsList = UserPermissions.GetUserModulePermissionsByUserAndModuleId(Operations.UserID);
            if (PermissionsList != null && PermissionsList.Count > 0)
            {
                if (PermissionsList[0].Saving == true)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
                if (PermissionsList[0].Deleting == true)
                {
                    btnDelete.Enabled = true;
                }
                else
                {
                    btnDelete.Enabled = false;
                }
            }
            //else if(Operations.IdRole == Validation.GetSafeGuid(EnRoles.Operators))
            //{
            //    btnSave.Enabled = false;
            //    btnDelete.Enabled = false;
            //}
        }
        void frmAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            DgvOpeningBalance.RefreshEdit();
            var manager = new OpeningBalanceBLL();
            List<OpeningBalanceEL> list = null;
            list = manager.GetOpeningBalance(Operations.IdProject, Operations.BookNo, oelAccount.AccountNo);
            if (list.Count > 0)
            {
                FillOpeningBalance(list);
            }
            else
            {
                DgvOpeningBalance.CurrentRow.Cells["colAccount"].Value = oelAccount.AccountNo;
                DgvOpeningBalance.CurrentRow.Cells["colAccountName"].Value = oelAccount.AccountName;
                DgvOpeningBalance.CurrentRow.Cells["colHeadId"].Value = oelAccount.IdHead;
            }
            DgvOpeningBalance.CurrentRow.Cells["colAccountName"].Selected = true;
        }
        private void FillOpeningBalance(List<OpeningBalanceEL> OpeningBalancelist)
        {
            if (DgvOpeningBalance.Rows.Count > 0)
            {
                dtOpeningBalance.Value = OpeningBalancelist[0].OpeningBalanceDate;
                DgvOpeningBalance.Rows.Clear();
            }
            for (int i = 0; i < OpeningBalancelist.Count; i++)
            {
                DgvOpeningBalance.Rows.Add();
                DgvOpeningBalance.Rows[i].Cells["colIdOpeningBalance"].Value = OpeningBalancelist[i].IdOpeningBalance;
                DgvOpeningBalance.Rows[i].Cells["colHeadId"].Value = OpeningBalancelist[i].IdHead;
                DgvOpeningBalance.Rows[i].Cells["colAccount"].Value = OpeningBalancelist[i].AccountNo;
                DgvOpeningBalance.Rows[i].Cells["colAccountName"].Value = OpeningBalancelist[i].AccountName;
                DgvOpeningBalance.Rows[i].Cells["colDiscription"].Value = OpeningBalancelist[i].Discription;
                DgvOpeningBalance.Rows[i].Cells["colAmount"].Value = OpeningBalancelist[i].Amount.ToString("0.00");
            }
        }
        private bool ValidateRows()
        {

            for (int i = 0; i < DgvOpeningBalance.Rows.Count - 1; i++)
            {
                if (DgvOpeningBalance.Rows[i].Cells["colAccount"].Value == null)
                {
                    return false;
                }
                else if (DgvOpeningBalance.Rows[i].Cells["colAmount"].Value == null)
                {
                    return false;
                }
            }
            return true;
        }
        private void ClearControl()
        {
            DgvOpeningBalance.Rows.Clear();
            dtOpeningBalance.Value = DateTime.Now;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new OpeningBalanceBLL();
            try
            {
                if (DgvOpeningBalance.Rows.Count > 0)
                {
                    for (int i = 0; i < DgvOpeningBalance.Rows.Count; i++)
                    {
                        if (manager.DeleteOpeningBalance(Validation.GetSafeString(DgvOpeningBalance.Rows[i].Cells["colAccount"].Value), new Guid(DgvOpeningBalance.Rows[i].Cells["ColTransaction"].Value.ToString()), Operations.IdCompany).IsSuccess == true)
                        {
                            lblStatuMessage.Text = "Opening Balance Is Deleted Successfully...";
                            ClearControl();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                lblStatuMessage.Text = "Problem Occured While Deleting OpeningBalance...";
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            List<OpeningBalanceEL> oelOpeningBalanceCollections = new List<OpeningBalanceEL>();
            //List<StockReceiptEL> oelOpeningStockCollection = new List<StockReceiptEL>();
            if (ValidateRows())
            {
                #region Header Section
                /// Add Opening Balance And Transaction ...
                for (int i = 0; i < DgvOpeningBalance.Rows.Count - 1; i++)
                {
                    OpeningBalanceEL oelOpeningBalance = new OpeningBalanceEL();
                    //StockReceiptEL oelStockReceipt = new StockReceiptEL();

                    if (DgvOpeningBalance.Rows[i].Cells["colIdOpeningBalance"].Value != null)
                    {
                        oelOpeningBalance.IdOpeningBalance = Validation.GetSafeLong(DgvOpeningBalance.Rows[i].Cells["colIdOpeningBalance"].Value);
                        oelOpeningBalance.IsNew = false;
                    }
                    else
                    {
                        oelOpeningBalance.IdOpeningBalance = 0;
                        oelOpeningBalance.IsNew = true;
                    }
                    oelOpeningBalance.IdProject = Operations.IdProject;
                    oelOpeningBalance.BookNo = Operations.BookNo;
                    oelOpeningBalance.UserId = Operations.UserID;
                    oelOpeningBalance.AccountNo = Validation.GetSafeString(DgvOpeningBalance.Rows[i].Cells["colAccount"].Value);
                    oelOpeningBalance.AccountName = DgvOpeningBalance.Rows[i].Cells["colAccountName"].Value.ToString();
                    oelOpeningBalance.EmpCode = Validation.GetSafeString(cbxEmployees.SelectedValue);

                    if (DgvOpeningBalance.Rows[i].Cells["colHeadId"].Value != null)
                    {
                        HeaderAccount = Validation.GetSafeInteger(DgvOpeningBalance.Rows[i].Cells["colHeadId"].Value);
                    }
                    oelOpeningBalance.Amount = Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value);
                    oelOpeningBalance.Discription = Validation.GetSafeString(DgvOpeningBalance.Rows[i].Cells["colDiscription"].Value);
                    oelOpeningBalance.OpeningBalanceDate = dtOpeningBalance.Value; // DateTime.Now;
                #endregion
                #region Balance Calculation Section
                    if (HeaderAccount == Validation.GetSafeInteger(HeaderAccounts.Assets))
                    {
                        if (Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value) < 0)
                        {
                            //oelTransaction.Credit = Math.Abs(Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value));
                            oelOpeningBalance.Credit = Math.Abs(Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value));
                            oelOpeningBalance.TransactionMode = "CR";
                            oelOpeningBalance.Debit = 0;
                        }
                        else
                        {
                            oelOpeningBalance.Debit = Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value);
                            oelOpeningBalance.Credit = 0;
                            oelOpeningBalance.TransactionMode = "DR";
                        }
                    }
                    else if (HeaderAccount == Validation.GetSafeInteger(HeaderAccounts.Libilities))
                    {
                        if (Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value) < 0)
                        {
                            oelOpeningBalance.Debit = Math.Abs(Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value));
                            oelOpeningBalance.Credit = 0;
                            oelOpeningBalance.TransactionMode = "DR";
                        }
                        else
                        {
                            oelOpeningBalance.Credit = Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value);
                            oelOpeningBalance.Debit = 0;
                            oelOpeningBalance.TransactionMode = "CR";
                        }
                    }
                    else if (HeaderAccount == Validation.GetSafeInteger(HeaderAccounts.Expense))
                    {
                        if (Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value) < 0)
                        {
                            oelOpeningBalance.Credit = Math.Abs(Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value));
                            oelOpeningBalance.Debit = 0;
                            oelOpeningBalance.TransactionMode = "CR";
                        }
                        else
                        {
                            oelOpeningBalance.Debit = Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value);
                            oelOpeningBalance.Credit = 0;
                            oelOpeningBalance.TransactionMode = "DR";
                        }
                    }
                    else if (HeaderAccount == Validation.GetSafeInteger(HeaderAccounts.Income))
                    {
                        if (Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value) < 0)
                        {
                            oelOpeningBalance.Debit = Math.Abs(Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value));
                            oelOpeningBalance.Credit = 0;
                            oelOpeningBalance.TransactionMode = "DR";
                        }
                        else
                        {
                            oelOpeningBalance.Credit = Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value);
                            oelOpeningBalance.Debit = 0;
                            oelOpeningBalance.TransactionMode = "CR";
                        }
                    }
                    else if (HeaderAccount == Validation.GetSafeInteger(HeaderAccounts.Equity))
                    {
                        if (Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value) < 0)
                        {
                            oelOpeningBalance.Debit = Math.Abs(Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value));
                            oelOpeningBalance.Credit = 0;
                            oelOpeningBalance.TransactionMode = "DR";
                        }
                        else
                        {
                            oelOpeningBalance.Credit = Convert.ToDecimal(DgvOpeningBalance.Rows[i].Cells["colAmount"].Value);
                            oelOpeningBalance.Debit = 0;
                            oelOpeningBalance.TransactionMode = "CR";
                        }
                    }

                    //oelTransactionCollection.Add(oelTransaction);
                    oelOpeningBalanceCollections.Add(oelOpeningBalance);

                }
                    #endregion
                #region Saving Code Section
                var manager = new OpeningBalanceBLL();
                EntityoperationInfo infoResult = manager.InsertUpdateOpeningBalance(oelOpeningBalanceCollections);
                if (infoResult.IsSuccess)
                {
                    //var managerStock = new PurchaseHeadBLL(); // PurchaseStockReceiptBLL();
                    //managerStock.UpdateStockitems(oelTransactionCollection, "Add");
                    lblStatuMessage.Text = "Opening Balance Transaction Successfull ...";
                    ClearControl();
                    //var managerStockReciept = new StockRecieptBLL();
                    //managerStockReciept.InsertUpdateStock(oelOpeningStockCollection);
                }
                #endregion
            }
            else
            {
                lblStatuMessage.Text = "Incomplete Entry...";
            }


        }
        private void DgvOpeningBalance_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvOpeningBalance.CurrentCellAddress.X == 3)
            {
                TextBox txtAccountName = e.Control as TextBox;
                if (txtAccountName != null)
                {
                    txtAccountName.KeyPress -= new KeyPressEventHandler(txtAccountName_KeyPress);
                    txtAccountName.KeyPress += new KeyPressEventHandler(txtAccountName_KeyPress);
                }
            }
        }
        void txtAccountName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DgvOpeningBalance.CurrentCellAddress.X == 3)
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
                {
                    frmAccount = new frmFindAccounts();
                    frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                    frmAccount.SearchText = e.KeyChar.ToString();
                    frmAccount.ShowDialog(this);
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
                else if (e.KeyChar == (char)Keys.Back)
                {

                }
                else
                    e.Handled = true;
            }
        }
        private void DgvOpeningBalance_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                SendKeys.Send("{F4}");
            }
        }

        private void frmOpeningBalance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
