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
    public partial class frmFindTradingCo : MetroForm
    {
        #region Variables
        DataTable dt;
        TradingEL oelTrading = null;
        public delegate void FindTradingDelegate(Object Sender, TradingEL oelTrading);
        public event FindTradingDelegate ExecuteFindTradingEvent;
        #endregion
        #region Forms Methods And Events
        public frmFindTradingCo()
        {
            InitializeComponent();
        }
        private void frmFindTradingCo_Load(object sender, EventArgs e)
        {
            this.grdFindTradingCo.AutoGenerateColumns = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            PopulateAllTradingCo();
        }
        private void frmFindTradingCo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (oelTrading != null)
            {
                ExecuteFindTradingEvent(sender, oelTrading);
            }
        }
        #endregion
        #region Methods
        private void PopulateAllTradingCo()
        {
            var manager = new TradingBLL();
            List<TradingEL> list = manager.GetAllTradingCo(Operations.IdProject);
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                grdFindTradingCo.DataSource = dt;
            }
            else
            {
                grdFindTradingCo.DataSource = null;
            }
        }
        private void PopulateTradingCosBySearch(List<TradingEL> list)
        {
            if (grdFindTradingCo.Rows.Count > 1)
            {
                grdFindTradingCo.DataSource = null;
            }
            else
            {
                dt = DataOperations.ToDataTable(list);
                grdFindTradingCo.DataSource = dt;
            }
        }
        #endregion
        #region Others Controls And Methods
        private void txtID_TextChanged(object sender, EventArgs e)
        {
            var manager = new TradingBLL();
            List<TradingEL> list = new List<TradingEL>();
            string searchString = "";
            if (txtID.Text != string.Empty)
            {
                char[] chars = txtID.Text.ToArray();
                if (chars.Length > 0 && char.IsNumber(chars[0]))
                {
                    list = manager.SearchTradingByTradingCode(Operations.IdProject, Validation.GetSafeLong(txtID.Text));
                    PopulateTradingCosBySearch(list);
                }
                else
                {
                    searchString = txtID.Text;
                    if (txtID.Text.Contains("\t"))
                        searchString = txtID.Text.Remove(txtID.Text.Count() - 1);
                    list = manager.SearchTradingByTradingName(Operations.IdProject, searchString);
                    PopulateTradingCosBySearch(list);
                }
            }
            else if (grdFindTradingCo.Rows.Count > 0)
            {
                grdFindTradingCo.DataSource = null;
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
            PopulateAllTradingCo();
        }
        private void filterDGV(string rowFilter)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = rowFilter;
            grdFindTradingCo.DataSource = DV;
        }
        #endregion
        #region Grid Events
        private void grdFindTradingCo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (grdFindTradingCo.CurrentRow != null)
                {
                    int RowIndex = grdFindTradingCo.CurrentRow.Index;
                    oelTrading = new TradingEL();
                    oelTrading.IdTrading = Validation.GetSafeLong(grdFindTradingCo.Rows[RowIndex].Cells[0].Value);
                    oelTrading.TradingCode = Validation.GetSafeLong(grdFindTradingCo.Rows[RowIndex].Cells[2].Value);
                    oelTrading.TradingName = grdFindTradingCo.Rows[RowIndex].Cells[3].Value.ToString();
                    this.Close();
                }
            }
            else
            {
                txtID.Focus();
            }
        }
        private void grdFindTradingCo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            oelTrading = new TradingEL();
            oelTrading.IdTrading = Validation.GetSafeLong(grdFindTradingCo.Rows[e.RowIndex].Cells[0].Value);
            oelTrading.TradingCode = Validation.GetSafeLong(grdFindTradingCo.Rows[e.RowIndex].Cells[2].Value);
            oelTrading.TradingName = grdFindTradingCo.Rows[e.RowIndex].Cells[3].Value.ToString();
            this.Close();
        }
        #endregion
    }
}
