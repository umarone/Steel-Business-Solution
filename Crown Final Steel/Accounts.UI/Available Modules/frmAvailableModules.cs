using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.Common;
using Accounts.BLL;
using Accounts.EL;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace Accounts.UI
{
    public partial class frmAvailableModules : MetroForm
    {
        #region Variables
        DataTable dtModules;
        DataTable dtStockReports;
        DataTable dtFinancialReports;
        DataTable dtAdministration;
        frmModulesPreviews frmPreviewModules;
        #endregion
        #region Form Methods And Events
        public frmAvailableModules()
        {
            InitializeComponent();
        }
        private void frmAvailableModules_Load(object sender, EventArgs e)
        {
            tabModules.SelectedIndex = 0;
            this.grdAvailableModules.AutoGenerateColumns = false;
            this.grdAvailableModulesReports.AutoGenerateColumns = false;
            this.grdAvailableFinancialModules.AutoGenerateColumns = false;
            this.grdAvailableAdministration.AutoGenerateColumns = false;
            FillModules();
        }
        private void frmAvailableModules_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void FillModules()
        {
            var manager = new ModulesBLL();
            List<ModulesEL> list = manager.GetAllModules();

            if (list.Count > 0)
            {
                List<ModulesEL> listEnabledModules = list.FindAll(x => x.IsEnabled == false);
                FillModulesGrid(listEnabledModules);
                FillStockReportsGrid(listEnabledModules.FindAll(x => x.ModuleType == "Report"));
                FillFinancialReportsGrid(listEnabledModules.FindAll(x => x.ModuleType == "Report"));
                FillAdministrationReportsGrid(listEnabledModules.FindAll(x => x.ModuleType == "Report"));
            }
        }
        #endregion
        #region Fill Methods
        private void FillModulesGrid(List<ModulesEL> list)
        {
            dtModules = DataOperations.ToDataTable(list.FindAll(x =>x.ModuleType == "Form"));
            grdAvailableModules.DataSource = dtModules;
        }
        private void FillStockReportsGrid(List<ModulesEL> list)
        {
            List<ModulesEL> listStockReports = list.FindAll(x => x.ModuleHeader == "Stock Management");
            if (listStockReports.Count > 0)
            {
                dtStockReports = DataOperations.ToDataTable(listStockReports);
                grdAvailableModulesReports.DataSource = dtStockReports;
            }
        }
        private void FillFinancialReportsGrid(List<ModulesEL> list)
        {
            List<ModulesEL> listFinancialReports = list.FindAll(x => x.ModuleHeader == "General Ledger");
            if (listFinancialReports.Count > 0)
            {
                dtFinancialReports = DataOperations.ToDataTable(listFinancialReports);
                grdAvailableFinancialModules.DataSource = dtFinancialReports;
            }
        }
        private void FillAdministrationReportsGrid(List<ModulesEL> list)
        {
            List<ModulesEL> listAdministrationReports = list.FindAll(x => x.ModuleHeader == "Administration");
            if (listAdministrationReports.Count > 0)
            {
                dtAdministration = DataOperations.ToDataTable(listAdministrationReports);
                grdAvailableAdministration.DataSource = dtAdministration;
            }
        }
        #endregion
        #region Win Controls Events
        private void cbxModuleCategories_SelectedIndexChanged(object sender, EventArgs e)
        {           
            if (cbxModuleCategories.SelectedIndex > 0)
            {
                if (cbxModuleCategories.SelectedIndex == 1)
                {
                    tabModules.SelectedIndex = 0;
                }
                else if (cbxModuleCategories.SelectedIndex == 2)
                {
                    tabModules.SelectedIndex = 1;
                }
                else if (cbxModuleCategories.SelectedIndex == 3)
                {
                    tabModules.SelectedIndex = 2;
                }
                else
                {
                    tabModules.SelectedIndex = 3;
                }
                if (tabModules.SelectedIndex == 0)
                {
                    //DataView DV = new DataView(dtModules);
                    //DV.RowFilter = string.Format("ModuleCategory LIKE '%{0}%'", cbxModuleCategories.Text);
                    //grdAvailableModules.DataSource = DV;
                }
                else
                {
                    //DataView DV = new DataView(dtStockReports);
                    //DV.RowFilter = string.Format("ModuleCategory LIKE '%{0}%'", cbxModuleCategories.Text);
                    //grdAvailableModulesReports.DataSource = DV;
                }
            }
        }
        #endregion
        #region Modules Grid Region
        private void grdAvailableModules_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = "Preview";
            }
        }
        private void grdAvailableModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                frmPreviewModules = new frmModulesPreviews();
                frmPreviewModules.IdModule = Validation.GetSafeLong(grdAvailableModules.Rows[e.RowIndex].Cells[0].Value);
                frmPreviewModules.ShowDialog();
            }
        }
        #endregion
        #region Stock Modules Grid Region
        private void grdAvailableModulesReports_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = "Preview";
            }
        }
        private void grdAvailableModulesReports_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPreviewModules = new frmModulesPreviews();
            frmPreviewModules.IdModule = Validation.GetSafeLong(grdAvailableModulesReports.Rows[e.RowIndex].Cells[0].Value);
            frmPreviewModules.ShowDialog();
        }
        #endregion
        #region  #region Financial Modules Grid Region
        private void grdAvailableFinancialModules_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = "Preview";
            }
        }
        private void grdAvailableFinancialModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPreviewModules = new frmModulesPreviews();
            frmPreviewModules.IdModule = Validation.GetSafeLong(grdAvailableFinancialModules.Rows[e.RowIndex].Cells[0].Value);
            frmPreviewModules.ShowDialog();
        }
        #endregion
        #region Administration Modules Region
        private void grdAvailableAdministration_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = "Preview";
            }
        }
        private void grdAvailableAdministration_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            frmPreviewModules = new frmModulesPreviews();
            frmPreviewModules.IdModule = Validation.GetSafeLong(grdAvailableAdministration.Rows[e.RowIndex].Cells[0].Value);
            frmPreviewModules.ShowDialog();
        }
        #endregion
    }
}
