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
    public partial class frmFindOutSourceWorkType : MetroForm
    {
        #region Variables
        OutSourceWorkTypeEL oelOutSourceWork = null;
        public delegate void FindOutSourceWorkDelegate(Object Sender, OutSourceWorkTypeEL oelOutSourceWorkType);
        public event FindOutSourceWorkDelegate ExecuteFindOutSourceWorkTypeEvent;
        DataTable dt;
        #endregion
        #region Form Methods And Events
        public frmFindOutSourceWorkType()
        {
            InitializeComponent();
        }
        private void frmFindOutSourceWorkType_Load(object sender, EventArgs e)
        {
            this.grdFindOutSourceWorkTypes.AutoGenerateColumns = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            PopulateAllOutSourceWorks();
        }
        private void frmFindOutSourceWorkType_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void frmFindOutSourceWorkType_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (oelOutSourceWork != null)
            {
                ExecuteFindOutSourceWorkTypeEvent(sender, oelOutSourceWork);
            }
        }
        #endregion
        #region Methods
        private void PopulateAllOutSourceWorks()
        {
            var manager = new OutSourceWorkTypeBLL();
            List<OutSourceWorkTypeEL> list = manager.GetAllOutSourceWorkTypes(Operations.IdProject);
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                grdFindOutSourceWorkTypes.DataSource = dt;
            }
            else
            {
                grdFindOutSourceWorkTypes.DataSource = null;
            }
        }
        private void PopulateOutSourceWorkTypeBySearch(List<OutSourceWorkTypeEL> list)
        {
            if (grdFindOutSourceWorkTypes.Rows.Count > 1)
            {
                grdFindOutSourceWorkTypes.DataSource = null;
            }
            else
            {
                dt = DataOperations.ToDataTable(list);
                grdFindOutSourceWorkTypes.DataSource = dt;
            }
        }
        private void filterDGV(string rowFilter)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = rowFilter;
            grdFindOutSourceWorkTypes.DataSource = DV;
        }
        #endregion
        #region Controls Events And Methods
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var manager = new OutSourceWorkTypeBLL();
            List<OutSourceWorkTypeEL> list = new List<OutSourceWorkTypeEL>();
            string searchString = "";
            if (txtID.Text != string.Empty)
            {
                char[] chars = txtID.Text.ToArray();
                if (chars.Length > 0 && char.IsNumber(chars[0]))
                {
                    list = manager.SearchOutSourceWorkTypeByOutSourceWorkTypeCode(Operations.IdProject, Validation.GetSafeLong(txtID.Text));
                    PopulateOutSourceWorkTypeBySearch(list);
                }
                else
                {
                    searchString = txtID.Text;
                    if (txtID.Text.Contains("\t"))
                        searchString = txtID.Text.Remove(txtID.Text.Count() - 1);
                    list = manager.SearchOutSourceWorkTypeByOutSourceWorkTypeByName(Operations.IdProject, searchString);
                    PopulateOutSourceWorkTypeBySearch(list);
                }
            }
            else if (grdFindOutSourceWorkTypes.Rows.Count > 0)
            {
                grdFindOutSourceWorkTypes.DataSource = null;
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
            PopulateAllOutSourceWorks();
        }
        #endregion
        #region Grid Methods
        private void grdFindOutSourceWorkTypes_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (grdFindOutSourceWorkTypes.CurrentRow != null)
                {
                    int RowIndex = grdFindOutSourceWorkTypes.CurrentRow.Index;
                    oelOutSourceWork = new OutSourceWorkTypeEL();
                    oelOutSourceWork.IdOutSourceWorkType = Validation.GetSafeLong(grdFindOutSourceWorkTypes.Rows[RowIndex].Cells[0].Value);
                    oelOutSourceWork.OutSourceWorkTypeCode = Validation.GetSafeString(grdFindOutSourceWorkTypes.Rows[RowIndex].Cells[2].Value);
                    oelOutSourceWork.OutSourceWorkTypeName = grdFindOutSourceWorkTypes.Rows[RowIndex].Cells[3].Value.ToString();                  
                    this.Close();
                }
            }
            else
            {
                txtID.Focus();
            }
        }
        private void grdFindOutSourceWorkTypes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oelOutSourceWork = new OutSourceWorkTypeEL();
            oelOutSourceWork.IdOutSourceWorkType = Validation.GetSafeLong(grdFindOutSourceWorkTypes.Rows[e.RowIndex].Cells[0].Value);
            oelOutSourceWork.OutSourceWorkTypeCode = Validation.GetSafeString(grdFindOutSourceWorkTypes.Rows[e.RowIndex].Cells[2].Value);
            oelOutSourceWork.OutSourceWorkTypeName = grdFindOutSourceWorkTypes.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.Close();
        }
        #endregion                    
    }
}
