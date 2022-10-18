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
using SpreadsheetLight;
using System.Diagnostics;

namespace Accounts.UI
{
    public partial class frmDatedCashPaidExpense : MetroForm
    {
        #region Variables
        frmFindAccounts frmFindAccounts;
        string AccountNo = string.Empty;
        TextBox txtPaymentTotal = new TextBox();
        DataTable dtPayments;
        #endregion
        #region Form Methods And Events
        public frmDatedCashPaidExpense()
        {
            InitializeComponent();
        }
        private void frmDatedCashPaidExpense_Load(object sender, EventArgs e)
        {
            this.grdPayments.AutoGenerateColumns = false;
            CreateAndInitializeFooterRow();
        }
        private void frmDatedCashPaidExpense_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void CreateAndInitializeFooterRow()
        {
            txtPaymentTotal.Enabled = false;
           
            txtPaymentTotal.TextAlign = HorizontalAlignment.Center;
           
          
            int Xdgvx1 = this.grdPayments.GetCellDisplayRectangle(1, -1, true).Location.X;


            txtPaymentTotal.Width = this.grdPayments.Columns[1].Width;

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
            List<TransactionsEL> list = manager.GetCashPaidExpenseByDate(Operations.IdProject, Operations.BookNo, AccountNo, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                if (list.Count > 0)
                {
                    dtPayments = DataOperations.ToDataTable(list);
                    grdPayments.DataSource = dtPayments;
                    txtPaymentTotal.Text = list.Sum(x => x.TotalAmount).ToString();
                }
                else
                {
                    grdPayments.DataSource = null;
                    txtPaymentTotal.Text = string.Empty;
                    dtPayments = null;
                }
            }
            else
            {
                MessageBox.Show("No Record Found..");
                grdPayments.DataSource = null;
                txtPaymentTotal.Text = string.Empty;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdPayments.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdPayments.Columns)
                {
                    if (column.Visible)
                    {
                        dt.Columns.Add(column.HeaderText);
                    }
                }

                //Add Header Rows....
                dt.Rows.Add();
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    dt.Rows[0][i] = dt.Columns[i].ColumnName; //"Account Name"; 
                }

                // Add Empty Row....
                dt.Rows.Add();
                for (int i = 0; i < grdPayments.Columns.Count; i++)
                {
                    if (i != dt.Columns.Count)
                    {
                        dt.Rows[1][i] = "";
                    }
                    else
                    {
                        break;
                    }
                }

                foreach (DataGridViewRow row in grdPayments.Rows)
                {
                    dt.Rows.Add();
                    int colindex = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        //if (cell.Value != null)
                        //{
                        if (cell.Visible)
                        {
                            //dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                            dt.Rows[dt.Rows.Count - 1][colindex] = cell.Value ?? 0.ToString();
                            colindex++;
                        }
                        //}
                    }
                }

                SLDocument slExcelExport = new SLDocument();


                for (int i = 0; i < dt.Columns.Count; i++)
                {

                    slExcelExport.SetColumnWidth(i, 20);
                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        slExcelExport.SetCellValue(j + 1, i + 1, dt.Rows[j].ItemArray[i].ToString());
                    }
                }
                slExcelExport.Save();

                Process.Start("Book1.xlsx");
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtPayments);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtFilter.Text);
            grdPayments.DataSource = DV;
        }
        #endregion
    }
}
