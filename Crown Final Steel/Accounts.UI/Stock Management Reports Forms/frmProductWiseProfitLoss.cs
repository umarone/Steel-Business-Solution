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
    public partial class frmProductWiseProfitLoss : MetroForm
    {
        #region Variables
        frmFindProducts frmfindProducts = null;
        Int64 IdItem;
        #endregion
        #region Form Methods And Events
        public frmProductWiseProfitLoss()
        {
            InitializeComponent();
        }
        private void frmProductWiseProfitLoss_Load(object sender, EventArgs e)
        {
            grdProductWisePofitLoss.AutoGenerateColumns = false;
        }
        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
                frmfindProducts = new frmFindProducts();
                frmfindProducts.SearchText = e.KeyChar.ToString();
                frmfindProducts.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindProducts_ExecuteFindPorudctsEvent);
                frmfindProducts.ShowDialog();

            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                if (txtSearch.Text != string.Empty)
                {
                    btnLoad.Focus();
                }
            }
            else
                e.Handled = false;
           
        }
        void frmfindProducts_ExecuteFindPorudctsEvent(object Sender, ItemsEL oelItems)
        {
            txtSearch.Text = oelItems.ItemName;
            IdItem = oelItems.IdItem.Value;
        }
        #endregion
        #region Button Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new IncomeBLL();
            List<TransactionsEL> list = null;
            if (chkExcludeDate.Checked)
            {
                list = manager.GetItemWiseProfitAndLoss(Operations.IdProject, Operations.BookNo, IdItem);
            }
            else
                list = manager.GetItemWiseProfitAndLossByDate(Operations.IdProject, Operations.BookNo, IdItem, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                grdProductWisePofitLoss.DataSource = list;
            }
            else
            {
                grdProductWisePofitLoss.DataSource = null;
            }
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdProductWisePofitLoss.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdProductWisePofitLoss.Columns)
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
                for (int i = 0; i < grdProductWisePofitLoss.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdProductWisePofitLoss.Rows)
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
        private void txtSearch_ButtonClick(object sender, EventArgs e)
        {
            frmfindProducts = new frmFindProducts();
            frmfindProducts.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindProducts_ExecuteFindPorudctsEvent);
            frmfindProducts.ShowDialog();
        }
        #endregion
    }
}
