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
using System.Collections;
using SpreadsheetLight;
using System.Diagnostics;

namespace Accounts.UI
{
    public partial class frmCustomerWiseProductsProfitAndLoss : MetroForm
    {
        #region 
        frmFindAccounts frmfind;
        DataTable dtRecords;
        string AccountNo = string.Empty;
        #endregion
        public frmCustomerWiseProductsProfitAndLoss()
        {
            InitializeComponent();
        }
        private void frmCustomerWiseProductsProfitAndLoss_Load(object sender, EventArgs e)
        {
            this.grdAllProductsProfitLossWithCustomer.AutoGenerateColumns = false;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new IncomeBLL();
            List<TransactionsEL> list = null;
            if (chkExcludeDate.Checked)
            {
                list = manager.GetCustomerWiseAllItemsProfitAndLoss(Operations.IdProject, Operations.BookNo, AccountNo);
            }
            else
            {
                list = manager.GetCustomerWiseAllItemsProfitAndLossByDate(Operations.IdProject, Operations.BookNo, AccountNo, dtStart.Value, dtEnd.Value);
            }
            if (list.Count > 0)
            {
                grdAllProductsProfitLossWithCustomer.DataSource = list;
            }
            else
            {
                grdAllProductsProfitLossWithCustomer.DataSource = null;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdAllProductsProfitLossWithCustomer.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdAllProductsProfitLossWithCustomer.Columns)
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
                for (int i = 0; i < grdAllProductsProfitLossWithCustomer.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdAllProductsProfitLossWithCustomer.Rows)
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
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
                frmfind = new frmFindAccounts();
                frmfind.SearchText = e.KeyChar.ToString();
                frmfind.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmfind_ExecuteFindAccountEvent);
                frmfind.ShowDialog();

            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtSearch.Text != string.Empty)
                {
                    btnLoad.Focus();
                }
            }
            else
                e.Handled = false;
        }
        void frmfind_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            AccountNo = oelAccount.AccountNo;
            txtSearch.Text = oelAccount.AccountName;
        }
        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            frmfind = new frmFindAccounts();
            frmfind.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmfind_ExecuteFindAccountEvent);
            frmfind.ShowDialog();
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtRecords);
            DV.RowFilter = string.Format("ItemName LIKE '%{0}%'", txtFilter.Text);
            grdAllProductsProfitLossWithCustomer.DataSource = DV;
        }
    }
}
