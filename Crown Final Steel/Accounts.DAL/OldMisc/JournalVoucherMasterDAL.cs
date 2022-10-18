using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounts.EL;
using System.Data.SqlClient;
using System.Data;

namespace Accounts.DAL
{
    public class JournalVoucherMasterDAL
    {
        JournalVoucherDetailDAL dal;
        public JournalVoucherMasterDAL()
        {
            dal = new JournalVoucherDetailDAL();
        }
        public EntityoperationInfo InsertJournalVoucherMaster(VouchersEL oelVoucher, List<JournalVoucherEL> oelJVDetailCollection, List<TransactionsEL> oelTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdJVMaster = new SqlCommand("sp_insertJournalVoucherMaster", objConn))
            {
                try
                {
                    oTran = objConn.BeginTransaction();
                    cmdJVMaster.Transaction = oTran;
                    cmdJVMaster.CommandType = CommandType.StoredProcedure;
                    cmdJVMaster.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    cmdJVMaster.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdJVMaster.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdJVMaster.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@Discount", DbType.Decimal)).Value = oelVoucher.Discount;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@NetAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdJVMaster.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdJVMaster.ExecuteNonQuery();

                    // Insert Payment Detail

                    dal.InsertJournalVoucherDetail(oelJVDetailCollection, objConn, oTran);

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
        public EntityoperationInfo UpdateJournalVoucherMaster(VouchersEL oelVoucher, List<JournalVoucherEL> oelJVDetailCollection, List<TransactionsEL> oelTransactionsCollection, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            using (SqlCommand cmdJVMaster = new SqlCommand("sp_UpdateJournalVoucherMaster", objConn))
            {
                try
                {
                    oTran = objConn.BeginTransaction();
                    cmdJVMaster.Transaction = oTran;
                    cmdJVMaster.CommandType = CommandType.StoredProcedure;
                    cmdJVMaster.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelVoucher.Date;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucher.Description;
                    cmdJVMaster.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucher.Amount;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@Discount", DbType.Decimal)).Value = oelVoucher.Discount;
                    //cmdJVMaster.Parameters.Add(new SqlParameter("@NetAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdJVMaster.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdJVMaster.ExecuteNonQuery();

                    // Update Payment Details
                    dal.UpdateJournalVoucherDetail(oelJVDetailCollection, objConn, oTran);


                    SqlCommand cmdTransactions = new SqlCommand();
                    cmdTransactions.CommandText = "sp_updateTransactions";
                    cmdTransactions.CommandType = CommandType.StoredProcedure;
                    cmdTransactions.Transaction = oTran;
                    cmdTransactions.Connection = objConn;
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
        public bool DeleteJournalVoucher(Int64 VoucherNo, SqlConnection objConn)
        {
            EntityoperationInfo DeleteInfo = new EntityoperationInfo();
            using (SqlCommand cmdDeleteSales = new SqlCommand("sp_DeleteJournalVoucher", objConn))
            {
                cmdDeleteSales.CommandType = CommandType.StoredProcedure;
                cmdDeleteSales.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int32)).Value = VoucherNo;
                cmdDeleteSales.ExecuteNonQuery();
            }

            return true;
        }
    }
}
