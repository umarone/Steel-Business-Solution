using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Accounts.EL;

namespace Accounts.DAL
{
    public class CashDAL
    {
        CashDetailDAL dal;
        public CashDAL()
        {
            dal = new CashDetailDAL();
        }
         // Cash Receipt Entries
        public EntityoperationInfo InsertCashReceipt(VouchersEL oelVoucher, List<VoucherDetailEL> oelDetailCollection, List<TransactionsEL> oelTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdCashReceipt = new SqlCommand("sp_insertRecievedMaster", objConn))
            {
                try
                {
                    oTran = objConn.BeginTransaction();
                    cmdCashReceipt.Transaction = oTran;
                    cmdCashReceipt.CommandType = CommandType.StoredProcedure;
                    cmdCashReceipt.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    cmdCashReceipt.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdCashReceipt.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdCashReceipt.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdCashReceipt.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdCashReceipt.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    cmdCashReceipt.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdCashReceipt.ExecuteNonQuery();

                    // Insert Payment Receipt
                    dal.InsertReceiptDetail(oelDetailCollection, objConn, oTran);

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
        public EntityoperationInfo UpdateCashReceipt(VouchersEL oelVoucher, List<VoucherDetailEL> oelDetailCollection, List<TransactionsEL> oelTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdUPdateCashReceipt = new SqlCommand("sp_updateRecievedMaster", objConn))
            {
                try
                {
                    oTran = objConn.BeginTransaction();
                    cmdUPdateCashReceipt.Transaction = oTran;
                    cmdUPdateCashReceipt.CommandType = CommandType.StoredProcedure;
                    cmdUPdateCashReceipt.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    cmdUPdateCashReceipt.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdUPdateCashReceipt.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdUPdateCashReceipt.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdUPdateCashReceipt.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdUPdateCashReceipt.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    cmdUPdateCashReceipt.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdUPdateCashReceipt.ExecuteNonQuery();

                    // Update Payment Receipt
                    dal.UpdateReceiptDetail(oelDetailCollection, objConn, oTran);

                    SqlCommand cmdTransactions = new SqlCommand();
                    cmdTransactions.CommandType = CommandType.StoredProcedure;
                    cmdTransactions.Transaction = oTran;
                    cmdTransactions.Connection = objConn;
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
        public bool DeleteCashReceipt(Int64 VoucherNo, string TransactionType, SqlConnection objConn)
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
                    //cmdDeleteTransaction.Parameters.Clear();

                    //cmdDeleteTransaction.Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = TransactionType;
                    //cmdDeleteTransaction.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;

                    cmdDeleteTransaction.CommandText = "sp_deleteTransaction";
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


        ///// Cash Payment Entries
        public EntityoperationInfo InsertPayment(VouchersEL oelVoucher, List<VoucherDetailEL> oelVoucherDetailCollection, List<TransactionsEL> oelTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdPayment = new SqlCommand("sp_insertPaymentMaster", objConn))
            {
                try
                {
                    oTran = objConn.BeginTransaction();
                    cmdPayment.Transaction = oTran;
                    cmdPayment.CommandType = CommandType.StoredProcedure;
                    cmdPayment.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    cmdPayment.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdPayment.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdPayment.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdPayment.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdPayment.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    cmdPayment.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdPayment.ExecuteNonQuery();

                    // Insert Payment Detail

                    dal.InsertPaymentDetail(oelVoucherDetailCollection, objConn, oTran);

                    SqlCommand cmdTransactions = new SqlCommand("sp_insertTransactions", objConn);
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
        public EntityoperationInfo UpdatePayment(VouchersEL oelVoucher, List<VoucherDetailEL> oelVoucherDetailCollection, List<TransactionsEL> oelTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdUPdatePayment = new SqlCommand("sp_updatePaymentMaster", objConn))
            {
                try
                {
                    oTran = objConn.BeginTransaction();
                    cmdUPdatePayment.Transaction = oTran;
                    cmdUPdatePayment.CommandType = CommandType.StoredProcedure;
                    cmdUPdatePayment.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    cmdUPdatePayment.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdUPdatePayment.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdUPdatePayment.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdUPdatePayment.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdUPdatePayment.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    cmdUPdatePayment.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdUPdatePayment.ExecuteNonQuery();

                    // Update Payment Details
                    dal.UpdatePaymentDetail(oelVoucherDetailCollection, objConn, oTran);


                    SqlCommand cmdTransactions = new SqlCommand();
                    cmdTransactions.CommandType = CommandType.StoredProcedure;
                    cmdTransactions.Transaction = oTran;
                    cmdTransactions.Connection = objConn;
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
        public bool DeletePayment(Int64 VoucherNo, string TransactionType, SqlConnection objConn)
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
