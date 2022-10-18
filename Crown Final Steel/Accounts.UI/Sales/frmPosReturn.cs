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
    public partial class frmPosReturn : Form
    {
        #region Variables
        int EnterCounter = 0;
        string CashRecievedAmount = string.Empty;
        frmFindAccounts frmfindAccounts;
        string CustomerAccountNo = string.Empty;
        string CashAccountNo = string.Empty;
        string SalesAccountNo = string.Empty;
        string SalesTaxAccountNo = string.Empty;
        frmPOSInfoDialogue frmposdialogue;
        Int64? IdVoucher = null;
        #endregion
        #region Form Methods And Events
        public frmPosReturn()
        {
            InitializeComponent();
        }
        private void frmPosReturn_Load(object sender, EventArgs e)
        {
            LoadAllItems();
            cbxPaymentMode.SelectedIndex = 0;
            toolStripBtnCashier.Text = Operations.UserName;
            cbxCustomerType.SelectedIndex = 0;
            FillData();
            FillSalesTaxAccounts(string.Empty);
            FillSalesAccounts(string.Empty);
            FillCashAccounts(string.Empty);
            CheckSoftwareCreditNature();
            CheckSoftwareTaxableNature();
        }
        #endregion
        #region Form Methods
        private void FillData()
        {
            var manager = new SalesHeadBLL();
            txtInvoiceNumber.Text = manager.GetMaxSalesReturnInvoiceNumberBySaleReturnType(Operations.IdProject, Operations.BookNo, true, 1).ToString();
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
        private void CheckSoftwareCreditNature()
        {
            SoftwareChecksEL oelSoftwareNatureCheck = DataOperations.SoftwareChecks.Find(x => x.SoftwareCheckName == "CreditSale");
            if (oelSoftwareNatureCheck != null)
            {
                if (!oelSoftwareNatureCheck.IsMust.Value)
                {
                    cbxCustomerType.Enabled = false;
                }
                else
                {
                    cbxCustomerType.Enabled = true;
                }
            }
            else
            {
                cbxCustomerType.Enabled = false;
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
        private void CalculateTax()
        {
            if (CheckSoftwareTaxableNature())
            {
                txtTotalTax.Text = Validation.GetSafeDecimal(XmlConfiguration.ReadXmlTaxConfiguration()[1]).ToString();
                txtTotalTaxAmount.Text = Validation.GetSafeString(((Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) * Validation.GetSafeDecimal(txtTotalTax.Text)) / 100).ToString("0.00"));
                txtInvoiceTotalWithTax.Text = Validation.GetSafeString((Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) + (Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text) * Validation.GetSafeDecimal(txtTotalTax.Text)) / 100).ToString("0.00"));
            }
        }
        private void FillSalesAccounts(string AccountNo)
        {
            var manager = new AccountsBLL();
            #region Fill Sales Account
            List<AccountsEL> list = manager.GetAccountsByType("Net Sales", Operations.IdCompany, Operations.IdProject);
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
            txtFreeVoucher.Text = string.Empty;
            txtInvoiceTotal.Text = string.Empty;
            txtInvoiceTotalAfterDiscount.Text = string.Empty;
            txtTotalTaxAmount.Text = string.Empty;
            txtInvoiceTotalWithTax.Text = string.Empty;
            txtCardNo.Text = string.Empty;
            txtCashRecieved.Text = string.Empty;
            txtBalance.Text = string.Empty;
            EnterCounter = 0;
            CashRecievedAmount = string.Empty;
            cbxProducts.Focus();
            if (CustEditBox.Visible)
            {
                CustomerAccountNo = string.Empty;
                CustEditBox.Text = string.Empty;
                CustEditBox.Visible = false;
            }
            IdVoucher = null;
        }
        #endregion
        #region Grid Events
        private void grdProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                e.Value = "-";
            }
            else if (e.ColumnIndex == 8)
            {
                e.Value = "+";
            }
            else if (e.ColumnIndex == 9)
            {
                e.Value = "Delete";
            }
        }
        private void grdProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal Amount = 0;
            decimal TotalQuantity = 0;
            if (e.ColumnIndex == 7)
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
            else if (e.ColumnIndex == 8)
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
            else if (e.ColumnIndex == 9)
            {
                DataGridViewRow ORow = grdProducts.Rows[e.RowIndex];
                grdProducts.Rows.Remove(ORow);
            }
            for (int i = 0; i < grdProducts.Rows.Count; i++)
            {
                Amount += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colAmount"].Value);
                TotalQuantity += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colQuantity"].Value);
            }
            txtTotalItems.Text = TotalQuantity.ToString(); ;
            txtInvoiceTotal.Text = Amount.ToString("0.00");
            txtInvoiceTotalAfterDiscount.Text = Amount.ToString("0.00");
            CalculateTax();
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
                if (CustomerAccountNo == string.Empty)
                {
                    MessageBox.Show("Customer Is Missing...");
                    return false;
                }
                else if (SalesAccountNo == string.Empty)
                {
                    MessageBox.Show("Sales Account Missing, Please Select...");
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
                else if (SalesAccountNo == string.Empty)
                {
                    MessageBox.Show("Sales Account Missing, Please Select...");
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
            frmposdialogue = new frmPOSInfoDialogue();
            List<VoucherDetailEL> oelSalesDetailCollection = new List<VoucherDetailEL>();
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
                        //if (!IdVoucher.HasValue)
                        {
                            oelVoucher.IdVoucher = 0;
                        }
                        //else
                        //{
                        //    oelVoucher.IdVoucher = IdVoucher;
                        //}
                        oelVoucher.IdUser = Operations.UserID;
                        oelVoucher.IdProject = Operations.IdProject;
                        oelVoucher.SheetNo = 0;
                        oelVoucher.BookNo = Operations.BookNo;
                        oelVoucher.TerminalNumber = Validation.GetSafeInteger(XmlConfiguration.ReadXmlTerminalsConfiguration()[0]);
                        oelVoucher.BiltyNo = string.Empty;
                        oelVoucher.SampleNo = 0;
                        oelVoucher.FirstName = string.Empty;
                        oelVoucher.Contact = string.Empty;
                        oelVoucher.Cnic = string.Empty;
                        oelVoucher.Address = string.Empty;
                        oelVoucher.SoftwareType = string.Empty;
                        if (CustEditBox.Visible)
                        {
                            oelVoucher.AccountNo = CustomerAccountNo;
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
                        oelVoucher.InWardGatePassNo = string.Empty;
                        oelVoucher.OutWardGatePassNo = string.Empty;
                        oelVoucher.VDate = VInvoiceDate.Value;
                        if (CustEditBox.Visible)
                        {
                            oelVoucher.ClosingBalance = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, CustomerAccountNo)[0].ClosingBalance;//CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, CustomerAccountNo)[0].ClosingBalance;  //Validation.GetSafeDecimal(txtCurrentBalance.Text);
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
                           // if (grdProducts.Rows[i].Cells["ColIdVoucherDetail"].Value != null)
                            //{
                                //oelPurchaseDetial.TransactionID = new Guid(DgvStockReceipt.Rows[i].Cells["ColTransaction"].Value.ToString());
                            //    oelSaleDetial.IdVoucherDetail = Validation.GetSafeLong(grdProducts.Rows[i].Cells["ColIdVoucherDetail"].Value.ToString());
                            //    oelSaleDetial.IsNew = false;
                            //}
                           // else
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

                            oelSalesDetailCollection.Add(oelSaleDetial);
                        }
                        #endregion
                        #region Add Products Profit & Loss

                        //for (int k = 0; k < grdProducts.Rows.Count; k++)
                        //{
                        //    var IManager = new ItemsBLL();
                        //    VoucherDetailEL oelProductsProfitLoss = new VoucherDetailEL();
                        //    oelProductsProfitLoss.IdItem = Validation.GetSafeLong(grdProducts.Rows[k].Cells["colIdItem"].Value);
                        //    oelProductsProfitLoss.NetSaleAmount = Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colAmount"].Value);
                        //    oelProductsProfitLoss.SaleCost = Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(oelProductsProfitLoss.IdItem.Value)) *
                        //                                             Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value);
                        //    oelProductsProfitLoss.Units = Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value);
                        //    oelProductsProfitLoss.NetProfit = oelProductsProfitLoss.NetSaleAmount - oelProductsProfitLoss.SaleCost;

                        //    oelProductsProfitLossCollection.Add(oelProductsProfitLoss);
                        //}

                        #endregion
                        #region Add Inventory And COGS Accounts
                        for (int k = 0; k < grdProducts.Rows.Count; k++)
                        {
                            var IManager = new ItemsBLL();
                            List<ItemsEL> EachItem = IManager.GetItemById(Validation.GetSafeLong(grdProducts.Rows[k].Cells["colIdItem"].Value));
                            if (oelCostOfSalesCollection.Count > 0)
                            {
                                VoucherDetailEL oelFindInventoryDetail = oelCostOfSalesCollection.Find(x => x.AccountNo == EachItem[0].InventoryAccount);
                                if (oelFindInventoryDetail != null)
                                {
                                    oelFindInventoryDetail.Debit += Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) *
                                                                     Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value); //EachItem[0].AVGEvaluationUnitPrice;
                                    //oelCostOfSalesCollection.Add(oelFindInventoryDetail);
                                }
                                else
                                {
                                    oelCostOfSalesCollection.Add(CreateInventoryTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value)));
                                }
                            }
                            else
                            {
                                oelCostOfSalesCollection.Add(CreateInventoryTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value)));
                            }
                            if (oelCostOfSalesCollection.Count > 0)
                            {
                                /// COGS
                                VoucherDetailEL oelFindCOGSDetail = oelCostOfSalesCollection.Find(x => x.AccountNo == EachItem[0].COGSAccount);
                                if (oelFindCOGSDetail != null)
                                {
                                    oelFindCOGSDetail.Credit += Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) *
                                                                     Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value); //EachItem[0].AVGEvaluationUnitPrice;
                                    //oelCostOfSalesCollection.Add(oelFindCOGSDetail);
                                }
                                else
                                {
                                    oelCostOfSalesCollection.Add(CreateCOGSTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value)));
                                }
                            }
                            else
                            {
                                oelCostOfSalesCollection.Add(CreateCOGSTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(grdProducts.Rows[k].Cells["colQuantity"].Value)));
                            }
                        }

                        #endregion
                        #region Add Customer
                        if (CustEditBox.Visible)
                        {
                            VoucherDetailEL oelCustomerTransaction = new VoucherDetailEL();
                            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "ItemWiseLederPrint");
                            //if (CustomerTransactionId.HasValue && CustomerTransactionId.Value > 0)
                            //{
                            //    oelCustomerTransaction.IdTransactionDetail = CustomerTransactionId.Value;
                            //    oelCustomerTransaction.IsNew = false;
                            //}
                            //else
                            //{
                                oelCustomerTransaction.IdTransactionDetail = 0;
                                oelCustomerTransaction.IsNew = true;
                            //}
                            oelCustomerTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                            oelCustomerTransaction.SeqNo = 1;
                            oelCustomerTransaction.TrackNumber = 1;
                            oelCustomerTransaction.IdProject = Operations.IdProject;
                            oelCustomerTransaction.BookNo = Operations.BookNo;
                            oelCustomerTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCustomerTransaction.AccountNo = CustomerAccountNo;
                            oelCustomerTransaction.SubAccountNo = "0";
                            oelCustomerTransaction.Date = VInvoiceDate.Value;
                            oelCustomerTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelCustomerTransaction.VoucherType = "SR";
                            oelCustomerTransaction.TransactionType = 1;
                            oelCustomerTransaction.TransactionMode = "CR";
                            if (oelSoftwareCheck != null && oelSoftwareCheck.IsMust.Value)
                            {
                                oelCustomerTransaction.Description = BuildRemarks(); //txtDescription.Text;
                            }
                            else
                            {
                                oelCustomerTransaction.Description = "Credit Sale Return From : " + CustEditBox.Text;
                            }
                            oelCustomerTransaction.Credit = Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount);
                            oelCustomerTransaction.Debit = 0;
                            oelCustomerTransaction.Posted = true;
                            oelCustomerTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelCustomerTransaction);

                        }
                        #endregion
                        #region Add Customer Sale Tax Transaction
                        if (CustEditBox.Visible && txtInvoiceTotalWithTax.Text != string.Empty && txtTotalTaxAmount.Text != string.Empty && txtTotalTax.Text != string.Empty)
                        {
                            VoucherDetailEL oelCustomerTaxTransaction = new VoucherDetailEL();
                            //if (CustomerTransactionId.HasValue && CustomerTransactionId.Value > 0)
                            //{
                            //    oelCustomerTransaction.IdTransactionDetail = CustomerTransactionId.Value;
                            //    oelCustomerTransaction.IsNew = false;
                            //}
                            //else
                            //{
                            oelCustomerTaxTransaction.IdTransactionDetail = 0;
                            oelCustomerTaxTransaction.IsNew = true;
                            //}
                            oelCustomerTaxTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                            oelCustomerTaxTransaction.SeqNo = 1;
                            oelCustomerTaxTransaction.TrackNumber = 1;
                            oelCustomerTaxTransaction.IdProject = Operations.IdProject;
                            oelCustomerTaxTransaction.BookNo = Operations.BookNo;
                            oelCustomerTaxTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCustomerTaxTransaction.AccountNo = CustomerAccountNo;
                            oelCustomerTaxTransaction.SubAccountNo = "0";
                            oelCustomerTaxTransaction.Date = VInvoiceDate.Value;
                            oelCustomerTaxTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelCustomerTaxTransaction.VoucherType = "SR";
                            oelCustomerTaxTransaction.TransactionType = 1;
                            oelCustomerTaxTransaction.TransactionMode = "CR";
                           

                            oelCustomerTaxTransaction.Description = "Sale Tax Transaction Return From  : " + CustEditBox.Text;

                            oelCustomerTaxTransaction.Credit = Validation.GetSafeDecimal(txtTotalTaxAmount.Text);

                            oelCustomerTaxTransaction.Debit = 0;
                            oelCustomerTaxTransaction.Posted = true;
                            oelCustomerTaxTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelCustomerTaxTransaction);

                        }
                        #endregion
                        #region Add Cash
                        if (!CustEditBox.Visible)
                        {
                            VoucherDetailEL oelCashTransaction = new VoucherDetailEL();
                            //if (CashTransactionId.HasValue && CashTransactionId.Value > 0)
                            //{
                            //    oelCashTransaction.IdTransactionDetail = CashTransactionId.Value;
                            //    oelCashTransaction.IsNew = false;
                            //}
                            //else
                            //{
                                oelCashTransaction.IdTransactionDetail = 0;
                                oelCashTransaction.IsNew = true;
                            //}
                            oelCashTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                            oelCashTransaction.SeqNo = 1;
                            oelCashTransaction.TrackNumber = 1;
                            oelCashTransaction.IdProject = Operations.IdProject;
                            oelCashTransaction.BookNo = Operations.BookNo;
                            oelCashTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCashTransaction.AccountNo = CashAccountNo;
                            oelCashTransaction.SubAccountNo = "0";
                            oelCashTransaction.Date = VInvoiceDate.Value;
                            oelCashTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelCashTransaction.VoucherType = "SR";
                            oelCashTransaction.TransactionType = 1;
                            oelCashTransaction.TransactionMode = "CR";
                           
                            oelCashTransaction.Description = "Counter Cash Sale Return";
                            oelCashTransaction.Credit = Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text);
                            oelCashTransaction.Debit = 0;
                            oelCashTransaction.Posted = true;
                            oelCashTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelCashTransaction);
                        }
                        #endregion
                        #region Add Cash Sale Tax Transaction
                        if (!CustEditBox.Visible && txtInvoiceTotalWithTax.Text != string.Empty && txtTotalTaxAmount.Text != string.Empty && txtTotalTax.Text != string.Empty)
                        {
                            VoucherDetailEL oelSaleTaxCashTransaction = new VoucherDetailEL();
                            //if (CashTransactionId.HasValue && CashTransactionId.Value > 0)
                            //{
                            //    oelCashTransaction.IdTransactionDetail = CashTransactionId.Value;
                            //    oelCashTransaction.IsNew = false;
                            //}
                            //else
                            //{
                                oelSaleTaxCashTransaction.IdTransactionDetail = 0;
                                oelSaleTaxCashTransaction.IsNew = true;
                            //}
                            oelSaleTaxCashTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                            oelSaleTaxCashTransaction.SeqNo = 1;
                            oelSaleTaxCashTransaction.TrackNumber = 1;
                            oelSaleTaxCashTransaction.IdProject = Operations.IdProject;
                            oelSaleTaxCashTransaction.BookNo = Operations.BookNo;
                            oelSaleTaxCashTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelSaleTaxCashTransaction.AccountNo = CashAccountNo;
                            oelSaleTaxCashTransaction.SubAccountNo = "0";
                            oelSaleTaxCashTransaction.Date = VInvoiceDate.Value;
                            oelSaleTaxCashTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelSaleTaxCashTransaction.VoucherType = "SR";
                            oelSaleTaxCashTransaction.TransactionType = 1;
                            oelSaleTaxCashTransaction.TransactionMode = "CR";
                           
                            oelSaleTaxCashTransaction.Description = "Counter Cash Sale";
                            oelSaleTaxCashTransaction.Credit = Convert.ToDecimal(txtTotalTaxAmount.Text);
                            oelSaleTaxCashTransaction.Debit = 0;
                            oelSaleTaxCashTransaction.Posted = true;
                            oelSaleTaxCashTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelSaleTaxCashTransaction);
                        }
                        #endregion
                        #region Add Sales Account In Transactions
                        /// Add Sales Account...
                        VoucherDetailEL oelSaleTransaction = new TransactionsEL();
                        //if (SalesTransactionId.HasValue && SalesTransactionId.Value > 0)
                        //{
                        //    oelSaleTransaction.IdTransactionDetail = SalesTransactionId.Value;
                        //    oelSaleTransaction.IsNew = false;
                        //}
                        //else
                        //{
                            oelSaleTransaction.IdTransactionDetail = 0;
                            oelSaleTransaction.IsNew = true;
                        //}
                        oelSaleTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                        oelSaleTransaction.SeqNo = 2;
                        oelSaleTransaction.TrackNumber = 2;
                        oelSaleTransaction.IdProject = Operations.IdProject;
                        oelSaleTransaction.BookNo = Operations.BookNo;
                        oelSaleTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                        oelSaleTransaction.IdVoucher = oelVoucher.IdVoucher;
                        //oelPurchaseTransaction.AccountNo = Validation.GetSafeLong(PurchasesEditBox.Text);
                        oelSaleTransaction.AccountNo = SalesAccountNo;
                        oelSaleTransaction.SubAccountNo = "0";
                        oelSaleTransaction.Date = VInvoiceDate.Value;
                        oelSaleTransaction.VoucherType = "SR";
                        oelSaleTransaction.TransactionType = 2;
                        if(CustEditBox.Visible)
                            oelSaleTransaction.Description = "Credit Sale To : " + CustEditBox.Text;
                        else
                            oelSaleTransaction.Description = "Sales Account Debit In Sales Return";
                        oelSaleTransaction.Debit = Validation.GetSafeDecimal(txtInvoiceTotal.Text);
                        oelSaleTransaction.Credit = 0;
                        oelSaleTransaction.TransactionMode = "DR";
                        oelSaleTransaction.CreatedDateTime = VInvoiceDate.Value;
                        oelSaleTransaction.Posted = true;

                        oelCostOfSalesCollection.Add(oelSaleTransaction);
                        #endregion region
                        #region Add Sale Tax Transaction
                        if (CustEditBox.Visible && txtInvoiceTotalWithTax.Text != string.Empty && txtTotalTaxAmount.Text != string.Empty && txtTotalTax.Text != string.Empty)
                        {
                            VoucherDetailEL oelSaleTaxTransaction = new VoucherDetailEL();
                            //if (CustomerTransactionId.HasValue && CustomerTransactionId.Value > 0)
                            //{
                            //    oelCustomerTransaction.IdTransactionDetail = CustomerTransactionId.Value;
                            //    oelCustomerTransaction.IsNew = false;
                            //}
                            //else
                            //{
                            oelSaleTaxTransaction.IdTransactionDetail = 0;
                            oelSaleTaxTransaction.IsNew = true;
                            //}
                            oelSaleTaxTransaction.IsNetTransaction = CustEditBox.Visible ? false : true;
                            oelSaleTaxTransaction.SeqNo = 1;
                            oelSaleTaxTransaction.TrackNumber = 1;
                            oelSaleTaxTransaction.IdProject = Operations.IdProject;
                            oelSaleTaxTransaction.BookNo = Operations.BookNo;
                            oelSaleTaxTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelSaleTaxTransaction.AccountNo = SalesTaxAccountNo;
                            oelSaleTaxTransaction.SubAccountNo = "0";
                            oelSaleTaxTransaction.Date = VInvoiceDate.Value;
                            oelSaleTaxTransaction.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
                            oelSaleTaxTransaction.VoucherType = "SR";
                            oelSaleTaxTransaction.TransactionType = 1;
                            oelSaleTaxTransaction.TransactionMode = "CR";


                            oelSaleTaxTransaction.Description = "Sale Tax Transaction";

                            oelSaleTaxTransaction.Credit = Validation.GetSafeDecimal(txtTotalTaxAmount.Text);

                            oelSaleTaxTransaction.Debit = 0;
                            oelSaleTaxTransaction.Posted = true;
                            oelSaleTaxTransaction.CreatedDateTime = VInvoiceDate.Value;

                            oelCostOfSalesCollection.Add(oelSaleTaxTransaction);

                        }
                        #endregion
                        #region Saving Code
                        if (IdVoucher == null || IdVoucher == 0)
                        {
                            var manager = new SalesHeadBLL();

                            EntityoperationInfo infoResult = manager.InsertSalesReturn(oelVoucher, oelSalesDetailCollection, oelCostOfSalesCollection);
                            if (infoResult.IsSuccess)
                            {
                                txtInvoiceNumber.Text = infoResult.VoucherNo.ToString();
                                IdVoucher = infoResult.IntID;
                                if (!chkNoPrint.Checked)
                                {
                                    PrintReport(IdVoucher.Value);
                                }
                                FillData();
                                frmposdialogue.TotalItems = txtTotalItems.Text;
                                frmposdialogue.InvoiceTotal = txtInvoiceTotal.Text;
                                frmposdialogue.CashRecieved = txtCashRecieved.Text;
                                frmposdialogue.BalanceAmount = txtBalance.Text;
                                if (frmposdialogue.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                                {
                                    ClearControls();
                                }
                            }
                        }
                        //else
                        //{
                        //    var manager = new SalesHeadBLL();
                        //    EntityoperationInfo infoResult = manager.UpdateSales(oelVoucher, oelSalesDetailCollection, oelProductsProfitLossCollection, oelCostOfSalesCollection);
                        //    if (infoResult.IsSuccess)
                        //    {
                        //        MessageBox.Show("Recorded Sales Updated Successfully...");
                        //        ClearControls();
                        //        //FillData();
                        //    }
                        //}
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
        private VoucherDetailEL CreateInventoryTransaction(VouchersEL oelVoucher, List<ItemsEL> EachItem, decimal Quantity)
        {
            VoucherDetailEL oelInventoryVoucherDetail = new VoucherDetailEL();
            var manager = new ItemsBLL();
            oelInventoryVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
            oelInventoryVoucherDetail.IdProject = Operations.IdProject;
            oelInventoryVoucherDetail.BookNo = Operations.BookNo;
            oelInventoryVoucherDetail.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
            oelInventoryVoucherDetail.IdTransactionDetail = 0;
            oelInventoryVoucherDetail.IsNew = true;
            //if (DgvSalesTransactions.Rows[k].Cells["ColIdDetailVoucher"].Value != null)
            //{
            //    oelVoucherDetail.IdTransactionDetail = Validation.GetSafeLong(DgvSalesTransactions.Rows[k].Cells["ColIdDetailVoucher"].Value.ToString());
            //    oelVoucherDetail.IsNew = false;
            //}
            //else
            //{
            //    oelVoucherDetail.IdTransactionDetail = 0;
            //    oelVoucherDetail.IsNew = true;

            //}
            oelInventoryVoucherDetail.SheetNo = 0;

            oelInventoryVoucherDetail.Description = "Inventory Debit";
            oelInventoryVoucherDetail.IsNetTransaction = CustEditBox.Visible ? false : true;
            oelInventoryVoucherDetail.SeqNo = 0;
            oelInventoryVoucherDetail.TrackNumber = 0;
            oelInventoryVoucherDetail.VoucherType = "SR";
            oelInventoryVoucherDetail.AccountNo = Validation.GetSafeString(EachItem[0].InventoryAccount);
            oelInventoryVoucherDetail.Debit = Validation.GetSafeDecimal(manager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) * Quantity; //EachItem[0].AVGEvaluationUnitPrice);
            oelInventoryVoucherDetail.Credit = 0;
            oelInventoryVoucherDetail.TransactionMode = "DR";
            oelInventoryVoucherDetail.Posted = true;
            oelInventoryVoucherDetail.CreatedDateTime = VInvoiceDate.Value;

            return oelInventoryVoucherDetail;
        }
        private VoucherDetailEL CreateCOGSTransaction(VouchersEL oelVoucher, List<ItemsEL> EachItem, decimal Quantity)
        {
            var manager = new ItemsBLL();
            VoucherDetailEL oelCOGSVoucherDetail = new VoucherDetailEL();
            oelCOGSVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
            oelCOGSVoucherDetail.IdProject = Operations.IdProject;
            oelCOGSVoucherDetail.BookNo = Operations.BookNo;
            oelCOGSVoucherDetail.VoucherNo = Validation.GetSafeLong(txtInvoiceNumber.Text);
            oelCOGSVoucherDetail.IdTransactionDetail = 0;
            oelCOGSVoucherDetail.IsNew = true;
            //if (DgvSalesTransactions.Rows[k].Cells["ColIdDetailVoucher"].Value != null)
            //{
            //    oelVoucherDetail.IdTransactionDetail = Validation.GetSafeLong(DgvSalesTransactions.Rows[k].Cells["ColIdDetailVoucher"].Value.ToString());
            //    oelVoucherDetail.IsNew = false;
            //}
            //else
            //{
            //    oelVoucherDetail.IdTransactionDetail = 0;
            //    oelVoucherDetail.IsNew = true;

            //}
            oelCOGSVoucherDetail.IsNetTransaction = CustEditBox.Visible ? false : true;
            oelCOGSVoucherDetail.SheetNo = 0;


            oelCOGSVoucherDetail.Description = "COGS Credit";


            oelCOGSVoucherDetail.VoucherType = "SR";
            oelCOGSVoucherDetail.AccountNo = Validation.GetSafeString(EachItem[0].COGSAccount);
            oelCOGSVoucherDetail.Credit = Validation.GetSafeDecimal(manager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) * Quantity;//EachItem[0].AVGEvaluationUnitPrice);
            oelCOGSVoucherDetail.Debit = 0;
            oelCOGSVoucherDetail.TransactionMode = "CR";
            oelCOGSVoucherDetail.Posted = true;
            oelCOGSVoucherDetail.CreatedDateTime = VInvoiceDate.Value;

            return oelCOGSVoucherDetail;
        }
        private void PrintReport(Int64 IdVoucher)
        {
            //LocalReport rptInvoice = new LocalReport();
            //var Manager = new SalesHeadBLL();
            //ReportDataSource reportRDS = new ReportDataSource("dtReport", Manager.GetRdlcSalesTransactions(IdVoucher, Operations.IdProject, Operations.BookNo, CustEditBox.Visible ? false : true).Tables[0]);
            //rptInvoice.ReportPath = "..//..//POSInvoices/SampleRDLCCheck.rdlc";
            //rptInvoice.DataSources.Clear();
            //rptInvoice.DataSources.Add(reportRDS);
            //LocalReportExtensions.PrintToPrinter(rptInvoice);
        }
        #endregion
        #region CumboBox Methods And Events
        private void cbxNaturalAccounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxNaturalAccounts.SelectedIndex > 0)
            {
                SalesAccountNo = Validation.GetSafeString(cbxNaturalAccounts.SelectedValue);
            }
            else
            {
                SalesAccountNo = string.Empty;
            }
        }
        private void cbxTaxPayables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTaxPayables.SelectedIndex > 0)
            {
                SalesTaxAccountNo = Validation.GetSafeString(cbxTaxPayables.SelectedValue);
            }
            else
            {
                SalesTaxAccountNo = string.Empty;
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
            if (cbxCustomerType.SelectedIndex == 1)
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
                        txtCashRecieved.Focus();
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
                if (cbxCustomerType.Text == "Credit Customer")
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

                e.Handled = true;
                frmfindAccounts = new frmFindAccounts();
                frmfindAccounts.SearchText = e.KeyChar.ToString();
                frmfindAccounts.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmfindAccounts_ExecuteFindAccountEvent);
                frmfindAccounts.ShowDialog();

            }
            else
                e.Handled = false;
        }
        void frmfindAccounts_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            CustomerAccountNo = oelAccount.AccountNo;
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
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colUnitPrice"].Value = list[0].MRP;
                    grdProducts.Rows[grdProducts.Rows.Count - 1].Cells["colAmount"].Value = 1 * list[0].MRP;
                }
                for (int i = 0; i < grdProducts.Rows.Count; i++)
                {
                    Amount += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colAmount"].Value);
                    TotalQuantity += Validation.GetSafeDecimal(grdProducts.Rows[i].Cells["colQuantity"].Value);
                }
                txtTotalItems.Text = TotalQuantity.ToString(); ;
                txtInvoiceTotal.Text = Amount.ToString("0.00");
                txtInvoiceTotalAfterDiscount.Text = Amount.ToString("0.00");
                CalculateTax();
            }
        }
        #endregion
        #region Invoice Calculation Fields Methods And Events
        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtInvoiceTotalAfterDiscount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(txtInvoiceTotal.Text) - Validation.GetSafeDecimal(txtDiscount.Text));
                txtTotalTax.Focus();
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
                txtCardNo.Focus();
            }
        }
        private void txtTotalTax_Enter(object sender, EventArgs e)
        {
            txtTotalTax.Text = string.Empty;
        }
        private void txtCardNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtCashRecieved.Focus();
            }
        }
        private void txtCashRecieved_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                if (!char.IsNumber(e.KeyChar))
                {
                    e.Handled = true;
                    if (txtCashRecieved.Text != string.Empty)
                    {
                        if (txtInvoiceTotalWithTax.Text != string.Empty)
                        {
                            txtBalance.Text = CommonFunctions.RemoveTrailingZeros(Validation.GetSafeDecimal(txtCashRecieved.Text) - Validation.GetSafeDecimal(txtInvoiceTotalWithTax.Text));
                        }
                        else
                        {
                            txtBalance.Text = CommonFunctions.RemoveTrailingZeros(Validation.GetSafeDecimal(txtCashRecieved.Text) - Validation.GetSafeDecimal(txtInvoiceTotalAfterDiscount.Text));
                        }
                        CashRecievedAmount = string.Empty;
                        btnSave.Focus();
                    }
                }
                else
                    e.Handled = false;
            }
            else
            {
                e.Handled = false;
                CashRecievedAmount += e.KeyChar;
            }
        }
        #endregion
    }
}
