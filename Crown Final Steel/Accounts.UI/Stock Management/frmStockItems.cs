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
    public partial class frmStockItems : MetroForm
    {
        Int64? IdItem;
        string ItemCode = "";
        public frmStockItems()
        {
            InitializeComponent();
        }
        private void frmStockItems_Load(object sender, EventArgs e)
        {
            this.grdItems.AutoGenerateColumns = false;
            CheckModulePermissions();
        }
        private void CheckModulePermissions()
        {
            List<UserModulesPermissionsEL> PermissionsList = UserPermissions.GetUserModulePermissionsByUserAndModuleId(Operations.UserID);
            if (PermissionsList != null && PermissionsList.Count > 0)
            {
                if (PermissionsList[0].Saving == true)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
                if (PermissionsList[0].Deleting == true)
                {
                    //btnDelete.Enabled = true;
                }
                else
                {
                    //btnDelete.Enabled = false;
                }
            }
            //else
            //{
            //    btnSave.Enabled = false;
            //    btnDelete.Enabled = false;
            //    chkPosted.Checked = true;
            //    chkPosted.Enabled = true;
            //}
        }
        private void txtSearchItems_Enter(object sender, EventArgs e)
        {
            txtSearchItems.WaterMark = string.Empty;
        }
        private void txtSearchItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                grdItems.Focus();
                e.KeyChar = (char)Keys.Tab;
            }
        }
        private void txtSearchItems_TextChanged(object sender, EventArgs e)
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = new List<ItemsEL>();
            string searchString = "";
            if (txtSearchItems.Text != string.Empty)
            {
                char[] chars = txtSearchItems.Text.ToArray();
                if (chars.Length > 0 && char.IsNumber(chars[0]))
                {
                    list = manager.SearchStockItemsByItemNo(Validation.GetSafeLong(txtSearchItems.Text), Operations.IdCompany);
                    PopulateItemsBySearch(list);
                }
                else
                {
                    searchString = txtSearchItems.Text;
                    if (txtSearchItems.Text.Contains("\t"))
                        searchString = txtSearchItems.Text.Remove(txtSearchItems.Text.Count() - 1);
                    list = manager.SearchStockItemsByItemName(searchString, Operations.IdCompany);
                    PopulateItemsBySearch(list);
                }
            }
            else if (grdItems.Rows.Count > 0)
            {
                grdItems.DataSource = null;
            }
        }
        private void PopulateItemsBySearch(List<ItemsEL> list)
        {
            if (grdItems.Rows.Count > 1)
            {
                grdItems.DataSource = null;
            }
            grdItems.DataSource = list;
        }
        private void grdItems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdItem = Validation.GetSafeLong(grdItems.Rows[e.RowIndex].Cells["colItemtId"].Value);
            ItemCode = Validation.GetSafeString(grdItems.Rows[e.RowIndex].Cells["colAccountCode"].Value);
            //CbxHeads.SelectedValue = Validation.GetSafeInteger(grdAccounts.Rows[e.RowIndex].Cells["colIdParent1"].Value);
            //CbxHeads_SelectedIndexChanged(sender, e);
            GetItem(IdItem);
        }
        private void grdItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if (grdItems.CurrentRow != null)
                {
                    int RowIndex = grdItems.CurrentRow.Index;
                    IdItem = Validation.GetSafeLong(grdItems.Rows[RowIndex].Cells["colItemtId"].Value);
                    ItemCode = Validation.GetSafeString(grdItems.Rows[RowIndex].Cells["colAccountCode"].Value);
                    // CbxHeads.SelectedValue = Validation.GetSafeInteger(grdAccounts.Rows[RowIndex].Cells["colIdParent1"].Value);
                    // CbxHeads_SelectedIndexChanged(sender, e);
                    GetItem(IdItem);
                }
            }
        }
        private void GetItem(Int64? IdItem)
        {
            var manager = new ItemsBLL();
            ItemsEL oelItem = new ItemsEL();
            List<ItemsEL> list = manager.GetItemById(IdItem.Value);
            if (list.Count > 0)
            {
                txtItemCode.Text = list[0].AccountNo.ToString();
                txtItemName.Text = list[0].ItemName;
                txtPackingSize.Text = list[0].PackingSize;
                txtDiscription.Text = list[0].Discription; 
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //var manager = new ItemsBLL();
            
            //ItemsEL oelItem = new ItemsEL();
            //oelItem.IdItem = IdItem;
            //oelItem.IdCompany = Operations.IdCompany;
            //oelItem.AccountNo = Validation.GetSafeString(txtItemCode.Text);
            //oelItem.ItemNo = txtItemCode.Text;
            //oelItem.ItemName = txtItemName.Text;
            //oelItem.Discription = txtDiscription.Text;
            //oelItem.PackingSize = txtPackingSize.Text;
            //oelItem.Balance = 0;
            //oelItem.Qty = 0;

            //if (manager.UpdateItems(oelItem, list))
            //{
            //    ClearControls();
            //    MessageBox.Show("Item Information Updated Successfully.....");
            //}
            //else
            //{
            //    MessageBox.Show("Problem Occured.....");
            //}

        }
        private void ClearControls()
        {
            if (grdItems.DataSource != null)
            {
                grdItems.DataSource = null;
            }
            IdItem = null;
            txtItemCode.Text = string.Empty;
            txtItemName.Text = string.Empty;
            txtPackingSize.Text = string.Empty;
            txtSearchItems.Text = string.Empty;
            txtDiscription.Text = string.Empty;

        }
        private void frmStockItems_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                ClearControls();
            }
        }

    }
}
