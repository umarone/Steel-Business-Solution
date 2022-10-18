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
    public partial class frmStockReturn : MetroForm
    {
        #region Variables
        frmAccounts frmaccounts;
        frmFindAccounts frmAccount;
        frmFindProducts frmfindProducts;
        frmFindVouchers frmfindVouchers;
        frmAuthentication frmauthentication;
        frmPersons frmpersons;
        public decimal OldValue { get; set; }
        public Int64 VoucherNo { get; set; }
        Int64? IdVoucher = null;
        public Int64? SupplierTransactionId { get; set; }
        public Int64? CashTransactionId { get; set; }
        public Int64? PurchasesTransactionId { get; set; }
        public string VoucherType { get; set; }
        public bool IsImport { get; set; }
        string EventCommandName;
        int EventTime = 0;
        public bool IsNetTransaction { get; set; }
        public bool IsImportTransaction { get; set; }
        TextBox txtDebit = new TextBox();
        TextBox txtCredit = new TextBox();
        string SupplierAccountNo= "", PurchasesAccountNo = "", CashAccountNo = "";
        int SilentSave = 0;
        DateTime? VoucherDateTime = DateTime.Now;

        public decimal VoucherPreviousBillAmount = 0;
        bool IsEditedDateChanged = false;
        int DateStatus = 0;

        #endregion
        #region Form Methods And Events
        public frmStockReturn()
        {
            InitializeComponent();
        }
        private void frmStockReturn_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DgvStockReceipt.AutoGenerateColumns = false;
            txtBillNo.Text = "0";
            ShowHideColumns();
            //AdjustControls();
            FillData();
            FillNaturalAccounts(string.Empty);
            FillCashAccounts(string.Empty);
            CheckModulePermissions();
            LoadAdjustmentTypes();
            FillTotalVouchers();
            GetLastVoucherTransactionByType();
            if (IsNetTransaction)
            {
                this.Text = "Net Inventory Purchases Return";              
            }
            else
            {
                this.Text = "Credit Inventory Purchases Return";
            }

        }
        private void frmStockReturn_KeyPress(object sender, KeyPressEventArgs e)
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

                        DgvStockReceipt.Columns["colItemName"].Width = 435;
                        DgvStockReceipt.Columns["colpacking"].Width = 100;
                        DgvStockReceipt.Columns["colQty"].Width = 100;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "General Bhatta")
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

                        DgvStockReceipt.Columns["colItemName"].Width = 420;
                        DgvStockReceipt.Columns["colpacking"].Width = 100;
                        DgvStockReceipt.Columns["colQty"].Width = 100;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "General Ledger")
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

                        DgvStockReceipt.Columns["colItemName"].Width = 520;
                        DgvStockReceipt.Columns["colpacking"].Width = 100;
                        DgvStockReceipt.Columns["colQty"].Width = 100;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 100;
                    }
                    if (objActiveType.SoftwareType == "Medicine General Trading")
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

                        DgvStockReceipt.Columns["colItemName"].Width = 500;
                        DgvStockReceipt.Columns["colpacking"].Width = 100;
                        DgvStockReceipt.Columns["colQty"].Width = 100;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 100;
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
                        DgvStockReceipt.Columns["colItemName"].Width = 465;
                    }
                    else if (objActiveType.SoftwareType == "Distribution Trading")
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

                        DgvStockReceipt.Columns["colItemName"].Width = 435;
                        DgvStockReceipt.Columns["colpacking"].Width = 100;
                        DgvStockReceipt.Columns["colQty"].Width = 100;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 100;
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

                        DgvStockReceipt.Columns["colItemName"].Width = 525;
                        DgvStockReceipt.Columns["colpacking"].Width = 100;
                        DgvStockReceipt.Columns["colQty"].Width = 100;
                        DgvStockReceipt.Columns["colUnitPrice"].Width = 100;
                    }
                }
            }
        }
        private void AdjustControls()
        {
            if (IsNetTransaction)
            {
                grpCreditor.Visible = false;
                //grpSupplier.Visible = true;
            }
            else
            {
                pnlCash.Visible = false;
                //grpSupplier.Visible = false;
            }
        }
        private void LoadAdjustmentTypes()
        {
            var manager = new StockAdjustmentsBLL();
            List<StockAdjustmentsEL> list = manager.GetStockAdjustmentsByType(1);
            if (list.Count > 0)
            {
                list.Insert(0, new StockAdjustmentsEL() { IdStockAdjustmentType = -1, StockAdjustmentName = "" });
                cbxAdjustmentTypes.DataSource = list;
                cbxAdjustmentTypes.DisplayMember = "StockAdjustmentName";
                cbxAdjustmentTypes.ValueMember = "IdStockAdjustmentType";
                cbxAdjustmentTypes.SelectedIndex = -1;
            }
            else
            {
                cbxAdjustmentTypes.DataSource = null;
            }
        }
        private void CreateAndInitializeFooterRow()
        {
            txtDebit.Enabled = false;
            txtDebit.TextAlign = HorizontalAlignment.Left;
            txtDebit.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);

            int hostCellLocation = DgvPurchases.GetCellDisplayRectangle(6, -1, true).X;

            txtDebit.Width = DgvPurchases.Columns[6].Width; //+SystemInformation.VerticalScrollBarWidth;
            txtDebit.Location = new Point(hostCellLocation, DgvPurchases.Height - txtDebit.Height);

            DgvPurchases.Controls.Add(txtDebit);

            txtDebit.BringToFront();

            txtCredit.Enabled = false;
            txtCredit.TextAlign = HorizontalAlignment.Left;
            txtCredit.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);

            int hostCreditCellLocation = DgvPurchases.GetCellDisplayRectangle(7, -1, true).X;
            txtCredit.Width = DgvPurchases.Columns[7].Width; //+SystemInformation.VerticalScrollBarWidth;
            txtCredit.Location = new Point(hostCreditCellLocation, DgvPurchases.Height - txtCredit.Height);

            DgvPurchases.Controls.Add(txtCredit);

            txtCredit.BringToFront();
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
                //txtContact.Text = list[0].Contact;
            }
        }
        private void FillCreditorCredentials(string AccountNo)
        {
            var manager = new PersonsBLL();
            List<PersonsEL> list = manager.GetPersonByAccount(Operations.IdProject, AccountNo);
            if (list.Count > 0)
            {
                if (list[0].PersonName == string.Empty)
                {
                    SEditBox.Text = list[0].AccountName;
                }
                else
                {
                    SEditBox.Text = list[0].PersonName + "-" + list[0].Address;
                }
                txtCurrentBalance.Text = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, AccountNo)[0].TypedClosingBalance;
            }
            else
            {
                var Amanager = new AccountsBLL();
                List<AccountsEL> Alist = Amanager.GetAccount(AccountNo, Operations.IdCompany, Operations.IdProject);
                if (list.Count > 0)
                {
                    SEditBox.Text = Alist[0].AccountName;
                }
            }
        }
        private void FillData()
        {
            var manager = new PurchaseHeadBLL();
            VEditBox.Text = manager.GetMaxPurchaseReturnNumber(Operations.IdProject, Operations.BookNo, IsNetTransaction).ToString();
        }
        private void FillTotalVouchers()
        {
            var Manager = new VoucherBLL();
            lblTotalVouchers.Text = Manager.GetAllStockTotalTransactionalVouchersByType(Operations.IdProject, Operations.BookNo, VoucherTypes.StockReturnVoucher.ToString(), IsNetTransaction).ToString();
        }
        private void GetLastVoucherTransactionByType()
        {
            var Manager = new VoucherBLL();
            List<VouchersEL> listLast = Manager.GetStockLastVoucherTransactionByType(Operations.IdProject, Operations.BookNo, VoucherTypes.StockReturnVoucher.ToString(), IsNetTransaction);
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
        private void FillCashAccounts(string AccountNo)
        {
            #region Fill Cash Accounts
            //if (IsNetTransaction)
            //{
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
            //}
            #endregion
        }
        private void ClearControls()
        {
            SEditBox.Focus();
            VDate.Value = DateTime.Now;
            VDate.Enabled = true;
            VEditedDateTime.Value = DateTime.Now;
            DgvStockReceipt.Rows.Clear();
            DgvPurchases.Rows.Clear();
            //txtDescription.Text = string.Empty;
            VoucherNo = 0;
            IdVoucher = null;
            //VEditBox.Text = string.Empty;
            VEditBox.Enabled = true;
            txtSheetNo.Text = string.Empty;
            txtDescription.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;

            SupplierTransactionId = null;
            PurchasesTransactionId = null;
            CashTransactionId = null;

            SEditBox.Text = string.Empty;
            txtBillNo.Text = "0";
            lblStatuMessage.Text = string.Empty;
            if (chkPosted.Checked)
            {
                chkPosted.Checked = false;
                chkPosted.Enabled = true;
            }

            //SupplierAccountNo = string.Empty;
            //CashAccountNo = string.Empty;
            //PurchasesAccountNo = string.Empty;

            //txtSupplierName.Text = string.Empty;
            //txtSupplierContact.Text = string.Empty;
            //txtSupplerCNIC.Text = string.Empty;
            //txtSupplierAddress.Text = string.Empty;
            //txtBiltyNo.Text = string.Empty;
            //txtContact.Text = string.Empty;
            txtCurrentBalance.Text = string.Empty;
            txtBillNo.Text = string.Empty;
            cbxAdjustmentTypes.SelectedIndex = -1;
            //cbxNaturalAccounts.SelectedIndex = -1;
            //cbxCashAccounts.SelectedIndex = -1;

            rdCredit.Checked = false;
            rdCash.Checked = false;

            btnSave.Enabled = true;
            lblVoucherStatus.Text = string.Empty;
            lblVoucherStatus.Visible = false;

            VoucherPreviousBillAmount = 0;
            IsEditedDateChanged = false;
            DateStatus = 1;
            txtFreightAmount.Text = string.Empty;
            txtsystemweight.Text = string.Empty;
            txtBillAmount.Text = string.Empty;
            txtsystemweight.Text = string.Empty;
            txtManualWeight.Text = string.Empty;
            txt2kgWeight.Text = string.Empty;
        }
        private bool ValidateRows()
        {

            for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
            {
                if (DgvStockReceipt.Rows[i].Cells["colQty"].Value == null)
                {
                    return false;
                }
                else if (DgvStockReceipt.Rows[i].Cells["colWeight"].Value == null || Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colWeight"].Value) == 0)
                {
                    MessageBox.Show("0 Weight Is Not Allowed....");
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
            if (rdCredit.Checked)
            {
                if (SupplierAccountNo == string.Empty)
                {
                    MessageBox.Show("Please Select Supplier...");
                    return false;
                }
                else if (PurchasesAccountNo == string.Empty)
                {
                    MessageBox.Show("Purchase Account Missing, Please Select...");
                    return false;
                }
            }
            else if (rdCash.Checked)
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
                else if (SupplierAccountNo == string.Empty)
                {
                    MessageBox.Show("Please Select Supplier...");
                    return false;
                }
            }
            else
            {
                MessageBox.Show("Please Transaction Type ?");
            }
            if (cbxAdjustmentTypes.SelectedIndex == 0 || cbxAdjustmentTypes.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select Return Type ...");
                return false;
            }
            if (IdVoucher.HasValue && IdVoucher.Value > 0)
            {
                if (rdCredit.Checked)
                {
                    if (SupplierTransactionId != null)
                    {
                        if (SupplierTransactionId.HasValue && SupplierTransactionId.Value > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Customer Is Missing...");
                            return false;
                        }
                    }
                    else if (CashTransactionId != null || CashTransactionId.Value > 0)
                    {
                        SupplierTransactionId = CashTransactionId;
                    }
                }
                else if (rdCash.Checked)
                {
                    //if (IsWhatTransactionType)
                    //{
                    if (CashTransactionId != null)
                    {
                        if (CashTransactionId.HasValue && CashTransactionId.Value > 0)
                        {

                        }
                        else
                        {
                            MessageBox.Show("Cash Account Is Missing...");
                            return false;
                        }
                    }
                    else if (SupplierTransactionId != null || SupplierTransactionId.Value > 0)
                    {
                        CashTransactionId = SupplierTransactionId;
                    }

                    //}
                    //else
                    //{ 

                    //}
                }
            }
            if (txtTotalAmount.Text == string.Empty || txtTotalAmount.Text == "0")
            {
                MessageBox.Show("Total Amount Is Missing....");
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
            string First = txtDescription.Text == string.Empty ? "Follow Are Purchases Return By "+SEditBox.Text+"~" : txtDescription.Text +"~";
            for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
            {
                Remarks += DgvStockReceipt.Rows[i].Cells[4].Value.ToString() + " "
                           + DgvStockReceipt.Rows[i].Cells[16].Value.ToString() + " Units"
                           + "@" + DgvStockReceipt.Rows[i].Cells[18].Value.ToString() + "~";
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
            List<VoucherDetailEL> oelPurchaseDetailCollection = new List<VoucherDetailEL>();
            List<VoucherDetailEL> oelCostOfSalesCollection = new List<VoucherDetailEL>();
            List<ItemsEL> oelItemsCollection = new List<ItemsEL>();
            #endregion
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
                        oelVoucher.EditedByUserId = Operations.UserID;
                        oelVoucher.PostedByUserId = Operations.UserID;
                        oelVoucher.IdProject = Operations.IdProject;
                        oelVoucher.SheetNo = Validation.GetSafeLong(txtSheetNo.Text);
                        oelVoucher.BookNo = Operations.BookNo;
                        oelVoucher.TerminalNumber = Validation.GetSafeInteger(XmlConfiguration.ReadXmlTerminalsConfiguration()[0]);
                        oelVoucher.BiltyNo = Validation.GetSafeString(txtBiltyNo.Text);
                        oelVoucher.IdStockAdjustmentType = Validation.GetSafeLong(cbxAdjustmentTypes.SelectedValue);
                        oelVoucher.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                        oelVoucher.AccountNo = SupplierAccountNo;
                        if (!IsNetTransaction)
                        {
                            oelVoucher.TransactionAccountNo = SupplierAccountNo;
                        }
                        else
                        {
                            oelVoucher.TransactionAccountNo = CashAccountNo;
                        }
                        oelVoucher.SubAccountNo = "0";
                        oelVoucher.BillNo = txtBillNo.Text;
                        oelVoucher.VDate = VDate.Value;
                        //if (VoucherDateTime.Value != VDate.Value)
                        //    oelVoucher.EditedDateTime = VDate.Value;
                        //else
                        //    oelVoucher.EditedDateTime = DateTime.Now;
                        //oelVoucher.PostedDateTime = DateTime.Now;
                        if (!IdVoucher.HasValue)
                        {
                            oelVoucher.EditedDateTime = null;
                        }
                        else
                        {
                            if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && VoucherDateTime == null)
                                oelVoucher.EditedDateTime = VDate.Value;
                            else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                oelVoucher.EditedDateTime = VEditedDateTime.Value;
                            else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                oelVoucher.EditedDateTime = VEditedDateTime.Value;
                            else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged)
                                oelVoucher.EditedDateTime = VEditedDateTime.Value;
                            else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged && VEditedDateTime.Value > DateTime.Now)
                                oelVoucher.EditedDateTime = VEditedDateTime.Value;
                            else
                                oelVoucher.EditedDateTime = DateTime.Now;
                        }
                        if (chkPosted.Checked)
                        {
                            oelVoucher.PostedDateTime = DateTime.Now;
                        }
                        else
                            oelVoucher.PostedDateTime = null;
                        oelVoucher.IsNetTransaction = IsNetTransaction;
                        oelVoucher.IsImportTransaction = IsImportTransaction;
                        oelVoucher.BillAmount = Validation.GetSafeDecimal(txtBillAmount.Text);
                        oelVoucher.TotalFreight = Validation.GetSafeDecimal(txtFreightAmount.Text);
                        oelVoucher.TotalAmount = Validation.GetSafeDecimal(txtTotalAmount.Text);
                        oelVoucher.VAT = 0;//Validation.GetSafeInteger(txtVat.Text);
                        oelVoucher.VATAmount = 0;//Validation.GetSafeDecimal(txtTotalAmount.Text);
                        oelVoucher.IsImport = IsNetTransaction;
                        oelVoucher.Discription = Validation.GetSafeString(txtDescription.Text);
                        oelVoucher.SystemWeight = Validation.GetSafeDecimal(txtsystemweight.Text);
                        oelVoucher.ManualWeight = Validation.GetSafeDecimal(txtManualWeight.Text);
                        oelVoucher.AutoWeight = Validation.GetSafeDecimal(txt2kgWeight.Text);
                        oelVoucher.Posted = chkPosted.Checked;
                        #endregion
                        #region Add Stock
                        for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                        {
                            VoucherDetailEL oelPurchaseDetial = new VoucherDetailEL();
                            ItemsEL oelItem = new ItemsEL();
                            if (DgvStockReceipt.Rows[i].Cells["ColIdVoucherDetail"].Value != null)
                            {
                                //oelPurchaseDetial.TransactionID = new Guid(DgvStockReceipt.Rows[i].Cells["ColTransaction"].Value.ToString());
                                oelPurchaseDetial.IdVoucherDetail = Validation.GetSafeLong(DgvStockReceipt.Rows[i].Cells["ColIdVoucherDetail"].Value.ToString());
                                oelPurchaseDetial.IsNew = false;
                            }
                            else
                            {
                                oelPurchaseDetial.IdVoucherDetail = 0;
                                //  oelPurchaseDetial.TransactionID = Guid.NewGuid();
                                oelPurchaseDetial.IsNew = true;
                            }
                            oelPurchaseDetial.SeqNo = i + 1;
                            oelPurchaseDetial.IdVoucher = oelVoucher.IdVoucher;
                            oelPurchaseDetial.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                            oelPurchaseDetial.IdItem = Validation.GetSafeLong(DgvStockReceipt.Rows[i].Cells["colIdItem"].Value);
                            oelItem.IdItem = Validation.GetSafeLong(DgvStockReceipt.Rows[i].Cells["colIdItem"].Value);
                            oelPurchaseDetial.PackingSize = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colpacking"].Value);
                            oelPurchaseDetial.Discription = "N/A"; //Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colRemarks"].Value);
                            oelPurchaseDetial.TotalCartons = Validation.GetSafeLong(DgvStockReceipt.Rows[i].Cells["colCartons"].Value);
                            oelPurchaseDetial.BatchNo = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colBatchNo"].Value);
                            oelPurchaseDetial.Expiry = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colExpiry"].Value);
                            oelPurchaseDetial.EngineNo = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colEngineNo"].Value);
                            oelPurchaseDetial.ChasisNo = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colChassisNo"].Value);
                            oelPurchaseDetial.VehicleModel = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colVehicleModel"].Value);
                            oelPurchaseDetial.VehicleNo = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colVehicleNo"].Value);
                            oelPurchaseDetial.FirstIMEI = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colFirstIMEI"].Value);
                            oelPurchaseDetial.SecondIMEI = Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colSecondIMEI"].Value);
                            if (DgvStockReceipt.Rows[i].Cells["colVehicleColors"].Value != null && Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colVehicleColors"].Value) != string.Empty)
                            {
                                if (Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colVehicleColors"].Value) == "Red")
                                {
                                    oelPurchaseDetial.ColorCode = 1;
                                }
                                else if (Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colVehicleColors"].Value) == "Black")
                                {
                                    oelPurchaseDetial.ColorCode = 2;
                                }
                                else if (Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colVehicleColors"].Value) == "Blue")
                                {
                                    oelPurchaseDetial.ColorCode = 3;
                                }
                                else if (Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colVehicleColors"].Value) == "Silver")
                                {
                                    oelPurchaseDetial.ColorCode = 4;
                                }
                            }

                            oelPurchaseDetial.Units = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colQty"].Value);
                            oelPurchaseDetial.ItemWeight = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colWeight"].Value);
                            //oelPurchaseDetial.Bonus = Validation.GetSafeInteger(DgvStockReceipt.Rows[i].Cells["colBonus"].Value);
                            oelPurchaseDetial.RemainingUnits = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colQty"].Value);
                            oelPurchaseDetial.UnitPrice = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colUnitPrice"].Value);
                            oelItem.CurrentUnitPrice = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colUnitPrice"].Value);
                            oelPurchaseDetial.Discount = 0;//Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colDisc"].Value);
                            oelPurchaseDetial.Amount = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);

                            oelItemsCollection.Add(oelItem);
                            oelPurchaseDetailCollection.Add(oelPurchaseDetial);
                        }
                        #endregion
                        #region Add Supplier
                        if (!IsNetTransaction)
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
                            oelSupplierTransaction.IsNetTransaction = IsNetTransaction;
                            oelSupplierTransaction.SeqNo = 1;
                            oelSupplierTransaction.TrackNumber = 1;
                            oelSupplierTransaction.IdProject = Operations.IdProject;
                            oelSupplierTransaction.BookNo = Operations.BookNo;
                            oelSupplierTransaction.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                            oelSupplierTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelSupplierTransaction.AccountNo = SupplierAccountNo;
                            oelSupplierTransaction.SubAccountNo = "0";
                            //oelSupplierTransaction.Date = VDate.Value;
                            //if (VoucherDateTime.Value != VDate.Value)
                            //    oelSupplierTransaction.Date = VDate.Value;
                            //else
                            //    oelSupplierTransaction.Date = DateTime.Now;
                            if (!IdVoucher.HasValue)
                            {
                                oelSupplierTransaction.CreatedDateTime = VDate.Value;
                            }
                            else
                            {
                                if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && VoucherDateTime == null)
                                    oelSupplierTransaction.CreatedDateTime = VDate.Value;
                                else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                    oelSupplierTransaction.CreatedDateTime = VEditedDateTime.Value;
                                else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                    oelSupplierTransaction.CreatedDateTime = VEditedDateTime.Value;
                                else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged)
                                    oelSupplierTransaction.CreatedDateTime = VEditedDateTime.Value;
                                else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged && VEditedDateTime.Value > DateTime.Now)
                                    oelSupplierTransaction.CreatedDateTime = VEditedDateTime.Value;
                                else
                                    oelSupplierTransaction.CreatedDateTime = DateTime.Now;
                            }
                            oelSupplierTransaction.VoucherType = "PR";
                            oelSupplierTransaction.TransactionType = 1;
                            oelSupplierTransaction.TransactionMode = "DR";
                            if (oelSoftwareCheck != null && oelSoftwareCheck.IsMust.Value)
                            {
                                oelSupplierTransaction.Description = BuildRemarks(); //txtDescription.Text;
                            }
                            else
                            {
                                oelSupplierTransaction.Description = txtDescription.Text;
                            }
                            oelSupplierTransaction.Debit = Validation.GetSafeDecimal(txtTotalAmount.Text);

                            oelSupplierTransaction.Credit = 0;
                            oelSupplierTransaction.Posted = chkPosted.Checked;
                            //oelSupplierTransaction.CreatedDateTime = VDate.Value;

                            oelCostOfSalesCollection.Add(oelSupplierTransaction);
                        }
                        #endregion
                        #region Add Cash
                        if (IsNetTransaction)
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
                            oelCashTransaction.IsNetTransaction = IsNetTransaction;
                            oelCashTransaction.SeqNo = 1;
                            oelCashTransaction.TrackNumber = 1;
                            oelCashTransaction.IdProject = Operations.IdProject;
                            oelCashTransaction.BookNo = Operations.BookNo;
                            oelCashTransaction.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                            oelCashTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCashTransaction.AccountNo = CashAccountNo;
                            oelCashTransaction.SubAccountNo = "0";
                            //oelCashTransaction.Date = VDate.Value;
                            //if (VoucherDateTime.Value != VDate.Value)
                            //    oelCashTransaction.Date = VDate.Value;
                            //else
                            //    oelCashTransaction.Date = DateTime.Now;
                            if (!IdVoucher.HasValue)
                            {
                                oelCashTransaction.CreatedDateTime = VDate.Value;
                            }
                            else
                            {
                                if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && VoucherDateTime == null)
                                    oelCashTransaction.CreatedDateTime = VDate.Value;
                                else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                    oelCashTransaction.CreatedDateTime = VEditedDateTime.Value;
                                else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                    oelCashTransaction.CreatedDateTime = VEditedDateTime.Value;
                                else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged)
                                    oelCashTransaction.CreatedDateTime = VEditedDateTime.Value;
                                else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged && VEditedDateTime.Value > DateTime.Now)
                                    oelCashTransaction.CreatedDateTime = VEditedDateTime.Value;
                                else
                                    oelCashTransaction.CreatedDateTime = DateTime.Now;
                            }
                            oelCashTransaction.VoucherType = "PR";
                            oelCashTransaction.TransactionType = 1;
                            oelCashTransaction.TransactionMode = "DR";
                            if (txtDescription.Text == string.Empty)
                            {
                                oelCashTransaction.Description = "Purchases Return To : " + SEditBox.Text;
                            }
                            else
                            oelCashTransaction.Description = txtDescription.Text;

                            oelCashTransaction.Debit = Validation.GetSafeDecimal(txtTotalAmount.Text);

                            oelCashTransaction.Credit = 0;
                            oelCashTransaction.Posted = true; //chkPosted.Checked;
                            //oelCashTransaction.CreatedDateTime = VDate.Value;

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
                        oelPurchaseTransaction.IsNetTransaction = IsNetTransaction;
                        oelPurchaseTransaction.SeqNo = 2;
                        oelPurchaseTransaction.TrackNumber = 2;
                        oelPurchaseTransaction.IdProject = Operations.IdProject;
                        oelPurchaseTransaction.BookNo = Operations.BookNo;
                        oelPurchaseTransaction.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                        oelPurchaseTransaction.IdVoucher = oelVoucher.IdVoucher;
                        //oelPurchaseTransaction.AccountNo = Validation.GetSafeLong(PurchasesEditBox.Text);
                        oelPurchaseTransaction.AccountNo = PurchasesAccountNo;
                        oelPurchaseTransaction.SubAccountNo = "0";
                        //oelPurchaseTransaction.Date = VDate.Value;
                        //if (VoucherDateTime.Value != VDate.Value)
                        //    oelPurchaseTransaction.Date = VDate.Value;
                        //else
                        //    oelPurchaseTransaction.Date = DateTime.Now;
                        if (!IdVoucher.HasValue)
                        {
                            oelPurchaseTransaction.CreatedDateTime = VDate.Value;
                        }
                        else
                        {
                            if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && VoucherDateTime == null)
                                oelPurchaseTransaction.CreatedDateTime = VDate.Value;
                            else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                oelPurchaseTransaction.CreatedDateTime = VEditedDateTime.Value;
                            else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                oelPurchaseTransaction.CreatedDateTime = VEditedDateTime.Value;
                            else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged)
                                oelPurchaseTransaction.CreatedDateTime = VEditedDateTime.Value;
                            else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged && VEditedDateTime.Value > DateTime.Now)
                                oelPurchaseTransaction.CreatedDateTime = VEditedDateTime.Value;
                            else
                                oelPurchaseTransaction.CreatedDateTime = DateTime.Now;
                        }
                        oelPurchaseTransaction.VoucherType = "PR";
                        oelPurchaseTransaction.TransactionType = 2;
                        if (txtDescription.Text == string.Empty)
                        {
                            oelPurchaseTransaction.Description = "Inventory Account Credited Against Purchases Return To :" + SEditBox.Text;
                        }
                        else
                            oelPurchaseTransaction.Description = txtDescription.Text;
                        oelPurchaseTransaction.Credit = Validation.GetSafeDecimal(txtTotalAmount.Text);
                        oelPurchaseTransaction.Debit = 0;
                        oelPurchaseTransaction.TransactionMode = "CR";
                        //oelPurchaseTransaction.CreatedDateTime = VDate.Value;
                        oelPurchaseTransaction.Posted = chkPosted.Checked;

                        oelCostOfSalesCollection.Add(oelPurchaseTransaction);
                        #endregion region
                        #region Add Cost of Sales Transactions
                        for (int j = 0; j < DgvPurchases.Rows.Count - 1; j++)
                        {
                            VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                            oelVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
                            oelVoucherDetail.IdProject = Operations.IdProject;
                            oelVoucherDetail.BookNo = Operations.BookNo;
                            oelVoucherDetail.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                            if (DgvPurchases.Rows[j].Cells["ColIdDetailVoucher"].Value != null)
                            {
                                oelVoucherDetail.IdTransactionDetail = Validation.GetSafeLong(DgvPurchases.Rows[j].Cells["ColIdDetailVoucher"].Value.ToString());
                                oelVoucherDetail.IsNew = false;
                            }
                            else
                            {
                                oelVoucherDetail.IdTransactionDetail = 0;
                                oelVoucherDetail.IsNew = true;

                            }
                            oelVoucherDetail.VoucherNo = Validation.GetSafeLong(VEditBox.Text);
                            if (DgvPurchases.Rows[j].Cells["colDescription"].Value == null)
                            {
                                oelVoucherDetail.Description = "N/A";
                            }
                            else
                            {
                                oelVoucherDetail.Description = DgvPurchases.Rows[j].Cells["colDescription"].Value.ToString();
                            }
                            oelVoucherDetail.IsNetTransaction = IsNetTransaction;
                            oelVoucherDetail.SeqNo = j + 3;
                            oelVoucherDetail.TrackNumber = j + 3;
                            oelVoucherDetail.VoucherType = "PR";
                            oelVoucherDetail.IdAccount = Validation.GetSafeLong(DgvPurchases.Rows[j].Cells["colIdAccount"].Value);
                            oelVoucherDetail.AccountNo = Validation.GetSafeString(DgvPurchases.Rows[j].Cells["colAccountNo"].Value);
                            oelVoucherDetail.Debit = Validation.GetSafeDecimal(DgvPurchases.Rows[j].Cells["colDebit"].Value);
                            if (oelVoucherDetail.Debit > 0)
                            {
                                oelVoucherDetail.TransactionMode = "DR";
                            }
                            else
                            {
                                oelVoucherDetail.TransactionMode = "CR";
                            }
                            oelVoucherDetail.Credit = Validation.GetSafeDecimal(DgvPurchases.Rows[j].Cells["colCredit"].Value);
                            //oelVoucherDetail.CreatedDateTime = VDate.Value;
                            //if (VoucherDateTime.Value != VDate.Value)
                            //    oelVoucherDetail.CreatedDateTime = VDate.Value;
                            //else
                            //    oelVoucherDetail.CreatedDateTime = DateTime.Now;
                            if (!IdVoucher.HasValue)
                            {
                                oelVoucherDetail.CreatedDateTime = VDate.Value;
                            }
                            else
                            {
                                if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && VoucherDateTime == null)
                                    oelVoucherDetail.CreatedDateTime = VDate.Value;
                                else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                    oelPurchaseTransaction.CreatedDateTime = VEditedDateTime.Value;
                                else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && IsEditedDateChanged)
                                    oelVoucherDetail.CreatedDateTime = VEditedDateTime.Value;
                                else if (VoucherPreviousBillAmount == Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged)
                                    oelVoucherDetail.CreatedDateTime = VEditedDateTime.Value;
                                else if (VoucherPreviousBillAmount != Validation.GetSafeDecimal(txtTotalAmount.Text) && !IsEditedDateChanged && VEditedDateTime.Value > DateTime.Now)
                                    oelVoucherDetail.CreatedDateTime = VEditedDateTime.Value;
                                else
                                    oelVoucherDetail.CreatedDateTime = DateTime.Now;
                            }
                            oelCostOfSalesCollection.Add(oelVoucherDetail);

                        }
                        #endregion
                        #region Saving Code
                        if (IdVoucher == null || IdVoucher == 0)
                        {
                            var manager = new PurchaseHeadBLL();
                            if (MessageBox.Show("Confirm Save It ? ", "Save", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                EntityoperationInfo infoResult = manager.InsertPurchasesReturn(oelVoucher, oelPurchaseDetailCollection, oelCostOfSalesCollection);
                                if (infoResult.IsSuccess)
                                {
                                    lblStatuMessage.Text = "Stock Return Successfully To Supplier...";
                                    ClearControls();
                                    FillData();
                                }
                            }
                        }
                        else
                        {
                            var manager = new PurchaseHeadBLL();
                            var VManager = new VoucherBLL();
                            var ItemManager = new ItemsBLL();
                            if (SilentSave == 1)
                            { 
                                EntityoperationInfo infoResult = manager.UpdatePurchasesReturn(oelVoucher, oelPurchaseDetailCollection, oelCostOfSalesCollection);
                                if (infoResult.IsSuccess)
                                {
                                    SilentSave = 2;
                                }
                            }
                            if (MessageBox.Show("Confirm Update It ? ", "Update", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                            {
                                EntityoperationInfo infoResult = manager.UpdatePurchasesReturn(oelVoucher, oelPurchaseDetailCollection, oelCostOfSalesCollection);
                                if (infoResult.IsSuccess)
                                {
                                    lblStatuMessage.Text = "Stock Returned To Supplier Updated Successfully...";
                                    ClearControls();
                                    FillData();
                                    SilentSave = 2;
                                }
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
                            if (manager.DeletePurchasesReturnByVoucher(IdVoucher.Value, Operations.IdProject))
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
                        if (manager.DeletePurchasesReturnByVoucher(IdVoucher.Value, Operations.IdProject))
                        {
                            MessageBox.Show("Voucher Deleted Successfully and Transactions Rolled Back");
                            ClearControls();
                        }
                    }
                }
                //PurchaseStockReceiptBLL();
                else if (MessageBox.Show("Are You Sure To Delete ?", "Deleting Voucher", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (manager.DeletePurchasesReturnByVoucher(IdVoucher.Value, Operations.IdProject))
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
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (SupplierAccountNo != string.Empty)
            {
                frmpersons = new frmPersons();
                frmpersons.AccountNo = SupplierAccountNo;
                frmpersons.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Supplier To View Detail....");
            }
        }
        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            frmaccounts = new frmAccounts();
            frmaccounts.Show();
        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
            FillData();
            SEditBox.Focus();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (VEditBox.Text != string.Empty)
            {
                long NextVoucherNo = Convert.ToInt64(VEditBox.Text);
                NextVoucherNo += 1;
                VEditBox.Text = NextVoucherNo.ToString();
                FillPurchasesReturnByNumber(NextVoucherNo);
            }
            else
            {
                MessageBox.Show("Please Load Any Purchase Return To Move Forward");
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            //if (VEditBox.Text != string.Empty)
            //{
            //    long PreviousVoucherNo = Convert.ToInt64(VEditBox.Text);
            //    PreviousVoucherNo -= 1;
            //    VEditBox.Text = PreviousVoucherNo.ToString();
            //    FillPurchasesReturnByNumber(PreviousVoucherNo);
            //}
            //else
            //{
            //    MessageBox.Show("Please Load Any Purchase Return To Move Back");
            //}
            if (VEditBox.Text != string.Empty)
            {
                long PreviousVoucherNo = Convert.ToInt64(VEditBox.Text);
                if (PreviousVoucherNo > 1)
                {
                    PreviousVoucherNo -= 1;
                    VEditBox.Text = PreviousVoucherNo.ToString();
                    FillPurchasesReturnByNumber(PreviousVoucherNo);
                }
                else
                {
                    MessageBox.Show("Can Not Go Back");
                }
            }
            else
            {
                MessageBox.Show("Please Load Any Invoice First Then Move Back....");
            } 
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region DropDown Events
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
            frmfindVouchers.VoucherType = VoucherTypes.StockReturnVoucher.ToString();
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
                    FillPurchasesReturnByNumber(Validation.GetSafeLong(VEditBox.Text));
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
                        rdCredit.Focus();
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
        private void txtBillNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SEditBox.Focus();
            }
        }
        private void txtFreightAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (e.KeyChar == (char)Keys.Enter)
            {
                //e.Handled = true;
                //decimal ActualAmount = Validation.GetSafeDecimal(txtBillAmount.Text);
                //decimal Resultant = ActualAmount + Validation.GetSafeDecimal(txtFreightAmount.Text);
                //txtTotalAmount.Text = Resultant.ToString();
                CalculateProceduralTotalWeightWithAmount();
                btnSave.Focus();
            }
        }
        private void txtManualWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (e.KeyChar == (char)Keys.Enter)
            {
                txtFreightAmount.Focus();
            }
        }
        private void txtManualWeight_Leave(object sender, EventArgs e)
        {
            CalculateProceduralTotalWeightWithAmount();
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
            else if (EventCommandName == "DgvPurchases")
            {
                DgvPurchases.RefreshEdit();
                DgvPurchases.CurrentRow.Cells["colAccountNo"].Value = oelAccount.AccountNo;
                DgvPurchases.CurrentRow.Cells["colIdAccount"].Value = oelAccount.IdAccount;
                DgvPurchases.CurrentRow.Cells["colAccountName"].Value = oelAccount.AccountName;
                list = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, oelAccount.AccountNo);
                if (list.Count > 0)
                {
                    DgvPurchases.CurrentRow.Cells["colClosingBalance"].Value = list[0].ClosingBalance;
                }
                else
                {
                    DgvPurchases.CurrentRow.Cells["colClosingBalance"].Value = 0;
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
                lblStatuMessage.Text = "";
                DgvStockReceipt.CurrentRow.Cells["colAutoWeight"].Value = manager.GetItemById(oelItems.IdItem.Value)[0].AutoWeightItemIndex;
                DgvStockReceipt.CurrentRow.Cells["colIdItem"].Value = oelItems.IdItem;
                DgvStockReceipt.CurrentRow.Cells["colItemName"].Value = oelItems.ItemName;
                DgvStockReceipt.CurrentRow.Cells["colpacking"].Value = oelItems.PackingSize;
                //DgvStockReceipt.CurrentRow.Cells["ColBatch"].Value = oelItems.BatchNo;
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
        #region Tabs Related Events And Methods
        private void tabPurchaseTransactions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabPurchaseTransactions.SelectedIndex == 1)
                CreateAndInitializeFooterRow();
        }
        #endregion
        #region Stock Grid Events
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
            if (DgvStockReceipt.CurrentCellAddress.X == 4)
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
            if (DgvStockReceipt.CurrentCellAddress.X == 4)
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
        private void DgvStockReceipt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DgvStockReceipt_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 20)
            {
                e.Value = "Delete";
            }
        }
        private void DgvStockReceipt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal lineAmount, value = 0;
            if (e.ColumnIndex == 20)
            {
                if (DgvStockReceipt.Rows[e.RowIndex].Cells["ColIdVoucherDetail"].Value == null)
                {
                    if (DgvStockReceipt.Rows.Count > 1)
                    {
                        DataGridViewRow oRow = DgvStockReceipt.Rows[e.RowIndex];
                        DgvStockReceipt.Rows.Remove(oRow);
                    }
                    DataGridViewCell oCell = DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"];
                    for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                    {
                        value += Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);
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
                    //if (!chkPosted.Checked)
                    if (!chkPosted.Checked)
                    {
                        if (DgvStockReceipt.Rows.Count - 1 == 1)
                        {
                            MessageBox.Show("There Is Only One Record In This Voucher , Please Press Delete Button To Remove This Voucher");
                            return;
                        }
                        var Manager = new VoucherBLL();
                        lineAmount = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value);
                        txtBillAmount.Text = (Validation.GetSafeDecimal(txtBillAmount.Text) - lineAmount).ToString();
                        txtTotalAmount.Text = Validation.GetSafeString(Validation.GetSafeDecimal(txtBillAmount.Text) + Validation.GetSafeDecimal(txtFreightAmount.Text));
                        if (MessageBox.Show("Do Want To Delete It ?", "Deleting Rows", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                        {
                            if (Manager.DeleteChildRecords(Validation.GetSafeLong(DgvStockReceipt.Rows[e.RowIndex].Cells["ColIdVoucherDetail"].Value), "StockReceiptVoucher"))
                            {

                                DataGridViewRow oRow = DgvStockReceipt.Rows[e.RowIndex];
                                DgvStockReceipt.Rows.Remove(oRow);
                                for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                                {
                                    OldValue += Convert.ToDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);
                                }
                                txtBillAmount.Text = OldValue.ToString();
                                txtTotalAmount.Text = Validation.GetSafeString(OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text));
                                OldValue = 0;
                                SilentSave = 1;
                                btnSave_Click(sender, e);
                                //MessageBox.Show("This Voucher and Party Ledger Updated Automatically...");

                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Voucher Is Posted...");
                    }

                }
            }
        }
        private void DgvStockReceipt_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DgvStockReceipt.IsCurrentCellDirty)
            {
                DgvStockReceipt.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void DgvStockReceipt_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colAmount")
            //{
            //    OldValue = Convert.ToInt32(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value);
            //}
        }
        private void DgvStockReceipt_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var manager = new ItemsBLL();
            if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colQty")
            {
                decimal ItemWeight = manager.GetItemById(Validation.GetSafeLong(DgvStockReceipt.Rows[e.RowIndex].Cells["colIdItem"].Value))[0].ItemWeight;
                if (ItemWeight == 0)
                {
                    DgvStockReceipt.Rows[e.RowIndex].Cells["colWeight"].Value = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value);
                }
                else
                {
                    DgvStockReceipt.Rows[e.RowIndex].Cells["colWeight"].Value = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value) * ItemWeight;
                }
                if (Validation.GetSafeLong(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value) > 0)
                {
                    //DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value);
                    DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colWeight"].Value);
                }
                else
                {
                    DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = 0;
                }
            }
            if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colUnitPrice")
            {
                //DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colWeight"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);
                }
                txtBillAmount.Text = OldValue.ToString();
                txtTotalAmount.Text = Validation.GetSafeString(OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text));
                OldValue = 0;
                CalculateTotalWeight();
            }
            //else if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colDisc")
            //{
            //    if (Validation.GetSafeInteger(DgvStockReceipt.Rows[e.RowIndex].Cells[e.ColumnIndex].Value) != 0)
            //    {
            //        DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = (Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value)) * (Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colDisc"].Value)) / 100;
            //    }
            //    else
            //    {
            //        DgvStockReceipt.Rows[e.RowIndex].Cells["colDisc"].Value = "";
            //    }
            //}
            //else if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colExpiry")
            //{
            //    if (DgvStockReceipt.Rows[e.RowIndex].Cells["colExpiry"].Value != null)
            //    {
            //        bool Value = DgvStockReceipt.Rows[e.RowIndex].Cells["colExpiry"].Value.ToString().Contains('/');
            //        if (Value == false)
            //        {
            //            MessageBox.Show("Wrong Expiry Date");
            //            DgvStockReceipt.Rows[e.RowIndex].Cells["colExpiry"].Value = "";
            //        }
            //        else
            //        {
            //            string[] splitString = DgvStockReceipt.Rows[e.RowIndex].Cells["colExpiry"].Value.ToString().Split('/');
            //            if (splitString.Length == 3)
            //            {
            //                MessageBox.Show("Wrong Expiry Date");
            //                DgvStockReceipt.Rows[e.RowIndex].Cells["colExpiry"].Value = "";
            //            }
            //            else if (splitString.Length == 2)
            //            {
            //                int Year = Validation.GetSafeInteger(splitString[1]);
            //                int Month = Validation.GetSafeInteger(splitString[0]);
            //                int compareyear = Validation.GetSafeInteger(DateTime.Now.Year.ToString().Substring(2));
            //                int CurrentMonth = Validation.GetSafeInteger(DateTime.Now.Month.ToString());
            //                if (Year == compareyear)
            //                {
            //                    if (Month < CurrentMonth)
            //                    {
            //                        MessageBox.Show("Wrong Expiry Date.. Expiry Month is smaller then current Month");
            //                        DgvStockReceipt.Rows[e.RowIndex].Cells["colExpiry"].Value = "";
            //                    }
            //                }
            //                else if (Year < compareyear)
            //                {
            //                    MessageBox.Show("Wrong Expiry Date.. Expiry Year is smaller then current year");
            //                    DgvStockReceipt.Rows[e.RowIndex].Cells["colExpiry"].Value = "";
            //                }
            //            }
            //        }
            //    }
            //}
            //else if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colAmount")
            //{
            //    decimal value = 0;
            //    if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colAmount")
            //    {
            //        if (OldValue > Convert.ToInt32(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value))
            //        {
            //            value = OldValue;
            //            txtTotalAmount.Text = (((Convert.ToInt64(txtTotalAmount.Text == "" ? "0" : txtTotalAmount.Text) + Convert.ToInt64(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value) - (value))).ToString());
            //        }
            //        else if (OldValue < Convert.ToDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value))
            //        {
            //            value = Convert.ToDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value) - OldValue;
            //            txtTotalAmount.Text = (Convert.ToDecimal(txtTotalAmount.Text == "" ? "0" : txtTotalAmount.Text) + (value)).ToString();
            //        }
            //        DgvStockReceipt.Text = (DgvStockReceipt.Rows.Count - 1).ToString();
            //    }
            //}
        }
        private void DgvStockReceipt_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colUnitPrice")
            {
                //DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = (Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value));
                DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = (Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colWeight"].Value));
            }
            else if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colAmount")
            {
                //DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colWeight"].Value) * Validation.GetSafeDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                {
                    OldValue += Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);
                }
                txtBillAmount.Text = OldValue.ToString();
                //txtTotalAmount.Text = Validation.GetSafeString(OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text));
                OldValue = 0;
                CalculateProceduralTotalWeightWithAmount();
            }
            //DgvStockReceipt.EndEdit();
            //if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colUnitPrice")
            //{
            //    DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value = Convert.ToInt64(DgvStockReceipt.Rows[e.RowIndex].Cells["colQty"].Value) * Convert.ToDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colUnitPrice"].Value);

            //}

            //else if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colAmount")
            //{
            //    if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colAmount")
            //    {
            //        for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
            //        {
            //            OldValue += Convert.ToDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);
            //        }
            //        txtTotalAmount.Text = OldValue.ToString();
            //        OldValue = 0;
            //    }
            //}
            //{
            //    Int64 value = 0;
            //    if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colAmount")
            //    {
            //        if (OldValue > Convert.ToInt32(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value))
            //        {
            //            value = OldValue;
            //            txtTotalAmount.Text = (((Convert.ToInt64(txtTotalAmount.Text == "" ? "0" : txtTotalAmount.Text) + Convert.ToInt64(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value) - (value))).ToString());
            //        }
            //        else if (OldValue < Convert.ToDecimal(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value))
            //        {
            //            value = Convert.ToInt64(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value) - OldValue;
            //            txtTotalAmount.Text = (Convert.ToDecimal(txtTotalAmount.Text == "" ? "0" : txtTotalAmount.Text) + (value)).ToString();
            //        }
            //        else
            //        {
            //            txtTotalAmount.Text = OldValue.ToString();
            //        }
            //        OldValue = 0;
            //        DgvStockReceipt.Text = (DgvStockReceipt.Rows.Count - 1).ToString();
            //    }
            //}
        }
        private void DgvStockReceipt_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvStockReceipt.Columns["colVehicleColors"].Visible)
            {
                if (e.ColumnIndex == 12)
                {
                    SendKeys.Send("{F4}");
                }
            }
        }
        private void DgvStockReceipt_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
        {
            //DgvStockReceipt.EndEdit();
            //if (!DgvStockReceipt.IsCurrentRowDirty)
            //{
            //    e.Cancel = false;
            //}
            //else
            //{
            //    e.Cancel = true;
            //}
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
        #region Purchases Grid Code and Events
        private void DgvPurchases_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvPurchases.Columns[e.ColumnIndex].Name == "colDebit")
            {

                for (int i = 0; i < DgvPurchases.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvPurchases.Rows[i].Cells["colDebit"].Value);
                }
                //txtAmount.Text = OldValue.ToString();
                txtDebit.Text = OldValue.ToString();
                OldValue = 0;

            }
            else if (DgvPurchases.Columns[e.ColumnIndex].Name == "colCredit")
            {
                for (int i = 0; i < DgvPurchases.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvPurchases.Rows[i].Cells["colCredit"].Value);
                }
                //txtAmount.Text = OldValue.ToString();
                txtCredit.Text = OldValue.ToString();
                OldValue = 0;
            }
        }
        private void DgvPurchases_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvPurchases.Columns[e.ColumnIndex].Name == "colDebit")
            {
                if (DgvPurchases.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    DgvPurchases.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
            else if (DgvPurchases.Columns[e.ColumnIndex].Name == "colCredit")
            {
                if (DgvPurchases.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    DgvPurchases.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
        }
        private void DgvPurchases_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvPurchases.CurrentCellAddress.X == 3)
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
            if (DgvPurchases.CurrentCellAddress.X == 3)
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
                {
                    frmAccount = new frmFindAccounts();
                    EventCommandName = "DgvPurchases";
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
        #endregion
        #region Grids Transactions Related Methods
        private void FillVoucher()
        {
            var Manager = new VoucherBLL();
            var PManager = new PurchaseHeadBLL();
            VoucherType = "PR";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(VEditBox.Text));
            List<VoucherDetailEL> ListPurchases = PManager.GetPurchasesReturnTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, IsNetTransaction);
            if (ListPurchases.Count > 0)
            {
                IdVoucher = ListPurchases[0].IdVoucher;
                VEditBox.Enabled = false;
                txtBiltyNo.Text = ListPurchases[0].BiltyNo;
                txtBillNo.Text = ListPurchases[0].BillNo;
                txtSheetNo.Text = Validation.GetSafeString(ListPurchases[0].SheetNo);
                VDate.Value = ListPurchases[0].VDate.Value;
                DateStatus = 0;
                if (ListPurchases[0].EditedDateTime != null)
                {
                    VoucherDateTime = ListPurchases[0].EditedDateTime.Value;
                    VEditedDateTime.Value = ListPurchases[0].EditedDateTime.Value;
                }
                else
                {
                    //VEditedDateTime.Value = VDate.Value;
                    VEditedDateTime.Value = DateTime.Now;
                    VoucherDateTime = null;
                }
                if (VoucherDateTime == null)
                {
                    VDate.Enabled = true;
                    VEditedDateTime.Enabled = false;
                }
                else
                {
                    VEditedDateTime.Enabled = true;
                    VDate.Enabled = false;
                }
                DateStatus = 1;
                txtDescription.Text = ListPurchases[0].VDiscription;
                txtFreightAmount.Text = ListPurchases[0].TotalFreight.ToString();
                txtBillAmount.Text = ListPurchases[0].BillAmount.ToString();
                txtTotalAmount.Text = ListPurchases[0].TotalAmount.ToString();
                txtsystemweight.Text = Validation.GetSafeString(ListPurchases[0].SystemWeight);
                txtManualWeight.Text = Validation.GetSafeString(ListPurchases[0].ManualWeight);
                txt2kgWeight.Text = Validation.GetSafeString(ListPurchases[0].AutoWeight);
                VoucherPreviousBillAmount = ListPurchases[0].TotalAmount;
                cbxAdjustmentTypes.SelectedValue = ListPurchases[0].IdStockAdjustmentType;
                if (ListPurchases[0].IsNetTransaction.Value)
                    rdCash.Checked = true;
                else
                    rdCredit.Checked = true;
                SupplierAccountNo = ListPurchases[0].AccountNo;
                // if (!IsNetTransaction)
                //{
                FillCreditor(ListPurchases[0].AccountNo);
                FillCreditorCredentials(ListPurchases[0].AccountNo);
                //}
                chkPosted.Checked = ListPurchases[0].Posted.Value;
                if (ListPurchases[0].Posted.Value)
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

                FillPurchases(ListPurchases);

                List<VoucherDetailEL> listTransactions = PManager.GetPurchasesReturnSubTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, IsNetTransaction);

                HandleVoucher(ListPurchases);
                FillHeadTransactions(listTransactions);
                FillPurchasesTransactions(listTransactions);

            }
            else
            {
                MessageBox.Show("Voucher Number Not Found ...");
                ClearControls();
            }
        }
        private void FillPurchasesReturnByNumber(Int64 PNo)
        {
            var Manager = new VoucherBLL();
            var PManager = new PurchaseHeadBLL();
            VoucherType = "PR";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            //List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(VEditBox.Text));
            List<VoucherDetailEL> ListPurchases = PManager.GetPurchasesReturnTransactionsByNumber(PNo, Operations.IdProject, Operations.BookNo, IsNetTransaction);
            if (ListPurchases.Count > 0)
            {
                IdVoucher = ListPurchases[0].IdVoucher;
                VEditBox.Enabled = false;
                VEditBox.Text = Validation.GetSafeString(ListPurchases[0].VoucherNo);
                txtBiltyNo.Text = ListPurchases[0].BiltyNo;
                txtBillNo.Text = ListPurchases[0].BillNo;
                txtSheetNo.Text = Validation.GetSafeString(ListPurchases[0].SheetNo);
                VDate.Value = ListPurchases[0].VDate.Value;
                DateStatus = 0;
                if (ListPurchases[0].EditedDateTime != null)
                {
                    VoucherDateTime = ListPurchases[0].EditedDateTime.Value;
                    VEditedDateTime.Value = ListPurchases[0].EditedDateTime.Value;
                }
                else
                {
                    //VEditedDateTime.Value = VDate.Value;
                    VEditedDateTime.Value = DateTime.Now;
                    VoucherDateTime = null;
                }
                if (VoucherDateTime == null)
                {
                    VDate.Enabled = true;
                    VEditedDateTime.Enabled = false;
                }
                else
                {
                    VEditedDateTime.Enabled = true;
                    VDate.Enabled = false;
                }
                DateStatus = 1;
                txtDescription.Text = ListPurchases[0].VDiscription;
                txtFreightAmount.Text = ListPurchases[0].TotalFreight.ToString();
                txtBillAmount.Text = ListPurchases[0].BillAmount.ToString();
                txtTotalAmount.Text = ListPurchases[0].TotalAmount.ToString();
                txtsystemweight.Text = Validation.GetSafeString(ListPurchases[0].SystemWeight);
                txtManualWeight.Text = Validation.GetSafeString(ListPurchases[0].ManualWeight);
                txt2kgWeight.Text = Validation.GetSafeString(ListPurchases[0].AutoWeight);
                VoucherPreviousBillAmount = ListPurchases[0].TotalAmount;
                cbxAdjustmentTypes.SelectedValue = ListPurchases[0].IdStockAdjustmentType;

                if (ListPurchases[0].IsNetTransaction.Value)
                    rdCash.Checked = true;
                else
                    rdCredit.Checked = true;

                SupplierAccountNo = ListPurchases[0].AccountNo;
                // if (!IsNetTransaction)
                //{
                FillCreditor(ListPurchases[0].AccountNo);
                FillCreditorCredentials(ListPurchases[0].AccountNo);
                //}
                chkPosted.Checked = ListPurchases[0].Posted.Value;
                if (ListPurchases[0].Posted.Value)
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

                FillPurchases(ListPurchases);

                List<VoucherDetailEL> listTransactions = PManager.GetPurchasesReturnSubTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, IsNetTransaction);

                HandleVoucher(ListPurchases);
                FillHeadTransactions(listTransactions);
                FillPurchasesTransactions(listTransactions);

            }
            else
            {
                MessageBox.Show("Voucher Number Not Found ...");
                ClearControls();
            }
        }
        private void VEditedDateTime_ValueChanged(object sender, EventArgs e)
        {
            if (DateStatus == 0)
                IsEditedDateChanged = false;
            else
            {
                if (DateTime.Now.ToShortDateString() != VEditedDateTime.Value.ToShortDateString())
                    IsEditedDateChanged = true;
                else
                    IsEditedDateChanged = false;
            }
        }
        private void HandleVoucher(List<VoucherDetailEL> list)
        {
            if (list[0].Posted.Value && list[0].IsDeleted == true)
            {
                //if (Operations.IdRole != Validation.GetSafeGuid(EnRoles.Administrator))
                {
                    btnSave.Enabled = false;
                    //btnDelete.Enabled = false;
                    chkPosted.Enabled = false;
                }
                lblVoucherStatus.Visible = true;
                lblVoucherStatus.Text = "Deleted Voucher";
                chkPosted.Checked = list[0].Posted.Value;
            }
            else if (!list[0].Posted.Value && !list[0].IsDeleted == true)
            {
                {
                    btnSave.Enabled = true;
                    btnDelete.Enabled = true;
                    chkPosted.Enabled = true;
                }
                lblVoucherStatus.Visible = false;
            }
            else if (list[0].Posted.Value && !list[0].IsDeleted == true)
            {
                btnSave.Enabled = false;
                //btnDelete.Enabled = false;
                chkPosted.Enabled = false;
            }
            else if (!list[0].Posted.Value && list[0].IsDeleted == true)
            {
                btnSave.Enabled = false;
                //btnDelete.Enabled = false;
                chkPosted.Enabled = false;
                lblVoucherStatus.Visible = true;
                lblVoucherStatus.Text = "Deleted Voucher";
            }
            else if (list[0].Posted.Value && list[0].IsDeleted == null)
            {
                btnSave.Enabled = false;
                //btnDelete.Enabled = false;
                chkPosted.Enabled = false;
                lblVoucherStatus.Visible = true;
                lblVoucherStatus.Text = "Posted Voucher";
            }
            else if (!list[0].Posted.Value && list[0].IsDeleted == null)
            {
                btnSave.Enabled = true;
                //btnDelete.Enabled = false;
                chkPosted.Enabled = true;
                lblVoucherStatus.Visible = true;
                lblVoucherStatus.Text = "Unposted Voucher";
            }
            else
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void FillPurchases(List<VoucherDetailEL> List)
        {
            if (DgvStockReceipt.Rows.Count > 0)
            {
                DgvStockReceipt.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {

                for (int i = 0; i < List.Count; i++)
                {
                    DgvStockReceipt.Rows.Add();
                    //DgvStockReceipt.Rows[i].Cells[0].Value = List[i].TransactionID;
                    DgvStockReceipt.Rows[i].Cells[0].Value = List[i].IdVoucherDetail;
                    DgvStockReceipt.Rows[i].Cells[1].Value = List[i].AutoWeightItemIndex;
                    DgvStockReceipt.Rows[i].Cells[2].Value = List[i].IdItem;
                    DgvStockReceipt.Rows[i].Cells[3].Value = List[i].ItemNo;
                    DgvStockReceipt.Rows[i].Cells[4].Value = List[i].ItemName;
                    DgvStockReceipt.Rows[i].Cells[5].Value = List[i].PackingSize;
                    DgvStockReceipt.Rows[i].Cells[6].Value = List[i].TotalCartons;
                    DgvStockReceipt.Rows[i].Cells[7].Value = List[i].BatchNo;
                    DgvStockReceipt.Rows[i].Cells[8].Value = List[i].Expiry;
                    DgvStockReceipt.Rows[i].Cells[9].Value = List[i].EngineNo;
                    DgvStockReceipt.Rows[i].Cells[10].Value = List[i].ChasisNo;
                    DgvStockReceipt.Rows[i].Cells[11].Value = List[i].VehicleModel;
                    if (List[i].ColorCode == 1)
                    {
                        DgvStockReceipt.Rows[i].Cells[12].Value = "Red";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        DgvStockReceipt.Rows[i].Cells[12].Value = "Black";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        DgvStockReceipt.Rows[i].Cells[12].Value = "Blue";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        DgvStockReceipt.Rows[i].Cells[12].Value = "Silver";
                    }
                    DgvStockReceipt.Rows[i].Cells[13].Value = List[i].VehicleNo;
                    DgvStockReceipt.Rows[i].Cells[14].Value = List[i].FirstIMEI;
                    DgvStockReceipt.Rows[i].Cells[15].Value = List[i].SecondIMEI;


                    DgvStockReceipt.Rows[i].Cells[16].Value = List[i].Units;
                    DgvStockReceipt.Rows[i].Cells[17].Value = List[i].ItemWeight;
                    DgvStockReceipt.Rows[i].Cells[18].Value = List[i].UnitPrice;
                    DgvStockReceipt.Rows[i].Cells[19].Value = List[i].Amount;

                }
                CalculateTotalWeight();
            }
        }
        private void FillHeadTransactions(List<VoucherDetailEL> List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].TrackNumber == 1)
                {
                    if (!IsNetTransaction)
                    {
                        SupplierTransactionId = List[i].IdTransactionDetail;
                        SEditBox.Text = List[i].AccountName;
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
            }
        }
        private void FillPurchasesTransactions(List<VoucherDetailEL> List)
        {
            if (DgvPurchases.Rows.Count > 0)
            {
                DgvPurchases.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {
                List.RemoveAll(x => x.TrackNumber == 1 || x.TrackNumber == 2);
                for (int i = 0; i < List.Count; i++)
                {
                    if (List[i].TrackNumber != 1 && List[i].TrackNumber != 2)
                    {
                        DgvPurchases.Rows.Add();
                        DgvPurchases.Rows[i].Cells[0].Value = List[i].IdTransactionDetail;
                        DgvPurchases.Rows[i].Cells[1].Value = List[i].IdAccount;
                        DgvPurchases.Rows[i].Cells[2].Value = List[i].AccountNo;
                        DgvPurchases.Rows[i].Cells[3].Value = List[i].AccountName;
                        DgvPurchases.Rows[i].Cells[4].Value = List[i].ClosingBalance;
                        DgvPurchases.Rows[i].Cells[5].Value = List[i].Narration;
                        DgvPurchases.Rows[i].Cells[6].Value = List[i].Debit;
                        DgvPurchases.Rows[i].Cells[7].Value = List[i].Credit;
                    }
                }
                txtDebit.Text = List.Sum(x => x.Debit).ToString();
                txtCredit.Text = List.Sum(x => x.Credit).ToString();
            }
        }
        
        #endregion
        #region Radion Buttons Methods and Events
        private void rdCredit_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCredit.Checked)
            {
                IsNetTransaction = false;
                rdCash.Checked = false;
            }
        }
        private void rdCash_CheckedChanged(object sender, EventArgs e)
        {
            if (rdCash.Checked)
            {
                IsNetTransaction = true;
                rdCredit.Checked = false;
            }
        }
        private void rdCredit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && rdCredit.Checked)
            {
                DgvStockReceipt.Focus();
            }
            else
            {
                rdCash.Focus();
            }
        }
        private void rdCash_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && rdCash.Checked)
            {
                DgvStockReceipt.Focus();
            }
        }
        #endregion
        #region Weight Calculation
        private void CalculateTotalWeight()
        {
            decimal weight = 0;
            for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
            {
                weight += Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colWeight"].Value);
            }
            txtsystemweight.Text = weight.ToString();
        }
        private void CalculateProceduralTotalWeightWithAmount()
        {
            decimal weight = 0, AutoAmount = 0, ManualUnitPrice = 0, TotalManualWeightAmount = 0, TotalFinalAmount;
            if (txtManualWeight.Text != string.Empty && Validation.GetSafeDecimal(txtManualWeight.Text) > 0)
            {
                for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                {
                    if (Validation.GetSafeInteger(DgvStockReceipt.Rows[i].Cells["colAutoWeight"].Value) == 1)
                    {
                        weight += Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colWeight"].Value);
                        //AutoAmount += Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscountAmount"].Value);
                        AutoAmount += Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colAmount"].Value);
                    }
                }
                for (int i = 0; i < DgvStockReceipt.Rows.Count - 1; i++)
                {
                    if (Validation.GetSafeInteger(DgvStockReceipt.Rows[i].Cells["colAutoWeight"].Value) == 2)
                    {
                        ManualUnitPrice = Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colUnitPrice"].Value);
                        break;
                    }
                }
                txt2kgWeight.Text = Validation.GetSafeString(Validation.GetSafeDecimal(txtManualWeight.Text) - weight);
                TotalManualWeightAmount = ManualUnitPrice * Validation.GetSafeDecimal(txt2kgWeight.Text);
                TotalFinalAmount = (AutoAmount + TotalManualWeightAmount); //- (Validation.GetSafeDecimal(txtTotalDiscount.Text) + Validation.GetSafeDecimal(txtFlatDiscount.Text));

                txtTotalAmount.Text = Validation.GetSafeString(TotalFinalAmount + Validation.GetSafeDecimal(txtFreightAmount.Text));

                //txtTotalAmount.Text = Validation.GetSafeString((ActualAmount - Resultant) + Validation.GetSafeDecimal(txtFreightAmount.Text) + Validation.GetSafeDecimal(txtLoadingCharges.Text) + Validation.GetSafeDecimal(txtCuttingCharges.Text) + Validation.GetSafeDecimal(txtMiscCharges.Text));

            }
        }
        #endregion
    }
}
