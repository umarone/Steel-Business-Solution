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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.Common;

namespace Accounts.UI
{
    public partial class frmDistributionSales : MetroForm
    {
        #region Variables
        frmAccounts frmaccounts;
        frmFindAccounts frmAccount;
        frmFindProducts frmfindProducts;
        frmFindVouchers frmfindVouchers;
        frmAuthentication frmauthentication;
        frmPersons frmpersons;
        frmReports frmprintInvoice;
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
        string CustomerAccountNo = "", SalesAccountNo = "", CashAccountNo = "", EmpAccountNo = "0", EmpDeliveryAccountNo = "0";
        ConnectionInfo oConnectionInfo = new ConnectionInfo();
        #endregion
        #region Form Methods And Events
        public frmDistributionSales()
        {
            InitializeComponent();
        }
        private void frmSales_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DgvStockSales.AutoGenerateColumns = false;
            ShowHideColumns();
            AdjustControls();
            //FillData();
            FillNaturalAccounts(string.Empty);
            FillCashAccounts(string.Empty);
            CheckModulePermissions();
            FillTotalVouchers();
            GetLastVoucherTransactionByType();
            //if (IsNetTransaction)
            //{
            //    this.Text = "Net Inventory Sales";
            //    btnViewDetail.Enabled = false;
            //    btnAddCustomer.Text = "Add Cash Account";
            //    grpDebitor.Text = "Cash Account Information";
            //}
            //else
            //{
            //    this.Text = "Credit Inventory Sales";
            //}

        }
        private void frmSales_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                //FillData();
                ClearControls();
                if (DgvStockSales.Rows.Count > 0)
                {
                    DgvStockSales.Rows.Clear();
                }
                VDate.Focus();
            }
            else if (e.KeyChar == (char)Keys.Tab)
            { 
                
            }
            else if (e.KeyChar == (char)Keys.End)
            {
                btnSave_Click(sender, e);
            }
        }
        private void frmDistributionSales_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.F12)
            if (e.Alt && e.KeyCode == Keys.N)
                ClearControls();
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
                        grpEmployees.Visible = false;
                        DgvStockSales.Columns["colBonusUnit"].Visible = false;
                        DgvStockSales.Columns["colEngineNo"].Visible = false;
                        DgvStockSales.Columns["colChassisNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleNo"].Visible = false;
                        DgvStockSales.Columns["colBatchNo"].Visible = false;
                        DgvStockSales.Columns["colExpiry"].Visible = false;
                        DgvStockSales.Columns["colVehicleModel"].Visible = false;
                        DgvStockSales.Columns["colVehicleColors"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;

                        DgvStockSales.Columns["colItemName"].Width = 250;
                        DgvStockSales.Columns["colpacking"].Width = 70;
                        DgvStockSales.Columns["colCurrentStock"].Width = 100;
                        DgvStockSales.Columns["colQty"].Width = 80;
                        DgvStockSales.Columns["colUnitPrice"].Width = 80;
                        DgvStockSales.Columns["colAmount"].Width = 80;
                        DgvStockSales.Columns["colDiscount"].Width = 80;
                        DgvStockSales.Columns["colDiscountAmount"].Width = 90;
                        DgvStockSales.Columns["colDelete"].Width = 80;
                    }
                    else if (objActiveType.SoftwareType == "POS")
                    {
                        grpEmployees.Visible = false;
                        DgvStockSales.Columns["colBonusUnit"].Visible = false;
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
                    }
                    else if (objActiveType.SoftwareType == "Motor Bikes")
                    {
                        grpEmployees.Visible = false;
                        DgvStockSales.Columns["colBonusUnit"].Visible = false;
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
                        grpEmployees.Visible = false;
                        DgvStockSales.Columns["colBonusUnit"].Visible = false;
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
                        grpEmployees.Visible = false;
                        DgvStockSales.Columns["colBonusUnit"].Visible = false;
                        DgvStockSales.Columns["colEngineNo"].Visible = false;
                        DgvStockSales.Columns["colChassisNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleModel"].Visible = false;
                        DgvStockSales.Columns["colVehicleColors"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;


                        DgvStockSales.Columns["colItemName"].Width = 290;
                    }
                    else if (objActiveType.SoftwareType == "Medicine POS")
                    {
                        grpEmployees.Visible = false;
                        DgvStockSales.Columns["colBonusUnit"].Visible = false;
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
                        grpEmployees.Visible = false;
                        DgvStockSales.Columns["colBonusUnit"].Visible = false;
                        DgvStockSales.Columns["colItemName"].Width = 250;
                        DgvStockSales.Columns["colpacking"].Width = 70;
                        DgvStockSales.Columns["colFirstIMEI"].Width = 90;
                        DgvStockSales.Columns["colCurrentStock"].Width = 100;
                        DgvStockSales.Columns["colQty"].Width = 80;
                        DgvStockSales.Columns["colUnitPrice"].Width = 80;
                        DgvStockSales.Columns["colAmount"].Width = 80;
                        DgvStockSales.Columns["colDiscount"].Width = 80;
                        DgvStockSales.Columns["colDiscountAmount"].Width = 90;
                        DgvStockSales.Columns["colDelete"].Width = 80;

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
                        grpEmployees.Visible = true;
                        DgvStockSales.Columns["colCartons"].Visible = false;
                        DgvStockSales.Columns["colBonusUnit"].Visible = false;
                        DgvStockSales.Columns["colEngineNo"].Visible = false;
                        DgvStockSales.Columns["colChassisNo"].Visible = false;
                        DgvStockSales.Columns["colVehicleNo"].Visible = false;
                        DgvStockSales.Columns["colBatchNo"].Visible = false;
                        DgvStockSales.Columns["colExpiry"].Visible = false;
                        DgvStockSales.Columns["colVehicleModel"].Visible = false;
                        DgvStockSales.Columns["colVehicleColors"].Visible = false;
                        DgvStockSales.Columns["colFirstIMEI"].Visible = false;
                        DgvStockSales.Columns["colSecondIMEI"].Visible = false;

                        DgvStockSales.Columns["colItemName"].Width = 300;
                        DgvStockSales.Columns["colpacking"].Width = 70;
                        DgvStockSales.Columns["colCurrentStock"].Width = 100;
                        DgvStockSales.Columns["colQty"].Width = 70;
                        DgvStockSales.Columns["colBonusUnit"].Width = 70;
                        DgvStockSales.Columns["colUnitPrice"].Width = 85;
                        DgvStockSales.Columns["colAmount"].Width = 80;
                        DgvStockSales.Columns["colDiscount"].Width = 80;
                        DgvStockSales.Columns["colDiscountAmount"].Width = 90;
                        DgvStockSales.Columns["colPromoDisc"].Width = 80;
                        DgvStockSales.Columns["colNetAmount"].Width = 90;
                        DgvStockSales.Columns["colDelete"].Width = 60;
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
            pnlCash.Visible = false;
            //if (IsNetTransaction)
            //{
            //    grpDebitor.Visible = false;
            //    grpCustomer.Visible = true;
            //    lblCreditDays.Visible = false;
            //    txtCreditDays.Visible = false;
            //}
            //else
            //{
            //    pnlCash.Visible = false;
            //    grpCustomer.Visible = false;
            //}            
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
                SEditBox.Text = list[0].PersonName + " -" + list[0].Address;
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
        private void FillData()
        {
            var manager = new SalesHeadBLL();
            InvEditBox.Text = manager.GetMaxSalesInvoiceNumberBySaleType(Operations.IdProject, Operations.BookNo, IsNetTransaction, 1).ToString();
        }
        private void FillTotalVouchers()
        {
            var Manager = new VoucherBLL();
            lblTotalVouchers.Text = Manager.GetAllStockTotalTransactionalVouchersByType(Operations.IdProject, Operations.BookNo, VoucherTypes.SaleInvoiceVoucher.ToString(), IsNetTransaction).ToString();
        }
        private void GetLastVoucherTransactionByType()
        {
            var Manager = new VoucherBLL();
            List<VouchersEL> listLast = Manager.GetStockLastVoucherTransactionByType(Operations.IdProject, Operations.BookNo, VoucherTypes.SaleInvoiceVoucher.ToString(), IsNetTransaction);
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
        private void ClearControls()
        {
            DgvStockSales.Rows.Clear();
            DgvSalesTransactions.Rows.Clear();
            //txtDescription.Text = string.Empty;
            VoucherNo = 0;
            IdVoucher = 0;
            txtSheetNo.Text = string.Empty;
            txtSheetNo.Enabled = true;
            txtDescription.Text = string.Empty;
            txtBillAmount.Text = string.Empty;
            txtFreightAmount.Text = string.Empty;
            txtExtraDiscount.Text = string.Empty;
            txtTotalDiscount.Text = string.Empty;
            txtTotalAmount.Text = string.Empty;
            CustomerTransactionId = null;
            VDate.Value = DateTime.Now;
            lblVoucherStatus.Visible = false;
            SalesTransactionId = null;
            CashTransactionId = null;

            SEditBox.Text = string.Empty;
            lblStatuMessage.Text = string.Empty;
            if (chkPosted.Checked)
            {
                chkPosted.Checked = false;
                chkPosted.Enabled = true;
            }
            btnSave.Enabled = true;
            btnDelete.Enabled = true;

            txtBiltyNo.Text = string.Empty;
            txtContact.Text = string.Empty;
            txtCurrentBalance.Text = string.Empty;

            InvEditBox.Enabled = true;
            InvEditBox.Text = string.Empty;
            txtSampleNo.Text = string.Empty;
            txtCreditDays.Text = string.Empty;
            txtGatePass.Text = string.Empty;

            cbxNaturalAccounts.SelectedIndex = -1;
            cbxCashAccounts.SelectedIndex = -1;

            CustomerAccountNo = string.Empty;
            SalesAccountNo = string.Empty;
            //EmpDeliveryAccountNo = string.Empty;
            //EmpAccountNo = string.Empty;
            //txtDeliveryPerson.Text = string.Empty;
            //EmpEditCode.Text = string.Empty;
            VDate.Focus();
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
            if (CustomerAccountNo == string.Empty)
            {
                MessageBox.Show("Customer Account Missing...");
                return false;
            }
            if (RdCreditSales.Checked)
            {
                if (CustomerAccountNo == string.Empty)
                {
                    MessageBox.Show("Customer Account Missing...");
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
            string First = txtDescription.Text == string.Empty ? "Following Are Sales To " + SEditBox.Text + "~" : txtDescription.Text + "~";                            
            for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
            {
                Remarks += DgvStockSales.Rows[i].Cells[3].Value.ToString() + " "
                           + DgvStockSales.Rows[i].Cells[16].Value.ToString() + " Units"
                           + "@" + DgvStockSales.Rows[i].Cells[23].Value.ToString() + "~";
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
            List<VoucherDetailEL> oelProductsProfitLossCollection = new List<VoucherDetailEL>();
            List<ItemsEL> oelItemsCollection = new List<ItemsEL>();
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
                        oelVoucher.SheetNo = Validation.GetSafeLong(txtSheetNo.Text);
                        oelVoucher.BookNo = Operations.BookNo;
                        oelVoucher.TerminalNumber = Validation.GetSafeInteger(XmlConfiguration.ReadXmlTerminalsConfiguration()[0]);
                        oelVoucher.BiltyNo = Validation.GetSafeString(txtBiltyNo.Text);
                        oelVoucher.SampleNo = Validation.GetSafeLong(txtSampleNo.Text);
                        oelVoucher.FirstName = string.Empty;
                        oelVoucher.Contact = string.Empty;
                        oelVoucher.Cnic = string.Empty;
                        oelVoucher.Address = string.Empty;
                        oelVoucher.SoftwareType = SoftwareType();
                        oelVoucher.AccountNo = CustomerAccountNo;
                        oelVoucher.CashAccountNo = CashAccountNo;
                        
                        if (IdVoucher != null || IdVoucher > 0)
                        {
                            oelVoucher.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
                        }
                        oelVoucher.SubAccountNo = EmpAccountNo;
                        oelVoucher.EmployeeAccountNo = EmpDeliveryAccountNo;
                        oelVoucher.VDiscription = Validation.GetSafeString(txtDescription.Text);
                        oelVoucher.OutWardGatePassNo = Validation.GetSafeString(txtGatePass.Text);
                        oelVoucher.VDate = VDate.Value;
                        oelVoucher.DueDate = dueDate.Value;
                        if (RdCreditSales.Checked)
                        {
                            if (IdVoucher != null && IdVoucher > 0)
                            {
                                if (txtCurrentBalance.Text.Contains("DR") || txtCurrentBalance.Text.Contains("CR"))
                                {
                                    oelVoucher.ClosingBalance = Validation.GetSafeDecimal(txtCurrentBalance.Text.Remove(txtCurrentBalance.Text.IndexOf(' ')));
                                }
                                else
                                {
                                    oelVoucher.ClosingBalance = Validation.GetSafeDecimal(txtCurrentBalance.Text);
                                }
                            }
                            else
                            {
                                oelVoucher.ClosingBalance = CommonFunctions.GetUnPostedClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, CustomerAccountNo)[0].ClosingBalance;//CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, CustomerAccountNo)[0].ClosingBalance;  //Validation.GetSafeDecimal(txtCurrentBalance.Text);
                            }
                        }
                        else
                        {
                            oelVoucher.ClosingBalance = 0;
                        }
                        oelVoucher.BillAmount = Validation.GetSafeDecimal(txtBillAmount.Text);
                        oelVoucher.TotalFreight = Validation.GetSafeDecimal(txtFreightAmount.Text);
                        oelVoucher.ExtraDiscount = Validation.GetSafeDecimal(txtExtraDiscount.Text);
                        oelVoucher.TotalAmount = Math.Round(Validation.GetSafeDecimal(txtTotalAmount.Text));
                        oelVoucher.VAT = 0;//Validation.GetSafeInteger(txtVat.Text);
                        oelVoucher.VATAmount = 0;//Validation.GetSafeDecimal(txtTotalAmount.Text);
                        oelVoucher.Transactiondays = Validation.GetSafeLong(txtCreditDays.Text);
                        oelVoucher.IsRecieved = false;
                        oelVoucher.IsImportTransaction = IsImportTransaction;
                        oelVoucher.IsNetTransaction = RdCashSale.Checked ? true : false;
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
                            oelSaleDetial.CurrentStock = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colCurrentStock"].Value);
                            oelSaleDetial.Units = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colQty"].Value);
                            oelSaleDetial.Bonus = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colBonusUnit"].Value);
                            //oelPurchaseDetial.Bonus = Validation.GetSafeInteger(DgvStockReceipt.Rows[i].Cells["colBonus"].Value);
                            oelSaleDetial.RemainingUnits = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colQty"].Value);
                            oelSaleDetial.UnitPrice = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colUnitPrice"].Value);
                            oelItem.CurrentUnitPrice = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colUnitPrice"].Value);
                            oelSaleDetial.Amount = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value);
                            oelSaleDetial.Discount = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscount"].Value.ToString().Replace('%', ' '));
                            oelSaleDetial.DiscountAmount = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscountAmount"].Value);
                            oelSaleDetial.PromoDiscount = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colPromoDisc"].Value.ToString().Replace('%', ' '));
                            oelSaleDetial.NetSaleAmount = Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colNetAmount"].Value);

                            oelItemsCollection.Add(oelItem);
                            oelSalesDetailCollection.Add(oelSaleDetial);
                        }
                        #endregion
                        #region Add Products Profit & Loss
                        if (chkPosted.Checked)
                        {
                            for (int k = 0; k < DgvStockSales.Rows.Count - 1; k++)
                            {
                                var IManager = new ItemsBLL();
                                VoucherDetailEL oelProductsProfitLoss = new VoucherDetailEL();
                                oelProductsProfitLoss.IdItem = Validation.GetSafeLong(DgvStockSales.Rows[k].Cells["colIdItem"].Value);
                                oelProductsProfitLoss.NetSaleAmount = Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colDiscountAmount"].Value);
                                oelProductsProfitLoss.SaleCost = Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(oelProductsProfitLoss.IdItem.Value)) *
                                                                         Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colQty"].Value);
                                oelProductsProfitLoss.Units = Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colQty"].Value);
                                oelProductsProfitLoss.NetProfit = oelProductsProfitLoss.NetSaleAmount - oelProductsProfitLoss.SaleCost;

                                oelProductsProfitLossCollection.Add(oelProductsProfitLoss);
                            }
                        }
                        #endregion
                        #region Add Inventory And COGS Accounts
                        if (chkPosted.Checked)
                        {
                            for (int k = 0; k < DgvStockSales.Rows.Count - 1; k++)
                            {
                                if (Validation.GetSafeDecimal(DgvStockSales.Rows[k].Cells["colDiscountAmount"].Value) > 0)
                                {
                                    var IManager = new ItemsBLL();
                                    List<ItemsEL> EachItem = IManager.GetItemById(Validation.GetSafeLong(DgvStockSales.Rows[k].Cells["colIdItem"].Value));
                                    if (oelCostOfSalesCollection.Count > 0)
                                    {
                                        VoucherDetailEL oelFindInventoryDetail = oelCostOfSalesCollection.Find(x => x.AccountNo == EachItem[0].InventoryAccount);
                                        if (oelFindInventoryDetail != null)
                                        {
                                            oelFindInventoryDetail.Credit += Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) *
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
                                            oelFindCOGSDetail.Debit += Validation.GetSafeDecimal(IManager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) *
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
                            if (IdVoucher != null && IdVoucher > 0 && RdCreditSales.Checked && CustomerTransactionId.Value == 0 && CashTransactionId.Value > 0)
                            {
                                oelCustomerTransaction.IdTransactionDetail = CashTransactionId.Value;
                                oelCustomerTransaction.IsNew = false;
                            }
                            //else
                            //{
                            //    oelCustomerTransaction.IdTransactionDetail = 0;
                            //    oelCustomerTransaction.IsNew = true;
                            //}
                            oelCustomerTransaction.IsNetTransaction = RdCashSale.Checked ? true : false;
                            oelCustomerTransaction.SeqNo = 1;
                            oelCustomerTransaction.TrackNumber = 1;
                            oelCustomerTransaction.IdProject = Operations.IdProject;
                            oelCustomerTransaction.BookNo = Operations.BookNo;
                            oelCustomerTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCustomerTransaction.AccountNo = CustomerAccountNo;
                            oelCustomerTransaction.SubAccountNo = "0";
                            oelCustomerTransaction.Date = VDate.Value;
                            oelCustomerTransaction.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
                            oelCustomerTransaction.VoucherType = "S";
                            oelCustomerTransaction.TransactionType = 1;
                            oelCustomerTransaction.TransactionMode = "DR";
                            if (oelSoftwareCheck != null && oelSoftwareCheck.IsMust.Value)
                            {
                                oelCustomerTransaction.Description = BuildRemarks();
                            }
                            else
                            {
                                oelCustomerTransaction.Description = txtDescription.Text;
                            }
                            oelCustomerTransaction.Credit = 0;

                            oelCustomerTransaction.Debit = Math.Round(Validation.GetSafeDecimal(txtTotalAmount.Text));
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
                            if (IdVoucher != null && IdVoucher > 0 && RdCashSale.Checked && CashTransactionId.Value == 0 && CustomerTransactionId.Value > 0)
                            {
                                oelCashTransaction.IdTransactionDetail = CustomerTransactionId.Value;
                                oelCashTransaction.IsNew = false;
                            }
                            //else
                            //{
                            //    oelCashTransaction.IdTransactionDetail = 0;
                            //    oelCashTransaction.IsNew = true;
                            //}
                            oelCashTransaction.IsNetTransaction = RdCashSale.Checked ? true : false;
                            oelCashTransaction.SeqNo = 1;
                            oelCashTransaction.TrackNumber = 1;
                            oelCashTransaction.IdProject = Operations.IdProject;
                            oelCashTransaction.BookNo = Operations.BookNo;
                            oelCashTransaction.IdVoucher = oelVoucher.IdVoucher;
                            oelCashTransaction.AccountNo = CashAccountNo;
                            oelCashTransaction.SubAccountNo = "0";
                            oelCashTransaction.Date = VDate.Value;
                            oelCashTransaction.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
                            oelCashTransaction.VoucherType = "S";
                            oelCashTransaction.TransactionType = 1;
                            oelCashTransaction.TransactionMode = "DR";
                            if (txtDescription.Text != string.Empty)
                            {
                                oelCashTransaction.Description = txtDescription.Text + " " + "-Cash Sale To Party" + " '" + SEditBox.Text + "'";
                            }
                            else
                            {
                                oelCashTransaction.Description = txtDescription.Text == string.Empty ? "Cash Collected By Cash Sale" : txtDescription.Text;
                            }

                            oelCashTransaction.Credit = 0;
                            oelCashTransaction.Debit = Math.Round(Validation.GetSafeDecimal(txtTotalAmount.Text));
                            oelCashTransaction.Posted = chkPosted.Checked;
                            oelCashTransaction.CreatedDateTime = VDate.Value;

                            oelCostOfSalesCollection.Add(oelCashTransaction);
                        }
                        #endregion
                        #region Add Sales Account In Transactions
                        /// Add Sales Account...
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
                        oelSaleTransaction.VoucherType = "S";
                        oelSaleTransaction.TransactionType = 2;
                        oelSaleTransaction.Description = txtDescription.Text;
                        oelSaleTransaction.Debit = 0;
                        oelSaleTransaction.Credit = Math.Round(Validation.GetSafeDecimal(txtTotalAmount.Text));
                        oelSaleTransaction.TransactionMode = "CR";
                        oelSaleTransaction.CreatedDateTime = VDate.Value;
                        oelSaleTransaction.Posted = chkPosted.Checked;

                        oelCostOfSalesCollection.Add(oelSaleTransaction);
                        #endregion region
                        #region Add Accounting Transactions
                        if (chkPosted.Checked)
                        {
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
                                oelVoucherDetail.VoucherType = "S";
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
                        }
                        #endregion
                        #region Saving Code
                        if (IdVoucher == null || IdVoucher == 0)
                        {
                            var manager = new SalesHeadBLL();

                            EntityoperationInfo infoResult = manager.InsertSales(oelVoucher, oelSalesDetailCollection, oelProductsProfitLossCollection, oelCostOfSalesCollection);
                            if (infoResult.IsSuccess)
                            {
                                InvEditBox.Text = infoResult.VoucherNo.ToString();
                                IdVoucher = infoResult.IntID;
                                FillVoucher();
                                if (MessageBox.Show("Sales Recorded Successfully... Do You Want To Print (Y/N)", "Printing Invoice", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    PrintReport();   
                                }
                                VDate.Focus();
                                //ClearControls();
                                //FillData();
                            }
                        }
                        else
                        {
                            var manager = new SalesHeadBLL();
                            EntityoperationInfo infoResult = manager.UpdateSales(oelVoucher, oelSalesDetailCollection, oelProductsProfitLossCollection, oelCostOfSalesCollection);
                            if (infoResult.IsSuccess)
                            {
                                if (MessageBox.Show("Recorded Sales Updated Successfully... Do You Want To Print (Y/N)", "Printing Invoice", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                                {
                                    PrintReport();
                                }
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
                    lblStatuMessage.Text = "Check Values";
                }
            }
            else
            {
                lblStatuMessage.Text = "Incomplete Entry...";
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

            oelInventoryVoucherDetail.Description = "Inventory Credit";
            oelInventoryVoucherDetail.IsNetTransaction = IsNetTransaction;
            oelInventoryVoucherDetail.SeqNo = 0;
            oelInventoryVoucherDetail.TrackNumber = 0;
            oelInventoryVoucherDetail.VoucherType = "S";
            oelInventoryVoucherDetail.AccountNo = Validation.GetSafeString(EachItem[0].InventoryAccount);
            oelInventoryVoucherDetail.Credit = Validation.GetSafeDecimal(manager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) * Quantity; //EachItem[0].AVGEvaluationUnitPrice);

            oelInventoryVoucherDetail.TransactionMode = "CR";
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
            oelCOGSVoucherDetail.IsNetTransaction = IsNetTransaction;
            oelCOGSVoucherDetail.SheetNo = Validation.GetSafeLong(txtSheetNo.Text);


            oelCOGSVoucherDetail.Description = "COGS Debit";


            oelCOGSVoucherDetail.VoucherType = "S";
            oelCOGSVoucherDetail.AccountNo = Validation.GetSafeString(EachItem[0].COGSAccount);
            oelCOGSVoucherDetail.Debit = Validation.GetSafeDecimal(manager.GetItemsAvgValueWOT(EachItem[0].IdItem.Value)) * Quantity;//EachItem[0].AVGEvaluationUnitPrice);
            oelCOGSVoucherDetail.TransactionMode = "DR";
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
                            if (manager.DeleteSalesByVoucher(IdVoucher.Value, Operations.IdProject))
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
                        if (manager.DeleteSalesByVoucher(IdVoucher.Value, Operations.IdProject))
                        {
                            MessageBox.Show("Voucher Deleted Successfully and Transactions Rolled Back");
                            ClearControls();
                        }
                    }
                }
                //PurchaseStockReceiptBLL();
                else if (MessageBox.Show("Are You Sure To Delete ?", "Deleting Voucher", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                {
                    if (manager.DeleteSalesByVoucher(IdVoucher.Value, Operations.IdProject))
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmprintInvoice = new frmReports();
            if (IdVoucher > 0)
            {
                frmprintInvoice.VoucherNo = Validation.GetSafeLong(InvEditBox.Text);
                frmprintInvoice.IsNetTransaction = IsNetTransaction;
                frmprintInvoice.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Invoice To Print....");
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
        private void btnAddPurchasesAccount_Click(object sender, EventArgs e)
        {
            frmaccounts = new frmAccounts();
            frmaccounts.Show();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            FillNaturalAccounts(string.Empty);
        }
        private void btnAddCashAccount_Click(object sender, EventArgs e)
        {
            frmaccounts = new frmAccounts();
            frmaccounts.Show();
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
        private void PrintReport()
        {
            PrintDialog printDialogue = new PrintDialog();
            ReportDocument RptDocument = new ReportDocument();
            TableLogOnInfo oTableLogOnInfo = new TableLogOnInfo();
            if (printDialogue.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string ReportName = Operations.ProjectInvoiceName + ".rpt";
                RptDocument.Load("..//..//Reports/" + ReportName + "");
                RptDocument.PrintOptions.PrinterName = printDialogue.PrinterSettings.PrinterName;
                DbConnectionStringBuilder connectionBuilder = new DbConnectionStringBuilder();
                connectionBuilder.ConnectionString = DBHelper.DataConnection;
                oConnectionInfo.ServerName = connectionBuilder["Data Source"].ToString();
                oConnectionInfo.DatabaseName = connectionBuilder["initial catalog"].ToString();
                oConnectionInfo.UserID = connectionBuilder["user id"].ToString();
                oConnectionInfo.Password = connectionBuilder["password"].ToString();
                //oConnectionInfo.IntegratedSecurity = true;
                oConnectionInfo.Type = ConnectionInfoType.SQL;



                foreach (CrystalDecisions.CrystalReports.Engine.Table oTable in RptDocument.Database.Tables)
                {
                    oTableLogOnInfo = oTable.LogOnInfo;
                    oTableLogOnInfo.ConnectionInfo = oConnectionInfo;
                    oTable.ApplyLogOnInfo(oTableLogOnInfo);
                }

                for (int i = 0; i <= RptDocument.Database.Tables.Count - 1; i++)
                {
                    RptDocument.Database.Tables[i].Location = oConnectionInfo.DatabaseName + "." + "Reports" + "." + RptDocument.Database.Tables[i].Location.Substring(RptDocument.Database.Tables[i].Location.LastIndexOf(".") + 1);
                }

                ParameterFieldDefinitions crParamFieldDefinitions = RptDocument.DataDefinition.ParameterFields;
                foreach (ParameterFieldDefinition def in crParamFieldDefinitions)
                {

                    if (def.ReportName == "")
                    {
                        if (def.ParameterFieldName == "@VoucherNo")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Validation.GetSafeLong(InvEditBox.Text);
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@IdProject")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.IdProject; //"{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@BookNo")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = Operations.BookNo; //"{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                        else if (def.ParameterFieldName == "@IsNetTransaction")
                        {
                            ParameterDiscreteValue crParamDiscreteValue = new ParameterDiscreteValue();
                            ParameterValues crCurrentValues = def.CurrentValues;


                            //string TayloringNumber = VoucherNo;

                            crParamDiscreteValue.Value = IsNetTransaction; //"{" + Operations.IdCompany + "}";
                            crCurrentValues.Add(crParamDiscreteValue);
                            def.ApplyCurrentValues(crCurrentValues);
                        }
                    }
                }
                //PageMargins margins = RptDocument.PrintOptions.PageMargins;
                //margins.bottomMargin = 350;/
                //margins.leftMargin = 350;
                //margins.rightMargin = 350;
                //margins.topMargin = 350;   
                //RptDocument.PrintOptions.ApplyPageMargins(margins);
                //ReportViewer.ReportSource = RptDocument;
                //RptDocument.PrintToPrinter(1, false, 0, 0);
                RptDocument.PrintOptions.PaperOrientation = PaperOrientation.Portrait;
                RptDocument.PrintOptions.PaperSize = PaperSize.PaperA5;
                RptDocument.PrintToPrinter(printDialogue.PrinterSettings.Copies, printDialogue.PrinterSettings.Collate, printDialogue.PrinterSettings.FromPage, printDialogue.PrinterSettings.ToPage);
                //reportViewer1.repo = RptDocument;
                // crystalReportViewer1.ReportSource = RptDocument;
            }
            ClearControls();
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
            frmfindVouchers.VoucherType = VoucherTypes.SaleInvoiceVoucher.ToString();
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
                        if (RdCashSale.Checked)
                        {
                            cbxCashAccounts.Focus();
                            cbxCashAccounts.DroppedDown = true;
                        }
                        else if (RdCreditSales.Checked)
                        {
                            cbxNaturalAccounts.Focus();
                            cbxNaturalAccounts.DroppedDown = true;
                        }
                        //if (grpEmployees.Visible)
                        //{
                        //    EmpEditCode.Focus();
                        //}
                        //else
                        //{
                        //    cbxNaturalAccounts.Focus();
                        //    cbxNaturalAccounts.DroppedDown = true;
                        //}
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
            MetroFramework.Controls.MetroTextBox txt = sender as MetroFramework.Controls.MetroTextBox;
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                if (txt.Name == "EmpEditCode")
                {
                    txtDeliveryPerson.Focus();
                }
            }
            else if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
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
        private void txtDeliveryPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Enter)
            {
                SEditBox.Focus();
                //cbxNaturalAccounts.Focus();
                //cbxNaturalAccounts.DroppedDown = true;
            }
            else if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                if (EventTime == 0)
                {
                    EventCommandName = "DeliveryPerson";
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
        private void VDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                EmpEditCode.Focus();
            }
        }
        private void txtFreigh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
                e.Handled = true;
            else if (e.KeyChar == (char)Keys.Enter)
            {
                txtExtraDiscount.Focus();
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
                decimal Resultant = (ActualAmount + Validation.GetSafeDecimal(txtFreightAmount.Text)) - Validation.GetSafeDecimal(txtExtraDiscount.Text);
                txtTotalAmount.Text = Resultant.ToString();
            }
        }
        private void txtExtraDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                if (txtExtraDiscount.Text != string.Empty)
                {
                    if (Validation.GetSafeDecimal(txtExtraDiscount.Text) > 0 && Validation.GetSafeDecimal(txtTotalAmount.Text) > 0)
                    {
                        decimal ActualAmount = Validation.GetSafeDecimal(txtBillAmount.Text);
                        decimal Resultant = (ActualAmount + Validation.GetSafeDecimal(txtFreightAmount.Text)) - Validation.GetSafeDecimal(txtExtraDiscount.Text);
                        txtTotalAmount.Text = Resultant.ToString();
                    }
                }
            }
        }
        private void RdCashSale_CheckedChanged(object sender, EventArgs e)
        {
            if (RdCashSale.Checked)
            {
                RdCreditSales.Checked = false;
                pnlCash.Visible = true;
                lblCreditDays.Visible = false;
                txtCreditDays.Visible = false;
            }
        }
        private void RdCreditSales_CheckedChanged(object sender, EventArgs e)
        {
            if (RdCreditSales.Checked)
            {
                RdCashSale.Checked = false;
                pnlCash.Visible = false;
                lblCreditDays.Visible = true;
                txtCreditDays.Visible = true;
            }
        }
        #endregion
        #region Custom Controls Methods And Events
        private void InvEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (InvEditBox.Text != string.Empty)
                {
                    FillVoucherByNumber();
                }
            }
        }
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
                //var salesManager = new SalesHeadBLL().GetCustomersSalesUnpostedVouchers(Operations.IdProject, Operations.BookNo, oelAccount.AccountNo);
                //if (salesManager.Count == 0)
                //{
                SEditBox.Text = oelAccount.AccountName;
                CustomerAccountNo = oelAccount.AccountNo;
                FillCustomer(oelAccount.AccountNo);
                list = CommonFunctions.GetUnPostedClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, oelAccount.AccountNo);//CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, oelAccount.AccountNo);
                if (list.Count > 0)
                {
                    txtCurrentBalance.Text = list[0].TypedClosingBalance;
                }
                //}
                //else
                //{
                //    MessageBox.Show("Customer " + oelAccount.AccountName + " may have one or more unposted Vouchers, Please Post These Vouchers First Then Select ...");
                //}
            }
            else if (EventCommandName == "Employees")
            {
                EmpEditCode.Text = oelAccount.AccountName;
                EmpAccountNo = oelAccount.AccountNo;
                FillEmployees(oelAccount.AccountNo);
            }
            else if (EventCommandName == "DeliveryPerson")
            {
                EmpDeliveryAccountNo = oelAccount.AccountNo;
                txtDeliveryPerson.Text = oelAccount.AccountName;
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
                //for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                //{
                //    if (DgvStockSales.Rows[i].Cells["colIdItem"].Value != null)
                //    {
                //        if (oelItems.IdItem == Validation.GetSafeLong(DgvStockSales.Rows[i].Cells["colIdItem"].Value))
                //        {
                //            MessageBox.Show("Product Already exists");
                //            return;
                //        }
                //    }
                //}
                lblStatuMessage.Text = "";
                DgvStockSales.CurrentRow.Cells["colIdItem"].Value = oelItems.IdItem;
                DgvStockSales.CurrentRow.Cells["colItemName"].Value = oelItems.ItemName;
                DgvStockSales.CurrentRow.Cells["colpacking"].Value = oelItems.PackingSize;
                DgvStockSales.CurrentRow.Cells["colCurrentStock"].Value = manager.GetItemClosingStock(Validation.GetSafeLong(DgvStockSales.CurrentRow.Cells["colIdItem"].Value));
                //DgvStockReceipt.CurrentRow.Cells["ColBatch"].Value = oelItems.BatchNo;
            }
        }
        void frmfindVouchers_ExecuteFindVouchersEvent(VouchersEL oelVoucher)
        {
            VoucherNo = oelVoucher.VoucherNo;
            IdVoucher = oelVoucher.IdVoucher;
            InvEditBox.Text = oelVoucher.VoucherNo.ToString();
            InvEditBox.Enabled = false;
            FillVoucher();

        }
        #endregion
        #region Tabs Related Events And Methods
        private void tabSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            CreateAndInitializeFooterRow();
        }
        #endregion
        #region Stock Grid Events
        private void DgvStockSales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.End)
            {
                btnSave_Click(sender, e);
            }
        } 
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
                else if (e.KeyChar == (char)Keys.End)
                {
                    btnSave_Click(sender, e);
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
            if (e.ColumnIndex == 24)
            {
                e.Value = "Delete";
            }
        }
        private void DgvStockSales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            decimal lineAmount, value = 0;
            if (e.ColumnIndex == 24)
            {
                if (DgvStockSales.Rows[e.RowIndex].Cells["ColIdVoucherDetail"].Value == null)
                {
                    if (DgvStockSales.Rows.Count > 1)
                    {
                        DataGridViewRow oRow = DgvStockSales.Rows[e.RowIndex];
                        DgvStockSales.Rows.Remove(oRow);
                    }
                    DataGridViewCell oCell = DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"];
                    for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                    {
                        value += Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colNetAmount"].Value);
                    }
                    //lineAmount = Validation.GetSafeDecimal(oCell.GetEditedFormattedValue(e.RowIndex, DataGridViewDataErrorContexts.Commit));
                    //txtCreditBalance.Text = (Validation.GetSafeDecimal(txtCreditBalance.Text) - lineAmount).ToString();
                    txtBillAmount.Text = value.ToString();
                    txtTotalAmount.Text = Validation.GetSafeString((Validation.GetSafeDecimal(txtBillAmount.Text) + Validation.GetSafeDecimal(txtFreightAmount.Text)) - Validation
                        .GetSafeDecimal(txtExtraDiscount.Text));
                    if (DgvStockSales.Rows.Count - 1 == 0)
                    {
                        txtBillAmount.Text = string.Empty;
                        txtFreightAmount.Text = string.Empty;
                        txtTotalAmount.Text = string.Empty;
                        txtExtraDiscount.Text = string.Empty;
                        txtTotalDiscount.Text = string.Empty;
                    }
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
                        lineAmount = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value);
                        txtBillAmount.Text = (Validation.GetSafeDecimal(txtBillAmount.Text) - lineAmount).ToString();
                        txtTotalAmount.Text = (Validation.GetSafeDecimal(txtTotalAmount.Text) - lineAmount).ToString();

                        if (Manager.DeleteChildRecords(Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["ColIdVoucherDetail"].Value), VoucherTypes.SaleInvoiceVoucher.ToString()))
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
            decimal DiscTotalAmount = 0,SameQuantity = 0;
            if (DgvStockSales.Columns[e.ColumnIndex].Name == "colQty")
            {
                var manager = new ItemsBLL();
                decimal ClosingStock = manager.GetItemClosingStock(Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value));
                if (IdVoucher == 0 || IdVoucher == null)
                {
                    if (ClosingStock > 0)
                    {
                        for (int i = 0; i < DgvStockSales.Rows.Count-1; i++)
                        {
                            if (Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value) == Validation.GetSafeLong(DgvStockSales.Rows[i].Cells["colIdItem"].Value))
                            {
                                SameQuantity += Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colQty"].Value);
                            }
                        }
                        //if (ClosingStock > Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value) || ClosingStock == Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value))
                        if (ClosingStock > SameQuantity || ClosingStock == SameQuantity)
                        {
                            /// Allow Input
                            DgvStockSales.Rows[e.RowIndex].Cells["colUnitPrice"].Value = manager.GetItemById(Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value))[0].MRP;
                            if (Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) > 0)
                            {
                                DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colUnitPrice"].Value) * Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value);
                            }
                            else
                            {
                                DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value = 0;
                            }
                            if (DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value != null && Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value.ToString().Replace('%', ' ')) > 0)
                            {
                                string CellValue = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value);
                                if (CellValue.Contains('%'))
                                {
                                    CellValue = CellValue.Substring(0, CellValue.Length - 1);
                                }
                                if (Validation.GetSafeLong(CellValue) > 0)
                                {
                                    DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) - ((Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) / 100)
                                                                                                  * Validation.GetSafeDecimal(CellValue)));

                                }
                                else
                                {
                                    DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);

                                }
                            }
                            else
                            {
                                DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value = 0 + "%";
                                DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);
                            }
                            if (DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value != null && Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value.ToString().Replace('%', ' ')) > 0)
                            {
                                string CellValue = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value);
                                if (CellValue.Contains('%'))
                                {
                                    CellValue = CellValue.Substring(0, CellValue.Length - 1);
                                }
                                if (Validation.GetSafeLong(CellValue) > 0)
                                {
                                    DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) - ((Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) / 100)
                                                                                                  * Validation.GetSafeDecimal(CellValue)));

                                }
                                else
                                {
                                    DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);

                                }
                            }
                            else
                            {
                                DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value = 0 + "%";
                                DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                            }
                            for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                            {
                                OldValue += Convert.ToDecimal(DgvStockSales.Rows[i].Cells["colNetAmount"].Value);
                                DiscTotalAmount += (Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value) - Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscountAmount"].Value));
                            }
                            txtBillAmount.Text = OldValue.ToString();
                            txtTotalAmount.Text = Validation.GetSafeString((OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text)) - Validation.GetSafeDecimal(txtExtraDiscount.Text));
                            txtTotalDiscount.Text = DiscTotalAmount.ToString();
                            OldValue = 0;
                        }
                        else
                        {
                            MessageBox.Show("Closing Stock Is Less Than Issue Quantity for this Product which is '" + ClosingStock + "'....");
                            DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value = "";
                            return;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Quantity Not Available for this Product....");
                        DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value = "";
                        return;
                    }
                }
                else
                {
                    var SManager = new SalesDetailBLL();
                    decimal UnpostedQuantity = SManager.GetItemUnPostedSoldQuantity(IdVoucher.Value, Operations.IdProject, Operations.BookNo, Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value));
                    for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                    {
                        if (Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value) == Validation.GetSafeLong(DgvStockSales.Rows[i].Cells["colIdItem"].Value))
                        {
                            SameQuantity += Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colQty"].Value);
                        }
                    }
                    //if (UnpostedQuantity + ClosingStock >= Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value))
                    if (UnpostedQuantity + ClosingStock >= SameQuantity)
                    {
                        // Take No Action Please....
                    }
                    else
                    {
                        MessageBox.Show("Closing Stock Is Less Than Issue Quantity for this Product which is '" + (ClosingStock + UnpostedQuantity) + "'....");
                        DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value = "";
                        return;
                    }
                    DgvStockSales.Rows[e.RowIndex].Cells["colUnitPrice"].Value = manager.GetItemById(Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value))[0].MRP;
                }
            }
            else if (DgvStockSales.Columns[e.ColumnIndex].Name == "colUnitPrice")
            {
                DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeLong(DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value) *
                                                                            Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
            }
            else if (DgvStockSales.Columns[e.ColumnIndex].Name == "colDiscount")
            {
                if (DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value != null)
                {
                    string CellValue = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value);
                    if (CellValue.Contains('%'))
                    {
                        CellValue = CellValue.Substring(0, CellValue.Length - 1);
                    }
                    if (Validation.GetSafeDecimal(CellValue) > 0)
                    {
                        DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) - (Validation.GetSafeDecimal(CellValue) * (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) / 100)));
                        if (DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value == null)
                        {
                            DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                        }
                        else
                        {
                            if (DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value != null)
                            {
                                string PromoCellValue = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value);
                                if (PromoCellValue.Contains('%'))
                                {
                                    PromoCellValue = PromoCellValue.Substring(0, PromoCellValue.Length - 1);
                                }
                                if (Validation.GetSafeDecimal(CellValue) > 0)
                                {
                                    DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) - ((Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) / 100)
                                                                                                * Validation.GetSafeDecimal(PromoCellValue)));

                                }
                                else
                                {
                                    DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                                }
                            }
                            else
                            {
                                DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                            }    
                        }
                    }
                    else
                    {
                        DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);
                        if (DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value == null)
                        {
                            DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                        }
                        if (DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value != null)
                        {
                            string PromoCellValue = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value);
                            if (PromoCellValue.Contains('%'))
                            {
                                PromoCellValue = PromoCellValue.Substring(0, PromoCellValue.Length - 1);
                            }
                            if (Validation.GetSafeDecimal(PromoCellValue) > 0)
                            {
                                DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) - ((Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) / 100)
                                                                                            * Validation.GetSafeDecimal(PromoCellValue)));

                            }
                            else
                            {
                                DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                            }
                        }
                        else
                        {
                            DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                        }
                    }
                }
                else
                {
                    DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);
                    if (DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value == null)
                    {
                        DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                    }
                }                
                for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvStockSales.Rows[i].Cells["colNetAmount"].Value);
                    DiscTotalAmount += (Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value) - Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscountAmount"].Value));
                }
                txtBillAmount.Text = OldValue.ToString();
                txtTotalAmount.Text = Validation.GetSafeString((OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text)) - Validation.GetSafeDecimal(txtExtraDiscount.Text));
                txtTotalDiscount.Text = DiscTotalAmount.ToString();
                OldValue = 0;
            }
            else if (DgvStockSales.Columns[e.ColumnIndex].Name == "colPromoDisc")
            {
                if (DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value != null)
                {
                    string CellValue = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value);
                    if (CellValue.Contains('%'))
                    {
                        CellValue = CellValue.Substring(0, CellValue.Length - 1);
                    }
                    if (Validation.GetSafeDecimal(CellValue) > 0)
                    {
                        DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) - ((Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) / 100) 
                                                                                    * Validation.GetSafeDecimal(CellValue)));

                    }
                    else
                    {
                        DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                    }
                }
                else
                {
                    DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                }
                for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvStockSales.Rows[i].Cells["colNetAmount"].Value);
                    DiscTotalAmount += (Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value) - Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscountAmount"].Value));
                }
                txtBillAmount.Text = OldValue.ToString();
                txtTotalAmount.Text = Validation.GetSafeString((OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text)) - Validation.GetSafeDecimal(txtExtraDiscount.Text));
                txtTotalDiscount.Text = DiscTotalAmount.ToString();
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
            decimal DiscTotalAmount = 0;
            if (DgvStockSales.Columns[e.ColumnIndex].Name == "colUnitPrice")
            {
                DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colQty"].Value) * Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
                if (DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value != null)
                {                    
                    if (DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value != null && Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value.ToString().Replace('%', ' ')) > 0)
                    {
                        string CellValue = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value);
                        if (CellValue.Contains('%'))
                        {
                            CellValue = CellValue.Substring(0, CellValue.Length - 1);
                        }
                        if (Validation.GetSafeLong(CellValue) > 0)
                        {
                            DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) - ((Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) / 100)
                                                                                          * Validation.GetSafeDecimal(CellValue)));

                        }
                        else
                        {
                            DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);

                        }
                    }
                    else
                    {
                        DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value = 0 + "%";
                        DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);
                    }
                }
                if (DgvStockSales.Rows[e.RowIndex].Cells["colIdItem"].Value != null)
                {                    
                    if (DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value != null && Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value.ToString().Replace('%', ' ')) > 0)
                    {
                        string CellValue = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value);
                        if (CellValue.Contains('%'))
                        {
                            CellValue = CellValue.Substring(0, CellValue.Length - 1);
                        }
                        if (Validation.GetSafeLong(CellValue) > 0)
                        {
                            DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) - ((Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value) / 100)
                                                                                          * Validation.GetSafeDecimal(CellValue)));

                        }
                        else
                        {
                            DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);

                        }
                    }
                    else
                    {
                        DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value = 0 + "%";
                        DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                    }
                }
                for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvStockSales.Rows[i].Cells["colNetAmount"].Value);
                    DiscTotalAmount += (Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value) - Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscountAmount"].Value));
                }
                txtBillAmount.Text = OldValue.ToString();
                txtTotalAmount.Text = Validation.GetSafeString((OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text)) - Validation.GetSafeDecimal(txtExtraDiscount.Text));
                txtTotalDiscount.Text = DiscTotalAmount.ToString();
                OldValue = 0;
            }
            else if (DgvStockSales.Columns[e.ColumnIndex].Name == "colDiscount")
            {
                if (DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value != null && Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value.ToString().Replace('%',' ')) > 0)
                {
                    //DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) / 100)
                    //                                                                   * Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"]);
                    if (DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value.ToString().Contains('%'))
                    { 
                    
                    }
                    else
                    DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value) + "%";
                }
                else
                {
                    DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value = "0" + "%";
                    //DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value = "0" + "%";
                    DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);
                }                
                for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvStockSales.Rows[i].Cells["colNetAmount"].Value);
                    DiscTotalAmount += (Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value) - Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscountAmount"].Value));
                }
                txtBillAmount.Text = OldValue.ToString();
                txtTotalAmount.Text = Validation.GetSafeString((OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text)) - Validation.GetSafeDecimal(txtExtraDiscount.Text));
                
                txtTotalDiscount.Text = DiscTotalAmount.ToString();
                OldValue = 0;
            }
            else if (DgvStockSales.Columns[e.ColumnIndex].Name == "colPromoDisc")
            {
                if (DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value != null && Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value.ToString().Replace('%', ' ')) > 0)
                {
                    //DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = (Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value) / 100)
                    //                                                                   * Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"]);
                    if (DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value.ToString().Contains('%'))
                    {

                    }
                    else
                        DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value = Validation.GetSafeString(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value) + "%";
                }
                else
                {
                    DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value = "0" + "%";
                    DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value);
                }
                for (int i = 0; i < DgvStockSales.Rows.Count - 1; i++)
                {
                    OldValue += Convert.ToDecimal(DgvStockSales.Rows[i].Cells["colNetAmount"].Value);
                    DiscTotalAmount += (Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colAmount"].Value) - Validation.GetSafeDecimal(DgvStockSales.Rows[i].Cells["colDiscountAmount"].Value));
                }
                txtBillAmount.Text = OldValue.ToString();
                txtTotalAmount.Text = Validation.GetSafeString((OldValue + Validation.GetSafeDecimal(txtFreightAmount.Text)) - Validation.GetSafeDecimal(txtExtraDiscount.Text));

                txtTotalDiscount.Text = DiscTotalAmount.ToString();
                OldValue = 0;
            }
            else if (DgvStockSales.Columns[e.ColumnIndex].Name == "colAmount")
            {
                if (DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value != null && Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value.ToString().Replace('%', ' ')) > 0)
                {

                }
                else
                {
                    DgvStockSales.Rows[e.RowIndex].Cells["colDiscount"].Value = 0 + "%";
                    DgvStockSales.Rows[e.RowIndex].Cells["colDiscountAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);
                }
                if (DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value != null && Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value.ToString().Replace('%', ' ')) > 0)
                {

                }
                else
                {
                    DgvStockSales.Rows[e.RowIndex].Cells["colPromoDisc"].Value = 0 + "%";
                    DgvStockSales.Rows[e.RowIndex].Cells["colNetAmount"].Value = Validation.GetSafeDecimal(DgvStockSales.Rows[e.RowIndex].Cells["colAmount"].Value);
                }
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
                if (e.ColumnIndex == 12)
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
            List<VoucherDetailEL> ListSales = SManager.GetDistributionSalesTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo);
            if (ListSales.Count > 0)
            {
                IdVoucher = ListSales[0].IdVoucher;
                InvEditBox.Text = Validation.GetSafeString(ListSales[0].VoucherNo);
                txtSheetNo.Text = Validation.GetSafeString(ListSales[0].SheetNo);
                txtBiltyNo.Text = ListSales[0].BiltyNo;
                txtCreditDays.Text = Validation.GetSafeString(ListSales[0].Transactiondays);
                txtGatePass.Text = ListSales[0].OutWardGatePassNo;
                VDate.Value = ListSales[0].VDate.Value;
                if (ListSales[0].DueDate.Value.ToString() != "1/1/0001 12:00:00 AM")
                dueDate.Value = ListSales[0].DueDate.Value;
                txtDescription.Text = ListSales[0].VDiscription;
                txtCurrentBalance.Text = ListSales[0].ClosingBalance.ToString();
                txtBillAmount.Text = Validation.GetSafeString(ListSales[0].BillAmount);
                txtFreightAmount.Text = Validation.GetSafeString(ListSales[0].TotalFreight);
                txtExtraDiscount.Text = Validation.GetSafeString(ListSales[0].ExtraDiscount);
                txtTotalAmount.Text = Validation.GetSafeString(ListSales[0].TotalAmount);
                IsNetTransaction = ListSales[0].IsNetTransaction.Value;
                if (ListSales[0].IsNetTransaction.Value)
                {
                    RdCashSale.Checked = true;
                    RdCreditSales.Checked = false;
                    pnlCash.Visible = true;
                    FillCashAccounts(ListSales[0].CashAccountNo);
                    FillCustomerParty(ListSales[0].AccountNo);
                }
                else
                {
                    RdCashSale.Checked = false;
                    RdCreditSales.Checked = true;
                    pnlCash.Visible = false;
                    if(ListSales[0].CashAccountNo != string.Empty)
                    FillCashAccounts(ListSales[0].CashAccountNo);
                }
                EmpAccountNo = ListSales[0].SubAccountNo;
                FillEmployees(EmpAccountNo);
                CustomerAccountNo = ListSales[0].AccountNo;
                EmpDeliveryAccountNo = ListSales[0].EmployeeAccountNo;
                FillDeliveryPerson(EmpDeliveryAccountNo);
                if (ListSales[0].BillAmount == 0)
                {
                    txtBillAmount.Text = txtTotalAmount.Text;
                }
                if (!IsNetTransaction)
                {
                    FillCustomer(ListSales[0].AccountNo);
                }
                else
                {
                    //txtSupplierName.Text = ListSales[0].FirstName;
                    //txtSupplierContact.Text = ListSales[0].Contact;
                    //txtSupplerCNIC.Text = ListSales[0].Cnic;
                    //txtSupplierAddress.Text = ListSales[0].Address;
                }
                chkPosted.Checked = ListSales[0].Posted.Value;
                if (ListSales[0].Posted.Value)
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
                HandleVoucher(ListSales);
                FillSales(ListSales);
            #endregion
            #region Filling Transactional Data
                List<VoucherDetailEL> listTransactions = SManager.GetDistributionSalesSubTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo);

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
        private void FillVoucherByNumber()
        {
            #region Variables
            var Manager = new VoucherBLL();
            var SManager = new SalesHeadBLL();
            VoucherType = "P";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            #endregion
            #region Filling Sales Header And Detail
            //List<VouchersEL> list = Manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(VEditBox.Text));
            List<VoucherDetailEL> ListSales = SManager.GetDistributionSalesTransactionsByNumber(Validation.GetSafeLong(InvEditBox.Text), Operations.IdProject, Operations.BookNo);
            if (ListSales.Count > 0)
            {
                IdVoucher = ListSales[0].IdVoucher;
                InvEditBox.Text = Validation.GetSafeString(ListSales[0].VoucherNo);
                txtSheetNo.Text = Validation.GetSafeString(ListSales[0].SheetNo);
                txtBiltyNo.Text = ListSales[0].BiltyNo;
                txtCreditDays.Text = Validation.GetSafeString(ListSales[0].Transactiondays);
                txtGatePass.Text = ListSales[0].OutWardGatePassNo;
                VDate.Value = ListSales[0].VDate.Value;
                if(ListSales[0].DueDate.Value.ToString() != "1/1/0001 12:00:00 AM")
                dueDate.Value = ListSales[0].DueDate.Value;
                txtDescription.Text = ListSales[0].VDiscription;
                txtCurrentBalance.Text = ListSales[0].ClosingBalance.ToString();
                txtBillAmount.Text = Validation.GetSafeString(ListSales[0].BillAmount);
                txtFreightAmount.Text = Validation.GetSafeString(ListSales[0].TotalFreight);
                txtExtraDiscount.Text = Validation.GetSafeString(ListSales[0].ExtraDiscount);
                txtTotalAmount.Text = Validation.GetSafeString(ListSales[0].TotalAmount);
                IsNetTransaction = ListSales[0].IsNetTransaction.Value;
                if (ListSales[0].IsNetTransaction.Value)
                {
                    RdCashSale.Checked = true;
                    RdCreditSales.Checked = false;
                    pnlCash.Visible = true;
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
                }
                EmpAccountNo = ListSales[0].SubAccountNo;
                FillEmployees(EmpAccountNo);
                CustomerAccountNo = ListSales[0].AccountNo;
                EmpDeliveryAccountNo = ListSales[0].EmployeeAccountNo;
                FillDeliveryPerson(EmpDeliveryAccountNo);
                if (ListSales[0].BillAmount == 0)
                {
                    txtBillAmount.Text = txtTotalAmount.Text;
                }
                if (!IsNetTransaction)
                {
                    FillCustomer(ListSales[0].AccountNo);
                }
                else
                {
                    //txtSupplierName.Text = ListSales[0].FirstName;
                    //txtSupplierContact.Text = ListSales[0].Contact;
                    //txtSupplerCNIC.Text = ListSales[0].Cnic;
                    //txtSupplierAddress.Text = ListSales[0].Address;
                }
                chkPosted.Checked = ListSales[0].Posted.Value;
                if (ListSales[0].Posted.Value)
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
                HandleVoucher(ListSales);
                FillSales(ListSales);
            #endregion
            #region Filling Transactional Data
                List<VoucherDetailEL> listTransactions = SManager.GetDistributionSalesSubTransactions(IdVoucher.Value, Operations.IdProject, Operations.BookNo);

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

                    DgvStockSales.Rows[i].Cells[15].Value = CommonFunctions.RemoveTrailingZeros(List[i].CurrentStock);
                    DgvStockSales.Rows[i].Cells[16].Value = CommonFunctions.RemoveTrailingZeros(List[i].Units);
                    DgvStockSales.Rows[i].Cells[17].Value = CommonFunctions.RemoveTrailingZeros(List[i].Bonus);
                    DgvStockSales.Rows[i].Cells[18].Value = List[i].UnitPrice;
                    DgvStockSales.Rows[i].Cells[19].Value = List[i].Amount;
                    DgvStockSales.Rows[i].Cells[20].Value = List[i].Discount.ToString() + "%";
                    DgvStockSales.Rows[i].Cells[21].Value = List[i].DiscountAmount;
                    DgvStockSales.Rows[i].Cells[22].Value = List[i].PromoDiscount.ToString() + "%";
                    DgvStockSales.Rows[i].Cells[23].Value = List[i].NetSaleAmount;
                }
                txtTotalDiscount.Text = (List.Sum(x => x.Amount) - List.Sum(x => x.DiscountAmount)).ToString();
            }
        }
        private void FillHeadTransactions(List<VoucherDetailEL> List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].TrackNumber == 1)
                {
                    if (RdCreditSales.Checked) //!IsNetTransaction)
                    {
                        CustomerTransactionId = List[i].IdTransactionDetail;
                        CashTransactionId = 0;
                        FillCustomer(List[i].AccountNo);
                        if(SEditBox.Text == string.Empty)
                            SEditBox.Text = List[i].AccountName;
                        CustomerAccountNo = List[i].AccountNo;
                        if (IdVoucher.Value > 0 && Validation.GetSafeDecimal(txtCurrentBalance.Text) > 0)
                        {
                            /// Do Nothing Here....
                        }
                        else
                        {
                            List<TransactionsEL> listClosingBalance = CommonFunctions.GetClosingBalanceByAccount(Operations.IdProject, Operations.BookNo, List[i].AccountNo);
                            if (listClosingBalance.Count > 0)
                                txtCurrentBalance.Text = listClosingBalance[0].TypedClosingBalance.ToString();
                            else
                                txtCurrentBalance.Text = "0";
                        }
                    }
                    else
                    {
                        CustomerTransactionId = 0;
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
