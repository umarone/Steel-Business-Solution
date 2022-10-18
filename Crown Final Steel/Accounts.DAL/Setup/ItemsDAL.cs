using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Accounts.EL;
using Accounts.Common;

namespace Accounts.DAL
{
    public class ItemsDAL
    {
        IDataReader objReader;
        public bool InsertItems(ItemsEL oelItems, SqlConnection objConn)
        {
            lock (this)
            {
                EntityoperationInfo infoResult = new EntityoperationInfo();
                try
                {
                    SqlCommand cmdItems = new SqlCommand("[Setup].[Proc_CreateItems]", objConn);

                    cmdItems.CommandType = CommandType.StoredProcedure;
                    cmdItems.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelItems.IdItem;
                    cmdItems.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelItems.IdProject;
                    cmdItems.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelItems.UserId;
                    cmdItems.Parameters.Add(new SqlParameter("@IdCategory", DbType.Int64)).Value = oelItems.IdCategory;
                    cmdItems.Parameters.Add(new SqlParameter("@IdTradingCo", DbType.Int64)).Value = oelItems.IdTradingCo;
                    //cmdItems.Parameters.Add(new SqlParameter("@ItemNo", DbType.Int64)).Value = oelItems.ItemNo;
                    cmdItems.Parameters.Add(new SqlParameter("@ItemCode", DbType.String)).Value = oelItems.ProductCode;
                    cmdItems.Parameters.Add(new SqlParameter("@InventoryAccount", DbType.String)).Value = oelItems.InventoryAccount;
                    cmdItems.Parameters.Add(new SqlParameter("@COGSAccount", DbType.String)).Value = oelItems.COGSAccount;
                    cmdItems.Parameters.Add(new SqlParameter("@SalesAccount", DbType.String)).Value = oelItems.SalesAccount;
                    cmdItems.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelItems.ItemName;
                    cmdItems.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelItems.Discription;
                    cmdItems.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = oelItems.PackingSize;
                    //cmdItems.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelItems.BatchNo;
                    cmdItems.Parameters.Add(new SqlParameter("@BarCode", DbType.String)).Value = oelItems.BarCode;
                    cmdItems.Parameters.Add(new SqlParameter("@AutoWeightItemIndex", DbType.Int32)).Value = oelItems.AutoWeightItemIndex;
                    cmdItems.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelItems.ItemWeight;
                    cmdItems.Parameters.Add(new SqlParameter("@CalculatedUnitPrice", DbType.Decimal)).Value = oelItems.CurrentUnitPrice;
                    cmdItems.Parameters.Add(new SqlParameter("@MRP", DbType.Decimal)).Value = oelItems.MRP;
                    cmdItems.Parameters.Add(new SqlParameter("@ReorderLevel", DbType.Int32)).Value = oelItems.ReorderLevel;
                    cmdItems.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelItems.CreatedDateTime;
                    cmdItems.Parameters.Add(new SqlParameter("@IsActive", DbType.Int32)).Value = oelItems.IsActive;
                    cmdItems.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    objConn.Dispose();
                    return false;
                }
                finally
                {
                    objConn.Dispose();
                }
                return true;
            }

        }

        public bool UpdateItems(ItemsEL oelItems, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                SqlCommand cmdItems = new SqlCommand("[Setup].[Proc_UpdateItems]", objConn);

                cmdItems.CommandType = CommandType.StoredProcedure;
                cmdItems.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelItems.IdItem;
                cmdItems.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelItems.IdProject;
                cmdItems.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelItems.UserId;
                cmdItems.Parameters.Add(new SqlParameter("@IdCategory", DbType.Int64)).Value = oelItems.IdCategory;
                cmdItems.Parameters.Add(new SqlParameter("@IdTradingCo", DbType.Int64)).Value = oelItems.IdTradingCo;
                cmdItems.Parameters.Add(new SqlParameter("@ItemCode", DbType.String)).Value = oelItems.ProductCode;
                cmdItems.Parameters.Add(new SqlParameter("@InventoryAccount", DbType.String)).Value = oelItems.InventoryAccount;
                cmdItems.Parameters.Add(new SqlParameter("@COGSAccount", DbType.String)).Value = oelItems.COGSAccount;
                cmdItems.Parameters.Add(new SqlParameter("@SalesAccount", DbType.String)).Value = oelItems.SalesAccount;
                cmdItems.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelItems.ItemName;
                cmdItems.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelItems.Discription;
                cmdItems.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = oelItems.PackingSize;
                //cmdItems.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelItems.BatchNo;
                cmdItems.Parameters.Add(new SqlParameter("@BarCode", DbType.String)).Value = oelItems.BarCode;
                cmdItems.Parameters.Add(new SqlParameter("@AutoWeightItemIndex", DbType.Int32)).Value = oelItems.AutoWeightItemIndex;
                cmdItems.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelItems.ItemWeight;
                cmdItems.Parameters.Add(new SqlParameter("@CalculatedUnitPrice", DbType.Decimal)).Value = oelItems.CurrentUnitPrice;
                cmdItems.Parameters.Add(new SqlParameter("@MRP", DbType.Decimal)).Value = oelItems.MRP;
                cmdItems.Parameters.Add(new SqlParameter("@ReorderLevel", DbType.Int32)).Value = oelItems.ReorderLevel;
                cmdItems.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelItems.CreatedDateTime;
                cmdItems.Parameters.Add(new SqlParameter("@IsActive", DbType.Int32)).Value = oelItems.IsActive;

                cmdItems.ExecuteNonQuery();
                //UpdateCurrentStock(list, objConn, objTran);               
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                objConn.Dispose();
            }
            return true;
        }
        public bool InsertCurrentStock(List<ItemsEL> list, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlCommand cmdItems = new SqlCommand("[Setup].[Proc_CreateCurrentStock]", objConn);
            for (int i = 0; i < list.Count; i++)
            {
                cmdItems.CommandType = CommandType.StoredProcedure;
                cmdItems.Parameters.Add(new SqlParameter("@IdCurrentStock", DbType.Int64)).Value = list[i].IdCurrentStock;
                cmdItems.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = list[i].IdProject;
                cmdItems.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = list[i].IdItem;
                cmdItems.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = list[i].BookNo;
                cmdItems.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = list[i].Seq;
                cmdItems.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = list[i].PackingSize;
                cmdItems.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = list[i].TotalCartons;
                cmdItems.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = list[i].BatchNo;
                cmdItems.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = list[i].Expiry;
                cmdItems.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = list[i].EngineNo;
                cmdItems.Parameters.Add(new SqlParameter("@chasisNo", DbType.String)).Value = list[i].ChasisNo;
                cmdItems.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = list[i].VehicleNo;
                cmdItems.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = list[i].FirstIMEI;
                cmdItems.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = list[i].SecondIMEI;
                cmdItems.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = list[i].ColorCode;
                cmdItems.Parameters.Add(new SqlParameter("@Units", DbType.Int64)).Value = list[i].Qty;
                cmdItems.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = list[i].UnitPrice;
                cmdItems.Parameters.Add(new SqlParameter("@CurrentUnitPrice", DbType.Decimal)).Value = list[i].CurrentUnitPrice;
                cmdItems.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = list[i].TotalAmount;
                cmdItems.ExecuteNonQuery();
                cmdItems.Parameters.Clear();
            }
            return true;
        }
        
