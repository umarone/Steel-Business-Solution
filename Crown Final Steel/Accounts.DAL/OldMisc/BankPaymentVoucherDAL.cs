using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Accounts.EL;

using System.Data;
using System.Data.SqlClient;

namespace Accounts.DAL
{
    public class BankPaymentVoucherDAL
    {
        public EntityoperationInfo InsertBankPayment(VouchersEL oelVoucher, List<TransactionsEL> oelTransactionsCollection, SqlConnection oConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdBankPayment = new SqlCommand("sp_InsertBankPaymentVoucher", oConn))
            {
                try
                {
                    oTran = oConn.BeginTransaction();
                    cmdBankPayment.Transaction = oTran;
                    cmdBankPayment.CommandType = CommandType.StoredProcedure;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@ChequeNo", DbType.String)).Value = oelVoucher.ChequeNo;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdBankPayment.ExecuteNonQuery();

                    SqlCommand cmdTransactions = new SqlCommand("sp_insertTransactions", oConn);
                    cmdTransactions.CommandType = CommandType.StoredProcedure;
                    cmdTransactions.Transaction = oTran;
                    for (int i = 0; i < oelTransactionsCollection.Count; i++)
                    {
                        cmdTransactions.Parameters.Add(new SqlParameter("@IdTransaction", DbType.Guid)).Value = oelTransactionsCollection[i].TransactionID;
                        cmdTransactions.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelTransactionsCollection[i].AccountNo;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelTransactionsCollection[i].Date;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelTransactionsCollection[i].Seq;
                        cmdTransactions.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int32)).Value = oelTransactionsCollection[i].VoucherNo;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelTransactionsCollection[i].Description;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Debit", DbType.Int64)).Value = oelTransactionsCollection[i].Debit;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Credit", DbType.Int64)).Value = oelTransactionsCollection[i].Credit;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Qty", DbType.Int16)).Value = oelTransactionsCollection[i].Qty;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Type", DbType.String)).Value = oelTransactionsCollection[i].VoucherType;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelTransactionsCollection[i].Posted;
                        cmdTransactions.ExecuteNonQuery();
                        cmdTransactions.Parameters.Clear();
                    }
                    oTran.Commit();
                    infoResult.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    oTran.Rollback();
                    throw ex;
                }

            }

            return infoResult;
        }
        public EntityoperationInfo UpdateBankPayment(VouchersEL oelVoucher, List<TransactionsEL> oelTransactionsCollection, SqlConnection oConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdBankPayment = new SqlCommand("sp_updateBankPaymentVoucher", oConn))
            {
                try
                {
                    oTran = oConn.BeginTransaction();
                    cmdBankPayment.Transaction = oTran;
                    cmdBankPayment.CommandType = CommandType.StoredProcedure;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@ChequeNo", DbType.String)).Value = oelVoucher.ChequeNo;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    cmdBankPayment.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdBankPayment.ExecuteNonQuery();

                    SqlCommand cmdTransactions = new SqlCommand();
                    cmdTransactions.CommandType = CommandType.StoredProcedure;
                    cmdTransactions.Transaction = oTran;
                    cmdTransactions.Connection = oConn;
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
                        cmdTransactions.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int32)).Value = oelTransactionsCollection[i].VoucherNo;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelTransactionsCollection[i].Description;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Debit", DbType.Int64)).Value = oelTransactionsCollection[i].Debit;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Credit", DbType.Int64)).Value = oelTransactionsCollection[i].Credit;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Qty", DbType.Int16)).Value = oelTransactionsCollection[i].Qty;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Type", DbType.String)).Value = oelTransactionsCollection[i].VoucherType;
                        cmdTransactions.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelTransactionsCollection[i].Posted;
                        cmdTransactions.ExecuteNonQuery();
                        cmdTransactions.Parameters.Clear();
                    }
                    oTran.Commit();
                    infoResult.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    oTran.Rollback();
                    throw ex;
                }

            }

            return infoResult;
        }
        public bool DeleteBankPayment(Int64 VoucherNo, string TransactionType, SqlConnection objConn)
        {
            using (SqlTransaction objTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteTransaction = new SqlCommand("sp_deleteVoucherWithtransaction", objConn);
                    cmdDeleteTransaction.CommandType = CommandType.StoredProcedure;
                    cmdDeleteTransaction.Transaction = objTran;
                    cmdDeleteTransaction.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
                    cmdDeleteTransaction.Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = TransactionType;
                    cmdDeleteTransaction.ExecuteNonQuery();
                    cmdDeleteTransaction.Parameters.Clear();

                    cmdDeleteTransaction.CommandText = "sp_deleteTransaction";
                    cmdDeleteTransaction.Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = TransactionType;
                    cmdDeleteTransaction.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;

                    cmdDeleteTransaction.ExecuteNonQuery();
                    objTran.Commit();
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
            }
            return true;
        }
    }
}
