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
    public partial class frmRecoveryReport : MetroForm
    {
        frmFindAccounts frmfindAccounts;
        string AccountNo = string.Empty;
        public frmRecoveryReport()
        {
            InitializeComponent();
        }

        private void frmRecoveryReport_Load(object sender, EventArgs e)
        {
            grdRecovery.AutoGenerateColumns = false;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            var Manager = new TransactionBLL();
            if (!chkAllCustomers.Checked)
            {
                if (!chkDate.Checked)
                {
                    list = Manager.GetCustomerRecoveryReport(Operations.IdProject, Operations.BookNo, AccountNo);
                }
                else
                {
                    list = Manager.GetCustomerRecoveryReportByDate(Operations.IdProject, Operations.BookNo, AccountNo, dtStart.Value, dtEnd.Value);
                }
            }
            else
            {
                if (!chkDate.Checked)
                {
                    list = Manager.GetAllCustomersRecoveryReport(Operations.IdProject, Operations.BookNo);
                }
                else
                {
                    list = Manager.GetAllCustomersByRecoveryReportByDate(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
                }
            }
            if (list.Count > 0)
            {
                txtTotalRecovery.Text = Validation.GetSafeString(list.Sum(x => x.Credit));
                grdRecovery.DataSource = list;
            }
            else
            {
                MessageBox.Show("No Record Found....");
                txtTotalRecovery.Text = string.Empty;
                grdRecovery.DataSource = null;
            }
        }

        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked)
            {
                dtStart.Enabled = true;
                dtEnd.Enabled = true;
            }
            else
            {
                dtStart.Enabled = false;
                dtEnd.Enabled = false;
            }
        }

        private void AccEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmfindAccounts = new frmFindAccounts();
            frmfindAccounts.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmfindAccounts_ExecuteFindAccountEvent);
            frmfindAccounts.ShowDialog();
        }

        void frmfindAccounts_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            AccountNo = oelAccount.AccountNo;
            AccEditBox.Text = oelAccount.AccountName;
           //txtAccountName.Text = oelAccount.AccountName;
        }

        private void grdRecovery_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdRecovery.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdRecovery.Columns)
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
                for (int i = 0; i < grdRecovery.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdRecovery.Rows)
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

        private void chkAllCustomers_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllCustomers.Checked)
            {
                AccEditBox.Enabled = false;
                grdRecovery.Columns[2].Visible = false;
                grdRecovery.Columns[3].Visible = false;
                grdRecovery.DataSource = null;
            }
            else
            {
                AccEditBox.Enabled = true;
                grdRecovery.Columns[2].Visible = true;
                grdRecovery.Columns[3].Visible = true;
                grdRecovery.DataSource = null;
            }
        }
    }
}
