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
    public partial class frmSubHeadExpensesDetail : MetroForm
    {
        #region Variables
        public Int64 IdAccount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool chkIgnore { get; set; }
        public string AccountType { get; set; }
        DataTable dt;
        #endregion
        #region Form Methods And Events
        public frmSubHeadExpensesDetail()
        {
            InitializeComponent();
        }
        private void frmSubHeadExpensesDetail_Load(object sender, EventArgs e)
        {
            grdExpensesdetails.AutoGenerateColumns = false;
            if (chkIgnore)
            {
                this.Text = "Expense Detail";
            }
            else
            {
                this.Text = "Expense Detail From ('" + StartDate.ToShortDateString() + "' To '" + EndDate.ToShortDateString() + "')";
            }
            LoadData();
        }
        private void frmSubHeadExpensesDetail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void LoadData()
        {
            var manager = new TransactionBLL();
            List<TransactionsEL> list = new List<TransactionsEL>();
            if (chkIgnore)
            {
                list = manager.GetSubHeadWiseDetailExpenseReport(IdAccount, Operations.IdProject, Operations.BookNo, AccountType);
            }
            else
            {
                list = manager.GetDateWiseSubHeadWiseDetailExpenseReport(IdAccount, Operations.IdProject, Operations.BookNo, StartDate, EndDate, AccountType);
            }
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                grdExpensesdetails.DataSource = dt;
                lblTotal.Text = "Total Amount : " + list.Sum(x => x.Amount).ToString();
            }
            else
            {
                grdExpensesdetails.DataSource = null;
            }
        }
        #endregion
        #region Win Controls Events
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdExpensesdetails.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdExpensesdetails.Columns)
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
                for (int i = 0; i < grdExpensesdetails.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdExpensesdetails.Rows)
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
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtSearch.Text);
            grdExpensesdetails.DataSource = DV;
        }
        #endregion
    }
}
