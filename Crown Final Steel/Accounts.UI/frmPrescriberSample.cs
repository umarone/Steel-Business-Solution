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
    public partial class frmPrescriberSample : Form
    {
        frmFindAccounts frmAccount;
        frmStockAccounts frmstockAccounts;
        frmVouchers frmVoucher;
        public string VoucherType { get; set; }
        string CommandType = "";
        public Guid PrescriberTransactionId { get; set; }
        bool IsNewSample;
        public Int64 SampleVoucherNo { get; set; }
        public decimal OldValue { get; set; }
        public frmPrescriberSample()
        {
            InitializeComponent();
        }

        private void frmPrescriberSample_Load(object sender, EventArgs e)
        {
            FillData();
        }
        private void FillData()
        {
            var manager = new VoucherBLL();
            VEditBox.Text = manager.GetMaxVoucherNumber("PrescriberSampleVoucher");
        }
        private bool ValidateRows()
        {
            bool Status = true;
            if (DgvPrescriberSample.Rows.Count > 1)
            {
                for (int i = 0; i < DgvPrescriberSample.Rows.Count - 1; i++)
                {
                    if (DgvPrescriberSample.Rows[i].Cells["colItem"].Value == null)
                    {
                        Status = false;
                    }
                    else if (DgvPrescriberSample.Rows[i].Cells["colQty"].Value == null)
                    {
                        Status = false;
                    }                    
                }
            }
            else if (DgvPrescriberSample.Rows.Count == 1)
            {
                Status = false;
            }
            return Status;
        }
        private bool ValidateControls()
        {
            if (PrescriberEditBox.Text == string.Empty)
            {
                lblStatuMessage.Text = "Customer Missing...";
                return false;
            }
            return true;
        }
      
        private void ClearControl()
        {
            DgvPrescriberSample.Rows.Clear();
            //txtDescription.Text = string.Empty;
          
            txtDescription.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtNTN.Text = string.Empty;
            txtAddress.Text = string.Empty;
            //txtCashReceipt.Text = string.Empty;
            PrescriberTransactionId = Guid.Empty;
            IsNewSample = true;
            PrescriberEditBox.Text = string.Empty;
            txtPrescriberName.Text = "";
            if (chkPost.Checked)
            {
                chkPost.Checked = false;
                chkPost.Enabled = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void PrecriberEditBox_ClickButton(object sender, EventArgs e)
        {
            CommandType = "Persons";
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog(this);
        }
        void frmAccount_ExecuteFindAccountEvent(EL.ChartsOfAccountsEL oelChartOfAccount)
        {
            if (CommandType == "Persons")
            {
                var manager = new PersonsBLL();                
                List<PersonsEL> list = manager.VerifyAccount("Persons", oelChartOfAccount.AccountNo);
                if (list.Count > 0)
                {
                    PrescriberEditBox.Text = oelChartOfAccount.AccountNo;
                    txtPrescriberName.Text = list[0].PersonName;
                    txtContact.Text = list[0].Contact;
                    txtNTN.Text = list[0].NTN;
                    txtAddress.Text = list[0].Address;
                    
                }
                else
                {
                    MessageBox.Show("Select Doctor/Prescriber");
                }
            }
        }
        private void VEditBox_ClickButton(object sender, EventArgs e)
        {
            frmVoucher = new frmVouchers();
            frmVoucher.VoucherType = "PrescriberSampleVoucher";
            frmVoucher.ExecuteVoucherEvent += new frmVouchers.VouchersDelegate(frmVoucher_ExecuteVoucherEvent);
            frmVoucher.ShowDialog(this);
        }
        void frmVoucher_ExecuteVoucherEvent(VouchersEL oelVoucher)
        {
            var manager = new PrescriberSampleDetailVoucherBLL();
            if (oelVoucher != null)
            {
                //InvoiceNo = oelVoucher.VoucherNo;
                SampleVoucherNo = oelVoucher.VoucherNo;
                VEditBox.Text = oelVoucher.VoucherNo.ToString();
                IsNewSample = false;
                VDate.Value = oelVoucher.Date;
                if (oelVoucher.Posted)
                {
                    btnSave.Enabled = false;
                    btnDelete.Enabled = false;
                    chkPost.Checked = oelVoucher.Posted;
                    chkPost.Enabled = false;
                    lblStatuMessage.Text = "Posted Voucher ...";
                    lblStatuMessage.ForeColor = Color.Red;
                }
                List<PrescriberSampleDetailEL> listPrescriber = manager.GetSamplePrescriber(SampleVoucherNo, oelVoucher.AccountNo);
                if (listPrescriber.Count > 0)
                {
                    PrescriberEditBox.Text = listPrescriber[0].AccountNo;
                    PrescriberTransactionId = listPrescriber[0].IdPrescriberTransaction;
                }
                var PrescriberManager = new PersonsBLL();
                List<PersonsEL> list = PrescriberManager.VerifyAccount("Persons", oelVoucher.AccountNo);
                if (list.Count > 0)
                {
                    txtPrescriberName.Text = list[0].PersonName;
                    txtContact.Text = list[0].Contact;
                    txtNTN.Text = list[0].NTN;
                    txtAddress.Text = list[0].Address;
                    //lblStatuMessage.Text = "";
                }
                List<PrescriberSampleDetailEL> SampleList = manager.GetPrescriberSampleDetailWithSampleNumber(SampleVoucherNo);
                if (SampleList.Count > 0)
                {
                    //txtNetSale.Text = SalesList[0].NetSaleAmount.ToString();
                    FillPrescriberSampleTransaction(SampleList, listPrescriber[0].TotalAmount);
                }
            }
        }
        private void FillPrescriberSampleTransaction(List<PrescriberSampleDetailEL> Samplelist, decimal Amount)
        {
            var manager = new ItemsBLL();

            if (DgvPrescriberSample.Rows.Count > 0)
            {
                DgvPrescriberSample.Rows.Clear();
            }
            for (int i = 0; i < Samplelist.Count; i++)
            {
                DgvPrescriberSample.Rows.Add();
                DgvPrescriberSample.Rows[i].Cells[0].Value = Samplelist[i].IdTransaction;
                DgvPrescriberSample.Rows[i].Cells[1].Value = Samplelist[i].IdProductSample;
                DgvPrescriberSample.Rows[i].Cells[2].Value = Samplelist[i].ItemNo;
                DgvPrescriberSample.Rows[i].Cells[3].Value = manager.GetItemByAccount(Samplelist[i].ItemNo).ItemName;
                DgvPrescriberSample.Rows[i].Cells[4].Value = Samplelist[i].PackingSize;
                DgvPrescriberSample.Rows[i].Cells[5].Value = Samplelist[i].BatchNo;
                DgvPrescriberSample.Rows[i].Cells[6].Value = Samplelist[i].UnitPrice;
                DgvPrescriberSample.Rows[i].Cells[7].Value = Samplelist[i].Units;
                DgvPrescriberSample.Rows[i].Cells[8].Value = Samplelist[i].Units * Convert.ToDecimal(DgvPrescriberSample.Rows[i].Cells[6].Value);
    
                //if (Salelist[0].Discount > 0)
                //{
                //    //DgvSaleInvoice.Rows[i].Cells[7].Value = Convert.ToDecimal(DgvSaleInvoice.CurrentRow.Cells["colAmount"].Value) - (Convert.ToDecimal(DgvSaleInvoice.CurrentRow.Cells["colAmount"].Value) * Convert.ToDecimal(DgvSaleInvoice.Rows[i].Cells[6].Value) / 100);
                //    DgvSaleInvoice.Rows[i].Cells[8].Value = Salelist[i].Amount;
                //}
                //else
                //{
                //    DgvSaleInvoice.Rows[i].Cells[8].Value = DgvSaleInvoice.Rows[i].Cells[6].Value; 
                //}
                //DgvSaleInvoice.Rows[i].Cells[9].Value = Salelist[i].Description;
                ////DgvSaleInvoice.Rows[i].Cells[3].Value = List[i].
            }
            txtTotalAmount.Text = Amount.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            List<PrescriberSampleDetailEL> oelPrescriberSampleCollection = new List<PrescriberSampleDetailEL>();
            //List<StockReceiptEL> oelStockReceiptCollection = new List<StockReceiptEL>();
            if (ValidateRows())
            {
                if (ValidateControls())
                {
                    /// Add Voucher...
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Convert.ToInt32(VEditBox.Text);
                    oelVoucher.IdUser = Operations.UserID;
                    oelVoucher.Date = VDate.Value;
                    oelVoucher.AccountNo = PrescriberEditBox.Text;
                    oelVoucher.Description = txtDescription.Text;
                    oelVoucher.Amount = 0;
                    oelVoucher.TotalAmount = Validation.GetSafeDecimal(txtTotalAmount.Text);
                    oelVoucher.Posted = chkPost.Checked;


                    /// Add Items In Transactions

                    for (int i = 0; i < DgvPrescriberSample.Rows.Count - 1; i++)
                    {
                        TransactionsEL oelTransaction = new TransactionsEL();
                        if (DgvPrescriberSample.Rows[i].Cells["ColTransaction"].Value != null)
                        {
                            oelTransaction.TransactionID = Validation.GetSafeGuid(DgvPrescriberSample.Rows[i].Cells["ColTransaction"].Value);
                            oelTransaction.IsNew = false;
                        }
                        else
                        {
                            oelTransaction.TransactionID = Guid.NewGuid();
                            oelTransaction.IsNew = true;
                        }
                        oelTransaction.AccountNo = Validation.GetSafeString(DgvPrescriberSample.Rows[i].Cells["colItem"].Value);
                        oelTransaction.Date = VDate.Value;
                        oelTransaction.Seq = i + 1;
                        oelTransaction.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                        oelTransaction.VoucherType = "PrescriberSampleVoucher";
                       
                        oelTransaction.Qty = Validation.GetSafeInteger(DgvPrescriberSample.Rows[i].Cells["colQty"].Value);
                        oelTransaction.Debit = 0;
                        oelTransaction.Credit = Validation.GetSafeInteger(DgvPrescriberSample.Rows[i].Cells["colAmount"].Value);
                        oelTransaction.Amount = Validation.GetSafeDecimal(DgvPrescriberSample.Rows[i].Cells["colAmount"].Value);
                        oelTransaction.Posted = chkPost.Checked;
                        oelTransactionCollection.Add(oelTransaction);
                    }

                    /// Add Items in SampleDetail 
                    for (int j = 0; j < DgvPrescriberSample.Rows.Count - 1; j++)
                    {
                        PrescriberSampleDetailEL oelPrescriberSampleDetail = new PrescriberSampleDetailEL();

                        if (DgvPrescriberSample.Rows[j].Cells["colSampleDetailId"].Value != null)
                        {
                            oelPrescriberSampleDetail.IdProductSample = Validation.GetSafeGuid(DgvPrescriberSample.Rows[j].Cells["colSampleDetailId"].Value);
                            oelPrescriberSampleDetail.IsNew = false;
                        }
                        else
                        {
                            oelPrescriberSampleDetail.IdProductSample = Guid.NewGuid();
                            oelPrescriberSampleDetail.IsNew = true;
                        }
                        oelPrescriberSampleDetail.Seq = j + 1;
                        
                        oelPrescriberSampleDetail.ItemNo = DgvPrescriberSample.Rows[j].Cells["colItem"].Value.ToString();
                        oelPrescriberSampleDetail.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                        
                        oelPrescriberSampleDetail.Units = Validation.GetSafeInteger(DgvPrescriberSample.Rows[j].Cells["colQty"].Value);
                        
                        oelPrescriberSampleDetail.Amount = Validation.GetSafeDecimal(DgvPrescriberSample.Rows[j].Cells["colAmount"].Value);
                        
                        oelPrescriberSampleDetail.UnitPrice = Validation.GetSafeDecimal(DgvPrescriberSample.Rows[j].Cells["colUnitPrice"].Value);

                        oelPrescriberSampleDetail.BatchNo = Validation.GetSafeString(DgvPrescriberSample.Rows[j].Cells["colItemBatchNo"].Value);
                        oelPrescriberSampleDetail.PackingSize = Validation.GetSafeString(DgvPrescriberSample.Rows[j].Cells["colItemPackingSize"].Value);
                        oelPrescriberSampleCollection.Add(oelPrescriberSampleDetail);
                    }


                    /// Add Prescriber...
                    TransactionsEL oeTransaction = new TransactionsEL();
                    if (PrescriberTransactionId != Guid.Empty)
                    {
                        oeTransaction.TransactionID = PrescriberTransactionId;
                        oeTransaction.IsNew = false;
                    }
                    else
                    {
                        oeTransaction.TransactionID = Guid.NewGuid();
                        oeTransaction.IsNew = true;
                    }
                    oeTransaction.AccountNo = PrescriberEditBox.Text;
                    oeTransaction.Date = VDate.Value;
                    oeTransaction.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                    oeTransaction.VoucherType = "PrescriberSampleVoucher";
                    oeTransaction.Description = txtDescription.Text;
                    //oeTransaction.Debit = Validation.GetSafeDecimal(txtNetSale.Text);
                    oeTransaction.Debit = 0;
                    oeTransaction.Credit = 0;

                    oeTransaction.Posted = chkPost.Checked;
                    oelTransactionCollection.Add(oeTransaction);           
                    if (PrescriberTransactionId == Guid.Empty)
                    {
                        var manager = new PrescriberSampleVoucherBLL();
                        if (manager.InsertPrescriberSample(oelVoucher, oelPrescriberSampleCollection, oelTransactionCollection) == true)
                        {
                            lblStatuMessage.Text = "Prescriber Transaction Successfull...";
                            ClearControl();
                            FillData();
                        }
                    }
                    else
                    {
                        var manager = new PrescriberSampleVoucherBLL();
                        if (manager.UpdatePrescriberSample(oelVoucher, oelPrescriberSampleCollection, oelTransactionCollection) == true)
                        {
                            lblStatuMessage.Text = "Prescriber Transaction Successfull...";
                            ClearControl();
                            FillData();
                        }
                    }
                }
                else
                {
                    lblStatuMessage.Text = "Customer Missing...";
                    lblStatuMessage.ForeColor = Color.Red;
                }
            }
            else
            {
                lblStatuMessage.Text = "InComplete Entry";
                lblStatuMessage.ForeColor = Color.Red;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new PrescriberSampleVoucherBLL();
            if (MessageBox.Show("Are You Sure To Delete...", "Deleting Sample", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (manager.CheckSample(Convert.ToInt32(VEditBox.Text)))
                {
                    if (manager.DeleteSample(Convert.ToInt64(VEditBox.Text)))
                    {
                        lblStatuMessage.Text = "Sample Deleted...";
                        FillData();
                        ClearControl();
                    }
                }
                else
                {
                    MessageBox.Show("Delete With Out Sample ?");
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frmPrescriberSample_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                FillData();
                ClearControl();
                if (DgvPrescriberSample.Rows.Count > 0)
                {
                    DgvPrescriberSample.Rows.Clear();
                }
            }
        }
        private void DgvPrescriberSample_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 7)
            {
                try
                {
                    var manager = new ItemsBLL();
                    Int64 TotalQuantity = manager.GetItemTotalQuantity(DgvPrescriberSample.Rows[e.RowIndex].Cells["colItem"].Value.ToString());
                    if (Convert.ToInt64(DgvPrescriberSample.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > TotalQuantity)
                    {
                        lblStatuMessage.Text = "Quantity Exceeds Stock Limit";
                        DgvPrescriberSample.CurrentCell.Selected = true;
                        DgvPrescriberSample.Rows[e.RowIndex].Cells["colQty"].Value = string.Empty;
                        return;
                    }
                    DgvPrescriberSample.CurrentRow.Cells["colAmount"].Value = Convert.ToDecimal(DgvPrescriberSample.CurrentRow.Cells["colUnitPrice"].Value) * Convert.ToInt64(DgvPrescriberSample.CurrentRow.Cells[e.ColumnIndex].Value);

                    for (int i = 0; i < DgvPrescriberSample.Rows.Count - 1; i++)
                    {
                        OldValue += Convert.ToDecimal(DgvPrescriberSample.Rows[i].Cells["colAmount"].Value);
                    }
                    txtTotalAmount.Text = OldValue.ToString();
                    OldValue = 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Quantity Not Available For Sample...");
                }
            }
        }
        private void DgvPrescriberSample_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                if (DgvPrescriberSample.CurrentCellAddress.X == 2)
                {
                    CommandType = "Items";
                    frmstockAccounts = new frmStockAccounts();
                    frmstockAccounts.ExecuteFindStockAccountEvent += new frmStockAccounts.FindStockAccountDelegate(frmstockAccounts_ExecuteFindStockAccountEvent);
                    frmstockAccounts.ShowDialog(this);
                }
            }
        }
        void frmstockAccounts_ExecuteFindStockAccountEvent(ItemsEL oelItems)
        {
            var manager = new ItemsBLL();
            if (manager.VerifyAccount("Items", oelItems.AccountNo).Count > 0)
            {
                for (int i = 0; i < DgvPrescriberSample.Rows.Count - 1; i++)
                {
                    if (DgvPrescriberSample.Rows[i].Cells["colItem"].Value != null)
                    {
                        if (oelItems.AccountNo == DgvPrescriberSample.Rows[i].Cells["colItem"].Value.ToString())
                        {
                            lblStatuMessage.Text = "Item Already exists";
                            return;
                        }
                    }
                }
                lblStatuMessage.Text = "";
                DgvPrescriberSample.CurrentCell.Value = oelItems.AccountNo;
                DgvPrescriberSample.CurrentRow.Cells["colItemName"].Value = oelItems.AccountName;
                DgvPrescriberSample.CurrentRow.Cells["colItemPackingSize"].Value = oelItems.PackingSize;
                DgvPrescriberSample.CurrentRow.Cells["colItemBatchNo"].Value = oelItems.ProductRegNo;
                DgvPrescriberSample.CurrentRow.Cells["colUnitPrice"].Value = manager.GetItemPriceByCode(oelItems.AccountNo).ToString();
                DgvPrescriberSample.CurrentRow.Cells["colQty"].Selected = true;
            }
            else
            {
                lblStatuMessage.Text = "Wrong Account For Sample";
            }
        }
    }
}
