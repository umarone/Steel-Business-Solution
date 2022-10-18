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
    public partial class frmDistributionSalesReturn : MetroForm
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
        public Int64? CustomerTransactionId { get; set; }
        public Int64? CashTransactionId { get; set; }
        public Int64? SalesTransactionId { get; set; }
        public string VoucherType { get; set; }
        string EventCommandName;
        int EventTime = 0;
        public bool IsNetTransaction { get; set; }
        public bool IsImportTransaction { get; set; }
        TextBox txtDebit = new TextBox();
        TextBox txtCredit = new TextBox();
        string CustomerAccountNo, SalesAccountNo = "", CashAccountNo = "", EmpAccountNo = "0", EmpDeliveryAccountNo = "";
        decimal DisCountSum = 0;
        #endregion
        #region Form Methods And Events
        public frmDistributionSalesReturn()
        {
            InitializeComponent();
        }
        private void frmSalesReturn_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DgvStockSales.AutoGenerateColumns = false;
            this.DgvSales.AutoGenerateColumns = false;
            ShowHideColumns();
            AdjustControls();
            LoadAdjustmentTypes();
            //FillData();
            FillNaturalAccounts(string.Empty);
            FillCashAccounts(string.Empty);
            CheckModulePermissions();
            FillTotalVouchers();
            GetLastVoucherTransactionByType();
            if (IsNetTransaction)
            {
                this.Text = "Net Inventory Sales Return";
                btnViewDetail.Enabled = false;
                btnAddCustomer.Text = "Add Cash Account";
                grpDebitor.Text = "Cash Account Information";
            }
            else
            {
                this.Text = "Credit Inventory Sales Return";
            }

        }
        private void frmSalesReturn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                //FillData();
                ClearControls();
                if (DgvStockSales.Rows.Count > 0)
                {
                    DgvStockSales.Rows.Clear();
                }
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
                        DgvStockSales.Columns["colEngineNo"].Visible = false;
                        DgvStockSales.Columns["colChassisNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleNo"].Visible = false;
                        DgvStockSales.Columns["colBatchNo"].Visible = false;
                        DgvStockSales.Columns["colExpiry"].Visible = false;
                        DgvStockSales.Columns["colVehicleModel"].Visible = false;
                        DgvStockSales.Columns["colVehicleColors"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;

                        DgvStockSales.Columns["colItemName"].Width = 435;
                        DgvStockSales.Columns["colpacking"].Width = 100;
                        DgvStockSales.Columns["colQty"].Width = 100;
                        DgvStockSales.Columns["colUnitPrice"].Width = 100;

                        DgvSales.Columns["colBonusUnit"].Visible = false;
                        DgvSales.Columns["colEngineNo"].Visible = false;
                        DgvSales.Columns["colChassisNo"].Visible = false;
                        DgvSales.Columns["colVehicleNo"].Visible = false;
                        DgvSales.Columns["colBatchNo"].Visible = false;
                        DgvSales.Columns["colExpiry"].Visible = false;
                        DgvSales.Columns["colVehicleModel"].Visible = false;
                        DgvSales.Columns["colVehicleColors"].Visible = false;
                        DgvSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;

                        DgvSales.Columns["colItemName"].Width = 250;
                        DgvSales.Columns["colpacking"].Width = 70;
                        DgvSales.Columns["colCurrentStock"].Width = 100;
                        DgvSales.Columns["colQty"].Width = 80;
                        DgvSales.Columns["colUnitPrice"].Width = 80;
                        DgvSales.Columns["colAmount"].Width = 80;
                        DgvSales.Columns["colDiscount"].Width = 80;
                        DgvSales.Columns["colDiscountAmount"].Width = 90;
                        DgvSales.Columns["colDelete"].Width = 80; ;
                    }
                    else if (objActiveType.SoftwareType == "POS")
                    {
                        DgvStockSales.Columns["colpacking"].Visible = false;
                        DgvStockSales.Columns["colCartons"].Visible = false;
                        DgvStockSales.Columns["colEngineNo"].Visible = false;
                        DgvStockSales.Columns["colChassisNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleNo"].Visible = false;
                        DgvStockSales.Columns["colBatchNo"].Visible = false;
                        DgvStockSales.Columns["colExpiry"].Visible = false;
                        DgvStockSales.Columns["colVehicleModel"].Visible = false;
                        DgvStockSales.Columns["colVehicleColors"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;
                        DgvStockSales.Columns["colDelete"].Visible = false;

                        DgvStockSales.Columns["colItemName"].Width = 400;
                        DgvStockSales.Columns["colQty"].Width = 170;
                        DgvStockSales.Columns["colUnitPrice"].Width = 170;
                        DgvStockSales.Columns["colAmount"].Width = 170;

                        DgvSales.Columns["colBonusUnit"].Visible = false;
                        DgvSales.Columns["colpacking"].Visible = false;
                        DgvSales.Columns["colCartons"].Visible = false;
                        DgvSales.Columns["colEngineNo"].Visible = false;
                        DgvSales.Columns["colChassisNo"].Visible = false;
                        DgvSales.Columns["colVehicleNo"].Visible = false;
                        DgvSales.Columns["colBatchNo"].Visible = false;
                        DgvSales.Columns["colExpiry"].Visible = false;
                        DgvSales.Columns["colVehicleModel"].Visible = false;
                        DgvSales.Columns["colVehicleColors"].Visible = false;
                        DgvSales.Columns["colFirstIMEI"].Visible = false;
                        DgvSales.Columns["colSecondIMEI"].Visible = false;
                        DgvSales.Columns["colDelete"].Visible = false;

                        DgvSales.Columns["colItemName"].Width = 400;
                        DgvSales.Columns["colQty"].Width = 170;
                        DgvSales.Columns["colUnitPrice"].Width = 170;
                        DgvSales.Columns["colAmount"].Width = 170;
                    }
                    else if (objActiveType.SoftwareType == "Motor Bikes")
                    {
                        DgvStockSales.Columns["colpacking"].Visible = false;
                        DgvStockSales.Columns["colCartons"].Visible = false;
                        DgvStockSales.Columns["colBatchNo"].Visible = false;
                        DgvStockSales.Columns["colExpiry"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;

                        DgvStockSales.Columns["colItemName"].Width = 250;
                    }
                    else if (objActiveType.SoftwareType == "Motor Cars")
                    {
                        DgvStockSales.Columns["colpacking"].Visible = false;
                        DgvStockSales.Columns["colCartons"].Visible = false;
                        DgvStockSales.Columns["colBatchNo"].Visible = false;
                        DgvStockSales.Columns["colExpiry"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;

                        DgvStockSales.Columns["colItemName"].Width = 250;
                    }
                    else if (objActiveType.SoftwareType == "Medicine Trading")
                    {
                        DgvStockSales.Columns["colCartons"].Visible = false;
                        DgvStockSales.Columns["colEngineNo"].Visible = false;
                        DgvStockSales.Columns["colChassisNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleModel"].Visible = false;
                        DgvStockSales.Columns["colVehicleColors"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;


                        DgvStockSales.Columns["colItemName"].Width = 340;
                        DgvStockSales.Columns["colpacking"].Width = 100;
                        DgvStockSales.Columns["colExpiry"].Width = 100;
                        DgvStockSales.Columns["colBatchNo"].Width = 100;
                        DgvStockSales.Columns["colUnitPrice"].Width = 100;
                        DgvStockSales.Columns["colAmount"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "Medicine POS")
                    {
                        DgvStockSales.Columns["colpacking"].Visible = false;
                        DgvStockSales.Columns["colCartons"].Visible = false;
                        DgvStockSales.Columns["colEngineNo"].Visible = false;
                        DgvStockSales.Columns["colChassisNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleNo"].Visible = false;
                        DgvStockSales.Columns["colBatchNo"].Visible = false;
                        DgvStockSales.Columns["colExpiry"].Visible = false;
                        DgvStockSales.Columns["colVehicleModel"].Visible = false;
                        DgvStockSales.Columns["colVehicleColors"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;
                    }
                    else if (objActiveType.SoftwareType == "Mobile Soft")
                    {
                        DgvStockSales.Columns["colItemName"].Width = 465;

                        DgvStockSales.Columns["colpacking"].Visible = true;
                        DgvStockSales.Columns["colCartons"].Visible = false;
                        DgvStockSales.Columns["colEngineNo"].Visible = false;
                        DgvStockSales.Columns["colChassisNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleNo"].Visible = false;
                        DgvStockSales.Columns["colBatchNo"].Visible = false;
                        DgvStockSales.Columns["colExpiry"].Visible = false;
                        DgvStockSales.Columns["colVehicleModel"].Visible = false;
                        DgvStockSales.Columns["colVehicleColors"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;
                    }
                    else if (objActiveType.SoftwareType == "Distribution Trading")
                    {
                        DgvStockSales.Columns["colEngineNo"].Visible = false;
                        DgvStockSales.Columns["colChassisNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleNo"].Visible = false;
                        DgvStockSales.Columns["colBatchNo"].Visible = false;
                        DgvStockSales.Columns["colExpiry"].Visible = false;
                        DgvStockSales.Columns["colVehicleModel"].Visible = false;
                        DgvStockSales.Columns["colVehicleColors"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;
                        
                        DgvStockSales.Columns["colItemName"].Width = 435;
                        DgvStockSales.Columns["colpacking"].Width = 100;
                        DgvStockSales.Columns["colQty"].Width = 100;
                        DgvStockSales.Columns["colUnitPrice"].Width = 100;

                        DgvSales.Columns["colSalesEngineNo"].Visible = false;
                        DgvSales.Columns["colSalesChasisNumber"].Visible = false;
                        DgvSales.Columns["colSalesVehicle"].Visible = false;
                        DgvSales.Columns["colSalesBatchNo"].Visible = false;
                        DgvSales.Columns["colSalesExpiryNumber"].Visible = false;
                        DgvSales.Columns["colSalesModel"].Visible = false;
                        DgvSales.Columns["colSalesColor"].Visible = false;
                        DgvSales.Columns["colSalesFirstIMEI"].Visible = false;
                        DgvSales.Columns["colSalesSecondIMEI"].Visible = false;
                        DgvSales.Columns["colSalesCartons"].Visible = false;
                        DgvSales.Columns["colSalesBonusUnit"].Visible = false;

                        DgvSales.Columns["colSalesItemName"].Width = 180;
                        DgvSales.Columns["colSalesUOM"].Width = 70;
                        //DgvSales.Columns["colCurrentStock"].Width = 100;
                        DgvSales.Columns["colSalesQuantity"].Width = 70;
                        DgvSales.Columns["colSalesBonusUnit"].Width = 70;
                        DgvSales.Columns["colSalesUnitPrice"].Width = 85;
                        DgvSales.Columns["colSalesAmount"].Width = 80;
                        DgvSales.Columns["colSalesDiscount"].Width = 80;
                        DgvSales.Columns["colSalesDiscountAmount"].Width = 90;
                    }
                }
            }
        }
        private string SoftwareType()
        {
            string SoftwareType = string.Empty;
            List<SoftwareTypesEL> list = DataOperations.SoftwareTypes;
            if (list.Count > 0)
            {
                SoftwareTypesEL objActiveType = list.Find(x => x.ActiveSoftware == true);
                SoftwareType = objActiveType.SoftwareType;
            }
            return SoftwareType;
        }
        private void AdjustControls()
        {
            if (IsNetTransaction)
            {
                grpDebitor.Visible = false;               
            }
            else
            {
                pnlCash.Visible = false;              
            }
            //grpEmployees.Visible = false;
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

            int hostCellLocation = DgvSalesTransactions.GetCellDisplayRectangle(5, -1, true).X;

            txtDebit.Width = DgvSalesTransactions.Columns[5].Width; //+SystemInformation.VerticalScrollBarWidth;
            txtDebit.Location = new Point(hostCellLocation, DgvSalesTransactions.Height - txtDebit.Height);

            DgvSalesTransactions.Controls.Add(txtDebit);

            txtDebit.BringToFront();

            txtCredit.Enabled = false;
            txtCredit.TextAlign = HorizontalAlignment.Left;
            txtCredit.Font = new System.Drawing.Font("Arial", 9, FontStyle.Bold);

            int hostCreditCellLocation = DgvSalesTransactions.GetCellDisplayRectangle(6, -1, true).X;
            txtCredit.Width = DgvSalesTransactions.Columns[6].Width; //+SystemInformation.VerticalScrollBarWidth;
            txtCredit.Location = new Point(hostCreditCellLocation, DgvSalesTransactions.Height - txtCredit.Height);

            DgvSalesTransactions.Controls.Add(txtCredit);

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
        private void FillCustomer(string AccountNo)
        {
            var manager = new PersonsBLL();
            List<PersonsEL> list = manager.GetPersonByAccount(Operations.IdProject, AccountNo);
            if (list.Count > 0)
            {
                txtContact.Text = list[0].Contact;
            }
        }
        private void FillData()
        {
            var manager = new PurchaseHeadBLL();
            //txtSheetNo.Text = manager.GetMaxPurchaseNumber(Operations.IdCompany, IsNetTransaction).ToString();
        }
        private void FillTotalVouchers()
        {
            var Manager = new VoucherBLL();
            lblTotalVouchers.Text = Manager.GetAllStockTotalTransactionalVouchersByType(Operations.IdProject, Operations.BookNo, VoucherTypes.SalesReturnVoucher.ToString(), IsNetTransaction).ToString();
        }
        private void GetLastVoucherTransactionByType()
        {
            var Manager = new VoucherBLL();
            List<VouchersEL> listLast = Manager.GetStockLastVoucherTransactionByType(Operations.IdProject, Operations.BookNo, VoucherTypes.SalesReturnVoucher.ToString(), IsNetTransaction);
            if (listLast != null && listLast.Count > 0)
            {
                lblLastVoucherNo.Text = listLast[0].VoucherNo.ToString();
            }
        }
        private void FillNaturalAccounts(string AccountNo)
        {
            var manager = new AccountsBLL();
            #region Fill Sales Account
            List<AccountsEL> list = manager.GetAccountsByType("Net Sales", Operations.IdCompany, Operations.IdProject);
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
            DgvSales.Rows.Clear();
            DgvStockSales.Rows.Clear();
            DgvSalesTransactions.Rows.Clear();
            //txtDescription.Text = string.Empty;
            VoucherNo = 0;
            IdVoucher = 0;
            txtSheetNo.Text = string.Empty;
            txtSheetNo.Enabled = true;
            txtTotalAmount.Text = string.Empty;
            CustomerTransactionId = null;

            VDate.Value = DateTime.Now;

            SalesTransactionId = null;
            CashTransactionId = null;

            SEditBox.Text = string.Empty;
            if (chkPosted.Checked)
            {
                chkPosted.Checked = false;
                chkPosted.Enabled = true;
            }
            txtBiltyNo.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtCurrentBalance.Text = string.Empty;

            InvEditBox.Text = string.Empty;
            txtGatePass.Text = string.Empty;

            cbxNaturalAccounts.SelectedIndex = -1;
            cbxCashAccounts.SelectedIndex = -1;
            cbxAdjustmentTypes.SelectedIndex = -1;

            CustomerAccountNo = string.Empty;
            SalesAccountNo = string.Empty;
            btnSave.Enabled = true;
            btnDelete.Enabled = true;

            txtInvoiceNo.Text = string.Empty;
            EmpEditCode.Text = string.Empty;
            txtDeliveryPerson.Text = string.Empty;
            EmpAccountNo = string.Empty;
            EmpDeliveryAccountNo = string.Empty;
        }
        private bool ValidateRows()
        {

            for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
            {
                if (DgvStockSales.Rows[i].Cells["colQty"].Value == null)
                {
                    return false;
                }
                else if (DgvStockSales.Rows[i].Cells["colUnitPrice"].Value == null)
                {
                    return false;
                }
            }
            return true;
        }
        private bool ValidateControls()
        {
            if (RdCreditSales.Checked)
            {
                if (CustomerAccountNo == string.Empty)
                {
                    MessageBox.Show("Debit Account Missing...");
                    return false;
                }
                else if (SalesAccountNo == string.Empty)
                {
                    MessageBox.Show("Sales Account Missing, Please Select...");
                    return false;
                }
            }
            else if (RdCashSale.Checked)
            {
                if (CashAccountNo == string.Empty)
                {
                    MessageBox.Show("Debit Account Missing...");
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
            string First = "Following Are Returns By "+SEditBox.Text+"" + "~";
            for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
            {
                Remarks += DgvStockSales.Rows[i].Cells[3].Value.ToString() + " "
                           + DgvStockSales.Rows[i].Cells[15].Value.ToString() + " Units"
                           + "@" + DgvStockSales.Rows[i].Cells[17].Value.ToString() + "~";
            }
            First += Remarks;
            return First;
        }
        #endregion
        #region Buttons Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Variables
            List<StockReceiptEL> oelStockReceiptCollection = new List<StockReceiptEL>();
            List<VoucherDetailEL> oelSalesDetailCollection = new List<VoucherDetailEL>();
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
                        oelVoucher.SheetNo = Validation.GetSafeLong(txtSheetNo.Text);
                        oelVoucher.BookNo = Operations.BookNo;
                        oelVoucher.TerminalNumber = Validation.GetSafeInteger(XmlConfiguration.ReadXmlTerminalsConfiguration()[0]);
                        oelVoucher.BiltyNo = Validation.GetSafeString(txtBiltyNo.Text);
                        oelVoucher.SampleNo = 0;
                        oelVoucher.InvoiceNo = Validation.GetSafeLong(txtInvoiceNo.Text);
                        oelVoucher.FirstName = string.Empty;
                        oelVoucher.Contact = string.Empty;
                        oelVoucher.Cnic = string.Empty;
                        oelVoucher.Address = string.Empty;
                        if (IdVoucher != null || IdVoucher > 0)
                        {
                            oelVoucher.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
                        }
                        //if (!IsNetTransaction)
                        //{
                        //    oelVoucher.AccountNo = CustomerAccountNo;
                        //}
                        //else
                        //{
                        //    oelVoucher.AccountNo = CashAccountNo;
                        //}
                        oelVoucher.SoftwareType = SoftwareType();
                        oelVoucher.AccountNo = CustomerAccountNo;
                        oelVoucher.CashAccountNo = CashAccountNo;
                        oelVoucher.SubAccountNo = EmpAccountNo;
                        oelVoucher.EmployeeAccountNo = EmpDeliveryAccountNo;
                        oelVoucher.VDiscription = string.Empty;
                        oelVoucher.InWardGatePassNo = Validation.GetSafeString(txtInwardGatePass.Text);
                        oelVoucher.OutWardGatePassNo = Validation.GetSafeString(txtGatePass.Text);
                        oelVoucher.VDate = VDate.Value;
                        oelVoucher.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
                        oelVoucher.VAT = 0;//Validation.GetSafeInteger(txtVat.Text);
                        oelVoucher.VATAmount = 0;//Validation.GetSafeDecimal(txtTotalAmount.Text);
                        oelVoucher.IsImportTransaction = IsImportTransaction;
                        oelVoucher.IsNetTransaction = RdCashSale.Checked ? true : false;
                        oelVoucher.IdStockAdjustmentType = Validation.GetSafeLong(cbxAdjustmentTypes.SelectedIndex);
                        oelVoucher.Posted = chkPosted.Checked;
                        #endregion
                        #region Add Stock
                        for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                        {
                            VoucherDetailEL oelSaleDetial = new VoucherDetailEL();
                            ItemsEL oelItem = new ItemsEL();
                            if (DgvStockSales.Rows[i].Cells["ColIdVoucherDetail"].Value != null)
                            {
                                //oelPurchaseDetial.TransactionID = new Guid(DgvStockReceipt.Rows[i].Cells["ColTransaction"].Value.ToString());
                                oelSaleDetial.IdVoucherDetail = Validation.GetSafeLong(DgvStockSales.Rows[i].Cells["ColIdVoucherDetail"].Value.ToString());
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
                            oelSaleDetial.VoucherNo = Validation.GetSafeLong(txtSheetNo.Text);
                            oelSaleDetial.IdItem = Validation.GetSafeLong(DgvStockSales.Rows[i].Cells["colIdItem"].Value);
                            oelItem.IdItem = Validation.GetSafeLong(DgvStockSales.Rows[i].Cells["colIdItem"].Value);
                            oelSaleDetial.PackingSize = Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colpacking"].Value);
                            oelSaleDetial.Discription = "N/A"; //Validation.GetSafeString(DgvStockReceipt.Rows[i].Cells["colRemarks"].Value);
                            oelSaleDetial.TotalCartons = Validation.GetSafeLong(DgvStockSales.Rows[i].Cells["colCartons"].Value);
                            oelSaleDetial.BatchNo = Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colBatchNo"].Value);
                            oelSaleDetial.Expiry = Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colExpiry"].Value);
                            oelSaleDetial.EngineNo = Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colEngineNo"].Value);
                            oelSaleDetial.ChasisNo = Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colChassisNo"].Value);
                            oelSaleDetial.VehicleModel = Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colVehicleModel"].Value);
                            oelSaleDetial.VehicleNo = Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colVehicleNo"].Value);
                            oelSaleDetial.FirstIMEI = Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colFirstIMEI"].Value);
                            oelSaleDetial.SecondIMEI = Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colSecondIMEI"].Value);
                            if (DgvStockSales.Rows[i].Cells["colVehicleColors"].Value != null && Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colVehicleColors"].Value) != string.Empty)
                            {
                                if (Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colVehicleColors"].Value) == "Red")
                                {
                                    oelSaleDetial.ColorCode = 1;
                                }
                                else if (Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colVehicleColors"].Value) == "Black")
                                {
                                    oelSaleDetial.ColorCode = 2;
                                }
                                else if (Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colVehicleColors"].Value) == "Blue")
                                {
                                    oelSaleDetial.ColorCode = 3;
                                }
                                else if (Validation.GetSafeString(DgvStockSales.Rows[i].Cells["colVehicleColors"].Value) == "Silver")
                                {
                                    oelSaleDetial.ColorCode = 4;
                                }
                            }

                            oelSaleDetial.Units = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colQty"].Value);
                            //oelPurchaseDetial.Bonus = Validation.GetSafeInteger(DgvStockReceipt.Rows[i].Cells["colBonus"].Value);
                            oelSaleDetial.RemainingUnits = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colQty"].Value);
                            oelSaleDetial.UnitPrice = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colUnitPrice"].Value);
                            oelItem.CurrentUnitPrice = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colUnitPrice"].Value);
                            oelSaleDetial.Discount = 0;//Validation.GetSafeDecimal(DgvStockReceipt.Rows[i].Cells["colDisc"].Value);
                            oelSaleDetial.Amount = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value);

                            oelItemsCollection.Add(oelItem);
                            oelSalesDetailCollection.Add(oelSaleDetial);
                        }
                        #endregion
                        #region Add Inventory And COGS Accounts
                        if (chkPosted.Checked)
                        {
                            for (int k = 0; k < DgvStockSales.Rows.Count - 1; k++)
                            {
                                var IManager = new ItemsBLL();
                                List<ItemsEL> EachItem = IManager.GetItemById(Validation.GetSafeLong(DgvStockSales.Rows[k].Cells["colIdItem"].Value));
                                if (oelCostOfSalesCollection.Count > 0)
                                {
                                    VoucherDetailEL oelFindInventoryDetail = oelCostOfSalesCollection.Find(x => x.AccountNo == EachItem[0].InventoryAccount);
                                    if (oelFindInventoryDetail != null)
                                    {
                                        oelFindInventoryDetail.Debit += Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) *
                                                                         Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colQty"].Value); //EachItem[0].AVGEvaluationUnitPrice;
                                        //oelCostOfSalesCollection.Add(oelFindInventoryDetail);
                                    }
                                    else
                                    {
                                        oelCostOfSalesCollection.Add(CreateInventoryTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colQty"].Value)));
                                    }
                                }
                                else
                                {
                                    oelCostOfSalesCollection.Add(CreateInventoryTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colQty"].Value)));
                                }
                                if (oelCostOfSalesCollection.Count > 0)
                                {
                                    /// COGS
                                    VoucherDetailEL oelFindCOGSDetail = oelCostOfSalesCollection.Find(x => x.AccountNo == EachItem[0].COGSAccount);
                                    if (oelFindCOGSDetail != null)
                                    {
                                        oelFindCOGSDetail.Credit += Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) *
                                                                         Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colQty"].Value); //EachItem[0].AVGEvaluationUnitPrice;
                                        //oelCostOfSalesCollection.Add(oelFindCOGSDetail);
                                    }
                                    else
                                    {
                                        oelCostOfSalesCollection.Add(CreateCOGSTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colQty"].Value)));
                                    }
                                }
                                else
                                {
                                    oelCostOfSalesCollection.Add(CreateCOGSTransaction(oelVoucher, EachItem, Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colQty"].Value)));
                                }
                            }
                        }
                        #endregion
                        #region Add Customer
                        if (RdCreditSales.Checked)
                        {
                            VoucherDetailEL oelCustomerTransaction = new VoucherDetailEL();
                            SoftwareChecksEL oelSoftwareCheck = DataOperations.SoftwareChecks.ToList().Find(x => x.SoftwareCheckName == "ItemWiseLederPrint");
                            if (CustomerTransactionId.HasValue && CustomerTransactionId.Value > 0)
                            {
                                oelCustomerTransaction.IdTransactionDetail = CustomerTransactionId.Value;
                                oelCustomerTransaction.IsNew = false;
                            }
                            else
                            {
                                oelCustomerTransaction.IdTransactionDetail = 0;
                                oelCustomerTransaction.IsNew = true;
                            }
                            oelCustomerTransaction.IsNetTransaction = RdCashSale.Checked ? true : false;
                            oelCustomerTransaction.SeqNo = 1;
                            oelCustomerTransaction.TrackNumber = 1;
                            oelCustomerTransaction.IdProject = Operations.IdProject;
                            oelCustomerTransaction.BookNo = Operations.BookNo;
                            oelCustomerTransaction.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
                            oelCustomerTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCustomerTransaction.AccountNo = CustomerAccountNo;
                            oelCustomerTransaction.SubAccountNo = "0";
                            oelCustomerTransaction.Date = VDate.Value;
                            oelCustomerTransaction.VoucherType = "SR";
                            oelCustomerTransaction.TransactionType = 1;
                            oelCustomerTransaction.TransactionMode = "CR";
                            if (oelSoftwareCheck != null && oelSoftwareCheck.IsMust.Value)
                            {
                                oelCustomerTransaction.Description = BuildRemarks();
                            }
                            else
                            {
                                oelCustomerTransaction.Description = "Sale Return From : " + SEditBox.Text;
                            }
                            oelCustomerTransaction.Credit = Convert.ToDecimal(txtTotalAmount.Text);

                            oelCustomerTransaction.Debit = 0;
                            oelCustomerTransaction.Posted = chkPosted.Checked;
                            oelCustomerTransaction.CreatedDateTime = VDate.Value;

                            oelCostOfSalesCollection.Add(oelCustomerTransaction);
                        }
                        #endregion
                        #region Add Cash
                        if (RdCashSale.Checked)
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
                            oelCashTransaction.IsNetTransaction = RdCashSale.Checked ? true : false;
                            oelCashTransaction.SeqNo = 1;
                            oelCashTransaction.TrackNumber = 1;
                            oelCashTransaction.IdProject = Operations.IdProject;
                            oelCashTransaction.BookNo = Operations.BookNo;
                            oelCashTransaction.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
                            oelCashTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCashTransaction.AccountNo = CashAccountNo;
                            oelCashTransaction.SubAccountNo = "0";
                            oelCashTransaction.Date = VDate.Value;
                            oelCashTransaction.VoucherType = "SR";
                            oelCashTransaction.TransactionType = 1;
                            oelCashTransaction.TransactionMode = "CR";
                            oelCashTransaction.Description = "Cash Sale Returned From : " + SEditBox.Text;// txtDescription.Text;

                            oelCashTransaction.Credit = Convert.ToDecimal(txtTotalAmount.Text);

                            oelCashTransaction.Debit = 0;
                            oelCashTransaction.Posted = chkPosted.Checked;
                            oelCashTransaction.CreatedDateTime = VDate.Value;

                            oelCostOfSalesCollection.Add(oelCashTransaction);
                        }
                        #endregion
                        #region Add Sales Account In Transactions
                        /// Add Purchase Account...
                        VoucherDetailEL oelSaleTransaction = new TransactionsEL();
                        if (SalesTransactionId.HasValue && SalesTransactionId.Value > 0)
                        {
                            oelSaleTransaction.IdTransactionDetail = SalesTransactionId.Value;
                            oelSaleTransaction.IsNew = false;
                        }
                        else
                        {
                            oelSaleTransaction.IdTransactionDetail = 0;
                            oelSaleTransaction.IsNew = true;
                        }
                        oelSaleTransaction.IsNetTransaction = RdCashSale.Checked ? true : false;
                        oelSaleTransaction.SeqNo = 2;
                        oelSaleTransaction.TrackNumber = 2;
                        oelSaleTransaction.IdProject = Operations.IdProject;
                        oelSaleTransaction.BookNo = Operations.BookNo;
                        oelSaleTransaction.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
                        oelSaleTransaction.IdVoucher = oelVoucher.IdVoucher;
                        //oelPurchaseTransaction.AccountNo = Validation.GetSafeLong(PurchasesEditBox.Text);
                        oelSaleTransaction.AccountNo = SalesAccountNo;
                        oelSaleTransaction.SubAccountNo = "0";
                        oelSaleTransaction.Date = VDate.Value;
                        oelSaleTransaction.SheetNo = Validation.GetSafeLong(txtSheetNo.Text);
                        oelSaleTransaction.VoucherType = "SR";
                        oelSaleTransaction.TransactionType = 2;
                        oelSaleTransaction.Description = "";
                        oelSaleTransaction.Debit = Validation.GetSafeDecimal(txtTotalAmount.Text);
                        oelSaleTransaction.Credit = 0;
                        oelSaleTransaction.TransactionMode = "DR";
                        oelSaleTransaction.CreatedDateTime = VDate.Value;
                        oelSaleTransaction.Posted = chkPosted.Checked;

                        oelCostOfSalesCollection.Add(oelSaleTransaction);
                        #endregion region
                        #region Add Accounting Transactions
                        for (int j = 0; j < DgvSalesTransactions.Rows.Count - 1; j++)
                        {
                            VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                            oelVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
                            oelVoucherDetail.IdProject = Operations.IdProject;
                            oelVoucherDetail.BookNo = Operations.BookNo;
                            oelVoucherDetail.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
                            if (DgvSalesTransactions.Rows[j].Cells["ColIdDetailVoucher"].Value != null)
                            {
                                oelVoucherDetail.IdTransactionDetail = Validation.GetSafeLong(DgvSalesTransactions.Rows[j].Cells["ColIdDetailVoucher"].Value.ToString());
                                oelVoucherDetail.IsNew = false;
                            }
                            else
                            {
                                oelVoucherDetail.IdTransactionDetail = 0;
                                oelVoucherDetail.IsNew = true;

                            }
                            oelVoucherDetail.SheetNo = Validation.GetSafeLong(txtSheetNo.Text);
                            if (DgvSalesTransactions.Rows[j].Cells["colDescription"].Value == null)
                            {
                                oelVoucherDetail.Description = "N/A";
                            }
                            else
                            {
                                oelVoucherDetail.Description = DgvSalesTransactions.Rows[j].Cells["colDescription"].Value.ToString();
                            }
                            oelVoucherDetail.IsNetTransaction = RdCashSale.Checked ? true : false;
                            oelVoucherDetail.SeqNo = j + 3;
                            oelVoucherDetail.TrackNumber = j + 3;
                            oelVoucherDetail.VoucherType = "SR";
                            oelVoucherDetail.IdAccount = Validation.GetSafeLong(DgvSalesTransactions.Rows[j].Cells["colIdAccount"].Value);
                            oelVoucherDetail.AccountNo = Validation.GetSafeString(DgvSalesTransactions.Rows[j].Cells["colAccountNo"].Value);
                            oelVoucherDetail.Debit = Validation.GetSafeDecimal(DgvSalesTransactions.Rows[j].Cells["colDebit"].Value);
                            if (oelVoucherDetail.Debit > 0)
                            {
                                oelVoucherDetail.TransactionMode = "DR";
                            }
                            else
                            {
                                oelVoucherDetail.TransactionMode = "CR";
                            }
                            oelVoucherDetail.Credit = Validation.GetSafeDecimal(DgvSalesTransactions.Rows[j].Cells["colCredit"].Value);
                            oelVoucherDetail.CreatedDateTime = VDate.Value;
                            oelCostOfSalesCollection.Add(oelVoucherDetail);

                        }
                        #endregion
                        #region Saving Code
                        if (IsNetTransaction)
                        {
                            SoftwareChecksEL PCheck = DataOperations.SoftwareChecks.Find(x => x.SoftwareCheckName == "NetSaleReturnCheck");
                            if (PCheck != null && PCheck.IsMust.Value)
                            {
                                if (CashAccountNo == string.Empty)
                                {
                                    MessageBox.Show("Please Select Cash Account For Net Sale Return....");
                                    return;
                                }
                                List<TransactionsEL> EndingBalanceList = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, CashAccountNo);
                                if (EndingBalanceList.Count > 0)
                                {
                                    if (EndingBalanceList[0].ClosingBalance > 0 && EndingBalanceList[0].BalanceType == "DR")
                                    {
                                        if (EndingBalanceList[0].ClosingBalance > Validation.GetSafeDecimal(txtTotalAmount.Text))
                                        {
                                            // Let It Go
                                        }
                                        else
                                        {
                                            MessageBox.Show("You Do Not Have Enough Balance for Net Sale Return...");
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        // Stop It Here....
                                        MessageBox.Show("You Do Not Have Enough Balance for Net Sale Return...");
                                        return;
                                    }
                                }
                            }
                        }
                        if (IdVoucher == null || IdVoucher == 0)
                        {
                            var manager = new SalesHeadBLL();

                            EntityoperationInfo infoResult = manager.InsertSalesReturn(oelVoucher, oelSalesDetailCollection, oelCostOfSalesCollection);
                            if (infoResult.IsSuccess)
                            {
                                MessageBox.Show("Sales Return Recorded Successfully...");
                                InvEditBox.Text = infoResult.VoucherNo.ToString();
                                IdVoucher = infoResult.IntID;
                                FillVoucher();
                                //ClearControls();
                                //FillData();
                            }
                        }
                        else
                        {
                            var manager = new SalesHeadBLL();
                            EntityoperationInfo infoResult = manager.UpdateSalesReturn(oelVoucher, oelSalesDetailCollection, oelCostOfSalesCollection);
                            if (infoResult.IsSuccess)
                            {
                                 MessageBox.Show("Recorded Sales Return Updated Successfully...");
                                ClearControls();
                                //FillData();
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
                    MessageBox.Show("Check All Values....");
                }
            }
            else
            {
                MessageBox.Show("Incomplete Entry...");
            }
            #endregion
        }
        private VoucherDetailEL CreateInventoryTransaction(VouchersEL oelVoucher, List<ItemsEL> EachItem, decimal Quantity)
        {
            VoucherDetailEL oelInventoryVoucherDetail = new VoucherDetailEL();
            var manager = new ItemsBLL();
            oelInventoryVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
            oelInventoryVoucherDetail.IdProject = Operations.IdProject;
            oelInventoryVoucherDetail.BookNo = Operations.BookNo;
            oelInventoryVoucherDetail.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
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
            oelInventoryVoucherDetail.SheetNo = Validation.GetSafeLong(txtSheetNo.Text);

            oelInventoryVoucherDetail.Description = "Inventory Debit";
            oelInventoryVoucherDetail.IsNetTransaction = RdCashSale.Checked ? true : false;
            oelInventoryVoucherDetail.SeqNo = 0;
            oelInventoryVoucherDetail.TrackNumber = 0;
            oelInventoryVoucherDetail.VoucherType = "SR";
            oelInventoryVoucherDetail.AccountNo = Validation.GetSafeString(EachItem[0].InventoryAccount);
            oelInventoryVoucherDetail.Debit = Validation.GetSafeDecimal(manager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) * Quantity; //EachItem[0].AVGEvaluationUnitPrice);

            oelInventoryVoucherDetail.TransactionMode = "DR";
            oelInventoryVoucherDetail.Posted = chkPosted.Checked;
            oelInventoryVoucherDetail.CreatedDateTime = VDate.Value;

            return oelInventoryVoucherDetail;
        }
        private VoucherDetailEL CreateCOGSTransaction(VouchersEL oelVoucher, List<ItemsEL> EachItem, decimal Quantity)
        {
            var manager = new ItemsBLL();
            VoucherDetailEL oelCOGSVoucherDetail = new VoucherDetailEL();
            oelCOGSVoucherDetail.IdVoucher = oelVoucher.IdVoucher;
            oelCOGSVoucherDetail.IdProject = Operations.IdProject;
            oelCOGSVoucherDetail.BookNo = Operations.BookNo;
            oelCOGSVoucherDetail.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
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
            oelCOGSVoucherDetail.IsNetTransaction = RdCashSale.Checked ? true : false;
            oelCOGSVoucherDetail.SheetNo = Validation.GetSafeLong(txtSheetNo.Text);


            oelCOGSVoucherDetail.Description = "COGS Credit";


            oelCOGSVoucherDetail.VoucherType = "SR";
            oelCOGSVoucherDetail.AccountNo = Validation.GetSafeString(EachItem[0].COGSAccount);
            oelCOGSVoucherDetail.Credit = Validation.GetSafeDecimal(manager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) * Quantity;//EachItem[0].AVGEvaluationUnitPrice);
            oelCOGSVoucherDetail.TransactionMode = "CR";
            oelCOGSVoucherDetail.Posted = chkPosted.Checked;
            oelCOGSVoucherDetail.CreatedDateTime = VDate.Value;

            return oelCOGSVoucherDetail;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> oelItemTransactionCollection = new List<TransactionsEL>();
            var manager = new SalesHeadBLL();

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
                            if (manager.DeleteSalesReturnByVoucher(IdVoucher.Value, Operations.IdProject))
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
                        if (manager.DeleteSalesReturnByVoucher(IdVoucher.Value, Operations.IdProject))
                        {
                            MessageBox.Show("Voucher Deleted Successfully and Transactions Rolled Back");
                            ClearControls();
                        }
                    }
                }
                //PurchaseStockReceiptBLL();
                else if (MessageBox.Show("Are You Sure To Delete ?", "Deleting Voucher", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (manager.DeleteSalesReturnByVoucher(IdVoucher.Value, Operations.IdProject))
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
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmaccounts = new frmAccounts();
            frmaccounts.Show();
        }
        private void btnViewDetail_Click(object sender, EventArgs e)
        {
            if (CustomerAccountNo != string.Empty)
            {
                frmpersons = new frmPersons();
                frmpersons.AccountNo = CustomerAccountNo;
                frmpersons.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please Select Supplier To View Detail....");
            }
        }        
        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearControls();
            //FillData();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            long NextVoucherNo = Convert.ToInt64(txtSheetNo.Text);
            NextVoucherNo += 1;
            txtSheetNo.Text = NextVoucherNo.ToString();
            FillVoucher();
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            long PreviousVoucherNo = Convert.ToInt64(txtSheetNo.Text);
            PreviousVoucherNo -= 1;
            txtSheetNo.Text = PreviousVoucherNo.ToString();
            FillVoucher();
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
                List<TransactionsEL> EndingBalanceList = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, CashAccountNo);
                if (EndingBalanceList.Count > 0)
                {
                    txtCashClosingBalance.Text = EndingBalanceList[0].ClosingBalance + " " + EndingBalanceList[0].BalanceType;
                }
                else
                {
                    txtCashClosingBalance.Text = string.Empty;
                }
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
                SalesAccountNo = Validation.GetSafeString(cbxNaturalAccounts.SelectedValue);
            }
            else
            {
                SalesAccountNo = string.Empty;
            }
        }
        private void cbxNaturalAccounts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //txtBillNo.Focus();
                DgvStockSales.Focus();
            }
        }
        #endregion
        #region Other Controls Methods And Events
        private void InvEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmfindVouchers = new frmFindVouchers();
            frmfindVouchers.VoucherType = VoucherTypes.SalesReturnVoucher.ToString();
            //frmfindVouchers.IsNetTransaction = IsNetTransaction;
            frmfindVouchers.IsNetTransaction = null;
            frmfindVouchers.ExecuteFindVouchersEvent += new frmFindVouchers.VouchersDelegate(frmfindVouchers_ExecuteFindVouchersEvent);
            frmfindVouchers.ShowDialog(this);
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
        private void SEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox txt = sender as MetroFramework.Controls.MetroTextBox;
            if (txt != null)
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txt.Name == "SEditBox")
                    {
                        cbxNaturalAccounts.Focus();
                        cbxNaturalAccounts.DroppedDown = true;
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
        private void EmpEditCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                if (EventTime == 0)
                {
                    EventCommandName = "Employees";
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
        private void txtInvoiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoadInvoiceByNumber(txtInvoiceNo.Text, true);
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
                CustomerAccountNo = oelAccount.AccountNo;
                FillCustomer(oelAccount.AccountNo);
                list = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, oelAccount.AccountNo);
                if (list.Count > 0)
                {
                    txtCurrentBalance.Text = list[0].TypedClosingBalance;
                }
            }
            else if (EventCommandName == "Employees")
            {
                EmpEditCode.Text = oelAccount.AccountName;
                EmpAccountNo = oelAccount.AccountNo;
                FillEmployees(oelAccount.AccountNo);
            }
            else if (EventCommandName == "DgvPurchases")
            {
                DgvSalesTransactions.RefreshEdit();
                DgvSalesTransactions.CurrentRow.Cells["colAccountNo"].Value = oelAccount.AccountNo;
                DgvSalesTransactions.CurrentRow.Cells["colIdAccount"].Value = oelAccount.IdAccount;
                DgvSalesTransactions.CurrentRow.Cells["colAccountName"].Value = oelAccount.AccountName;
                list = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, oelAccount.AccountNo);
                if (list.Count > 0)
                {
                    DgvSalesTransactions.CurrentRow.Cells["colClosingBalance"].Value = list[0].ClosingBalance;
                }
                else 
                {
                    DgvSalesTransactions.CurrentRow.Cells["colClosingBalance"].Value = 0;
                }
            }
            else
            {
                SalesAccountNo = oelAccount.AccountNo.ToString();
            }
        }
        private void DgvStockReceipt_KeyDown(object sender, KeyEventArgs e)
        {
        }
        void frmfindProducts_ExecuteFindPorudctsEvent(object Sender, ItemsEL oelItems)
        {
            DgvStockSales.RefreshEdit();
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
                //lblStatuMessage.Text = "";
                DgvStockSales.CurrentRow.Cells["colIdItem"].Value = oelItems.IdItem;
                DgvStockSales.CurrentRow.Cells["colItemName"].Value = oelItems.ItemName;
                DgvStockSales.CurrentRow.Cells["colpacking"].Value = oelItems.PackingSize;
                //DgvStockReceipt.CurrentRow.Cells["ColBatch"].Value = oelItems.BatchNo;
            }
        }
        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {
            VoucherNo = oelVoucher.VoucherNo;
            IdVoucher = oelVoucher.IdVoucher;
            txtSheetNo.Text = oelVoucher.VoucherNo.ToString();
            FillVoucher();

        }
        #endregion
        #region Tabs Related Events And Methods
        private void tabSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateAndInitializeFooterRow();
        }
        #endregion
        #region Sales Grid Event
        private void DgvSales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow ORow = DgvSales.Rows[e.RowIndex];
            DgvStockSales.Rows.Add();
            decimal AmountValue = 0;
            DisCountSum = 0;
            decimal Disc1 = 0, Disc2 = 0;
            //DgvStockSales.Rows[DgvStockSales.Rows.Count-1].Cells["colIdItem"].Value = ORow.Cells["colSalesIdItem"].Value;
            DgvStockSales.Rows[DgvStockSales.Rows.Count - 2].Cells["colIdItem"].Value = ORow.Cells["colSalesIdItem"].Value;
            DgvStockSales.Rows[DgvStockSales.Rows.Count - 2].Cells["colItemName"].Value = ORow.Cells["colSalesItemName"].Value;
            DgvStockSales.Rows[DgvStockSales.Rows.Count - 2].Cells["colpacking"].Value = ORow.Cells["colSalesUOM"].Value;
            DgvStockSales.Rows[DgvStockSales.Rows.Count - 2].Cells["colCartons"].Value = ORow.Cells["colSalesCartons"].Value;
            DgvStockSales.Rows[DgvStockSales.Rows.Count - 2].Cells["colQty"].Value = ORow.Cells["colSalesQuantity"].Value;
            DgvStockSales.Rows[DgvStockSales.Rows.Count - 2].Cells["colUnitPrice"].Value = ORow.Cells["colSalesUnitPrice"].Value;
            DgvStockSales.Rows[DgvStockSales.Rows.Count - 2].Cells["colAmount"].Value = ORow.Cells["colSalesNetAmount"].Value;
            
            for (int i = 0; i < DgvStockSales.Rows.Count-1; i++)
            {
                AmountValue += Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value);
            }
            txtTotalAmount.Text = AmountValue.ToString();
        }
        private decimal DiscountSumValueReturn(Int64 IdItem)
        {
            DataGridViewRow oRow = null;
            if (DgvSales.Rows.Count > 0)
            {
                for (int i = 0; i < DgvSales.Rows.Count; i++)
                {
                    if (Validation.GetSafeLong(DgvSales.Rows[i].Cells["colSalesIdItem"].Value) == IdItem)
                    {
                        oRow = DgvSales.Rows[i];
                        break;
                    }
                }
                if (oRow != null)
                {
                    string CellDisc1Value = Validation.GetSafeString(oRow.Cells["colSalesDiscount"].Value);
                    string CellDisc2Value = Validation.GetSafeString(oRow.Cells["colSalesDisc2"].Value);
                    if (CellDisc1Value.Contains('%'))
                    {
                        CellDisc1Value = CellDisc1Value.Substring(0, CellDisc1Value.Length - 1);
                    }
                    if (CellDisc2Value.Contains('%'))
                    {
                        CellDisc2Value = CellDisc2Value.Substring(0, CellDisc2Value.Length - 1);
                    }

                    DisCountSum = Validation.GetSafeDecimal(CellDisc1Value) + Validation.GetSafeDecimal(CellDisc2Value);        
                }
            }
            else
                DisCountSum = 0;

            return DisCountSum;
        }
        #endregion
        #region Stock Grid Events
        private void DgvStockSales_KeyPress(object sender, KeyPressEventArgs e)
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
        private void DgvStockSales_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvStockSales.CurrentCellAddress.X == 3)
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
            if (DgvStockSales.CurrentCellAddress.X == 3)
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
        private void DgvStockSales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void DgvStockSales_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 18)
            {
                e.Value = "Delete";
            }
        }
        private void DgvStockSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal lineAmount, value = 0;
            if (e.ColumnIndex == 18)
            {
                if (DgvStockSales.Rows[e.RowIndex].Cells["ColIdVoucherDetail"].Value == null)
                {
                    if (DgvStockSales.Rows.Count > 1)
                    {
                        DataGridViewRow oRow = DgvStockSales.Rows[e.RowIndex];
                        DgvStockSales.Rows.Remove(oRow);
                    }
                    DataGridViewCell oCell = DgvStockSales.Rows[e.RowIndex].Cells["colAmount"];
                    for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                    {
                        value += Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value);
                    }
                    //lineAmount = Validation.GetSafeDecimal(oCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit));
                    //txtCreditBalance.Text = (Validation.GetSafeDecimal(txtCreditBalance.Text) - lineAmount).ToString();
                    txtTotalAmount.Text = value.ToString();
                }
                else
                {
                    if (!chkPosted.Checked)
                    {
                        if (DgvStockSales.Rows.Count - 1 == 1)
                        {
                            MessageBox.Show("There Is Only One Record In This Voucher , Please Press Delete Button To Remove This Voucher");
                            return;
                        }
                        var Manager = new VoucherBLL();
                        lineAmount = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);
                        txtTotalAmount.Text = (Validation.GetSafeDecimal(txtTotalAmount.Text) - lineAmount).ToString();

                        if (Manager.DeleteChildRecords(Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colIdDetail"].Value), VoucherTypes.SalesReturnVoucher.ToString()))
                        {
                            DataGridViewRow oRow = DgvStockSales.Rows[e.RowIndex];
                            DgvStockSales.Rows.Remove(oRow);
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
        private void DgvStockSales_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (DgvStockSales.IsCurrentCellDirty)
            {
                DgvStockSales.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }
        private void DgvStockSales_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            //if (DgvStockReceipt.Columns[e.ColumnIndex].Name == "colAmount")
            //{
            //    OldValue = Convert.ToInt32(DgvStockReceipt.Rows[e.RowIndex].Cells["colAmount"].Value);
            //}
        }
        private void DgvStockSales_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            if (DgvStockSales.Columns[e.ColumnIndex].Name == "colUnitPrice")
            {
                DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value) *
                                                                            Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                DisCountSum = DiscountSumValueReturn(Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value));
                if (DisCountSum > 0)
                {
                    DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) - ((Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) * DisCountSum) / 100);    
                }
                for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value);
                }
                txtTotalAmount.Text = OldValue.ToString();
                OldValue = 0;
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
        private void DgvStockSales_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (DgvStockSales.Columns[e.ColumnIndex].Name == "colUnitPrice")
            //{
            //    DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value));
            //}
            //DisCountSum = DiscountSumValueReturn(Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value));
            //if (DisCountSum > 0)
            //{
            //    DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) - ((Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) * DisCountSum) / 100);
            //}
            if (DgvStockSales.Columns[e.ColumnIndex].Name == "colAmount")
            {
                //DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value) * Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value);
                }
                txtTotalAmount.Text = OldValue.ToString();
                OldValue = 0;
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
        private void DgvStockSales_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvStockSales.Columns["colVehicleColors"].Visible)
            {
                if (e.ColumnIndex == 11)
                {
                    SendKeys.Send("{F4}");
                }
            }
        }
        private void DgvStockSales_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
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
        #endregion
        #region Sales Grid Code and Events
        private void DgvSalesTransactions_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSalesTransactions.Columns[e.ColumnIndex].Name == "colDebit")
            {

                for (int i = 0; i < DgvSalesTransactions.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvSalesTransactions.Rows[i].Cells["colDebit"].Value);
                }
                //txtAmount.Text = OldValue.ToString();
                txtDebit.Text = OldValue.ToString();
                OldValue = 0;

            }
            else if (DgvSalesTransactions.Columns[e.ColumnIndex].Name == "colCredit")
            {
                for (int i = 0; i < DgvSalesTransactions.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvSalesTransactions.Rows[i].Cells["colCredit"].Value);
                }
                //txtAmount.Text = OldValue.ToString();
                txtCredit.Text = OldValue.ToString();
                OldValue = 0;
            }
        }
        private void DgvSalesTransactions_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvSalesTransactions.Columns[e.ColumnIndex].Name == "colDebit")
            {
                if (DgvSalesTransactions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    DgvSalesTransactions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
            else if (DgvSalesTransactions.Columns[e.ColumnIndex].Name == "colCredit")
            {
                if (DgvSalesTransactions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null)
                {
                    DgvSalesTransactions.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = 0;
                }
            }
        }
        private void DgvSalesTransactions_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (DgvSalesTransactions.CurrentCellAddress.X == 3)
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
            if (DgvSalesTransactions.CurrentCellAddress.X == 3)
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
        #region Invoice Related Methods
        private void LoadInvoiceByNumber(string InvoiceNumber, bool LoadByRealInvoice)
        {
            #region Variables
            var Manager = new VoucherBLL();
            var SManager = new SalesHeadBLL();
            VoucherType = "P";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            #endregion
            #region Filling Sales Header And Detail
            List<VoucherDetailEL> ListSales = SManager.GetDistributionSalesTransactionsByNumber(Validation.GetSafeLong(InvoiceNumber), Operations.IdProject, Operations.BookNo);
            if (ListSales.Count > 0)
            {
                //IdVoucher = ListSales[0].IdVoucher;
                //InvEditBox.Text = Validation.GetSafeString(ListSales[0].VoucherNo);                
                txtBiltyNo.Text = ListSales[0].BiltyNo;
                txtGatePass.Text = ListSales[0].OutWardGatePassNo;
                //VDate.Value = ListSales[0].VDate.Value;
                if(LoadByRealInvoice)
                txtCurrentBalance.Text = ListSales[0].ClosingBalance.ToString();
                //txtTotalAmount.Text = Validation.GetSafeString(ListSales[0].TotalAmount);
                IsNetTransaction = ListSales[0].IsNetTransaction.Value;
                if (ListSales[0].IsNetTransaction.Value)
                {
                    RdCashSale.Checked = true;
                    RdCreditSales.Checked = false;
                    pnlCash.Visible = true;
                    if(ListSales[0].CashAccountNo != string.Empty && ListSales[0].CashAccountNo != null)
                    FillCashAccounts(ListSales[0].CashAccountNo);
                    FillCustomerParty(ListSales[0].AccountNo);
                }
                else
                {
                    RdCashSale.Checked = false;
                    RdCreditSales.Checked = true;
                    pnlCash.Visible = false;
                    if (ListSales[0].CashAccountNo != string.Empty)
                        FillCashAccounts(ListSales[0].CashAccountNo);
                    FillCustomerParty(ListSales[0].AccountNo);
                }
                EmpAccountNo = ListSales[0].SubAccountNo;
                FillEmployees(EmpAccountNo);
                CustomerAccountNo = ListSales[0].AccountNo;
                EmpDeliveryAccountNo = ListSales[0].EmployeeAccountNo;
                FillDeliveryPerson(EmpDeliveryAccountNo);
                if (!IsNetTransaction)
                {
                    //FillCustomer(ListSales[0].AccountNo);
                }
                else
                {
                    //txtSupplierName.Text = ListSales[0].FirstName;
                    //txtSupplierContact.Text = ListSales[0].Contact;
                    //txtSupplerCNIC.Text = ListSales[0].Cnic;
                    //txtSupplierAddress.Text = ListSales[0].Address;
                }
                //chkPosted.Checked = ListSales[0].Posted.Value;
                //if (ListSales[0].Posted.Value)
                //{
                //    //if (Operations.IdRole != Validation.GetSafeLong(EnRoles.Administrator))
                //    //{
                //    //    btnSave.Enabled = false;
                //    //    btnDelete.Enabled = false;
                //    //    chkPosted.Enabled = false;
                //    //}
                //    chkPosted.Enabled = false;
                //}
                //else
                //{
                //    chkPosted.Enabled = true;
                //    //btnSave.Enabled = true;
                //    //btnDelete.Enabled = true;
                //}
                //HandleVoucher(ListSales);
                FillInvoiceSales(ListSales);
                if (LoadByRealInvoice)
                {
                    List<VoucherDetailEL> ListInvoiceBasedSale = SManager.GetSalesReturnTransactionsOnInvoiceBasis(Validation.GetSafeLong(InvoiceNumber), Operations.IdProject, Operations.BookNo, null);
                    if (ListInvoiceBasedSale.Count > 0)
                    {
                        IdVoucher = ListInvoiceBasedSale[0].IdVoucher;
                        FillVoucher();
                    }
                }

            }
            #endregion            
        }
        private void FillInvoiceSales(List<VoucherDetailEL> List)
        {
            if (DgvSales.Rows.Count > 0)
            {
                DgvSales.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {

                for (int i = 0; i < List.Count; i++)
                {
                    DgvSales.Rows.Add();
                    //DgvStockReceipt.Rows[i].Cells[0].Value = List[i].TransactionID;
                    DgvSales.Rows[i].Cells[0].Value = List[i].IdVoucherDetail;
                    DgvSales.Rows[i].Cells[1].Value = List[i].IdItem;
                    DgvSales.Rows[i].Cells[2].Value = List[i].ItemNo;
                    DgvSales.Rows[i].Cells[3].Value = List[i].ItemName;
                    DgvSales.Rows[i].Cells[4].Value = List[i].PackingSize;
                    DgvSales.Rows[i].Cells[5].Value = List[i].TotalCartons;
                    DgvSales.Rows[i].Cells[6].Value = List[i].BatchNo;
                    DgvSales.Rows[i].Cells[7].Value = List[i].Expiry;
                    DgvSales.Rows[i].Cells[8].Value = List[i].EngineNo;
                    DgvSales.Rows[i].Cells[9].Value = List[i].ChasisNo;
                    DgvSales.Rows[i].Cells[10].Value = List[i].VehicleModel;
                    if (List[i].ColorCode == 1)
                    {
                        DgvSales.Rows[i].Cells[11].Value = "Red";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        DgvSales.Rows[i].Cells[11].Value = "Black";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        DgvSales.Rows[i].Cells[11].Value = "Blue";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        DgvSales.Rows[i].Cells[11].Value = "Silver";
                    }
                    DgvSales.Rows[i].Cells[12].Value = List[i].VehicleNo;
                    DgvSales.Rows[i].Cells[13].Value = List[i].FirstIMEI;
                    DgvSales.Rows[i].Cells[14].Value = List[i].SecondIMEI;

                    DgvSales.Rows[i].Cells[15].Value = CommonFunctions.RemoveTrailingZeros(List[i].CurrentStock);
                    DgvSales.Rows[i].Cells[16].Value = CommonFunctions.RemoveTrailingZeros(List[i].Units);
                    DgvSales.Rows[i].Cells[17].Value = CommonFunctions.RemoveTrailingZeros(List[i].Bonus);
                    DgvSales.Rows[i].Cells[18].Value = List[i].UnitPrice;
                    DgvSales.Rows[i].Cells[19].Value = List[i].Amount;
                    DgvSales.Rows[i].Cells[20].Value = List[i].Discount.ToString() + "%";
                    DgvSales.Rows[i].Cells[21].Value = List[i].DiscountAmount;
                    DgvSales.Rows[i].Cells[22].Value = List[i].PromoDiscount;
                    DgvSales.Rows[i].Cells[23].Value = List[i].NetSaleAmount;

                }
            }
        }
        private void FillCustomerParty(string AccountNo)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccount(AccountNo, Operations.IdCompany, Operations.IdProject);
            if (list.Count > 0)
            {
                SEditBox.Text = list[0].AccountName;
            }
            List<TransactionsEL> listClosingBalance = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, AccountNo);
            if (listClosingBalance.Count > 0)
                txtCurrentBalance.Text = listClosingBalance[0].TypedClosingBalance.ToString();
            else
                txtCurrentBalance.Text = "0";
        }
        private void FillDeliveryPerson(string AccountNo)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccount(AccountNo, Operations.IdCompany, Operations.IdProject);
            if (list.Count > 0)
            {
                txtDeliveryPerson.Text = list[0].AccountName;
            }
        }
        private void FillEmployees(string AccountNo)
        {
            var manager = new AccountsBLL();
            List<AccountsEL> list = manager.GetAccount(AccountNo, Operations.IdCompany, Operations.IdProject);
            if (list.Count > 0)
            {
                EmpEditCode.Text = list[0].AccountName;
            }
        }
        #endregion
        #region Grids Transactions Related Methods     
        private void FillVoucher()
        {
            #region Variables
            var Manager = new VoucherBLL();
            var SManager = new SalesHeadBLL();
            VoucherType = "P";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            #endregion
            #region Filling Sales Header And Detail
            //List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(VEditBox.Text));
            List<VoucherDetailEL> ListSales = SManager.GetSalesReturnTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, null);
            if (ListSales.Count > 0)
            {
                IdVoucher = ListSales[0].IdVoucher;
                InvEditBox.Text = Validation.GetSafeString(ListSales[0].VoucherNo);
                //txtBiltyNo.Text = ListSales[0].BiltyNo;
                txtInvoiceNo.Text = Validation.GetSafeString(ListSales[0].InvoiceNo);
                if (Validation.GetSafeString(ListSales[0].InvoiceNo) != string.Empty)
                {
                    LoadInvoiceByNumber(ListSales[0].InvoiceNo.ToString(), false);
                }
                IsNetTransaction = ListSales[0].IsNetTransaction.Value;
                txtInwardGatePass.Text = ListSales[0].InWardGatePassNo;
                txtGatePass.Text = ListSales[0].OutWardGatePassNo;
                VDate.Value = ListSales[0].VDate.Value;
                txtTotalAmount.Text = ListSales[0].TotalAmount.ToString();
                cbxAdjustmentTypes.SelectedIndex = Validation.GetSafeInteger(ListSales[0].IdStockAdjustmentType);
                //if (!IsNetTransaction)
                //{
                //    FillCustomer(ListSales[0].AccountNo);
                //}
                //else
                //{
                //    //txtSupplierName.Text = ListSales[0].FirstName;
                //    //txtSupplierContact.Text = ListSales[0].Contact;
                //    //txtSupplerCNIC.Text = ListSales[0].Cnic;
                //    //txtSupplierAddress.Text = ListSales[0].Address;
                //}
                //chkPosted.Checked = ListSales[0].Posted.Value;
                if (ListSales[0].Posted.Value)
                {
                    //if (Operations.IdRole != Validation.GetSafeLong(EnRoles.Administrator))
                    //{
                    //    btnSave.Enabled = false;
                    //    btnDelete.Enabled = false;
                    //    chkPosted.Enabled = false;
                    //}
                    chkPosted.Checked = true;
                    chkPosted.Enabled = false;
                    //lblStatuMessage.Text = "Posted Voucher ...";
                    //lblStatuMessage.ForeColor = Color.Red;
                }
                else
                {
                    chkPosted.Enabled = true;
                    chkPosted.Checked = false;
                    //btnSave.Enabled = true;
                    //btnDelete.Enabled = true;
                }
                HandleVoucher(ListSales);
                FillSales(ListSales);
            #endregion
            #region Filling Transactional Data
            List<VoucherDetailEL> listTransactions = SManager.GetSalesReturnSubTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo, null);

            FillHeadTransactions(listTransactions);
            FillSalesTransactions(listTransactions);
            #endregion
            }
            else
            {
                MessageBox.Show("Voucher Number Not Found ...");
                ClearControls();
            }
        }
        private void HandleVoucher(List<VoucherDetailEL> list)
        {
            lblVoucherStatus.Text = string.Empty;
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
            else
            {
                btnSave.Enabled = true;
                btnDelete.Enabled = true;
            }
        }
        private void FillSales(List<VoucherDetailEL> List)
        {
            if (DgvStockSales.Rows.Count > 0)
            {
                DgvStockSales.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {

                for (int i = 0; i < List.Count; i++)
                {
                    DgvStockSales.Rows.Add();
                    //DgvStockReceipt.Rows[i].Cells[0].Value = List[i].TransactionID;
                    DgvStockSales.Rows[i].Cells[0].Value = List[i].IdVoucherDetail;
                    DgvStockSales.Rows[i].Cells[1].Value = List[i].IdItem;
                    DgvStockSales.Rows[i].Cells[2].Value = List[i].ItemNo;
                    DgvStockSales.Rows[i].Cells[3].Value = List[i].ItemName;
                    DgvStockSales.Rows[i].Cells[4].Value = List[i].PackingSize;
                    DgvStockSales.Rows[i].Cells[5].Value = List[i].TotalCartons;
                    DgvStockSales.Rows[i].Cells[6].Value = List[i].BatchNo;
                    DgvStockSales.Rows[i].Cells[7].Value = List[i].Expiry;
                    DgvStockSales.Rows[i].Cells[8].Value = List[i].EngineNo;
                    DgvStockSales.Rows[i].Cells[9].Value = List[i].ChasisNo;
                    DgvStockSales.Rows[i].Cells[10].Value = List[i].VehicleModel;
                    if (List[i].ColorCode == 1)
                    {
                        DgvStockSales.Rows[i].Cells[11].Value = "Red";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        DgvStockSales.Rows[i].Cells[11].Value = "Black";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        DgvStockSales.Rows[i].Cells[11].Value = "Blue";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        DgvStockSales.Rows[i].Cells[11].Value = "Silver";
                    }
                    DgvStockSales.Rows[i].Cells[12].Value = List[i].VehicleNo;
                    DgvStockSales.Rows[i].Cells[13].Value = List[i].FirstIMEI;
                    DgvStockSales.Rows[i].Cells[14].Value = List[i].SecondIMEI;


                    DgvStockSales.Rows[i].Cells[15].Value = CommonFunctions.RemoveTrailingZeros(List[i].Units);
                    DgvStockSales.Rows[i].Cells[16].Value = List[i].UnitPrice;
                    DgvStockSales.Rows[i].Cells[17].Value = List[i].Amount;

                }
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
                        CustomerTransactionId = List[i].IdTransactionDetail;
                        SEditBox.Text = List[i].AccountName;
                        CustomerAccountNo = List[i].AccountNo;
                        List<TransactionsEL> listClosingBalance = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, List[i].AccountNo);
                        if (listClosingBalance.Count > 0)
                            txtCurrentBalance.Text = listClosingBalance[0].TypedClosingBalance.ToString();
                        else
                            txtCurrentBalance.Text = "0";
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
                    SalesTransactionId = List[i].IdTransactionDetail;
                    cbxNaturalAccounts.SelectedValue = List[i].AccountNo;
                    SalesAccountNo = List[i].AccountNo;
                }
            }
        }
        private void FillSalesTransactions(List<VoucherDetailEL> List)
        {
            if (DgvSalesTransactions.Rows.Count > 0)
            {
                DgvSalesTransactions.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {
                List.RemoveAll(x => x.TrackNumber == 1 || x.TrackNumber == 2);
                for (int i = 0; i < List.Count; i++)
                {
                    if (List[i].TrackNumber != 1 && List[i].TrackNumber != 2)
                    {
                        DgvSalesTransactions.Rows.Add();
                        DgvSalesTransactions.Rows[i].Cells[0].Value = List[i].IdTransactionDetail;
                        DgvSalesTransactions.Rows[i].Cells[1].Value = List[i].IdAccount;
                        DgvSalesTransactions.Rows[i].Cells[2].Value = List[i].AccountNo;
                        DgvSalesTransactions.Rows[i].Cells[3].Value = List[i].AccountName;
                        DgvSalesTransactions.Rows[i].Cells[4].Value = List[i].Narration;
                        DgvSalesTransactions.Rows[i].Cells[5].Value = List[i].Debit;
                        DgvSalesTransactions.Rows[i].Cells[6].Value = List[i].Credit;
                    }
                }
                txtDebit.Text = List.Sum(x => x.Debit).ToString();
                txtCredit.Text = List.Sum(x => x.Credit).ToString();
            }
        }
        #endregion
    }
}

