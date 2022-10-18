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
    public class SaleDetailDAL
    {
        #region Variables
        IDataReader objReader;
        #endregion
        #region Sales Related Method        
        public bool InsertSaleDetail(List<VoucherDetailEL> oelSaleCollection, Int64? Identity, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdSaleDetail = new SqlCommand("[Transactions].[Proc_CreateSalesDetail]", objConn);
            cmdSaleDetail.CommandType = CommandType.StoredProcedure;
            cmdSaleDetail.CommandTimeout = 0;
            cmdSaleDetail.Transaction = oTran;
            for (int i = 0; i < oelSaleCollection.Count; i++)
            {
                cmdSaleDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelSaleCollection[i].IdVoucherDetail;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelSaleCollection[i].SeqNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelSaleCollection[i].IdItem;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelSaleCollection[i].Discription;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelSaleCollection[i].TotalCartons;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSaleCollection[i].BatchNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelSaleCollection[i].Expiry;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelSaleCollection[i].EngineNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelSaleCollection[i].ChasisNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelSaleCollection[i].VehicleNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelSaleCollection[i].FirstIMEI;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelSaleCollection[i].SecondIMEI;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelSaleCollection[i].ColorCode;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@CurrentStock", DbType.Decimal)).Value = oelSaleCollection[i].CurrentStock;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelSaleCollection[i].Units;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@BonusUnits", DbType.Decimal)).Value = oelSaleCollection[i].Bonus;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelSaleCollection[i].ItemWeight;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelSaleCollection[i].UnitPrice;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelSaleCollection[i].Amount;
                //cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Bonus", DbType.Int64)).Value = oelPurchaseCollection[i].Bonus;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@DiscPercentage", DbType.Decimal)).Value = oelSaleCollection[i].Discount;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@DiscountAmount", DbType.Decimal)).Value = oelSaleCollection[i].DiscountAmount;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@LineDiscount", DbType.Decimal)).Value = oelSaleCollection[i].LineDiscount;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@PromoDiscountPercentage", DbType.Decimal)).Value = oelSaleCollection[i].PromoDiscount;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@NetSaleAmount", DbType.Decimal)).Value = oelSaleCollection[i].NetSaleAmount;
                cmdSaleDetail.ExecuteNonQuery();
                cmdSaleDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateSaleDetail(List<VoucherDetailEL> oelSaleCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdSaleDetail = new SqlCommand();
            cmdSaleDetail.CommandType = CommandType.StoredProcedure;
            cmdSaleDetail.Connection = objConn;
            cmdSaleDetail.Transaction = oTran;
            for (int i = 0; i < oelSaleCollection.Count; i++)
            {
                if (oelSaleCollection[i].IsNew)
                {
                    cmdSaleDetail.CommandText = "[Transactions].[Proc_CreateSalesDetail]";
                }
                else
                {
                    cmdSaleDetail.CommandText = "[Transactions].[Proc_UpdateSalesDetail]";
                }
                cmdSaleDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelSaleCollection[i].IdVoucherDetail;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelSaleCollection[i].IdVoucher;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelSaleCollection[i].SeqNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelSaleCollection[i].IdItem;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelSaleCollection[i].Discription;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelSaleCollection[i].TotalCartons;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSaleCollection[i].BatchNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelSaleCollection[i].Expiry;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelSaleCollection[i].EngineNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelSaleCollection[i].ChasisNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelSaleCollection[i].VehicleNo;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelSaleCollection[i].FirstIMEI;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelSaleCollection[i].SecondIMEI;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelSaleCollection[i].ColorCode;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@CurrentStock", DbType.Decimal)).Value = oelSaleCollection[i].CurrentStock;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelSaleCollection[i].Units;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@BonusUnits", DbType.Decimal)).Value = oelSaleCollection[i].Bonus;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelSaleCollection[i].ItemWeight;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelSaleCollection[i].Amount;
                //cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Bonus", DbType.Int64)).Value = oelPurchaseCollection[i].Bonus;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelSaleCollection[i].UnitPrice;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@DiscPercentage", DbType.Decimal)).Value = oelSaleCollection[i].Discount;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@DiscountAmount", DbType.Decimal)).Value = oelSaleCollection[i].DiscountAmount;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@LineDiscount", DbType.Decimal)).Value = oelSaleCollection[i].LineDiscount;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@PromoDiscountPercentage", DbType.Decimal)).Value = oelSaleCollection[i].PromoDiscount;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@NetSaleAmount", DbType.Decimal)).Value = oelSaleCollection[i].NetSaleAmount;
                cmdSaleDetail.ExecuteNonQuery();
                cmdSaleDetail.Parameters.Clear();
            }

            return true;
        }
        public bool InsertProductsProfitLoss(List<VoucherDetailEL> oelSaleCollection, Int64? Identity, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdSaleDetail = new SqlCommand("[Transactions].[Proc_CreateProductsProfitLoss]", objConn);
            cmdSaleDetail.CommandType = CommandType.StoredProcedure;
            cmdSaleDetail.CommandTimeout = 0;
            cmdSaleDetail.Transaction = oTran;
            for (int i = 0; i < oelSaleCollection.Count; i++)
            {
                cmdSaleDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelSaleCollection[i].IdItem;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@Quantity", DbType.Decimal)).Value = oelSaleCollection[i].Units;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@SaleAmount", DbType.Decimal)).Value = oelSaleCollection[i].NetSaleAmount;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@CostAmount", DbType.Decimal)).Value = oelSaleCollection[i].SaleCost;
                cmdSaleDetail.Parameters.Add(new SqlParameter("@ProfitLossAmount", DbType.Decimal)).Value = oelSaleCollection[i].NetProfit;
                cmdSaleDetail.ExecuteNonQuery();
                cmdSaleDetail.Parameters.Clear();
            }
            return true;
        }
        public bool InsertSalesTransactionsDetail(List<VoucherDetailEL> oelDetailCollection, Int64? Identity, string LedgerVoucherNo, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdVoucherDetail = new SqlCommand("[Transactions].[Proc_CreateTransactionsDetails]", objConn);
            cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
            cmdVoucherDetail.CommandTimeout = 0;
            cmdVoucherDetail.Transaction = objTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdTransactionDetail", DbType.Int64)).Value = oelDetailCollection[i].IdTransactionDetail;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelDetailCollection[i].IdProject;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelDetailCollection[i].BookNo;
                if (oelDetailCollection[i].VoucherType == "S" && oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "NS" + "-" + LedgerVoucherNo.ToString();
                }
                else if (oelDetailCollection[i].VoucherType == "S" && !oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "CS" + "-" + LedgerVoucherNo.ToString();
                }
                else if (oelDetailCollection[i].VoucherType == "SR" && oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "NSR" + "-" + LedgerVoucherNo.ToString();
                }
                else if (oelDetailCollection[i].VoucherType == "SR" && !oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "CSR" + "-" + LedgerVoucherNo.ToString();
                }
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = LedgerVoucherNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelDetailCollection[i].SeqNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelDetailCollection[i].Debit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelDetailCollection[i].Credit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TransactionMode", DbType.String)).Value = oelDetailCollection[i].TransactionMode;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TrackNumber", DbType.Decimal)).Value = oelDetailCollection[i].TrackNumber;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VType", DbType.Decimal)).Value = oelDetailCollection[i].VoucherType;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelDetailCollection[i].CreatedDateTime;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelDetailCollection[i].Posted;
                cmdVoucherDetail.ExecuteNonQuery();
                cmdVoucherDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateSalesTransactionsDetail(List<VoucherDetailEL> oelDetailCollection, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdVoucherDetail = new SqlCommand();
            cmdVoucherDetail.Connection = objConn;
            cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
            cmdVoucherDetail.CommandTimeout = 0;
            cmdVoucherDetail.Transaction = objTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                if (oelDetailCollection[i].IsNew)
                {
                    cmdVoucherDetail.CommandText = "[Transactions].[Proc_CreateTransactionsDetails]";
                }
                else
                {
                    cmdVoucherDetail.CommandText = "[Transactions].[Proc_UpdateTransactionsDetails]";
                }
                cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdTransactionDetail", DbType.Int64)).Value = oelDetailCollection[i].IdTransactionDetail;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelDetailCollection[i].IdVoucher;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelDetailCollection[i].IdProject;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelDetailCollection[i].BookNo;
                if (oelDetailCollection[i].VoucherType == "S" && oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "NS" + "-" + oelDetailCollection[i].VoucherNo.ToString();
                }
                else if (oelDetailCollection[i].VoucherType == "S" && !oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "CS" + "-" + oelDetailCollection[i].VoucherNo.ToString();
                }
                else if (oelDetailCollection[i].VoucherType == "SR" && oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "NSR" + "-" + oelDetailCollection[i].VoucherNo.ToString();
                }
                else if (oelDetailCollection[i].VoucherType == "SR" && !oelDetailCollection[i].IsNetTransaction.Value)
                {
                    cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = "CSR" + "-" + oelDetailCollection[i].VoucherNo.ToString();
                }
                //cmdVoucherDetail.Parameters.Add(new SqlParameter("@LedgerVoucherNo", DbType.String)).Value = oelDetailCollection[i].VoucherType + "-" + oelDetailCollection[i].VoucherNo.ToString();
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelDetailCollection[i].VoucherNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelDetailCollection[i].SeqNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelDetailCollection[i].Debit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelDetailCollection[i].Credit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TransactionMode", DbType.String)).Value = oelDetailCollection[i].TransactionMode;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@TrackNumber", DbType.Decimal)).Value = oelDetailCollection[i].TrackNumber;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@VType", DbType.Decimal)).Value = oelDetailCollection[i].VoucherType;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelDetailCollection[i].CreatedDateTime;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelDetailCollection[i].Posted;
                cmdVoucherDetail.ExecuteNonQuery();
                cmdVoucherDetail.Parameters.Clear();
            }
            return true;
        }
        public decimal GetItemUnPostedSoldQuantity(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, Int64 IdItem, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetItemUnPostedSoldQuantity]", objConn);
            
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;
                return Validation.GetSafeDecimal(cmdSales.ExecuteScalar());             
        }

        #endregion
        #region Sales Reports
        public List<SaleDetailEL> GetPrescriberSale(string AccountNo, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdPrescriberSale = new SqlCommand("sp_GetPrescriberSale", objConn))
            {
                cmdPrescriberSale.CommandType = CommandType.StoredProcedure;
                cmdPrescriberSale.Parameters.Add("@PrescriberAccountNo", SqlDbType.NVarChar).Value = AccountNo;
                objReader = cmdPrescriberSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Units = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    oelSaleDetail.CommissionPercentage = Validation.GetSafeDecimal(objReader["TotalCommissionPercentage"]);
                    oelSaleDetail.TotalCommissionAmount = Validation.GetSafeDecimal(objReader["TotalCommissionAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<SaleDetailEL> GetPrescriberSaleByDate(string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdPrescriberSale = new SqlCommand("sp_GetPrescriberSaleByDate", objConn))
            {
                cmdPrescriberSale.CommandType = CommandType.StoredProcedure;
                cmdPrescriberSale.Parameters.Add("@PrescriberAccountNo", SqlDbType.NVarChar).Value = AccountNo;
                cmdPrescriberSale.Parameters.Add("@StartDate", SqlDbType.NVarChar).Value = StartDate;
                cmdPrescriberSale.Parameters.Add("@EndDate", SqlDbType.NVarChar).Value = EndDate;
                objReader = cmdPrescriberSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Units = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    oelSaleDetail.CommissionPercentage = Validation.GetSafeDecimal(objReader["TotalCommissionPercentage"]);
                    oelSaleDetail.TotalCommissionAmount = Validation.GetSafeDecimal(objReader["TotalCommissionAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<SaleDetailEL> GetCustomerSale(Int64 AccountNo, Int64 IdProject, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdPrescriberSale = new SqlCommand("[Transactions].[Proc_GetCustomerSale]", objConn))
            {
                cmdPrescriberSale.CommandType = CommandType.StoredProcedure;
                cmdPrescriberSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPrescriberSale.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
                objReader = cmdPrescriberSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Qty = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelSaleDetail.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<SaleDetailEL> GetCustomerSaleByDate(string AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdProject, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdCustomerSale = new SqlCommand("[Transactions].[Proc_GetCustomerSaleByDate]", objConn))
            {
                cmdCustomerSale.CommandType = CommandType.StoredProcedure;
                cmdCustomerSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdCustomerSale.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdCustomerSale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdCustomerSale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdCustomerSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Qty = Validation.GetSafeDecimal(objReader["TotalUnits"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelSaleDetail.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<SaleDetailEL> GetProductsTotalSale(Int64 IdProject, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdProductSale = new SqlCommand("[Transactions].[Proc_GetProductsTotalSale]", objConn))
            {
                cmdProductSale.CommandType = CommandType.StoredProcedure;
                cmdProductSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                objReader = cmdProductSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Qty = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelSaleDetail.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<SaleDetailEL> GetProductsTotalSaleByDate(DateTime StartDate, DateTime EndDate, Int64 IdProject, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdProductSale = new SqlCommand("[Transactions].[Proc_GetProductsTotalSaleByDate]", objConn))
            {
                cmdProductSale.CommandType = CommandType.StoredProcedure;
                cmdProductSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdProductSale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdProductSale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdProductSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Qty = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelSaleDetail.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<SaleDetailEL> GetProductDetailSale(Int64 AccountNo, Int64 IdProject, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdProductSale = new SqlCommand("[Transactions].[Proc_GetProductDetailSale]", objConn))
            {
                cmdProductSale.CommandType = CommandType.StoredProcedure;

                cmdProductSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdProductSale.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
                objReader = cmdProductSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelSaleDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Qty = Validation.GetSafeLong(objReader["Units"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelSaleDetail.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);
                    if (objReader["CustomerName"] != null)
                    {
                        oelSaleDetail.AccountName = Validation.GetSafeString(objReader["CustomerName"]);
                    }
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<SaleDetailEL> GetProductDetailSaleByDate(Int64 AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdProject, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdProductSale = new SqlCommand("[Transactions].[Proc_GetProductDetailSaleByDate]", objConn))
            {
                cmdProductSale.CommandType = CommandType.StoredProcedure;
                cmdProductSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdProductSale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdProductSale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                cmdProductSale.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdProductSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelSaleDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelSaleDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Qty = Validation.GetSafeLong(objReader["Units"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelSaleDetail.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }

        public List<TransactionsEL> GetMonthlySalesReport(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMonthlySalesReport]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPurchaseDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlySalesReportWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMonthlySalesDetailedReport]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdSales.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyStraightSalesReport(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMonthlyStraightSalesReport]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPurchaseDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyStraightSalesReportWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMonthlyStraightSalesDetailedReport]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelPurchaseDetail = new TransactionsEL();
                    oelPurchaseDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelPurchaseDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelPurchaseDetail);
                }
            }
            return list;
        }
        
        public List<TransactionsEL> GetMonthlySalesReturnReport(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMonthlySalesReturnReport]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlySalesReturnReportWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMonthlySalesReturnDetailedReport]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdSales.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelTransaction.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyStraightSalesReturnReport(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMonthlyStraightSalesReturnReport]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetMonthlyStraightSalesReturnReportWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetMonthlyStraightSalesReturnDetailedReport]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelTransaction.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }

        public List<TransactionsEL> GetCustomersDiscountSummaryByDate(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetCustomersDiscountSummaryByDate]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelDiscountDetail = new TransactionsEL();
                    oelDiscountDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelDiscountDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelDiscountDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelDiscountDetail.LineDiscount = Validation.GetSafeDecimal(objReader["FlatDiscount"]);

                    list.Add(oelDiscountDetail);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetCustomersDetailDiscountSummaryByDate(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetCustomersDetailDiscountSummaryByDate]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelDiscountDetail = new TransactionsEL();
                    oelDiscountDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelDiscountDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelDiscountDetail.LineDiscount = Validation.GetSafeDecimal(objReader["FlatDiscount"]);

                    list.Add(oelDiscountDetail);
                }
            }
            return list;
        }
        #endregion
        #region Sales Return Related Method
        public bool InsertSalesReturnDetail(List<VoucherDetailEL> oelSalesReturnDetailCollection, Int64? Identity, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdSalesReturn = new SqlCommand("[Transactions].[Proc_CreateSalesReturnDetail]", objConn);
            cmdSalesReturn.CommandType = CommandType.StoredProcedure;
            cmdSalesReturn.CommandTimeout = 0;
            cmdSalesReturn.Transaction = oTran;
            for (int i = 0; i < oelSalesReturnDetailCollection.Count; i++)
            {
                cmdSalesReturn.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelSalesReturnDetailCollection[i].IdVoucherDetail;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelSalesReturnDetailCollection[i].SeqNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelSalesReturnDetailCollection[i].IdItem;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelSalesReturnDetailCollection[i].Discription;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelSalesReturnDetailCollection[i].TotalCartons;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSalesReturnDetailCollection[i].BatchNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelSalesReturnDetailCollection[i].Expiry;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelSalesReturnDetailCollection[i].EngineNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelSalesReturnDetailCollection[i].ChasisNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelSalesReturnDetailCollection[i].VehicleNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelSalesReturnDetailCollection[i].FirstIMEI;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelSalesReturnDetailCollection[i].SecondIMEI;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelSalesReturnDetailCollection[i].ColorCode;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].Units;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].ItemWeight;
                //cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Bonus", DbType.Int64)).Value = oelPurchaseCollection[i].Bonus;
                //cmdSalesReturn.Parameters.Add(new SqlParameter("@RemainingUnits", DbType.Int64)).Value = oelSalesReturnDetailCollection[i].RemainingUnits;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].UnitPrice;
                //cmdSalesReturn.Parameters.Add(new SqlParameter("@Disc", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].Discount;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].Amount;
                cmdSalesReturn.ExecuteNonQuery();
                cmdSalesReturn.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateSalesReturnDetail(List<VoucherDetailEL> oelSalesReturnDetailCollection, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdSalesReturn = new SqlCommand();
            cmdSalesReturn.CommandType = CommandType.StoredProcedure;
            cmdSalesReturn.Connection = objConn;
            cmdSalesReturn.Transaction = objTran;
            for (int i = 0; i < oelSalesReturnDetailCollection.Count; i++)
            {
                if (oelSalesReturnDetailCollection[i].IsNew)
                {
                    cmdSalesReturn.CommandText = "[Transactions].[Proc_CreateSalesReturnDetail]";
                }
                else
                {
                    cmdSalesReturn.CommandText = "[Transactions].[Proc_UpdateSalesReturnDetail]";
                }
                cmdSalesReturn.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelSalesReturnDetailCollection[i].IdVoucherDetail;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelSalesReturnDetailCollection[i].IdVoucher;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelSalesReturnDetailCollection[i].SeqNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelSalesReturnDetailCollection[i].IdItem;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelSalesReturnDetailCollection[i].Discription;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelSalesReturnDetailCollection[i].TotalCartons;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSalesReturnDetailCollection[i].BatchNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelSalesReturnDetailCollection[i].Expiry;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelSalesReturnDetailCollection[i].EngineNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelSalesReturnDetailCollection[i].ChasisNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelSalesReturnDetailCollection[i].VehicleNo;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelSalesReturnDetailCollection[i].FirstIMEI;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelSalesReturnDetailCollection[i].SecondIMEI;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelSalesReturnDetailCollection[i].ColorCode;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].Units;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@ItemWeight", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].ItemWeight;
                //cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Bonus", DbType.Int64)).Value = oelPurchaseCollection[i].Bonus;
                //cmdSalesReturn.Parameters.Add(new SqlParameter("@RemainingUnits", DbType.Int64)).Value = oelSalesReturnDetailCollection[i].RemainingUnits;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].UnitPrice;
                //cmdSalesReturn.Parameters.Add(new SqlParameter("@Disc", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].Discount;
                cmdSalesReturn.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelSalesReturnDetailCollection[i].Amount;
                cmdSalesReturn.ExecuteNonQuery();
                cmdSalesReturn.Parameters.Clear();
            }

            return true;
        }
        #endregion

        public List<SaleDetailEL> GetEmployeesMonthlyPerformanceReport(Int64 IdProject, Int64 BookNo, int EmpType, string AccountNo,DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdMonthlySalePerformance = new SqlCommand("[Transactions].[Proc_GetEmployeesMonthlyPerformanceReport]", objConn))
            {
                cmdMonthlySalePerformance.CommandType = CommandType.StoredProcedure;
                cmdMonthlySalePerformance.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdMonthlySalePerformance.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdMonthlySalePerformance.Parameters.Add("@EmpType", SqlDbType.BigInt).Value = EmpType;
                cmdMonthlySalePerformance.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
                cmdMonthlySalePerformance.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdMonthlySalePerformance.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdMonthlySalePerformance.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Qty = Validation.GetSafeDecimal(objReader["Units"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelSaleDetail.PromoDiscount = Validation.GetSafeDecimal(objReader["PromoPercentage"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DiscountAmount"]);
                    oelSaleDetail.TotalDiscount = Validation.GetSafeDecimal(objReader["Disc2Amount"]);
                    oelSaleDetail.NetSaleReturnAmount = Validation.GetSafeDecimal(objReader["TotalReturnAmount"]);
                    oelSaleDetail.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public bool UpdatePurchaseUnits(List<PurchaseDetailEL> oelPurchaseDetailCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdPurchseDetail = new SqlCommand("sp_UpdatePurchaseUnits", objConn);
            cmdPurchseDetail.CommandType = CommandType.StoredProcedure;
            cmdPurchseDetail.CommandTimeout = 0;
            cmdPurchseDetail.Transaction = oTran;
            for (int i = 0; i < oelPurchaseDetailCollection.Count; i++)
            {
                cmdPurchseDetail.Parameters.Add(new SqlParameter("@IdPurchaseDetail", DbType.Guid)).Value = oelPurchaseDetailCollection[i].IdPurchaseDetail;
                cmdPurchseDetail.Parameters.Add(new SqlParameter("@RemainingUnits", DbType.Int32)).Value = oelPurchaseDetailCollection[i].RemainingUnits;

                cmdPurchseDetail.ExecuteNonQuery();
                cmdPurchseDetail.Parameters.Clear();
            }
            return true;
        }
        public List<VoucherDetailEL> GetSaleWithInvoiceNumber(Int64 InvoiceNumber,Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetSaleWithInvoiceNumber]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.CommandTimeout = 0;
                cmdSales.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
                cmdSales.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = InvoiceNumber;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelSaleDetail = new VoucherDetailEL();
                    oelSaleDetail.IdVoucherDetail = Validation.GetSafeNullableLong(objReader["VoucherDetail_Id"].ToString());
                    //oelSaleDetail.IdTransaction = new Guid(objReader["transaction_id"].ToString());
                    //oelSaleDetail.IdPrescriberTransaction = new Guid(objReader["PrescriberTransaction_Id"].ToString());
                    oelSaleDetail.IdAccount = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.PackingSize = Validation.GetSafeString(objReader["packingsize"]);
                    //oelSaleDetail.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    //oelSaleDetail.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    oelSaleDetail.CurrentStock = Validation.GetSafeLong(objReader["CurrentStock"]);
                    oelSaleDetail.Discription = Validation.GetSafeString(objReader["Description"]);
                    oelSaleDetail.Units = Validation.GetSafeLong(objReader["units"]);
                    //oelSaleDetail.Bonus = Validation.GetSafeInteger(objReader["Bonus"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeDecimal(objReader["unitprice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["amount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["Discount"]);
                    //oelSaleDetail.TotalDiscount = Validation.GetSafeDecimal(objReader["TotalDiscount"]);
                    //oelSaleDetail.NetSaleAmount = Validation.GetSafeDecimal(objReader["NetSale"]);

                    //oelSaleDetail.Discount = Convert.ToDecimal(objReader["discount"]);
                    //if (objReader["Description"] != DBNull.Value)
                    //{
                    //    oelSaleDetail.Description = objReader["Description"].ToString();
                    //}
                    //else
                    //{
                    //    oelSaleDetail.Description = "";
                    //}
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public Guid GetSalePrescriberIdWithInvoiceNumber(Int64 InvoiceNumber, string AccountNo, SqlConnection objConn)
        {
            using (SqlCommand cmdSales = new SqlCommand("sp_GetSalePrescriberIdWithInvoiceNumber", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.CommandTimeout = 0;
                cmdSales.Parameters.Add(new SqlParameter("@AccountNo", DbType.Guid)).Value = AccountNo;
                cmdSales.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = InvoiceNumber;
                return new Guid(cmdSales.ExecuteScalar().ToString());
            }

        }
        public List<VoucherDetailEL> GetSalesReturnWithInvoiceNumber(Int64 InvoiceNumber, Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetSalesReturnWithInvoiceNumber]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.CommandTimeout = 0;
                cmdSales.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
                cmdSales.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = InvoiceNumber;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelSaleDetail = new VoucherDetailEL();
                    oelSaleDetail.IdVoucherDetail = Validation.GetSafeNullableLong(objReader["VoucherDetail_Id"].ToString());
                    oelSaleDetail.IdAccount = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelSaleDetail.ItemNo = objReader["itemNo"].ToString();
                    oelSaleDetail.ItemName = objReader["ItemName"].ToString();                   
                    oelSaleDetail.PackingSize = objReader["PackingSize"].ToString();
                    //oelSaleDetail.BatchNo = objReader["BatchNo"].ToString();
                    //oelSaleDetail.Expiry = objReader["Expiry"].ToString();
                    oelSaleDetail.Units = Convert.ToInt64(objReader["units"]);
                    oelSaleDetail.UnitPrice = Convert.ToInt64(objReader["unitprice"]);
                    oelSaleDetail.Amount = Convert.ToDecimal(objReader["amount"]);
                    //if (objReader["Description"] != DBNull.Value)
                    //{
                    //    oelSaleDetail.Description = objReader["Description"].ToString();
                    //}
                    //else
                    //{
                    //    oelSaleDetail.Description = "";
                    //}
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<SaleDetailEL> GetCustomerDiscountDetail(Int64 IdCompany, Guid IdItem, string AccountNo, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetCustomerDiscountDetail]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.CommandTimeout = 0;
                cmdSales.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
                cmdSales.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = IdItem;
                cmdSales.Parameters.Add(new SqlParameter("@AccountNo", DbType.Int64)).Value = AccountNo;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["DiscPercentage"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["DisCount"]);
                    oelSaleDetail.UnitPrice = Convert.ToInt64(objReader["unitprice"]);
                    oelSaleDetail.Amount = Convert.ToDecimal(objReader["amount"]);

                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }      
        

        public List<SaleDetailEL> GetPartyWiseSaleSummary(Int64 IdProject, Int64 BookNo, string OrderBooker, string DeliveryMan, DateTime startDate, DateTime endDate, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdPrescriberSale = new SqlCommand("[Transactions].[Proc_GetPartyWiseSaleSummary]", objConn))
            {
                cmdPrescriberSale.CommandType = CommandType.StoredProcedure;
                cmdPrescriberSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPrescriberSale.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPrescriberSale.Parameters.Add("@EmpCode", SqlDbType.VarChar).Value = OrderBooker;
                cmdPrescriberSale.Parameters.Add("@DeliveryEmployeeAccountNo", SqlDbType.VarChar).Value = DeliveryMan;
                cmdPrescriberSale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
                cmdPrescriberSale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = endDate;
                objReader = cmdPrescriberSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelSaleDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelSaleDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelSaleDetail.Address = Validation.GetSafeString(objReader["CustomerAddress"]);
                    oelSaleDetail.ClosingBalance = Validation.GetSafeLong(objReader["CustomerBalance"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["discount"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                    oelSaleDetail.TransactionMode = Validation.GetSafeString(objReader["SaleType"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<SaleDetailEL> GetPartyWiseSaleSummaryWithoutEmps(Int64 IdProject, Int64 BookNo, DateTime startDate, DateTime endDate, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            using (SqlCommand cmdPrescriberSale = new SqlCommand("[Transactions].[Proc_GetPartyWiseSaleSummaryWithoutEmps]", objConn))
            {
                cmdPrescriberSale.CommandType = CommandType.StoredProcedure;
                cmdPrescriberSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPrescriberSale.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdPrescriberSale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
                cmdPrescriberSale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = endDate;
                objReader = cmdPrescriberSale.ExecuteReader();
                while (objReader.Read())
                {
                    SaleDetailEL oelSaleDetail = new SaleDetailEL();
                    oelSaleDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelSaleDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelSaleDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelSaleDetail.Address = Validation.GetSafeString(objReader["CustomerAddress"]);
                    oelSaleDetail.ClosingBalance = Validation.GetSafeLong(objReader["CustomerBalance"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["discount"]);
                    oelSaleDetail.DiscountAmount = Validation.GetSafeDecimal(objReader["NetAmount"]);
                    oelSaleDetail.TransactionMode = Validation.GetSafeString(objReader["SaleType"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public decimal GetLastItemUnitPriceRateByCustomer(Int64 IdProject, Int64 BookNo, Int64 IdItem, String AccountNo, SqlConnection objConn)
        {
            using (SqlCommand cmdLastUnitRate = new SqlCommand("[Transactions].[Proc_GetLastItemUnitPriceRateByAccountNo]", objConn))
            {
                cmdLastUnitRate.CommandType = CommandType.StoredProcedure;
                cmdLastUnitRate.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdLastUnitRate.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdLastUnitRate.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;
                cmdLastUnitRate.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                return Validation.GetSafeDecimal(cmdLastUnitRate.ExecuteScalar());
              
            }
        }       
        public List<TransactionsEL> GetTopSellingItemsByDate(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetTopSellingItemsByDate]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelTransaction.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelTransaction.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelTransaction.OneTimeUnits = Validation.GetSafeDecimal(objReader["OneTimeSale"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetTopSellingReturnItemsByDate(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetTopSellingReturnItemsByDate]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelTransaction.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelTransaction.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelTransaction.OneTimeUnits = Validation.GetSafeDecimal(objReader["OneTimeSaleReturn"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetCustomersProfitAndLostByDate(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetCustomersProfitAndLostByDate]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.TotalSales = Validation.GetSafeDecimal(objReader["TotalSoldItems"]);
                    oelTransaction.NetSaleAmount = Validation.GetSafeDecimal(objReader["TotalSale"]);
                    oelTransaction.SaleCost = Validation.GetSafeDecimal(objReader["SaleCost"]);
                    oelTransaction.GrossProfit = Validation.GetSafeDecimal(objReader["GrossProfit"]);
                    oelTransaction.NetSaleReturnAmount = Validation.GetSafeDecimal(objReader["SaleReturn"]);
                    oelTransaction.ActualSoldAmount = Validation.GetSafeDecimal(objReader["ActualSoldAmount"]);
                    oelTransaction.TotalSalesReturn = Validation.GetSafeDecimal(objReader["TotalReturnedItems"]);
                    oelTransaction.ReturnedCost = Validation.GetSafeDecimal(objReader["ReturnedCost"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetCustomersProfitAndLossDetailByDate(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetCustomersProfitAndLostDetailByDate]", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdSales.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdSales.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSales.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelTransaction.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelTransaction.TotalSales = Validation.GetSafeDecimal(objReader["TotalSoldItems"]);
                    oelTransaction.NetSaleAmount = Validation.GetSafeDecimal(objReader["TotalSale"]);
                    oelTransaction.SaleCost = Validation.GetSafeDecimal(objReader["SaleCost"]);
                    oelTransaction.GrossProfit = Validation.GetSafeDecimal(objReader["GrossProfit"]);
                    //oelTransaction.NetSaleReturnAmount = Validation.GetSafeDecimal(objReader["SaleReturn"]);
                    //oelTransaction.ActualSoldAmount = Validation.GetSafeDecimal(objReader["ActualSoldAmount"]);
                    //oelTransaction.TotalSalesReturn = Validation.GetSafeDecimal(objReader["TotalReturnedItems"]);
                    //oelTransaction.ReturnedCost = Validation.GetSafeDecimal(objReader["ReturnedCost"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
    }
}
