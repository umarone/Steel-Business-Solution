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
    public partial class frmUserActivityReport : MetroForm
    {
        #region Variables
        string VoucherType = string.Empty;
        string StockVoucherType = string.Empty;
        string TanneryType = string.Empty;
        #endregion
        #region Form Events
        public frmUserActivityReport()
        {
            InitializeComponent();
        }
        private void frmUserActivityReport_Load(object sender, EventArgs e)
        {
            this.grdFindAccounts.AutoGenerateColumns = false;
            this.grdFinancialActivities.AutoGenerateColumns = false;
            this.grdStockActivities.AutoGenerateColumns = false;
            this.lblDebitSum.Visible = false;
            this.lblCreditSum.Visible = false;
            LoadAllSystemUsers();
        }
        #endregion
        #region General Events
        private void LoadAllSystemUsers()
        {
            var manager = new UsersBLL();
            List<UsersEL> list = manager.GetAllUsers();
            if (list.Count > 0)
            {
                list.Insert(0, new UsersEL() { UserId = 0, UserName = "Select User" });

                cbxUsers.DisplayMember = "UserName";
                cbxUsers.ValueMember = "UserId";
                cbxUsers.DataSource = list;
            }
        }
        #endregion
        #region Buttons Events
        private void btnAccountsActivities_Click(object sender, EventArgs e)
        {
            var Manager = new UsersBLL();
            try
            {
                List<AccountsEL> list = null;
                if (cbxUsers.Text == "Select User")
                {
                    MessageBox.Show("Please Select User.....");
                    grdFindAccounts.DataSource = null;
                    return;
                }
                if (!chkAllAccounts.Checked)
                {
                    list = Manager.GetAllAccountsByUserAndDateForActivityLogger(Validation.GetSafeLong(cbxUsers.SelectedValue), Convert.ToDateTime(dtActivity.Value.ToShortDateString()));
                }
                else
                {
                    list = Manager.GetAllAccountsByUserForActivityLogger(Validation.GetSafeLong(cbxUsers.SelectedValue));
                }
                if (list.Count > 0)
                {
                    grdFindAccounts.DataSource = list;
                    lblTotalsum.Text = list.Count.ToString();
                }
                else
                {
                    grdFindAccounts.DataSource = null;
                    lblTotalsum.Text = "0";
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnLoadFinancialActivities_Click(object sender, EventArgs e)
        {
            var Manager = new UsersBLL();
            List<TransactionsEL> list = null;
            if (cbxUsers.Text == "Select User")
            {
                MessageBox.Show("Please Select User.....");
                grdFinancialActivities.DataSource = null;
                return;
            }
            if (!chkPaymentActivities.Checked && !chkReceiptActivities.Checked && !chkBankPaymentActivities.Checked && !chkBankReceiptActivities.Checked && !chkJournalActivities.Checked)
            {
                MessageBox.Show("Please Select Activity Type...");
                return;
            }
            list = Manager.GetVouchersByUserAndDateForActivity(Validation.GetSafeLong(cbxUsers.SelectedValue), Operations.IdProject, Operations.BookNo, Convert.ToDateTime(dtActivity.Value.ToShortDateString()), VoucherType);
            if (list.Count > 0)
            {
                grdFinancialActivities.DataSource = list;
                lblTotalsum.Text = list.Count.ToString();
                lblCreditSum.Visible = false;
                lblDebitSum.Visible = true;
                lblDebitSum.Text = "Total Amount : " + list.Sum(x => x.TotalAmount).ToString();
            }
            else
            {
                grdFinancialActivities.DataSource = null;
                lblTotalsum.Text = "0";
            }
        }
        private void btnLoadStockActivity_Click(object sender, EventArgs e)
        {
            var Manager = new UsersBLL();
            List<VouchersEL> list = null;
            if (cbxUsers.Text == "Select User")
            {
                MessageBox.Show("Please Select User.....");
                grdStockActivities.DataSource = null;
                return;
            }
            if (!chkPurchaseActivities.Checked && !chkPurchasesReturnActivity.Checked && !chkStockSaleActivites.Checked && !chkStockReturnAcitvities.Checked)
            {
                MessageBox.Show("Please Select Stock Activity Type...");
                return;
            }
            list = Manager.GetStockVouchersByUserAndDateForActivity(Validation.GetSafeLong(cbxUsers.SelectedValue), Operations.IdProject, Operations.BookNo, Convert.ToDateTime(dtActivity.Value.ToShortDateString()), StockVoucherType);
            if (list.Count > 0)
            {
                grdStockActivities.DataSource = list;
                lblTotalsum.Text = list.Count.ToString();
                lblDebitSum.Visible = true;
                lblCreditSum.Visible = true;
                lblDebitSum.Text = "Debit Sum :" + list.Where(x => x.IsNetTransaction.Value).Sum(x => x.TotalAmount);
                lblCreditSum.Text = "Credit Sum :" + list.Where(x => x.IsNetTransaction.Value == false).Sum(x => x.TotalAmount);
            }
            else
            {
                grdStockActivities.DataSource = null;
                lblTotalsum.Text = "0";
            }
        } 
        #endregion
        #region CheckBox Events
        private void chkAllAccounts_CheckedChanged(object sender, EventArgs e)
        {
            grdFindAccounts.DataSource = null;
        }
        private void chkPaymentActivities_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPaymentActivities.Checked)
            {
                chkReceiptActivities.Checked = false;
                chkBankPaymentActivities.Checked = false;
                chkBankReceiptActivities.Checked = false;
                chkJournalActivities.Checked = false;

                grdFinancialActivities.DataSource = null;
            }
            VoucherType = "PaymentVoucher";
        }
        private void chkReceiptActivities_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReceiptActivities.Checked)
            {
                chkPaymentActivities.Checked = false;
                chkBankPaymentActivities.Checked = false;
                chkBankReceiptActivities.Checked = false;
                chkJournalActivities.Checked = false;

                grdFinancialActivities.DataSource = null;
            }
            VoucherType = "CashReceiptVoucher";
        }
        private void chkBankPaymentActivities_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBankPaymentActivities.Checked)
            {
                chkReceiptActivities.Checked = false;
                chkPaymentActivities.Checked = false;
                chkBankReceiptActivities.Checked = false;
                chkJournalActivities.Checked = false;

                grdFinancialActivities.DataSource = null;
            }
            VoucherType = "BankPaymentVoucher";
        }
        private void chkBankReceiptActivities_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBankReceiptActivities.Checked)
            {
                chkReceiptActivities.Checked = false;
                chkBankPaymentActivities.Checked = false;
                chkPaymentActivities.Checked = false;
                chkJournalActivities.Checked = false;

                grdFinancialActivities.DataSource = null;
            }
            VoucherType = "BankReceiptVoucher";
        }
        private void chkJournalActivities_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJournalActivities.Checked)
            {
                chkReceiptActivities.Checked = false;
                chkBankPaymentActivities.Checked = false;
                chkBankReceiptActivities.Checked = false;
                chkPaymentActivities.Checked = false;

                grdFinancialActivities.DataSource = null;
            }
            VoucherType = "JournalVoucher";
        }
        #endregion
        #region Stock CheckBoxes Events
        private void chkPurchaseActivities_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPurchaseActivities.Checked)
            {
                chkPurchasesReturnActivity.Checked = false;
                chkStockSaleActivites.Checked = false;
                chkStockReturnAcitvities.Checked = false;
            }
            StockVoucherType = "Purchases";
        }
        private void chkPurchasesReturnActivity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPurchasesReturnActivity.Checked)
            {
                chkPurchaseActivities.Checked = false;
                chkStockSaleActivites.Checked = false;
                chkStockReturnAcitvities.Checked = false;
            }
            StockVoucherType = "Purchases Return";
        }
        private void chkStockSaleActivites_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStockSaleActivites.Checked)
            {
                chkPurchaseActivities.Checked = false;
                chkPurchasesReturnActivity.Checked = false;
                chkStockReturnAcitvities.Checked = false;
            }
            StockVoucherType = "Sales";
        }
        private void chkStockReturnAcitvities_CheckedChanged(object sender, EventArgs e)
        {
            if (chkStockReturnAcitvities.Checked)
            {
                chkPurchaseActivities.Checked = false;
                chkStockSaleActivites.Checked = false;
                chkPurchasesReturnActivity.Checked = false;
            }
            StockVoucherType = "Sales Return";
        }
        #endregion
        #region Tab Events
        private void tabUserActivity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
