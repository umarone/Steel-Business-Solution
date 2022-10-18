using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.BLL;
using Accounts.Common;
using Accounts.EL;

namespace Accounts.UI
{
    public partial class frmBankReceiptVoucher : Form
    {
        frmFindAccounts frmAccount;
        frmFindVouchers frmfindVouchers;
        public decimal OldValue { get; set; }
        public Int64 VoucherId { get; set; }
        public Guid IdVoucher = Guid.Empty;
        public Guid BankTransactionId { get; set; }
        bool IsNewVoucher;
        public string VoucherType { get; set; }
        bool checkSender = false;   
        public frmBankReceiptVoucher()
        {
            InitializeComponent();
        }

        private void frmBankReceiptVoucher_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void FillData()
        {
            var manager = new VoucherBLL();
            VEditBox.Text = manager.GetMaxVoucherNumber("BankReceiptVoucher",Operations.IdCompany);
        }
        private bool ValidateRows()
        {
            bool IsTrue = true;
            if (DgvBankReceiptVoucher.Rows.Count > 1)
            {
                for (int i = 0; i < DgvBankReceiptVoucher.Rows.Count - 1; i++)
                {
                    if (DgvBankReceiptVoucher.Rows[i].Cells["colAccount"].Value == null)
                    {
                        IsTrue = false;
                    }
                    else if (DgvBankReceiptVoucher.Rows[i].Cells["colAmount"].Value == null)
                    {
                        return false;
                    }
                }
            }
            else
            {
                IsTrue = false;
            }
            return IsTrue;
        }
        private bool ValidateControls()
        {
            if (BEditBox.Text == string.Empty)
            {
                lblStatuMessage.Text = "Bank Account Missing...";
                return false;
            }
            return true;
        }
        private void ClearControl()
        {
            DgvBankReceiptVoucher.Rows.Clear();
            txtDescription.Text = string.Empty;
            txtChequeNo.Text = string.Empty;
            VoucherId = 0;
            txtAmount.Text = string.Empty;
            BankTransactionId = Guid.Empty;
            IsNewVoucher = true;
            BEditBox.Text = string.Empty;
            if (chkPosted.Checked)
            {
                chkPosted.Checked = false;
                chkPosted.Enabled = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            if (ValidateRows())
            {
                if (ValidateControls())
                {
                    /// Add Voucher...
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Convert.ToInt32(VEditBox.Text);
                    oelVoucher.IdUser = Operations.UserID;
                    oelVoucher.Date = VDate.Value;
                    oelVoucher.AccountNo = Validation.GetSafeLong(BEditBox.Text);
                    oelVoucher.ChequeNo = txtChequeNo.Text;
                    oelVoucher.Description = txtDescription.Text;
                    oelVoucher.Amount = Convert.ToDecimal(txtAmount.Text == "" ? "0" : txtAmount.Text);
                    
                    if (chkPosted.Checked)
                    {
                        oelVoucher.Posted = true;
                    }
                    else
                    {
                        oelVoucher.Posted = false;
                    }
                    /// Add Customers ...
                    for (int i = 0; i < DgvBankReceiptVoucher.Rows.Count - 1; i++)
                    {
                        TransactionsEL oelTransaction = new TransactionsEL();
                        if (DgvBankReceiptVoucher.Rows[i].Cells["ColTransaction"].Value != null)
                        {
                            oelTransaction.TransactionID = new Guid(DgvBankReceiptVoucher.Rows[i].Cells["ColTransaction"].Value.ToString());
                            oelTransaction.IsNew = false;
                        }
                        else
                        {
                            oelTransaction.TransactionID = Guid.NewGuid();
                            oelTransaction.IsNew = true;
                        }
                        oelTransaction.AccountNo = Validation.GetSafeLong(DgvBankReceiptVoucher.Rows[i].Cells["colAccount"].Value);
                        oelTransaction.Date = VDate.Value;
                        oelTransaction.VoucherNo = Convert.ToInt32(VEditBox.Text);
                        oelTransaction.VoucherType = "BankReceiptVoucher";
                        if (DgvBankReceiptVoucher.Rows[i].Cells["colDescription"].Value == null)
                        {
                            oelTransaction.Description = "N/A";
                        }
                        else
                        {
                            oelTransaction.Description = DgvBankReceiptVoucher.Rows[i].Cells["colDescription"].Value.ToString();
                        }
                        oelTransaction.Credit = Convert.ToDecimal(DgvBankReceiptVoucher.Rows[i].Cells["colAmount"].Value);
                        oelTransaction.Debit = 0;
                        if (chkPosted.Checked)
                        {
                            oelTransaction.Posted = true;
                        }
                        else
                        {
                            oelTransaction.Posted = false;
                        }
                        oelTransactionCollection.Add(oelTransaction);
                    }
                    /// Add Bank...
                    TransactionsEL oeTransaction = new TransactionsEL();
                    if (BankTransactionId != Guid.Empty)
                    {
                        oeTransaction.TransactionID = BankTransactionId;
                        oeTransaction.IsNew = false;
                    }
                    else
                    {
                        oeTransaction.TransactionID = Guid.NewGuid();
                        oeTransaction.IsNew = true;
                    }
                    oeTransaction.AccountNo = Validation.GetSafeLong(BEditBox.Text);
                    oeTransaction.Date = VDate.Value;
                    oeTransaction.VoucherNo = Convert.ToInt32(VEditBox.Text);
                    oeTransaction.VoucherType = "BankReceiptVoucher";
                    oeTransaction.Description = txtDescription.Text;
                    oeTransaction.Debit = Convert.ToDecimal(txtAmount.Text == "" ? "0" : txtAmount.Text);
                    oeTransaction.Credit = 0;
                    if (chkPosted.Checked)
                    {
                        oeTransaction.Posted = true;
                    }
                    else
                    {
                        oeTransaction.Posted = false;
                    }
                    oelTransactionCollection.Add(oeTransaction);
                    if (BankTransactionId == Guid.Empty)
                    {
                        var manager = new BankReceiptVoucherBLL();
                        EntityoperationInfo infoResult = manager.InsertBankReceipt(oelVoucher, oelTransactionCollection);
                        if (infoResult.IsSuccess)
                        {
                            //manager.UpdateStockitems(oelTransactionCollection, "Add");
                            lblStatuMessage.Text = "Bank Transaction Successfully...";
                            ClearControl();
                            FillData();
                        }
                    }
                    else
                    {
                        var manager = new BankReceiptVoucherBLL();
                        EntityoperationInfo infoResult = manager.UpdateBankReceipt(oelVoucher, oelTransactionCollection);
                        if (infoResult.IsSuccess)
                        {
                            // manager.UpdateStockitems(oelTransactionCollection, "Add");
                            lblStatuMessage.Text = "Bank Transaction Updated Successfully...";
                            ClearControl();
                            FillData();
                        }
                    }
                }
                else
                {
                    lblStatuMessage.Text = "Bank Account Missing";
                }
            }

            else
            {
                lblStatuMessage.Text = "Incomplete Entry...";
                lblStatuMessage.ForeColor = Color.Red;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DgvBankReceiptVoucher.EndEdit();
            DgvBankReceiptVoucher.CurrentCell = null;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelItemTransactionCollection = new List<TransactionsEL>();
            if (VEditBox.Text != string.Empty)
            {
                var manager = new BankReceiptVoucherBLL();
                if (VoucherId > 0)
                {
                    if (manager.DeleteBankReceipt(Convert.ToInt64(VEditBox.Text), "BankReceiptVoucher"))
                    {
                        lblStatuMessage.Text = "Voucher Deleted Successfully";
                        ClearControl();
                    }
                }
                else
                {

                }
            }
        }

        private void BEditBox_ClickButton(object sender, EventArgs e)
        {
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }

        void frmAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            if (checkSender)
            {
                var manager = new PersonsBLL();
                //if (manager.VerifyAccount("Customers", oelChartOfAccount.AccountNo).Count > 0 || manager.VerifyAccount("Suppliers", oelChartOfAccount.AccountNo).Count > 0 || manager.VerifyAccount("Employees", oelChartOfAccount.AccountNo).Count > 0)
                //{
                for (int i = 0; i < DgvBankReceiptVoucher.Rows.Count - 1; i++)
                {
                    if (DgvBankReceiptVoucher.Rows[i].Cells["colAccount"].Value != null)
                    {
                        if (oelAccount.AccountNo == Validation.GetSafeString(DgvBankReceiptVoucher.Rows[i].Cells["colAccount"].Value))
                        {
                            lblStatuMessage.Text = "Person Already exists";
                            return;
                        }
                    }
                }
                //}
                //else
                //{
                //   lblStatuMessage.Text = "Please Select Persons Account";
                //  DgvCashReceipt.CurrentCell.Value = "";
                // DgvCashReceipt.Refresh();
                //return;
                //}
                DgvBankReceiptVoucher.CurrentCell.Value = oelAccount.AccountNo;
                DgvBankReceiptVoucher.CurrentRow.Cells["colAccountName"].Value = oelAccount.AccountName;
                checkSender = false;
            }
            else
            {
                BEditBox.Text = Validation.GetSafeString(oelAccount.AccountNo);
            }
        }

        private void VEditBox_ClickButton(object sender, EventArgs e)
        {
            frmfindVouchers = new frmFindVouchers();
            frmfindVouchers.VoucherType = "BankReceiptVoucher";
            frmfindVouchers.ExecuteFindVouchersEvent += new frmFindVouchers.VouchersDelegate(frmfindVouchers_ExecuteFindVouchersEvent);
            frmfindVouchers.ShowDialog(this);
        }

        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {
            VoucherId = oelVoucher.VoucherNo;
            VEditBox.Text = oelVoucher.VoucherNo.ToString();
            BEditBox.Text = oelVoucher.AccountNo.ToString();
            VDate.Value = oelVoucher.Date;
            IsNewVoucher = false;
            VoucherType = "BankReceiptVoucher";
            if (oelVoucher.Posted)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                chkPosted.Checked = oelVoucher.Posted;
                chkPosted.Enabled = false;
                lblStatuMessage.Text = "Posted Voucher ...";
                lblStatuMessage.ForeColor = Color.Red;
            }
            var manager = new VoucherBLL();
            List<TransactionsEL> List = manager.GetTransactionsByVoucherAndType(Operations.IdCompany, IdVoucher, VoucherId, VoucherType);
            FillTransactions(List);   
        }
        private void FillTransactions(List<TransactionsEL> List)
        {
            if (DgvBankReceiptVoucher.Rows.Count > 0)
            {
                DgvBankReceiptVoucher.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {
                TransactionsEL oeTransaction = List.Find(x => x.AccountNo == Validation.GetSafeString(BEditBox.Text));
                if (oeTransaction != null)
                {
                    txtAmount.Text = oeTransaction.Debit.ToString();
                    BankTransactionId = oeTransaction.TransactionID;
                }
                List.RemoveAt(List.FindIndex(x => x.AccountNo == Validation.GetSafeString(BEditBox.Text)));
                for (int i = 0; i < List.Count; i++)
                {
                    DgvBankReceiptVoucher.Rows.Add();
                    DgvBankReceiptVoucher.Rows[i].Cells[0].Value = List[i].TransactionID;
                    DgvBankReceiptVoucher.Rows[i].Cells[1].Value = List[i].AccountNo;
                    DgvBankReceiptVoucher.Rows[i].Cells[2].Value = List[i].AccountName;
                    DgvBankReceiptVoucher.Rows[i].Cells[3].Value = List[i].Description;
                    DgvBankReceiptVoucher.Rows[i].Cells[4].Value = List[i].Credit;
                }
                // DgvStockReceipt.DataSource = List;
                //

            }
        }

        private void DgvBankReceiptVoucher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvBankReceiptVoucher.Columns[e.ColumnIndex].Name == "colAmount")
            {
                if (DgvBankReceiptVoucher.Columns[e.ColumnIndex].Name == "colAmount")
                {
                    for (int i = 0; i < DgvBankReceiptVoucher.Rows.Count - 1; i++)
                    {
                        OldValue += Convert.ToDecimal(DgvBankReceiptVoucher.Rows[i].Cells["colAmount"].Value);
                    }
                    txtAmount.Text = OldValue.ToString();
                    OldValue = 0;
                }
            }
        }
        private void DgvBankReceiptVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (DgvBankReceiptVoucher.CurrentCellAddress.X == 1)
                {
                    checkSender = true;
                    frmAccount = new frmFindAccounts();
                    frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                    frmAccount.ShowDialog(this);
                }
            }
        }

        private void frmBankReceiptVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                FillData();
                ClearControl();
                if (DgvBankReceiptVoucher.Rows.Count > 0)
                {
                    DgvBankReceiptVoucher.Rows.Clear();
                }
            }
        }

        //private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        decimal Amount = Validation.GetSafeDecimal(txtTotalCash.Text);
        //        txtAmount.Text = (Amount - Validation.GetSafeDecimal(txtDiscount.Text)).ToString();
        //        e.Handled = true;
        //        ProcessTabKey(true);
        //    }
        //}
    }
}
