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
    public partial class frmCurrentStock : MetroForm
    {
        #region Variables
        Int64? IdItem;
        frmFindProducts frmFindItems;
        #endregion
        #region Form Methods And Events
        public frmCurrentStock()
        {
            InitializeComponent();
        }
        private void frmCurrentStock_Load(object sender, EventArgs e)
        {
            this.grdCurrentStock.AutoGenerateColumns = false;
            FillCategories();
            ShowHideColumns();
        }
        private void frmCurrentStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }
        #endregion
        #region SimpleMethods
        private void FillCategories()
        {
            var manager = new CategoryBLL();
            List<CategoryEL> listCategories = manager.GetAllCategories(Operations.IdProject);
            listCategories.Insert(0,new CategoryEL(){ IdCategory = 0, CategoryName = "Please Select Category"});
            listCategories.Insert(1, new CategoryEL() { IdCategory = 0, CategoryName = "No Category Items" });
            CbxCategories.DataSource = listCategories;
            CbxCategories.DisplayMember = "CategoryName";
            CbxCategories.ValueMember = "IdCategory";
        }
        private void GetItemsOpeningStock(Int64? Id)
        {
            var manager = new ItemsBLL();
            if (Id == 0)
                Id = null;
            List<ItemsEL> list = manager.GetItemsCurrentStockByCategory(Id, Operations.IdProject);
            if (list.Count > 0)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i].Qty > 0)
                    {
                        IdItem = list[i].IdItem;
                        break;
                    }
                }
                FillGrid(list);                
            }
            else
            {
                grdCurrentStock.Rows.Clear();
            }
        }
        private void FillGrid(List<ItemsEL> List)
        {
            if (grdCurrentStock.Rows.Count > 0)
            {
                grdCurrentStock.Rows.Clear();
            }
            if (List != null && List.Count > 0)
            {

                for (int i = 0; i < List.Count; i++)
                {
                    grdCurrentStock.Rows.Add();
                    grdCurrentStock.Rows[i].Cells[0].Value = List[i].IdCurrentStock;
                    grdCurrentStock.Rows[i].Cells[1].Value = List[i].IdItem;
                    grdCurrentStock.Rows[i].Cells[2].Value = List[i].ItemNo;
                    grdCurrentStock.Rows[i].Cells[3].Value = List[i].ItemName;
                    grdCurrentStock.Rows[i].Cells[4].Value = List[i].PackingSize;
                    grdCurrentStock.Rows[i].Cells[5].Value = List[i].TotalCartons;
                    grdCurrentStock.Rows[i].Cells[6].Value = List[i].BatchNo;
                    grdCurrentStock.Rows[i].Cells[7].Value = List[i].Expiry;
                    grdCurrentStock.Rows[i].Cells[8].Value = List[i].EngineNo;
                    grdCurrentStock.Rows[i].Cells[9].Value = List[i].ChasisNo;
                    grdCurrentStock.Rows[i].Cells[10].Value = List[i].VehicleModel;
                    if (List[i].ColorCode == 1)
                    {
                        grdCurrentStock.Rows[i].Cells[11].Value = "Red";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        grdCurrentStock.Rows[i].Cells[11].Value = "Black";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        grdCurrentStock.Rows[i].Cells[11].Value = "Blue";
                    }
                    else if (List[i].ColorCode == 1)
                    {
                        grdCurrentStock.Rows[i].Cells[11].Value = "Silver";
                    }
                    grdCurrentStock.Rows[i].Cells[12].Value = List[i].VehicleNo;
                    grdCurrentStock.Rows[i].Cells[13].Value = List[i].FirstIMEI;
                    grdCurrentStock.Rows[i].Cells[14].Value = List[i].SecondIMEI;


                    grdCurrentStock.Rows[i].Cells[15].Value = CommonFunctions.RemoveTrailingZeros(List[i].Qty);
                    grdCurrentStock.Rows[i].Cells[16].Value = CommonFunctions.RemoveTrailingZeros(List[i].Bonus);
                    grdCurrentStock.Rows[i].Cells[17].Value = CommonFunctions.RemoveTrailingZeros(List[i].UnitPrice);
                    grdCurrentStock.Rows[i].Cells[18].Value = CommonFunctions.RemoveTrailingZeros(List[i].TotalAmount);

                }
            }
        }
        private void ShowHideColumns1()
        {
            List<SoftwareTypesEL> list = DataOperations.SoftwareTypes;
            if (list.Count > 0)
            {
                SoftwareTypesEL objActiveType = list.Find(x => x.ActiveSoftware == true);
                if (objActiveType != null)
                {
                    if (objActiveType.SoftwareType == "General Trading")
                    {
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 435;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "General Bhatta")
                    {
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 435;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "General Ledger")
                    {
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 435;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "Medicine General Trading")
                    {
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 435;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "POS")
                    {
                        grdCurrentStock.Columns["colpacking"].Visible = false;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;
                        grdCurrentStock.Columns["colDelete"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 400;
                        grdCurrentStock.Columns["colQty"].Width = 170;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 170;
                        grdCurrentStock.Columns["colAmount"].Width = 170;
                    }
                    else if (objActiveType.SoftwareType == "Motor Bikes")
                    {
                        grdCurrentStock.Columns["colpacking"].Visible = false;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 250;
                    }
                    else if (objActiveType.SoftwareType == "Motor Cars")
                    {
                        grdCurrentStock.Columns["colpacking"].Visible = false;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 250;
                    }
                    else if (objActiveType.SoftwareType == "Medicine Trading")
                    {
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;


                        grdCurrentStock.Columns["colItemName"].Width = 290;
                    }
                    else if (objActiveType.SoftwareType == "Medicine POS")
                    {
                        grdCurrentStock.Columns["colpacking"].Visible = false;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;
                    }
                    else if (objActiveType.SoftwareType == "Mobile Soft")
                    {
                        grdCurrentStock.Columns["colpacking"].Visible = false;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                    }
                }
            }
        }
        private void ShowHideColumns()
        {
            List<SoftwareTypesEL> list = DataOperations.SoftwareTypes;
            if (list.Count > 0)
            {
                SoftwareTypesEL objActiveType = list.Find(x => x.ActiveSoftware == true);
                if (objActiveType != null)
                {
                    if (objActiveType.SoftwareType == "General Trading")
                    {
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;
                        grdCurrentStock.Columns["colBonusUnit"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 435;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "General Bhatta")
                    {
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colBonusUnit"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 600;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "General Ledger")
                    {
                        //grdCurrentStock.Columns["colCartons"].Visible = false;
                        //grdCurrentStock.Columns["colBonusUnit"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 600;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "Medicine General Trading")
                    {
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 500;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "POS")
                    {
                        grdCurrentStock.Columns["colBonusUnit"].Visible = false;
                        grdCurrentStock.Columns["colpacking"].Visible = false;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;
                        grdCurrentStock.Columns["colDelete"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 400;
                        grdCurrentStock.Columns["colQty"].Width = 170;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 170;
                        grdCurrentStock.Columns["colAmount"].Width = 170;
                    }
                    else if (objActiveType.SoftwareType == "Motor Bikes")
                    {
                        grdCurrentStock.Columns["colBonusUnit"].Visible = false;
                        grdCurrentStock.Columns["colpacking"].Visible = false;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 250;
                    }
                    else if (objActiveType.SoftwareType == "Motor Cars")
                    {
                        grdCurrentStock.Columns["colBonusUnit"].Visible = false;
                        grdCurrentStock.Columns["colpacking"].Visible = false;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 250;
                    }
                    else if (objActiveType.SoftwareType == "Medicine Trading")
                    {
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colBonusUnit"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;


                        grdCurrentStock.Columns["colItemName"].Width = 400;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colExpiry"].Width = 100;
                        grdCurrentStock.Columns["colBatchNo"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                        grdCurrentStock.Columns["colTotalAmount"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "Medicine POS")
                    {
                        grdCurrentStock.Columns["colBonusUnit"].Visible = false;
                        grdCurrentStock.Columns["colpacking"].Visible = false;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;
                    }
                    else if (objActiveType.SoftwareType == "Mobile Soft")
                    {
                        grdCurrentStock.Columns["colBonusUnit"].Visible = false;
                        grdCurrentStock.Columns["colpacking"].Visible = true;
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 465;
                    }
                    else if (objActiveType.SoftwareType == "Distribution Trading")
                    {
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 380;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                    }
                    else if (objActiveType.SoftwareType == "Labs Materials Trading")
                    {
                        grdCurrentStock.Columns["colCartons"].Visible = false;
                        grdCurrentStock.Columns["colEngineNo"].Visible = false;
                        grdCurrentStock.Columns["colChassisNo"].Visible = false;
                        grdCurrentStock.Columns["colVehicleNo"].Visible = false;
                        grdCurrentStock.Columns["colBatchNo"].Visible = false;
                        grdCurrentStock.Columns["colExpiry"].Visible = false;
                        grdCurrentStock.Columns["colVehicleModel"].Visible = false;
                        grdCurrentStock.Columns["colVehicleColors"].Visible = false;
                        grdCurrentStock.Columns["colFirstIMEI"].Visible = false;
                        grdCurrentStock.Columns["colSecondIMEI"].Visible = false;
                        grdCurrentStock.Columns["colBonusUnit"].Visible = false;

                        grdCurrentStock.Columns["colItemName"].Width = 535;
                        grdCurrentStock.Columns["colpacking"].Width = 100;
                        grdCurrentStock.Columns["colQty"].Width = 100;
                        grdCurrentStock.Columns["colUnitPrice"].Width = 100;
                        grdCurrentStock.Columns["colTotalAmount"].Width = 170;
                    }
                }
            }
        }
        private void ClearControls()
        {
            CbxCategories.SelectedIndex = 0;
            grdCurrentStock.Rows.Clear();
        }
        #endregion
        #region Button Events
        private void btnSave_Click(object sender, EventArgs e)
        {
            #region Items Fill Code
            ItemsEL oelItem = new ItemsEL();
            var Manager = new ItemsBLL();
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();

            for (int i = 0; i < grdCurrentStock.Rows.Count - 1; i++)
            {
                VoucherDetailEL oelCurrentStock = new VoucherDetailEL();
                if (grdCurrentStock.Rows[i].Cells["ColIdCurrentStock"].Value != null && Validation.GetSafeLong(grdCurrentStock.Rows[i].Cells["ColIdCurrentStock"].Value) > 0)
                {
                    oelCurrentStock.IdCurrentStock = Validation.GetSafeLong(grdCurrentStock.Rows[i].Cells["colIdCurrentStock"].Value);
                    oelCurrentStock.IsNew = false;
                }
                else
                {
                    oelCurrentStock.IdCurrentStock = null;
                    //oelCurrentStock.IsNew = true;
                }
                oelCurrentStock.IdItem = Validation.GetSafeLong(grdCurrentStock.Rows[i].Cells["colIdItem"].Value);
                oelCurrentStock.IdProject = Operations.IdProject;
                oelCurrentStock.PackingSize = Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colpacking"].Value);
                oelCurrentStock.Seq = i + 1;
                oelCurrentStock.TotalCartons = Validation.GetSafeLong(grdCurrentStock.Rows[i].Cells["colCartons"].Value);
                oelCurrentStock.BatchNo = Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colBatchNo"].Value);
                oelCurrentStock.Expiry = Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colExpiry"].Value);
                oelCurrentStock.EngineNo = Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colEngineNo"].Value);
                oelCurrentStock.ChasisNo = Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colChassisNo"].Value);
                oelCurrentStock.VehicleModel = Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colVehicleModel"].Value);
                oelCurrentStock.VehicleNo = Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colVehicleNo"].Value);
                oelCurrentStock.FirstIMEI = Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colFirstIMEI"].Value);
                oelCurrentStock.SecondIMEI = Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colSecondIMEI"].Value);
                if (grdCurrentStock.Rows[i].Cells["colVehicleColors"].Value != null && Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colVehicleColors"].Value) != string.Empty)
                {
                    if (Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colVehicleColors"].Value) == "Red")
                    {
                        oelCurrentStock.ColorCode = 1;
                    }
                    else if (Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colVehicleColors"].Value) == "Black")
                    {
                        oelCurrentStock.ColorCode = 2;
                    }
                    else if (Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colVehicleColors"].Value) == "Blue")
                    {
                        oelCurrentStock.ColorCode = 3;
                    }
                    else if (Validation.GetSafeString(grdCurrentStock.Rows[i].Cells["colVehicleColors"].Value) == "Silver")
                    {
                        oelCurrentStock.ColorCode = 4;
                    }
                }
                oelCurrentStock.Qty = Validation.GetSafeDecimal(grdCurrentStock.Rows[i].Cells["colQty"].Value);
                oelCurrentStock.Bonus = Validation.GetSafeDecimal(grdCurrentStock.Rows[i].Cells["colBonusUnit"].Value);
                oelCurrentStock.UnitPrice = Validation.GetSafeDecimal(grdCurrentStock.Rows[i].Cells["colUnitPrice"].Value);
                oelCurrentStock.CurrentUnitPrice = Validation.GetSafeLong(grdCurrentStock.Rows[i].Cells["colUnitPrice"].Value);
                oelCurrentStock.TotalAmount = Validation.GetSafeDecimal(grdCurrentStock.Rows[i].Cells["colTotalAmount"].Value);
                list.Add(oelCurrentStock);
            }
            #endregion
            #region Saving Code Section
            if (Manager.InsertUpdateCurrentStock(list))
            {
                MessageBox.Show("Opening Stock Inserted / Updated Successfully....");               
                //GetMaxProductNo();
                ClearControls();
            }
            //if (!IdItem.HasValue)
            //{
            //    if (Manager.InsertCurrentStock(list))
            //    {
            //        MessageBox.Show("Opening Stock Inserted Successfully....");
            //        CbxCategories.SelectedIndex = 0;
            //        //GetMaxProductNo();
            //        //ClearControls();
            //    }
            //}
            //else
            //{
            //    if (Manager.UpdateCurrentStock(list))
            //    {
            //        MessageBox.Show("Opening Stock Updated Successfully....");
            //        //GetMaxProductNo();
            //        //ClearControls();
            //    }
            //}
            #endregion
        }
        #endregion 
        #region Other Controls Events And Methods
        private void CbxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbxCategories.SelectedIndex > 0)
            {
                GetItemsOpeningStock(Validation.GetSafeLong(CbxCategories.SelectedValue));
            }
            else
            {
                grdCurrentStock.DataSource = null;
            }
        }
        void txtItemName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (grdCurrentStock.CurrentCellAddress.X == 3)
            {
                if (e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Escape)
                {
                    frmFindItems = new frmFindProducts();
                    frmFindItems.ExecuteFindPorudctsEvent += new frmFindProducts.FindProductsDelegate(frmFindItems_ExecuteFindPorudctsEvent);
                    frmFindItems.SearchText = e.KeyChar.ToString();
                    frmFindItems.ShowDialog(this);
                    e.Handled = true;
                    SendKeys.Send("{TAB}");
                }
                else if (e.KeyChar == (char)Keys.Back)
                {

                }
                else
                    e.Handled = true;
            }
        }
        void frmFindItems_ExecuteFindPorudctsEvent(object Sender, ItemsEL oelItems)
        {
            var manager = new ItemsBLL();
            //if (manager.VerifyAccount(Operations.IdCompany, "Items", oelItems.AccountNo).Count > 0)
            {
                //for (int i = 0; i < grdCurrentStock.Rows.Count - 1; i++)
                //{
                //    if (grdCurrentStock.Rows[i].Cells["colItemNo"].Value != null)
                //    {
                //        if (oelItems.AccountNo == Validation.GetSafeLong(grdCurrentStock.Rows[i].Cells["colItemNo"].Value))
                //        {
                //            lblStatuMessage.Text = "Product Already exists";
                //            return;
                //        }
                //    }
                //}
                grdCurrentStock.CurrentRow.Cells["colIdItem"].Value = oelItems.IdItem;
                grdCurrentStock.CurrentRow.Cells["colItemName"].Value = oelItems.ItemName;
                grdCurrentStock.CurrentRow.Cells["colpacking"].Value = oelItems.PackingSize;
                //grdCurrentStock.CurrentRow.Cells["ColBatch"].Value = oelItems.BatchNo;
            }
        }
        #endregion
        #region Grid Events
        private void grdCurrentStock_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (grdCurrentStock.CurrentCellAddress.X == 3)
            {
                TextBox txtItemName = e.Control as TextBox;
                if (txtItemName != null)
                {
                    txtItemName.KeyPress -= new KeyPressEventHandler(txtItemName_KeyPress);
                    txtItemName.KeyPress += new KeyPressEventHandler(txtItemName_KeyPress);
                }
            }
        }
        private void grdCurrentStock_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var manager = new ItemsBLL();
            if (e.ColumnIndex == 15)
            {
                grdCurrentStock.Rows[e.RowIndex].Cells["colUnitPrice"].Value = manager.GetItemById(Validation.GetSafeLong(grdCurrentStock.Rows[e.RowIndex].Cells["colIdItem"].Value))[0].CurrentUnitPrice;
            }
            else if (e.ColumnIndex == 17)
            {
                grdCurrentStock.Rows[e.RowIndex].Cells["colTotalAmount"].Value = Validation.GetSafeDecimal(grdCurrentStock.Rows[e.RowIndex].Cells["colQty"].Value) *
                                                                                 Validation.GetSafeDecimal(grdCurrentStock.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
            }
        }
        private void grdCurrentStock_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 17)
            {
                grdCurrentStock.Rows[e.RowIndex].Cells["colTotalAmount"].Value = Validation.GetSafeDecimal(grdCurrentStock.Rows[e.RowIndex].Cells["colQty"].Value) *
                                                                                 Validation.GetSafeDecimal(grdCurrentStock.Rows[e.RowIndex].Cells["colUnitPrice"].Value);
            }
        }
        #endregion       
    }
}
