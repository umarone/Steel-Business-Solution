using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
using MetroFramework.Forms;
using MetroFramework.Controls;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmUnpostedVouchers : MetroFramework.Forms.MetroForm
    {
        string VoucherType;
        public frmUnpostedVouchers()
        {
            InitializeComponent();
        }

        private void frmUnpostedVouchers_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.dgvUnpostedVouchers.AutoGenerateColumns = false;
        }
        private void CreateBindVoucherWiseColumns()
        {
            if (dgvUnpostedVouchers.Columns.Count > 0)
            {
                dgvUnpostedVouchers.Columns.Clear();
            }
            DataGridViewTextBoxColumn colVoucherNo = new DataGridViewTextBoxColumn();
            colVoucherNo.HeaderText = "VoucherNo. #";
            colVoucherNo.Name = "colVoucherNo";
            colVoucherNo.DataPropertyName = "VoucherNo";
            this.dgvUnpostedVouchers.Columns.Add(colVoucherNo);

            DataGridViewTextBoxColumn colDate = new DataGridViewTextBoxColumn();
            if (VoucherType == VoucherTypes.CashReceiptVoucher.ToString())
            {
                colDate.HeaderText = "Recieved Date";
            }
            else if (VoucherType == VoucherTypes.PaymentVoucher.ToString())
            {
                colDate.HeaderText = "Paid Date";
            }
            else if (VoucherType ==  VoucherTypes.StockReceiptVoucher.ToString())
            {
                colDate.HeaderText = "Purchase Date";
            }
            else if (VoucherType == VoucherTypes.SaleInvoiceVoucher.ToString())
            {
                colDate.HeaderText = "Sale Date";
            }
            else if (VoucherType == VoucherTypes.SalesReturnVoucher.ToString())
            {
                colDate.HeaderText = "SalesReturn Date";
            }
            else if (VoucherType ==  VoucherTypes.BankReceiptVoucher.ToString())
            {
                colDate.HeaderText = "Recieved Date";
            }
            else if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
            {
                colDate.HeaderText = "Issue Date";
            }
            else if (VoucherType ==  VoucherTypes.JournalVoucher.ToString())
            {
                colDate.HeaderText = "JV Date";
            }
            colDate.Width = 150;
            colDate.Name = "colDate";
            colDate.DataPropertyName = "Date";
            this.dgvUnpostedVouchers.Columns.Add(colDate);


            DataGridViewTextBoxColumn colAccountNo = new DataGridViewTextBoxColumn();
            colAccountNo.HeaderText = "A/C";
            colAccountNo.Width = 100;
            colAccountNo.Name = "colPerson";
            colAccountNo.DataPropertyName = "AccountNo";
            this.dgvUnpostedVouchers.Columns.Add(colAccountNo);

            DataGridViewTextBoxColumn colAccountName = new DataGridViewTextBoxColumn();
            if (VoucherType == VoucherTypes.CashReceiptVoucher.ToString())
            {
                colAccountName.HeaderText = "Customer";
            }
            else if (VoucherType == VoucherTypes.PaymentVoucher.ToString())
            {
                colAccountName.HeaderText = "Suppliers";
            }
            else if (VoucherType == VoucherTypes.StockReceiptVoucher.ToString())
            {
                colAccountName.HeaderText = "Suppliers";
            }
            else if (VoucherType == VoucherTypes.SaleInvoiceVoucher.ToString())
            {
                colAccountName.HeaderText = "Customers";
            }
            else if (VoucherType == VoucherTypes.SalesReturnVoucher.ToString())
            {
                colAccountName.HeaderText = "Customers";
            }
            else if (VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
            {
                colAccountName.HeaderText = "Customers";
            }
            else if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
            {
                colAccountName.HeaderText = "Suppliers";
            }
            colAccountName.Width = 250;
            colAccountName.HeaderText = "AccountName";
            colAccountName.Name = "colAccountName";
            colAccountName.DataPropertyName = "PersonName";
            this.dgvUnpostedVouchers.Columns.Add(colAccountName);

            DataGridViewTextBoxColumn colAmount = new DataGridViewTextBoxColumn();
            colAmount.HeaderText = "Amount";
            colAmount.Name = "colAmount";
            colAmount.DataPropertyName = "Amount";
            this.dgvUnpostedVouchers.Columns.Add(colAmount);


            DataGridViewButtonColumn colPost = new DataGridViewButtonColumn();
            colPost.HeaderText = ".";
            colPost.Name = "colPost";
            //colPost.DataPropertyName = "Amount";
            this.dgvUnpostedVouchers.Columns.Add(colPost);

        }
        private void ShowHideRows()
        {
            if (VoucherType ==  VoucherTypes.JournalVoucher.ToString())
            {
                dgvUnpostedVouchers.Columns[2].Visible = false;
                dgvUnpostedVouchers.Columns[3].Visible = false;
            }
            else
            {
                dgvUnpostedVouchers.Columns[2].Visible = false;
                dgvUnpostedVouchers.Columns[3].Visible = false;
            }
        }
        //private void rdPurchaseVouchers_CheckedChanged(object sender, System.EventArgs e)
        //{
        //    rdJournalVoucher.Checked = false;
        //    CreateBindVoucherWiseColumns("StockReceiptVoucher");
        //    //dgvUnpostedVouchers.Columns[3].Visible = false;
        //    FillVouchers("StockReceiptVoucher");
        //    VoucherType = "StockReceiptVoucher";
        //}

        //private void rdSaleVouchers_CheckedChanged(object sender, System.EventArgs e)
        //{
        //    rdJournalVoucher.Checked = false;
        //    CreateBindVoucherWiseColumns("SaleInvoiceVoucher");
        //    //dgvUnpostedVouchers.Columns[3].Visible = false;
        //    FillVouchers("SaleInvoiceVoucher");
        //    VoucherType = "SaleInvoiceVoucher";
        //}
        //private void rdSalesReturnVouchers_CheckedChanged(object sender, System.EventArgs e)
        //{
        //    rdJournalVoucher.Checked = false;
        //    CreateBindVoucherWiseColumns("SalesReturnVoucher");
        //    //dgvUnpostedVouchers.Columns[3].Visible = false;
        //    FillVouchers("SalesReturnVoucher");
        //    VoucherType = "SalesReturnVoucher";
        //}
        //private void rdCashVouchers_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdCashVouchers.Checked)
        //    {
        //        rdJournalVoucher.Checked = false;
        //        rdPaymentVouchers.Checked = false;
        //        CreateBindVoucherWiseColumns("CashReceiptVoucher");
        //        //dgvUnpostedVouchers.Columns[3].Visible = false;
        //        FillVouchers("CashReceiptVoucher");
        //        VoucherType = "CashReceiptVoucher";
        //    }
        //}

        //private void rdPaymentVouchers_CheckedChanged(object sender, EventArgs e)
        //{
        //    if (rdPaymentVouchers.Checked)
        //    {
        //        rdJournalVoucher.Checked = false;
        //        rdCashVouchers.Checked = false;
        //        CreateBindVoucherWiseColumns("PaymentVoucher");
        //        //dgvUnpostedVouchers.Columns[3].Visible = false;
        //        FillVouchers("PaymentVoucher");
        //        VoucherType = "PaymentVoucher";
        //    }
        //}
        //private void rdBankReceiptVoucher_Click(object sender, System.EventArgs e)
        //{
        //    if (rdBankReceiptVoucher.Checked)
        //    {
        //        rdJournalVoucher.Checked = false;
        //        CreateBindVoucherWiseColumns("BankReceiptVoucher");
        //        //dgvUnpostedVouchers.Columns[3].Visible = false;
        //        FillVouchers("BankReceiptVoucher");
        //        VoucherType = "BankReceiptVoucher";
        //    }
        //}

        //private void rdBankPaymentVoucher_CheckedChanged(object sender, System.EventArgs e)
        //{
        //    if (rdBankPaymentVoucher.Checked)
        //    {
        //        rdJournalVoucher.Checked = false;
        //        CreateBindVoucherWiseColumns("BankPaymentVoucher");
        //        //dgvUnpostedVouchers.Columns[3].Visible = false;
        //        FillVouchers("BankPaymentVoucher");
        //        VoucherType = "BankPaymentVoucher";
        //    }
        //}

        //private void rdJournalVoucher_CheckedChanged(object sender, System.EventArgs e)
        //{
        //    if (rdJournalVoucher.Checked)
        //    {
        //        rdSalesReturnVouchers.Checked = false;
        //        rdSaleVouchers.Checked = false;
        //        rdPurchaseVouchers.Checked = false;
        //        rdPaymentVouchers.Checked = false;
        //        rdCashVouchers.Checked = false;
        //        rdBankPaymentVoucher.Checked = false;
        //        rdBankReceiptVoucher.Checked = false;
        //        CreateBindVoucherWiseColumns("JournalVoucher");
        //        //dgvUnpostedVouchers.Columns[3].Visible = false;
        //        FillVouchers("JournalVoucher");
        //        VoucherType = "JournalVoucher";
        //    }
        //}
        private void FillVouchers()
        {
            var Manager = new VoucherBLL();
            List<VouchersEL> list = Manager.GetUnPostedVouchers(Operations.IdCompany, VoucherType);
            if (dgvUnpostedVouchers.Rows.Count > 0)
            {
                dgvUnpostedVouchers.Rows.Clear();
            }

            for (int i = 0; i < list.Count; i++)
            {
                dgvUnpostedVouchers.Rows.Add();
                dgvUnpostedVouchers.Rows[i].Cells[0].Value = list[i].VoucherNo;
                dgvUnpostedVouchers.Rows[i].Cells[1].Value = list[i].Date.ToShortDateString();
                if (VoucherType != VoucherTypes.JournalVoucher.ToString())
                {
                    dgvUnpostedVouchers.Rows[i].Cells[2].Value = list[i].AccountNo;
                    dgvUnpostedVouchers.Rows[i].Cells[3].Value = list[i].PersonName;
                }
                if (VoucherType == VoucherTypes.BankPaymentVoucher.ToString())
                {
                    //dgvUnpostedVouchers.Rows[i].Cells[3].Value = list[i].ChequeNo;
                }
                else if (VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
                {
                    //dgvUnpostedVouchers.Rows[i].Cells[3].Value = list[i].ChequeNo;
                }
                dgvUnpostedVouchers.Rows[i].Cells[4].Value = list[i].Amount;
                ShowHideRows();
            }

        }

        private void dgvUnpostedVouchers_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                try
                {
                    if (MessageBox.Show("Post ?", "Posting...", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        var Manager = new VoucherBLL();
                        Int64 VoucherNo = Convert.ToInt64(dgvUnpostedVouchers.Rows[e.RowIndex].Cells[0].Value);
                        EntityoperationInfo ResultInfo = Manager.PostUnPostedVouchers(VoucherType, VoucherNo, Operations.IdCompany);
                        if (ResultInfo.IsSuccess)
                        {
                            dgvUnpostedVouchers.Rows[e.RowIndex].Visible = false;
                            MessageBox.Show("Posted");
                        }
                        else
                        {
                            MessageBox.Show("Problem Occured While Posting voucher...");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Problem Occured While Posting voucher...");
                }
            }
        }

        private void dgvUnpostedVouchers_CellFormatting(object sender, System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.Value = "Post";
            }
        }
        private void btnUnposted_Click(object sender, System.EventArgs e)
        {
            MetroTile tileButton = sender as MetroTile;
            if (tileButton.Text == "Cash Receipt")
            {
                VoucherType = VoucherTypes.CashReceiptVoucher.ToString();
            }
            else if (tileButton.Text == "Cash Payment")
            {
                VoucherType = VoucherTypes.PaymentVoucher.ToString();
            }
            else if (tileButton.Text == "Bank Receipt")
            {
                VoucherType = VoucherTypes.BankReceiptVoucher.ToString();
            }
            else if (tileButton.Text == "Bank Payment")
            {
                VoucherType = VoucherTypes.BankPaymentVoucher.ToString();
            }
            else if (tileButton.Text == "Sales")
            {
                VoucherType = VoucherTypes.SaleInvoiceVoucher.ToString();
            }
            else if (tileButton.Text == "Returns")
            {
                VoucherType = VoucherTypes.SalesReturnVoucher.ToString();
            }
            else if (tileButton.Text == "Purchases")
            {
                VoucherType = VoucherTypes.StockReceiptVoucher.ToString();
            }
            else if (tileButton.Text == "Journals")
            {
                VoucherType = VoucherTypes.JournalVoucher.ToString();
            }
            lblVoucherName.Text = tileButton.Text;
            CreateBindVoucherWiseColumns();
            FillVouchers();
            
        }
    }
}
