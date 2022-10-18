using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.Common;
using Accounts.EL;
using Accounts.BLL;
using MetroFramework.Forms;
//using Microsoft.Reporting.WinForms;

namespace Accounts.UI
{
    public partial class frmPosPurchasesReturn : Form
    {
        #region Variables
        int EnterCounter = 0;
        string CashRecievedAmount = string.Empty;
        frmFindAccounts frmfindAccounts;
        frmFindVouchers frmfindVouchers;
        string SupplierAccountNo = string.Empty;
        string CashAccountNo = string.Empty;
        string PurchasesAccountNo = string.Empty;
        string PurchasesTaxAccountNo = string.Empty;
        frmPOSInfoDialogue frmposdialogue;
        frmPosReturn frmposreturn;
        Int64? IdVoucher = null;
        Int64? SupplierTransactionId = 0, CashTransactionId = 0, PurchasesTransactionId = 0, PurchasesTaxTransactionId = 0;
        #endregion
        #region Form Methods And Events
        public frmPosPurchasesReturn()
        {
            InitializeComponent();
        }
        private void frmPosPurchasesReturn_Load(object sender, EventArgs e)
        {
            LoadAllItems();           
            toolStripBtnCashier.Text = Operations.UserName;
            cbxPurchasesType.SelectedIndex = 0;
            CheckSoftwareTaxableNature();
            FillSalesTaxAccounts(string.Empty);
            FillPurchaseAccounts(string.Empty);
            FillCashAccounts(string.Empty);
            CustEditBox.Focus();
        }
        #endregion
        #region Form Methods
        private void FillData()
        {
            var manager = new SalesHeadBLL();
            txtInvoiceNumber.Text = manager.GetMaxSalesInvoiceNumberBySaleType(Operations.IdProject, Operations.BookNo, true, 1).ToString();
        }
        private void LoadAllItems()
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetAllItems(Operations.IdProject);
            if (list.Count > 0)
            {
                //cbxProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                //cbxProducts.AutoCompleteSource = AutoCompleteSource.CustomSource;
                cbxProducts.DataSource = list;
                cbxProducts.DisplayMember = "ItemName";
                cbxProducts.ValueMember = "IdItem";
                cbxProducts.SelectedIndex = -1;
                cbxProducts.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cbxProducts.AutoCompleteSource = AutoCompleteSource.ListItems;

                //foreach (var item in list)
                //{
                //    cbxProducts.AutoCompleteCustomSource.Add(item.ItemName);
                //}
            }
        }
        private void CheckSoftwareNature()
        {
            SoftwareChecksEL oelSoftwareNatureCheck = DataOperations.SoftwareChecks.Find(x => x.SoftwareCheckName == "POSWithCredit");
            if (oelSoftwareNatureCheck != null)
            {
                if (!oelSoftwareNatureCheck.IsMust.Value)
                {
                    cbxPurchasesType.Enabled = false;
                }
                else
                {
                    cbxPurchasesType.Enabled = true;
                }
            }
            else
            {
                cbxPurchasesType.Enabled = false;
            }
        }
        private bool CheckSoftwareTaxableNature()
        {
            SoftwareChecksEL oelSoftwareNatureCheck = DataOperations.SoftwareChecks.Find(x => x.SoftwareCheckName == "Taxable");
            bool Status = false;
            if (oelSoftwareNatureCheck != null)
            {
                if (!oelSoftwareNatureCheck.IsMust.Value)
                {
                    txtTotalTax.Enabled = false;
                    txtTotalTaxAmount.Enabled = false;
                    txtInvoiceTotalWithTax.Enabled = false;
                }
                else
                {
                    txtTotalTax.Enabled = false;
                    txtTotalTaxAmount.Enabled = true;
                    txtInvoiceTotalWithTax.Enabled = true;
                    Status = true;
                }
            }
            else
            {
                txtTotalTax.Enabled = false;
                txtTotalTaxAmount.Enabled = false;
                txtInvoiceTotalWithTax.Enabled = false;
            }
            return Status;
        }
        private void FillPurchaseAccounts(string AccountNo)
        {
            var manager = new AccountsBLL();
            #region Fill Sales Account
            List<AccountsEL> list = manager.GetAccountsByType("Inventory Accounts", Operations.IdCompany, Operations.IdProject);
            if (AccountNo == "")
            {
                if (list.Count > 0)
                {

                    list.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "" });

                    cbxNaturalAccounts.DataSource = list;
                    cbxNaturalAccounts.DisplayMember = "AccountName";
                    cbxNaturalAccounts.ValueMember = "AccountNo";

                    cbxNaturalAccounts.SelectedIndex = 1;
                }
            }
            else
            {
                cbxNaturalAccounts.SelectedValue = AccountNo;
            }
            #endregion
        }
        private void FillSalesTaxAccounts(string AccountNo)
        {
            var manager = new AccountsBLL();
            #region Fill Tax Accounts Account
            List<AccountsEL> list = manager.GetAccountsByType("Tax Payables", Operations.IdCompany, Operations.IdProject);
            if (AccountNo == "")
            {
                if (list.Count > 0)
                {

                    list.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "" });

                    cbxTaxPayables.DataSource = list;
                    cbxTaxPayables.DisplayMember = "AccountName";
                    cbxTaxPayables.ValueMember = "AccountNo";

                    cbxTaxPayables.SelectedIndex = 1;
                }
            }
            else
            {
                cbxTaxPayables.SelectedValue = AccountNo;
            }
            #endregion
        }
        private void FillCashAccounts(string AccountNo)
        {
            #region Fill Cash Accounts
            var manager = new AccountsBLL();
            List<AccountsEL> listCash = manager.GetAccountsByType("Cash Accounts", Operations.IdCompany, Operations.IdProject);
            if (AccountNo == "")
            {
                if (listCash.Count > 0)
                {
                    cbxCashAccounts.DataSource = listCash;
                    listCash.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "" });

                    cbxCashAccounts.DisplayMember = "AccountName";
                    cbxCashAccounts.ValueMember = "AccountNo";

                    cbxCashAccounts.SelectedIndex = 1;
                }
            }
            else
            {
                cbxCashAccounts.SelectedValue = AccountNo;
            }

            #endregion
        }
        private string BuildRemarks()
        {
            string Remarks = "";
            string First = "Following Are Sales To " + CustEditBox.Text + "~"; //: txtDescription.Text + "~";
            for (int i = 0; i < grdProducts.Rows.Count; i++)
            {
                Remarks += grdProducts.Rows[i].Cells[2].Value.ToString() + " "
                           + grdProducts.Rows[i].Cells[4].Value.ToString() + " Units"
                           + "@" + grdProducts.Rows[i].Cells[6].Value.ToString() + "~";
            }
            First += Remarks;
            return First;
        }
        private void ClearControls()
        {
            grdProducts.Rows.Clear();
            txtTotalItems.Text = string.Empty;
            txtTotalTax.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtInvoiceNumber.Text = string.Empty;
            txtInvoiceTotal.Text = string.Empty;
            txtInvoiceTotalAfterDiscount.Text = string.Empty;
            txtTotalTaxAmount.Text = string.Empty;
            txtInvoiceTotalWithTax.Text = string.Empty;
            EnterCounter = 0;
            CashRecievedAmount = string.Empty;
            cbxProducts.Focus();
            if (CustEditBox.Visible)
            {
                SupplierAccountNo = string.Empty;
                CustEditBox.Text = string.Empty;
                //CustEditBox.Visible = false;
                CustEditBox.Focus();
            }
            IdVoucher = null;
            SupplierTransactionId = null;
            PurchasesTransactionId = null;
            CashTransactionId = null;
            PurchasesTaxTransactionId = null;
            SupplierAccountNo = string.Empty;
            CashAccountNo = string.Empty;
            PurchasesAccountNo = string.Empty;
            PurchasesTaxAccountNo = string.Empty;
            cbxPurchasesType.SelectedIndex = 0;
        }
        #endregion
        #region Grid Events
        private void grdProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                e.Value = "-";
            }
            else if (e.ColumnIndex == 9)
            {
                e.Value = "+";
            }
            else if (e.ColumnIndex == 10)
            {
                e.Value = "Delete";
            }
        }
        private void grdProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal Amount = 0;
            decimal TotalQuantity = 0;
            if (e.ColumnIndex == 8)
            {
                DataGridViewRow ORow = grdProducts.Rows[e.RowIndex];
                decimal CurrentRowQuantity = Validation.GetSafeDecimal(ORow.Cells["colQuantity"].Value);
                if (CurrentRowQuantity >= 1)
                {
                    CurrentRowQuantity--;
                    if (CurrentRowQuantity > 0)
                    {
                        grdProducts.Rows[e.RowIndex].Cells["colQuantity"].Value = CurrentRowQuantity;
                        grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value = CurrentRowQuantity * Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                    }
                }
            }
            else if (e.ColumnIndex == 9)
            {
                DataGridViewRow ORow = grdProducts.Rows[e.RowIndex];
                decimal CurrentRowQuantity = Validation.GetSafeDecimal(ORow.Cells["colQuantity"].Value);
                if (CurrentRowQuantity >= 1)
                {
                    CurrentRowQuantity++;
                    grdProducts.Rows[e.RowIndex].Cells["colQuantity"].Value = CurrentRowQuantity;
                    grdProducts.Rows[e.RowIndex].Cells["colAmount"].Value = CurrentRowQuantity * Validation.GetSafeDecimal(grdProducts.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                }
            }
            else if (e.ColumnIndex == 10)
            {
                DataGridViewRow ORow = grdProducts.Rows[e.RowIndex];
                grdProducts.Rows.Remove(ORow);
            }
            for (int i = 0; i < grdProducts.Rows.Count; i++)
            {
                Amount += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colAmount"].Value);
                TotalQuantity += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colQuantity"].Value);
            }
            txtTotalItems.Text = TotalQuantity.ToString();
            txtInvoiceTotal.Text = Amount.ToString("0.00");
            txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(Amount) - (Validation.GetSafeDecimal(txtDiscount.Text) + Validation.GetSafeDecimal(txtFreight.Text)));
            if (grdProducts.Rows.Count == 0)
            {
                txtFreight.Text = string.Empty;
                txtDiscount.Text = string.Empty;
                txtInvoiceTotalAfterDiscount.Text = "0.00";
            }
        }
        #endregion        
        #region Validate Methods
        private bool ValidateRows()
        {

            if (grdProducts.Rows.Count == 0)
                return false;
            else
                return true;
        }
        private bool ValidateControls()
        {
            if (CustEditBox.Visible)
            {
                if (SupplierAccountNo == string.Empty)
                {
                    MessageBox.Show("Supplier Is Missing...");
                    return false;
                }
                else if (PurchasesAccountNo == string.Empty)
                {
                    MessageBox.Show("Purchase Account Missing, Please Select...");
                    return false;
                }
            }
            else if (!CustEditBox.Visible)
            {
                if (CashAccountNo == string.Empty)
                {
                    MessageBox.Show("Cash Account Missing...");
                    return false;
                }
                else if (PurchasesAccountNo == string.Empty)
                {
                    MessageBox.Show("Purchase Account Missing, Please Select...");
                    return false;
                }
            }

            return true;
        }
        private bool ValidateBookPeriod()
        {
            bool Status = true;
            if (Operations.BookPeriod == "" || Operations.BookPeriod == "Open")
            {
                Status = true;
            }
            else
            {
                string[] Period = Operations.BookPeriod.Split('=');
                if (Period.Length == 2)
                {
                    int FirstMonth = Convert.ToInt32(Period[0].Split(',')[0]);
                    int FirstYear = Convert.ToInt32(Period[0].Split(',')[1]);

                    int SecondMonth = Convert.ToInt32(Period[1].Split(',')[0]);
                    int SecondYear = Convert.ToInt32(Period[1].Split(',')[1]);
                    if (VInvoiceDate.Value.Year == FirstYear || VInvoiceDate.Value.Year == SecondYear)
                    {
                        if (VInvoiceDate.Value.Month < FirstMonth && VInvoiceDate.Value.Year == FirstYear)
                        {
                            Status = false;
                        }
                        else if (VInvoiceDate.Value.Month > SecondMonth && VInvoiceDate.Value.Year == SecondYear)
                        {
                            Status = false;
                        }
                        else
                        {
                            Status = true;
                        }
                    }
                    else
                    {
                        Status = false;
                    }
                    //if (VDate.Value.Month == FirstMonth && VDate.Value.Year == FirstYear || (VDate.Value.Month == SecondMonth && VDate.Value.Year == SecondYear))
                    //{
                    //    Status = true;
                    //}
                }
                else
                {
                    Status = false;
                }
            }
            return Status;
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Variables
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            List<VoucherDetailEL> oelPurchaseDetailCollection = new List<VoucherDetailEL>();
            List<VoucherDetailEL> oelCostOfSalesCollection = new List<VoucherDetailEL>();
            List<VoucherDetailEL> oelProductsProfitLossCollection = new List<VoucherDetailEL>();
            #endregion
            #region Main Button Area
            if (ValidateRows())
            {
                if (ValidateControls())
                {
                    if (ValidateBookPeriod())
                    {
                        #region VoucherHead
                        VouchersEL oelVoucher = new VouchersEL();
                        if (!IdVoucher.HasValue)
                        {
                            oelVoucher.IdVoucher = 0;
                        }
                        else
                        {
                            oelVoucher.IdVoucher = IdVoucher;
                        }
                        oelVoucher.IdUser = Operations.UserID;
                        oelVoucher.IdProject = Operations.IdProject;
                        oelVoucher.SheetNo = 0;
                        oelVoucher.BookNo = Operations.BookNo;
                        oelVoucher.TerminalNumber = Validation.GetSafeInteger(XmlConfiguration.ReadXmlTerminalsConfiguration()[0]);
                        oelVoucher.BiltyNo = string.Empty;
                        oelVoucher.BillNo = txtBillNo.Text;
                        oelVoucher.SampleNo = 0;
                        oelVoucher.FirstName = string.Empty;
                        oelVoucher.Contact = string.Empty;
                        oelVoucher.Cnic = string.Empty;
                        oelVoucher.Address = string.Empty;
                        oelVoucher.SoftwareType = string.Empty;
                        if (CustEditBox.Visible)
                        {
                            oelVoucher.AccountNo = SupplierAccountNo;
                        }
                        else
                        {
                            oelVoucher.AccountNo = CashAccountNo;
                        }
                        // if (IdVoucher != null || IdVoucher > 0)
                        {
                            oelVoucher.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                        }
                        oelVoucher.SubAccountNo = string.Empty;
                        oelVoucher.EmployeeAccountNo = string.Empty;
                        oelVoucher.VDiscription = string.Empty;

                        oelVoucher.OutWardGatePassNo = string.Empty;
                        oelVoucher.VDate = VInvoiceDate.Value;
                        if (CustEditBox.Visible)
                        {
                            oelVoucher.ClosingBalance = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, SupplierAccountNo)[0].ClosingBalance;//CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, CustomerAccountNo)[0].ClosingBalance;  //Validation.GetSafeDecimal(txtCurrentBalance.Text);
                        }
                        else
                        {
                            oelVoucher.ClosingBalance = 0;
                        }
                        oelVoucher.TotalItems = Validation.GetSafeDecimal(txtTotalItems.Text);
                        oelVoucher.BillAmount = Validation.GetSafeDecimal(txtInvoiceTotal.Text);
                        oelVoucher.Discount = Validation.GetSafeDecimal(txtDiscount.Text);                        
                        oelVoucher.TotalFreight = Validation.GetSafeDecimal(0);
                        oelVoucher.TotalAmount = Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text);
                        oelVoucher.TaxPercentage = Validation.GetSafeDecimal(txtTotalTax.Text);
                        oelVoucher.TotalTaxAmount = Validation.GetSafeDecimal(txtTotalTaxAmount.Text);
                        oelVoucher.TotalAmountAfterTax = Validation.GetSafeDecimal(txtInvoiceTotalWithTax.Text);
                        oelVoucher.VAT = 0;//Validation.GetSafeInteger(txtVat.Text);
                        oelVoucher.VATAmount = 0;//Validation.GetSafeDecimal(txtTotalAmount.Text);
                        oelVoucher.Transactiondays = 0;
                        oelVoucher.IsRecieved = false;
                        oelVoucher.IsImportTransaction = false;
                        if (CustEditBox.Visible)
                            oelVoucher.IsNetTransaction = false;
                        else
                            oelVoucher.IsNetTransaction = true;
                        oelVoucher.Posted = true;
                        #endregion
                        #region Add Stock
                        for (int i = 0; i < grdProducts.Rows.Count; i++)
                        {
                            VoucherDetailEL oelSaleDetial = new VoucherDetailEL();
                            ItemsEL oelItem = new ItemsEL();
                            if (grdProducts.Rows[i].Cells["ColIdVoucherDetail"].Value != null)
                            {
                                //oelSaleDetial.TransactionID = new Guid(grdProducts.Rows[i].Cells["ColTransaction"].Value.ToString());
                                oelSaleDetial.IdVoucherDetail = Validation.GetSafeLong(grdProducts.Rows[i].Cells["ColIdVoucherDetail"].Value.ToString());
                                oelSaleDetial.IsNew = false;
                            }
                            else
                            {
                                oelSaleDetial.IdVoucherDetail = 0;
                                //  oelPurchaseDetial.TransactionID = Guid.NewGuid();
                                oelSaleDetial.IsNew = true;
                            }
                            oelSaleDetial.SeqNo = i + 1;
                            oelSaleDetial.IdVoucher = oelVoucher.IdVoucher;
                            oelSaleDetial.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelSaleDetial.IdItem = Validation.GetSafeLong(grdProducts.Rows[i].Cells["colIdItem"].Value);
                            oelItem.IdItem = Validation.GetSafeLong(grdProducts.Rows[i].Cells["colIdItem"].Value);
                            oelSaleDetial.PackingSize = Validation.GetSafeString(grdProducts.Rows[i].Cells["colPackingSize"].Value);
                            oelSaleDetial.Discription = "N/A"; //Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colRemarks"].Value);
                            oelSaleDetial.TotalCartons = 0; //Validation.GetSafeLong(grdProducts.Rows[i].Cells["colCartons"].Value);
                            oelSaleDetial.BatchNo = string.Empty;
                            oelSaleDetial.Expiry = string.Empty;
                            oelSaleDetial.EngineNo = string.Empty;
                            oelSaleDetial.ChasisNo = string.Empty;
                            oelSaleDetial.VehicleModel = string.Empty;
                            oelSaleDetial.VehicleNo = string.Empty;
                            oelSaleDetial.FirstIMEI = string.Empty;
                            oelSaleDetial.SecondIMEI = string.Empty;
                            oelSaleDetial.ColorCode = 0;
                            oelSaleDetial.CurrentStock = 0;
                            oelSaleDetial.Units = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colQuantity"].Value);
                            oelSaleDetial.Bonus = 0;
                            oelSaleDetial.RemainingUnits = 0;
                            oelSaleDetial.UnitPrice = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colUnitPrice"].Value);
                            oelItem.CurrentUnitPrice = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colUnitPrice"].Value);
                            oelSaleDetial.Amount = Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colAmount"].Value);
                            oelSaleDetial.Discount = 0; //Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscount"].Value.ToString().Replace('%', ' '));
                            oelSaleDetial.DiscountAmount = 0; //Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscountAmount"].Value);

                            oelPurchaseDetailCollection.Add(oelSaleDetial);
                        }
                        #endregion                       
                        #region Add Supplier
                        if (CustEditBox.Visible)
                        {
                            VoucherDetailEL oelSupplierTransaction = new VoucherDetailEL();
                            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "ItemWiseLederPrint");
                            if (SupplierTransactionId.HasValue && SupplierTransactionId.Value > 0)
                            {
                                oelSupplierTransaction.IdTransactionDetail = SupplierTransactionId.Value;
                                oelSupplierTransaction.IsNew = false;
                            }
                            else
                            {
                                oelSupplierTransaction.IdTransactionDetail = 0;
                                oelSupplierTransaction.IsNew = true;
                            }
                            oelSupplierTransaction.IsNetTransaction = false;
                            oelSupplierTransaction.SeqNo = 1;
                            oelSupplierTransaction.TrackNumber = 1;
                            oelSupplierTransaction.IdProject = Operations.IdProject;
                            oelSupplierTransaction.BookNo = Operations.BookNo;
                            oelSupplierTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelSupplierTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelSupplierTransaction.AccountNo = SupplierAccountNo;
                            oelSupplierTransaction.SubAccountNo = "0";
                            oelSupplierTransaction.Date = VInvoiceDate.Value;
                            oelSupplierTransaction.VoucherType = "P";
                            oelSupplierTransaction.TransactionType = 1;
                            oelSupplierTransaction.TransactionMode = "CR";
                            if (oelSoftwareCheck != null && oelSoftwareCheck.IsMust.Value)
                            {
                                oelSupplierTransaction.Description = BuildRemarks(); //txtDescription.Text;
                            }
                            else
                            {
                                oelSupplierTransaction.Description = "Purchases Return From : " + CustEditBox.Text;
                            }
                            if (CheckSoftwareTaxableNature())
                            {
                                oelSupplierTransaction.Debit = Validation.GetSafeDecimal(txtInvoiceTotalWithTax.Text);
                            }
                            else
                                oelSupplierTransaction.Debit = Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text);

                            oelSupplierTransaction.Credit = 0;
                            oelSupplierTransaction.Posted = chkPosted.Checked;
                            oelSupplierTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelSupplierTransaction);
                        }
                        #endregion
                        #region Add Cash
                        if (!CustEditBox.Visible)
                        {
                            VoucherDetailEL oelCashTransaction = new VoucherDetailEL();
                            if (CashTransactionId.HasValue && CashTransactionId.Value > 0)
                            {
                                oelCashTransaction.IdTransactionDetail = CashTransactionId.Value;
                                oelCashTransaction.IsNew = false;
                            }
                            else
                            {
                                oelCashTransaction.IdTransactionDetail = 0;
                                oelCashTransaction.IsNew = true;
                            }
                            oelCashTransaction.IsNetTransaction = true;
                            oelCashTransaction.SeqNo = 1;
                            oelCashTransaction.TrackNumber = 1;
                            oelCashTransaction.IdProject = Operations.IdProject;
                            oelCashTransaction.BookNo = Operations.BookNo;
                            oelCashTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelCashTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCashTransaction.AccountNo = CashAccountNo;
                            oelCashTransaction.SubAccountNo = "0";
                            oelCashTransaction.Date = VInvoiceDate.Value; ;
                            oelCashTransaction.VoucherType = "P";
                            oelCashTransaction.TransactionType = 1;
                            oelCashTransaction.TransactionMode = "CR";
                            oelCashTransaction.Description = "Cash Purchases Return : ";

                            if (CheckSoftwareTaxableNature())
                            {
                                oelCashTransaction.Debit = Convert.ToDecimal(txtInvoiceTotalWithTax.Text);
                            }
                            else
                                oelCashTransaction.Debit = Convert.ToDecimal(txtInvoiceTotalAfterDiscount.Text);
                            oelCashTransaction.Credit = 0;
                            oelCashTransaction.Posted = chkPosted.Checked;
                            oelCashTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelCashTransaction);
                        }
                        #endregion
                        #region Add Purchase Account In Transactions
                        /// Add Purchase Account...
                        VoucherDetailEL oelPurchaseTransaction = new TransactionsEL();
                        if (PurchasesTransactionId.HasValue && PurchasesTransactionId.Value > 0)
                        {
                            oelPurchaseTransaction.IdTransactionDetail = PurchasesTransactionId.Value;
                            oelPurchaseTransaction.IsNew = false;
                        }
                        else
                        {
                            oelPurchaseTransaction.IdTransactionDetail = 0;
                            oelPurchaseTransaction.IsNew = true;
                        }
                        oelPurchaseTransaction.IsNetTransaction = CustEditBox.Visible ? false : true; ;
                        oelPurchaseTransaction.SeqNo = 2;
                        oelPurchaseTransaction.TrackNumber = 2;
                        oelPurchaseTransaction.IdProject = Operations.IdProject;
                        oelPurchaseTransaction.BookNo = Operations.BookNo;
                        oelPurchaseTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                        oelPurchaseTransaction.IdVoucher = oelVoucher.IdVoucher;
                        //oelPurchaseTransaction.AccountNo = Validation.GetSafeLong(PurchasesEditBox.Text);
                        oelPurchaseTransaction.AccountNo = PurchasesAccountNo;
                        oelPurchaseTransaction.SubAccountNo = "0";
                        oelPurchaseTransaction.Date = VInvoiceDate.Value;
                        oelPurchaseTransaction.VoucherType = "P";
                        oelPurchaseTransaction.TransactionType = 2;
                        oelPurchaseTransaction.Description = "Purchases Account Debited";
                        oelPurchaseTransaction.Credit = Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text);
                        
                        oelPurchaseTransaction.Credit = 0;
                        oelPurchaseTransaction.TransactionMode = "DR";
                        oelPurchaseTransaction.CreatedDateTime = VInvoiceDate.Value;
                        oelPurchaseTransaction.Posted = chkPosted.Checked;

                        oelCostOfSalesCollection.Add(oelPurchaseTransaction);
                        #endregion region
                        #region Add Tax Account In Transactions
                        if (CheckSoftwareTaxableNature())
                        {
                            /// Add Tax Account...
                            VoucherDetailEL oelPurchaseTaxTransaction = new TransactionsEL();
                            if (PurchasesTaxTransactionId.HasValue && PurchasesTaxTransactionId.Value > 0)
                            {
                                oelPurchaseTaxTransaction.IdTransactionDetail = PurchasesTaxTransactionId.Value;
                                oelPurchaseTaxTransaction.IsNew = false;
                            }
                            else
                            {
                                oelPurchaseTaxTransaction.IdTransactionDetail = 0;
                                oelPurchaseTaxTransaction.IsNew = true;
                            }
                            oelPurchaseTaxTransaction.IsNetTransaction = CustEditBox.Visible ? false : true; ;
                            oelPurchaseTaxTransaction.SeqNo = 2;
                            oelPurchaseTaxTransaction.TrackNumber = 3;
                            oelPurchaseTaxTransaction.IdProject = Operations.IdProject;
                            oelPurchaseTaxTransaction.BookNo = Operations.BookNo;
                            oelPurchaseTaxTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelPurchaseTaxTransaction.IdVoucher = oelVoucher.IdVoucher;
                            //oelPurchaseTransaction.AccountNo = Validation.GetSafeLong(PurchasesEditBox.Text);
                            oelPurchaseTaxTransaction.AccountNo = PurchasesTaxAccountNo;
                            oelPurchaseTaxTransaction.SubAccountNo = "0";
                            oelPurchaseTaxTransaction.Date = VInvoiceDate.Value;
                            oelPurchaseTaxTransaction.VoucherType = "P";
                            oelPurchaseTaxTransaction.TransactionType = 2;
                            oelPurchaseTaxTransaction.Description = "Purchases Account Credit With Tax Amount";
                            oelPurchaseTaxTransaction.Credit = Validation.GetSafeDecimal(txtTotalTaxAmount.Text);
                            oelPurchaseTaxTransaction.Debit = 0;
                            oelPurchaseTaxTransaction.TransactionMode = "DR";
                            oelPurchaseTaxTransaction.CreatedDateTime = VInvoiceDate.Value;
                            oelPurchaseTaxTransaction.Posted = chkPosted.Checked;
                           
                            oelCostOfSalesCollection.Add(oelPurchaseTaxTransaction);
                            
                        }
                        #endregion region
                        #region Saving Code
                        if (MessageBox.Show("Save Or Update Purchases Return Record?", "Saving Record", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (IdVoucher == null || IdVoucher == 0)
                            {

                                var manager = new PurchaseHeadBLL();

                                EntityoperationInfo infoResult = manager.InsertPurchasesReturn(oelVoucher, oelPurchaseDetailCollection, oelCostOfSalesCollection);
                                if (infoResult.IsSuccess)
                                {
                                    txtInvoiceNumber.Text = infoResult.VoucherNo.ToString();
                                    IdVoucher = infoResult.IntID;
                                    FillVoucher();
                                    MessageBox.Show("Transaction Successfully Done...");
                                    //ClearControls();
                                    //FillData();
                                }
                            }
                            else
                            {
                                var manager = new PurchaseHeadBLL();
                                var VManager = new VoucherBLL();
                                var ItemManager = new ItemsBLL();
                                EntityoperationInfo infoResult = manager.UpdatePurchasesReturn(oelVoucher, oelPurchaseDetailCollection, oelCostOfSalesCollection);
                                if (infoResult.IsSuccess)
                                {
                                    MessageBox.Show("Transaction Successfully Done...");
                                    ClearControls();
                                    //FillData();
                                }
                            }
                        }
                        else
                        {
                            cbxProducts.Focus();
                        }
                        #endregion
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Voucher In This Book Period :" + Operations.BookPeriod);
                    }
                }
                else
                {
                    MessageBox.Show("Check Values....");
                }
            }
            else
            {
                MessageBox.Show("No Record Found...");
            }
            #endregion            
        }
        private void toolStripBtnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
        private void toolStripReturn_Click(object sender, EventArgs e)
        {
            frmposreturn = new frmPosReturn();
            frmposreturn.Show();
        }       
        #endregion
        #region CumboBox Methods And Events
        private void cbxNaturalAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNaturalAccounts.SelectedIndex > 0)
            {
                PurchasesAccountNo = Validation.GetSafeString(cbxNaturalAccounts.SelectedValue);
            }
            else
            {
                PurchasesAccountNo = string.Empty;
            }
        }
        private void cbxTaxPayables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTaxPayables.SelectedIndex > 0)
            {
                PurchasesTaxAccountNo = Validation.GetSafeString(cbxTaxPayables.SelectedValue);
            }
            else
            {
                PurchasesTaxAccountNo = string.Empty;
            }
        }
        private void cbxCashAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxCashAccounts.SelectedIndex > 0)
            {
                CashAccountNo = Validation.GetSafeString(cbxCashAccounts.SelectedValue);
            }
            else
            {
                CashAccountNo = string.Empty;
            }
        }
        private void cbxCustomerType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxPurchasesType.SelectedIndex == 0)
            {
                CustEditBox.Visible = true;
            }
            else
            {
                CustEditBox.Visible = false;
            }
        }
        #endregion
        #region WinControls And Custom Controls Methods And Events
        private void cbxProducts_TextChanged(object sender, EventArgs e)
        {
            GetItemByBarCode(Validation.GetSafeString(cbxProducts.Text));
        }
        private void cbxProducts_KeyUp(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Down || (e.KeyCode == Keys.Shift && e.KeyCode == Keys.Home))
            //    return;
            //if (e.KeyCode != Keys.Enter)
            //{
            //    cbxProducts.DroppedDown = true;
            //}
            //else if (e.KeyCode == Keys.Enter)
            //{
            //    cbxProducts.DroppedDown = false;
            //}
            //int index;
            //string actual;
            //string found;
            //actual = this.cbxProducts.Text;
            //index = cbxProducts.FindString(actual);
            //if (index > -1)
            //{
            //    found =   ((ItemsEL)(this.cbxProducts.Items[index])).ItemName;

            //    //Select this item from the list.
            //    this.cbxProducts.SelectedIndex = index;

            //    //Select the portion of the text that was automatically
            //    //added so that additional typing replaces it.
            //    this.cbxProducts.SelectionStart = actual.Length;
            //    this.cbxProducts.SelectionLength = found.Length;
            //}

        }
        private void cbxProducts_Leave(object sender, EventArgs e)
        {
            //int iFoundIndex;
            //iFoundIndex = cbxProducts.FindStringExact(cbxProducts.Text);
            //cbxProducts.SelectedIndex = iFoundIndex;
        }
        private void cbxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (cbxProducts.SelectedIndex > 0)
            //{
            //    MessageBox.Show(cbxProducts.Text);
            //    MessageBox.Show(cbxProducts.SelectedValue.ToString());
            //}
        }
        private void cbxProducts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Left || e.KeyCode == Keys.Right || e.KeyCode == Keys.Up || e.KeyCode == Keys.Delete || e.KeyCode == Keys.Down || (e.KeyCode == Keys.Shift && e.KeyCode == Keys.Home))
            {
                return;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (cbxProducts.Text != string.Empty)
                {
                    GetItemById(Validation.GetSafeLong(cbxProducts.SelectedValue));
                    cbxProducts.Text = string.Empty;
                }
                else
                {
                    EnterCounter++;
                    if (EnterCounter >= 2 && grdProducts.Rows.Count > 0)
                    {
                        EnterCounter = 0;
                        txtFreight.Focus();
                    }
                }
            }
            else
            {
                if (!char.IsNumber((char)e.KeyCode))
                    e.SuppressKeyPress = false;
                else
                {
                    GetItemByBarCode(Validation.GetSafeString(cbxProducts.SelectedValue));
                    cbxProducts.Text = string.Empty;
                }
            }
        }
        private void cbxCustomerType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (cbxPurchasesType.Text == "Credit Purchases")
                {
                    CustEditBox.Focus();
                }
                else
                {
                    cbxProducts.Focus();
                }
            }
        }
        private void CustEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                if (e.KeyChar != (char)Keys.Enter)
                {
                    e.Handled = true;
                    frmfindAccounts = new frmFindAccounts();
                    frmfindAccounts.SearchText = e.KeyChar.ToString();
                    frmfindAccounts.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmfindAccounts_ExecuteFindAccountEvent);
                    frmfindAccounts.ShowDialog();
                }
                else
                {
                    cbxProducts.Focus();
                }

            }
            else
                e.Handled = false;
        }
        void frmfindAccounts_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            SupplierAccountNo = oelAccount.AccountNo;
            CustEditBox.Text = oelAccount.AccountName;
        }
        #endregion
        #region Item Fetch Methods
        private void GetItemById(Int64? Id)
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetItemById(Id.Value);
            FillProductInGrid(list, Id);
        }
        private void GetItemByBarCode(string BarCode)
        {
            if (!string.IsNullOrEmpty(BarCode))
            {
                var manager = new ItemsBLL();
                List<ItemsEL> list = manager.GetItemByBarCode(BarCode);
                if (list.Count > 0)
                {
                    MessageBox.Show(cbxProducts.Text);
                    FillProductInGrid(list, list[0].IdItem);
                    cbxProducts.Text = string.Empty;
                }
            }
        }
        private void FillProductInGrid(List<ItemsEL> list, Int64? Id)
        {
            decimal Amount = 0;
            decimal TotalQuantity = 0;
            bool IsItemFound = false;
            int ItemFoundIndex = 0;
            if (list.Count > 0)
            {
                //MessageBox.Show(cbxProducts.Text);
                //MessageBox.Show(cbxProducts.SelectedValue.ToString());   
                //First Check Item If Exists In Grid
                if (grdProducts.Rows.Count > 0)
                {
                    for (int i = 0; i < grdProducts.Rows.Count; i++)
                    {
                        if (Id == Validation.GetSafeLong(grdProducts.Rows[i].Cells["colIdItem"].Value))
                        {
                            IsItemFound = true;
                            ItemFoundIndex = i;
                            break;
                        }
                    }
                }
                if (IsItemFound)
                {
                    // Update Items Here...   
                    DataGridViewRow oFoundRow = grdProducts.Rows[ItemFoundIndex];
                    grdProducts.Rows[ItemFoundIndex].Cells["colQuantity"].Value = Validation.GetSafeDecimal(grdProducts.Rows[ItemFoundIndex].Cells["colQuantity"].Value) + 1;
                    grdProducts.Rows[ItemFoundIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(grdProducts.Rows[ItemFoundIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(grdProducts.Rows[ItemFoundIndex].Cells["colQuantity"].Value);
                }
                else
                {
                    // Add New Items Here If No Item Found
                    grdProducts.Rows.Add();
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colIdItem"].Value = Id;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colBarCode"].Value = list[0].BarCode;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colItemName"].Value = list[0].ItemName;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colPackingSize"].Value = list[0].PackingSize;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colQuantity"].Value = 1;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colUnitPrice"].Value = list[0].CurrentUnitPrice;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value = 1 * list[0].CurrentUnitPrice;
                }
                for (int i = 0; i < grdProducts.Rows.Count; i++)
                {
                    Amount += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colAmount"].Value);
                    TotalQuantity += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colQuantity"].Value);
                }
                txtTotalItems.Text = TotalQuantity.ToString(); ;
                txtInvoiceTotal.Text = Amount.ToString("0.00");
                txtInvoiceTotalAfterDiscount.Text = Amount.ToString("0.00");
            }
        }
        #endregion
        #region Purchases Calculation Fields Methods And Events
        private void txtFreight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(txtInvoiceTotal.Text) + Validation.GetSafeDecimal(txtFreight.Text) + Validation.GetSafeDecimal(txtDiscount.Text));
                txtDiscount.Focus();
            }
        }
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) - Validation.GetSafeDecimal(txtDiscount.Text) + Validation.GetSafeDecimal(txtFreight.Text));
                if (txtTotalTax.Enabled)
                    txtTotalTax.Focus();
                else
                    btnSave.Focus();
            }
        }        
        private void txtTotalTax_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtTotalTaxAmount.Text = Validation.GetSafeString(((Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) * Validation.GetSafeDecimal(txtTotalTax.Text)) / 100).ToString("0.00"));
                txtInvoiceTotalWithTax.Text = Validation.GetSafeString((Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) + (Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) * Validation.GetSafeDecimal(txtTotalTax.Text)) / 100).ToString("0.00"));
                if (txtTotalTax.Text != string.Empty)
                {
                    txtTotalTax.Text = txtTotalTax.Text + "%";
                }
                btnSave.Focus();
            }
        }
        private void txtTotalTax_Enter(object sender, EventArgs e)
        {
            txtTotalTax.Text = string.Empty;
        }       
        #endregion   
        #region Custom Controls and Events
        private void txtInvoiceNumber_ButtonClick(object sender, EventArgs e)
        {
            frmfindVouchers = new frmFindVouchers();
            frmfindVouchers.ExecuteFindVouchersEvent += new frmFindVouchers.VouchersDelegate(frmfindVouchers_ExecuteFindVouchersEvent);
            frmfindVouchers.ShowDialog();
        }
        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {            
            IdVoucher = oelVoucher.IdVoucher;
            txtInvoiceNumber.Text = oelVoucher.VoucherNo.ToString();
            FillVoucher();
        }
        #endregion
        #region Grids Transactions Related Methods
        private void FillVoucher()
        {
            var Manager = new VoucherBLL();
            var PManager = new PurchaseHeadBLL();            
            //List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(VEditBox.Text));
            List<VoucherDetailEL> ListPurchases = PManager.GetPOSPurchasesTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo);
            if (ListPurchases.Count > 0)
            {
                IdVoucher = ListPurchases[0].IdVoucher;
                txtInvoiceNumber.Enabled = false;
                txtBillNo.Text = ListPurchases[0].BillNo;
                VInvoiceDate.Value = ListPurchases[0].VDate.Value;
                txtTotalItems.Text = Validation.GetSafeString(ListPurchases[0].TotalItems);
                txtFreight.Text = ListPurchases[0].TotalFreight.ToString();
                txtInvoiceTotalAfterDiscount.Text = ListPurchases[0].TotalAmount.ToString();
                if (!ListPurchases[0].IsNetTransaction.Value)
                {
                    FillCreditor(ListPurchases[0].AccountNo);
                    CustEditBox.Visible = true;
                }
                else
                    CustEditBox.Visible = false;
                chkPosted.Checked = ListPurchases[0].Posted.Value;               
                FillPurchases(ListPurchases);

                List<VoucherDetailEL> listTransactions = PManager.GetPurchasesSubTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, ListPurchases[0].IsNetTransaction.Value);
                FillHeadTransactions(listTransactions);

            }
            else
            {
                MessageBox.Show("Voucher Number Not Found ...");
                ClearControls();
            }
        }
        private void FillPurchasesByNumber(Int64 PNo)
        {
            var Manager = new VoucherBLL();
            var PManager = new PurchaseHeadBLL();           
  
            //List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(VEditBox.Text));
            List<VoucherDetailEL> ListPurchases = PManager.GetPOSPurchasesTransactionsByNumber(PNo, Operations.IdProject, Operations.BookNo);
            if (ListPurchases.Count > 0)
            {
                IdVoucher = ListPurchases[0].IdVoucher;
                txtInvoiceNumber.Enabled = false;
                txtInvoiceNumber.Text = Validation.GetSafeString(ListPurchases[0].VoucherNo);
                txtBillNo.Text = ListPurchases[0].BillNo;
                VInvoiceDate.Value = ListPurchases[0].VDate.Value;
                txtTotalItems.Text = Validation.GetSafeString(ListPurchases[0].TotalItems);
                txtFreight.Text = ListPurchases[0].TotalFreight.ToString();
                txtInvoiceTotalAfterDiscount.Text = ListPurchases[0].TotalAmount.ToString();
                if (!ListPurchases[0].IsNetTransaction.Value)
                {
                    FillCreditor(ListPurchases[0].AccountNo);
                    CustEditBox.Visible = true;
                }
                else
                    CustEditBox.Visible = false;
                chkPosted.Checked = ListPurchases[0].Posted.Value;
              
                FillPurchases(ListPurchases);

                List<VoucherDetailEL> listTransactions = PManager.GetPurchasesSubTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, ListPurchases[0].IsNetTransaction.Value);

                FillHeadTransactions(listTransactions);               
            }
            else
            {
                MessageBox.Show("Voucher Number Not Found ...");
                ClearControls();
            }
        }
        private void FillPurchases(List<VoucherDetailEL> List)
        {
            if (grdProducts.Rows.Count > 0)
            {
                grdProducts.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {

                for (int i = 0; i < List.Count; i++)
                {
                    grdProducts.Rows.Add();
                    //DgvStockReceipt.Rows[i].Cells[0].Value = List[i].TransactionID;
                    grdProducts.Rows[i].Cells[0].Value = List[i].IdVoucherDetail;
                    grdProducts.Rows[i].Cells[1].Value = List[i].IdItem;
                    grdProducts.Rows[i].Cells[2].Value = List[i].BarCode;
                    grdProducts.Rows[i].Cells[3].Value = List[i].ItemName;
                    grdProducts.Rows[i].Cells[4].Value = List[i].PackingSize;
                    grdProducts.Rows[i].Cells[5].Value = CommonFunctions.RemoveTrailingZeros(List[i].Units);
                    grdProducts.Rows[i].Cells[6].Value = List[i].UnitPrice;
                    grdProducts.Rows[i].Cells[7].Value = List[i].Amount;
                }
            }
        }
        private void FillHeadTransactions(List<VoucherDetailEL> List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].TrackNumber == 1)
                {
                    if (CustEditBox.Visible)
                    {
                        SupplierTransactionId = List[i].IdTransactionDetail;
                        CustEditBox.Text = List[i].AccountName;
                        SupplierAccountNo = List[i].AccountNo;
                    }
                    else
                    {
                        CashTransactionId = List[i].IdTransactionDetail;
                        CashAccountNo = List[i].AccountNo;
                        FillCashAccounts(CashAccountNo);
                    }
                }
                else if (List[i].TrackNumber == 2)
                {
                    PurchasesTransactionId = List[i].IdTransactionDetail;
                    cbxNaturalAccounts.SelectedValue = List[i].AccountNo;
                    PurchasesAccountNo = List[i].AccountNo;
                }
                else if (List[i].TrackNumber == 3)
                {
                    PurchasesTaxTransactionId = List[i].IdTransactionDetail;
                    cbxTaxPayables.SelectedValue = List[i].AccountNo;
                    PurchasesTaxAccountNo = List[i].AccountNo;
                }
            }
        }
        private void FillCreditor(string AccountNo)
        {
            var manager = new PersonsBLL();
            List<PersonsEL> list = manager.GetPersonByAccount(Operations.IdProject, AccountNo);
            if (list.Count > 0)
            {
                //txtContact.Text = list[0].Contact;
                //txtCurrentBalance.Text = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, AccountNo)[0].TypedClosingBalance;
            }
        }
        #endregion
    }
}
