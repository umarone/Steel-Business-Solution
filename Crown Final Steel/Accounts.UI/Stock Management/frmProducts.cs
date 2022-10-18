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
    public partial class frmProducts : MetroForm
    {
        #region Variables
        Int64? IdItem;
        Int64? IdCategory;
        Int64? IdTradingCo;
        frmFindProducts frmfindProducts;
        frmFindCategories frmfindCategory;
        frmFindTradingCo frmfindTradingCo;
        frmCurrentStock frmOpeningStock;
        #endregion
        #region Form Methods And Events
        public frmProducts()
        {
            InitializeComponent();
        }
        private void frmProducts_Load(object sender, EventArgs e)
        {
            //GetMaxProductNo();
            GetALLUOMS();
            LoadNominalAccounts();
        }
        private void frmProducts_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                //GetMaxProductNo();
                //ClearControls();
                this.Close();
            }
            else if (e.KeyChar == (char)Keys.F2)
            {
                frmfindProducts = new frmFindProducts();
                frmfindProducts.ExecuteFindPorudctsEvent +=new frmFindProducts.FindProductsDelegate(frmfindProducts_ExecuteFindPorudctsEvent);
                frmfindProducts.ShowDialog(this);
            }
        }
        #endregion
        #region Simple Methods
        private void GetMaxProductNo()
        {
            var Manager = new ItemsBLL();
            txtProdcutNo.Text = Validation.GetSafeString(Manager.GetMaxProductNo(Operations.IdCompany));
        }
        private bool ValidateControls()
        {
            bool isValid = true;
            if (txtProductName.Text == string.Empty)
            {
                isValid = false;
                MessageBox.Show("Product Description Missing....");
            }
            //else if (txtunitPrice.Text == string.Empty)
            //{
            //    MessageBox.Show("Unit Price Missing....");
            //    isValid = false;
            //}
            if (txtwight.Text == string.Empty)
            {
                isValid = false;
                MessageBox.Show("Product Weight Is Missing....");
            }
            else if (cbxInventoryAccounts.SelectedIndex == -1 || cbxInventoryAccounts.SelectedIndex == 0)
            {
                MessageBox.Show("Inventory Account Missing....");
                isValid = false;
            }
            else if (cbxCogsAccounts.SelectedIndex == -1 || cbxCogsAccounts.SelectedIndex == 0)
            {
                MessageBox.Show("COGS Account Missing....");
                isValid = false;
            }
            else if (cbxSalesAccounts.SelectedIndex == -1 || cbxSalesAccounts.SelectedIndex == 0)
            {
                MessageBox.Show("Sales Account Missing....");
                isValid = false;
            }
            else if (cbxItemType.SelectedIndex == -1 || cbxItemType.SelectedIndex == 0)
            {
                MessageBox.Show("Please Select Item Type....");
                isValid = false;
            }
            return isValid;
        }
        private void ClearControls()
        {
            IdItem = null;
            txtProdcutNo.Text = string.Empty;
            txtProductCode.Text = string.Empty;
            //cbxInventoryAccounts.SelectedIndex = 0;
            //cbxCogsAccounts.SelectedIndex = 0;
            //cbxSalesAccounts.SelectedIndex = 0;
            txtProductName.Text = string.Empty;
            txtwight.Text = string.Empty;
            //txtBatchNo.Text = string.Empty;
            txtBarCode.Text = string.Empty;
            txtMRP.Text = "";
            txtunitPrice.Text = string.Empty;
            txtReorderlevel.Text = string.Empty;
            cbxUOM.SelectedIndex = -1;
            cbxItemType.SelectedIndex = -1;
            //txtStockInHand.Text = string.Empty;
        }
        private void LoadNominalAccounts()
        { 
            var manager = new AccountsBLL();
            #region Fill Products Account

            List<AccountsEL> listInventory = manager.GetAccountsByType("Inventory Accounts", Operations.IdCompany, Operations.IdProject);
            //if (AccountNo == "")
            {
                if (listInventory.Count > 0)
                {

                    listInventory.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "Select Inventory Account" });

                    cbxInventoryAccounts.DataSource = listInventory;
                    cbxInventoryAccounts.DisplayMember = "AccountName";
                    cbxInventoryAccounts.ValueMember = "AccountNo";

                    cbxInventoryAccounts.SelectedIndex = 1;
                }
            }
            
            List<AccountsEL> listSales = manager.GetAccountsByType("Net Sales", Operations.IdCompany, Operations.IdProject);
            //if (AccountNo == "")
            {
                if (listSales.Count > 0)
                {

                    listSales.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "Select Sales Account" });

                    cbxSalesAccounts.DataSource = listSales;
                    cbxSalesAccounts.DisplayMember = "AccountName";
                    cbxSalesAccounts.ValueMember = "AccountNo";

                    cbxSalesAccounts.SelectedIndex = 1;
                }
            }
            List<AccountsEL> listCOGS = manager.GetAccountsByType("Cost Of Sales", Operations.IdCompany, Operations.IdProject);
            //if (AccountNo == "")
            {
                if (listCOGS.Count > 0)
                {

                    listCOGS.Insert(0, new AccountsEL() { AccountNo = "0", AccountName = "Select COGS Account" });

                    cbxCogsAccounts.DataSource = listCOGS;
                    cbxCogsAccounts.DisplayMember = "AccountName";
                    cbxCogsAccounts.ValueMember = "AccountNo";

                    cbxCogsAccounts.SelectedIndex = 1;
                }
            }
            //else
            //{
            //    cbxNaturalAccounts.SelectedValue = AccountNo;
            //}
            #endregion
        }
        private void GetALLUOMS()
        {
            var manager = new UOMBLL();
            List<UOMEL> list = manager.GetAllUOMS();
            if (list.Count > 0)
            {
                cbxUOM.DataSource = list;
                cbxUOM.DisplayMember = "UOMName";
                cbxUOM.ValueMember = "IdUOM";
            }
            else
                cbxUOM.DataSource = null;
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            ItemsEL oelItem = new ItemsEL();
            var Manager = new ItemsBLL();
            List<ItemsEL> list = new List<ItemsEL>();
            if (ValidateControls())
            {
                if (!IdItem.HasValue)
                {
                    oelItem.IdItem = 0;
                }
                else
                {
                    oelItem.IdItem = IdItem;
                }
                oelItem.IdCategory = IdCategory;
                oelItem.IdTradingCo = IdTradingCo;
                oelItem.IdProject = Operations.IdProject;
                oelItem.UserId = Operations.UserID;
               // oelItem.ItemNo = txtProdcutNo.Text;
                oelItem.ProductCode = txtProductCode.Text;
                oelItem.InventoryAccount = Validation.GetSafeString(cbxInventoryAccounts.SelectedValue);
                oelItem.COGSAccount = Validation.GetSafeString(cbxCogsAccounts.SelectedValue);
                oelItem.SalesAccount = Validation.GetSafeString(cbxSalesAccounts.SelectedValue);
                oelItem.ItemName = txtProductName.Text;
                oelItem.Discription = Validation.GetSafeString(txtDiscription.Text);
                oelItem.PackingSize = cbxUOM.Text;
                //oelItem.BatchNo = txtBatchNo.Text;
                oelItem.BarCode = txtBarCode.Text;
                oelItem.AutoWeightItemIndex = cbxItemType.SelectedIndex;
                oelItem.ItemWeight = Validation.GetSafeDecimal(txtwight.Text);
                oelItem.IsActive = true;
                oelItem.CurrentUnitPrice = Validation.GetSafeDecimal(txtunitPrice.Text);
                oelItem.MRP = Validation.GetSafeDecimal(txtMRP.Text);
                //oelItem.UnitPrice = Validation.GetSafeDecimal(txtunitPrice.Text);
                //oelItem.StockOnHandDate = StockDate.Value;
                //oelItem.StockOnHand = Validation.GetSafeInteger(txtStockInHand.Text);
                oelItem.CreatedDateTime = DateTime.Now;
                oelItem.ReorderLevel = Validation.GetSafeInteger(txtReorderlevel.Text);
                //oelItem.PackingSize = "";

                if (!IdItem.HasValue)
                {
                    if (Manager.InsertItems(oelItem))
                    {
                        //GetMaxProductNo();
                        MessageBox.Show("Created Successfully....");
                        ClearControls();
                    }
                }
                else
                {
                    if (Manager.UpdateItems(oelItem))
                    {
                        //GetMaxProductNo();
                        MessageBox.Show("Updated Successfully....");
                        ClearControls();
                    }
                }
            }
            else
            {
            }
        }        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var manager = new ItemsBLL();
            if (manager.DeleteItems(IdItem.Value))
            {
                //GetMaxProductNo();
                ClearControls();
            }
        }
        private void btnNewProduct_Click(object sender, EventArgs e)
        {
            this.ClearControls();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnFindCategory_Click(object sender, EventArgs e)
        {
            frmfindCategory = new frmFindCategories();
            frmfindCategory.ExecuteFindCategoryEvent += new frmFindCategories.FindCategoryDelegate(frmfindCategory_ExecuteFindCategoryEvent);
            frmfindCategory.ShowDialog();
        }
        private void btnFindTradingCo_Click(object sender, EventArgs e)
        {
            frmfindTradingCo = new frmFindTradingCo();
            frmfindTradingCo.ExecuteFindTradingEvent += new frmFindTradingCo.FindTradingDelegate(frmfindTradingCo_ExecuteFindTradingEvent);
            frmfindTradingCo.ShowDialog();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmfindProducts = new frmFindProducts();
            frmfindProducts.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmfindProducts_ExecuteFindPorudctsEvent);
            frmfindProducts.ShowDialog(this);
        }        
        private void btnAddStock_Click(object sender, EventArgs e)
        {
            frmOpeningStock = new frmCurrentStock();
            frmOpeningStock.ShowDialog();
        }
        #endregion
        #region Custom Events And Methods
        void frmfindProducts_ExecuteFindPorudctsEvent(object Sender, ItemsEL oelItems)
        {
            IdItem = oelItems.IdItem.Value;
            GetItem(IdItem);
            //GetItemOpeningStock(IdItem);
        }
        private void GetItem(Int64? Id)
        {
            var manager = new ItemsBLL();
            List<ItemsEL> list = manager.GetItemById(Id.Value);
            if (list.Count > 0)
            {
                txtProdcutNo.Text = list[0].AccountNo.ToString();
                txtProductCode.Text = list[0].ProductCode;
                cbxInventoryAccounts.SelectedValue = list[0].InventoryAccount;
                cbxCogsAccounts.SelectedValue = list[0].COGSAccount;
                cbxSalesAccounts.SelectedValue = list[0].SalesAccount;
                txtProductName.Text = list[0].ItemName;
                txtCategoryName.Text = list[0].CategoryName;
                txtTradingCo.Text = list[0].TradingCode;
                cbxUOM.SelectedIndex = cbxUOM.Items.IndexOf(list[0].PackingSize);
                cbxUOM.Text = list[0].PackingSize;
                //txtPackingSize.Text = list[0].PackingSize;
                //txtBatchNo.Text = list[0].BatchNo;
                txtBarCode.Text = list[0].BarCode;
                cbxItemType.SelectedIndex = list[0].AutoWeightItemIndex;
                txtwight.Text = Validation.GetSafeString(CommonFunctions.RemoveTrailingZeros(list[0].ItemWeight));
                txtunitPrice.Text = list[0].CurrentUnitPrice.ToString();
                txtMRP.Text = list[0].MRP.ToString();
                //txtunitPrice.Text = Validation.GetSafeString(list[0].UnitPrice);
                txtReorderlevel.Text = Validation.GetSafeString(list[0].ReorderLevel);
                //txtStockInHand.Text = Validation.GetSafeString(list[0].StockOnHand);
                IdCategory = list[0].IdCategory;
                IdTradingCo = list[0].IdTradingCo;
                //StockDate.Value = Convert.ToDateTime(list[0].StockOnHandDate);
            }
        }
        void frmfindCategory_ExecuteFindCategoryEvent(object Sender, CategoryEL oelCategory)
        {
            IdCategory = oelCategory.IdCategory;
            txtCategoryName.Text = oelCategory.CategoryName;
        }
        void frmfindTradingCo_ExecuteFindTradingEvent(object Sender, TradingEL oelTrading)
        {
            IdTradingCo = oelTrading.IdTrading;
            txtTradingCo.Text = oelTrading.TradingName;
        }
        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MetroFramework.Controls.MetroTextBox txt = sender as MetroFramework.Controls.MetroTextBox;
            if (e.KeyChar == (char)Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
        private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        #endregion
    }
}
