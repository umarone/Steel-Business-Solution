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
    public partial class frmFindProducts : MetroForm
    {
        #region Variables
        public string SearchText { get; set; }
        public string SearchType { get; set; }
        ItemsEL Items = null;
        public delegate void FindProductsDelegate(Object Sender,ItemsEL oelItems);
        public event FindProductsDelegate ExecuteFindPorudctsEvent;
        frmFindProductByBatchAndExpiry frmFind = null;
        #endregion
        #region Forms Methods And Events
        public frmFindProducts()
        {
            InitializeComponent();
        }
        private void frmFindProducts_Load(object sender, EventArgs e)
        {
            grdFindItems.AutoGenerateColumns = false;
            txtName.Text = SearchText;
            txtName.SelectionStart = 1;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            PopulateCategories();
        }
        private void frmFindProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        private void frmFindProducts_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Items != null)
            {
                ExecuteFindPorudctsEvent(sender, Items);
            }
        }
        #endregion
        #region Simple Methods
        private void PopulateCategories()
        {
            var manager = new CategoryBLL();
            List<CategoryEL> listCategories = manager.GetAllCategories(Operations.IdProject);
            listCategories.Insert(0, new CategoryEL() { IdCategory = -1, CategoryName = "Please Select Category" });
            listCategories.Insert(1, new CategoryEL() { IdCategory = 0, CategoryName = "No Category Items" });
            CbxCategories.DataSource = listCategories;
            CbxCategories.DisplayMember = "CategoryName";
            CbxCategories.ValueMember = "IdCategory";

        }
        private void PopulateItems(List<ItemsEL> list)
        {
            if (grdFindItems.Rows.Count > 1)
            {
                grdFindItems.DataSource = null;
            }
            grdFindItems.DataSource = list;
        }
        #endregion
        #region Grid Events
        private void grdFindItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (grdFindItems.CurrentRow != null)
                {
                    int RowIndex = grdFindItems.CurrentRow.Index;
                    Items = new ItemsEL();
                    Items.IdItem = Validation.GetSafeLong(grdFindItems.Rows[RowIndex].Cells[0].Value);
                    Items.ItemNo = Validation.GetSafeString(grdFindItems.Rows[RowIndex].Cells[1].Value);
                    Items.ProductCode = Validation.GetSafeString(grdFindItems.Rows[RowIndex].Cells[2].Value);
                    Items.ItemName = Validation.GetSafeString(grdFindItems.Rows[RowIndex].Cells[3].Value);
                    Items.PackingSize = Validation.GetSafeString(grdFindItems.Rows[RowIndex].Cells[4].Value);
                    Items.CategoryName = Validation.GetSafeString(grdFindItems.Rows[RowIndex].Cells[5].Value);                                        

                    if (SearchType == "SaleInvoiceVoucher")
                    {
                        frmFind = new frmFindProductByBatchAndExpiry();
                        frmFind.IdItem = Validation.GetSafeLong(grdFindItems.Rows[RowIndex].Cells[0].Value);
                        frmFind.ProductName = grdFindItems.Rows[RowIndex].Cells[4].Value.ToString();
                        frmFind.ExecuteFindStockEvent += new frmFindProductByBatchAndExpiry.FindStockDelegate(frmFind_ExecuteFindStockEvent);
                        frmFind.ShowDialog();
                    }
                    this.Close();
                }
            }
            else
            {
               
            }
        }
        private void grdFindItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Items = new ItemsEL();
            Items.IdItem = Validation.GetSafeLong(grdFindItems.Rows[e.RowIndex].Cells[0].Value);
            Items.ItemNo = Validation.GetSafeString(grdFindItems.Rows[e.RowIndex].Cells[1].Value);
            Items.ProductCode = Validation.GetSafeString(grdFindItems.Rows[e.RowIndex].Cells[2].Value);
            Items.ItemName = Validation.GetSafeString(grdFindItems.Rows[e.RowIndex].Cells[3].Value);
            Items.PackingSize = Validation.GetSafeString(grdFindItems.Rows[e.RowIndex].Cells[4].Value);
            Items.CategoryName = Validation.GetSafeString(grdFindItems.Rows[e.RowIndex].Cells[5].Value);

            if (SearchType == "SaleInvoiceVoucher")
            {
                frmFind = new frmFindProductByBatchAndExpiry();
                frmFind.IdItem = Validation.GetSafeLong(grdFindItems.Rows[e.RowIndex].Cells[0].Value);
                frmFind.ProductName = grdFindItems.Rows[e.RowIndex].Cells[4].Value.ToString();
                frmFind.ExecuteFindStockEvent += new frmFindProductByBatchAndExpiry.FindStockDelegate(frmFind_ExecuteFindStockEvent);
                frmFind.ShowDialog();
            }
            this.Close();
        }
        #endregion     
        #region Other Controls And Events
        private void chkSearchAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSearchAll.Checked)
            {
                var manager = new ItemsBLL();
                List<ItemsEL> list = manager.GetAllItems(Operations.IdProject);
                grdFindItems.DataSource = list;
            }
            else
            {
                grdFindItems.DataSource = null;
            }
        }
        void frmFind_ExecuteFindStockEvent(object Sender, ItemsEL oelItems)
        {
            Items.Qty = oelItems.Qty;
        }
        private void cbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxCategories.SelectedIndex > 0)
            {
                var manager = new ItemsBLL();
                Int64? IdCate = Validation.GetSafeLong(CbxCategories.SelectedValue);
                if (IdCate == 0)
                    IdCate = null;
                List<ItemsEL> list = manager.GetItemsByCategory(IdCate);
                if (list.Count > 0)
                {
                    grdFindItems.DataSource = list;
                }
                else
                {
                    grdFindItems.DataSource = null;
                }
            }
        }
        private void txtName_TextChanged(object sender, EventArgs e)
        {
            var manager = new ItemsBLL();
            if (txtName.Text != string.Empty)
            {
                List<ItemsEL> list = manager.SearchStockByProductName(txtName.Text, Operations.IdProject);
                PopulateItems(list);
            }
            else
            {
                grdFindItems.DataSource = null;
            }
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                grdFindItems.Focus();
            }
        }
        private void txtName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Down)
            {
                if (!grdFindItems.Focused)
                {
                    grdFindItems.Focus();
                    SendKeys.Send("{Tab}");
                }
            }
        }
        #endregion
    }
}
