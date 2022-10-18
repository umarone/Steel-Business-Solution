using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.EL;
using System.Data.SqlClient;
using System.Data;
using Accounts.Common;

namespace Accounts.DAL
{
    public class StockDAL
    {
        IDataReader objReader;
        public bool InsertUpdateStock(List<StockReceiptEL> oelStockReceiptCollectioin, SqlConnection objConn)
        {
            try
            {
                using (SqlTransaction oTran = objConn.BeginTransaction())
                {
                    SqlCommand cmdStockReceipt = new SqlCommand("sp_InsertStockReceipt", objConn);
                    cmdStockReceipt.CommandType = CommandType.StoredProcedure;
                    cmdStockReceipt.Transaction = oTran;
                    for (int j = 0; j < oelStockReceiptCollectioin.Count; j++)
                    {
                        //cmdStockReceipt.Parameters.Add(new SqlParameter("@IdStockReceipt", DbType.Guid)).Value = oelStockReceiptCollectioin[j].IdStockReceipt;
                        cmdStockReceipt.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelStockReceiptCollectioin[j].IdUser;
                        //cmdStockReceiptDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelOpeningStockCollection[j].VoucherNo;
                        cmdStockReceipt.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelStockReceiptCollectioin[j].ItemNo;
                        cmdStockReceipt.Parameters.Add(new SqlParameter("@units", DbType.Int64)).Value = oelStockReceiptCollectioin[j].Units;
                        cmdStockReceipt.Parameters.Add(new SqlParameter("@ActionType", DbType.Int64)).Value = oelStockReceiptCollectioin[j].ActionType;
                        //cmdStockReceiptDetail.Parameters.Add(new SqlParameter("@RemainingUnits", DbType.Int64)).Value = oelOpeningStockCollection[j].RemainingUnits;
                        //cmdStockReceiptDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelOpeningStockCollection[j].Amount;
                        //cmdStockReceiptDetail.Parameters.Add(new SqlParameter("@stockdate", DbType.DateTime)).Value = oelOpeningStockCollection[j].StockDate;
                        cmdStockReceipt.ExecuteNonQuery();
                        cmdStockReceipt.Parameters.Clear();
                    }
                    oTran.Commit();

                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public bool UpdateStock(List<StockReceiptEL> oelStockReceiptCollectioin, SqlTransaction oTran, SqlConnection objConn)
        {
            try
            {
                SqlCommand cmdStockReceipt = new SqlCommand("sp_InsertStockReceipt", objConn);
                cmdStockReceipt.CommandType = CommandType.StoredProcedure;
                cmdStockReceipt.Transaction = oTran;
                for (int j = 0; j < oelStockReceiptCollectioin.Count; j++)
                {
                    //cmdStockReceipt.Parameters.Add(new SqlParameter("@IdStockReceipt", DbType.Guid)).Value = oelStockReceiptCollectioin[j].IdStockReceipt;
                    cmdStockReceipt.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelStockReceiptCollectioin[j].IdUser;
                    //cmdStockReceiptDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelOpeningStockCollection[j].VoucherNo;
                    cmdStockReceipt.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelStockReceiptCollectioin[j].ItemNo;
                    cmdStockReceipt.Parameters.Add(new SqlParameter("@units", DbType.Int64)).Value = oelStockReceiptCollectioin[j].Units;
                    cmdStockReceipt.Parameters.Add(new SqlParameter("@ActionType", DbType.Int64)).Value = oelStockReceiptCollectioin[j].ActionType;
                    //cmdStockReceiptDetail.Parameters.Add(new SqlParameter("@RemainingUnits", DbType.Int64)).Value = oelOpeningStockCollection[j].RemainingUnits;
                    //cmdStockReceiptDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelOpeningStockCollection[j].Amount;
                    //cmdStockReceiptDetail.Parameters.Add(new SqlParameter("@stockdate", DbType.DateTime)).Value = oelOpeningStockCollection[j].StockDate;
                    cmdStockReceipt.ExecuteNonQuery();
                    cmdStockReceipt.Parameters.Clear();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
        public List<StockReceiptEL> GetTotalStockByItems(Int64 IdProject, SqlConnection objConn)
        {
            List<StockReceiptEL> list = new List<StockReceiptEL>();
            SqlCommand cmdStock = new SqlCommand("[Reports].[Proc_GetTotalStockByItems]", objConn);
            cmdStock.CommandType = CommandType.StoredProcedure;
            cmdStock.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            objReader = cmdStock.ExecuteReader();
            while (objReader.Read())
            {
                StockReceiptEL oelStockReceipt = new StockReceiptEL();
                oelStockReceipt.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                oelStockReceipt.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                oelStockReceipt.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                //oelStockReceipt.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                oelStockReceipt.Opening = Validation.GetSafeDecimal(objReader["OPU"]);
                oelStockReceipt.Purchases = Validation.GetSafeDecimal(objReader["PU"]);
                oelStockReceipt.PurchasesReturn = Validation.GetSafeDecimal(objReader["PRU"]);
                oelStockReceipt.Sales = Validation.GetSafeDecimal(objReader["SU"]);
                oelStockReceipt.Returns = Validation.GetSafeDecimal(objReader["SRU"]);
                oelStockReceipt.StoreIn = Validation.GetSafeDecimal(objReader["StoreIN"]);
                oelStockReceipt.StoreOut = Validation.GetSafeDecimal(objReader["StoreOut"]);
                //oelStockReceipt.Samples = Validation.GetSafeLong(objReader["SampleUnits"]);
                //oelStockReceipt.SamplesReturn = Validation.GetSafeLong(objReader["SampleReturnedUnits"]);

                oelStockReceipt.Closing = Validation.GetSafeDecimal(objReader["ClosingStock"]);
                oelStockReceipt.AVR = Validation.GetSafeDecimal(objReader["AVR"]);
                oelStockReceipt.NVR = Validation.GetSafeDecimal(objReader["NVR"]);

                list.Add(oelStockReceipt);
            }

            return list;
        }
        public List<StockReceiptEL> GetDateWiseTotalStockByItems(Int64 IdProject, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<StockReceiptEL> list = new List<StockReceiptEL>();
            SqlCommand cmdStock = new SqlCommand("[Reports].[Proc_GetDateWiseTotalStockByItems]", objConn);
            cmdStock.CommandType = CommandType.StoredProcedure;

            cmdStock.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdStock.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
            cmdStock.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;

            objReader = cmdStock.ExecuteReader();
            while (objReader.Read())
            {
                StockReceiptEL oelStockReceipt = new StockReceiptEL();
                oelStockReceipt.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                oelStockReceipt.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                oelStockReceipt.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                //oelStockReceipt.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                oelStockReceipt.Opening = Validation.GetSafeDecimal(objReader["OPU"]);
                oelStockReceipt.Purchases = Validation.GetSafeDecimal(objReader["PU"]);
                oelStockReceipt.PurchasesReturn = Validation.GetSafeDecimal(objReader["PRU"]);
                oelStockReceipt.Sales = Validation.GetSafeDecimal(objReader["SU"]);
                oelStockReceipt.Returns = Validation.GetSafeDecimal(objReader["SRU"]);
                oelStockReceipt.StoreIn = Validation.GetSafeDecimal(objReader["StoreIN"]);
                oelStockReceipt.StoreOut = Validation.GetSafeDecimal(objReader["StoreOut"]);
                //oelStockReceipt.Samples = Validation.GetSafeLong(objReader["SampleUnits"]);
                //oelStockReceipt.SamplesReturn = Validation.GetSafeLong(objReader["SampleReturnedUnits"]);

                oelStockReceipt.Closing = Validation.GetSafeDecimal(objReader["ClosingStock"]);
                oelStockReceipt.AVR = Validation.GetSafeDecimal(objReader["AVR"]);
                oelStockReceipt.NVR = Validation.GetSafeDecimal(objReader["NVR"]);

                list.Add(oelStockReceipt);

                //list.Add(oelStockReceipt);
            }

            return list;
        }
        public List<StockReceiptEL> GetTotalStockReport(Int64 IdCategory, Int64 IdProject, SqlConnection objConn)
        {
            List<StockReceiptEL> list = new List<StockReceiptEL>();
            SqlCommand cmdStock = new SqlCommand("[Reports].[Proc_GetTotalStock]", objConn);
            cmdStock.CommandType = CommandType.StoredProcedure;
            cmdStock.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdStock.Parameters.Add("@IdCategory", SqlDbType.BigInt).Value = IdCategory;
            objReader = cmdStock.ExecuteReader();
            while (objReader.Read())
            {
                StockReceiptEL oelStockReceipt = new StockReceiptEL();
                oelStockReceipt.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                oelStockReceipt.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                oelStockReceipt.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                //oelStockReceipt.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                oelStockReceipt.Opening = Validation.GetSafeDecimal(objReader["OPU"]);
                oelStockReceipt.Purchases = Validation.GetSafeDecimal(objReader["PU"]);
                oelStockReceipt.PurchasesReturn = Validation.GetSafeDecimal(objReader["PRU"]);
                oelStockReceipt.Sales = Validation.GetSafeDecimal(objReader["SU"]);
                oelStockReceipt.Returns = Validation.GetSafeDecimal(objReader["SRU"]);
                oelStockReceipt.StoreIn = Validation.GetSafeDecimal(objReader["StoreIN"]);
                oelStockReceipt.StoreOut = Validation.GetSafeDecimal(objReader["StoreOut"]);
                //oelStockReceipt.Samples = Validation.GetSafeLong(objReader["SampleUnits"]);
                //oelStockReceipt.SamplesReturn = Validation.GetSafeLong(objReader["SampleReturnedUnits"]);
               
                oelStockReceipt.Closing = Validation.GetSafeDecimal(objReader["ClosingStock"]);
                oelStockReceipt.AVR = Validation.GetSafeDecimal(objReader["AVR"]);
                oelStockReceipt.NVR = Validation.GetSafeDecimal(objReader["NVR"]);

                list.Add(oelStockReceipt);
            }

            return list;
        }
        public List<StockReceiptEL> GetTradingWiseTotalStock(Int64 IdTrading, Int64 IdProject, SqlConnection objConn)
        {
            List<StockReceiptEL> list = new List<StockReceiptEL>();
            SqlCommand cmdStock = new SqlCommand("[Reports].[Proc_GetTradingWiseTotalStock]", objConn);
            cmdStock.CommandType = CommandType.StoredProcedure;
            cmdStock.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdStock.Parameters.Add("@IdTrading", SqlDbType.BigInt).Value = IdTrading;
            objReader = cmdStock.ExecuteReader();
            while (objReader.Read())
            {
                StockReceiptEL oelStockReceipt = new StockReceiptEL();
                oelStockReceipt.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                oelStockReceipt.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                oelStockReceipt.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                //oelStockReceipt.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                oelStockReceipt.Opening = Validation.GetSafeDecimal(objReader["OPU"]);
                oelStockReceipt.Purchases = Validation.GetSafeDecimal(objReader["PU"]);
                oelStockReceipt.PurchasesReturn = Validation.GetSafeDecimal(objReader["PRU"]);
                oelStockReceipt.Sales = Validation.GetSafeDecimal(objReader["SU"]);
                oelStockReceipt.Returns = Validation.GetSafeDecimal(objReader["SRU"]);
                oelStockReceipt.StoreIn = Validation.GetSafeDecimal(objReader["StoreIN"]);
                oelStockReceipt.StoreOut = Validation.GetSafeDecimal(objReader["StoreOut"]);
                //oelStockReceipt.Samples = Validation.GetSafeLong(objReader["SampleUnits"]);
                //oelStockReceipt.SamplesReturn = Validation.GetSafeLong(objReader["SampleReturnedUnits"]);

                oelStockReceipt.Closing = Validation.GetSafeDecimal(objReader["ClosingStock"]);
                oelStockReceipt.AVR = Validation.GetSafeDecimal(objReader["AVR"]);
                oelStockReceipt.NVR = Validation.GetSafeDecimal(objReader["NVR"]);

                list.Add(oelStockReceipt);
            }

            return list;
        }
        public List<StockReceiptEL> GetDateWiseTotalStockReport(Int64 IdCategory, Int64 IdProject, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<StockReceiptEL> list = new List<StockReceiptEL>();
            SqlCommand cmdStock = new SqlCommand("[Reports].[Proc_GetDateWiseTotalStock]", objConn);
            cmdStock.CommandType = CommandType.StoredProcedure;
            
            cmdStock.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            //cmdStock.Parameters.Add("@TradingCode", SqlDbType.VarChar).Value = TradingCo;
            cmdStock.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
            cmdStock.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
            cmdStock.Parameters.Add("@IdCategory", SqlDbType.BigInt).Value = IdCategory;
            
            objReader = cmdStock.ExecuteReader();
            while (objReader.Read())
            {
                StockReceiptEL oelStockReceipt = new StockReceiptEL();
                oelStockReceipt.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                oelStockReceipt.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                oelStockReceipt.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                //oelStockReceipt.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                oelStockReceipt.Opening = Validation.GetSafeDecimal(objReader["OPU"]);
                oelStockReceipt.Purchases = Validation.GetSafeDecimal(objReader["PU"]);
                oelStockReceipt.PurchasesReturn = Validation.GetSafeDecimal(objReader["PRU"]);
                oelStockReceipt.Sales = Validation.GetSafeDecimal(objReader["SU"]);
                oelStockReceipt.Returns = Validation.GetSafeDecimal(objReader["SRU"]);
                oelStockReceipt.StoreIn = Validation.GetSafeDecimal(objReader["StoreIN"]);
                oelStockReceipt.StoreOut = Validation.GetSafeDecimal(objReader["StoreOut"]);
                //oelStockReceipt.Samples = Validation.GetSafeLong(objReader["SampleUnits"]);
                //oelStockReceipt.SamplesReturn = Validation.GetSafeLong(objReader["SampleReturnedUnits"]);

                oelStockReceipt.Closing = Validation.GetSafeDecimal(objReader["ClosingStock"]);
                oelStockReceipt.AVR = Validation.GetSafeDecimal(objReader["AVR"]);
                oelStockReceipt.NVR = Validation.GetSafeDecimal(objReader["NVR"]);

                list.Add(oelStockReceipt);

                //list.Add(oelStockReceipt);
            }

            return list;
        }
        public List<StockReceiptEL> GetDateAndTradingWiseTotalStockReport(Int64 IdTrading, Int64 IdProject, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<StockReceiptEL> list = new List<StockReceiptEL>();
            SqlCommand cmdStock = new SqlCommand("[Reports].[Proc_GetDateAndTradingWiseTotalStock]", objConn);
            cmdStock.CommandType = CommandType.StoredProcedure;

            cmdStock.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdStock.Parameters.Add("@IdTrading", SqlDbType.BigInt).Value = IdTrading;
            cmdStock.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
            cmdStock.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;

            objReader = cmdStock.ExecuteReader();
            while (objReader.Read())
            {
                StockReceiptEL oelStockReceipt = new StockReceiptEL();
                oelStockReceipt.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                oelStockReceipt.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                oelStockReceipt.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                //oelStockReceipt.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                oelStockReceipt.Opening = Validation.GetSafeDecimal(objReader["OPU"]);
                oelStockReceipt.Purchases = Validation.GetSafeDecimal(objReader["PU"]);
                oelStockReceipt.PurchasesReturn = Validation.GetSafeDecimal(objReader["PRU"]);
                oelStockReceipt.Sales = Validation.GetSafeDecimal(objReader["SU"]);
                oelStockReceipt.Returns = Validation.GetSafeDecimal(objReader["SRU"]);
                oelStockReceipt.StoreIn = Validation.GetSafeDecimal(objReader["StoreIN"]);
                oelStockReceipt.StoreOut = Validation.GetSafeDecimal(objReader["StoreOut"]);
                //oelStockReceipt.Samples = Validation.GetSafeLong(objReader["SampleUnits"]);
                //oelStockReceipt.SamplesReturn = Validation.GetSafeLong(objReader["SampleReturnedUnits"]);

                oelStockReceipt.Closing = Validation.GetSafeDecimal(objReader["ClosingStock"]);
                oelStockReceipt.AVR = Validation.GetSafeDecimal(objReader["AVR"]);
                oelStockReceipt.NVR = Validation.GetSafeDecimal(objReader["NVR"]);

                list.Add(oelStockReceipt);
            }

            return list;
        }
        public List<StockReceiptEL> GetLowStockAlert(Int64 IdProject, SqlConnection objConn)
        {
            List<StockReceiptEL> list = new List<StockReceiptEL>();
            SqlCommand cmdStock = new SqlCommand("[Reports].[Proc_GetLowStockAlert]", objConn);
            cmdStock.CommandType = CommandType.StoredProcedure;
            cmdStock.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            objReader = cmdStock.ExecuteReader();
            while (objReader.Read())
            {
                StockReceiptEL oelStockReceipt = new StockReceiptEL();
                oelStockReceipt.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                oelStockReceipt.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                oelStockReceipt.CategoryName = Validation.GetSafeString(objReader["CategoryName"]);
                oelStockReceipt.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                oelStockReceipt.ReorderLevel = Validation.GetSafeInteger(objReader["ReOrderLevel"]);
                oelStockReceipt.Closing = Validation.GetSafeLong(objReader["ClosingStock"]);

                list.Add(oelStockReceipt);
            }

            return list;
        }
        public List<StockReceiptEL> AllProductsInOutWithAvgValue(Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<StockReceiptEL> list = new List<StockReceiptEL>();
            SqlCommand cmdStock = new SqlCommand("[Reports].[Proc_AllProductsInOutWithAvgValue]", objConn);
            cmdStock.CommandType = CommandType.StoredProcedure;
            cmdStock.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdStock.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            objReader = cmdStock.ExecuteReader();
            while (objReader.Read())
            {
                StockReceiptEL oelStockReceipt = new StockReceiptEL();
                oelStockReceipt.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                oelStockReceipt.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                oelStockReceipt.Purchases = Validation.GetSafeDecimal(objReader["StockIn"]);
                oelStockReceipt.AVGEvaluationUnitPrice = Validation.GetSafeDecimal(objReader["PurchaseAverage"]);
                oelStockReceipt.Sales = Validation.GetSafeDecimal(objReader["StockOut"]);
                oelStockReceipt.AVR = Validation.GetSafeDecimal(objReader["SaleAverage"]);
                oelStockReceipt.Closing = Validation.GetSafeDecimal(objReader["Closing"]);
                list.Add(oelStockReceipt);
            }

            return list;
        }
        public List<StockReceiptEL> AllProductsInOutWithAvgValueByDate(Int64 IdProject, Int64 BookNo, DateTime dtStart, DateTime dtEnd, SqlConnection objConn)
        {
            List<StockReceiptEL> list = new List<StockReceiptEL>();
            SqlCommand cmdStock = new SqlCommand("[Reports].[Proc_AllProductsInOutWithAvgValueByDate]", objConn);
            cmdStock.CommandType = CommandType.StoredProcedure;
            cmdStock.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdStock.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdStock.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = dtStart;
            cmdStock.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = dtEnd;
            objReader = cmdStock.ExecuteReader();
            while (objReader.Read())
            {
                StockReceiptEL oelStockReceipt = new StockReceiptEL();

                oelStockReceipt.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                oelStockReceipt.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                oelStockReceipt.Purchases = Validation.GetSafeDecimal(objReader["StockIn"]);
                oelStockReceipt.AVGEvaluationUnitPrice = Validation.GetSafeDecimal(objReader["PurchaseAverage"]);
                oelStockReceipt.Sales = Validation.GetSafeDecimal(objReader["StockOut"]);
                oelStockReceipt.AVR = Validation.GetSafeDecimal(objReader["SaleAverage"]);
                oelStockReceipt.Closing = Validation.GetSafeDecimal(objReader["Closing"]);

                list.Add(oelStockReceipt);
            }

            return list;
        }
    }
}
