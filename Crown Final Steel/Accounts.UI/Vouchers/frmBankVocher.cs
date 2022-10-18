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
    public partial class frmBankVocher : MetroFramework.Forms.MetroForm
    {
        frmFindAccounts frmAccount;
        frmFindVouchers frmfindVouchers;
        public decimal OldValue { get; set; }        
        public Guid IdVoucher = Guid.Empty;
        public Guid IdCompany = Guid.Empty;
        public Guid BankTransactionId { get; set; }        
        public string VoucherType { get; set; }
        bool checkSender = false;
        TextBox txtBalance = new TextBox();
        public frmBankVocher()
        {
            InitializeComponent();
        }

        private void frmBankPaymentVoucher_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
            {
                this.Text = "Bank Payment Voucher";
            }
            else if (VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
            {
                this.Text = "Bank Receipt Voucher";
            }
            FillData();
            CreateAndInitializeFooterRow();
        }
        private void FillData()
        {
            var manager = new VoucherBLL();
            VEditBox.Text = manager.GetMaxVoucherNumber(VoucherType,Operations.IdCompany);
        }
        private void CreateAndInitializeFooterRow()
        {
            txtBalance.Enabled = false;
            txtBalance.TextAlign = HorizontalAlignment.Center;

            int hostCellLocation = DgvBankVoucher.GetCellDisplayRectangle(5, -1, true).X;
            txtBalance.Width = DgvBankVoucher.Columns[5].Width;
            txtBalance.Location = new Point(hostCellLocation, DgvBankVoucher.Height - txtBalance.Height);
            DgvBankVoucher.Controls.Add(txtBalance);
            txtBalance.BringToFront();

        }
        private bool ValidateRows()
        {
            bool IsTrue = true;
            if (DgvBankVoucher.Rows.Count > 1)
            {
                for (int i = 0; i < DgvBankVoucher.Rows.Count - 1; i++)
                {
                    if (DgvBankVoucher.Rows[i].Cells["colAccount"].Value == null)
                    {
                        IsTrue = false;
                    }
                    else if (DgvBankVoucher.Rows[i].Cells["colAmount"].Value == null)
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
            DgvBankVoucher.Rows.Clear();
            txtAccountName.Text = string.Empty;
            txtChequeNo.Text = string.Empty;
            txtBalance.Text = string.Empty;
            BankTransactionId = Guid.Empty;
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
            List<VoucherDetailEL> oelVoucherDetailCollection = new List<VoucherDetailEL>();
            EntityoperationInfo infoResult = new EntityoperationInfo();
            if (ValidateRows())
            {
                if (ValidateControls())
                {
                    /// Add Voucher...
                    VouchersEL oelVoucher = new VouchersEL();
                    if (IdVoucher == Guid.Empty)
                    {
                        oelVoucher.IdVoucher = Guid.NewGuid();
                    }
                    else
                    {
                        oelVoucher.IdVoucher = IdVoucher;
                    }
                    oelVoucher.IdCompany = Operations.IdCompany;
                    oelVoucher.VoucherNo = Convert.ToInt32(VEditBox.Text);
                    oelVoucher.IdUser = Operations.UserID;
                    oelVoucher.Date = VDate.Value;
                    oelVoucher.AccountNo = Validation.GetSafeLong(BEditBox.Text);
                    oelVoucher.VoucherType = VoucherType;
                    oelVoucher.Description = txtDescription.Text;
                    oelVoucher.ChequeNo = txtChequeNo.Text;
                    //oelVoucher.Amount = Convert.ToDecimal(txtAmount.Text == "" ? "0" : txtAmount.Text);
                    oelVoucher.Amount = Convert.ToDecimal(txtBalance.Text == "" ? "0" : txtBalance.Text);
                    if (chkPosted.Checked)
                    {
                        oelVoucher.Posted = true;
                    }
                    else
                    {
                        oelVoucher.Posted = false;
                    }
                    /// Add Suppliers ...
                    for (int i = 0; i < DgvBankVoucher.Rows.Count - 1; i++)
                    {
                        TransactionsEL oelTransaction = new TransactionsEL();
                        if (DgvBankVoucher.Rows[i].Cells["ColTransaction"].Value != null)
                        {
                            oelTransaction.TransactionID = new Guid(DgvBankVoucher.Rows[i].Cells["ColTransaction"].Value.ToString());
                            oelTransaction.IsNew = false;
                        }
                        else
                        {
                            oelTransaction.TransactionID = Guid.NewGuid();
                            oelTransaction.IsNew = true;
                        }
                        oelTransaction.IdCompany = Operations.IdCompany;
                        oelTransaction.AccountNo = Validation.GetSafeLong(DgvBankVoucher.Rows[i].Cells["colAccount"].Value);
                        oelTransaction.Date = VDate.Value;
                        oelTransaction.VoucherNo = Convert.ToInt32(VEditBox.Text);
                        oelTransaction.VoucherType = VoucherType;
                        if (DgvBankVoucher.Rows[i].Cells["colDescription"].Value == null)
                        {
                            oelTransaction.Description = "";
                        }
                        else
                        {
                            oelTransaction.Description = DgvBankVoucher.Rows[i].Cells["colDescription"].Value.ToString();
                        }
                        // oelTransaction.Amount = Convert.ToDecimal(DgvPaymentVoucher.Rows[i].Cells["colAmount"].Value);                       
                        if (VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
                        {
                            oelTransaction.Credit = Convert.ToDecimal(DgvBankVoucher.Rows[i].Cells["colAmount"].Value);
                            oelTransaction.Debit = 0;
                        
                        }
                        else if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
                        {
                            oelTransaction.Credit = 0;
                            oelTransaction.Debit = Convert.ToDecimal(DgvBankVoucher.Rows[i].Cells["colAmount"].Value);
                        
                        }
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

                    for (int j = 0; j < DgvBankVoucher.Rows.Count - 1; j++)
                    {
                        //PaymentDetailEL oelPaymentDetail = new PaymentDetailEL();
                        VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                        oelVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
                        if (DgvBankVoucher.Rows[j].Cells["ColIdDetailVoucher"].Value != null)
                        {
                            oelVoucherDetail.IdVoucherDetail = new Guid(DgvBankVoucher.Rows[j].Cells["ColIdDetailVoucher"].Value.ToString());
                            oelVoucherDetail.IsNew = false;
                        }
                        else
                        {
                            oelVoucherDetail.IdVoucherDetail = Guid.NewGuid();
                            oelVoucherDetail.IsNew = true;
                        }
                        oelVoucherDetail.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                        if (DgvBankVoucher.Rows[j].Cells["colDescription"].Value == null)
                        {
                            oelVoucherDetail.Description = "N/A";
                        }
                        else
                        {
                            oelVoucherDetail.Description = DgvBankVoucher.Rows[j].Cells["colDescription"].Value.ToString();
                        }
                        oelVoucherDetail.JVType = string.Empty;
                        oelVoucherDetail.AccountNo = Validation.GetSafeLong(DgvBankVoucher.Rows[j].Cells["colAccount"].Value);
                        oelVoucherDetail.Amount = Validation.GetSafeDecimal(DgvBankVoucher.Rows[j].Cells["colAmount"].Value);
                        oelVoucherDetailCollection.Add(oelVoucherDetail);
                    }

                    /// Add Bank Account OR Bank...
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
                    oeTransaction.IdCompany = Operations.IdCompany;
                    oeTransaction.AccountNo = Validation.GetSafeLong(BEditBox.Text);
                    oeTransaction.Date = VDate.Value;
                    oeTransaction.VoucherNo = Convert.ToInt32(VEditBox.Text);
                    oeTransaction.VoucherType = VoucherType;
                    oeTransaction.Description = txtDescription.Text;
                    //oeTransaction.Amount = -Convert.ToDecimal(txtTotalAmount.Text);
                    if (VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
                    {
                        //oeTransaction.Debit = Convert.ToDecimal(txtAmount.Text == "" ? "0" : txtAmount.Text);
                        oeTransaction.Debit = Convert.ToDecimal(txtBalance.Text == "" ? "0" : txtBalance.Text);
                        oeTransaction.Credit = 0;

                    }
                    else if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
                    {
                        oeTransaction.Debit = 0;
                        oeTransaction.Credit = Convert.ToDecimal(txtBalance.Text == "" ? "0" : txtBalance.Text);

                    }
                    if (chkPosted.Checked)
                    {
                        oeTransaction.Posted = true;
                    }
                    else
                    {
                        oeTransaction.Posted = false;
                    }
                    oelTransactionCollection.Add(oeTransaction);
                    if (IdVoucher == Guid.Empty)
                    {
                        var manager = new VoucherBLL();
                        infoResult = manager.InsertVouchersHead(oelVoucher, oelVoucherDetailCollection, oelTransactionCollection);

                        if (infoResult.IsSuccess)
                        {
                            //manager.UpdateStockitems(oelTransactionCollection, "Add");
                            lblStatuMessage.Text = "Bank Transaction Successful...";
                            ClearControl();
                            FillData();
                        }
                    }
                    else
                    {
                        var manager = new VoucherBLL();
                        infoResult = manager.UpdateVouchersHead(oelVoucher, oelVoucherDetailCollection, oelTransactionCollection);

                        if (infoResult.IsSuccess)
                        {
                            // manager.UpdateStockitems(oelTransactionCollection, "Add");
                            lblStatuMessage.Text = "Bank Transaction Successful...";
                            ClearControl();
                            FillData();
                        }
                    }
                }

                else
                {
                    lblStatuMessage.Text = "Bank Account Missing...";
                }
            }
            else
            {
                lblStatuMessage.Text = "Incomplete Entry...";
                lblStatuMessage.ForeColor = Color.Red;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelItemTransactionCollection = new List<TransactionsEL>();
            if (VEditBox.Text != string.Empty)
            {
                var manager = new BankPaymentVoucherBLL();
                //if (VoucherId > 0)
                //{
                //    if (manager.DeleteBankPayment(Convert.ToInt64(VEditBox.Text), "BankPaymentVoucher"))
                //    {
                //        lblStatuMessage.Text = "Voucher Deleted Successfully";
                //        ClearControl();
                //    }
                //}
                //else
                //{

                //}
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            DgvBankVoucher.EndEdit();
            DgvBankVoucher.CurrentCell = null;
            this.Close();
        }
        private void DgvBankVoucher_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvBankVoucher.Columns[e.ColumnIndex].Name == "colAmount")
            {
                if (DgvBankVoucher.Columns[e.ColumnIndex].Name == "colAmount")
                {
                    for (int i = 0; i < DgvBankVoucher.Rows.Count - 1; i++)
                    {
                        OldValue += Convert.ToDecimal(DgvBankVoucher.Rows[i].Cells["colAmount"].Value);
                    }
                    //txtAmount.Text = OldValue.ToString();
                    txtBalance.Text = OldValue.ToString();
                    OldValue = 0;
                }
            }
        }
        private void VEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmfindVouchers = new frmFindVouchers();
            frmfindVouchers.ExecuteFindVouchersEvent += new frmFindVouchers.VouchersDelegate(frmfindVouchers_ExecuteFindVouchersEvent);
            frmfindVouchers.ShowDialog(this);
        }

        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {
            VEditBox.Text = oelVoucher.VoucherNo.ToString();
            BEditBox.Text = Validation.GetSafeString(oelVoucher.AccountNo);
            VDate.Value = oelVoucher.Date;
        }
        private void VEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    FillVoucher();
                }
            }
            else
                e.Handled = true;
        }
        private void FillVoucher()
        {
            var Manager = new VoucherBLL();
            if (VEditBox.Text != string.Empty)
            {
                List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(VEditBox.Text));
                if (list.Count > 0)
                {
                    VDate.Value = list[0].Date;
                    IdVoucher = list[0].IdVoucher;
                    BEditBox.Text = list[0].AccountNo.ToString();
                    txtAccountName.Text = list[0].AccountName;
                    if (list[0].Posted)
                    {
                        btnSave.Enabled = false;
                        btnDelete.Enabled = false;
                        chkPosted.Checked = list[0].Posted;
                        chkPosted.Enabled = false;
                        lblStatuMessage.Text = "Posted Voucher ...";
                        lblStatuMessage.ForeColor = Color.Red;
                    }
                    else
                    {
                        btnSave.Enabled = true;
                        btnDelete.Enabled = true;
                        chkPosted.Checked = false;
                        chkPosted.Enabled = true;
                    }

                    var TManager = new TransactionBLL();
                    BankTransactionId = TManager.GetHeadAccountTransactionId(Validation.GetSafeLong(VEditBox.Text), VoucherType, list[0].AccountNo, Operations.IdCompany)[0].TransactionID;

                    var manager = new VoucherBLL();
                    List<TransactionsEL> List = manager.GetTransactionsByVoucherAndType(Operations.IdCompany, IdVoucher, Validation.GetSafeLong(VEditBox.Text), VoucherType);
                    FillTransactions(List);
                }
            }
        }
        private void FillTransactions(List<TransactionsEL> List)
        {
            if (DgvBankVoucher.Rows.Count > 0)
            {
                DgvBankVoucher.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {
                //TransactionsEL oeTransaction = List.Find(x => x.AccountNo == Validation.GetSafeLong(BEditBox.Text));
                //if (oeTransaction != null)
                //{
                //    //txtAmount.Text = oeTransaction.Credit.ToString();
                //    if (VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
                //    {
                //        txtBalance.Text = oeTransaction.Debit.ToString();
                //    }
                //    else if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
                //    {
                //        txtBalance.Text = oeTransaction.Credit.ToString();
                //    }
                    
                //    BankTransactionId = oeTransaction.TransactionID;
                //}
                //List.RemoveAt(List.FindIndex(x => x.AccountNo == Validation.GetSafeLong(BEditBox.Text)));
                for (int i = 0; i < List.Count; i++)
                {
                    DgvBankVoucher.Rows.Add();
                    DgvBankVoucher.Rows[i].Cells[0].Value = List[i].TransactionID;
                    DgvBankVoucher.Rows[i].Cells[1].Value = List[i].IdDetail;
                    DgvBankVoucher.Rows[i].Cells[2].Value = List[i].AccountNo;
                    DgvBankVoucher.Rows[i].Cells[3].Value = List[i].AccountName;
                    DgvBankVoucher.Rows[i].Cells[4].Value = List[i].Description;
                    if (VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
                    {
                        DgvBankVoucher.Rows[i].Cells[5].Value = List[i].Credit;
                    }
                    else if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
                    {
                        DgvBankVoucher.Rows[i].Cells[5].Value = List[i].Debit;
                    }                   
                }

                if (VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
                {
                    txtBalance.Text = List.Sum(x => x.Credit).ToString();
                }
                else if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
                {
                    txtBalance.Text = List.Sum(x => x.Debit).ToString();
                }      
                // DgvStockReceipt.DataSource = List;
                //

            }
        }
        private void BEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }

        void frmAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            if (checkSender)
            {
                //var manager = new ChartsOfAccountsBLL();
                var manager = new AccountsBLL();
                List<AccountsEL> list = manager.GetAccount(oelAccount.AccountNo, Validation.GetSafeGuid(oelAccount.IdCompany));
                if (list.Count > 0)
                {
                    //if (list[0].HeaderAccount == 2 || list[0].HeaderAccount == 5)
                    //{
                    for (int i = 0; i < DgvBankVoucher.Rows.Count - 1; i++)
                    {
                        if (DgvBankVoucher.Rows[i].Cells["colAccount"].Value != null)
                        {
                            if (oelAccount.AccountNo == Validation.GetSafeString(DgvBankVoucher.Rows[i].Cells["colAccount"].Value))
                            {
                                lblStatuMessage.Text = "Account Already exists";
                                return;
                            }
                        }
                    }
                    //}
                    //else
                    //{
                    //   lblStatuMessage.Text = "Not Valid Account For Payment";
                    //  DgvPaymentVoucher.CurrentCell.Value = "";
                    // return;
                    //}
                }

                DgvBankVoucher.CurrentCell.Value = oelAccount.AccountNo;
                DgvBankVoucher.CurrentRow.Cells["colAccountName"].Value = oelAccount.AccountName;
                checkSender = false;
                lblStatuMessage.Text = "";
            }
            else
            {
                BEditBox.Text = Validation.GetSafeString(oelAccount.AccountNo);
                txtAccountName.Text = oelAccount.AccountName;
            }
        }
        private void DgvBankVoucher_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (DgvBankVoucher.CurrentCellAddress.X == 2)
                {
                    checkSender = true;
                    frmAccount = new frmFindAccounts();
                    frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                    frmAccount.ShowDialog(this);
                }
            }
        }
        private void frmBankPaymentVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                FillData();
                ClearControl();
                if (DgvBankVoucher.Rows.Count > 0)
                {
                    DgvBankVoucher.Rows.Clear();
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