        public bool DeleteItems(Int64 IdItem, SqlConnection objConn)
        {
            using (SqlTransaction oTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteItem = new SqlCommand("[Setup].[Proc_DeleteItem]", objConn);
                    cmdDeleteItem.Connection = objConn;
                    cmdDeleteItem.CommandType = CommandType.StoredProcedure;
                    cmdDeleteItem.Transaction = oTran;
                    cmdDeleteItem.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;
                    cmdDeleteItem.ExecuteNonQuery();

                    oTran.Commit();
                }
                catch (Exception ex)
                {
                    oTran.Rollback();
                    throw ex;
                }
            }
            return true;
        }
        public bool UpdateCurrentStock(List<ItemsEL> list, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlCommand cmdItems = new SqlCommand();
            cmdItems.Connection = objConn;
            //cmdItems.Transaction = objTran;
            cmdItems.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IsNew == false)
                {
                    cmdItems.CommandText = "[Setup].[Proc_UpdateCurrentStock]";
                }
                else
                {
                    cmdItems.CommandText = "[Setup].[Proc_CreateCurrentStock]";
                }
                cmdItems.Parameters.Add(new SqlParameter("@IdCurrentStock", DbType.Int64)).Value = list[i].IdCurrentStock;
                cmdItems.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = list[i].IdProject;
                cmdItems.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = list[i].IdItem;
                cmdItems.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = list[i].BookNo;
                cmdItems.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = list[i].Seq;
                cmdItems.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = list[i].PackingSize;
                cmdItems.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = list[i].TotalCartons;
                cmdItems.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = list[i].BatchNo;
                cmdItems.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = list[i].Expiry;
                cmdItems.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = list[i].EngineNo;
                cmdItems.Parameters.Add(new SqlParameter("@chasisNo", DbType.String)).Value = list[i].ChasisNo;
                cmdItems.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = list[i].VehicleNo;
                cmdItems.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = list[i].FirstIMEI;
                cmdItems.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = list[i].SecondIMEI;
                cmdItems.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = list[i].ColorCode;
                cmdItems.Parameters.Add(new SqlParameter("@Units", DbType.Int64)).Value = list[i].Qty;
                cmdItems.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = list[i].UnitPrice;
                cmdItems.Parameters.Add(new SqlParameter("@CurrentUnitPrice", DbType.Decimal)).Value = list[i].CurrentUnitPrice;
                cmdItems.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = list[i].TotalAmount;
                cmdItems.ExecuteNonQuery();
                cmdItems.Parameters.Clear();
            }
            return true;
        }
        public bool InsertUpdateCurrentStock(List<VoucherDetailEL> list, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction objTran = objConn.BeginTransaction();
            SqlCommand cmdItems = new SqlCommand();
            cmdItems.Connection = objConn;
            cmdItems.Transaction = objTran;
            cmdItems.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].IdCurrentStock.HasValue)
                {
                    cmdItems.CommandText = "[Setup].[Proc_UpdateCurrentStock]";
                }
                else
                {
                    cmdItems.CommandText = "[Setup].[Proc_CreateCurrentStock]";
                }
                cmdItems.Parameters.Add(new SqlParameter("@IdCurrentStock", DbType.Int64)).Value = list[i].IdCurrentStock;
                cmdItems.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = list[i].IdProject;
                cmdItems.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = list[i].IdItem;
                cmdItems.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = list[i].BookNo;
                cmdItems.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = list[i].Seq;
                cmdItems.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = list[i].PackingSize;
                cmdItems.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = list[i].TotalCartons;
                cmdItems.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = list[i].BatchNo;
                cmdItems.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = list[i].Expiry;
                cmdItems.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = list[i].EngineNo;
                cmdItems.Parameters.Add(new SqlParameter("@chasisNo", DbType.String)).Value = list[i].ChasisNo;
                cmdItems.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = list[i].VehicleNo;
                cmdItems.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = list[i].FirstIMEI;
                cmdItems.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = list[i].SecondIMEI;
                cmdItems.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = list[i].ColorCode;
                cmdItems.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = list[i].Qty;
                cmdItems.Parameters.Add(new SqlParameter("@BonusUnits", DbType.Decimal)).Value = list[i].Bonus;
                cmdItems.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = list[i].UnitPrice;
                cmdItems.Parameters.Add(new SqlParameter("@CurrentUnitPrice", DbType.Decimal)).Value = list[i].CurrentUnitPrice;
                cmdItems.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = list[i].TotalAmount;
                cmdItems.ExecuteNonQuery();
                cmdItems.Parameters.Clear();
            }
            UpdateEvaluationPrice(list, objTran, objConn);
            objTran.Commit();
            return true;
        }
        public void UpdateCurrentUnitPrice(List<ItemsEL> list, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlCommand cmdItems = new SqlCommand();
            cmdItems.Connection = objConn;
            cmdItems.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < list.Count; i++)
            {

                cmdItems.CommandText = "[Setup].[Proc_UpdateCurrentUnitPrice]";
                cmdItems.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = list[i].IdItem;
                cmdItems.Parameters.Add(new SqlParameter("@CurrentUnitPrice", DbType.Decimal)).Value = list[i].CurrentUnitPrice;

                cmdItems.ExecuteNonQuery();
                cmdItems.Parameters.Clear();
            }
        }
        public void UpdateEvaluationPrice(List<VoucherDetailEL> list, SqlTransaction objTransaction, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            decimal AVGValue = 0;
            SqlCommand cmdItems = new SqlCommand();
            cmdItems.Connection = objConn;
            cmdItems.Transaction = objTransaction;
            cmdItems.CommandType = CommandType.StoredProcedure;

            for (int i = 0; i < list.Count; i++)
            {

                cmdItems.CommandText = "[Setup].[Proc_UpdateEvaulationPrice]";
                AVGValue = GetItemsAvgValue(list[i].IdItem.Value, objConn, objTransaction);
                if (AVGValue == 0 || AVGValue == Validation.GetSafeDecimal(0.00))
                {
                    AVGValue = list[i].UnitPrice;
                }
                cmdItems.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = list[i].IdItem;
                cmdItems.Parameters.Add(new SqlParameter("@EvaluationPrice", DbType.Decimal)).Value = list[i].UnitPrice;
                cmdItems.Parameters.Add(new SqlParameter("@AvgEvaluationPrice", DbType.Decimal)).Value = AVGValue;
                cmdItems.ExecuteNonQuery();
                cmdItems.Parameters.Clear();
            }

        }
        public Int64 GetMaxProductNo(Int64 IdCompany, SqlConnection objConn)
        {
            SqlCommand cmdAccount = new SqlCommand("[Setup].[Proc_GetMaxProductNo]", objConn);
            cmdAccount.CommandType = CommandType.StoredProcedure;
            cmdAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            return Validation.GetSafeLong(cmdAccount.ExecuteScalar());

        }
        public List<ItemsEL> GetPriceWiseItems(Int64 IdProject, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            using (SqlCommand cmdPriceList = new SqlCommand("[Setup].[Proc_GetPriceWiseItems]", objConn))
            {
                cmdPriceList.CommandType = CommandType.StoredProcedure;
                cmdPriceList.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
                objReader = cmdPriceList.ExecuteReader();
                while (objReader.Read())
                {
                    ItemsEL oelItems = new ItemsEL();
                    oelItems.ItemNo = objReader["ItemNo"].ToString();
                    oelItems.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelItems.ItemName = objReader["ItemName"].ToString();
                    if (objReader["packingsize"] != DBNull.Value)
                    {
                        oelItems.PackingSize = objReader["packingsize"].ToString();
                    }
                    else
                    {
                        oelItems.PackingSize = "";
                    }
                    //if (objReader["ProductRegNo"] != DBNull.Value)
                    //{
                    //    oelItems.ProductRegNo = objReader["ProductRegNo"].ToString();
                    //}
                    oelItems.Description = objReader["Description"].ToString();
                    if (objReader["UnitPrice"] != DBNull.Value)
                    {
                        oelItems.UnitPrice = Convert.ToDecimal(objReader["UnitPrice"]);
                    }
                    list.Add(oelItems);
                }
            }
            return list;
        }
        public bool CreateUpdatePriceList(List<ItemsEL> oelItemsCollection, Int64 IdProject, SqlConnection objConn)
        {
            using (SqlTransaction objTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdPriceList = new SqlCommand("[Setup].[Proc_CreateUpdatePriceList]", objConn);
                    cmdPriceList.Transaction = objTran;
                    cmdPriceList.CommandType = CommandType.StoredProcedure;
                    for (int i = 0; i < oelItemsCollection.Count; i++)
                    {
                        cmdPriceList.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = oelItemsCollection[i].IdItem;
                        cmdPriceList.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
                        cmdPriceList.Parameters.Add("@ItemName", SqlDbType.NVarChar).Value = oelItemsCollection[i].ItemName;
                        cmdPriceList.Parameters.Add("@Description", SqlDbType.NVarChar).Value = oelItemsCollection[i].Description;
                        cmdPriceList.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = oelItemsCollection[i].MRP;
                        //cmdPriceList.Parameters.Add("@ProductRegNo", SqlDbType.VarChar).Value = oelItemsCollection[i].ProductRegNo;
                        cmdPriceList.ExecuteNonQuery();
                        cmdPriceList.Parameters.Clear();
                    }
                    objTran.Commit();
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    objTran.Dispose();
                    throw ex;
                }
                finally
                {
                    objTran.Dispose();
                }
            }
            return true;
        }
        public bool UpdateStockCalculationRateList(ItemsEL oelItemsCollection, Int64 IdProject, SqlConnection objConn)
        {

            SqlCommand cmdPriceList = new SqlCommand("[Setup].[Proc_UpdateStockCalcuationRates]", objConn);
            cmdPriceList.CommandType = CommandType.StoredProcedure;
            //for (int i = 0; i < oelItemsCollection.Count; i++)
            //{
            cmdPriceList.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = oelItemsCollection.IdItem;
            cmdPriceList.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdPriceList.Parameters.Add("@UnitPrice", SqlDbType.Decimal).Value = oelItemsCollection.CurrentUnitPrice;
            cmdPriceList.ExecuteNonQuery();
            cmdPriceList.Parameters.Clear();
            //}
            //objTran.Commit();

            return true;
        }
        public List<ItemsEL> VerifyAccount(Int64 IdCompany, string Type, string AccountNo, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            using (SqlCommand cmdVerifyAccount = new SqlCommand("[Setup].[Proc_VerifyAccount]", objConn))
            {
                cmdVerifyAccount.CommandType = CommandType.StoredProcedure;
                cmdVerifyAccount.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdVerifyAccount.Parameters.Add("@Type", SqlDbType.VarChar).Value = Type;
                cmdVerifyAccount.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdVerifyAccount.ExecuteReader();
                while (objReader.Read())
                {
                    ItemsEL oelItem = new ItemsEL();
                    oelItem.ItemNo = objReader["ItemNo"].ToString();
                    list.Add(oelItem);
                }
            }
            return list;
        }
        public decimal GetItemPriceByCode(Int64 ItemNo, Int64 IdCompany, SqlConnection objConn)
        {
            using (SqlCommand cmdItemPrice = new SqlCommand("[Setup].[Proc_GetItemPriceByCode]", objConn))
            {
                cmdItemPrice.CommandType = CommandType.StoredProcedure;
                cmdItemPrice.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdItemPrice.Parameters.Add("@ItemNo", SqlDbType.BigInt).Value = ItemNo;
                return Convert.ToDecimal(cmdItemPrice.ExecuteScalar());
            }
        }
        public List<ItemsEL> GetItemPriceAndSizeByCode(Int64 ItemNo, Int64 IdCompany, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("[Setup].[Proc_GetItemPriceAndSizeByCode]", objConn);

            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            cmdSearchAccount.Parameters.Add("@ItemNo", SqlDbType.BigInt).Value = ItemNo;

            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchAccount.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.MRP = Validation.GetSafeDecimal(oReader["MRP"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        //public List<StockReceiptEL> GetStockByItemNo(string ItemNo,SqlConnection objConn)
        //{
        //    List<StockReceiptEL> list = new List<StockReceiptEL>();
        //    using (SqlCommand cmdStockReceipt = new SqlCommand("sp_GetStockByItemNo", objConn))
        //    {
        //        cmdStockReceipt.CommandType = CommandType.StoredProcedure;
        //        cmdStockReceipt.CommandTimeout = 0;
        //        cmdStockReceipt.Parameters.Add("@ItemNo", SqlDbType.NVarChar).Value = ItemNo;
        //        objReader = cmdStockReceipt.ExecuteReader();
        //        while (objReader.Read())
        //        {
        //            StockReceiptEL oelStockReceipt = new StockReceiptEL();
        //            oelStockReceipt.IdStockReceipt = new Guid(objReader["stockreceipt_id"].ToString());
        //            oelStockReceipt.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
        //            oelStockReceipt.ItemNo = objReader["ItemNo"].ToString();
        //            oelStockReceipt.Units = Convert.ToInt64(objReader["Units"]);
        //            oelStockReceipt.RemainingUnits = Convert.ToInt64(objReader["RemainingUnits"]);
        //            oelStockReceipt.Amount = Convert.ToDecimal(objReader["Amount"]);
        //            list.Add(oelStockReceipt);
        //        }
        //    }
        //    return list;
        //}
        public List<PurchaseDetailEL> GetStockByItemNo(string ItemNo, SqlConnection objConn)
        {
            List<PurchaseDetailEL> list = new List<PurchaseDetailEL>();
            using (SqlCommand cmdPurchaseDetail = new SqlCommand("sp_GetStockByItemNo", objConn))
            {
                cmdPurchaseDetail.CommandType = CommandType.StoredProcedure;
                cmdPurchaseDetail.CommandTimeout = 0;
                cmdPurchaseDetail.Parameters.Add("@ItemNo", SqlDbType.NVarChar).Value = ItemNo;
                objReader = cmdPurchaseDetail.ExecuteReader();
                while (objReader.Read())
                {
                    PurchaseDetailEL obj = new PurchaseDetailEL();
                    obj.IdPurchaseDetail = new Guid(objReader["PurchaseDetail_Id"].ToString());
                    obj.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
                    obj.ItemNo = objReader["ItemNo"].ToString();
                    obj.Units = Convert.ToInt64(objReader["Units"]);
                    obj.UnitPrice = Convert.ToDecimal(objReader["UnitPrice"]);
                    obj.RemainingUnits = Convert.ToInt64(objReader["RemainingUnits"]);
                    obj.Amount = Convert.ToDecimal(objReader["Amount"]);
                    list.Add(obj);
                }
            }
            return list;
        }
        public Int64 GetDateWiseItemTotalQuantity(Guid IdItem, string PackingSize, string BatchNo, DateTime StockDate, Int64 IdCompany, SqlConnection objConn)
        {
            using (SqlCommand cmdItemQuantity = new SqlCommand("[Transactions].[Proc_GetDateWiseItemTotalQuantity]", objConn))
            {
                cmdItemQuantity.CommandType = CommandType.StoredProcedure;
                cmdItemQuantity.Parameters.Add("@IdCompany", SqlDbType.UniqueIdentifier).Value = IdCompany;
                cmdItemQuantity.Parameters.Add("@IdItem", SqlDbType.UniqueIdentifier).Value = IdItem;
                cmdItemQuantity.Parameters.Add("@PackingSize", SqlDbType.VarChar).Value = PackingSize;
                cmdItemQuantity.Parameters.Add("@BatchNo", SqlDbType.VarChar).Value = BatchNo;
                cmdItemQuantity.Parameters.Add("@StockDate", SqlDbType.DateTime).Value = StockDate;
                return Validation.GetSafeLong(cmdItemQuantity.ExecuteScalar());
            }
        }
        public Int64 GetItemCurrentTotalQuantity(Guid IdItem, string PackingSize, string BatchNo, Int64 IdCompany, SqlConnection objConn)
        {
            using (SqlCommand cmdItemQuantity = new SqlCommand("[Transactions].[Proc_GetItemCurrentTotalQuantity]", objConn))
            {
                cmdItemQuantity.CommandType = CommandType.StoredProcedure;
                cmdItemQuantity.Parameters.Add("@IdCompany", SqlDbType.UniqueIdentifier).Value = IdCompany;
                cmdItemQuantity.Parameters.Add("@IdItem", SqlDbType.UniqueIdentifier).Value = IdItem;
                cmdItemQuantity.Parameters.Add("@PackingSize", SqlDbType.VarChar).Value = PackingSize;
                cmdItemQuantity.Parameters.Add("@BatchNo", SqlDbType.VarChar).Value = BatchNo;
                return Validation.GetSafeLong(cmdItemQuantity.ExecuteScalar());
            }
        }
        public ItemsEL GetItemByAccount(Int64 ItemNo, Int64 IdCompany, SqlConnection objConn)
        {
            ItemsEL oelItem = new ItemsEL();
            using (SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetItemByAccount]", objConn))
            {
                cmdItem.CommandType = CommandType.StoredProcedure;
                cmdItem.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdItem.Parameters.Add("@ItemNo", SqlDbType.BigInt).Value = ItemNo;
                objReader = cmdItem.ExecuteReader();
                while (objReader.Read())
                {
                    oelItem.ItemName = objReader["ItemName"].ToString();
                    if (objReader["PackingSize"] != DBNull.Value)
                    {
                        oelItem.PackingSize = objReader["PackingSize"].ToString();
                    }
                    else
                    {
                        oelItem.Description = "";
                    }

                    if (objReader["Description"] != DBNull.Value)
                    {
                        oelItem.Description = objReader["Description"].ToString();
                    }
                    else
                    {
                        oelItem.Description = "";
                    }
                }
                return oelItem;
            }
        }
        public List<ItemsEL> SearchStockItemsByItemNo(Int64 ItemNo, Int64 IdCompany, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("[Setup].[Proc_SearchStockItemsByItemNo]", objConn);

            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            cmdSearchAccount.Parameters.Add("@ItemNo", SqlDbType.BigInt).Value = ItemNo;

            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchAccount.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.Discription = Validation.GetSafeString(oReader["Description"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> SearchStockItemsByItemName(string ItemName, Int64 IdCompany, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("[Setup].[Proc_SearchStockItemsByItemName]", objConn);

            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            cmdSearchAccount.Parameters.Add("@ItemName", SqlDbType.VarChar).Value = ItemName;

            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchAccount.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.Discription = Validation.GetSafeString(oReader["Description"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> GetItemById(Int64 IdItem, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetItemById]", objConn);

            cmdItem.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;

            cmdItem.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdItem.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.IdCategory = Validation.GetSafeLong(oReader["Category_Id"]);
                oelItems.IdTradingCo = Validation.GetSafeLong(oReader["Trading_Id"]);
                oelItems.TradingCode = Validation.GetSafeString(oReader["Trading_Name"]);
                oelItems.AccountNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ProductCode = Validation.GetSafeString(oReader["ItemCode"]);
                oelItems.InventoryAccount = Validation.GetSafeString(oReader["InventoryAccount"]);
                oelItems.COGSAccount = Validation.GetSafeString(oReader["COGSAccount"]);
                oelItems.SalesAccount = Validation.GetSafeString(oReader["SalesAccount"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.CategoryName = Validation.GetSafeString(oReader["Category_Name"]);
                //oelItems.BatchNo = Validation.GetSafeString(oReader["BatchNo"]);
                oelItems.CurrentUnitPrice = Validation.GetSafeDecimal(oReader["CalculatedUnitPrice"]);
                oelItems.MRP = Validation.GetSafeDecimal(oReader["MRP"]);
                //oelItems.UnitPrice = Validation.GetSafeDecimal(oReader["UnitPrice"]);
                oelItems.BarCode = Validation.GetSafeString(oReader["BarCode"]);
                oelItems.AutoWeightItemIndex = Validation.GetSafeInteger(oReader["AutoWeightItemIndex"]);
                oelItems.ItemWeight = Validation.GetSafeDecimal(oReader["ItemWeight"]);
                //oelItems.StockOnHand = Validation.GetSafeInteger(oReader["StockOnHand"]);
                oelItems.ReorderLevel = Validation.GetSafeInteger(oReader["ReorderLevel"]);
                //oelItems.StockOnHandDate = Convert.ToDateTime(oReader["OnHandDate"]);
                //oelItems.CreatedDateTime = Convert.ToDateTime(oReader["StockInHandDate"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                oelItems.AVGEvaluationUnitPrice = Validation.GetSafeDecimal(oReader["AVGEvaluationPrice"]);
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> GetItemByBarCode(string BarCode, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetItemByBarCode]", objConn);

            cmdItem.Parameters.Add("@BarCode", SqlDbType.VarChar).Value = BarCode;

            cmdItem.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdItem.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.IdCategory = Validation.GetSafeLong(oReader["Category_Id"]);
                oelItems.IdTradingCo = Validation.GetSafeLong(oReader["Trading_Id"]);
                oelItems.TradingCode = Validation.GetSafeString(oReader["Trading_Name"]);
                oelItems.AccountNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ProductCode = Validation.GetSafeString(oReader["ItemCode"]);
                oelItems.InventoryAccount = Validation.GetSafeString(oReader["InventoryAccount"]);
                oelItems.COGSAccount = Validation.GetSafeString(oReader["COGSAccount"]);
                oelItems.SalesAccount = Validation.GetSafeString(oReader["SalesAccount"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.CategoryName = Validation.GetSafeString(oReader["Category_Name"]);
                //oelItems.BatchNo = Validation.GetSafeString(oReader["BatchNo"]);
                oelItems.CurrentUnitPrice = Validation.GetSafeDecimal(oReader["CalculatedUnitPrice"]);
                oelItems.MRP = Validation.GetSafeDecimal(oReader["MRP"]);
                //oelItems.UnitPrice = Validation.GetSafeDecimal(oReader["UnitPrice"]);
                oelItems.BarCode = Validation.GetSafeString(oReader["BarCode"]);
                //oelItems.StockOnHand = Validation.GetSafeInteger(oReader["StockOnHand"]);
                oelItems.ReorderLevel = Validation.GetSafeInteger(oReader["ReorderLevel"]);
                //oelItems.StockOnHandDate = Convert.ToDateTime(oReader["OnHandDate"]);
                //oelItems.CreatedDateTime = Convert.ToDateTime(oReader["StockInHandDate"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                oelItems.AVGEvaluationUnitPrice = Validation.GetSafeDecimal(oReader["AVGEvaluationPrice"]);
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> GetItemsByCategory(Int64? IdCategory, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetItemsByCategory]", objConn);

            cmdItem.Parameters.Add("@IdCategory", SqlDbType.BigInt).Value = IdCategory;

            cmdItem.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdItem.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.IdCategory = Validation.GetSafeLong(oReader["Category_Id"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.BarCode = Validation.GetSafeString(oReader["BarCode"]);
                oelItems.ProductCode = Validation.GetSafeString(oReader["ItemCode"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.MRP = Validation.GetSafeDecimal(oReader["MRP"]);
                oelItems.CategoryName = Validation.GetSafeString(oReader["Category_Name"]);
                oelItems.BrandName = Validation.GetSafeString(oReader["Trading_Name"]);
                oelItems.MRP = Validation.GetSafeDecimal(oReader["MRP"]);
                oelItems.LastPurchaseRate = Validation.GetSafeDecimal(oReader["LastPurchaseRate"]);
                oelItems.ClosingStock = Validation.GetSafeDecimal(oReader["Closing"]);
                //oelItems.PackingSize = Validation.GetSafeString(oReader["PackingSize"]);
                //oelItems.BatchNo = Validation.GetSafeString(oReader["BatchNo"]);
                //oelItems.UnitPrice = Validation.GetSafeDecimal(oReader["UnitPrice"]);

                //oelItems.StockOnHand = Validation.GetSafeInteger(oReader["StockOnHand"]);
                //oelItems.ReorderLevel = Validation.GetSafeInteger(oReader["ReorderLevel"]);
                //oelItems.StockOnHandDate = Convert.ToDateTime(oReader["OnHandDate"]);
                //oelItems.CreatedDateTime = Convert.ToDateTime(oReader["StockInHandDate"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> GetItemsCurrentStockByCategory(Int64? IdCategory, Int64 IdProject, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetItemsCurrentStockByCategory]", objConn);

            cmdItem.Parameters.Add("@IdCategory", SqlDbType.BigInt).Value = IdCategory;
            cmdItem.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;

            cmdItem.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdItem.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.IdCurrentStock = Validation.GetSafeLong(oReader["CurrentStock_Id"]);
                oelItems.IdCategory = Validation.GetSafeLong(oReader["Category_Id"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ProductCode = Validation.GetSafeString(oReader["ItemCode"]);
                oelItems.BarCode = Validation.GetSafeString(oReader["BarCode"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.CategoryName = Validation.GetSafeString(oReader["Category_Name"]);
                oelItems.BatchNo = Validation.GetSafeString(oReader["BatchNo"]);
                oelItems.TotalCartons = Validation.GetSafeLong(oReader["TotalCartons"]);
                oelItems.BatchNo = Validation.GetSafeString(oReader["BatchNo"]);
                oelItems.Expiry = Validation.GetSafeString(oReader["Expiry"]);
                oelItems.EngineNo = Validation.GetSafeString(oReader["EngineNo"]);
                oelItems.ChasisNo = Validation.GetSafeString(oReader["ChasisNo"]);
                oelItems.VehicleNo = Validation.GetSafeString(oReader["VehicleNo"]);
                oelItems.FirstIMEI = Validation.GetSafeString(oReader["FirstIMEI"]);
                oelItems.SecondIMEI = Validation.GetSafeString(oReader["SecondIMEI"]);
                oelItems.Qty = Validation.GetSafeDecimal(oReader["Units"]);
                oelItems.Bonus = Validation.GetSafeDecimal(oReader["BonusUnits"]);
                oelItems.UnitPrice = Validation.GetSafeDecimal(oReader["UnitPrice"]);
                oelItems.CurrentUnitPrice = Validation.GetSafeDecimal(oReader["CurrentUnitPrice"]);
                oelItems.TotalAmount = Validation.GetSafeDecimal(oReader["TotalAmount"]);
                //oelItems.UnitPrice = Validation.GetSafeDecimal(oReader["UnitPrice"]);
                oelItems.BarCode = Validation.GetSafeString(oReader["BarCode"]);
                //oelItems.StockOnHand = Validation.GetSafeInteger(oReader["StockOnHand"]);
                //oelItems.ReorderLevel = Validation.GetSafeInteger(oReader["ReorderLevel"]);
                //oelItems.StockOnHandDate = Convert.ToDateTime(oReader["OnHandDate"]);
                //oelItems.CreatedDateTime = Convert.ToDateTime(oReader["StockInHandDate"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        //public EntityoperationInfo UpdateItem(ItemsEL oelItems, SqlConnection objConn)
        //{
        //    EntityoperationInfo infoResult = new EntityoperationInfo();

        //    SqlCommand cmdItems = new SqlCommand("[Setup].[Proc_UpdateItems]", objConn);
        //    cmdItems.Connection = objConn;
        //    cmdItems.CommandType = CommandType.StoredProcedure;

        //    cmdItems.Parameters.Add(new SqlParameter("@IdItem", DbType.Guid)).Value = oelItems.IdItem;
        //    cmdItems.Parameters.Add(new SqlParameter("@IdCompany", DbType.Guid)).Value = oelItems.IdCompany;
        //    cmdItems.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelItems.ItemNo;
        //    cmdItems.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelItems.ItemName;
        //    cmdItems.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = oelItems.PackingSize;
        //    cmdItems.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelItems.Discription;
        //    cmdItems.Parameters.Add(new SqlParameter("@Qty", DbType.Decimal)).Value = oelItems.Qty;
        //    cmdItems.Parameters.Add(new SqlParameter("@Balance", DbType.Decimal)).Value = oelItems.Balance;
        //    if (cmdItems.ExecuteNonQuery() > -1)
        //    {
        //        infoResult.IsSuccess = true;
        //    }
        //    else
        //    {
        //        infoResult.IsSuccess = false;
        //    }
        //    return infoResult;
        //}
        public List<ItemsEL> SearchStockByProductNo(Int64 ProductNo, Int64 IdProject, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdSearchStock = new SqlCommand("[Setup].[Proc_SearchStockByProductNo]", objConn);

            cmdSearchStock.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdSearchStock.Parameters.Add("@ProductNo", SqlDbType.BigInt).Value = ProductNo;

            cmdSearchStock.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchStock.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ProductCode = Validation.GetSafeString(oReader["ItemCode"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.UnitPrice = Validation.GetSafeDecimal(oReader["UnitPrice"]);
                oelItems.BarCode = Validation.GetSafeString(oReader["BarCode"]);
                oelItems.CategoryName = Validation.GetSafeString(oReader["Category_Name"]);
                oelItems.BrandName = Validation.GetSafeString(oReader["Trading_Name"]);
                //oelItems.StockOnHand = Validation.GetSafeInteger(oReader["StockOnHand"]);
                oelItems.ReorderLevel = Validation.GetSafeInteger(oReader["ReorderLevel"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> SearchStockByProductName(string ProductName, Int64 IdProject, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdSearchStock = new SqlCommand("[Setup].[Proc_SearchStockByProductName]", objConn);

            cmdSearchStock.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdSearchStock.Parameters.Add("@ProductName", SqlDbType.VarChar).Value = ProductName;

            cmdSearchStock.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchStock.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ProductCode = Validation.GetSafeString(oReader["ItemCode"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.BarCode = Validation.GetSafeString(oReader["BarCode"]);
                oelItems.ReorderLevel = Validation.GetSafeInteger(oReader["ReorderLevel"]);
                oelItems.CategoryName = Validation.GetSafeString(oReader["Category_Name"]);
                oelItems.BrandName = Validation.GetSafeString(oReader["Trading_Name"]);
                oelItems.CurrentUnitPrice = Validation.GetSafeDecimal(oReader["CalculatedUnitPrice"]);
                oelItems.MRP = Validation.GetSafeDecimal(oReader["MRP"]);
                oelItems.LastPurchaseRate = Validation.GetSafeDecimal(oReader["LastPurchaseRate"]);
                oelItems.ClosingStock = Validation.GetSafeDecimal(oReader["Closing"]);
                //oelItems.BatchNo = Validation.GetSafeString(oReader["BatchNo"]);
                //oelItems.UnitPrice = Validation.GetSafeDecimal(oReader["UnitPrice"]);

                //oelItems.StockOnHand = Validation.GetSafeInteger(oReader["StockOnHand"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> GetCurrentOpeningStockByItem(Int64 IdItem, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetCurrentStockByItem]", objConn);

            cmdItem.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;

            cmdItem.CommandType = CommandType.StoredProcedure;
            SqlDataReader objReader = cmdItem.ExecuteReader();
            while (objReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);

                oelItems.IdCurrentStock = Validation.GetSafeLong(objReader["CurrentStock_Id"]);
                oelItems.Seq = Validation.GetSafeInteger(objReader["Seq"]);
                oelItems.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                oelItems.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                oelItems.Mfg = Validation.GetSafeString(objReader["Mfg"]);
                oelItems.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                oelItems.Qty = Validation.GetSafeInteger(objReader["Units"]);
                oelItems.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                oelItems.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> GetItemByBatchAndExpiry(Int64 IdItem, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetItemByBatchAndExpiry]", objConn);

            cmdItem.Parameters.Add("@IdItem", SqlDbType.UniqueIdentifier).Value = IdItem;

            cmdItem.CommandType = CommandType.StoredProcedure;
            SqlDataReader objReader = cmdItem.ExecuteReader();
            while (objReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                oelItems.Qty = Validation.GetSafeLong(objReader["Units"]);
                if (objReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(objReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> GetAllItems(Int64 IdProject, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdItems = new SqlCommand("[Setup].[Proc_GetAllItems]", objConn);

            cmdItems.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;

            cmdItems.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdItems.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ProductCode = Validation.GetSafeString(oReader["ItemCode"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.CategoryName = Validation.GetSafeString(oReader["Category_Name"]);
                oelItems.BrandName = Validation.GetSafeString(oReader["Trading_Name"]);
                oelItems.MRP = Validation.GetSafeDecimal(oReader["MRP"]);
                oelItems.LastPurchaseRate = Validation.GetSafeDecimal(oReader["LastPurchaseRate"]);
                oelItems.ClosingStock = Validation.GetSafeDecimal(oReader["Closing"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> GetAllActiveItems(Int64 IdProject, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdItems = new SqlCommand("[Setup].[Proc_GetAllActiveItems]", objConn);

            cmdItems.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;

            cmdItems.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdItems.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdItem = Validation.GetSafeLong(oReader["Item_Id"]);
                oelItems.ItemNo = Validation.GetSafeString(oReader["ItemNo"]);
                oelItems.ProductCode = Validation.GetSafeString(oReader["ItemCode"]);
                oelItems.ItemName = Validation.GetSafeString(oReader["ItemName"]);
                oelItems.CategoryName = Validation.GetSafeString(oReader["Category_Name"]);
                oelItems.BrandName = Validation.GetSafeString(oReader["Trading_Name"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                oelItems.MRP = Validation.GetSafeDecimal(oReader["MRP"]);
                oelItems.CurrentUnitPrice = Validation.GetSafeDecimal(oReader["EvaluationPrice"]);
                list.Add(oelItems);
            }
            return list;
        }

        public decimal GetItemClosingStock(Int64 IdItem, SqlConnection objConn)
        {
            using (SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetItemClosingStock]", objConn))
            {
                cmdItem.CommandType = CommandType.StoredProcedure;
                cmdItem.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;
                return Validation.GetSafeDecimal(cmdItem.ExecuteScalar());
            }
        }
        public decimal GetItemsAvgValue(Int64 IdItem, SqlConnection objConn, SqlTransaction objTran)
        {
            using (SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetItemsAvgValue]", objConn, objTran))
            {
                cmdItem.CommandType = CommandType.StoredProcedure;
                cmdItem.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;
                return Validation.GetSafeDecimal(cmdItem.ExecuteScalar());
            }
        }
        public decimal GetItemsAvgValueWOT(Int64 IdItem, SqlConnection objConn)
        {
            using (SqlCommand cmdItem = new SqlCommand("[Setup].[Proc_GetItemsAvgValue]", objConn))
            {
                cmdItem.CommandType = CommandType.StoredProcedure;
                cmdItem.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;
                return Validation.GetSafeDecimal(cmdItem.ExecuteScalar());
            }
        }
        public List<ItemsEL> GetProductLedger(Int64? IdItem, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdLotDetail = new SqlCommand("[Reports].[Proc_GetProductLedger]", objConn);
            cmdLotDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int32)).Value = IdItem;
            cmdLotDetail.CommandType = CommandType.StoredProcedure;
            objReader = cmdLotDetail.ExecuteReader();
            while (objReader.Read())
            {
                ItemsEL oelItem = new ItemsEL();
                oelItem.Description = Validation.GetSafeString(objReader["Description"]);
                oelItem.AccountType = Validation.GetSafeString(objReader["Desc"]);
                oelItem.StockOnHandDate = Convert.ToDateTime(objReader["Date"]);
                oelItem.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                oelItem.Qty = Validation.GetSafeDecimal(objReader["Units"]);
                oelItem.UnitPrice = Validation.GetSafeDecimal(objReader["Value"]);


                list.Add(oelItem);
            }
            return list;
        }
        public List<ItemsEL> GetProductLedgerByDate(Int64? IdItem, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdLotDetail = new SqlCommand("[Reports].[Proc_GetProductLedgerByDate]", objConn);
            cmdLotDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = IdItem;
            cmdLotDetail.Parameters.Add(new SqlParameter("@StartDate", DbType.DateTime)).Value = StartDate;
            cmdLotDetail.Parameters.Add(new SqlParameter("@EndDate", DbType.DateTime)).Value = EndDate;
            cmdLotDetail.CommandType = CommandType.StoredProcedure;
            objReader = cmdLotDetail.ExecuteReader();
            while (objReader.Read())
            {
                ItemsEL oelItem = new ItemsEL();
                oelItem.Description = Validation.GetSafeString(objReader["Description"]);
                oelItem.AccountType = Validation.GetSafeString(objReader["Desc"]);
                oelItem.StockOnHandDate = Convert.ToDateTime(objReader["Date"]);
                oelItem.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                oelItem.Qty = Validation.GetSafeDecimal(objReader["Units"]);
                oelItem.UnitPrice = Validation.GetSafeDecimal(objReader["Value"]);


                list.Add(oelItem);
            }
            return list;
        }
    }
}
