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
using SpreadsheetLight;
using System.Diagnostics;

using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmAllProductsInOutWithAvg : MetroForm
    {
        #region Variables
        DataTable dtProducts;
        #endregion
        #region Form Methods And Events
        public frmAllProductsInOutWithAvg()
        {
            InitializeComponent();
        }
        private void frmAllProductsInOutWithAvg_Load(object sender, EventArgs e)
        {
            this.grdAllProducts.AutoGenerateColumns = false;
        }
        #endregion
        #region Win Controls Methods And Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new StockRecieptBLL();
            List<StockReceiptEL> list = null;
            if (chkExcludeDate.Checked)
            {
                list = manager.AllProductsInOutWithAvgValue(Operations.IdProject, Operations.BookNo);
            }
            else
            {
                list = manager.AllProductsInOutWithAvgValueByDate(Operations.IdProject, Operations.BookNo, dtStart.Value, dtEnd.Value);
            }
            if (list.Count > 0)
            {
                dtProducts = DataOperations.ToDataTable(list);
                grdAllProducts.DataSource = dtProducts;
            }
            else
            {
                MessageBox.Show("No Record Found....");
                grdAllProducts.DataSource = null;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdAllProducts.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdAllProducts.Columns)
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
                for (int i = 0; i < grdAllProducts.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdAllProducts.Rows)
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
            else
            {
                MessageBox.Show("No Record Found...");
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtProducts);
            DV.RowFilter = string.Format("ItemName LIKE '%{0}%'", txtFilter.Text);
            grdAllProducts.DataSource = DV;
        }
        #endregion
    }
}
