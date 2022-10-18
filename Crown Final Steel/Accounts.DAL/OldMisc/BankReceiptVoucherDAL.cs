using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Accounts.EL;

namespace Accounts.DAL
{
    public class BankReceiptVoucherDAL
    {
        public EntityoperationInfo InsertBankReceipt(VouchersEL oelVoucher, List<TransactionsEL> oelTransactionsCollection, SqlConnection oConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdBankReceipt = new SqlCommand("sp_InsertBankReceiptVoucher", oConn))
            {
                try
                {
                    oTran = oConn.BeginTransaction();
                    cmdBankReceipt.Transaction = oTran;
                    cmdBankReceipt.CommandType = CommandType.StoredProcedure;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@ChequeNo", DbType.String)).Value = oelVoucher.ChequeNo;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;  
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdBankReceipt.ExecuteNonQuery();

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
        public EntityoperationInfo UpdateBankReceipt(VouchersEL oelVoucher, List<TransactionsEL> oelTransactionsCollection, SqlConnection oConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdBankReceipt = new SqlCommand("sp_UpdateBankReceiptVoucher", oConn))
            {
                try
                {
                    oTran = oConn.BeginTransaction();
                    cmdBankReceipt.Transaction = oTran;
                    cmdBankReceipt.CommandType = CommandType.StoredProcedure;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int32)).Value = oelVoucher.VoucherNo;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@ChequeNo", DbType.String)).Value = oelVoucher.ChequeNo;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    cmdBankReceipt.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdBankReceipt.ExecuteNonQuery();

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
        public bool DeleteBankReceipt(Int64 VoucherNo, string TransactionType, SqlConnection objConn)
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
