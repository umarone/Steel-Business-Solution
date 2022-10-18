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
    public partial class frmInvoicesDateChange : MetroForm
    {
        #region Variables
        Int64 IdVoucher;
        public Int32 ChangedNumber = 0;
        #endregion
        #region Form Methods And Events
        public frmInvoicesDateChange()
        {
            InitializeComponent();
        }
        private void frmInvoicesDateChange_Load(object sender, EventArgs e)
        {

        }
        #endregion
        #region Win Control Methods And Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            FillVoucherByNumber();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var manager = new SalesHeadBLL();
            if (manager.UpdateInvoicesAndReturnsDates(IdVoucher, dtNew.Value, ChangedNumber).IsSuccess)
            {
                MessageBox.Show("Invoice Date Changed Successfully....");
                btnUpdate.Enabled = false;
            }
        }
        private void txtSaleNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
            }
            else
                e.Handled = false;
        }
        #endregion
        #region Methods
        private void FillVoucherByNumber()
        {
            var SManager = new SalesHeadBLL();
            if (cbxSaleType.Text == string.Empty)
            {
                MessageBox.Show("Please Select Sale Type");
                return;
            }
            List<VoucherDetailEL> ListSales = SManager.GetSalesTransactionsByNumber(Validation.GetSafeLong(txtSaleNumber.Text), Operations.IdProject, Operations.BookNo, cbxSaleType.Text == "Net Sales" ? true : false);
            if (ListSales.Count > 0)
            {
                IdVoucher = ListSales[0].IdVoucher.Value;
                txtCurrentDate.Text = ListSales[0].VDate.Value.ToString();
                btnUpdate.Enabled = true;
            }
            else
            {
                MessageBox.Show("Invoice Number Not Found ...");
                btnUpdate.Enabled = false;
                txtCurrentDate.Text = string.Empty;
                dtNew.Value = DateTime.Now;
            }
        }
        #endregion
    }
}
