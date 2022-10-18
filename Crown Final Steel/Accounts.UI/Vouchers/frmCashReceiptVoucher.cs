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

namespace Accounts.UI
{
    public partial class frmCashReceiptVoucher : Form
    {
        frmFindAccounts frmAccount;
        frmFindVouchers frmfindVouchers;
        public decimal OldValue { get; set; }
        public Int64 VoucherId { get; set; }
        public Guid IdVoucher = Guid.Empty;
        public Guid CashTransactionId { get; set; }
        public string VoucherType { get; set; }
        bool checkSender = false;        
        public frmCashReceiptVoucher()
        {
            InitializeComponent();
        }

        private void frmCashReceiptVoucher_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void FillData()
        {
            var manager = new VoucherBLL();
            VEditBox.Text = manager.GetMaxVoucherNumber("CashReceiptVoucher",Operations.IdCompany);
        }
        private bool ValidateRows()
        {
            bool isTrue = true;
            if (DgvCashReceipt.Rows.Count > 1)
            {
                for (int i = 0; i < DgvCashReceipt.Rows.Count - 1; i++)
                {
                    if (DgvCashReceipt.Rows[i].Cells["colAccount"].Value == null)
                    {
                        isTrue = false;
                    }
                    else if (DgvCashReceipt.Rows[i].Cells["colAmount"].Value == null)
                    {
                        isTrue = false;
                    }
                }
            }
            else
            {
                isTrue = false;
            }
            return isTrue;
        }
        private void ClearControl()
        {
            DgvCashReceipt.Rows.Clear();
            txtDescription.Text = string.Empty;
            VoucherId = 0;
            txtTotalAmount.Text = string.Empty;
            CashTransactionId = Guid.Empty;
            CEditBox.Text = string.Empty;
            lblStatuMessage.Text = string.Empty;
            if (chkPosted.Checked)
            {
                chkPosted.Checked = false;
                chkPosted.Enabled = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private bool ValidateControls()
        {
            if (CEditBox.Text == string.Empty)
            {
                lblStatuMessage.Text = "Cash Account Missing...";
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            List<RecievedDetailEL> oelRecievedDetailCollection = new List<RecievedDetailEL>();
            if (ValidateRows())
            {
                if (ValidateControls())
                {
                    /// Add Voucher...
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Convert.ToInt32(VEditBox.Text);
                    oelVoucher.IdUser = Operations.UserID;
                    oelVoucher.Date = VDate.Value;
                    oelVoucher.AccountNo = Validation.GetSafeLong(CEditBox.Text);
                    oelVoucher.Description = txtDescription.Text;
                    oelVoucher.Amount = Convert.ToDecimal(txtTotalAmount.Text == "" ? "0" : txtTotalAmount.Text);
                    //oelVoucher.Discount = Validation.GetSafeDecimal(txtDiscount.Text);
                    //oelVoucher.DiscountAmount = Validation.GetSafeDecimal(txtDiscountAmount.Text);
                    oelVoucher.Posted = chkPosted.Checked;
                    if (chkPosted.Checked)
                    {
                        oelVoucher.Posted = true;
                    }
                    else
                    {
                        oelVoucher.Posted = false;
                    }
                    /// Add Customers In Transaction ...
                    for (int i = 0; i < DgvCashReceipt.Rows.Count - 1; i++)
                    {
                        TransactionsEL oelTransaction = new TransactionsEL();

                        if (DgvCashReceipt.Rows[i].Cells["ColTransaction"].Value != null)
                        {
                            oelTransaction.TransactionID = new Guid(DgvCashReceipt.Rows[i].Cells["ColTransaction"].Value.ToString());
                            oelTransaction.IsNew = false;
                        }
                        else
                        {
                            oelTransaction.TransactionID = Guid.NewGuid();
                            oelTransaction.IsNew = true;
                        }
                        oelTransaction.AccountNo = Validation.GetSafeLong(DgvCashReceipt.Rows[i].Cells["colAccount"].Value);
                        oelTransaction.Date = VDate.Value;
                        oelTransaction.VoucherNo = Convert.ToInt64(VEditBox.Text);
                        oelTransaction.VoucherType = "CashReceiptVoucher";
                        if (DgvCashReceipt.Rows[i].Cells["colDescription"].Value == null)
                        {
                            oelTransaction.Description = "N/A";
                        }
                        else
                        {
                            oelTransaction.Description = DgvCashReceipt.Rows[i].Cells["colDescription"].Value.ToString();
                        }
                        oelTransaction.Credit = Convert.ToDecimal(DgvCashReceipt.Rows[i].Cells["colAmount"].Value);
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

                    // Add Customer's Cash In Detail
                    for (int j = 0; j < DgvCashReceipt.Rows.Count - 1; j++)
                    {
                        RecievedDetailEL oelRecievedDetail = new RecievedDetailEL();
                        if (DgvCashReceipt.Rows[j].Cells["ColRecievedDetailId"].Value != null)
                        {
                            oelRecievedDetail.IdRecievedDetail = new Guid(DgvCashReceipt.Rows[j].Cells["ColRecievedDetailId"].Value.ToString());
                            oelRecievedDetail.IsNew = false;
                        }
                        else
                        {
                            oelRecievedDetail.IdRecievedDetail = Guid.NewGuid();
                            oelRecievedDetail.IsNew = true;
                        }
                        oelRecievedDetail.VoucherNo = Convert.ToInt64(VEditBox.Text);
                        if (DgvCashReceipt.Rows[j].Cells["colDescription"].Value == null)
                        {
                            oelRecievedDetail.Description = "N/A";
                        }
                        else
                        {
                            oelRecievedDetail.Description = DgvCashReceipt.Rows[j].Cells["colDescription"].Value.ToString();
                        }
                        oelRecievedDetail.AccountNo = Validation.GetSafeLong(DgvCashReceipt.Rows[j].Cells["colAccount"].Value);
                        oelRecievedDetail.Amount = Validation.GetSafeDecimal(DgvCashReceipt.Rows[j].Cells["colAmount"].Value);
                        oelRecievedDetailCollection.Add(oelRecievedDetail);
                    }

                    /// Add Cash in Transaction...
                    TransactionsEL oeTransaction = new TransactionsEL();
                    if (CashTransactionId != Guid.Empty)
                    {
                        oeTransaction.TransactionID = CashTransactionId;
                        oeTransaction.IsNew = false;
                    }
                    else
                    {
                        oeTransaction.TransactionID = Guid.NewGuid();
                        oeTransaction.IsNew = true;
                    }
                    oeTransaction.AccountNo = Validation.GetSafeLong(CEditBox.Text);
                    oeTransaction.Date = VDate.Value;
                    oeTransaction.VoucherNo = Convert.ToInt32(VEditBox.Text);
                    oeTransaction.VoucherType = "CashReceiptVoucher";
                    oeTransaction.Description = txtDescription.Text;
                    oeTransaction.Debit = Convert.ToDecimal(txtTotalAmount.Text == "" ? "0" : txtTotalAmount.Text);
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
                    if (CashTransactionId == Guid.Empty)
                    {
                        var manager = new CashReceiptBLL();
                        EntityoperationInfo infoResult = manager.InsertCashReceipt(oelVoucher, oelRecievedDetailCollection, oelTransactionCollection);
                        if (infoResult.IsSuccess)
                        {
                            //manager.UpdateStockitems(oelTransactionCollection, "Add");
                            lblStatuMessage.Text = "Cash Receipt Successfully...";
                            ClearControl();
                            FillData();
                        }
                    }
                    else
                    {
                        var manager = new CashReceiptBLL();
                        EntityoperationInfo infoResult = manager.UpdateCashReceipt(oelVoucher, oelRecievedDetailCollection, oelTransactionCollection);
                        if (infoResult.IsSuccess)
                        {
                            // manager.UpdateStockitems(oelTransactionCollection, "Add");
                            lblStatuMessage.Text = "Cash Receipt Successfully...";
                            ClearControl();
                            FillData();
                        }
                    }
                }
                else
                {
                    lblStatuMessage.Text = "Cash Account Missing";
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
            DgvCashReceipt.EndEdit();
            DgvCashReceipt.CurrentCell = null;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelItemTransactionCollection = new List<TransactionsEL>();
            if (VEditBox.Text != string.Empty)
            {
                var manager = new CashReceiptBLL();
                if (VoucherId > 0)
                {
                    if (manager.DeleteCashReceipt(Convert.ToInt64(VEditBox.Text), "CashReceiptVoucher"))
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
        private void CEditBox_ClickButton(object sender, EventArgs e)
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
                for (int i = 0; i < DgvCashReceipt.Rows.Count - 1; i++)
                {
                    if (DgvCashReceipt.Rows[i].Cells["colAccount"].Value != null)
                    {
                        if (oelAccount.AccountNo == Validation.GetSafeString(DgvCashReceipt.Rows[i].Cells["colAccount"].Value))
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
                DgvCashReceipt.CurrentCell.Value = oelAccount.AccountNo;
                DgvCashReceipt.CurrentRow.Cells["colAccountName"].Value = oelAccount.AccountName;
                checkSender = false;
            }
            else
            {
                CEditBox.Text = Validation.GetSafeString(oelAccount.AccountNo);
            }
        }

        private void VEditBox_ClickButton(object sender, EventArgs e)
        {
            frmfindVouchers = new frmFindVouchers();
            frmfindVouchers.VoucherType = "CashReceiptVoucher";
            frmfindVouchers.ExecuteFindVouchersEvent += new frmFindVouchers.VouchersDelegate(frmfindVouchers_ExecuteFindVouchersEvent);
            frmfindVouchers.ShowDialog(this);
        }
        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {
            VoucherId = oelVoucher.VoucherNo;
            VEditBox.Text = oelVoucher.VoucherNo.ToString();
            CEditBox.Text = Validation.GetSafeString(oelVoucher.AccountNo);
            VDate.Value = oelVoucher.Date;            
            if (oelVoucher.Posted)
            {
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
                chkPosted.Checked = oelVoucher.Posted;
                chkPosted.Enabled = false;
                lblStatuMessage.Text = "Posted Voucher ...";
                lblStatuMessage.ForeColor = Color.Red;
            }
            var TManager = new TransactionBLL();
            CashTransactionId = TManager.GetHeadAccountTransactionId(Validation.GetSafeLong(VEditBox.Text), VoucherType, Validation.GetSafeLong(CEditBox.Text),Operations.IdCompany)[0].TransactionID;
            var manager = new VoucherBLL();
            List<TransactionsEL> List = manager.GetTransactionsByVoucherAndType(Operations.IdCompany, IdVoucher, VoucherId, VoucherType);
            FillTransactions(List);
        }
        private void FillVoucher()
        { 
            
        }
        private void FillTransactions(List<TransactionsEL> List)
        {
            if (DgvCashReceipt.Rows.Count > 0)
            {
                DgvCashReceipt.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {
                //TransactionsEL oeTransaction = List.Find(x => x.AccountNo == CEditBox.Text);
                //if (oeTransaction != null)
                //{
                //    txtTotalAmount.Text = oeTransaction.Debit.ToString();
                //    CashTransactionId = oeTransaction.TransactionID;
                //}
                //List.RemoveAt(List.FindIndex(x => x.AccountNo == CEditBox.Text));
                for (int i = 0; i < List.Count; i++)
                {
                    DgvCashReceipt.Rows.Add();
                    DgvCashReceipt.Rows[i].Cells[0].Value = List[i].TransactionID;
                    DgvCashReceipt.Rows[i].Cells[1].Value = List[i].IdDetail;
                    DgvCashReceipt.Rows[i].Cells[2].Value = List[i].AccountNo;
                    DgvCashReceipt.Rows[i].Cells[3].Value = List[i].AccountName;
                    DgvCashReceipt.Rows[i].Cells[4].Value = List[i].Description;
                    DgvCashReceipt.Rows[i].Cells[5].Value = List[i].Credit;
                }
                txtTotalAmount.Text = List.Sum(x => x.Credit).ToString();
                //txtDiscount.Text = List[0].Discount.ToString();
                //txtDiscountAmount.Text = List[0].TotalAmount.ToString();
                // DgvStockReceipt.DataSource = List;
                //

            }
        }
        private void DgvCashReceipt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {            
            if (DgvCashReceipt.Columns[e.ColumnIndex].Name == "colAmount")
            {
                if (DgvCashReceipt.Columns[e.ColumnIndex].Name == "colAmount")
                {
                    for (int i = 0; i < DgvCashReceipt.Rows.Count - 1; i++)
                    {
                        OldValue += Convert.ToDecimal(DgvCashReceipt.Rows[i].Cells["colAmount"].Value);
                    }
                    txtTotalAmount.Text = OldValue.ToString();
                    OldValue = 0;
                }
            }
        }
        private void DgvCashReceipt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (DgvCashReceipt.CurrentCellAddress.X == 2)
                {
                    checkSender = true;
                    frmAccount = new frmFindAccounts();
                    frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                    frmAccount.ShowDialog(this);
                }
            }
        }
        private void frmCashReceiptVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                FillData();
                ClearControl();
                if (DgvCashReceipt.Rows.Count > 0)
                {
                    DgvCashReceipt.Rows.Clear();
                }
            }
        }

        private void txtDiscount_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //decimal Amount = Validation.GetSafeDecimal(txtTotalAmount.Text);
                //txtDiscountAmount.Text = (Amount - Validation.GetSafeDecimal(txtDiscount.Text)).ToString();
                //e.Handled = true;
                //ProcessTabKey(true);
            }
        }
    }
}
