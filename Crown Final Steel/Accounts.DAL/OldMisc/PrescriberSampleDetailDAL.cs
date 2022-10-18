using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.EL;
using Accounts.Common;
using System.Data;
using System.Data.SqlClient;

namespace Accounts.DAL
{
    public class PrescriberSampleDetailDAL
    {
        IDataReader objReader;
        public PrescriberSampleDetailDAL()
        { 
            
        }
        public bool InsertSampleDetail(List<PrescriberSampleDetailEL> oelPrescriberSampleCollectionDetail, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdSampleDetail = new SqlCommand("sp_insertPrescriberDetail", objConn);
            cmdSampleDetail.CommandType = CommandType.StoredProcedure;
            cmdSampleDetail.CommandTimeout = 0;
            cmdSampleDetail.Transaction = oTran;
            for (int i = 0; i < oelPrescriberSampleCollectionDetail.Count; i++)
            {
                cmdSampleDetail.Parameters.Add(new SqlParameter("@IdSampleProduct", DbType.Guid)).Value = oelPrescriberSampleCollectionDetail[i].IdProductSample;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelPrescriberSampleCollectionDetail[i].VoucherNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelPrescriberSampleCollectionDetail[i].Seq;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelPrescriberSampleCollectionDetail[i].ItemNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelPrescriberSampleCollectionDetail[i].BatchNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = oelPrescriberSampleCollectionDetail[i].PackingSize;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelSaleCollection[i].ItemName;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSaleDetail.BatchNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelPrescriberSampleCollectionDetail[i].Units;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelPrescriberSampleCollectionDetail[i].UnitPrice;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPrescriberSampleCollectionDetail[i].Amount;
                cmdSampleDetail.ExecuteNonQuery();
                cmdSampleDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateSampleDetail(List<PrescriberSampleDetailEL> oelPrescriberSampleCollectionDetail, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdSampleDetail = new SqlCommand();
            cmdSampleDetail.CommandType = CommandType.StoredProcedure;
            cmdSampleDetail.Connection = objConn;
            cmdSampleDetail.Transaction = oTran;
            for (int i = 0; i < oelPrescriberSampleCollectionDetail.Count; i++)
            {
                if (oelPrescriberSampleCollectionDetail[i].IsNew)
                {
                    cmdSampleDetail.CommandText = "sp_insertPrescriberDetail";
                }
                else
                {
                    cmdSampleDetail.CommandText = "sp_updatePrescriberDetail";
                }
                cmdSampleDetail.Parameters.Add(new SqlParameter("@IdSampleProduct", DbType.Guid)).Value = oelPrescriberSampleCollectionDetail[i].IdProductSample;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelPrescriberSampleCollectionDetail[i].VoucherNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelPrescriberSampleCollectionDetail[i].Seq;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@ItemNo", DbType.String)).Value = oelPrescriberSampleCollectionDetail[i].ItemNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelPrescriberSampleCollectionDetail[i].BatchNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@PackingSize", DbType.String)).Value = oelPrescriberSampleCollectionDetail[i].PackingSize;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@ItemName", DbType.String)).Value = oelSaleCollection[i].ItemName;
                //cmdSaleDetail.Parameters.Add(new SqlParameter("@BatchNo", DbType.String)).Value = oelSaleDetail.BatchNo;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Units", DbType.Decimal)).Value = oelPrescriberSampleCollectionDetail[i].Units;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@UnitPrice", DbType.Decimal)).Value = oelPrescriberSampleCollectionDetail[i].UnitPrice;
                cmdSampleDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPrescriberSampleCollectionDetail[i].Amount;
                cmdSampleDetail.ExecuteNonQuery();
                cmdSampleDetail.Parameters.Clear();
            }

            return true;
        }
        public List<PrescriberSampleDetailEL> GetPrescriberSampleDetailWithSampleNumber(Int64 SampleNumber, SqlConnection objConn)
        {
            List<PrescriberSampleDetailEL> list = new List<PrescriberSampleDetailEL>();
            using (SqlCommand cmdSales = new SqlCommand("sp_GetPrescriberSampleWithSampleNumber", objConn))
            {
                cmdSales.CommandType = CommandType.StoredProcedure;
                cmdSales.CommandTimeout = 0;
                cmdSales.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = SampleNumber;
                objReader = cmdSales.ExecuteReader();
                while (objReader.Read())
                {
                    PrescriberSampleDetailEL oelPrescriberSampleDetail = new PrescriberSampleDetailEL();
                    oelPrescriberSampleDetail.IdProductSample =Validation.GetSafeGuid(objReader["SampleProduct_Id"].ToString());
                    oelPrescriberSampleDetail.IdTransaction = Validation.GetSafeGuid(objReader["transaction_id"].ToString());
                    //oelSaleDetail.IdPrescriberTransaction = new Guid(objReader["PrescriberTransaction_Id"].ToString());
                    oelPrescriberSampleDetail.ItemNo = objReader["accountno"].ToString();
                    oelPrescriberSampleDetail.BatchNo = objReader["batchno"].ToString();
                    oelPrescriberSampleDetail.PackingSize = objReader["packingsize"].ToString();
                    oelPrescriberSampleDetail.Units = Convert.ToInt64(objReader["units"]);
                    oelPrescriberSampleDetail.UnitPrice = Convert.ToDecimal(objReader["unitprice"]);
                    oelPrescriberSampleDetail.Amount = Convert.ToDecimal(objReader["amount"]);
                    
                    //oelSaleDetail.Discount = Convert.ToDecimal(objReader["discount"]);
                    if (objReader["Description"] != DBNull.Value)
                    {
                        oelPrescriberSampleDetail.Description = objReader["Description"].ToString();
                    }
                    else
                    {
                        oelPrescriberSampleDetail.Description = "";
                    }
                    list.Add(oelPrescriberSampleDetail);
                }
            }
            return list;
        }
        public List<PrescriberSampleDetailEL> GetSamplePrescriber(Int64 SampleNumber, string AccountNo, SqlConnection objConn)
        {
            List<PrescriberSampleDetailEL> list = new List<PrescriberSampleDetailEL>();
            using (SqlCommand cmdSamplePrescriber = new SqlCommand("sp_GetSamplePrescriber", objConn))
            {
                cmdSamplePrescriber.CommandType = CommandType.StoredProcedure;
                cmdSamplePrescriber.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = SampleNumber;
                cmdSamplePrescriber.Parameters.Add("@AccountNo", SqlDbType.NVarChar).Value = AccountNo;
                objReader = cmdSamplePrescriber.ExecuteReader();
                while (objReader.Read())
                {
                    PrescriberSampleDetailEL oelSamplePrescriberDetail = new PrescriberSampleDetailEL();
                    oelSamplePrescriberDetail.IdPrescriberTransaction = Validation.GetSafeGuid(objReader["transaction_id"]);
                    oelSamplePrescriberDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelSamplePrescriberDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    oelSamplePrescriberDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelSamplePrescriberDetail.Date = Convert.ToDateTime(objReader["date"]);
                    list.Add(oelSamplePrescriberDetail);
                }
            }
            return list;
        }
    }
}
