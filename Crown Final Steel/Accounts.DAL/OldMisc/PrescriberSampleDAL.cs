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
    public class PrescriberSampleDAL
    {
        PrescriberSampleDetailDAL dal;
        public PrescriberSampleDAL()
        {
            dal = new PrescriberSampleDetailDAL();
        }
        public bool InsertPrescriberSample(VouchersEL oelVoucher, List<PrescriberSampleDetailEL> oelPrescriberSampleCollection, List<TransactionsEL> oelTransactionsCollection, SqlConnection objConn)
        {
            using (SqlTransaction oTran = objConn.BeginTransaction())
            {
                try
                {
                    //// Insert Sale Voucher
                    SqlCommand cmdVoucher = new SqlCommand("sp_insertPrescriberMaster", objConn);
                    cmdVoucher.CommandType = CommandType.StoredProcedure;
                    cmdVoucher.Transaction = oTran;
                    cmdVoucher.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    cmdVoucher.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdVoucher.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdVoucher.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelVoucher.Description;
                    cmdVoucher.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdVoucher.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    cmdVoucher.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdVoucher.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdVoucher.ExecuteNonQuery();

                    //// Insert Sample In Sample Record
                    dal.InsertSampleDetail(oelPrescriberSampleCollection, objConn, oTran);

                    /// Insert Stock Transactions

                    SqlCommand cmdTransactions = new SqlCommand("sp_insertTransactions", objConn);
                    cmdTransactions.CommandType = CommandType.StoredProcedure;
                    cmdTransactions.Transaction = oTran;
                    for (int i = 0; i < oelTransactionsCollection.Count; i++)
                    {
                        cmdTransactions.Parameters.Add(new SqlParameter("@IdTransaction", DbType.Guid)).Value = oelTransactionsCollection[i].TransactionID;
                        cmdTransactions.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelTransactionsCollection[i].AccountNo;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelTransactionsCollection[i].Date;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelTransactionsCollection[i].Seq;
                        cmdTransactions.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelTransactionsCollection[i].VoucherNo;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelTransactionsCollection[i].Description;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelTransactionsCollection[i].Debit;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelTransactionsCollection[i].Credit;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Qty", DbType.Int16)).Value = oelTransactionsCollection[i].Qty;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Type", DbType.String)).Value = oelTransactionsCollection[i].VoucherType;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelTransactionsCollection[i].Posted;
                        cmdTransactions.ExecuteNonQuery();
                        cmdTransactions.Parameters.Clear();
                    }
                    oTran.Commit();
                    return true;
                }
                catch (Exception ex)
                {
                    oTran.Rollback();
                    throw ex;
                }
            }
        }
        public bool UpdatePrescriberSample(VouchersEL oelVoucher, List<PrescriberSampleDetailEL> oelPrescriberSampleCollection, List<TransactionsEL> oelTransactionsCollection, SqlConnection objConn)
        {
            using (SqlTransaction oTran = objConn.BeginTransaction())
            {
                SqlCommand cmdVoucher = new SqlCommand("sp_updatePrescriberMaster", objConn);
                cmdVoucher.CommandType = CommandType.StoredProcedure;
                cmdVoucher.Transaction = oTran;
                cmdVoucher.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                cmdVoucher.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                cmdVoucher.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                cmdVoucher.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                cmdVoucher.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelVoucher.Description;
                cmdVoucher.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                cmdVoucher.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                cmdVoucher.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                cmdVoucher.ExecuteNonQuery();

                //// Insert And Update Sample In Sample Record
                dal.UpdateSampleDetail(oelPrescriberSampleCollection, objConn, oTran);


                SqlCommand cmdTransactions = new SqlCommand();
                cmdTransactions.CommandType = CommandType.StoredProcedure;
                cmdTransactions.Connection = objConn;
                cmdTransactions.Transaction = oTran;
                for (int i = 0; i < oelTransactionsCollection.Count; i++)
                {
                    if (oelTransactionsCollection[i].IsNew)
                    {
                        cmdTransactions.CommandText = "sp_insertTransactions";
                    }
                    else
                    {
                        cmdTransactions.CommandText = "sp_updateTransactions";
                    }
                    cmdTransactions.Parameters.Add(new SqlParameter("@IdTransaction", DbType.Guid)).Value = oelTransactionsCollection[i].TransactionID;
                    cmdTransactions.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelTransactionsCollection[i].AccountNo;
                    cmdTransactions.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelTransactionsCollection[i].Date;
                    cmdTransactions.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelTransactionsCollection[i].Seq;
                    cmdTransactions.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelTransactionsCollection[i].VoucherNo;
                    cmdTransactions.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelTransactionsCollection[i].Description;
                    cmdTransactions.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelTransactionsCollection[i].Debit;
                    cmdTransactions.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelTransactionsCollection[i].Credit;
                    cmdTransactions.Parameters.Add(new SqlParameter("@Qty", DbType.Int16)).Value = oelTransactionsCollection[i].Qty;
                    cmdTransactions.Parameters.Add(new SqlParameter("@Type", DbType.String)).Value = oelTransactionsCollection[i].VoucherType;
                    cmdTransactions.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelTransactionsCollection[i].Posted;
                    cmdTransactions.ExecuteNonQuery();
                    cmdTransactions.Parameters.Clear();
                }               
                oTran.Commit();

                return true;

            }
        }
        public bool CheckSample(Int64 VoucherNo, SqlConnection objConn)
        {
            List<PrescriberSampleDetailEL> list = new List<PrescriberSampleDetailEL>();
            bool IsExists = false;
            using (SqlCommand cmdCheckSample = new SqlCommand("sp_CheckSample", objConn))
            {
                cmdCheckSample.CommandType = CommandType.StoredProcedure;
                cmdCheckSample.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int32)).Value = VoucherNo;
                IDataReader objReader = cmdCheckSample.ExecuteReader();
                while (objReader.Read())
                {
                    PrescriberSampleDetailEL oelSample = new PrescriberSampleDetailEL();
                    oelSample.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    list.Add(oelSample);
                }
            }
            if (list.Count > 0)
            {
                IsExists = true;
            }
            return IsExists;
        }
        public bool DeleteSample(Int64 VoucherNo, SqlConnection objConn)
        {
            EntityoperationInfo DeleteInfo = new EntityoperationInfo();
            using (SqlCommand cmdDeleteSample = new SqlCommand("sp_DeleteSamples", objConn))
            {
                cmdDeleteSample.CommandType = CommandType.StoredProcedure;
                cmdDeleteSample.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = VoucherNo;
                cmdDeleteSample.ExecuteNonQuery();               
            }

            return true;
        }
    }
}
