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
    public partial class frmDayBookDetail : MetroForm
    {
        #region Variables
        List<TransactionsEL> list;
        List<TransactionsEL> lstReceipts;
        List<TransactionsEL> lstPayments;
        List<TransactionsEL> lstJVReceipts;
        List<TransactionsEL> lstJVPayments;
        List<TransactionsEL> lstPurchases;
        List<TransactionsEL> lstSales;
        List<TransactionsEL> listSummary = new List<TransactionsEL>();
        TextBox txtRecievingTotal = new TextBox();
        TextBox txtPaymentTotal = new TextBox();
        TextBox txtPurchaseTotal = new TextBox();
        TextBox txtSaleTotal = new TextBox();
        TextBox txtJvReceiptTotal = new TextBox();
        TextBox txtJvPaymentTotal = new TextBox();
        #endregion
        #region Form Methods and Events
        public frmDayBookDetail()
        {
            InitializeComponent();
        }
        private void frmDayBookDetail_Load(object sender, EventArgs e)
        {
            grdReceipts.AutoGenerateColumns = false;
            grdPayments.AutoGenerateColumns = false;
            grdPurchases.AutoGenerateColumns = false;
            grdJVReceipt.AutoGenerateColumns = false;
            grdJVPayment.AutoGenerateColumns = false;
            grdSales.AutoGenerateColumns = false;
            CreateAndInitializeFooterRow();
        }
        private void CreateAndInitializeFooterRow()
        {
            txtRecievingTotal.Enabled = false;
            txtPaymentTotal.Enabled = false;
            txtPurchaseTotal.Enabled = false;
            txtSaleTotal.Enabled = false;
            txtJvReceiptTotal.Enabled = false;
            txtJvPaymentTotal.Enabled = false;

            txtRecievingTotal.TextAlign = HorizontalAlignment.Center;
            txtPaymentTotal.TextAlign = HorizontalAlignment.Center;
            txtPurchaseTotal.TextAlign = HorizontalAlignment.Center;
            txtSaleTotal.TextAlign = HorizontalAlignment.Center;
            txtJvReceiptTotal.TextAlign = HorizontalAlignment.Center;
            txtJvPaymentTotal.TextAlign = HorizontalAlignment.Center; 

            
            int Xdgvx0 = this.grdReceipts.GetCellDisplayRectangle(2, -1, true).Location.X;


            txtRecievingTotal.Width = this.grdReceipts.Columns[2].Width;

            txtRecievingTotal.Location = new Point(Xdgvx0, grdReceipts.Height - txtRecievingTotal.Height);

            this.grdReceipts.Controls.Add(txtRecievingTotal);


            int Xdgvx1 = this.grdPayments.GetCellDisplayRectangle(2, -1, true).Location.X;


            txtPaymentTotal.Width = this.grdPayments.Columns[2].Width;

            txtPaymentTotal.Location = new Point(Xdgvx1, grdPayments.Height - txtPaymentTotal.Height);

            this.grdPayments.Controls.Add(txtPaymentTotal);


            int Xdgvx2 = grdPurchases.GetCellDisplayRectangle(1, -1, true).Location.X;
            txtPurchaseTotal.Width = this.grdPurchases.Columns[1].Width;
            txtPurchaseTotal.Location = new Point(Xdgvx2, grdPurchases.Height - txtPurchaseTotal.Height);
            this.grdPurchases.Controls.Add(txtPurchaseTotal);

            int Xdgvx3 = grdSales.GetCellDisplayRectangle(1, -1, true).Location.X;
            txtSaleTotal.Width = this.grdSales.Columns[1].Width;
            txtSaleTotal.Location = new Point(Xdgvx3, grdSales.Height - txtSaleTotal.Height);
            grdSales.Controls.Add(txtSaleTotal);

            int Xdgvx4 = grdJVReceipt.GetCellDisplayRectangle(2, -1, true).Location.X;
            txtJvReceiptTotal.Width = this.grdJVReceipt.Columns[2].Width;
            txtJvReceiptTotal.Location = new Point(Xdgvx4, grdJVReceipt.Height - txtJvReceiptTotal.Height);
            grdJVReceipt.Controls.Add(txtJvReceiptTotal);


            int Xdgvx5 = grdJVPayment.GetCellDisplayRectangle(2, -1, true).Location.X;
            txtJvPaymentTotal.Width = this.grdJVPayment.Columns[2].Width;
            txtJvPaymentTotal.Location = new Point(Xdgvx5, grdJVPayment.Height - txtJvPaymentTotal.Height);
            grdJVPayment.Controls.Add(txtJvPaymentTotal);


        }
        #endregion
        #region Win Controls Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var Manager = new TransactionBLL();
            list = Manager.GetDayBookDetailByDate(Operations.IdProject, Operations.BookNo, Convert.ToDateTime(dtStart.Value.ToShortDateString()));
            if (list.Count > 0)
            {
                lstPurchases = list.FindAll(x => x.SeqNo == 1 || x.SeqNo == 2);
                if (lstPurchases.Count > 0)
                {
                    grdPurchases.DataSource = lstPurchases;
                    txtPurchaseTotal.Text = lstPurchases.Sum(x => x.TotalAmount).ToString();
                }
                else
                {
                    grdPurchases.DataSource = null;
                    txtPurchaseTotal.Text = string.Empty;
                }
                lstSales = list.FindAll(x => x.SeqNo == 3 || x.SeqNo == 4);
                if (lstSales.Count > 0)
                {
                    grdSales.DataSource = lstSales;
                    txtSaleTotal.Text = lstSales.Sum(x => x.TotalAmount).ToString();
                }
                else
                {
                    grdSales.DataSource = null;
                    txtSaleTotal.Text = string.Empty;
                }
                lstReceipts = list.FindAll(x => x.Discription == "CashReceiptVoucher" || x.Discription == "BankReceiptVoucher");
                if (lstReceipts.Count > 0)
                {
                    grdReceipts.DataSource = lstReceipts;
                    txtRecievingTotal.Text = lstReceipts.Sum(x => x.Credit).ToString();
                }
                else
                {
                    grdReceipts.DataSource = null;
                    txtRecievingTotal.Text = string.Empty;
                }
                lstPayments = list.FindAll(x => x.Discription == "PaymentVoucher" || x.Discription == "BankPaymentVoucher");
                if (lstPayments.Count > 0)
                {
                    grdPayments.DataSource = lstPayments;
                    txtPaymentTotal.Text = lstPayments.Sum(x => x.Debit).ToString();
                }
                else
                {
                    grdPayments.DataSource = null;
                    txtPaymentTotal.Text = string.Empty;
                }
                lstJVReceipts = list.FindAll(x => x.Discription == "JournalVoucher" && x.Credit > 0);
                if (lstJVReceipts.Count > 0)
                {
                    grdJVReceipt.DataSource = lstJVReceipts;
                    txtJvReceiptTotal.Text = lstJVReceipts.Sum(x => x.Credit).ToString();
                }
                lstJVPayments = list.FindAll(x => x.Discription == "JournalVoucher" && x.Debit > 0);
                if (lstJVPayments.Count > 0)
                {
                    grdJVPayment.DataSource = lstJVPayments;
                    txtJvPaymentTotal.Text = lstJVPayments.Sum(x => x.Debit).ToString();
                }
            }
            else
            {
                grdPurchases.DataSource = null;
                grdSales.DataSource = null;
                grdPayments.DataSource = null;
                grdReceipts.DataSource = null;
            }
        }
        #endregion
    }
}
