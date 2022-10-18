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

using MetroFramework.Forms;
using Accounts.Common;

namespace Accounts.UI
{
    public partial class frmPriceList : MetroForm
    {
        #region Variables
        frmPriceListReport frmPriceReport;
        DataTable dt;
        #endregion
        #region Form Methods And Events
        public frmPriceList()
        {
            InitializeComponent();
        }
        private void frmPriceList_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.DgvPriceList.AutoGenerateColumns = false;
            this.DgvPriceList.Columns[0].ReadOnly = true;
            this.DgvPriceList.Columns[1].ReadOnly = true; 
            this.DgvPriceList.Columns[2].ReadOnly = true;

            LoadPriceList();
        }
        private void LoadPriceList()
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetAllActiveItems(Operations.IdProject);  //.GetPriceWiseItems(Operations.IdProject);
            if (list.Count > 0)
            {
                dt = DataOperations.ToDataTable(list);
                DgvPriceList.DataSource = dt;
            }
            else
            {
                DgvPriceList.DataSource = null;
            }            
        }
        #endregion
        #region Buttons Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            List<ItemsEL> oelItemsCollections = new List<ItemsEL>();
            for (int i = 0; i < DgvPriceList.Rows.Count; i++)
            {
                ItemsEL oelItem = new ItemsEL();
                oelItem.IdItem = Validation.GetSafeLong(DgvPriceList.Rows[i].Cells[0].Value);
                oelItem.ItemName = DgvPriceList.Rows[i].Cells[2].Value.ToString();
                if (DgvPriceList.Rows[i].Cells[4].Value == null || DgvPriceList.Rows[i].Cells[4].Value.ToString() == string.Empty)
                {
                    oelItem.Description = "N/A";
                }
                else
                {
                    oelItem.Description = DgvPriceList.Rows[i].Cells[4].Value.ToString();
                }
                //if (DgvPriceList.Rows[i].Cells[4].Value == DBNull.Value)
                //{
                //    oelItem.ProductRegNo = "N/A";
                //}
                //else
                //{
                //    oelItem.ProductRegNo = Convert.ToString(DgvPriceList.Rows[i].Cells[4].Value);
                //}
                if (DgvPriceList.Rows[i].Cells[5].Value == DBNull.Value)
                {
                    oelItem.MRP = 0;
                }
                else
                {
                    oelItem.MRP = Validation.GetSafeDecimal(DgvPriceList.Rows[i].Cells[5].Value);
                }
                oelItemsCollections.Add(oelItem);
            }
            var manager = new ItemsBLL();
            if (manager.CreateUpdatePriceList(oelItemsCollections,Operations.IdCompany))
            {
                MessageBox.Show("Price List Updated");            
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            frmPriceReport = new frmPriceListReport();
            frmPriceReport.Show(this);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DataView DV = new DataView(dt);
            DV.RowFilter = string.Format("ItemName LIKE '%{0}%'", txtSearch.Text);
            DgvPriceList.DataSource = DV;
        }
        #endregion
    }
}
