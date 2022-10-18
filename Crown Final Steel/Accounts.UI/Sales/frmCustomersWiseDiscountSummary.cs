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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.Common;
using SpreadsheetLight;
using System.Diagnostics;

namespace Accounts.UI
{
    public partial class frmCustomersWiseDiscountSummary : MetroForm
    {
        #region Variables
        string AccountNo = "";
        DataTable dtCustomersDicount;
        frmCustomersWiseDetailedDiscountSummary frmdetailDiscountSummary;
        #endregion
        #region Form Methods
        public frmCustomersWiseDiscountSummary()
        {
            InitializeComponent();
        }
        private void frmCustomersWiseDiscountSummary_Load(object sender, EventArgs e)
        {
            this.grdDiscountDetail.AutoGenerateColumns = false;
        }
        #endregion
        #region Win Controls Methods and Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new SalesDetailBLL();
            List<TransactionsEL> list = manager.GetCustomersDiscountSummaryByDate(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                dtCustomersDicount = DataOperations.ToDataTable(list);
                grdDiscountDetail.DataSource = dtCustomersDicount;
            }
            else
            {
                MessageBox.Show("No Data Found....");
            }
        }
        private void grdDiscountDetail_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.Value = "View Detail....";
            }
        }
        private void grdDiscountDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                frmdetailDiscountSummary = new frmCustomersWiseDetailedDiscountSummary();
                AccountNo = Validation.GetSafeString(grdDiscountDetail.Rows[e.RowIndex].Cells["colAccountNo"].Value);
                frmdetailDiscountSummary.AccountNo = AccountNo;
                frmdetailDiscountSummary.AccountName = Validation.GetSafeString(grdDiscountDetail.Rows[e.RowIndex].Cells["colAccountName"].Value);
                frmdetailDiscountSummary.StartDate = dtStart.Value;
                frmdetailDiscountSummary.EndDate = dtEnd.Value;
                frmdetailDiscountSummary.ShowDialog();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdDiscountDetail.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdDiscountDetail.Columns)
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
                for (int i = 0; i < grdDiscountDetail.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdDiscountDetail.Rows)
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
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtCustomersDicount);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtsearch.Text);
            grdDiscountDetail.DataSource = DV;
        }
        #endregion
    }
}
