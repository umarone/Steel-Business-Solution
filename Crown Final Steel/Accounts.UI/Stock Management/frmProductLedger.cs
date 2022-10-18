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

namespace Accounts.UI
{
    public partial class frmProductLedger : MetroForm
    {
        #region Variables
        frmFindProducts frmfindstock;
        Int64? IdItem;
        #endregion
        #region Form Methods And Variables
        public frmProductLedger()
        {
            InitializeComponent();
        }
        private void frmProductLedger_Load(object sender, EventArgs e)
        {
            this.grdProductLedger.AutoGenerateColumns = false;
        }
        #endregion
        #region Cutom Controls Events
        private void PEditBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
            {
                e.Handled = true;
                frmfindstock = new frmFindProducts();
                frmfindstock.SearchText = e.KeyChar.ToString();
                frmfindstock.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindstock_ExecuteFindPorudctsEvent);
                frmfindstock.ShowDialog();
            }
        }
        private void PEditBox_ButtonClick(object sender, EventArgs e)
        {
            frmfindstock = new frmFindProducts();
            frmfindstock.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindstock_ExecuteFindPorudctsEvent);
            frmfindstock.ShowDialog();
        }
        void frmfindstock_ExecuteFindPorudctsEvent(object Sender, ItemsEL oelItems) 
        {
            PEditBox.Text = oelItems.ItemName;
            IdItem = oelItems.IdItem;
        }
        #endregion
        #region Button Events
        private void btnProductReport_Click(object sender, EventArgs e)
        {
            decimal DebitStock = 0, CreditStock = 0, Balance = 0, Qty = 0, TotalValue = 0;
            var manager = new ItemsBLL();
            List<ItemsEL> list = null;
            if(!chkDate.Checked)
                list = manager.GetProductLedger(IdItem);
            else
                list = manager.GetProductLedgerByDate(IdItem, dtStart.Value, dtEnd.Value);
            if (list.Count > 0)
            {
                list.RemoveAll(x => x.Qty == 0);
                grdProductLedger.DataSource = list;
                for (int i = 0; i < list.Count; i++)
                {
                    if (Validation.GetSafeString(grdProductLedger.Rows[i].Cells["colType"].Value) == "In")
                    {
                        DebitStock = Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);
                        Balance += DebitStock;
                        grdProductLedger.Rows[i].Cells["colClosing"].Value = Balance;//.ToString() + " KG";
                        Qty += Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);

                    }
                    if (Validation.GetSafeString(grdProductLedger.Rows[i].Cells["colType"].Value) == "Out")
                    {
                        CreditStock = Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);
                        Balance -= CreditStock;
                        grdProductLedger.Rows[i].Cells["colClosing"].Value = Balance.ToString();
                        Qty -= Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);
                    }

                    TotalValue += Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colValue"].Value);
                    if (Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value) != 0)
                    {
                        grdProductLedger.Rows[i].Cells["colPerUnitAvg"].Value = Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colValue"].Value) / Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colUnits"].Value);
                    }
                    //if (Qty > 0)
                    {
                        //grdTanneryStockReport.Rows[i].Cells["colPerUnitAvg"].Value = (TotalValue / Qty).ToString("0.00");
                        grdProductLedger.Rows[i].Cells["colStockBalance"].Value = Math.Abs((Validation.GetSafeDecimal(grdProductLedger.Rows[i].Cells["colPerUnitAvg"].Value) * Balance)).ToString("0.00");
                    }
                }
            }
        }
        #endregion               
        #region Win Controls Methods And Events
        private void chkDate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDate.Checked)
            {
                pnlDate.Visible = true;
                grdProductLedger.DataSource = null;
            }
            else
            {
                pnlDate.Visible = false;
                grdProductLedger.DataSource = null;
            }
        }
        #endregion
    }
}
