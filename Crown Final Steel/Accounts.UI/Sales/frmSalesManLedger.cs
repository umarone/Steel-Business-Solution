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
using Accounts.EL;

using MetroFramework.Forms;
using SpreadsheetLight;
using System.Diagnostics;

namespace Accounts.UI
{
    public partial class frmSalesManLedger : MetroForm
    {
        public frmSalesManLedger()
        {
            InitializeComponent();
        }

        private void frmSalesManLedger_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.grdTotalTransactions.AutoGenerateColumns = false;
            //this.grdTotalTransactions.Columns[2].Visible = false;
            FillEmployees();
        }
        private void FillEmployees()
        {
            var manager = new AccountsBLL();
            List<AccountsEL> listAccounts = manager.GetEmployeesAccounts(Operations.IdCompany);

            cbxEmployees.DataSource = listAccounts;
            cbxEmployees.DisplayMember = "AccountName";
            cbxEmployees.ValueMember = "AccountNo";
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new TransactionBLL();
            List<TransactionsEL> listTransactions = new List<TransactionsEL>();
            if (chkDate.Checked)
            {
                listTransactions = manager.GetDateWiseEmployeesTransactions(Operations.IdCompany, Validation.GetSafeString(cbxEmployees.SelectedValue), Convert.ToDateTime(StartDate.Value.ToShortDateString()), Convert.ToDateTime(EndDate.Value.ToShortDateString()));
                 PopulateTransactions(listTransactions);
            }
            else
            {
                listTransactions = manager.GetEmployeesTransactions(Operations.IdCompany, Validation.GetSafeString(cbxEmployees.SelectedValue));
                PopulateTransactions(listTransactions);
            }
        }
        private void PopulateTransactions(List<TransactionsEL> list)
        {
            if(list.Count > 0)
            {
               grdTotalTransactions.DataSource = null;
         
                //if(chkDate.Checked == false)
               //list.RemoveAll(x => x.ClosingBalance == 0);
               list.RemoveAll(x => x.OpeningBalance == 0 && x.TotalSales == 0 && x.TotalRecieveables == 0);  
               grdTotalTransactions.DataSource = list;
            }
        }
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            if (grdTotalTransactions.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdTotalTransactions.Columns)
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
                for (int i = 0; i < grdTotalTransactions.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdTotalTransactions.Rows)
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

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            grdTotalTransactions.DataSource = null;
            if (chkDate.Checked)
            {
                StartDate.Enabled = true;
                EndDate.Enabled = true;
                //this.grdTotalTransactions.Columns[2].Visible = true;
            }
            else
            {
                StartDate.Enabled = false;
                EndDate.Enabled = false;
                //this.grdTotalTransactions.Columns[2].Visible = false;
            }
        }
    }
}
