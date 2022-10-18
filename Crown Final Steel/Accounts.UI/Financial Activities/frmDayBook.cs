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
    public partial class frmDayBook : MetroForm
    {
        List<TransactionsEL> list;
        List<TransactionsEL> listSummary = new List<TransactionsEL>();
        public frmDayBook()
        {
            InitializeComponent();
        }

        private void frmDayBook_Load(object sender, EventArgs e)
        {
            this.grdDetailedDailyBook.AutoGenerateColumns = false;
            this.grdSummaryDailyBook.AutoGenerateColumns = false;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var Manager = new TransactionBLL();
            list = Manager.GetDayBookByDate(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                grdDetailedDailyBook.DataSource = list;
                listSummary = new List<TransactionsEL>();
                if (chkCompositeSummary.Checked)
                {
                    listSummary.Add(new TransactionsEL() { Discription = "Purchases", TotalAmount = list.Where(x => x.SeqNo == 1).Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Purchaes Return", TotalAmount = list.Where(x => x.SeqNo == 2).Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Purchaes Amount", TotalAmount = (list.Where(x => x.SeqNo == 1).Sum(x => x.TotalAmount)) - (list.Where(x => x.SeqNo == 2).Sum(x => x.TotalAmount)) });
                    listSummary.Add(new TransactionsEL() { Discription = "Sales", TotalAmount = list.Where(x => x.SeqNo == 3).Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Sales Return", TotalAmount = list.Where(x => x.SeqNo == 4).Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Sales Amount", TotalAmount = (list.Where(x => x.SeqNo == 3).Sum(x => x.TotalAmount)) - (list.Where(x => x.SeqNo == 4).Sum(x => x.TotalAmount)) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Recieveing", TotalAmount = list.Where(x => x.Discription == "CashReceiptVoucher").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Payments / Expenses", TotalAmount = list.Where(x => x.Discription == "PaymentVoucher").Sum(x => x.TotalAmount) });
                }
                else if (chkNetSummary.Checked)
                {
                    listSummary.Add(new TransactionsEL() { Discription = "Net Purchases", TotalAmount = list.Where(x => x.SeqNo == 1 && x.Discription == "Net Purchases").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Net Purchaes Return", TotalAmount = list.Where(x => x.SeqNo == 2 && x.Discription == "Net Purchases Return").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Purchaes Amount", TotalAmount = (list.Where(x => x.SeqNo == 1).Sum(x => x.TotalAmount)) - (list.Where(x => x.SeqNo == 2).Sum(x => x.TotalAmount)) });
                    listSummary.Add(new TransactionsEL() { Discription = "Net Sales", TotalAmount = list.Where(x => x.SeqNo == 3 && x.Discription == "Net Sales").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Net Sales Return", TotalAmount = list.Where(x => x.SeqNo == 4 && x.Discription == "Net Sales Return").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Sales Amount", TotalAmount = (list.Where(x => x.SeqNo == 3).Sum(x => x.TotalAmount)) - (list.Where(x => x.SeqNo == 4).Sum(x => x.TotalAmount)) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Recieveing", TotalAmount = list.Where(x => x.Discription == "CashReceiptVoucher").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Payments / Expenses", TotalAmount = list.Where(x => x.Discription == "PaymentVoucher").Sum(x => x.TotalAmount) });

                }
                else if (chkCreditSummary.Checked)
                {
                    listSummary.Add(new TransactionsEL() { Discription = "Credit Purchases", TotalAmount = list.Where(x => x.SeqNo == 1 && x.Discription == "Credit Purchases").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Credit Purchaes Return", TotalAmount = list.Where(x => x.SeqNo == 2 && x.Discription == "Credit Purchases Return").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Purchaes Amount", TotalAmount = (list.Where(x => x.SeqNo == 1).Sum(x => x.TotalAmount)) - (list.Where(x => x.SeqNo == 2).Sum(x => x.TotalAmount)) });
                    listSummary.Add(new TransactionsEL() { Discription = "Credit Sales", TotalAmount = list.Where(x => x.SeqNo == 3 && x.Discription == "Credit Sales").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Credit Sales Return", TotalAmount = list.Where(x => x.SeqNo == 4 && x.Discription == "Credit Sales Return").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Sales Amount", TotalAmount = (list.Where(x => x.SeqNo == 3).Sum(x => x.TotalAmount)) - (list.Where(x => x.SeqNo == 4).Sum(x => x.TotalAmount)) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Recieveing", TotalAmount = list.Where(x => x.Discription == "CashReceiptVoucher").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Payments / Expenses", TotalAmount = list.Where(x => x.Discription == "PaymentVoucher").Sum(x => x.TotalAmount) });

                }
                else
                {
                    listSummary.Add(new TransactionsEL() { Discription = "Purchases", TotalAmount = list.Where(x => x.SeqNo == 1).Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Purchaes Return", TotalAmount = list.Where(x => x.SeqNo == 2).Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Purchaes Amount", TotalAmount = (list.Where(x => x.SeqNo == 1).Sum(x => x.TotalAmount)) - (list.Where(x => x.SeqNo == 2).Sum(x => x.TotalAmount)) });
                    listSummary.Add(new TransactionsEL() { Discription = "Sales", TotalAmount = list.Where(x => x.SeqNo == 3).Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Sales Return", TotalAmount = list.Where(x => x.SeqNo == 4).Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Sales Amount", TotalAmount = (list.Where(x => x.SeqNo == 3).Sum(x => x.TotalAmount)) - (list.Where(x => x.SeqNo == 4).Sum(x => x.TotalAmount)) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Recieveing", TotalAmount = list.Where(x => x.Discription == "CashReceiptVoucher").Sum(x => x.TotalAmount) });
                    listSummary.Add(new TransactionsEL() { Discription = "Total Payments / Expenses", TotalAmount = list.Where(x => x.Discription == "PaymentVoucher").Sum(x => x.TotalAmount) });
                }
                grdSummaryDailyBook.DataSource = listSummary;
            }
            else
                grdDetailedDailyBook.DataSource = null;
        }

        private void chkNetSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNetSummary.Checked)
            {
                chkCreditSummary.Checked = false;
                chkCompositeSummary.Checked = false;
            }
        }

        private void chkCreditSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCreditSummary.Checked)
            {
                chkNetSummary.Checked = false;
                chkCompositeSummary.Checked = false;
            }
        }

        private void chkCompositeSummary_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCompositeSummary.Checked)
            {
                chkCreditSummary.Checked = false;
                chkNetSummary.Checked = false;
            }
        }

        private void chkPurchases_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPurchases.Checked)
            {
                chkSales.Checked = false;
                chkPayments.Checked = false;
                chkReceipts.Checked = false;
                chkComposite.Checked = false;
                LoadFilteredData(1);
            }
        }

        private void chkSales_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSales.Checked)
            {
                chkPurchases.Checked = false;
                chkPayments.Checked = false;
                chkReceipts.Checked = false;
                chkComposite.Checked = false;
                LoadFilteredData(2);
            }
        }

        private void chkPayments_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPayments.Checked)
            {
                chkSales.Checked = false;
                chkPurchases.Checked = false;
                chkPurchases.Checked = false;
                chkPurchases.Checked = false;
                LoadFilteredData(3);
            }
        }

        private void chkReceipts_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReceipts.Checked)
            {
                chkSales.Checked = false;
                chkPayments.Checked = false;
                chkPurchases.Checked = false;
                chkPurchases.Checked = false;
                LoadFilteredData(4);
            }
        }

        private void chkComposite_CheckedChanged(object sender, EventArgs e)
        {
            if (chkComposite.Checked)
            {
                chkSales.Checked = false;
                chkPayments.Checked = false;
                chkReceipts.Checked = false;
                chkPurchases.Checked = false;
                LoadFilteredData(5);
            }
        }
        private void LoadFilteredData(int SeqNo)
        {
            if (SeqNo == 1 && list.Count > 0)
            {
                grdDetailedDailyBook.DataSource = list.Where(x => x.SeqNo == 1 || x.SeqNo == 2).ToList();
            }
            else if (SeqNo == 2 && list.Count > 0)
            {
                grdDetailedDailyBook.DataSource = list.Where(x => x.SeqNo == 3 || x.SeqNo == 4).ToList();
            }
            else if (SeqNo == 3 && list.Count > 0)
            {
                grdDetailedDailyBook.DataSource = list.Where(x=>x.Discription == "PaymentVoucher" || x.Discription == "BankPaymentVoucher").ToList();
            }
            else if (SeqNo == 4 && list.Count > 0)
            {
                grdDetailedDailyBook.DataSource = list.Where(x=>x.Discription == "CashReceiptVoucher" || x.Discription == "BankReceiptVoucher").ToList();
            }
            else if (SeqNo == 5 && list.Count > 0)
            {
                grdDetailedDailyBook.DataSource = list;
            }
        }
    }
}
