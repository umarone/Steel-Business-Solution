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
    public partial class frmTotalStock : MetroForm
    {
        #region Variables
        DataTable dt;
        frmStockAnalysisReports frmstockreportprint;
        frmGroupingStockAnalysisReports frmGroupingReportPrint;
        List<ModulesEL> list = null;
        List<ModulesEL> listDisabledModules = null;
        frmModulesPreviews frmmodulepreviewforuser;
        #endregion
        #region Form Methods And Events
        public frmTotalStock()
        {
            InitializeComponent();
        }
        private void frmTotalStock_Load(object sender, EventArgs e)
        {
            grdTotalStock.AutoGenerateColumns = false;
            FillCategories();
            FillBrands();
            FillModules();
            //FillTradingCo();
        }
        private void frmTotalStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
        #region Fill Methods
        private void FillCategories()
        {
            var manager = new CategoryBLL();
            List<CategoryEL> listCategories = manager.GetAllCategories(Operations.IdProject);

            CbxCategories.DataSource = listCategories;
            CbxCategories.DisplayMember = "CategoryName";
            CbxCategories.ValueMember = "IdCategory";
        }
        private void FillBrands()
        {
            var manager = new TradingBLL();
            List<TradingEL> listBrands = manager.GetAllTradingCo(Operations.IdProject);

            cbxBrands.DataSource = listBrands;
            cbxBrands.DisplayMember = "TradingName";
            cbxBrands.ValueMember = "IdTrading";
        }
        //private void FillTradingCo()
        //{
        //    var manager = new TradingBLL();
        //    List<TradingEL> listTradingCo = manager.GetAllTradingCo();

        //    CbxTrading.DataSource = listTradingCo;
        //    CbxTrading.DisplayMember = "TradingName";
        //    CbxTrading.ValueMember = "IdTrading";
        //}
        private void FillModules()
        {
            var manager = new ModulesBLL();
            list = manager.GetAllModules();

            if (list.Count > 0)
            {
                listDisabledModules = list.FindAll(x => x.IsEnabled == false);
            }
        }
        #endregion
        #region Button Events
        private void btnLoad_Click(object sender, EventArgs e)
        {
            var manager = new StockRecieptBLL();
            List<StockReceiptEL> lstStock = new List<StockReceiptEL>();
            if (!chkByCategory.Checked && !chkAllStock.Checked && !chkByBrand.Checked)
            {
                MessageBox.Show("No Option Is Checked For Stock Analysis...");
            }
            else
            {
                if (chkDate.Checked)
                {
                    if (chkByCategory.Checked)
                    {
                        lstStock = manager.GetTotalStockReport(Validation.GetSafeLong(CbxCategories.SelectedValue), Operations.IdProject);
                    }
                    else if (chkByBrand.Checked)
                    {
                        lstStock = manager.GetTradingWiseTotalStock(Validation.GetSafeLong(cbxBrands.SelectedValue), Operations.IdProject);
                    }
                    else if (chkAllStock.Checked)
                    {
                        lstStock = manager.GetTotalStockByItems(Operations.IdProject);
                    }
                    //PopulateStock(lstStock);
                }
                else
                {
                    if (chkByCategory.Checked)
                    {
                        lstStock = manager.GetDateWiseTotalStockReport(Validation.GetSafeLong(CbxCategories.SelectedValue), Operations.IdProject, StartDate.Value,EndDate.Value);
                    }
                    else if (chkByBrand.Checked)
                    {
                        lstStock = manager.GetDateAndTradingWiseTotalStockReport(Validation.GetSafeLong(cbxBrands.SelectedValue), Operations.IdProject, StartDate.Value, EndDate.Value);
                    }
                    else
                    {
                        lstStock = manager.GetDateWiseTotalStockByItems(Operations.IdProject, StartDate.Value, EndDate.Value);
                    }
                    //PopulateStock(lstStock);
                }
                if (lstStock.Count > 0)
                {
                    dt = DataOperations.ToDataTable(lstStock);
                    grdTotalStock.DataSource = dt;
                }
                else
                {
                    MessageBox.Show("No Stock Found....");
                    grdTotalStock.DataSource = null;
                }
            }
        }
        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            if (grdTotalStock.Rows.Count > 0)
            {
                DataTable dt = new DataTable();

                //Adding the Columns
                foreach (DataGridViewColumn column in grdTotalStock.Columns)
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
                for (int i = 0; i < grdTotalStock.Columns.Count; i++)
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

                foreach (DataGridViewRow row in grdTotalStock.Rows)
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
        private void btnPrint_Click(object sender, EventArgs e)
        {
            ctxStock.Show(btnPrint, new Point(0, btnPrint.Height));
        }
        #endregion
        #region TextBox Events
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("ItemName LIKE '%{0}%'", txtsearch.Text);
            grdTotalStock.DataSource = DV;
            //(grdTotalStock.DataSource as DataTable).DefaultView.RowFilter = string.Format("colAccountName='{0}'", txtsearch.Text);
        }
        #endregion
        #region CheckBoxes Events
        private void chkByCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByCategory.Checked)
            {
                chkAllStock.Checked = false;
                chkByBrand.Checked = false;
                pnlCategory.Visible = true;
                pnlBrand.Visible = false;
                grdTotalStock.DataSource = null;
            }
            else
            {
                pnlCategory.Visible = false;
                grdTotalStock.DataSource = null;
            }
        }
        private void chkByBrand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkByBrand.Checked)
            {
                chkAllStock.Checked = false;
                chkByCategory.Checked = false;
                pnlCategory.Visible = false;
                pnlBrand.Visible = true;
                grdTotalStock.DataSource = null;
            }
            else
            {
                pnlBrand.Visible = false;
                grdTotalStock.DataSource = null;
            }
        }
        private void chkAllStock_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAllStock.Checked)
            {
                chkByCategory.Checked = false;
                chkByBrand.Checked = false;
                pnlCategory.Visible = false;
                pnlBrand.Visible = false;
                grdTotalStock.DataSource = null;
            }
            else
            {
                grdTotalStock.DataSource = null;
            }
        }
        #endregion
        #region Menu Strip Region
        private void printTotalStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmstockreportprint = new frmStockAnalysisReports();
            if (chkDate.Checked)
            {
                frmstockreportprint.IsDateWise = false;
            }
            else
            {
                frmstockreportprint.IsDateWise = true;
                frmstockreportprint.StartDate = StartDate.Value;
                frmstockreportprint.EndDate = EndDate.Value;
            }
            frmstockreportprint.ShowDialog();
        }
        private void printGroupingStockReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGroupingReportPrint = new frmGroupingStockAnalysisReports();
            if (listDisabledModules != null && listDisabledModules.Count > 0)
            {
                ModulesEL oelModule = listDisabledModules.Find(x => x.ModuleName == "Grouping Stock Report");
                if (oelModule != null)
                {
                    if (oelModule.IsEnabled.Value)
                    {
                        if (chkDate.Checked)
                        {
                            frmGroupingReportPrint.IsDateWise = false;
                        }
                        else
                        {
                            frmGroupingReportPrint.IsDateWise = true;
                            frmGroupingReportPrint.StartDate = StartDate.Value;
                            frmGroupingReportPrint.EndDate = EndDate.Value;
                        }
                        frmGroupingReportPrint.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("You Have Not Purchased This Module, Please Purchase It ! Only Preview Is Available...");
                        frmmodulepreviewforuser = new frmModulesPreviews();
                        frmmodulepreviewforuser.IdModule = oelModule.IdModule;
                        frmmodulepreviewforuser.ShowDialog();
                    }
                }
                else
                {
                    MessageBox.Show("Module Is Not Available Please.... Contact Software Developer");
                }
            }
        }
        #endregion
    }
}
