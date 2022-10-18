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
    public class GeneralStockIssuanceDetailDAL
    {
        IDataReader objReader;
     
        public bool CreateGeneralInventoryIssuanceDetail(List<VoucherDetailEL> oelIssuanceCollection, Int64? Identity, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdIssuanceDetail = new SqlCommand("[Transactions].[Proc_CreateGeneralInventoryIssuanceDetail]", objConn);
            cmdIssuanceDetail.CommandType = CommandType.StoredProcedure;
            cmdIssuanceDetail.CommandTimeout = 0;
            cmdIssuanceDetail.Transaction = oTran;
            for (int i = 0; i < oelIssuanceCollection.Count; i++)
            {
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelIssuanceCollection[i].IdVoucherDetail;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = Identity;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelIssuanceCollection[i].SeqNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelIssuanceCollection[i].IdItem;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelIssuanceCollection[i].Discription;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelIssuanceCollection[i].TotalCartons;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelIssuanceCollection[i].BatchNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelIssuanceCollection[i].Expiry;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelIssuanceCollection[i].EngineNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelIssuanceCollection[i].ChasisNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelIssuanceCollection[i].VehicleNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelIssuanceCollection[i].FirstIMEI;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelIssuanceCollection[i].SecondIMEI;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelIssuanceCollection[i].ColorCode;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@CurrentStock", DbType.Decimal)).Value = oelIssuanceCollection[i].CurrentStock;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelIssuanceCollection[i].Units;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelIssuanceCollection[i].UnitPrice;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelIssuanceCollection[i].Amount;
                //cmdPurchaseDetail.Parameters.Add(new SqlParameter("@Bonus", DbType.Int64)).Value = oelPurchaseCollection[i].Bonus;
                cmdIssuanceDetail.ExecuteNonQuery();
                cmdIssuanceDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateGeneralInventoryIssuanceDetail(List<VoucherDetailEL> oelIssuanceCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdIssuanceDetail = new SqlCommand();
            cmdIssuanceDetail.CommandType = CommandType.StoredProcedure;
            cmdIssuanceDetail.Connection = objConn;
            cmdIssuanceDetail.Transaction = oTran;
            for (int i = 0; i < oelIssuanceCollection.Count; i++)
            {
                if (oelIssuanceCollection[i].IsNew)
                {
                    cmdIssuanceDetail.CommandText = "[Transactions].[Proc_CreateGeneralInventoryIssuanceDetail]";
                }
                else
                {
                    cmdIssuanceDetail.CommandText = "[Transactions].[Proc_UpdateGeneralInventoryIssuanceDetail]";
                }
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelIssuanceCollection[i].IdVoucherDetail;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelIssuanceCollection[i].IdVoucher;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@SeqNo", DbType.Int32)).Value = oelIssuanceCollection[i].SeqNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Int64)).Value = oelIssuanceCollection[i].IdItem;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelIssuanceCollection[i].Discription;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@TotalCartons", DbType.Int64)).Value = oelIssuanceCollection[i].TotalCartons;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelIssuanceCollection[i].BatchNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@Expiry", DbType.String)).Value = oelIssuanceCollection[i].Expiry;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@EngineNo", DbType.String)).Value = oelIssuanceCollection[i].EngineNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@ChasisNo", DbType.String)).Value = oelIssuanceCollection[i].ChasisNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@VehicleNo", DbType.String)).Value = oelIssuanceCollection[i].VehicleNo;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@FirstIMEI", DbType.String)).Value = oelIssuanceCollection[i].FirstIMEI;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@SecondIMEI", DbType.String)).Value = oelIssuanceCollection[i].SecondIMEI;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@ColorCode", DbType.Int32)).Value = oelIssuanceCollection[i].ColorCode;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@CurrentStock", DbType.Decimal)).Value = oelIssuanceCollection[i].CurrentStock;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelIssuanceCollection[i].Units;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelIssuanceCollection[i].UnitPrice;
                cmdIssuanceDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelIssuanceCollection[i].Amount;
                cmdIssuanceDetail.ExecuteNonQuery();
                cmdIssuanceDetail.Parameters.Clear();
            }

            return true;
        }

        public List<VoucherDetailEL> GetEmployeeIssuanceReport(string AccountNo, Int64 IdProject, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdPrescriberSale = new SqlCommand("[Transactions].[Proc_GetEmployeeIssuance]", objConn))
            {
                cmdPrescriberSale.CommandType = CommandType.StoredProcedure;
                cmdPrescriberSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdPrescriberSale.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdPrescriberSale.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelSaleDetail = new VoucherDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Units = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetEmployeeIssuanceReportByDate(string AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdProject, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdCustomerSale = new SqlCommand("[Transactions].[Proc_GetEmployeeIssuanceReportByDate]", objConn))
            {
                cmdCustomerSale.CommandType = CommandType.StoredProcedure;
                cmdCustomerSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdCustomerSale.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdCustomerSale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdCustomerSale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdCustomerSale.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelSaleDetail = new VoucherDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Units = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetGeneralProductsTotalIssuance(Int64 IdProject, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdProductSale = new SqlCommand("[Transactions].[Proc_GetGeneralProductsTotalIssuance]", objConn))
            {
                cmdProductSale.CommandType = CommandType.StoredProcedure;
                cmdProductSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                objReader = cmdProductSale.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelSaleDetail = new VoucherDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Units = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetGeneralProductsTotalIssuanceByDate(DateTime StartDate, DateTime EndDate, Int64 IdProject, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdProductSale = new SqlCommand("[Transactions].[Proc_GetGeneralProductsTotalIssuanceByDate]", objConn))
            {
                cmdProductSale.CommandType = CommandType.StoredProcedure;
                cmdProductSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdProductSale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdProductSale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdProductSale.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelSaleDetail = new VoucherDetailEL();
                    oelSaleDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Units = Validation.GetSafeLong(objReader["TotalUnits"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["TotalSaleAmount"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetGeneralProductDetailIssuance(Int64 IdProject, Int64 IdItem, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdProductSale = new SqlCommand("[Transactions].[Proc_GetGeneralProductDetailIssuance]", objConn))
            {
                cmdProductSale.CommandType = CommandType.StoredProcedure;

                cmdProductSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdProductSale.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;
                objReader = cmdProductSale.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelSaleDetail = new VoucherDetailEL();
                    oelSaleDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelSaleDetail.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Units = Validation.GetSafeLong(objReader["Units"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    if (objReader["AccountName"] != null)
                    {
                        oelSaleDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    }
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetGeneralProductDetailIssuanceByDate( Int64 IdProject, Int64 IdItem, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdProductSale = new SqlCommand("[Transactions].[Proc_GetGeneralProductDetailIssuanceByDate]", objConn))
            {
                cmdProductSale.CommandType = CommandType.StoredProcedure;
                cmdProductSale.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdProductSale.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;
                cmdProductSale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdProductSale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;                
                objReader = cmdProductSale.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelSaleDetail = new VoucherDetailEL();
                    oelSaleDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelSaleDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelSaleDetail.Units = Validation.GetSafeLong(objReader["Units"]);
                    oelSaleDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelSaleDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelSaleDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    list.Add(oelSaleDetail);
                }
            }
            return list;
        }
        public decimal GetItemUnPostedIssuanceQuantity(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, Int64 IdItem, SqlConnection objConn)
        {
            List<SaleDetailEL> list = new List<SaleDetailEL>();
            SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetItemUnPostedIssuanceQuantity]", objConn);

            cmdSales.CommandType = CommandType.StoredProcedure;
            cmdSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
            cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdSales.Parameters.Add("@IdItem", SqlDbType.BigInt).Value = IdItem;
            return Validation.GetSafeDecimal(cmdSales.ExecuteScalar());
        }
    }
}
