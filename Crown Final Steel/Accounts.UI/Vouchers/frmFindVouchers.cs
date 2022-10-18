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
    public partial class frmFindVouchers : MetroForm
    {
        #region Variables
        VouchersEL elVoucher = null;
        public delegate void VouchersDelegate(VouchersEL oelVoucher);
        public event VouchersDelegate ExecuteFindVouchersEvent;
        frmFindAccounts frmAccount;
        string AccountNo = string.Empty;
        public string VoucherType
        {
            get;
            set;
        }
        public bool? IsNetTransaction { get; set; }
        public int StoreType { get; set; }
        public string SoftwareType { get; set; }
        #endregion
        #region Form Methods And Events
        public frmFindVouchers()
        {
            InitializeComponent();
        }
        private void frmVouchers_Load(object sender, EventArgs e)
        {
            string seperatedName = "";
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DgvVoucher.AutoGenerateColumns = false;
            CreateVoucherWiseColumns();
            if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
            {
                seperatedName = "Search Bank Payment Vouchers";
                BindVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            else if (VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
            {
                seperatedName = "Search Bank Receipt Vouchers";
                BindVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            else if (VoucherType == VoucherTypes.PaymentVoucher.ToString())
            {
                seperatedName = "Search Cash Payment Vouchers";
                BindVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            else if (VoucherType == VoucherTypes.CashReceiptVoucher.ToString())
            {
                seperatedName = "Search Cash Receipt Vouchers";
                BindVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            else if (VoucherType == VoucherTypes.JournalVoucher.ToString())
            {
                seperatedName = "Search Journal Vouchers";
                BindVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            else if (VoucherType == VoucherTypes.StockReceiptVoucher.ToString())
            {
                seperatedName = "Search Stock Purchases Vouchers";
                BindStockVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            else if (VoucherType == VoucherTypes.StockReturnVoucher.ToString())
            {
                seperatedName = "Search Stock Purchases Return Vouchers";
                BindStockVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            else if (VoucherType == VoucherTypes.SaleInvoiceVoucher.ToString())
            {
                seperatedName = "Search Sales / Invoice  Vouchers";
                BindStockVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            else if (VoucherType == VoucherTypes.SalesReturnVoucher.ToString())
            {
                seperatedName = "Search Sales Return Vouchers";
                BindStockVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            else if (VoucherType == VoucherTypes.GeneralMaterialStoreIssuance.ToString())
            {
                seperatedName = "Search Store Issuance / Recieving Vouchers";
                BindStockVouchersByDate(Convert.ToDateTime(DateTime.Now.ToShortDateString()));
            }
            this.Text = seperatedName;            
        }
        private void frmVouchers_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (elVoucher != null)
            {
                ExecuteFindVouchersEvent(elVoucher);
            }
        }
        private void CreateVoucherWiseColumns()
        {
            DataGridViewTextBoxColumn colIdVoucher = new DataGridViewTextBoxColumn();
            colIdVoucher.HeaderText = "IdVoucher";
            colIdVoucher.Name = "colIdVoucher";
            colIdVoucher.Width = 80;
            colIdVoucher.DataPropertyName = "IdVoucher";
            colIdVoucher.Visible = false;
            this.DgvVoucher.Columns.Add(colIdVoucher);

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            colDate.HeaderText = "Date";
            colDate.Name = "colDate";
            colDate.DefaultCellStyle.Format = "d";
            colDate.Width = 90;
            colDate.DataPropertyName = "VDate";
            this.DgvVoucher.Columns.Add(colDate);

            DataGridViewTextBoxColumn colVoucherNo = new DataGridViewTextBoxColumn();
            colVoucherNo.HeaderText = "Voucher #";
            colVoucherNo.Name = "colVoucherNo";
            colVoucherNo.Width = 80;
            colVoucherNo.DataPropertyName = "VoucherNo";
            this.DgvVoucher.Columns.Add(colVoucherNo);            

            DataGridViewTextBoxColumn colTerminalNo = new DataGridViewTextBoxColumn();
            colTerminalNo.HeaderText = "Terminal #";
            colTerminalNo.Name = "colTerminalNo";
            colTerminalNo.Width = 65;
            colTerminalNo.DataPropertyName = "TerminalNumber";
            this.DgvVoucher.Columns.Add(colTerminalNo);

            DataGridViewTextBoxColumn colUserName = new DataGridViewTextBoxColumn();
            colUserName.HeaderText = "User";
            colUserName.Name = "colUserName";
            colUserName.Width = 100;
            colUserName.DataPropertyName = "UserName";
            this.DgvVoucher.Columns.Add(colUserName);

            DataGridViewTextBoxColumn colProjectName = new DataGridViewTextBoxColumn();
            colProjectName.HeaderText = "Project";
            colProjectName.Name = "colProjectName";
            colProjectName.Width = 180;
            colProjectName.DataPropertyName = "ProjectName";
            this.DgvVoucher.Columns.Add(colProjectName);

            //DataGridViewTextBoxColumn colVoucherType = new DataGridViewTextBoxColumn();
            //colVoucherType.HeaderText = "VoucherType";
            //colVoucherType.Name = "colVoucherType";
            //colVoucherType.DataPropertyName = "VoucherType";
            //this.DgvVoucher.Columns.Add(colVoucherType);

            DataGridViewTextBoxColumn colHead = new DataGridViewTextBoxColumn();
            if (VoucherType == "StockReceiptVoucher")
            {
                //colHead.HeaderText = "Supplier";
                colHead.DataPropertyName = "AccountNo";
            }
            //else if (VoucherType == "PaymentVoucher")
            //{
            //    //colHead.HeaderText = "Account";
            //    colHead.DataPropertyName = "AccountNo";
            //}
            //else if (VoucherType == "CashReceiptVoucher")
            //{
            //    //colHead.HeaderText = "Head";
            //    colHead.DataPropertyName = "AccountNo";
            //}
            else if (VoucherType == "SaleInvoiceVoucher")
            {
                //colHead.HeaderText = "Head";
                colHead.DataPropertyName = "AccountNo";

            }
            else if (VoucherType == "SalesReturnVoucher")
            {
                colHead.HeaderText = "Head";
                colHead.DataPropertyName = "AccountNo";
            }
            //else if (VoucherType == "BankPaymentVoucher")
            //{
            //    colHead.DataPropertyName = "AccountNo";
            //}
            //else if (VoucherType == "BankReceiptVoucher")
            //{
            //    colHead.DataPropertyName = "AccountNo";
            //}
            else if (VoucherType == "PrescriberSampleVoucher")
            {
                colHead.DataPropertyName = "AccountNo";
            }
            colHead.HeaderText = "Head A/C";
            colHead.Name = "HeadAC";
            //this.DgvVoucher.Columns.Add(colHead);

            DataGridViewTextBoxColumn colHeadName = new DataGridViewTextBoxColumn();
            colHeadName.DataPropertyName = "AccountName";
            colHeadName.HeaderText = "Account Name";
            colHeadName.Name = "HeadName";
            colHeadName.Width = 150;
            this.DgvVoucher.Columns.Add(colHeadName);

            DataGridViewTextBoxColumn colAddress = new DataGridViewTextBoxColumn();
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Addresss";
            colAddress.Name = "colAddress";
            colAddress.Width = 150;
            this.DgvVoucher.Columns.Add(colAddress);


            DataGridViewTextBoxColumn colBill = new DataGridViewTextBoxColumn();
            if (VoucherType == "CashReceiptVoucher")
            {
                colBill.HeaderText = "Bill. #";
            }
            else
            {
                colBill.HeaderText = "Invoce. #";
            }

            colBill.Name = "colBill";
            colBill.Width = 50;
            colBill.DataPropertyName = "BillNo";
            //this.DgvVoucher.Columns.Add(colBill);
            if (VoucherType == "PaymentVoucher" || VoucherType == "CashReceiptVoucher" || VoucherType == "SaleInvoiceVoucher" || VoucherType == "BankPaymentVoucher" || VoucherType == "BankReceiptVoucher" || VoucherType == "PrescriberSampleVoucher" || VoucherType == "JournalVoucher")
            {
                colBill.Visible = false;
            }
            else
            {
                colBill.Visible = true;
            }


            DataGridViewTextBoxColumn colAmount = new DataGridViewTextBoxColumn();
            colAmount.HeaderText = "Amount";
            colAmount.Name = "colAmount";
            colAmount.DataPropertyName = "Amount";
            colAmount.Width = 75;
            this.DgvVoucher.Columns.Add(colAmount);

            DataGridViewCheckBoxColumn colPosted = new DataGridViewCheckBoxColumn();
            colPosted.HeaderText = "Posted";
            colPosted.Name = "colPosted";
            colPosted.DataPropertyName = "Posted";
            colPosted.Width = 75;
            this.DgvVoucher.Columns.Add(colPosted);

            DataGridViewCheckBoxColumn colStatus = new DataGridViewCheckBoxColumn();
            colStatus.HeaderText = "Deleted";
            colStatus.Name = "colStatus";
            colStatus.ReadOnly = true;
            colStatus.DataPropertyName = "IsDeleted";
            colStatus.Width = 75;
            this.DgvVoucher.Columns.Add(colStatus);
        }
        #endregion
        #region FinancialVouchers
        private void BindVouchersByDate(DateTime VoucherDate)
        {
            var manager = new VoucherBLL();
            List<VouchersEL> list = manager.GetAllTransactionalVoucherByTypeAndDate(Operations.IdProject, Operations.BookNo, VoucherType, VoucherDate);
            DgvVoucher.DataSource = list;
        }
        private void BindVouchersByEditedDate(DateTime VoucherDate)
        {
            var manager = new VoucherBLL();
            List<VouchersEL> list = manager.GetAllTransactionalVoucherByTypeAndEditedDate(Operations.IdProject, Operations.BookNo, VoucherType, VoucherDate);
            DgvVoucher.DataSource = list;
        }
        private void BindVouchersByVoucherNo()
        {
            var manager = new VoucherBLL();
            if (txtVoucherNo.Text != string.Empty)
            {
                List<VouchersEL> list = manager.GetVouchersByTypeAndVoucherNumber(Operations.IdCompany, VoucherType, Convert.ToInt64(txtVoucherNo.Text));
                DgvVoucher.DataSource = list;
            }
            else
            {
                MessageBox.Show("Voucher Number Is Missing In Field...");
            }
        }
        private void BindVouchersByAccountNo()
        {
            var manager = new VoucherBLL();
            if (AcEditBox.Text != string.Empty)
            {
                List<VouchersEL> list = manager.GetAllTransactionalVoucherByTypeAndAccountNo(Operations.IdProject, Operations.BookNo, AccountNo, VoucherType);
                DgvVoucher.DataSource = list;
            }
            else
            {
                MessageBox.Show("Account Number Is Missing In Field...");
            }
        }
        private void BindAllVouchersByType()
        {
            var manager = new VoucherBLL();

            List<VouchersEL> list = manager.GetAllTransactionalVoucherByType(Operations.IdProject, Operations.BookNo, VoucherType);
            if (list.Count > 0)
            {
                DgvVoucher.DataSource = list;
            }
            else
            {
                MessageBox.Show("Not Record Found...");
            }

        }
        #endregion
        #region Stock Vouchers
        private void BindStockVouchersByDate(DateTime VoucherDate)
        {
            var manager = new VoucherBLL();
            List<VouchersEL> list = manager.GetAllStockTransactionalVouchersByTypeAndDate(Operations.IdProject, Operations.BookNo, VoucherType, VoucherDate, IsNetTransaction);
            if (list.Count > 0)
            {
                DgvVoucher.DataSource = list;
            }
            else
            {
                if (chkVByDate.Checked)
                {
                    MessageBox.Show("No Record Found In This Date...");
                }
                DgvVoucher.DataSource = null;
            }
            
        }
        private void BindStockVouchersByEditedDate(DateTime VoucherDate)
        {
            var manager = new VoucherBLL();
            List<VouchersEL> list = manager.GetAllStockTransactionalVouchersByTypeAndEditedDate(Operations.IdProject, Operations.BookNo, VoucherType, VoucherDate, IsNetTransaction);
            if (list.Count > 0)
            {
                DgvVoucher.DataSource = list;
            }
            else
            {
                if (chkVByDate.Checked)
                {
                    MessageBox.Show("No Record Found In This Date...");
                }
                DgvVoucher.DataSource = null;
            }

        }
        private void BindStockVouchersByAccountNo()
        {
            var manager = new VoucherBLL();
            if (AcEditBox.Text != string.Empty)
            {
                List<VouchersEL> list = manager.GetAllStockTransactionalVoucherByTypeAndAccountNo(Operations.IdProject, Operations.BookNo, AccountNo, VoucherType, IsNetTransaction);
                if (list.Count > 0)
                {
                    DgvVoucher.DataSource = list;
                }
                else
                {
                    MessageBox.Show("No Record Found For This Person....");
                    DgvVoucher.DataSource = null;
                }
            }

            else
            {
                MessageBox.Show("Account Number Is Missing In Field...");
            }
        }
        private void BindAllStockVouchersByType()
        {
            var manager = new VoucherBLL();

            List<VouchersEL> list = manager.GetAllStockTransactionalVoucherByType(Operations.IdProject, Operations.BookNo, VoucherType, IsNetTransaction);
            if (list.Count > 0)
            {
                DgvVoucher.DataSource = list;
            }
            else
            {
                MessageBox.Show("Not Record Found...");
            }

        }
        #endregion
        #region Grid Events
        private void DgvVoucher_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (DgvVoucher.CurrentRow != null)
            {
                int RowIndex = DgvVoucher.CurrentRow.Index;

                elVoucher = new VouchersEL();

                elVoucher.IdVoucher = Validation.GetSafeLong(DgvVoucher.Rows[RowIndex].Cells[0].Value);
                elVoucher.VDate = Validation.GetSafeDateTime(DgvVoucher.Rows[RowIndex].Cells[1].Value);
                elVoucher.VoucherNo = Validation.GetSafeLong(DgvVoucher.Rows[RowIndex].Cells[2].Value);
                //elVoucher.PersonName = Row.Cells[2].Value.ToString();
                //if (VoucherType != "PaymentVoucher" && VoucherType != "CashReceiptVoucher" && VoucherType != "SaleInvoiceVoucher" && VoucherType != "SalesReturnVoucher" && VoucherType != "BankPaymentVoucher" && VoucherType != "BankReceiptVoucher" && VoucherType != "PrescriberSampleVoucher" && VoucherType != "JournalVoucher")
                //{
                //    elVoucher.BillNo = DgvVoucher.Rows[RowIndex].Cells[6].Value.ToString();
                //    elVoucher.AccountNo = Validation.GetSafeString(DgvVoucher.Rows[RowIndex].Cells[4].Value);
                //}
                //else
                //{
                //    DgvVoucher.Columns[5].Visible = false;
                //    elVoucher.AccountNo = Validation.GetSafeString(DgvVoucher.Rows[RowIndex].Cells[4].Value);
                //}
                elVoucher.TotalAmount = Convert.ToDecimal(DgvVoucher.Rows[RowIndex].Cells[8].Value);
                elVoucher.Posted = Convert.ToBoolean(DgvVoucher.Rows[RowIndex].Cells[9].Value);

                this.Close();
            }
        }
        private void DgvVoucher_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            elVoucher = new VouchersEL();

            elVoucher.IdVoucher = Validation.GetSafeLong(DgvVoucher.Rows[e.RowIndex].Cells[0].Value);
            elVoucher.VDate = Validation.GetSafeDateTime(DgvVoucher.Rows[e.RowIndex].Cells[1].Value);
            elVoucher.VoucherNo = Validation.GetSafeLong(DgvVoucher.Rows[e.RowIndex].Cells[2].Value);
            //elVoucher.PersonName = Row.Cells[2].Value.ToString();
            //if (VoucherType != "PaymentVoucher" && VoucherType != "CashReceiptVoucher" && VoucherType != "SaleInvoiceVoucher" && VoucherType != "SalesReturnVoucher" && VoucherType != "BankPaymentVoucher" && VoucherType != "BankReceiptVoucher" && VoucherType != "PrescriberSampleVoucher" && VoucherType != "JournalVoucher")
            //{
            //    elVoucher.BillNo = DgvVoucher.Rows[e.RowIndex].Cells[6].Value.ToString();
            //    elVoucher.AccountNo = Validation.GetSafeString(DgvVoucher.Rows[e.RowIndex].Cells[4].Value);
            //}
            //else
            //{
            //    DgvVoucher.Columns[5].Visible = false;
            //    elVoucher.AccountNo = Validation.GetSafeString(DgvVoucher.Rows[e.RowIndex].Cells[4].Value);
            //}
            elVoucher.TotalAmount = Validation.GetSafeDecimal(DgvVoucher.Rows[e.RowIndex].Cells[8].Value);
            elVoucher.Posted = Convert.ToBoolean(DgvVoucher.Rows[e.RowIndex].Cells[9].Value);

            this.Close();

        }
        #endregion
        #region Win Controls Methods And Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (chkVByDate.Checked)
            {
                if (VoucherType == VoucherTypes.StockReceiptVoucher.ToString() || VoucherType == VoucherTypes.StockReturnVoucher.ToString() || VoucherType == VoucherTypes.SaleInvoiceVoucher.ToString() || VoucherType == VoucherTypes.SalesReturnVoucher.ToString())
                {
                    BindStockVouchersByDate(Convert.ToDateTime(dtVouchers.Value.ToString("yyyy/MM/dd")));
                }
                else
                {
                    BindVouchersByDate(Convert.ToDateTime(dtVouchers.Value.ToString("yyyy/MM/dd")));
                }
            }
            else if (chkVByEditDate.Checked)
            {
                if (VoucherType == VoucherTypes.StockReceiptVoucher.ToString() || VoucherType == VoucherTypes.StockReturnVoucher.ToString() || VoucherType == VoucherTypes.SaleInvoiceVoucher.ToString() || VoucherType == VoucherTypes.SalesReturnVoucher.ToString())
                {
                    BindStockVouchersByEditedDate(Convert.ToDateTime(dtEditedDateTime.Value.ToString("yyyy/MM/dd")));
                }
                else
                {
                    BindVouchersByEditedDate(Convert.ToDateTime(dtEditedDateTime.Value.ToString("yyyy/MM/dd")));
                }
            }
            else if (chkByVoucherNo.Checked)
            {
                if (VoucherType == VoucherTypes.StockReceiptVoucher.ToString() || VoucherType == VoucherTypes.StockReturnVoucher.ToString() || VoucherType == VoucherTypes.SaleInvoiceVoucher.ToString() || VoucherType == VoucherTypes.SalesReturnVoucher.ToString())
                {

                }
                else
                {
                    BindVouchersByVoucherNo();
                }
            }
            else if (chkVoucherByName.Checked)
            {
                if (VoucherType == VoucherTypes.StockReceiptVoucher.ToString() || VoucherType == VoucherTypes.StockReturnVoucher.ToString() || VoucherType == VoucherTypes.SaleInvoiceVoucher.ToString() || VoucherType == VoucherTypes.SalesReturnVoucher.ToString() || VoucherType == VoucherTypes.GeneralMaterialStoreIssuance.ToString())
                {
                    BindStockVouchersByAccountNo();
                }
                else
                {
                    BindVouchersByAccountNo();
                }
            }
            else if (chkAllVouchers.Checked)
            {
                if (VoucherType == VoucherTypes.StockReceiptVoucher.ToString() || VoucherType == VoucherTypes.StockReturnVoucher.ToString() || VoucherType == VoucherTypes.SaleInvoiceVoucher.ToString() || VoucherType == VoucherTypes.SalesReturnVoucher.ToString() || VoucherType == VoucherTypes.GeneralMaterialStoreIssuance.ToString())
                {
                    BindAllStockVouchersByType();
                }
                else
                {
                    BindAllVouchersByType();
                }
            }

        }
        private void chkVoucher_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            if (chk.Name == "chkVByDate")
            {
                if (chk.Checked)
                {
                    chkVByEditDate.Checked = false;
                    chkByVoucherNo.Checked = false;
                    chkVoucherByName.Checked = false;
                    chkAllVouchers.Checked = false;
                }
                else
                {
                    //chkByVoucherNo.Checked = true;
                    //chkVoucherByName.Checked= true;
                }
            }
            else if (chk.Name == "chkVByEditDate")
            {
                if (chk.Checked)
                {
                    chkVByDate.Checked = false;
                    chkByVoucherNo.Checked = false;
                    chkVoucherByName.Checked = false;
                    chkAllVouchers.Checked = false;
                }
                else
                {
                    //chkByVoucherNo.Checked = true;
                    //chkVoucherByName.Checked= true;
                }
            }
            else if (chk.Name == "chkByVoucherNo")
            {
                if (chk.Checked)
                {
                    chkVByDate.Checked = false;
                    chkVByEditDate.Checked = false;
                    chkVoucherByName.Checked = false;
                    chkAllVouchers.Checked = false;
                }
                else
                {
                    DgvVoucher.DataSource = null;
                    //chkVByDate.Checked = true;
                    //chkVoucherByName.Checked = true;
                }
            }
            else if (chk.Name == "chkVoucherByName")
            {
                if (chk.Checked)
                {
                    chkByVoucherNo.Checked = false;
                    chkVByDate.Checked = false;
                    chkVByEditDate.Checked = false;
                    chkAllVouchers.Checked = false;
                }
                else
                {
                    DgvVoucher.DataSource = null;
                    //chkByVoucherNo.Checked = true;
                    //chkVByDate.Checked = true;
                }
            }
            else if (chk.Name == "chkAllVouchers")
            {
                if (chk.Checked)
                {
                    chkByVoucherNo.Checked = false;
                    chkVByDate.Checked = false;
                    chkVByEditDate.Checked = false;
                    chkVoucherByName.Checked = false;
                }
                else
                {
                    DgvVoucher.DataSource = null;
                    //chkByVoucherNo.Checked = true;
                    //chkVByDate.Checked = true;
                }
            }
        }
        #endregion
        #region Custom Controls Methods And Events
        private void AcEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
                frmAccount = new frmFindAccounts();
                frmAccount.SearchText = e.KeyChar.ToString();
                frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                frmAccount.ShowDialog();

            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                if (AcEditBox.Text != string.Empty)
                {
                    btnLoad.Focus();
                }
            }
            else
                e.Handled = false;
        }
        private void AcEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmAccount = new frmFindAccounts();
            frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
            frmAccount.ShowDialog();
        }
        void frmAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            AccountNo = oelAccount.AccountNo;
            AcEditBox.Text = oelAccount.AccountName;
        }
        #endregion
    }
}
