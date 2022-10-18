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
    public partial class frmCustomersWiseDetailedDiscountSummary : MetroForm
    {
        #region Variables
        public string AccountNo = "";
        public string AccountName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        #endregion
        public frmCustomersWiseDetailedDiscountSummary()
        {
            InitializeComponent();
        }
        private void frmCustomersWiseDetailedDiscountSummary_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var manager = new SalesDetailBLL();
            List<TransactionsEL> list = manager.GetCustomersDetailDiscountSummaryByDate(Operations.IdProject, Operations.BookNo, AccountNo, StartDate, EndDate);
            if (list.Count > 0)
            {
                grdDiscountDetail.DataSource = list;
                lblDetail.Text = "Customer Name :" + AccountName + "(Summary From :" + StartDate + " To :" + EndDate + " :)";
            }
            else
            {
                grdDiscountDetail.DataSource = null;
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
    }
}
