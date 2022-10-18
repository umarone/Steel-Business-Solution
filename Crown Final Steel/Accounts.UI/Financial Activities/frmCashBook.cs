using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.BLL;
using Accounts.EL;
using Accounts.Common;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmCashBook : MetroForm
    {
        #region Variables
        frmFindAccounts frmFindAccounts;
        string AccountNo = string.Empty;
        List<TransactionsEL> listSummary = new List<TransactionsEL>();
        TextBox txtRecievingTotal = new TextBox();
        TextBox txtPaymentTotal = new TextBox();
        #endregion
        #region Form Methods And Events
        public frmCashBook()
        {
            InitializeComponent();
        }
        private void frmCashBook_Load(object sender, EventArgs e)
        {
            this.grdReceipts.AutoGenerateColumns = false;
            this.grdPayments.AutoGenerateColumns = false;
            CreateAndInitializeFooterRow();
        }
        private void frmCashBook_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void CreateAndInitializeFooterRow()
        {
            txtRecievingTotal.Enabled = false;
            txtPaymentTotal.Enabled = false;
           

            txtRecievingTotal.TextAlign = HorizontalAlignment.Center;
            txtPaymentTotal.TextAlign = HorizontalAlignment.Center;
           

            int Xdgvx0 = this.grdReceipts.GetCellDisplayRectangle(2, -1, true).Location.X;


            txtRecievingTotal.Width = this.grdReceipts.Columns[2].Width;

            txtRecievingTotal.Location = new Point(Xdgvx0, grdReceipts.Height - txtRecievingTotal.Height);

            this.grdReceipts.Controls.Add(txtRecievingTotal);


            int Xdgvx1 = this.grdPayments.GetCellDisplayRectangle(2, -1, true).Location.X;


            txtPaymentTotal.Width = this.grdPayments.Columns[2].Width;

            txtPaymentTotal.Location = new Point(Xdgvx1, grdPayments.Height - txtPaymentTotal.Height);

            this.grdPayments.Controls.Add(txtPaymentTotal);

        }
        #endregion
        #region Custom Controls Methods And Events
        private void AccEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
                frmFindAccounts = new frmFindAccounts();
                frmFindAccounts.SearchText = e.KeyChar.ToString();
                frmFindAccounts.ExecuteFindAccountEvent += new UI.frmFindAccounts.FindAccountDelegate(frmFindAccounts_ExecuteFindAccountEvent);
                frmFindAccounts.ShowDialog();

            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                if (AccEditBox.Text != string.Empty)
                {
                    btnLoad.Focus();
                }
            }
            else
                e.Handled = false;
        }
        private void AccEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmFindAccounts = new frmFindAccounts();
            frmFindAccounts.ExecuteFindAccountEvent +=new UI.frmFindAccounts.FindAccountDelegate(frmFindAccounts_ExecuteFindAccountEvent);
            frmFindAccounts.ShowDialog();
        }
        void frmFindAccounts_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            AccountNo = oelAccount.AccountNo;
            AccEditBox.Text = oelAccount.AccountName;
        }
        #endregion
        #region Button Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new TransactionBLL();
            List<TransactionsEL> list = manager.GetCashBookDetailByDate(Operations.IdProject, Operations.BookNo, AccountNo, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                List<TransactionsEL> listReceipts = list.FindAll(x => x.SeqNo == 2 || x.SeqNo == 3 || x.SeqNo == 6);
                if (listReceipts.Count > 0)
                {
                    grdReceipts.DataSource = listReceipts;
                    txtRecievingTotal.Text = listReceipts.Sum(x => x.TotalAmount).ToString();
                }
                else
                {
                    grdReceipts.DataSource = null;
                    txtRecievingTotal.Text = string.Empty;
                }
                List<TransactionsEL> listPayments = list.FindAll(x => x.SeqNo == 1 || x.SeqNo == 4 || x.SeqNo == 5);
                if (listPayments.Count > 0)
                {
                    grdPayments.DataSource = listPayments;
                    txtPaymentTotal.Text = listPayments.Sum(x => x.TotalAmount).ToString();
                }
                else
                {
                    grdPayments.DataSource = null;
                    txtPaymentTotal.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("No Record Found..");
                grdReceipts.DataSource = null;
                grdPayments.DataSource = null;
                txtRecievingTotal.Text = string.Empty;
                txtPaymentTotal.Text = string.Empty;
            }
        }
        #endregion
    }
}
