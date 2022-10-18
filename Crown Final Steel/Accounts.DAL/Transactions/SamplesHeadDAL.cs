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
    public class SamplesHeadDAL
    {
        IDataReader objReader;
        SamplesDetailDAL dal;
        public SamplesHeadDAL()
        {
            dal = new SamplesDetailDAL();
        }
        public bool InsertSamples(VouchersEL oelVoucher, List<VoucherDetailEL> oelSampleCollection, SqlConnection objConn)
        {
            SqlTransaction objTran = objConn.BeginTransaction();
            try
            {
                //// Insert Sample Voucher
                SqlCommand cmdSample = new SqlCommand("[Transactions].[Proc_CreateSamplesHead]", objConn);

                cmdSample.CommandType = CommandType.StoredProcedure;
                cmdSample.Transaction = objTran;
                cmdSample.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                cmdSample.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelVoucher.IdCompany;
                cmdSample.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                cmdSample.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                cmdSample.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                cmdSample.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                cmdSample.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                cmdSample.Parameters.Add(new SqlParameter("@DemandNo", DbType.String)).Value = oelVoucher.DemandNo;
                cmdSample.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                cmdSample.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                cmdSample.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                cmdSample.Parameters.Add(new SqlParameter("@SampleDays", DbType.Int32)).Value = oelVoucher.Transactiondays;
                cmdSample.Parameters.Add(new SqlParameter("@IsRecieved", DbType.Boolean)).Value = oelVoucher.IsRecieved;
                cmdSample.Parameters.Add(new SqlParameter("@IsSold", DbType.Boolean)).Value = oelVoucher.IsSold;
                cmdSample.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                cmdSample.ExecuteNonQuery();

                //// Insert Detail Sample In Sample Record
                dal.InsertSampleDetail(oelSampleCollection, objConn, objTran);

                /// Insert Transactions
                // Tdal.InsertTransactions(oelTransactionsCollection, objConn, objTran);


                objTran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                objTran.Rollback();
                throw ex;
            }
        }

        public bool UpdateSamples(VouchersEL oelVoucher, List<VoucherDetailEL> oelSampleCollection, SqlConnection objConn)
        {
            SqlTransaction objTran = objConn.BeginTransaction();
            try
            {
                SqlCommand cmdSample = new SqlCommand("[Transactions].[Proc_UpdateSamplesHead]", objConn);
                cmdSample.CommandType = CommandType.StoredProcedure;
                cmdSample.Transaction = objTran;

                cmdSample.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                cmdSample.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelVoucher.IdCompany;
                cmdSample.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                cmdSample.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                cmdSample.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                cmdSample.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                cmdSample.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                cmdSample.Parameters.Add(new SqlParameter("@DemandNo", DbType.String)).Value = oelVoucher.DemandNo;
                cmdSample.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                cmdSample.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                cmdSample.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                cmdSample.Parameters.Add(new SqlParameter("@SampleDays", DbType.Int32)).Value = oelVoucher.Transactiondays;
                cmdSample.Parameters.Add(new SqlParameter("@IsRecieved", DbType.Boolean)).Value = oelVoucher.IsRecieved;
                //cmdVoucher.Parameters.Add(new SqlParameter("@Discount", DbType.Decimal)).Value = oelSaleMaster.Discount;
                //cmdVoucher.Parameters.Add(new SqlParameter("@TotalDiscount", DbType.Decimal)).Value = oelSaleMaster.TotalDiscount;
                //cmdVoucher.Parameters.Add(new SqlParameter("@NetSale", DbType.Decimal)).Value = oelSaleMaster.NetSaleAmount;
                cmdSample.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                cmdSample.ExecuteNonQuery();

                //// Insert And Update Sales In Sale Record
                dal.UpdateSampleDetail(oelSampleCollection, objConn, objTran);
                ///
                //Tdal.UpdateTransactions(oelTransactionsCollection, objConn, objTran);


                objTran.Commit();
            }
            catch (Exception ex)
            {
                objTran.Rollback();
                throw ex;
            }
            finally
            {

            }
            return true;


        }       
        //public bool InsertSalesReturn(VouchersEL oelVoucher, List<SaleDetailEL> oelSaleCollection, List<TransactionsEL> oelTransactionsCollection, List<StockReceiptEL> oelStockRecieptCollection, SqlConnection objConn)
        public bool InsertSamplesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelSampleReturnCollection, SqlConnection objConn)
        {
            SqlTransaction objTran = objConn.BeginTransaction();

            try
            {
                //// Insert SalesReturn Voucher
                SqlCommand cmdSamplesReturn = new SqlCommand("[Transactions].[Proc_CreateSamplesReturnHead]", objConn);

                cmdSamplesReturn.CommandType = CommandType.StoredProcedure;
                cmdSamplesReturn.Transaction = objTran;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelVoucher.IdCompany;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.Date;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@AccountNo", DbType.Int64)).Value = oelVoucher.AccountNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@InWardGatePassNo", DbType.String)).Value = oelVoucher.InWardGatePassNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                cmdSamplesReturn.ExecuteNonQuery();

                //// Insert SalesReturn In SaleReturn Record
                dal.InsertSamplesReturnDetail(oelSampleReturnCollection, objConn, objTran);

                /// Insert Stock Transactions
                //Tdal.InsertTransactions(oelTransactionsCollection, objConn, objTran);

                objTran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                objTran.Rollback();
                throw ex;
            }

        }
        //public bool UpdateSalesReturn(VouchersEL oelSaleMaster, List<SaleDetailEL> oelSaleCollection, List<TransactionsEL> oelTransactionsCollection, List<StockReceiptEL> oelStockReceiptCollection, SqlConnection objConn)
        public bool UpdateSamplesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelSampleReturnCollection, SqlConnection objConn)
        {
            SqlTransaction objTran = objConn.BeginTransaction();
            try
            {
                SqlCommand cmdSamplesReturn = new SqlCommand("[Transactions].[Proc_UpdateSamplesReturnHead]", objConn);
                cmdSamplesReturn.CommandType = CommandType.StoredProcedure;
                cmdSamplesReturn.Transaction = objTran;

                cmdSamplesReturn.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Guid)).Value = oelVoucher.IdVoucher;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@IdCompany", DbType.Guid)).Value = oelVoucher.IdCompany;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.Date;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@InWardGatePassNo", DbType.String)).Value = oelVoucher.InWardGatePassNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                cmdSamplesReturn.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                cmdSamplesReturn.ExecuteNonQuery();

                //// Insert And Update Sales In Sale Record
                dal.UpdateSalesReturnDetail(oelSampleReturnCollection, objConn, objTran);

                /// Insert and Update Sales Return Transactions
                //Tdal.UpdateTransactions(oelTransactionsCollection, objConn, objTran);

                objTran.Commit();
                return true;
            }
            catch (Exception ex)
            {
                objTran.Rollback();
                throw ex;
            }
        }
        public bool DeleteSample(Int64? IdVoucher, string TransactionType, Int64 IdCompany, SqlConnection objConn)
        {
            try
            {
                SqlCommand cmdDeleteVouchers = new SqlCommand("[Transactions].[Proc_DeleteVoucherWithtransaction]", objConn);
                cmdDeleteVouchers.CommandType = CommandType.StoredProcedure;
                cmdDeleteVouchers.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdDeleteVouchers.Parameters.Add("@IdVoucher", SqlDbType.UniqueIdentifier).Value = IdVoucher;
                cmdDeleteVouchers.Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = TransactionType;
                cmdDeleteVouchers.ExecuteNonQuery();
                cmdDeleteVouchers.Parameters.Clear();

                //Tdal.DeleteTransactions(VoucherNo, TransactionType, IdCompany, objConn, objTran);


            }
            catch (Exception ex)
            {
                throw ex;
            }

            return true;
        }
        public bool DeleteSampleReturn(Int64? IdVoucher, string TransactionType, Int64 IdCompany, SqlConnection objConn)
        {
            try
            {
                SqlCommand cmdDeleteVouchers = new SqlCommand("[Transactions].[Proc_DeleteVoucherWithtransaction]", objConn);
                cmdDeleteVouchers.CommandType = CommandType.StoredProcedure;
                cmdDeleteVouchers.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdDeleteVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdDeleteVouchers.Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = TransactionType;
                cmdDeleteVouchers.ExecuteNonQuery();

                //Tdal.DeleteTransactions(VoucherNo, TransactionType, IdCompany, objConn, objTran);


            }
            catch (Exception ex)
            {

                throw ex;
            }
            return true;
        }
        public bool CheckSamples(Int64 IdCompnay, Int64 VoucherNo, SqlConnection objConn)
        {
            List<VouchersEL> oelSaleCollection = new List<VouchersEL>();
            bool IsExists = false;
            using (SqlCommand cmdCheckSamples = new SqlCommand("[Transactions].[Proc_CheckSample]", objConn))
            {
                cmdCheckSamples.CommandType = CommandType.StoredProcedure;

                cmdCheckSamples.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompnay;
                cmdCheckSamples.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = VoucherNo;

                IDataReader objReader = cmdCheckSamples.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelSaleMaster = new VouchersEL();
                    oelSaleMaster.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelSaleCollection.Add(oelSaleMaster);
                }
            }
            if (oelSaleCollection.Count > 0)
            {
                IsExists = true;
            }
            return IsExists;
        }
        public List<VouchersEL> GetSamplesDays(Int64 IdCompany, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSample = new SqlCommand("[Transactions].[Proc_GetSampleDays]", objConn))
            {
                cmdSample.CommandType = CommandType.StoredProcedure;
                cmdSample.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                objReader = cmdSample.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.Transactiondays = Validation.GetSafeInteger(objReader["SampleDays"]);
                    oelVoucher.RemainingDays = Validation.GetSafeInteger(objReader["RemainingDays"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetSamplesDaysByDate(Int64 IdCompany,DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSample = new SqlCommand("[Transactions].[Proc_GetSampleDaysByDate]", objConn))
            {
                cmdSample.CommandType = CommandType.StoredProcedure;
                cmdSample.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSample.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSample.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdSample.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.Transactiondays = Validation.GetSafeInteger(objReader["SampleDays"]);
                    oelVoucher.RemainingDays = Validation.GetSafeInteger(objReader["RemainingDays"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetSamplesDaysByEmployess(Int64 IdCompany,string EmpCode, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSample = new SqlCommand("[Transactions].[Proc_GetSampleDaysByEmployee]", objConn))
            {
                cmdSample.CommandType = CommandType.StoredProcedure;
                cmdSample.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSample.Parameters.Add("@EmpCode", SqlDbType.VarChar).Value = EmpCode;
                objReader = cmdSample.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.Transactiondays = Validation.GetSafeInteger(objReader["SampleDays"]);
                    oelVoucher.RemainingDays = Validation.GetSafeInteger(objReader["RemainingDays"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetSamplesDaysByEmployeesByDate(Int64 IdCompany,string EmpCode, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdSample = new SqlCommand("[Transactions].[Proc_GetSampleDaysByEmployeeByDate]", objConn))
            {
                cmdSample.CommandType = CommandType.StoredProcedure;
                cmdSample.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSample.Parameters.Add("@EmpCode", SqlDbType.VarChar).Value = EmpCode;
                cmdSample.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdSample.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;                
                objReader = cmdSample.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelVoucher.Transactiondays = Validation.GetSafeInteger(objReader["SampleDays"]);
                    oelVoucher.RemainingDays = Validation.GetSafeInteger(objReader["RemainingDays"]);

                    list.Add(oelVoucher);
                }
            }
            return list;
        }
    }
}
