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
using MetroFramework.Forms;
using MetroFramework.Controls;
using Accounts.Common;
using SpreadsheetLight;
using System.Diagnostics;

namespace Accounts.UI
{
    public partial class frmSubHeadExpenses : MetroForm
    {
        #region Variables
        frmSubHeadExpensesDetail frmdetailedExpense;
        #endregion
        #region Form Methods And Events
        public frmSubHeadExpenses()
        {
            InitializeComponent();
        }
        private void frmSubHeadExpenses_Load(object sender, EventArgs e)
        {
            this.grdExpenses.AutoGenerateColumns = false;
        }
        private void frmSubHeadExpenses_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
        #region Button Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var Manager = new TransactionBLL();
            string AccountType = string.Empty;
            List<TransactionsEL> list = new List<TransactionsEL>();
            if (!chkDirectExpense.Checked && !chkIndirectExpenses.Checked)
            {
                MessageBox.Show("Please Select Direct OR InDirect Expense");
                return;
            }
            else
            {
                if (chkDirectExpense.Checked)
                {
                    AccountType = "Direct Expenses";
                }
                else
                    AccountType = "InDirect Expenses";
                if (chkIgnore.Checked)
                {
                    list = Manager.GetSubHeadWiseExpenseReport(Operations.IdProject, Operations.BookNo,AccountType);
                }
                else
                {
                    list = Manager.GetDateWiseSubHeadWiseExpenseReport(Operations.IdProject, Operations.BookNo, AccountType, dtStart.Value, dtEnd.Value);
                }
                if (list.Count > 0)
                {
                    grdExpenses.DataSource = list;
                    lblTotal.Text = "Total Amount : " + list.Sum(x => x.Amount).ToString();
                }
                else
                {
                    grdExpenses.DataSource = null;
                }
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdExpenses.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdExpenses.Columns)
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
                for (int i = 0; i < grdExpenses.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdExpenses.Rows)
                {
                    dt.Rows.Add();
                    int colindex = 0;
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Visible)
                            {
                                //dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value.ToString();
                                dt.Rows[dt.Rows.Count - 1][colindex] = cell.Value.ToString();
                                colindex++;
                            }
                        }
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
        #endregion
        #region CheckBoxes Events
        private void chkDirectExpense_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDirectExpense.Checked)
            {
                chkIndirectExpenses.Checked = false;
                grdExpenses.DataSource = null;
            }
        }
        private void chkIndirectExpenses_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIndirectExpenses.Checked)
            {
                chkDirectExpense.Checked = false;
                grdExpenses.DataSource = null;
            }
        }
        #endregion
        #region Grid Events
        private void grdExpenses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                Int32 ParentId = Validation.GetSafeInteger(grdExpenses.Rows[e.RowIndex].Cells[0].Value);
                string AccountType = string.Empty;
                frmdetailedExpense = new frmSubHeadExpensesDetail();
                frmdetailedExpense.IdAccount = ParentId;
                frmdetailedExpense.StartDate = dtStart.Value;
                frmdetailedExpense.EndDate = dtEnd.Value;
                 if (chkDirectExpense.Checked)
                {
                    frmdetailedExpense.AccountType = "Direct Expenses";
                }
                else
                     frmdetailedExpense.AccountType = "InDirect Expenses";                
                if (chkIgnore.Checked)
                {
                    frmdetailedExpense.chkIgnore = true;
                }
                else
                    frmdetailedExpense.chkIgnore = false;
                frmdetailedExpense.ShowDialog();
            }
        }
        private void grdExpenses_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = "View Detail";
            }
        }
        #endregion        
    }
}
