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
    public partial class frmProductsChart : MetroForm
    {
        #region Variables
        DataTable dtItems;
        #endregion
        #region Form Methods And Events
        public frmProductsChart()
        {
            InitializeComponent();
        }
        private void frmProductsChart_Load(object sender, EventArgs e)
        {
            grdProductsChart.AutoGenerateColumns = false;
            FillCategories();
        }
        private void frmProductsChart_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void FillCategories()
        {
            var manager = new CategoryBLL();
            List<CategoryEL> listCategories = manager.GetAllCategories(Operations.IdProject);
            listCategories.Insert(0, new CategoryEL() { IdCategory = 0, CategoryName = "Please Select Category" });
            listCategories.Insert(1, new CategoryEL() { IdCategory = 0, CategoryName = "No Category Items" });
            CbxCategories.DataSource = listCategories;
            CbxCategories.DisplayMember = "CategoryName";
            CbxCategories.ValueMember = "IdCategory";
        }
        #endregion
        #region Win Controls Events And Methods
        private void CbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = null;
            if (CbxCategories.SelectedIndex > 0)
            {
                if (Validation.GetSafeLong(CbxCategories.SelectedValue) == 0)
                {
                    list = manager.GetAllItems(Operations.IdProject);
                }
                else
                {
                    list = manager.GetItemsByCategory(Validation.GetSafeLong(CbxCategories.SelectedValue));
                }
                if (list.Count > 0)
                {
                    dtItems = DataOperations.ToDataTable(list);
                    grdProductsChart.DataSource = dtItems;
                }
                else
                {
                    grdProductsChart.DataSource = null;
                }
            }
            else
            {
                grdProductsChart.DataSource = null;
            }
        }
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtItems);
            DV.RowFilter = string.Format("ItemName LIKE '%{0}%'", txtFilter.Text);
            grdProductsChart.DataSource = DV;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            if (grdProductsChart.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdProductsChart.Columns)
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
                for (int i = 0; i < grdProductsChart.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdProductsChart.Rows)
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
        #endregion
    }
}
