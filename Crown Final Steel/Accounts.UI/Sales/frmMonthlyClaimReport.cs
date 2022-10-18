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
    public partial class frmMonthlyClaimReport : MetroForm
    {
        DataTable dt;
        frmMonthlyClaimedVouchers frmmonthlyClaimedVouchers = null;
        public frmMonthlyClaimReport()
        {
            InitializeComponent();
        }
        private void frmMonthlyClaimReport_Load(object sender, EventArgs e)
        {
            this.grdTotalClaims.AutoGenerateColumns = false;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new SalesHeadBLL();
            List<VouchersEL> list = manager.GetDateWiseClaimReturnReport(Operations.IdProject, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                PopulateClaimsReturn(list);
                txtAmount.Text = list.Sum(x => x.TotalAmount).ToString();
                txtTotalClaims.Text = list.Sum(x => x.TotalSalesReturn).ToString();
                txtotalPersons.Text = list.Count().ToString();
            }
            else
                grdTotalClaims.DataSource = null;
        }
        private void PopulateClaimsReturn(List<VouchersEL> list)
        {
            dt = new DataTable();
            ////if (lstStock.Count > 0)
            ////{
            ////    grdTotalStock.DataSource = lstStock;                
            ////}
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Clear();
            dt.Columns.Add("AccountNo");
            dt.Columns.Add("AccountName");
            dt.Columns.Add("TotalSalesReturn");
            dt.Columns.Add("TotalAmount");


            for (int i = 0; i < list.Count; i++)
            {
                // Add rows.
                DataRow dr = dt.NewRow();
                dr[0] = list[i].AccountNo;
                dr[1] = list[i].AccountName;
                dr[2] = list[i].TotalSalesReturn;
                dr[3] = list[i].TotalAmount;

                dt.Rows.Add(dr);
            }
            if (dt.Rows.Count > 0)
            {
                grdTotalClaims.DataSource = dt;
            }
            else
            {
                grdTotalClaims.DataSource = null;
            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtsearch.Text);
            grdTotalClaims.DataSource = DV;
        }
        private void grdTotalClaims_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = "View Detail";
            }
        }
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            if (grdTotalClaims.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdTotalClaims.Columns)
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
                for (int i = 0; i < grdTotalClaims.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdTotalClaims.Rows)
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
        private void grdTotalClaims_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                frmmonthlyClaimedVouchers = new frmMonthlyClaimedVouchers();
                frmmonthlyClaimedVouchers.AccountNo = Validation.GetSafeString(grdTotalClaims.Rows[e.RowIndex].Cells["colAccountNo"].Value);
                frmmonthlyClaimedVouchers.ShowDialog();
            }
        }
    }
}
