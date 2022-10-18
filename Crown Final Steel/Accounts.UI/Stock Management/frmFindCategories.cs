using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.BLL;
using Accounts.Common;
using Accounts.UI.UserControls;
using Accounts.EL;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmFindCategories : MetroForm
    {
        #region Variables
        CategoryEL oelCategory = null;
        public delegate void FindCategoryDelegate(Object Sender, CategoryEL oelCategory);
        public event FindCategoryDelegate ExecuteFindCategoryEvent;
        DataTable dt;
        #endregion
        #region Form Methods And Events
        public frmFindCategories()
        {
            InitializeComponent();
        }
        private void frmFindCategories_Load(object sender, EventArgs e)
        {
            this.grdFindCategories.AutoGenerateColumns = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            PopulateAllCategories();
        }
        private void frmFindCategories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void frmFindCategories_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (oelCategory != null)
            {
                ExecuteFindCategoryEvent(sender, oelCategory);
            }
        }
        #endregion
        #region Methods
        private void PopulateAllCategories()
        {
            var manager = new CategoryBLL();
            List<CategoryEL> list = manager.GetAllCategories(Operations.IdProject);
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                grdFindCategories.DataSource = dt;
            }
            else
            {
                grdFindCategories.DataSource = null;
            }
        }
        private void PopulateCategoriesBySearch(List<CategoryEL> list)
        {
            if (grdFindCategories.Rows.Count > 1)
            {
                grdFindCategories.DataSource = null;
            }
            else
            {
                dt = DataOperations.ToDataTable(list);
                grdFindCategories.DataSource = dt;
            }
        }
        private void filterDGV(string rowFilter)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = rowFilter;
            grdFindCategories.DataSource = DV;
        }
        #endregion
        #region Controls Events And Methods
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var manager = new CategoryBLL();
            List<CategoryEL> list = new List<CategoryEL>();
            string searchString = "";
            if (txtID.Text != string.Empty)
            {
                char[] chars = txtID.Text.ToArray();
                if (chars.Length > 0 && char.IsNumber(chars[0]))
                {
                    list = manager.SearchCategoryByCategoryCode(Operations.IdProject, Validation.GetSafeLong(txtID.Text));
                    PopulateCategoriesBySearch(list);
                }
                else
                {
                    searchString = txtID.Text;
                    if (txtID.Text.Contains("\t"))
                        searchString = txtID.Text.Remove(txtID.Text.Count() - 1);
                    list = manager.SearchCategoryByCategoryByName(Operations.IdProject, searchString);
                    PopulateCategoriesBySearch(list);
                }
            }
            else if (grdFindCategories.Rows.Count > 0)
            {
                grdFindCategories.DataSource = null;
            }
        }
        private void chkFilter_CheckedChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            chkAll.Checked = false;
            if (chkFilter.Checked)
            {
                filterDGV("IsActive = 0");
            }
            else
            {
                filterDGV("IsActive = 1");
            }
        }
        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            chkFilter.Checked = false;
            PopulateAllCategories();
        }
        #endregion
        #region Grid Methods
        private void grdFindCategories_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (grdFindCategories.CurrentRow != null)
                {
                    int RowIndex = grdFindCategories.CurrentRow.Index;
                    oelCategory = new CategoryEL();
                    oelCategory.IdCategory = Validation.GetSafeLong(grdFindCategories.Rows[RowIndex].Cells[0].Value);
                    oelCategory.CategoryCode = Validation.GetSafeString(grdFindCategories.Rows[RowIndex].Cells[2].Value);
                    oelCategory.CategoryName = grdFindCategories.Rows[RowIndex].Cells[3].Value.ToString();                  
                    this.Close();
                }
            }
            else
            {
                txtID.Focus();
            }
        }
        private void grdFindCategories_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oelCategory = new CategoryEL();
            oelCategory.IdCategory = Validation.GetSafeLong(grdFindCategories.Rows[e.RowIndex].Cells[0].Value);
            oelCategory.CategoryCode = Validation.GetSafeString(grdFindCategories.Rows[e.RowIndex].Cells[2].Value);
            oelCategory.CategoryName = grdFindCategories.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.Close();
        }
        #endregion                    
    }
}
