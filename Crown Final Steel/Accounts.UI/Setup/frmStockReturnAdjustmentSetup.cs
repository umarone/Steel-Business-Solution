using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Accounts.BLL;
using Accounts.EL;
using Accounts.Common;
using MetroFramework.Forms;

namespace Accounts.UI
{
    public partial class frmStockReturnAdjustmentSetup : MetroForm
    {
        #region Variables
        public int AdjustmentType { get; set; }
        Int64? IdAdjustmentType;
        #endregion
        public frmStockReturnAdjustmentSetup()
        {
            InitializeComponent();
        }

        private void frmStockReturnAdjustmentSetup_Load(object sender, EventArgs e)
        {
            this.grdStockAdjustments.AutoGenerateColumns = false;
            LoadAdjustmentTypes();
        }
        private void LoadAdjustmentTypes()
        {
            var manager = new StockAdjustmentsBLL();
            List<StockAdjustmentsEL> list = manager.GetStockAdjustmentsByType(AdjustmentType);
            if (list.Count > 0)
            {
                grdStockAdjustments.DataSource = list;
            }
            else
            {
                grdStockAdjustments.DataSource = null;
            }
        }
        private bool ValidateControls()
        {
            bool isValid = true;
            if (txtAdjustmentTypes.Text == string.Empty)
            {
                isValid = false;
            }  
            return isValid;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            StockAdjustmentsEL oelAdjustment = new StockAdjustmentsEL();
            var Manager = new StockAdjustmentsBLL();
            List<StockAdjustmentsEL> list = new List<StockAdjustmentsEL>();
            if (ValidateControls())
            {
                if (!IdAdjustmentType.HasValue)
                {
                    oelAdjustment.IdStockAdjustmentType = 1;
                }
                else
                {
                    oelAdjustment.IdStockAdjustmentType = IdAdjustmentType.Value;
                }
                oelAdjustment.StockAdjustmentName = Validation.GetSafeString(txtAdjustmentTypes.Text);
                oelAdjustment.StockAdjustmentType = AdjustmentType;
                oelAdjustment.IsMeasureAble = chkMeasure.Checked;
                oelAdjustment.IsActive = true;
                oelAdjustment.CreatedDateTime = DateTime.Now;
                if (!IdAdjustmentType.HasValue)
                {
                    if (Manager.CreateStockAdjustmentTypes(oelAdjustment))
                    {
                        txtAdjustmentTypes.Text = string.Empty;
                        IdAdjustmentType = null;
                        LoadAdjustmentTypes();
                    }
                }
                else
                {
                    if (Manager.UpdateStockAdjustmentTypes(oelAdjustment))
                    {
                        txtAdjustmentTypes.Text = string.Empty;
                        IdAdjustmentType = null;
                        LoadAdjustmentTypes();
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new StockAdjustmentsBLL();
            if (manager.DeleteStockAdjustmentTypes(IdAdjustmentType))
            {
                MessageBox.Show("Adjustment Deleted Successfully....");
            }
        }
        private void grdStockAdjustments_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                e.Value = "Edit";
            }
        }
        private void grdStockAdjustments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                IdAdjustmentType = Validation.GetSafeLong(grdStockAdjustments.Rows[e.RowIndex].Cells["ColIdAdjustment"].Value);
                txtAdjustmentTypes.Text = Validation.GetSafeString(grdStockAdjustments.Rows[e.RowIndex].Cells["colDescription"].Value);
                chkMeasure.Checked = Convert.ToBoolean(grdStockAdjustments.Rows[e.RowIndex].Cells["colMeasureable"].Value);
            }
        }
    }
}
