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
    public class SamplesDetailDAL
    {
        IDataReader objReader;
        public bool InsertSampleDetail(List<VoucherDetailEL> oelSampleCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdSampleDetail = new SqlCommand("[Transactions].[Proc_CreateSamplesDetail]", objConn);
            cmdSampleDetail.CommandType = CommandType.StoredProcedure;
            cmdSampleDetail.CommandTimeout = 0;
            cmdSampleDetail.Transaction = oTran;
            for (int i = 0; i < oelSampleCollection.Count; i++)
            {
                cmdSampleDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Guid)).Value = oelSampleCollection[i].IdVoucherDetail;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Guid)).Value = oelSampleCollection[i].IdVoucher;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelSampleCollection[i].SeqNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Guid)).Value = oelSampleCollection[i].IdAccount;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelSampleCollection[i].ItemNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = oelSampleCollection[i].PackingSize;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSampleCollection[i].BatchNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelSampleCollection[i].Discription;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelSaleCollection[i].ItemName;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSaleDetail.BatchNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelSampleCollection[i].Units;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelSampleCollection[i].UnitPrice;;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelSampleCollection[i].Amount;
                cmdSampleDetail.ExecuteNonQuery();
                cmdSampleDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateSampleDetail(List<VoucherDetailEL> oelSampleCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdSampleDetail = new SqlCommand();
            cmdSampleDetail.CommandType = CommandType.StoredProcedure;
            cmdSampleDetail.Connection = objConn;
            cmdSampleDetail.Transaction = oTran;
            for (int i = 0; i < oelSampleCollection.Count; i++)
            {
                if (oelSampleCollection[i].IsNew)
                {
                    cmdSampleDetail.CommandText = "[Transactions].[Proc_CreateSamplesDetail]";
                }
                else
                {
                    cmdSampleDetail.CommandText = "[Transactions].[Proc_UpdateSamplesDetail]";
                }
                cmdSampleDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Guid)).Value = oelSampleCollection[i].IdVoucherDetail;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Guid)).Value = oelSampleCollection[i].IdVoucher;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelSampleCollection[i].Seq;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@IdItem", DbType.Guid)).Value = oelSampleCollection[i].IdAccount;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelSampleCollection[i].ItemNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = oelSampleCollection[i].PackingSize;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSampleCollection[i].BatchNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelSampleCollection[i].Discription;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelSampleCollection[i].Units;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelSampleCollection[i].UnitPrice;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelSampleCollection[i].Amount;
                cmdSampleDetail.ExecuteNonQuery();
                cmdSampleDetail.Parameters.Clear();
            }

            return true;
        }
        public bool InsertSamplesReturnDetail(List<VoucherDetailEL> oelSampleReturnCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdSamplesReturn = new SqlCommand("[Transactions].[Proc_CreateSamplesReturnDetail]", objConn);
            cmdSamplesReturn.CommandType = CommandType.StoredProcedure;
            cmdSamplesReturn.CommandTimeout = 0;
            cmdSamplesReturn.Transaction = oTran;
            for (int i = 0; i < oelSampleReturnCollection.Count; i++)
            {
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Guid)).Value = oelSampleReturnCollection[i].IdVoucherDetail;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Guid)).Value = oelSampleReturnCollection[i].IdVoucher;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelSampleReturnCollection[i].Seq;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelSampleReturnCollection[i].ItemNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@IdItem", DbType.Guid)).Value = oelSampleReturnCollection[i].IdAccount;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelSaleCollection[i].ItemName;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSaleDetail.BatchNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelSampleReturnCollection[i].Units;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelSampleReturnCollection[i].UnitPrice;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelSampleReturnCollection[i].Amount;
                cmdSamplesReturn.ExecuteNonQuery();
                cmdSamplesReturn.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateSalesReturnDetail(List<VoucherDetailEL> oelSampleReturnCollection, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdSampleReturn = new SqlCommand();
            cmdSampleReturn.CommandType = CommandType.StoredProcedure;
            cmdSampleReturn.Connection = objConn;
            cmdSampleReturn.Transaction = objTran;
            for (int i = 0; i < oelSampleReturnCollection.Count; i++)
            {
                if (oelSampleReturnCollection[i].IsNew)
                {
                    cmdSampleReturn.CommandText = "[Transactions].[Proc_CreateSamplesReturnDetail]";
                }
                else
                {
                    cmdSampleReturn.CommandText = "[Transactions].[Proc_UpdateSamplesReturnDetail]";
                }
                cmdSampleReturn.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Guid)).Value = oelSampleReturnCollection[i].IdVoucherDetail;
                cmdSampleReturn.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Guid)).Value = oelSampleReturnCollection[i].IdVoucher;
                cmdSampleReturn.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelSampleReturnCollection[i].Seq;
                cmdSampleReturn.Parameters.Add(new SqlParameter("@IdItem", DbType.Guid)).Value = oelSampleReturnCollection[i].IdAccount;
                cmdSampleReturn.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelSampleReturnCollection[i].ItemNo;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelSaleCollection[i].ItemName;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSaleDetail.BatchNo;
                cmdSampleReturn.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelSampleReturnCollection[i].Units;
                cmdSampleReturn.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelSampleReturnCollection[i].UnitPrice;
                cmdSampleReturn.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelSampleReturnCollection[i].Amount;
                cmdSampleReturn.ExecuteNonQuery();
                cmdSampleReturn.Parameters.Clear();
            }

            return true;
        }
        public List<VoucherDetailEL> GetSampleWithSampleNumber(Int64 SampleNumber, Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdSamples = new SqlCommand("[Transactions].[Proc_GetSampleWithSampleNumber]", objConn))
            {
                cmdSamples.CommandType = CommandType.StoredProcedure;
                cmdSamples.CommandTimeout = 0;
                cmdSamples.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
                cmdSamples.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = SampleNumber;
                objReader = cmdSamples.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                    oelVoucherDetail.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"].ToString());
                    //oelSaleDetail.IdTransaction = new Guid(objReader["transaction_id"].ToString());
                    //oelSaleDetail.IdPrescriberTransaction = new Guid(objReader["PrescriberTransaction_Id"].ToString());
                    oelVoucherDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucherDetail.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucherDetail.IdAccount = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelVoucherDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelVoucherDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucherDetail.Power = Validation.GetSafeString(objReader["Power"]);
                    oelVoucherDetail.ColorTemprature = Validation.GetSafeString(objReader["ColorTemprature"]);
                    oelVoucherDetail.PackingSize = Validation.GetSafeString(objReader["packingsize"]);
                    oelVoucherDetail.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    oelVoucherDetail.Discription = Validation.GetSafeString(objReader["Description"]);
                    oelVoucherDetail.Units = Validation.GetSafeLong(objReader["units"]);
                    oelVoucherDetail.UnitPrice = Validation.GetSafeDecimal(objReader["unitprice"]);
                    oelVoucherDetail.Amount = Validation.GetSafeDecimal(objReader["amount"]);
                    //oelSaleDetail.Discount = Validation.GetSafeDecimal(objReader["Discount"]);
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
                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetSamplesReturnWithSampleNumber(Int64 SampleNumber, Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdSamples = new SqlCommand("[Transactions].[Proc_GetSamplesReturnWithSampleNumber]", objConn))
            {
                cmdSamples.CommandType = CommandType.StoredProcedure;
                cmdSamples.CommandTimeout = 0;
                cmdSamples.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
                cmdSamples.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = SampleNumber;
                objReader = cmdSamples.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                    oelVoucherDetail.IdVoucherDetail = Validation.GetSafeNullableLong(objReader["VoucherDetail_Id"].ToString());
                    oelVoucherDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucherDetail.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucherDetail.IdAccount = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelVoucherDetail.ItemNo = objReader["itemNo"].ToString();
                    oelVoucherDetail.ItemName = objReader["ItemName"].ToString();
                    oelVoucherDetail.Power = Validation.GetSafeString(objReader["Power"]);
                    oelVoucherDetail.ColorTemprature = Validation.GetSafeString(objReader["ColorTemprature"]);
                    oelVoucherDetail.PackingSize = objReader["PackingSize"].ToString();
                    //oelSaleDetail.BatchNo = objReader["batchno"].ToString();
                    oelVoucherDetail.Units = Convert.ToInt64(objReader["units"]);
                    oelVoucherDetail.UnitPrice = Convert.ToInt64(objReader["unitprice"]);
                    oelVoucherDetail.Amount = Convert.ToDecimal(objReader["amount"]);
                    //if (objReader["Description"] != DBNull.Value)
                    //{
                    //    oelSaleDetail.Description = objReader["Description"].ToString();
                    //}
                    //else
                    //{
                    //    oelSaleDetail.Description = "";
                    //}
                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetCustomerSamples(Int64 AccountNo, Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdCustomerSamples = new SqlCommand("[Transactions].[Proc_GetCustomerSamples]", objConn))
            {
                cmdCustomerSamples.CommandType = CommandType.StoredProcedure;
                cmdCustomerSamples.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdCustomerSamples.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
                objReader = cmdCustomerSamples.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                    oelVoucherDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelVoucherDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucherDetail.TotalUnits = Validation.GetSafeLong(objReader["TotalSamples"]);
                    oelVoucherDetail.RemainingUnits = Validation.GetSafeLong(objReader["ReturnSamples"]);
                    oelVoucherDetail.ClosingUnits = Validation.GetSafeLong(objReader["Closing"]);

                    oelVoucherDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetCustomerSamplesByDate(string AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdCustomerSale = new SqlCommand("[Transactions].[Proc_GetCustomerSamplesByDate]", objConn))
            {
                cmdCustomerSale.CommandType = CommandType.StoredProcedure;
                cmdCustomerSale.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdCustomerSale.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdCustomerSale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdCustomerSale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdCustomerSale.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                    oelVoucherDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelVoucherDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucherDetail.TotalUnits = Validation.GetSafeLong(objReader["TotalSamples"]);
                    oelVoucherDetail.RemainingUnits = Validation.GetSafeLong(objReader["ReturnSamples"]);
                    oelVoucherDetail.ClosingUnits = Validation.GetSafeLong(objReader["Closing"]);

                    oelVoucherDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetProductsTotalSalmples(Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdCustomerSale = new SqlCommand("[Transactions].[Proc_GetProductsTotalSamples]", objConn))
            {
                cmdCustomerSale.CommandType = CommandType.StoredProcedure;
                cmdCustomerSale.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                objReader = cmdCustomerSale.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                    oelVoucherDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelVoucherDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucherDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucherDetail.TotalUnits = Validation.GetSafeLong(objReader["TotalSamples"]);
                    oelVoucherDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelVoucherDetail.RemainingUnits = Validation.GetSafeLong(objReader["ReturnSamples"]);
                    oelVoucherDetail.ClosingUnits = Validation.GetSafeLong(objReader["Closing"]);

                    oelVoucherDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetProductsTotalSamplesByDate(DateTime StartDate, DateTime EndDate, Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdSamples = new SqlCommand("[Transactions].[Proc_GetProductsTotalSamplesByDate]", objConn))
            {
                cmdSamples.CommandType = CommandType.StoredProcedure;
                cmdSamples.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSamples.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSamples.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSamples.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                    oelVoucherDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelVoucherDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucherDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucherDetail.TotalUnits = Validation.GetSafeLong(objReader["TotalSamples"]);
                    oelVoucherDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelVoucherDetail.RemainingUnits = Validation.GetSafeLong(objReader["ReturnSamples"]);
                    oelVoucherDetail.ClosingUnits = Validation.GetSafeLong(objReader["Closing"]);

                    oelVoucherDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetProductDetailSampling(Int64 AccountNo, Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdProductSampling = new SqlCommand("[Transactions].[Proc_GetProductDetailSampling]", objConn))
            {
                cmdProductSampling.CommandType = CommandType.StoredProcedure;
                cmdProductSampling.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdProductSampling.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
                objReader = cmdProductSampling.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                    oelVoucherDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelVoucherDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucherDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucherDetail.TotalUnits = Validation.GetSafeLong(objReader["TotalSamples"]);
                    oelVoucherDetail.RemainingUnits = Validation.GetSafeLong(objReader["ReturnSamples"]);
                    oelVoucherDetail.ClosingUnits = Validation.GetSafeLong(objReader["Closing"]);

                    oelVoucherDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetProductDetailSamplingByDate(Int64 AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdCompany, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdProductSampling = new SqlCommand("[Transactions].[Proc_GetProductDetailSamplingByDate]", objConn))
            {
                cmdProductSampling.CommandType = CommandType.StoredProcedure;
                cmdProductSampling.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdProductSampling.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdProductSampling.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                cmdProductSampling.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
                objReader = cmdProductSampling.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();
                    oelVoucherDetail.ItemNo = Validation.GetSafeString(objReader["ItemNo"]);
                    oelVoucherDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelVoucherDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucherDetail.TotalUnits = Validation.GetSafeLong(objReader["TotalSamples"]);
                    oelVoucherDetail.RemainingUnits = Validation.GetSafeLong(objReader["ReturnSamples"]);
                    oelVoucherDetail.ClosingUnits = Validation.GetSafeLong(objReader["Closing"]);

                    oelVoucherDetail.UnitPrice = Validation.GetSafeLong(objReader["UnitPrice"]);
                    oelVoucherDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
    }
}
