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
    public partial class frmMonthlySalesReport : MetroForm
    {
        DataTable dt;
        public frmMonthlySalesReport()
        {
            InitializeComponent();
        }

        private void frmMonthlySalesReport_Load(object sender, EventArgs e)
        {
            this.grdTotalSales.AutoGenerateColumns = false;
        }
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new SalesHeadBLL();
            List<VouchersEL> list = manager.GetDateWiseSalesReport(Operations.IdProject, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                PopulateSales(list);
                txtAmount.Text = list.Sum(x => x.TotalAmount).ToString();
                txtTotalSales.Text = list.Sum(x => x.TotalSales).ToString();
                txtotalPersons.Text = list.Count().ToString();
            }
            else
                grdTotalSales.DataSource = null;
        }
        private void PopulateSales(List<VouchersEL> list)
        {
            dt = new DataTable();
            ////if (lstStock.Count > 0)
            ////{
            ////    grdTotalStock.DataSource = lstStock;                
            ////}
            dt.Columns.Clear();
            dt.Rows.Clear();
            dt.Clear();
            dt.Columns.Add("AccountName");
            dt.Columns.Add("TotalSales");
            dt.Columns.Add("TotalAmount");


            for (int i = 0; i < list.Count; i++)
            {
                // Add rows.
                DataRow dr = dt.NewRow();
                dr[0] = list[i].AccountName;
                dr[1] = list[i].TotalSales;
                dr[2] = list[i].TotalAmount;

                dt.Rows.Add(dr);
            }
            if (dt.Rows.Count > 0)
            {
                grdTotalSales.DataSource = dt;
            }
            else
            {
                grdTotalSales.DataSource = null;
            }
        }
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("AccountName LIKE '%{0}%'", txtsearch.Text);
            grdTotalSales.DataSource = DV;
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
