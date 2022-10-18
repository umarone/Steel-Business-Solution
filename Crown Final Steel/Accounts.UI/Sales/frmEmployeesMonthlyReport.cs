using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using Accounts.Common;
using Accounts.EL;
using Accounts.BLL;
using SpreadsheetLight;
using System.Diagnostics;
namespace Accounts.UI
{
    public partial class frmEmployeesMonthlyReport : MetroForm
    {
        #region Variables
        string AccountNo;
        frmFindAccounts frmFindAccounts;
        #endregion
        #region Form Events And Methods
        public frmEmployeesMonthlyReport()
        {
            InitializeComponent();
        }
        private void frmEmployeesMonthlyReport_Load(object sender, EventArgs e)
        {
            this.grdReports.AutoGenerateColumns = false;
        }
        #endregion
        #region Misc Events And Methods
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new SalesDetailBLL();
            int EmpType = 0;
            if (cbxEmpType.Text == "Order Booker")
            {
                EmpType = 1;
            }
            else if (cbxEmpType.Text == "Supply Man")
            {
                EmpType = 2;
            }

            List<SaleDetailEL> list = manager.GetEmployeesMonthlyPerformanceReport(Operations.IdProject, Operations.BookNo, EmpType, AccountNo, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                grdReports.DataSource = list;
                txtUnits.Text = list.Sum(x => x.Qty).ToString();
                txtAmount.Text = list.Sum(x => x.Amount).ToString();
                txtReturnAmount.Text = list.Sum(x => x.NetSaleReturnAmount).ToString();
                txtDiscount.Text = (Validation.GetSafeDecimal(list.Sum(x => x.Amount)) - Validation.GetSafeDecimal(list.Sum(x => x.DiscountAmount))).ToString();
                txtDiscount2.Text = list.Sum(x => x.TotalDiscount).ToString(); //(Validation.GetSafeDecimal(list.Sum(x => x.DiscountAmount)) - Validation.GetSafeDecimal(list.Sum(x => x.NetSaleAmount))).ToString();
                txtNetAmount.Text = list.Sum(x => x.NetSaleAmount).ToString();
            }
            else
            {
                grdReports.DataSource = null;
                txtUnits.Text = string.Empty;
                txtAmount.Text = string.Empty;
                txtReturnAmount.Text = string.Empty;
                txtDiscount.Text = string.Empty;
                txtDiscount2.Text = string.Empty;
                txtNetAmount.Text = string.Empty;
                MessageBox.Show("No Data Found...");
            }
        }
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            if (grdReports.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdReports.Columns)
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
                for (int i = 0; i < grdReports.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdReports.Rows)
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
        private void txtDeliveryPerson_ButtonClick(object sender, EventArgs e)
        {
            frmFindAccounts = new frmFindAccounts();
            frmFindAccounts.ExecuteFindAccountEvent += new UI.frmFindAccounts.FindAccountDelegate(frmFindAccounts_ExecuteFindAccountEvent);
            frmFindAccounts.ShowDialog();
        }
        void frmFindAccounts_ExecuteFindAccountEvent(object Sender, AccountsEL oelAccount)
        {
            AccountNo = oelAccount.AccountNo;
            txtDeliveryPerson.Text = oelAccount.AccountName;
        }
        private void txtDeliveryPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
                frmFindAccounts = new frmFindAccounts();
                frmFindAccounts.SearchText = e.KeyChar.ToString();
                frmFindAccounts.ExecuteFindAccountEvent += new frmFindAccounts.FindAccountDelegate(frmFindAccounts_ExecuteFindAccountEvent);
                frmFindAccounts.ShowDialog();
            }
            else
                e.Handled = false;
        }
        #endregion

        
    }
}
