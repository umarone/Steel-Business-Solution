using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.EL;
using Accounts.BLL;
using Accounts.Common;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmOutSourceWork : MetroForm
    {
        #region Variables
        frmAccounts frmaccounts;
        frmFindAccounts frmAccount;
        frmFindProducts frmfindProducts;
        frmFindVouchers frmfindVouchers;
        frmAuthentication frmauthentication;
        frmPersons frmpersons;
        frmPurchasePrintReport frmpurchaseprintreport;
        public decimal OldValue { get; set; }
        public Int64 VoucherNo { get; set; }
        Int64? IdVoucher = null;
        public Int64? SupplierTransactionId { get; set; }
        public Int64? CashTransactionId { get; set; }
        public Int64? PurchasesTransactionId { get; set; }
        public int OutSourceWorkNature { get; set; }
        public string VoucherType { get; set; }
        string EventCommandName = string.Empty;
        int EventTime = 0;
        public bool IsNetTransaction { get; set; }
        public bool IsImportTransaction { get; set; }
        TextBox txtDebit = new TextBox();
        TextBox txtCredit = new TextBox();
        string SupplierAccountNo = "", PurchasesAccountNo = "", CashAccountNo = "";
        #endregion
        #region Form Methods And Events
        public frmOutSourceWork()
        {
            InitializeComponent();
        }
        private void frmOutSourceWork_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DgvStockReceipt.AutoGenerateColumns = false;
            this.grdExpectedProducts.AutoGenerateColumns = false;
            txtBillNo.Text = "0";
            FillData();
            //ShowHideColumns();
            if (OutSourceWorkNature == 1)
            {
                this.Text = "OutSource Work Issuance";
            }
            else
            {
                this.Text = "OutSource Work Receiving";
                groupBox2.Text = "Recieved Finished Goods From Vendor";
            }
            ShowHidePanels();
            if (OutSourceWorkNature == 2)
            {
                FillNaturalAccounts(string.Empty);
            }
            CheckModulePermissions();
            FillOutSourceWorkTypes();
            FillTotalVouchers();
            GetLastVoucherTransactionByType();

        }
        private void frmOutSourceWork_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                if (IdVoucher != null && IdVoucher > 0)
                {
                    ClearControls();
                    if (DgvStockReceipt.Rows.Count > 0)
                    {
                        DgvStockReceipt.Rows.Clear();
                    }
                    FillData();
                }
                else
                    this.Close();
            }
        }
        #endregion
        #region Simple Methods
        private void FillOutSourceWorkTypes()
        {
            var manager = new OutSourceWorkTypeBLL();
            List<OutSourceWorkTypeEL> list = manager.GetAllOutSourceWorkTypes(Operations.IdProject);
            if (list.Count > 0)
            {
                list.Insert(0, new OutSourceWorkTypeEL { IdOutSourceWorkType = 0, OutSourceWorkTypeName = "Select Work Type" });

                cbxOutSourceWorkTypes.DataSource = list;
                cbxOutSourceWorkTypes.DisplayMember = "OutSourceWorkTypeName";
                cbxOutSourceWorkTypes.ValueMember = "IdOutSourceWorkType";

                cbxOutSourceWorkTypes.SelectedIndex = 0;
            }
        }
        private void ShowHidePanels()
        {
            if (OutSourceWorkNature == 1)
            {
                lblDebitAccount.Visible = false;
                cbxNaturalAccounts.Visible = false;
                pnlRates.Visible = false;
            }
            else
            {
                pnlMaterialToBeSend.Visible = false;
                lblDebitAccount.Visible = true;
                cbxNaturalAccounts.Visible = true;
            }
        }
        private void ShowHideColumns()
        {
            List<SoftwareTypesEL> list = DataOperations.SoftwareTypes;
            if (list.Count > 0)
            {
                SoftwareTypesEL objActiveType = list.Find(x => x.ActiveSoftware == true);
                if (objActiveType != null)
                {
                    if (objActiveType.SoftwareType == "General Trading")
                    {
                        DgvStockReceipt.Columns["colEngineNo"].Visible = false;
                        DgvStockReceipt.Columns["colChassisNo"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleNo"].Visible = false;
                        DgvStockReceipt.Columns["colBatchNo"].Visible = false;
                        DgvStockReceipt.Columns["colExpiry"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleModel"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleColors"].Visible = false;
                        DgvStockReceipt.Columns["colFirstIMEI"].Visible = false;
                        DgvStockReceipt.Columns["colSecondIMEI"].Visible = false;

                        DgvStockReceipt.Columns["colItemName"].Width = 280;
                        DgvStockReceipt.Columns["colpacking"].Width = 90;
                        DgvStockReceipt.Columns["colQty"].Width = 80;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 90;
                    }
                    else if (objActiveType.SoftwareType == "POS")
                    {
                        DgvStockReceipt.Columns["colpacking"].Visible = false;
                        DgvStockReceipt.Columns["colCartons"].Visible = false;
                        DgvStockReceipt.Columns["colEngineNo"].Visible = false;
                        DgvStockReceipt.Columns["colChassisNo"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleNo"].Visible = false;
                        DgvStockReceipt.Columns["colBatchNo"].Visible = false;
                        DgvStockReceipt.Columns["colExpiry"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleModel"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleColors"].Visible = false;
                        DgvStockReceipt.Columns["colFirstIMEI"].Visible = false;
                        DgvStockReceipt.Columns["colSecondIMEI"].Visible = false;
                        DgvStockReceipt.Columns["colDelete"].Visible = false;

                        DgvStockReceipt.Columns["colItemName"].Width = 400;
                        DgvStockReceipt.Columns["colQty"].Width = 170;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 170;
                        DgvStockReceipt.Columns["colAmount"].Width = 170;
                    }
                    else if (objActiveType.SoftwareType == "Motor Bikes")
                    {
                        DgvStockReceipt.Columns["colpacking"].Visible = false;
                        DgvStockReceipt.Columns["colCartons"].Visible = false;
                        DgvStockReceipt.Columns["colBatchNo"].Visible = false;
                        DgvStockReceipt.Columns["colExpiry"].Visible = false;
                        DgvStockReceipt.Columns["colFirstIMEI"].Visible = false;
                        DgvStockReceipt.Columns["colSecondIMEI"].Visible = false;

                        DgvStockReceipt.Columns["colItemName"].Width = 250;
                    }
                    else if (objActiveType.SoftwareType == "Motor Cars")
                    {
                        DgvStockReceipt.Columns["colpacking"].Visible = false;
                        DgvStockReceipt.Columns["colCartons"].Visible = false;
                        DgvStockReceipt.Columns["colBatchNo"].Visible = false;
                        DgvStockReceipt.Columns["colExpiry"].Visible = false;
                        DgvStockReceipt.Columns["colFirstIMEI"].Visible = false;
                        DgvStockReceipt.Columns["colSecondIMEI"].Visible = false;

                        DgvStockReceipt.Columns["colItemName"].Width = 250;
                    }
                    else if (objActiveType.SoftwareType == "Medicine Trading")
                    {
                        DgvStockReceipt.Columns["colCartons"].Visible = false;
                        DgvStockReceipt.Columns["colEngineNo"].Visible = false;
                        DgvStockReceipt.Columns["colChassisNo"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleNo"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleModel"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleColors"].Visible = false;
                        DgvStockReceipt.Columns["colFirstIMEI"].Visible = false;
                        DgvStockReceipt.Columns["colSecondIMEI"].Visible = false;


                        DgvStockReceipt.Columns["colItemName"].Width = 240;
                        DgvStockReceipt.Columns["colExpiry"].Width = 80;
                        DgvStockReceipt.Columns["colBatchNo"].Width = 80;
                        DgvStockReceipt.Columns["colDiscount"].Width = 90;
                        DgvStockReceipt.Columns["colDiscountAmount"].Width = 90;
                    }
                    else if (objActiveType.SoftwareType == "Medicine POS")
                    {
                        DgvStockReceipt.Columns["colpacking"].Visible = false;
                        DgvStockReceipt.Columns["colCartons"].Visible = false;
                        DgvStockReceipt.Columns["colEngineNo"].Visible = false;
                        DgvStockReceipt.Columns["colChassisNo"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleNo"].Visible = false;
                        DgvStockReceipt.Columns["colBatchNo"].Visible = false;
                        DgvStockReceipt.Columns["colExpiry"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleModel"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleColors"].Visible = false;
                        DgvStockReceipt.Columns["colFirstIMEI"].Visible = false;
                        DgvStockReceipt.Columns["colSecondIMEI"].Visible = false;
                    }
                    else if (objActiveType.SoftwareType == "Mobile Soft")
                    {
                        DgvStockReceipt.Columns["colpacking"].Visible = true;
                        DgvStockReceipt.Columns["colCartons"].Visible = false;
                        DgvStockReceipt.Columns["colEngineNo"].Visible = false;
                        DgvStockReceipt.Columns["colChassisNo"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleNo"].Visible = false;
                        DgvStockReceipt.Columns["colBatchNo"].Visible = false;
                        DgvStockReceipt.Columns["colExpiry"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleModel"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleColors"].Visible = false;
                        DgvStockReceipt.Columns["colSecondIMEI"].Visible = false;

                        DgvStockReceipt.Columns["colItemName"].Width = 280;
                    }
                    if (objActiveType.SoftwareType == "Distribution Trading")
                    {
                        DgvStockReceipt.Columns["colEngineNo"].Visible = false;
                        DgvStockReceipt.Columns["colChassisNo"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleNo"].Visible = false;
                        DgvStockReceipt.Columns["colBatchNo"].Visible = false;
                        DgvStockReceipt.Columns["colExpiry"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleModel"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleColors"].Visible = false;
                        DgvStockReceipt.Columns["colFirstIMEI"].Visible = false;
                        DgvStockReceipt.Columns["colSecondIMEI"].Visible = false;

                        DgvStockReceipt.Columns["colItemName"].Width = 280;
                        DgvStockReceipt.Columns["colpacking"].Width = 90;
                        DgvStockReceipt.Columns["colQty"].Width = 80;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 90;
                    }
                    else if (objActiveType.SoftwareType == "Labs Materials Trading")
                    {
                        DgvStockReceipt.Columns["colCartons"].Visible = false;
                        DgvStockReceipt.Columns["colEngineNo"].Visible = false;
                        DgvStockReceipt.Columns["colChassisNo"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleNo"].Visible = false;
                        DgvStockReceipt.Columns["colBatchNo"].Visible = false;
                        DgvStockReceipt.Columns["colExpiry"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleModel"].Visible = false;
                        DgvStockReceipt.Columns["colVehicleColors"].Visible = false;
                        DgvStockReceipt.Columns["colFirstIMEI"].Visible = false;
                        DgvStockReceipt.Columns["colSecondIMEI"].Visible = false;

                        DgvStockReceipt.Columns["colItemName"].Width = 380;
                        DgvStockReceipt.Columns["colpacking"].Width = 90;
                        DgvStockReceipt.Columns["colQty"].Width = 80;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 90;
                    }
                }
            }
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
        private void FillCreditor(string AccountNo)
        {
            var manager = new PersonsBLL();
            List<PersonsEL> list = manager.GetPersonByAccount(Operations.IdProject, AccountNo);
            if (list.Count > 0)
            {
                if (IdVoucher != null && IdVoucher > 0)
                {
                    if(OutSourceWorkNature == 2)
                    txtCurrentBalance.Text = txtTotalAmount.Text + " CR";
                    else
                        txtCurrentBalance.Text = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, AccountNo)[0].TypedClosingBalance;
                }
                else
                {
                    txtCurrentBalance.Text = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, AccountNo)[0].TypedClosingBalance;   
                }
            }
        }
        private void FillData()
        {
            var manager = new OutSourceWorkHeadBLL();
            VEditBox.Text = Validation.GetSafeString(manager.GetMaxOutSourceWorkNumber(Operations.IdProject, Operations.BookNo, OutSourceWorkNature));
        }
        private void FillTotalVouchers()
        {
            var Manager = new VoucherBLL();
            lblTotalVouchers.Text = Manager.GetAllStockTotalTransactionalVouchersByType(Operations.IdProject, Operations.BookNo, VoucherTypes.StockReceiptVoucher.ToString(), IsNetTransaction).ToString();
        }
        private void GetLastVoucherTransactionByType()
        {
            var Manager = new VoucherBLL();
            List<VouchersEL> listLast = Manager.GetStockLastVoucherTransactionByType(Operations.IdProject, Operations.BookNo, VoucherTypes.StockReceiptVoucher.ToString(), IsNetTransaction);
            if (listLast != null && listLast.Count > 0)
            {
                lblLastVoucherNo.Text = listLast[0].VoucherNo.ToString();
            }
        }
        private void FillNaturalAccounts(string AccountNo)
        {
            var manager = new AccountsBLL();
            #region Fill Inventory Account
            List<AccountsEL> list = manager.GetAccountsByType("Inventory Accounts", Operations.IdCompany, Operations.IdProject);
            if (AccountNo == "")
            {
                if (list.Count > 0)
                {
                    cbxNaturalAccounts.DataSource = list;
                    list.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "" });

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
        private void ClearControls()
        {
            VDate.Value = DateTime.Now;
            DgvStockReceipt.Rows.Clear();
            grdExpectedProducts.Rows.Clear();
            //txtDescription.Text = string.Empty;
            VoucherNo = 0;
            IdVoucher = 0;
            VEditBox.Text = string.Empty;
            VEditBox.Enabled = true;
            txtDescription.Text = string.Empty;

            txtBillAmount.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;

            SupplierTransactionId = null;
            PurchasesTransactionId = null;
            CashTransactionId = null;

            SEditBox.Text = string.Empty;
            txtBillNo.Text = "0";
            lblStatuMessage.Text = string.Empty;
            //if (chkPosted.Checked)
            //{
            //    chkPosted.Checked = false;
            //    chkPosted.Enabled = true;
            //}
            PurchasesAccountNo = string.Empty;
            SupplierAccountNo = string.Empty;



            txtCurrentBalance.Text = string.Empty;
            txtBillNo.Text = string.Empty;

            cbxNaturalAccounts.SelectedIndex = -1;
            cbxOutSourceWorkTypes.SelectedIndex = 0;
        }
        private bool ValidateRows()
        {

            for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
            {
                if (DgvStockReceipt.Rows[i].Cells["colQty"].Value == null)
                {
                    return false;
                }
                else if (DgvStockReceipt.Rows[i].Cells["colUnitPrice"].Value == null)
                {
                    return false;
                }
            }
            return true;
        }
        private bool ValidateControls()
        {
            if (OutSourceWorkNature == 1)
            {
                if (SupplierAccountNo == string.Empty)
                {
                    MessageBox.Show("Vendor Is Missing...");
                    return false;
                }
            }
            else if (OutSourceWorkNature == 2)
            {
                if (SupplierAccountNo == string.Empty)
                {
                    MessageBox.Show("Vendor Is Missing...");
                    return false;
                }
                if (PurchasesAccountNo == string.Empty)
                {
                    MessageBox.Show("Purchase Account Missing, Please Select...");
                    return false;
                }
            }
            if (cbxOutSourceWorkTypes.SelectedIndex == 0 || cbxOutSourceWorkTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Work Type To Send OR Recieve....");
                return false;
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
                    if (VDate.Value.Year == FirstYear || VDate.Value.Year == SecondYear)
                    {
                        if (VDate.Value.Month < FirstMonth && VDate.Value.Year == FirstYear)
                        {
                            Status = false;
                        }
                        else if (VDate.Value.Month > SecondMonth && VDate.Value.Year == SecondYear)
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
        private string BuildRemarks()
        {
            string Remarks = "";
            string First = txtDescription.Text == string.Empty ? "Follow Are OutSource From " + SEditBox.Text + "~" : txtDescription.Text + "~";
            for (int i = 0; i < grdExpectedProducts.Rows.Count - 1; i++)
            {
                Remarks += grdExpectedProducts.Rows[i].Cells[2].Value.ToString() + " - "
                           + grdExpectedProducts.Rows[i].Cells[4].Value.ToString() + "Units"
                           + "@" + grdExpectedProducts.Rows[i].Cells[6].Value.ToString() + "~";
            }
            First += Remarks;
            return First;
        }
        #endregion
        #region Buttons Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Variables
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            List<StockReceiptEL> oelStockReceiptCollection = new List<StockReceiptEL>();
            List<VoucherDetailEL> oelOutSourceWorkDetailCollection = new List<VoucherDetailEL>();
            List<VoucherDetailEL> oelCostOfSalesCollection = new List<VoucherDetailEL>();
            List<ItemsEL> oelItemsCollection = new List<ItemsEL>();
            #endregion
            #region Main Content
            if (ValidateRows())
            {
                if (ValidateControls())
                {
                    if (ValidateBookPeriod())
                    {
                        /// Add Voucher...
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
                        oelVoucher.BiltyNo = Validation.GetSafeString(txtBiltyNo.Text);
                        oelVoucher.OutSourceWorkType = Validation.GetSafeInteger(cbxOutSourceWorkTypes.SelectedValue);
                        oelVoucher.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                        oelVoucher.AccountNo = SupplierAccountNo;
                        oelVoucher.OutSourceWork = OutSourceWorkNature;
                        oelVoucher.SubAccountNo = "0";
                        oelVoucher.BillNo = txtBillNo.Text;
                        oelVoucher.VDate = VDate.Value;
                        oelVoucher.DueDate = VDueDate.Value;
                        oelVoucher.Discription = Validation.GetSafeString(txtDescription.Text);
                        oelVoucher.BillAmount = Validation.GetSafeDecimal(txtBillAmount.Text);
                        oelVoucher.TotalFreight = Validation.GetSafeDecimal(txtFreightAmount.Text);
                        oelVoucher.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                        oelVoucher.VAT = 0;//Validation.GetSafeInteger(txtVat.Text);
                        oelVoucher.VATAmount = 0;//Validation.GetSafeDecimal(txtTotalAmount.Text);
                        oelVoucher.Posted = chkPosted.Checked;
                        #endregion
                        #region Add Raw Material Stock
                        for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                        {
                            VoucherDetailEL oelRawMaterialDetail = new VoucherDetailEL();
                            ItemsEL oelItem = new ItemsEL();
                            if (DgvStockReceipt.Rows[i].Cells["ColIdVoucherDetail"].Value != null)
                            {
                                //oelPurchaseDetial.TransactionID = new Guid(DgvStockReceipt.Rows[i].Cells["ColTransaction"].Value.ToString());
                                oelRawMaterialDetail.IdVoucherDetail = Validation.GetSafeLong(DgvStockReceipt.Rows[i].Cells["ColIdVoucherDetail"].Value.ToString());
                                oelRawMaterialDetail.IsNew = false;
                            }
                            else
                            {
                                oelRawMaterialDetail.IdVoucherDetail = 0;
                                //  oelPurchaseDetial.TransactionID = Guid.NewGuid();
                                oelRawMaterialDetail.IsNew = true;
                            }
                            oelRawMaterialDetail.SeqNo = i + 1;
                            oelRawMaterialDetail.IdVoucher = oelVoucher.IdVoucher;
                            oelRawMaterialDetail.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                            oelRawMaterialDetail.IdItem = Validation.GetSafeLong(DgvStockReceipt.Rows[i].Cells["colIdItem"].Value);
                            oelRawMaterialDetail.OutSourceWork = 1;
                            oelRawMaterialDetail.PackingSize = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colpacking"].Value);
                            oelRawMaterialDetail.Discription = "N/A"; //Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colRemarks"].Value);

                            oelRawMaterialDetail.CurrentStock = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colCurrentStock"].Value);
                            oelRawMaterialDetail.Units = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colQty"].Value);
                            oelRawMaterialDetail.UnitPrice = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colUnitPrice"].Value);
                            oelItem.CurrentUnitPrice = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colUnitPrice"].Value);
                            oelRawMaterialDetail.Amount = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);

                            oelOutSourceWorkDetailCollection.Add(oelRawMaterialDetail);
                        }
                        #endregion
                        #region Add Finished Goods Material Stock
                        for (int i = 0; i < grdExpectedProducts.Rows.Count - 1; i++)
                        {
                            VoucherDetailEL oelFinishedMaterialDetail = new VoucherDetailEL();
                            ItemsEL oelItem = new ItemsEL();
                            if (grdExpectedProducts.Rows[i].Cells["colInIdVoucherDetail"].Value != null)
                            {
                                //oelPurchaseDetial.TransactionID = new Guid(DgvStockReceipt.Rows[i].Cells["ColTransaction"].Value.ToString());
                                oelFinishedMaterialDetail.IdVoucherDetail = Validation.GetSafeLong(grdExpectedProducts.Rows[i].Cells["colInIdVoucherDetail"].Value.ToString());
                                oelFinishedMaterialDetail.IsNew = false;
                            }
                            else
                            {
                                oelFinishedMaterialDetail.IdVoucherDetail = 0;
                                //  oelPurchaseDetial.TransactionID = Guid.NewGuid();
                                oelFinishedMaterialDetail.IsNew = true;
                            }
                            oelFinishedMaterialDetail.SeqNo = i + 1;
                            oelFinishedMaterialDetail.IdVoucher = oelVoucher.IdVoucher;
                            oelFinishedMaterialDetail.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                            oelFinishedMaterialDetail.IdItem = Validation.GetSafeLong(grdExpectedProducts.Rows[i].Cells["colInIdItem"].Value);
                            if (OutSourceWorkNature == 1)
                            {
                                oelFinishedMaterialDetail.OutSourceWork = 2;
                            }
                            else
                            {
                                oelFinishedMaterialDetail.OutSourceWork = 3;
                            }
                            oelFinishedMaterialDetail.Discription = "N/A";

                            oelFinishedMaterialDetail.CurrentStock = 0;
                            oelFinishedMaterialDetail.Units = Validation.GetSafeDecimal(grdExpectedProducts.Rows[i].Cells["colInQuantity"].Value);
                            oelFinishedMaterialDetail.UnitPrice = Validation.GetSafeDecimal(grdExpectedProducts.Rows[i].Cells["colInUnitPrice"].Value);
                            oelFinishedMaterialDetail.Amount = Validation.GetSafeDecimal(grdExpectedProducts.Rows[i].Cells["colInAmount"].Value);

                            oelOutSourceWorkDetailCollection.Add(oelFinishedMaterialDetail);
                        }
                        #endregion
                        #region Add Supplier
                        if (OutSourceWorkNature == 2)
                        {
                            VoucherDetailEL oelVendorTransaction = new VoucherDetailEL();
                            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "ItemWiseLederPrint");
                            if (SupplierTransactionId.HasValue && SupplierTransactionId.Value > 0)
                            {
                                oelVendorTransaction.IdTransactionDetail = SupplierTransactionId.Value;
                                oelVendorTransaction.IsNew = false;
                            }
                            else
                            {
                                oelVendorTransaction.IdTransactionDetail = 0;
                                oelVendorTransaction.IsNew = true;
                            }
                            oelVendorTransaction.IsNetTransaction = IsNetTransaction;
                            oelVendorTransaction.SeqNo = 1;
                            oelVendorTransaction.TrackNumber = 1;
                            oelVendorTransaction.IdProject = Operations.IdProject;
                            oelVendorTransaction.BookNo = Operations.BookNo;
                            oelVendorTransaction.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                            oelVendorTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelVendorTransaction.AccountNo = SupplierAccountNo;
                            oelVendorTransaction.SubAccountNo = "0";
                            oelVendorTransaction.Date = VDate.Value;
                            oelVendorTransaction.VoucherType = "OW";
                            oelVendorTransaction.TransactionType = 1;
                            oelVendorTransaction.TransactionMode = "CR";
                            if (oelSoftwareCheck != null && oelSoftwareCheck.IsMust.Value)
                            {
                                oelVendorTransaction.Description = BuildRemarks(); //txtDescription.Text;
                            }
                            else
                            {
                                oelVendorTransaction.Description = "OutSourced From : " + SEditBox.Text;
                            }
                            oelVendorTransaction.Credit = Validation.GetSafeDecimal(txtTotalAmount.Text);

                            oelVendorTransaction.Debit = 0;
                            oelVendorTransaction.Posted = chkPosted.Checked;
                            oelVendorTransaction.CreatedDateTime = VDate.Value;

                            oelCostOfSalesCollection.Add(oelVendorTransaction);
                        }
                        #endregion
                        #region Add Purchase Account In Transactions
                        if (OutSourceWorkNature == 2)
                        {
                            VoucherDetailEL oelWorkPurchaseTransaction = new TransactionsEL();
                            if (PurchasesTransactionId.HasValue && PurchasesTransactionId.Value > 0)
                            {
                                oelWorkPurchaseTransaction.IdTransactionDetail = PurchasesTransactionId.Value;
                                oelWorkPurchaseTransaction.IsNew = false;
                            }
                            else
                            {
                                oelWorkPurchaseTransaction.IdTransactionDetail = 0;
                                oelWorkPurchaseTransaction.IsNew = true;
                            }
                            oelWorkPurchaseTransaction.IsNetTransaction = IsNetTransaction;
                            oelWorkPurchaseTransaction.SeqNo = 2;
                            oelWorkPurchaseTransaction.TrackNumber = 2;
                            oelWorkPurchaseTransaction.IdProject = Operations.IdProject;
                            oelWorkPurchaseTransaction.BookNo = Operations.BookNo;
                            oelWorkPurchaseTransaction.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                            oelWorkPurchaseTransaction.IdVoucher = oelVoucher.IdVoucher;
                            //oelPurchaseTransaction.AccountNo = Validation.GetSafeLong(PurchasesEditBox.Text);
                            oelWorkPurchaseTransaction.AccountNo = PurchasesAccountNo;
                            oelWorkPurchaseTransaction.SubAccountNo = "0";
                            oelWorkPurchaseTransaction.Date = VDate.Value;
                            oelWorkPurchaseTransaction.VoucherType = "OW";
                            oelWorkPurchaseTransaction.TransactionType = 2;
                            oelWorkPurchaseTransaction.Description = txtDescription.Text;
                            oelWorkPurchaseTransaction.Debit = Validation.GetSafeDecimal(txtTotalAmount.Text);
                            oelWorkPurchaseTransaction.Credit = 0;
                            oelWorkPurchaseTransaction.TransactionMode = "DR";
                            oelWorkPurchaseTransaction.CreatedDateTime = VDate.Value;
                            oelWorkPurchaseTransaction.Posted = chkPosted.Checked;

                            oelCostOfSalesCollection.Add(oelWorkPurchaseTransaction);
                        }
                        #endregion region
                        #region Saving Code
                        if (IdVoucher == null || IdVoucher == 0)
                        {
                            var manager = new OutSourceWorkHeadBLL();

                            EntityoperationInfo infoResult = manager.CreateOutSourceWork(oelVoucher, oelOutSourceWorkDetailCollection, oelCostOfSalesCollection);
                            if (infoResult.IsSuccess)
                            {
                                VEditBox.Text = infoResult.VoucherNo.ToString();
                                IdVoucher = infoResult.IntID;
                                //FillVoucher();
                                MessageBox.Show("Transaction Successfully Done...");
                                ClearControls();
                                FillData();
                            }
                        }
                        else
                        {
                            var manager = new OutSourceWorkHeadBLL();
                            EntityoperationInfo infoResult = manager.UpdateOutSourceWork(oelVoucher, oelOutSourceWorkDetailCollection, oelCostOfSalesCollection);
                            if (infoResult.IsSuccess)
                            {
                                MessageBox.Show("Transaction Successfully Done...");
                                ClearControls();
                                FillData();
                            }
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
                    lblStatuMessage.Text = "Check Values";
                }
            }
            else
            {
                lblStatuMessage.Text = "Incomplete Entry...";
            }
            #endregion
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelItemTransactionCollection = new List<TransactionsEL>();
            var manager = new PurchaseHeadBLL();

            if (IdVoucher > 0)
            {
                if (chkPosted.Checked)
                {
                    if (Operations.IdRole != Validation.GetSafeLong(EnRoles.Administrator))
                    {
                        frmauthentication = new frmAuthentication();
                        frmauthentication.ShowDialog();
                        if (Operations.IsAuthenticate && Operations.IdAuthenticationRole == Validation.GetSafeLong(EnRoles.Administrator) || Operations.IdAuthenticationRole == Validation.GetSafeLong(EnRoles.CheifExecutive))
                        {
                            if (manager.DeletePurchasesByVoucher(IdVoucher.Value, Operations.IdProject))
                            {
                                MessageBox.Show("Voucher Deleted Successfully and Transactions Rolled Back");
                                Operations.IsAuthenticate = false;
                                ClearControls();
                            }
                        }
                        else
                        {
                            MessageBox.Show("You Need Admin OR CEO Login To Delete It...");
                        }
                    }
                    else if (MessageBox.Show("Are You Sure To Delete ?", "Deleting Voucher", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    {
                        if (manager.DeletePurchasesByVoucher(IdVoucher.Value, Operations.IdProject))
                        {
                            MessageBox.Show("Voucher Deleted Successfully and Transactions Rolled Back");
                            ClearControls();
                        }
                    }
                }
                //PurchaseStockReceiptBLL();
                else if (MessageBox.Show("Are You Sure To Delete ?", "Deleting Voucher", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (manager.DeletePurchasesByVoucher(IdVoucher.Value, Operations.IdProject))
                    {
                        MessageBox.Show("Voucher Deleted Successfully and Transactions Rolled Back");
                        ClearControls();
                    }
                }
            }
            else
            {
                MessageBox.Show("Select Voucher To Delete...");
            }

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
            //FillData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (VEditBox.Text != string.Empty)
            {
                long NextVoucherNo = Convert.ToInt64(VEditBox.Text);
                NextVoucherNo += 1;
                FillOutSourceWorkByNumber(NextVoucherNo);
            }
            else
            {
                MessageBox.Show("Please Load Any Purchase First To Move Forward");
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (VEditBox.Text != string.Empty)
            {
                long PreviousVoucherNo = Convert.ToInt64(VEditBox.Text);
                PreviousVoucherNo -= 1;
                FillOutSourceWorkByNumber(PreviousVoucherNo);
            }
            else
            {
                MessageBox.Show("Please Load Any Purchase First To Move Back");
            }
        }
        private void btnPrintPurchaseInvoice_Click(object sender, EventArgs e)
        {
            frmpurchaseprintreport = new frmPurchasePrintReport();
            frmpurchaseprintreport.IsNetTransaction = IsNetTransaction;
            frmpurchaseprintreport.IdVoucher = IdVoucher.Value;
            frmpurchaseprintreport.ShowDialog();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region DropDown Events
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
        private void cbxNaturalAccounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //txtBillNo.Focus();
                DgvStockReceipt.Focus();
            }
        }
        #endregion
        #region Other Controls Methods And Events
        private void VEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmfindVouchers = new frmFindVouchers();
            frmfindVouchers.VoucherType = VoucherTypes.StockReceiptVoucher.ToString();
            frmfindVouchers.IsNetTransaction = IsNetTransaction;
            frmfindVouchers.ExecuteFindVouchersEvent += new frmFindVouchers.VouchersDelegate(frmfindVouchers_ExecuteFindVouchersEvent);
            frmfindVouchers.ShowDialog(this);
        }
        private void VEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    FillOutSourceWorkByNumber(Validation.GetSafeLong(VEditBox.Text));
                }
            }
            else
                e.Handled = true;
        }
        private void SEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox txt = sender as MetroFramework.Controls.MetroTextBox;
            if (txt != null)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txt.Name == "SEditBox")
                    {
                        if (SEditBox.Text == string.Empty)
                        {
                            return;
                        }
                        DgvStockReceipt.Focus();
                        //cbxNaturalAccounts.Focus();
                        //cbxNaturalAccounts.DroppedDown = true;
                    }
                }
                else if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
                {
                    if (EventTime == 0)
                    {
                        EventCommandName = "Persons";
                        e.Handled = true;
                        frmAccount = new frmFindAccounts();
                        frmAccount.SearchText = e.KeyChar.ToString();
                        frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                        frmAccount.ShowDialog();
                    }
                }
                else
                    e.Handled = false;
            }
        }
        private void SEditBox_TextChanged(object sender, EventArgs e)
        {
            //if (EventTime == 0)
            //{

            //    frmAccount = new frmFindAccounts();
            //    frmAccount.SearchText = SEditBox.Text;
            //    frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            //    frmAccount.ShowDialog();
            //}
        }
        private void txtFreigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (e.KeyChar == (char)Keys.Enter)
            {
                btnSave.Focus();
            }
            //{
            //    if (e.KeyChar == (char)Keys.Enter)
            //    {
            //        decimal ActualAmount = Validation.GetSafeDecimal(txtBillAmount.Text);
            //        decimal Resultant = ActualAmount + Validation.GetSafeDecimal(txtFreightAmount.Text);
            //        txtTotalAmount.Text = Resultant.ToString();
            //    }
            //    else
            //        e.Handled = true;
            //}
            //else
            //    e.Handled = true;
        }
        private void txtFreightAmount_Leave(object sender, EventArgs e)
        {
            if (txtFreightAmount.Text != string.Empty)
            {
                decimal ActualAmount = Validation.GetSafeDecimal(txtBillAmount.Text);
                decimal Resultant = ActualAmount + Validation.GetSafeDecimal(txtFreightAmount.Text);
                txtTotalAmount.Text = Resultant.ToString();
            }
        }
        private void txtBillNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SEditBox.Focus();
            }
        }
        #endregion
        #region Custom Controls Methods And Events
        private void PurchasesEditBox_ButtonClick(object sender, EventArgs e)
        {
            EventCommandName = "Sales";
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }
        private void SEditBox_ButtonClick(object sender, EventArgs e)
        {
            EventCommandName = "Persons";
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }
        void frmAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            if (EventCommandName == "Persons")
            {
                SEditBox.Text = oelAccount.AccountName;
                SupplierAccountNo = oelAccount.AccountNo;
                FillCreditor(oelAccount.AccountNo);
                list = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, oelAccount.AccountNo);
                if (list.Count > 0)
                {
                    txtCurrentBalance.Text = list[0].TypedClosingBalance;
                }
            }
            else
            {
                PurchasesAccountNo = oelAccount.AccountNo.ToString();
            }
        }
        private void DgvStockReceipt_KeyDown(object sender, KeyEventArgs e)
        {
        }
        void frmfindProducts_ExecuteFindPorudctsEvent(object Sender, ItemsEL oelItems)
        {
            DgvStockReceipt.RefreshEdit();
            var manager = new ItemsBLL();
            //if (manager.VerifyAccount(Operations.IdCompany, "Items", oelItems.AccountNo).Count > 0)
            {
                //for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                //{
                //    if (DgvStockReceipt.Rows[i].Cells["colItemNo"].Value != null)
                //    {
                //        if (oelItems.AccountNo == Validation.GetSafeLong(DgvStockReceipt.Rows[i].Cells["colItemNo"].Value))
                //        {
                //            lblStatuMessage.Text = "Product Already exists";
                //            return;
                //        }
                //    }
                //}
                if (EventCommandName == "Raw Grid")
                {
                    DgvStockReceipt.RefreshEdit();
                    lblStatuMessage.Text = "";
                    DgvStockReceipt.CurrentRow.Cells["colIdItem"].Value = oelItems.IdItem;
                    DgvStockReceipt.CurrentRow.Cells["colItemName"].Value = oelItems.ItemName;
                    DgvStockReceipt.CurrentRow.Cells["colpacking"].Value = oelItems.PackingSize;
                    DgvStockReceipt.CurrentRow.Cells["colCurrentStock"].Value = manager.GetItemClosingStock(Validation.GetSafeLong(DgvStockReceipt.CurrentRow.Cells["colIdItem"].Value));
                }
                else
                {
                    grdExpectedProducts.RefreshEdit();
                    grdExpectedProducts.CurrentRow.Cells["colInIdItem"].Value = oelItems.IdItem;
                    grdExpectedProducts.CurrentRow.Cells["colInProductDescription"].Value = oelItems.ItemName;
                    grdExpectedProducts.CurrentRow.Cells["colInUOM"].Value = oelItems.PackingSize;
                }
            }
        }
        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {
            VoucherNo = oelVoucher.VoucherNo;
            IdVoucher = oelVoucher.IdVoucher;
            VEditBox.Text = oelVoucher.VoucherNo.ToString();
            FillVoucher();

        }
        #endregion
        #region Stock Raw Material Grid Events
        private void DgvStockReceipt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)Keys.F2)
            //{
            //    if (DgvStockReceipt.CurrentCellAddress.X == 2)
            //    {
            //        checkSender = true;
            //        frmstockAccounts = new frmStockAccounts();
            //        frmstockAccounts.ExecuteFindStockAccountEvent += new frmStockAccounts.FindStockAccountDelegate(frmstockAccounts_ExecuteFindStockAccountEvent);
            //        frmstockAccounts.ShowDialog(this);
            //    }
            //}
        }
        private void DgvStockReceipt_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvStockReceipt.CurrentCellAddress.X == 2)
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
            if (DgvStockReceipt.CurrentCellAddress.X == 2)
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
                {
                    frmfindProducts = new frmFindProducts();
                    frmfindProducts.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindProducts_ExecuteFindPorudctsEvent);
                    frmfindProducts.SearchText = e.KeyChar.ToString();
                    EventCommandName = "Raw Grid";
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
        private void DgvStockReceipt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                e.Value = "Delete";
            }
        }
        private void DgvStockReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal lineAmount, value = 0;
            if (e.ColumnIndex == 8)
            {
                if (DgvStockReceipt.Rows[e.RowIndex].Cells["ColIdVoucherDetail"].Value == null)
                {
                    if (DgvStockReceipt.Rows.Count > 1)
                    {
                        DataGridViewRow oRow = DgvStockReceipt.Rows[e.RowIndex];
                        DgvStockReceipt.Rows.Remove(oRow);
                    }
                    DataGridViewCell oCell = DgvStockReceipt.Rows[e.RowIndex].Cells["colDiscountAmount"];
                    for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                    {
                        value += Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colDiscountAmount"].Value);
                    }
                    //lineAmount = Validation.GetSafeDecimal(oCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit));
                    //txtCreditBalance.Text = (Validation.GetSafeDecimal(txtCreditBalance.Text) - lineAmount).ToString();
                    txtBillAmount.Text = value.ToString();
                    txtTotalAmount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(txtBillAmount.Text) + Validation.GetSafeDecimal(txtFreightAmount.Text));
                    if (DgvStockReceipt.Rows.Count - 1 == 0)
                    {
                        txtBillAmount.Text = string.Empty;
                        txtFreightAmount.Text = string.Empty;
                        txtTotalAmount.Text = string.Empty;
                    }
                }
                else
                {
                    if (!chkPosted.Checked)
                    {
                        if (DgvStockReceipt.Rows.Count - 1 == 1)
                        {
                            MessageBox.Show("There Is Only One Record In This Voucher , Please Press Delete Button To Remove This Voucher");
                            return;
                        }
                        var Manager = new VoucherBLL();
                        lineAmount = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                        txtBillAmount.Text = (Validation.GetSafeDecimal(txtBillAmount.Text) - lineAmount).ToString();
                        txtTotalAmount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(txtBillAmount.Text) + Validation.GetSafeDecimal(txtFreightAmount.Text));

                        if (Manager.DeleteChildRecords(Validation.GetSafeLong(DgvStockReceipt.Rows[e.RowIndex].Cells["ColIdVoucherDetail"].Value), "StockReceiptVoucher"))
                        {
                            DataGridViewRow oRow = DgvStockReceipt.Rows[e.RowIndex];
                            DgvStockReceipt.Rows.Remove(oRow);
                            btnSave_Click(sender, e);
                            MessageBox.Show("This Voucher and Party Ledger Updated Automatically...");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Voucher Is Posted...");
                    }

                }
            }
        }
        private void DgvStockReceipt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var manager = new ItemsBLL();
            if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colQty")
            {
                if (DgvStockReceipt.Rows[e.RowIndex].Cells["colIdItem"].Value != null)
                {
                    SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "SaleQuantityCheck");
                    if (oelSoftwareCheck != null && oelSoftwareCheck.IsMust.Value)
                    {
                        decimal ClosingStock = manager.GetItemClosingStock(Validation.GetSafeLong(DgvStockReceipt.Rows[e.RowIndex].Cells["colIdItem"].Value));
                        if (IdVoucher == 0 || IdVoucher == null)
                        {
                            if (ClosingStock > 0)
                            {

                                if (ClosingStock > Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value) || ClosingStock == Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value))
                                {
                                    /// Allow Input
                                    if (Validation.GetSafeLong(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value) > 0)
                                    {
                                        DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = (Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value)).ToString("0.00");
                                    }
                                    else
                                    {
                                        DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = 0;
                                    }

                                }
                                else
                                {
                                    MessageBox.Show("Closing Stock Is Less Than Issue Quantity for this Product which is '" + ClosingStock + "'....");
                                    DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value = "";
                                    return;
                                }

                            }
                            else
                            {
                                MessageBox.Show("Quantity Not Available for this Product....");
                                DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value = "";
                                return;
                            }
                        }
                    }
                    if (DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value == null)
                    {
                        DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value = manager.GetItemsAvgValueWOT(Validation.GetSafeLong(DgvStockReceipt.Rows[e.RowIndex].Cells["colIdItem"].Value)).ToString("0.00");//.GetItemById(Validation.GetSafeLong(DgvStockReceipt.Rows[e.RowIndex].Cells["colIdItem"].Value))[0].CurrentUnitPrice;
                    }
                    if (Validation.GetSafeLong(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value) > 0)
                    {
                        DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = (Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value)).ToString("0.00");
                    }
                    else
                    {
                        DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = 0;
                    }
                }
            }
            else if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colUnitPrice")
            {
                if (DgvStockReceipt.Rows[e.RowIndex].Cells["colIdItem"].Value != null)
                {
                    DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = (Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value)).ToString("0.00");
                }
                if (OutSourceWorkNature == 1)
                {
                    for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                    {
                        OldValue += Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);
                    }
                    txtBillAmount.Text = OldValue.ToString();
                    txtTotalAmount.Text = Validation.GetSafeString(OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text));
                    OldValue = 0;
                }
            }
        }
        private void DgvStockReceipt_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            OldValue = 0;
            if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colUnitPrice")
            {
                if (DgvStockReceipt.Rows[e.RowIndex].Cells["colIdItem"].Value != null)
                {
                    DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = (Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value)).ToString("0.00");
                }
                if (OutSourceWorkNature == 1)
                {
                    for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                    {
                        OldValue += Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);
                    }
                    txtBillAmount.Text = OldValue.ToString();
                    txtTotalAmount.Text = Validation.GetSafeString(OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text));
                    OldValue = 0;
                }
            }
        }
        private void DgvStockReceipt_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
        }
        //private void DgvStockReceipt_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        //{
        ////    if (DgvStockReceipt.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
        ////    {
        ////        if (DgvStockReceipt.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() == string.Empty)
        ////        {
        ////            e.Cancel = true;
        ////        }
        ////        else
        ////        {
        ////            e.Cancel = false;
        ////        }
        ////    }
        //}
        #endregion
        #region Stock Finished Good Grid Events
        private void grdExpectedProducts_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (grdExpectedProducts.CurrentCellAddress.X == 2)
            {
                TextBox txtFinishedGoodItem = e.Control as TextBox;
                if (txtFinishedGoodItem != null)
                {
                    txtFinishedGoodItem.KeyPress -= new KeyPressEventHandler(txtFinishedGoodItem_KeyPress);
                    txtFinishedGoodItem.KeyPress += new KeyPressEventHandler(txtFinishedGoodItem_KeyPress);
                }
            }
        }
        void txtFinishedGoodItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (grdExpectedProducts.CurrentCellAddress.X == 2)
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
                {
                    frmfindProducts = new frmFindProducts();
                    frmfindProducts.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindProducts_ExecuteFindPorudctsEvent);
                    frmfindProducts.SearchText = e.KeyChar.ToString();
                    EventCommandName = "";
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
        private void grdExpectedProducts_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            OldValue = 0;
            if (grdExpectedProducts.Columns[e.ColumnIndex].Name == "colInQty")
            {
                if (grdExpectedProducts.Rows[e.RowIndex].Cells["colInIdItem"].Value != null)
                {

                }
            }
            else if (grdExpectedProducts.Columns[e.ColumnIndex].Name == "colInUnitPrice")
            {
                if (grdExpectedProducts.Rows[e.RowIndex].Cells["colInIdItem"].Value != null)
                {
                    grdExpectedProducts.Rows[e.RowIndex].Cells["colInAmount"].Value = (Validation.GetSafeDecimal(grdExpectedProducts.Rows[e.RowIndex].Cells["colInQuantity"].Value) * Validation.GetSafeDecimal(grdExpectedProducts.Rows[e.RowIndex].Cells["colInUnitPrice"].Value)).ToString("0.00");
                }
                if (OutSourceWorkNature == 2)
                {
                    for (int i = 0; i < grdExpectedProducts.Rows.Count - 1; i++)
                    {
                        OldValue += Validation.GetSafeDecimal(grdExpectedProducts.Rows[i].Cells["colInAmount"].Value);
                    }
                    txtBillAmount.Text = OldValue.ToString();
                    txtTotalAmount.Text = Validation.GetSafeString(OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text));
                    OldValue = 0;
                }
            }
        }
        private void grdExpectedProducts_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                e.Value = "Delete";
            }
        }
        #endregion
        #region Grids Transactions Related Methods
        private void FillVoucher()
        {
            var Manager = new OutSourceWorkHeadBLL();
            VoucherType = "OW";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(VEditBox.Text));
            List<VoucherDetailEL> ListOutSourceWork = Manager.GetOutSourceWorkTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, OutSourceWorkNature);
            if (ListOutSourceWork.Count > 0)
            {
                IdVoucher = ListOutSourceWork[0].IdVoucher;
                VEditBox.Enabled = false;
                SEditBox.Text = ListOutSourceWork[0].AccountName;
                txtBiltyNo.Text = ListOutSourceWork[0].BiltyNo;
                txtBillNo.Text = ListOutSourceWork[0].BillNo;
                VDate.Value = ListOutSourceWork[0].VDate.Value;
                VDueDate.Value = ListOutSourceWork[0].DueDate.Value;
                txtDescription.Text = ListOutSourceWork[0].VDiscription;
                txtBillAmount.Text = ListOutSourceWork[0].BillAmount.ToString();
                txtFreightAmount.Text = ListOutSourceWork[0].TotalFreight.ToString();
                txtTotalAmount.Text = ListOutSourceWork[0].TotalAmount.ToString();
                cbxOutSourceWorkTypes.SelectedValue = ListOutSourceWork[0].OutSourceWorkType;
                SupplierAccountNo = ListOutSourceWork[0].AccountNo;
                {
                    FillCreditor(ListOutSourceWork[0].AccountNo);
                }
                chkPosted.Checked = ListOutSourceWork[0].Posted.Value;
                if (ListOutSourceWork[0].Posted.Value)
                {
                    //if (Operations.IdRole != Validation.GetSafeLong(EnRoles.Administrator))
                    //{
                    //    btnSave.Enabled = false;
                    //    btnDelete.Enabled = false;
                    //    chkPosted.Enabled = false;
                    //}
                    chkPosted.Enabled = false;
                    lblStatuMessage.Text = "Posted Voucher ...";
                    lblStatuMessage.ForeColor = Color.Red;
                }
                else
                {
                    chkPosted.Enabled = true;
                    //btnSave.Enabled = true;
                    //btnDelete.Enabled = true;
                }

                FillOutSourceStocks(ListOutSourceWork);

                if (OutSourceWorkNature == 2)
                {
                    List<VoucherDetailEL> listTransactions = Manager.GetOutSourceWorkSubTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, OutSourceWorkNature);

                    FillHeadTransactions(listTransactions);
                }
            }
            else
            {
                MessageBox.Show("Voucher Number Not Found ...");
                ClearControls();
            }
        }
        private void FillOutSourceWorkByNumber(Int64 WorkNo)
        {
            var Manager = new OutSourceWorkHeadBLL();
            VoucherType = "OW";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(VEditBox.Text));
            List<VoucherDetailEL> ListOutSourceWork = Manager.GetOutSourceWorkTransactionsByNumber(WorkNo, Operations.IdProject, Operations.BookNo, OutSourceWorkNature);
            if (ListOutSourceWork.Count > 0)
            {
                IdVoucher = ListOutSourceWork[0].IdVoucher;
                VEditBox.Enabled = false;
                SEditBox.Text = ListOutSourceWork[0].AccountName;
                VEditBox.Text = Validation.GetSafeString(ListOutSourceWork[0].VoucherNo);
                txtBiltyNo.Text = ListOutSourceWork[0].BiltyNo;
                txtBillNo.Text = ListOutSourceWork[0].BillNo;
                VDate.Value = ListOutSourceWork[0].VDate.Value;
                VDueDate.Value = ListOutSourceWork[0].DueDate.Value;
                txtDescription.Text = ListOutSourceWork[0].VDiscription;
                txtBillAmount.Text = ListOutSourceWork[0].BillAmount.ToString();
                txtFreightAmount.Text = ListOutSourceWork[0].TotalFreight.ToString();
                txtTotalAmount.Text = ListOutSourceWork[0].TotalAmount.ToString();
                SupplierAccountNo = ListOutSourceWork[0].AccountNo;
                cbxOutSourceWorkTypes.SelectedIndex = Validation.GetSafeInteger(((OutSourceWorkTypeEL)cbxOutSourceWorkTypes.Items[ListOutSourceWork[0].OutSourceWorkType]).IdOutSourceWorkType);
                FillCreditor(ListOutSourceWork[0].AccountNo);

                chkPosted.Checked = ListOutSourceWork[0].Posted.Value;
                if (ListOutSourceWork[0].Posted.Value)
                {
                    //if (Operations.IdRole != Validation.GetSafeLong(EnRoles.Administrator))
                    //{
                    //    btnSave.Enabled = false;
                    //    btnDelete.Enabled = false;
                    //    chkPosted.Enabled = false;
                    //}
                    chkPosted.Enabled = false;
                    lblStatuMessage.Text = "Posted Voucher ...";
                    lblStatuMessage.ForeColor = Color.Red;
                }
                else
                {
                    chkPosted.Enabled = true;
                    //btnSave.Enabled = true;
                    //btnDelete.Enabled = true;
                }

                FillOutSourceStocks(ListOutSourceWork);

                if (OutSourceWorkNature == 2)
                {
                    List<VoucherDetailEL> listTransactions = Manager.GetOutSourceWorkSubTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, OutSourceWorkNature);

                    FillHeadTransactions(listTransactions);
                }
            }
            else
            {
                MessageBox.Show("Voucher Number Not Found ...");
                ClearControls();
            }
        }
        private void FillOutSourceStocks(List<VoucherDetailEL> List)
        {
            if (DgvStockReceipt.Rows.Count > 0)
            {
                DgvStockReceipt.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {
                List<VoucherDetailEL> ListRawItems = List.FindAll(x => x.OutSourceWork == 1);
                if (ListRawItems.Count > 0)
                {
                    for (int i = 0; i < ListRawItems.Count; i++)
                    {
                        DgvStockReceipt.Rows.Add();
                        //DgvStockReceipt.Rows[i].Cells[0].Value = List[i].TransactionID;
                        DgvStockReceipt.Rows[i].Cells[0].Value = ListRawItems[i].IdVoucherDetail;
                        DgvStockReceipt.Rows[i].Cells[1].Value = ListRawItems[i].IdItem;
                        DgvStockReceipt.Rows[i].Cells[2].Value = ListRawItems[i].ItemName;
                        DgvStockReceipt.Rows[i].Cells[3].Value = ListRawItems[i].PackingSize;
                        DgvStockReceipt.Rows[i].Cells[4].Value = ListRawItems[i].CurrentStock;

                        DgvStockReceipt.Rows[i].Cells[5].Value = CommonFunctions.RemoveTrailingZeros(ListRawItems[i].Units);
                        DgvStockReceipt.Rows[i].Cells[6].Value = ListRawItems[i].UnitPrice;
                        DgvStockReceipt.Rows[i].Cells[7].Value = ListRawItems[i].Amount;

                    }
                }
                List<VoucherDetailEL> ListFinishedItems = List.FindAll(x => x.OutSourceWork == 2 || x.OutSourceWork == 3);
                if (ListFinishedItems.Count > 0)
                {
                    for (int j = 0; j < ListFinishedItems.Count; j++)
                    {
                        grdExpectedProducts.Rows.Add();
                        //DgvStockReceipt.Rows[i].Cells[0].Value = List[i].TransactionID;
                        grdExpectedProducts.Rows[j].Cells[0].Value = ListFinishedItems[j].IdVoucherDetail;
                        grdExpectedProducts.Rows[j].Cells[1].Value = ListFinishedItems[j].IdItem;
                        grdExpectedProducts.Rows[j].Cells[2].Value = ListFinishedItems[j].ItemName;
                        grdExpectedProducts.Rows[j].Cells[3].Value = ListFinishedItems[j].PackingSize;

                        grdExpectedProducts.Rows[j].Cells[4].Value = CommonFunctions.RemoveTrailingZeros(ListFinishedItems[j].Units);
                        grdExpectedProducts.Rows[j].Cells[5].Value = ListFinishedItems[j].UnitPrice;
                        grdExpectedProducts.Rows[j].Cells[6].Value = ListFinishedItems[j].Amount;

                    }
                }
                txtBillAmount.Text = Validation.GetSafeString(List[0].BillAmount);
                txtFreightAmount.Text = Validation.GetSafeString(List[0].TotalFreight);
                txtTotalAmount.Text = Validation.GetSafeString(List[0].TotalAmount);
            }
        }
        private void FillHeadTransactions(List<VoucherDetailEL> List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].TrackNumber == 1)
                {
                    if (OutSourceWorkNature == 2)
                    {
                        SupplierTransactionId = List[i].IdTransactionDetail;
                        SEditBox.Text = List[i].AccountName;
                        SupplierAccountNo = List[i].AccountNo;
                    }
                }
                else if (List[i].TrackNumber == 2)
                {
                    PurchasesTransactionId = List[i].IdTransactionDetail;
                    cbxNaturalAccounts.SelectedValue = List[i].AccountNo;
                    PurchasesAccountNo = List[i].AccountNo;
                }
            }
        }
        #endregion       
    }
}
