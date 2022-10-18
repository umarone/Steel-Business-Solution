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
using Accounts.UI.UserControls;
using Accounts.EL;

using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmCustomersSalesInvoices : MetroForm
    {
        #region Variables
        frmFindAccounts frmFindAccount = null;
        Int64? IdVoucher;
        string AccountNo;
        #endregion
        public frmCustomersSalesInvoices()
        {
            InitializeComponent();
        }
        private void frmCustomersSalesInvoices_Load(object sender, EventArgs e)
        {
            this.grdInvoices.AutoGenerateColumns = false;
        }
        private void txtCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
               
                    e.Handled = true;
                    frmFindAccount = new frmFindAccounts();
                    frmFindAccount.SearchText = e.KeyChar.ToString();
                    frmFindAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmFindAccount_ExecuteFindAccountEvent);
                    frmFindAccount.ShowDialog();
               
            }
            else
                e.Handled = false;
        }
        private void txtCustomer_ButtonClick(object sender, EventArgs e)
        {
            frmFindAccount = new frmFindAccounts();
            frmFindAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmFindAccount_ExecuteFindAccountEvent);
            frmFindAccount.ShowDialog();
        }
        void frmFindAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            AccountNo = oelAccount.AccountNo;
            txtCustomer.Text = oelAccount.AccountName;
        }
        private void grdInvoices_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                e.Value = "Update";
            }
        }
        private void grdInvoices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                IdVoucher = Validation.GetSafeLong(grdInvoices.Rows[e.RowIndex].Cells[0].Value);
                decimal balance = Validation.GetSafeLong(grdInvoices.Rows[e.RowIndex].Cells[5].Value);
                UpdateInvoice(balance);
            }
        }       
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new VoucherBLL();
            if (txtCustomer.Text != string.Empty)
            {
                List<VoucherDetailEL> list =  manager.GetCustomersInvoices(AccountNo, Operations.IdProject, Operations.BookNo);
                if (list.Count > 0)
                {
                    grdInvoices.DataSource = list;
                }
                else
                {
                    MessageBox.Show("No Data Found....");
                    grdInvoices.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Please Select Customer");
            }
        }
        private void UpdateInvoice(decimal NewBalance)
        {
            var manager = new VoucherBLL();
            if (IdVoucher.HasValue)
            {
                if (manager.UpdateCustomerInvoicePreviousBalance(IdVoucher.Value, NewBalance).IsSuccess)
                {
                    MessageBox.Show("Previous Balance Updated Successfully for this invoice....");
                    IdVoucher = null;
                }
            }
        }
    }
}
