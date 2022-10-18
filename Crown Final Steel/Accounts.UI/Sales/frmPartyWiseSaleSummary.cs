using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;

using Accounts.BLL;
using Accounts.EL;
using Accounts.Common;
using SpreadsheetLight;
using System.Diagnostics;

namespace Accounts.UI
{
    public partial class frmPartyWiseSaleSummary : MetroForm
    {
        frmFindAccounts frmAccount;
        string EventCommandName = string.Empty;
        string EmpAccountNo = string.Empty, EmpDeliveryAccountNo = string.Empty;
        public frmPartyWiseSaleSummary()
        {
            InitializeComponent();
        }
        private void frmPartyWiseSaleSummary_Load(object sender, EventArgs e)
        {
            this.grdTotalSales.AutoGenerateColumns = false;
        }
        private void EmpEditCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            MetroFramework.Controls.MetroTextBox txt = sender as MetroFramework.Controls.MetroTextBox;
            if (e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Tab)
            {
                if (txt.Name == "EmpEditCode")
                {
                    txtDeliveryPerson.Focus();
                }
            }
            else if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                EventCommandName = "Employees";
                e.Handled = true;
                frmAccount = new frmFindAccounts();
                frmAccount.SearchText = e.KeyChar.ToString();
                frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                frmAccount.ShowDialog();

            }
            else
                e.Handled = false;
        }
        private void txtDeliveryPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                EventCommandName = "DeliveryPerson";
                e.Handled = true;
                frmAccount = new frmFindAccounts();
                frmAccount.SearchText = e.KeyChar.ToString();
                frmAccount.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmAccount_ExecuteFindAccountEvent);
                frmAccount.ShowDialog();

            }
            else
                e.Handled = false;
        }
        void frmAccount_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            if (EventCommandName == "Employees")
            {
                EmpEditCode.Text = oelAccount.AccountName;
                EmpAccountNo = oelAccount.AccountNo;
            }
            else if (EventCommandName == "DeliveryPerson")
            {
                EmpDeliveryAccountNo = oelAccount.AccountNo;
                txtDeliveryPerson.Text = oelAccount.AccountName;
            }
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new SalesDetailBLL();
            List<SaleDetailEL> list = null;
            if(!chkIgnore.Checked)
                list = manager.GetPartyWiseSaleSummary(Operations.IdProject, Operations.BookNo, EmpAccountNo, EmpDeliveryAccountNo, dtStart.Value, dtEnd.Value);
            else
                list = manager.GetPartyWiseSaleSummaryWithoutEmps(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);

            if (list.Count > 0)
            {
                grdTotalSales.DataSource = list;
                lblDiscount.Text = list.Sum(x => x.Discount).ToString();
                lblTotalAmount.Text = list.Sum(x => x.Amount).ToString();
                lblNetAmount.Text = list.Sum(x => x.DiscountAmount).ToString();
            }
            else
            {
                grdTotalSales.DataSource = null;
                lblDiscount.Text = "0";
                lblNetAmount.Text = "0";
                lblTotalAmount.Text = "0";
            }
        }
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            if (grdTotalSales.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdTotalSales.Columns)
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
                for (int i = 0; i < grdTotalSales.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdTotalSales.Rows)
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
    }
}
