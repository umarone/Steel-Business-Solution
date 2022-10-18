using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using MetroFramework.Forms;
using Accounts.EL;
using Accounts.BLL;

namespace Accounts.UI
{
    public partial class frmLowStock : MetroForm
    {
        #region Variables
        DataTable dtLowStock;
        #endregion
        #region Form Methods and Variables
        public frmLowStock()
        {
            InitializeComponent();
        }
        private void frmLowStock_Load(object sender, EventArgs e)
        {
            this.grdLowStock.AutoGenerateColumns = false;
        }
        #endregion
        #region Controls Events
        private void btnView_Click(object sender, EventArgs e)
        {
            var manager = new StockRecieptBLL();
            List<StockReceiptEL> list = manager.GetLowStockAlert(Operations.IdProject);
            if (list.Count > 0)
            {
                dtLowStock = DataOperations.ToDataTable(list);
                grdLowStock.DataSource = dtLowStock;
            }
            else
                grdLowStock.DataSource = null;
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dtLowStock);
            DV.RowFilter = string.Format("ItemName LIKE '%{0}%'", txtSearch.Text);
            grdLowStock.DataSource = DV;
        }
        #endregion
    }
}
