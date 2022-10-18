using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.EL;
using Accounts.Common;
using Accounts.BLL;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmSamplesReturn : MetroForm
    {
        frmFindAccounts frmAccount;
        frmFindProducts frmfindProducts;
        frmFindVouchers frmfindVouchers;
        frmReports frmReport;
        public decimal OldValue { get; set; }
        public Int64 InvoiceNo { get; set; }
        public Int64? IdVoucher = 0;
        public Int64? CustomerTransactionId { get; set; }
        public Int64? SalesTransactionId { get; set; }
        bool IsNewInvoice;
        decimal CostOfGoodsSoldAmount = 0;
        public string VoucherType { get; set; }
        string CommandType = "";
        List<PurchaseDetailEL> ListToUpdateStock = null;
        List<PurchaseDetailEL> ListToCheck = null;
        decimal MRP = 0;
        public frmSamplesReturn()
        {
            InitializeComponent();
        }
        private void frmSamples_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.metrolSalesTab.SelectedIndex = 0;
            FillData();
            //FillNaturalAccounts();
            FillEmployees();
            CheckModulePermissions();
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
                if (PermissionsList[0].Printing == true)
                {
                    btnPrint.Enabled = true;
                }
                else
                {
                    btnPrint.Enabled = false;
                }
                if (PermissionsList[0].Posting == true)
                {
                    btnSave.Enabled = true;
                    chkPosted.Checked = true;
                    chkPosted.Enabled = false;
                }
                else
                {
                    btnSave.Enabled = false;
                    chkPosted.Checked = false;
                    chkPosted.Enabled = true;
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
        private void FillData()
        {
            var manager = new VoucherBLL();
            InvSampleBox.Text = manager.GetMaxVoucherNumber("SampleReturnVoucher", Operations.IdProject, Operations.BookNo);
        }
        //private void FillNaturalAccounts()
        //{
        //    var manager = new AccountsBLL();
        //    List<AccountsEL> list = manager.GetAccountsByType("Net SALES", Operations.IdCompany);
        //    if (list.Count > 0)
        //    {
        //        cbxEmployees.DataSource = list;
        //        list.Insert(0,new AccountsEL() { AccountNo = "0", AccountName= "" });

        //        cbxEmployees.DisplayMember = "AccountName";
        //        cbxEmployees.ValueMember = "AccountNo";


        //    }
        //}
        private void FillEmployees()
        {
            var manager = new AccountsBLL();
            List<AccountsEL> listAccounts = manager.GetEmployeesAccounts(Operations.IdCompany);

            listAccounts.Insert(0, new AccountsEL() { AccountName = "Select Employees", AccountNo = "0" });

            cbxEmployees.DataSource = listAccounts;
            cbxEmployees.DisplayMember = "AccountName";
            cbxEmployees.ValueMember = "AccountNo";
        }
        private void CustEditBox_ButtonClick(object sender, EventArgs e)
        {
            CommandType = "Persons";
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }

        private void EmpEditCode_ButtonClick(object sender, EventArgs e)
        {
            CommandType = "Employees";
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }
        void frmAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            if (CommandType == "Persons")
            {
                var manager = new PersonsBLL();
                //List<PersonsEL> list = manager.VerifyAccount("Customers/Suppliers", oelChartOfAccount.AccountNo);
                List<PersonsEL> list = manager.VerifyAccount(Operations.IdCompany, "Persons", oelAccount.AccountNo);
                if (list.Count > 0)
                {
                    CustEditBox.Text = oelAccount.AccountNo.ToString();
                    txtCustomerName.Text = list[0].PersonName;
                    txtContact.Text = list[0].Contact;
                    txtNTN.Text = list[0].NTN;
                    txtAddress.Text = list[0].Address;
                    lblStatuMessage.Text = "";
                }
                else
                {
                    lblStatuMessage.Text = "Please Select Customer";
                }
            }
            else if (CommandType == "Employees")
            {
                var manager = new PersonsBLL();
                //List<PersonsEL> list = manager.VerifyAccount("Customers/Suppliers", oelChartOfAccount.AccountNo);
                List<PersonsEL> list = manager.VerifyAccount(Operations.IdCompany, "Persons", oelAccount.AccountNo);
                if (list.Count > 0)
                {
                    //EmpEditCode.Text = oelAccount.AccountNo.ToString();
                    //txtEmployeeName.Text = list[0].PersonName;
                    //txtEmployeeContact.Text = list[0].Contact;
                    lblStatuMessage.Text = "";
                }
                else
                {
                    lblStatuMessage.Text = "Please Select Customer";
                }
            }
            else if (CommandType == "Prescriber")
            {
                var manager = new PersonsBLL();
                List<PersonsEL> list = manager.VerifyAccount(Operations.IdCompany, "Prescriber", oelAccount.AccountNo);
                if (list.Count > 0)
                {
                    DgvSample.CurrentRow.Cells["colPrescriberAccount"].Value = oelAccount.AccountNo;
                    DgvSample.CurrentRow.Cells["colPrescriberName"].Value = oelAccount.AccountName;
                    lblStatuMessage.Text = "";
                }
                else
                {
                    lblStatuMessage.Text = "Please Select Prescriber";
                }
            }
            else if (CommandType == "Sales")
            {
                SalesEditBox.Text = oelAccount.AccountNo.ToString();
                EmpEditCode.Text = oelAccount.AccountName;
            }
        }
        void frmfindProducts_ExecuteFindPorudctsEvent(object Sender, ItemsEL oelItems)
        {
            var manager = new ItemsBLL();
            List<ItemsEL> listpriceAndSize = manager.GetItemPriceAndSizeByCode(Validation.GetSafeLong(oelItems.AccountNo), Operations.IdCompany);
            if (manager.VerifyAccount(Operations.IdCompany, "Items", oelItems.AccountNo).Count > 0)
            {
                //for (int i = 0; i < DgvSaleInvoice.Rows.Count - 1; i++)
                //{
                //    if (DgvSaleInvoice.Rows[i].Cells["colItemNo"].Value != null)
                //    {
                //        if (oelItems.AccountNo == Validation.GetSafeLong(DgvSaleInvoice.Rows[i].Cells["colItemNo"].Value))
                //        {
                //            lblStatuMessage.Text = "Item Already exists";
                //            return;
                //        }
                //    }
                //}
                lblStatuMessage.Text = "";
                DgvSample.CurrentRow.Cells["colItemNo"].Value = oelItems.AccountNo;
                DgvSample.CurrentRow.Cells["colIdItem"].Value = oelItems.IdItem;
                DgvSample.CurrentRow.Cells["colItemName"].Value = oelItems.AccountName;
                DgvSample.CurrentRow.Cells["colPower"].Value = oelItems.Power;
                DgvSample.CurrentRow.Cells["colTemprature"].Value = oelItems.ColorTemperature;
                //DgvSaleInvoice.CurrentRow.Cells["colItemPackingSize"].Value = listpriceAndSize[0].PackingSize; ///oelItems.PackingSize;
                MRP = listpriceAndSize[0].MRP;
                //DgvSaleInvoice.CurrentRow.Cells["colUnitPrice"].Value = listpriceAndSize[0].UnitPrice; //manager.GetItemPriceByCode(oelItems.AccountNo, Operations.IdCompany).ToString();
                //DgvSaleInvoice.CurrentRow.Cells["colQty"].Selected = true;
                //SendKeys.Send("{TAB}");
            }
        }
        //void frmAccount_ExecuteFindAccountEvent(AccountsEL oelChartOfAccount)
        //{

        //    //else if (CommandType == "Cash")
        //    //{
        //    //    CashEditBox.Text = oelChartOfAccount.AccountNo;
        //    //}
        //    //else if (CommandType == "Sales")
        //    //{
        //    //    SalesEditBox.Text = oelChartOfAccount.AccountNo;
        //    //}
        //    //else if (CommandType == "CostOfGoodsSold")
        //    //{
        //    //    CostOfGoodSoldEditBox.Text = oelChartOfAccount.AccountNo;
        //    //}
        //}
        private void DgvSample_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                if (MRP != 0)
                {
                    DgvSample.CurrentRow.Cells["colUnitPrice"].Value = MRP;
                }
                else
                {
                    var manager = new ItemsBLL();
                    List<ItemsEL> listpriceAndSize = manager.GetItemPriceAndSizeByCode(Validation.GetSafeLong(DgvSample.CurrentRow.Cells["colItemNo"].Value), Operations.IdCompany);
                    MRP = listpriceAndSize[0].MRP;
                }
            }
            else if (e.ColumnIndex == 8)
            {
                //DgvSaleInvoice.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = DgvSaleInvoice.Rows[e.RowIndex].Cells["colAmount"].Value;
                DgvSample.EndEdit();
                //if (DgvSaleInvoice.Columns[e.ColumnIndex].Name == "colDiscountAmount")
                //{
                //    for (int i = 0; i < DgvSaleInvoice.Rows.Count - 1; i++)
                //    {
                //        OldValue += Convert.ToDecimal(DgvSaleInvoice.Rows[i].Cells["colDiscountAmount"].Value);
                //    }
                //    txtTotalAmount.Text = OldValue.ToString();                    
                //    OldValue = 0;
                //}
                for (int i = 0; i < DgvSample.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvSample.Rows[i].Cells["colAmount"].Value);
                }
                txtTotalAmount.Text = OldValue.ToString();
                OldValue = 0;
            }
        }
        private void DgvSample_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                try
                {
                    var manager = new ItemsBLL();
                    //Int64 TotalQuantity = manager.GetItemTotalQuantity(Validation.GetSafeGuid(DgvSaleInvoice.Rows[e.RowIndex].Cells["colIdItem"].Value), Operations.IdCompany);
                    Int64 TotalQuantity = manager.GetDateWiseItemTotalQuantity(Validation.GetSafeGuid(DgvSample.Rows[e.RowIndex].Cells["colIdItem"].Value), Validation.GetSafeString(DgvSample.Rows[e.RowIndex].Cells["colPackingSize"].Value), Validation.GetSafeString(DgvSample.Rows[e.RowIndex].Cells["colBatchNo"].Value), VDate.Value, Operations.IdCompany);
                    if (TotalQuantity < 0 || TotalQuantity == 0)
                    {
                        MessageBox.Show("Quantity Not Available for the Product '" + DgvSample.Rows[e.RowIndex].Cells["colItemName"].Value + "' for the Voucher No : '" + InvSampleBox.Text + "' Dated : " + VDate.Value.ToShortDateString());
                        DgvSample.Rows[e.RowIndex].Cells["colQty"].Value = string.Empty;
                        return;
                    }
                    else if (Validation.GetSafeLong(DgvSample.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) > TotalQuantity)
                    {
                        MessageBox.Show("Quantity Exceeds Stock Limit");
                        DgvSample.CurrentCell.Selected = true;
                        DgvSample.Rows[e.RowIndex].Cells["colQty"].Value = string.Empty;
                        return;
                    }
                    else
                    {
                        DgvSample.CurrentRow.Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvSample.CurrentRow.Cells["colUnitPrice"].Value) * Validation.GetSafeLong(DgvSample.CurrentRow.Cells[e.ColumnIndex].Value);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem Occured While Getting Stock Quantity Information...");
                }
            }
            else if (e.ColumnIndex == 10)
            {
                DgvSample.CurrentRow.Cells["colDiscountAmount"].Value = Validation.GetSafeDecimal(DgvSample.CurrentRow.Cells["colAmount"].Value) - (Validation.GetSafeDecimal(DgvSample.CurrentRow.Cells["colAmount"].Value) * Validation.GetSafeDecimal(DgvSample.Rows[e.RowIndex].Cells["colDiscount"].Value) / 100);
            }
            //else if (e.ColumnIndex == 6)
            //{
            //    if (DgvSaleInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //    {
            //        if (Convert.ToDecimal(DgvSaleInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) != 0)
            //        {
            //            //DgvSaleInvoice.CurrentRow.Cells["colDiscountAmount"].Value = Convert.ToDecimal(DgvSaleInvoice.CurrentRow.Cells["colAmount"].Value) - (Convert.ToDecimal(DgvSaleInvoice.CurrentRow.Cells["colAmount"].Value) * Convert.ToDecimal(DgvSaleInvoice.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) / 100); 
            //        }
            //        else
            //        {
            //            //DgvSaleInvoice.CurrentRow.Cells["colDiscountAmount"].Value = DgvSaleInvoice.CurrentRow.Cells["colAmount"].Value;                    
            //        }
            //    }
            //    else
            //    {
            //        //DgvSaleInvoice.CurrentRow.Cells["colDiscountAmount"].Value = DgvSaleInvoice.CurrentRow.Cells["colAmount"].Value;   
            //    }
            //}            
        }
        private bool ValidateRows()
        {
            bool Status = true;
            if (DgvSample.Rows.Count > 1)
            {
                for (int i = 0; i < DgvSample.Rows.Count - 1; i++)
                {
                    if (DgvSample.Rows[i].Cells["colItemNo"].Value == null)
                    {
                        Status = false;
                    }
                    else if (DgvSample.Rows[i].Cells["colQty"].Value == null)
                    {
                        Status = false;
                    }
                }
            }
            else if (DgvSample.Rows.Count == 1)
            {
                Status = false;
            }
            return Status;
        }
        private bool ValidateControls()
        {
            if (CustEditBox.Text == string.Empty)
            {
                lblStatuMessage.Text = "Customer Missing...";
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            List<VoucherDetailEL> oelSampleCollection = new List<VoucherDetailEL>();
            //List<StockReceiptEL> oelStockReceiptCollection = new List<StockReceiptEL>();
            ListToUpdateStock = new List<PurchaseDetailEL>();
            ListToCheck = new List<PurchaseDetailEL>();
            if (ValidateRows())
            {
                if (ValidateControls())
                {
                    /// Add Voucher...
                    VouchersEL oelVoucher = new VouchersEL();
                    if (!IdVoucher.HasValue)
                    {
                        oelVoucher.IdVoucher = 0;
                    }
                    else
                    {
                        oelVoucher.IdVoucher = IdVoucher;
                    }
                    oelVoucher.IdCompany = Operations.IdCompany;
                    oelVoucher.VoucherNo = Convert.ToInt32(InvSampleBox.Text);
                    oelVoucher.IdUser = Operations.UserID;
                    oelVoucher.Date = VDate.Value;
                    oelVoucher.AccountNo = Validation.GetSafeString(CustEditBox.Text);
                    oelVoucher.SubAccountNo = Validation.GetSafeString(EmpEditCode.Text);
                    oelVoucher.Description = txtDescription.Text;
                    oelVoucher.MemoSaleNo = "";
                    oelVoucher.InWardGatePassNo = Validation.GetSafeString(txtInWardGatePass.Text);
                    oelVoucher.OutWardGatePassNo = Validation.GetSafeString(txtOutwardGatePassNo.Text);
                    oelVoucher.Amount = Validation.GetSafeDecimal(txtTotalAmount.Text);
                    //oelVoucher.Discount = Validation.GetSafeDecimal(txtDiscount.Text  == "" ? "0" : txtDiscount.Text);
                    //oelVoucher.TotalDiscount = Validation.GetSafeDecimal(txtTotalDiscount.Text == "" ? "0" : txtTotalDiscount.Text);
                    //oelVoucher.NetSaleAmount = Validation.GetSafeDecimal(txtNetSale.Text);
                    oelVoucher.Posted = chkPosted.Checked;

                    #region Add Items In Samples Detail
                    for (int j = 0; j < DgvSample.Rows.Count - 1; j++)
                    {
                        //SaleDetailEL oelSaleDetail = new SaleDetailEL();
                        VoucherDetailEL oelSampleDetail = new VoucherDetailEL();

                        if (DgvSample.Rows[j].Cells["colSampleDetailId"].Value != null)
                        {
                            oelSampleDetail.IdVoucherDetail = Validation.GetSafeLong(DgvSample.Rows[j].Cells["colSampleDetailId"].Value);
                            oelSampleDetail.IsNew = false;
                        }
                        else
                        {
                            oelSampleDetail.IdVoucherDetail = 0;
                            oelSampleDetail.IsNew = true;
                        }
                        oelSampleDetail.Seq = j + 1;

                        oelSampleDetail.IdVoucher = oelVoucher.IdVoucher;
                        oelSampleDetail.IdAccount = Validation.GetSafeLong(DgvSample.Rows[j].Cells["colIdItem"].Value);
                        oelSampleDetail.BatchNo = ""; //Validation.GetSafeString(DgvSaleInvoice.Rows[j].Cells["colBatchNo"].Value);
                        oelSampleDetail.Discription = ""; //Validation.GetSafeString(DgvSample.Rows[j].Cells["colNarration"].Value);
                        oelSampleDetail.ItemNo = DgvSample.Rows[j].Cells["colItemNo"].Value.ToString();
                        oelSampleDetail.VoucherNo = Validation.GetSafeLong(InvSampleBox.Text);
                        //if (DgvSaleInvoice.Rows[i].Cells["colRemarks"].Value == null)
                        //{
                        //    oelTransaction.Description = "";
                        //}
                        //else
                        //{
                        //    oelTransaction.Description = DgvSaleInvoice.Rows[i].Cells["colRemarks"].Value.ToString();
                        //}

                        oelSampleDetail.Units = Validation.GetSafeInteger(DgvSample.Rows[j].Cells["colQty"].Value);
                        // oelTransaction.Credit = Convert.ToDecimal(DgvSaleInvoice.Rows[i].Cells["colDiscountAmount"].Value);
                        //oelTransaction.Credit = CalculateCost(oelTransaction.AccountNo, DgvSaleInvoice.Rows[i]);
                        //oelSaleDetail.Amount = Convert.ToDecimal(DgvSaleInvoice.Rows[i].Cells["colDiscountAmount"].Value);
                        oelSampleDetail.Discount = 0;  //Validation.GetSafeInteger(DgvSaleInvoice.Rows[j].Cells["colDiscount"].Value);
                        oelSampleDetail.Amount = Validation.GetSafeDecimal(DgvSample.Rows[j].Cells["colAmount"].Value);
                        //oelSaleDetail.Amount = Validation.GetSafeDecimal(DgvSaleInvoice.Rows[j].Cells["colDiscountAmount"].Value);

                        oelSampleDetail.UnitPrice = Validation.GetSafeDecimal(DgvSample.Rows[j].Cells["colUnitPrice"].Value);
                        oelSampleDetail.PackingSize = ""; //Validation.GetSafeString(DgvSaleInvoice.Rows[j].Cells["colItemPackingSize"].Value);
                        oelSampleCollection.Add(oelSampleDetail);
                    }
                    #endregion
                    //#region Add Customer In Transactions

                    //TransactionsEL oelCustomerTransaction = new TransactionsEL();
                    //if (CustomerTransactionId != Guid.Empty)
                    //{
                    //    oelCustomerTransaction.TransactionID = CustomerTransactionId;
                    //    oelCustomerTransaction.IsNew = false;
                    //}
                    //else
                    //{
                    //    oelCustomerTransaction.TransactionID = Guid.NewGuid();
                    //    oelCustomerTransaction.IsNew = true;
                    //}
                    //oelCustomerTransaction.IdCompany = Operations.IdCompany;
                    //oelCustomerTransaction.AccountNo = Validation.GetSafeLong(CustEditBox.Text);
                    //oelCustomerTransaction.Date = VDate.Value;
                    //oelCustomerTransaction.VoucherNo = Validation.GetSafeLong(InvSampleBox.Text);
                    //oelCustomerTransaction.VoucherType = "SaleInvoiceVoucher";
                    //oelCustomerTransaction.Description = txtDescription.Text;
                    //oelCustomerTransaction.Debit = Validation.GetSafeDecimal(txtTotalAmount.Text);
                    //oelCustomerTransaction.Credit = 0;
                    ////if (txtCashReceipt.Text == string.Empty)
                    ////{
                    ////    oeTransaction.Amount = Convert.ToDecimal(txtTotalAmount.Text);
                    ////}
                    ////else
                    ////{
                    ////    oeTransaction.Amount = Convert.ToDecimal(txtTotalAmount.Text) - Convert.ToDecimal(txtCashReceipt.Text);
                    ////}
                    //oelCustomerTransaction.Posted = chkPosted.Checked;
                    //oelTransactionCollection.Add(oelCustomerTransaction);
                    //#endregion
                    //#region Add Sales Account In Transactions
                    ///// Add Sales Account...
                    //TransactionsEL oelSaleTransaction = new TransactionsEL();
                    //if (SalesTransactionId != Guid.Empty)
                    //{
                    //    oelSaleTransaction.TransactionID = SalesTransactionId;
                    //    oelSaleTransaction.IsNew = false;
                    //}
                    //else
                    //{
                    //    oelSaleTransaction.TransactionID = Guid.NewGuid();
                    //    oelSaleTransaction.IsNew = true;
                    //}
                    //oelSaleTransaction.IdCompany = Operations.IdCompany;
                    ////oelSaleTransaction.AccountNo = Validation.GetSafeLong(SalesEditBox.Text);
                    //oelSaleTransaction.AccountNo = Validation.GetSafeLong(EmpEditCode.Text);
                    //oelSaleTransaction.Date = VDate.Value;
                    //oelSaleTransaction.VoucherNo = Validation.GetSafeLong(InvSampleBox.Text);
                    //oelSaleTransaction.VoucherType = "SaleInvoiceVoucher";
                    //oelSaleTransaction.Description = txtDescription.Text;
                    //oelSaleTransaction.Debit = 0;
                    //oelSaleTransaction.Credit = Validation.GetSafeDecimal(txtTotalAmount.Text);;
                    ////if (txtCashReceipt.Text == string.Empty)
                    ////{
                    ////    oeTransaction.Amount = Convert.ToDecimal(txtTotalAmount.Text);
                    ////}
                    ////else
                    ////{
                    ////    oeTransaction.Amount = Convert.ToDecimal(txtTotalAmount.Text) - Convert.ToDecimal(txtCashReceipt.Text);
                    ////}
                    //oelSaleTransaction.Posted = chkPosted.Checked;
                    //oelTransactionCollection.Add(oelSaleTransaction);
                    //#endregion region

                    if (IdVoucher > 0)
                    {
                        var manager = new SamplesHeadBLL();
                        if (manager.InsertSamplesReturn(oelVoucher, oelSampleCollection) == true)
                        {
                            lblStatuMessage.Text = "Samples Transaction Successfully...";
                            ClearControl();
                            FillData();
                        }
                    }
                    else
                    {
                        var manager = new SamplesHeadBLL(); // SalesVoucherBLL();
                        if (manager.UpdateSamplesReturn(oelVoucher, oelSampleCollection) == true)
                        {
                            lblStatuMessage.Text = "Samples Transaction Successfully...";
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
        private void ClearControl()
        {
            DgvSample.Rows.Clear();
            IdVoucher = 0;
            //txtDescription.Text = string.Empty;
            InvoiceNo = 0;
            lblStatuMessage.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            txtInWardGatePass.Text = string.Empty;
            txtOutwardGatePassNo.Text = string.Empty;
            //txtDiscount.Text = string.Empty;
            //txtTotalDiscount.Text = string.Empty;
            //txtNetSale.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtNTN.Text = string.Empty;
            txtAddress.Text = string.Empty;
            EmpEditCode.Text = string.Empty;

            //txtCashReceipt.Text = string.Empty;
            CustomerTransactionId = 0;
            SalesTransactionId = 0;
            EmpEditCode.Text = string.Empty;
            SalesEditBox.Text = string.Empty;


            IsNewInvoice = true;
            CustEditBox.Text = string.Empty;
            ListToUpdateStock = null;
            ListToCheck = null;
            CostOfGoodsSoldAmount = 0;
            txtCustomerName.Text = "";
            if (chkPosted.Checked)
            {
                chkPosted.Checked = false;
                chkPosted.Enabled = true;
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private decimal CalculateCost(string ItemNo, DataGridViewRow Row)
        {
            Int64 qty = 0;
            Int64 remaining = 0;
            decimal Amount = 0;
            var manager = new ItemsBLL();
            // List<StockReceiptEL> list = manager.GetStockByItemNo(Row.Cells["colItem"].Value.ToString());
            List<PurchaseDetailEL> list = manager.GetStockByItemNo(Row.Cells["colItemNo"].Value.ToString());
            if (list.Count > 0)
            {
                foreach (var item in list)
                {
                    PurchaseDetailEL oelPurchaseDetail = new PurchaseDetailEL();
                    PurchaseDetailEL oelPurchaseCheck = new PurchaseDetailEL();

                    qty = item.RemainingUnits;
                    //if (Convert.ToInt64(Row.Cells["colQty"].Value) == item.Units)
                    if (Convert.ToInt64(Row.Cells["colQty"].Value) == item.RemainingUnits)
                    {
                        if (remaining > 0)
                        {
                            remaining += qty;
                            oelPurchaseDetail.IdPurchaseDetail = item.IdPurchaseDetail;
                            if (qty > remaining)
                            {
                                oelPurchaseDetail.RemainingUnits = qty - remaining;
                            }
                            else
                            {
                                oelPurchaseDetail.RemainingUnits = remaining - qty;
                                Amount = Amount + (qty - oelPurchaseDetail.RemainingUnits) * (item.Amount / oelPurchaseDetail.RemainingUnits);
                            }
                            oelPurchaseDetail.Amount = item.Amount;
                            //Amount = Amount + (item.RemainingUnits - oelPurchaseDetail.Units) * (item.Amount / item.RemainingUnits);
                            //Amount = Amount + (qty - oelPurchaseDetail.RemainingUnits) * (item.Units / oelPurchaseDetail.RemainingUnits);
                            ListToUpdateStock.Add(oelPurchaseDetail);
                            remaining = 0;
                            break;
                        }
                        else
                        {
                            oelPurchaseDetail.IdPurchaseDetail = item.IdPurchaseDetail;
                            //oelPurchaseDetail.RemainingUnits = qty - Convert.ToInt64(Row.Cells["colQty"].Value);
                            oelPurchaseDetail.RemainingUnits = qty - Convert.ToInt64(Row.Cells["colQty"].Value);
                            oelPurchaseCheck.RemainingUnits = item.RemainingUnits;
                            oelPurchaseDetail.Amount = item.Amount;
                            //Amount = Amount + (oelPurchaseDetail.RemainingUnits) * (item.Amount / item.RemainingUnits);
                            Amount = Amount + (qty * item.UnitPrice);
                            oelPurchaseCheck.Amount = Amount;
                            ListToCheck.Add(oelPurchaseCheck);
                            ListToUpdateStock.Add(oelPurchaseDetail);

                            break;
                        }
                    }
                    else if (item.RemainingUnits > Convert.ToInt64(Row.Cells["colQty"].Value))
                    {
                        if (remaining > 0)
                        {
                            remaining += qty;
                            oelPurchaseDetail.RemainingUnits = remaining - Convert.ToInt64(Row.Cells["colQty"].Value);
                            oelPurchaseDetail.IdPurchaseDetail = item.IdPurchaseDetail;
                            oelPurchaseDetail.Amount = item.Amount;
                            oelPurchaseCheck.RemainingUnits = item.RemainingUnits - oelPurchaseDetail.RemainingUnits;
                            Amount = Amount + (item.RemainingUnits - oelPurchaseDetail.RemainingUnits) * (item.Amount / item.Units);
                            oelPurchaseCheck.Amount = Amount;
                            ListToCheck.Add(oelPurchaseCheck);
                            ListToUpdateStock.Add(oelPurchaseDetail);
                            remaining = 0;
                            break;
                        }
                        else
                        {
                            oelPurchaseDetail.IdPurchaseDetail = item.IdPurchaseDetail;
                            //oelPurchaseDetail.RemainingUnits = qty - Convert.ToInt64(Row.Cells["colQty"].Value);
                            oelPurchaseDetail.RemainingUnits = qty - Convert.ToInt64(Row.Cells["colQty"].Value);
                            oelPurchaseDetail.Amount = item.Amount;
                            oelPurchaseCheck.RemainingUnits = item.RemainingUnits;
                            // Amount = Amount + (oelPurchaseDetail.RemainingUnits) * (item.Amount / item.RemainingUnits);
                            Amount = Amount + (Convert.ToInt64(Row.Cells["colQty"].Value)) * (item.Amount / item.Units);
                            oelPurchaseCheck.Amount = Amount;
                            ListToCheck.Add(oelPurchaseCheck);
                            ListToUpdateStock.Add(oelPurchaseDetail);
                            break;
                        }
                    }
                    else if (item.RemainingUnits < Convert.ToInt64(Row.Cells["colQty"].Value))
                    {
                        remaining += qty;
                        if (remaining < Convert.ToInt64(Row.Cells["colQty"].Value))
                        {
                            oelPurchaseDetail.RemainingUnits = item.RemainingUnits - qty;
                            Amount = Amount + (remaining) * (item.Amount / item.RemainingUnits);
                        }
                        else if (remaining == Convert.ToInt64(Row.Cells["colQty"].Value))
                        {
                            oelPurchaseDetail.RemainingUnits = item.RemainingUnits - qty;
                            //Amount = Amount + (Convert.ToInt64(Row.Cells["colQty"].Value)) * (item.Amount / item.RemainingUnits);
                            Amount = Amount + (qty * item.UnitPrice);
                        }
                        else if (remaining > Convert.ToInt64(Row.Cells["colQty"].Value))
                        {
                            oelPurchaseDetail.RemainingUnits = remaining - Convert.ToInt64(Row.Cells["colQty"].Value);
                            Amount = Amount + (Convert.ToInt64(Row.Cells["colQty"].Value) - qty) * (item.Amount / item.RemainingUnits);
                        }
                        oelPurchaseDetail.IdPurchaseDetail = item.IdPurchaseDetail;
                        oelPurchaseCheck.RemainingUnits = item.RemainingUnits;
                        oelPurchaseDetail.Amount = item.Amount;
                        // Amount = Amount + (oelPurchaseDetail.RemainingUnits) * (item.Amount / item.RemainingUnits);
                        //Amount = Amount +  (item.Amount / item.RemainingUnits);
                        oelPurchaseCheck.Amount = Amount;
                        ListToUpdateStock.Add(oelPurchaseDetail);
                        ListToCheck.Add(oelPurchaseCheck);
                        if (ListToCheck.Sum(x => x.RemainingUnits) == Convert.ToInt64(Row.Cells["colQty"].Value))
                        {
                            remaining = 0;
                            break;
                        }
                    }
                }
            }
            return Amount;
        }
        private void CashEditBox_ClickButton(object sender, EventArgs e)
        {
            CommandType = "Cash";
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }
        private void SalesEditBox_ButtonClick(object sender, EventArgs e)
        {
            CommandType = "Sales";
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }
        private void CostOfGoodSoldEditBox_ClickButton(object sender, EventArgs e)
        {
            CommandType = "CostOfGoodsSold";
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void InvSampleBox_ButtonClick(object sender, EventArgs e)
        {
            frmfindVouchers = new frmFindVouchers();
            frmfindVouchers.VoucherType = "SaleInvoiceVoucher";
            frmfindVouchers.ExecuteFindVouchersEvent += new frmFindVouchers.VouchersDelegate(frmfindVouchers_ExecuteFindVouchersEvent);
            frmfindVouchers.ShowDialog(this);
        }
        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {
            var manager = new SalesDetailBLL();
            if (oelVoucher != null)
            {
                InvoiceNo = oelVoucher.VoucherNo;
                InvSampleBox.Text = oelVoucher.VoucherNo.ToString();
                IdVoucher = oelVoucher.IdVoucher;

                IsNewInvoice = false;

                FillVoucher();
            }
        }
        private void InvSampleBox_KeyPress(object sender, KeyPressEventArgs e)
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
            var SalesManager = new SalesDetailBLL();
            var SamplesManager = new SampleDetailBLL();
            VoucherType = "SampleReturnVoucher";
            if (InvSampleBox.Text != string.Empty)
            {
                List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(InvSampleBox.Text));
                if (list.Count > 0)
                {
                    IdVoucher = list[0].IdVoucher;
                    VDate.Value = list[0].Date;
                    txtDescription.Text = list[0].Description;
                    txtInWardGatePass.Text = Validation.GetSafeString(list[0].InWardGatePassNo);
                    txtOutwardGatePassNo.Text = Validation.GetSafeString(list[0].OutWardGatePassNo);
                    if (list[0].Posted.Value)
                    {
                        if (Operations.IdRole != Validation.GetSafeLong(EnRoles.Administrator))
                        {
                            btnSave.Enabled = false;
                            btnDelete.Enabled = false;
                            chkPosted.Enabled = false;
                        }
                        chkPosted.Checked = list[0].Posted.Value;
                        lblStatuMessage.Text = "Posted Voucher ...";
                        lblStatuMessage.ForeColor = Color.Red;
                    }
                    else
                    {
                        btnSave.Enabled = true;
                        btnDelete.Enabled = true;
                    }

                    //List<TransactionsEL> listTransactions = Manager.GetTransactions(Validation.GetSafeLong(InvSampleBox.Text), "SaleInvoiceVoucher", Operations.IdCompany);

                    //if (listTransactions.Count > 0)
                    //{
                    //    TransactionsEL oelSalesTransaction = listTransactions.Find(x => x.Credit != 0);
                    //    if (oelSalesTransaction != null)
                    //    {
                    //        //SalesEditBox.Text = oelSalesTransaction.AccountNo.ToString();
                    //        cbxEmployees.SelectedValue = oelSalesTransaction.AccountNo;
                    //        EmpEditCode.Text = oelSalesTransaction.AccountNo.ToString();
                    //        SalesTransactionId = oelSalesTransaction.TransactionID;
                    //    }
                    //}


                    //FillEmployee(ListCustomer[0].SubAccountNo);

                    List<VoucherDetailEL> CustomerSamplesList = SamplesManager.GetSamplesReturnWithSampleNumber(Validation.GetSafeLong(InvSampleBox.Text), Operations.IdCompany);
                    if (CustomerSamplesList.Count > 0)
                    {
                        FillEmployee(CustomerSamplesList[0].SubAccountNo);

                        List<PersonsEL> ListCustomer = Manager.GetSampleCustomer(Validation.GetSafeLong(InvSampleBox.Text), list[0].AccountNo.ToString(), "SampleReturnVoucher", Operations.IdCompany);
                        if (ListCustomer.Count > 0)
                        {
                            CustEditBox.Text = Validation.GetSafeString(ListCustomer[0].AccountNo);
                            txtCustomerName.Text = ListCustomer[0].PersonName;
                            //txtSaleMemoNo.Text = ListCustomer[0].MemoSaleNo.ToString();                            
                            txtContact.Text = ListCustomer[0].Contact;
                            txtNTN.Text = ListCustomer[0].NTN;
                            txtAddress.Text = ListCustomer[0].Address;
                        }

                        FillSamplesTransaction(CustomerSamplesList, ListCustomer[0].Balance);
                    }
                }
                else
                {
                    ClearControl();
                    MessageBox.Show("Voucher Number Not Found ...");
                }
            }


        }
        private void FillEmployee(string EmpCode)
        {
            if (EmpCode != string.Empty)
            {
                cbxEmployees.SelectedValue = EmpCode;
                EmpEditCode.Text = EmpCode;
            }
            //var manager = new PersonsBLL();
            ////List<PersonsEL> list = manager.VerifyAccount("Customers/Suppliers", oelChartOfAccount.AccountNo);
            //List<PersonsEL> list = manager.VerifyAccount(Operations.IdCompany, "Persons", EmpCode);
            //if (list.Count > 0)
            //{
            //    EmpEditCode.Text = EmpCode.ToString();
            //    //txtEmployeeName.Text = list[0].PersonName;
            //    //txtEmployeeContact.Text = list[0].Contact;
            //    lblStatuMessage.Text = "";
            //}
            //else
            //{
            //    lblStatuMessage.Text = "Please Select Customer";
            //}
        }
        private void FillSamplesTransaction(List<VoucherDetailEL> CustomerSamplesList, decimal Amount)
        {
            var manager = new ItemsBLL();

            if (DgvSample.Rows.Count > 0)
            {
                DgvSample.Rows.Clear();
            }
            for (int i = 0; i < CustomerSamplesList.Count; i++)
            {
                DgvSample.Rows.Add();
                DgvSample.Rows[i].Cells[0].Value = CustomerSamplesList[i].IdVoucherDetail;
                DgvSample.Rows[i].Cells[1].Value = CustomerSamplesList[i].IdAccount;
                DgvSample.Rows[i].Cells[2].Value = CustomerSamplesList[i].ItemNo;
                DgvSample.Rows[i].Cells[3].Value = CustomerSamplesList[i].ItemName; //manager.GetItemByAccount(Validation.GetSafeLong(Salelist[i].ItemNo), Operations.IdCompany).ItemName;
                DgvSample.Rows[i].Cells[4].Value = CustomerSamplesList[i].Power;
                DgvSample.Rows[i].Cells[5].Value = CustomerSamplesList[i].ColorTemprature;
                //DgvSaleInvoice.Rows[i].Cells[4].Value = Salelist[i].BatchNo;
                //DgvSaleInvoice.Rows[i].Cells[5].Value = Salelist[i].PackingSize;
                //DgvSample.Rows[i].Cells[6].Value = CustomerSamplesList[i].Discription;
                DgvSample.Rows[i].Cells[6].Value = CustomerSamplesList[i].UnitPrice;
                DgvSample.Rows[i].Cells[7].Value = CustomerSamplesList[i].Units;
                DgvSample.Rows[i].Cells[8].Value = CustomerSamplesList[i].Units * Convert.ToDecimal(DgvSample.Rows[i].Cells[6].Value);
                //if (Salelist[i].Discount > 0)
                //{
                //    DgvSaleInvoice.Rows[i].Cells[9].Value = Salelist[i].Discount;
                //    DgvSaleInvoice.Rows[i].Cells[10].Value = Convert.ToDecimal(Salelist[i].Units * Salelist[i].UnitPrice) - (Convert.ToDecimal(Salelist[i].Units * Salelist[i].UnitPrice) * Convert.ToDecimal(DgvSaleInvoice.Rows[i].Cells[9].Value) / 100);

                //}
                //else
                //{
                //    DgvSaleInvoice.Rows[i].Cells[9].Value = Salelist[i].Discount;
                //    DgvSaleInvoice.Rows[i].Cells[10].Value = DgvSaleInvoice.Rows[i].Cells[8].Value;
                //}
                //DgvSaleInvoice.Rows[i].Cells[9].Value = Salelist[i].Description;
                ////DgvSaleInvoice.Rows[i].Cells[3].Value = List[i].
            }
            txtTotalAmount.Text = Amount.ToString();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmReport = new frmReports();
            frmReport.VoucherNo = Convert.ToInt64(InvSampleBox.Text);
            //frmReport.MdiParent = this;
            frmReport.ShowDialog();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new SamplesHeadBLL(); //SalesVoucherBLL();
            if (MessageBox.Show("Are You Sure To Delete...", "Deleting Sample", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                if (manager.DeleteSampleReturn(IdVoucher, "SampleReturnVoucher", Operations.IdCompany))
                {
                    lblStatuMessage.Text = "Sample Return Deleted Successfully";
                    FillData();
                    ClearControl();
                }

            }
        }
        //private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == 13)
        //    {
        //        if (txtTotalAmount.Text != string.Empty)
        //        {
        //            if (txtDiscount.Text != string.Empty)
        //            {
        //                if (txtDiscount.Text != "0" || txtDiscount.Text != string.Empty)
        //                {
        //                    //txtTotalDiscount.Text = (Convert.ToDecimal(txtTotalAmount.Text) * (Convert.ToDecimal(txtDiscount.Text) / 100)).ToString();
        //                    txtTotalDiscount.Text = (Convert.ToDecimal(txtTotalAmount.Text) - Convert.ToDecimal(txtDiscount.Text)).ToString();
        //                    //txtNetSale.Text = (Convert.ToDecimal(txtTotalAmount.Text) - ((Convert.ToDecimal(txtTotalAmount.Text)) * (Convert.ToDecimal(txtDiscount.Text)) / 100)).ToString();
        //                    txtNetSale.Text = (Convert.ToDecimal(txtTotalAmount.Text) - Convert.ToDecimal(txtDiscount.Text)).ToString();
        //                }
        //                else
        //                {
        //                    txtNetSale.Text = txtTotalAmount.Text;
        //                }
        //            }
        //            else
        //            {
        //                txtNetSale.Text = txtTotalAmount.Text;
        //            }
        //        }
        //        e.Handled = true;
        //        ProcessTabKey(true);

        //    }
        //    else
        //    {

        //    }
        //}
        private void txtTotalAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                //txtNetSale.Text = txtTotalAmount.Text;
                e.Handled = true;
                ProcessTabKey(true);
            }

        }
        private void frmSamples_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                FillData();
                ClearControl();
                if (DgvSample.Rows.Count > 0)
                {
                    DgvSample.Rows.Clear();
                }
            }
        }

        private void DgvSample_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvSample.CurrentCellAddress.X == 3)
            {
                TextBox txtItemName = e.Control as TextBox;
                if (txtItemName != null)
                {
                    txtItemName.KeyPress -= new KeyPressEventHandler(txtItemName_KeyPress);
                    txtItemName.KeyPress += new KeyPressEventHandler(txtItemName_KeyPress);
                }
            }
        }
        void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DgvSample.CurrentCellAddress.X == 3)
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
                {
                    frmfindProducts = new frmFindProducts();
                    frmfindProducts.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindProducts_ExecuteFindPorudctsEvent);
                    frmfindProducts.SearchText = e.KeyChar.ToString();
                    frmfindProducts.ShowDialog(this);
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



        private void cbxEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEmployees.SelectedIndex > 0)
            {
                EmpEditCode.Text = Validation.GetSafeString(cbxEmployees.SelectedValue);
            }
        }

        private void btnNewVoucher_Click(object sender, EventArgs e)
        {
            ClearControl();
            FillData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            long NextVoucherNo = Convert.ToInt64(SalesEditBox.Text);
            NextVoucherNo += 1;
            SalesEditBox.Text = NextVoucherNo.ToString();
            FillVoucher();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            long PreviousVoucherNo = Convert.ToInt64(SalesEditBox.Text);
            PreviousVoucherNo -= 1;
            SalesEditBox.Text = PreviousVoucherNo.ToString();
            FillVoucher();
        }
    }
}
