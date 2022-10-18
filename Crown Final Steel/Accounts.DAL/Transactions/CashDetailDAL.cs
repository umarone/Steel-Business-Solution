using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Accounts.EL;

namespace Accounts.DAL
{
    public class CashDetailDAL
    {

        // Cash Receipt Entries
        public bool InsertReceiptDetail(List<VoucherDetailEL> oelDetailCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdCashDetail = new SqlCommand("sp_insertRecievedDetail", objConn);
            cmdCashDetail.CommandType = CommandType.StoredProcedure;
            cmdCashDetail.CommandTimeout = 0;
            cmdCashDetail.Transaction = oTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                cmdCashDetail.CommandType = CommandType.StoredProcedure;
                cmdCashDetail.Parameters.Add(new SqlParameter("@IdRecievedDetail", DbType.Guid)).Value = oelDetailCollection[i].IdVoucherDetail;
                cmdCashDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelDetailCollection[i].VoucherNo;
                cmdCashDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdCashDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdCashDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelDetailCollection[i].Amount;
                cmdCashDetail.ExecuteNonQuery();
                cmdCashDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateReceiptDetail(List<VoucherDetailEL> oelDetailCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdCashDetail = new SqlCommand();
            cmdCashDetail.CommandType = CommandType.StoredProcedure;
            cmdCashDetail.CommandTimeout = 0;
            cmdCashDetail.Connection = objConn;
            cmdCashDetail.Transaction = oTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                if (oelDetailCollection[i].IsNew)
                {
                    cmdCashDetail.CommandText = "sp_insertRecievedDetail";
                }
                else
                {
                    cmdCashDetail.CommandText = "sp_updateRecievedDetail";
                }
                cmdCashDetail.CommandType = CommandType.StoredProcedure;
                cmdCashDetail.Parameters.Add(new SqlParameter("@IdRecievedDetail", DbType.Guid)).Value = oelDetailCollection[i].IdVoucherDetail;
                cmdCashDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelDetailCollection[i].VoucherNo;
                cmdCashDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdCashDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdCashDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelDetailCollection[i].Amount;
                cmdCashDetail.ExecuteNonQuery();
                cmdCashDetail.Parameters.Clear();
            }
            return true;
        }

        ///// Cash Payment Entries

        public bool InsertPaymentDetail(List<VoucherDetailEL> oelVoucherDetailCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdCashDetail = new SqlCommand("sp_insertPaymentDetail", objConn);
            cmdCashDetail.CommandType = CommandType.StoredProcedure;
            cmdCashDetail.CommandTimeout = 0;
            cmdCashDetail.Transaction = oTran;
            for (int i = 0; i < oelVoucherDetailCollection.Count; i++)
            {
                cmdCashDetail.Parameters.Add(new SqlParameter("@IdPaymentDetail", DbType.Guid)).Value = oelVoucherDetailCollection[i].IdVoucherDetail;
                cmdCashDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucherDetailCollection[i].VoucherNo;
                cmdCashDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucherDetailCollection[i].AccountNo;
                cmdCashDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucherDetailCollection[i].Description;
                cmdCashDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucherDetailCollection[i].Amount;
                cmdCashDetail.ExecuteNonQuery();
                cmdCashDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdatePaymentDetail(List<VoucherDetailEL> oelVoucherDetailCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdCashDetail = new SqlCommand();
            cmdCashDetail.CommandType = CommandType.StoredProcedure;
            cmdCashDetail.CommandTimeout = 0;
            cmdCashDetail.Connection = objConn;
            cmdCashDetail.Transaction = oTran;
            for (int i = 0; i < oelVoucherDetailCollection.Count; i++)
            {
                if (oelVoucherDetailCollection[i].IsNew)
                {
                    cmdCashDetail.CommandText = "sp_insertPaymentDetail";
                }
                else
                {
                    cmdCashDetail.CommandText = "sp_updatePaymentDetail";
                }
                cmdCashDetail.CommandType = CommandType.StoredProcedure;
                cmdCashDetail.Parameters.Add(new SqlParameter("@IdPaymentDetail", DbType.Guid)).Value = oelVoucherDetailCollection[i].IdVoucherDetail;
                cmdCashDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucherDetailCollection[i].VoucherNo;
                cmdCashDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucherDetailCollection[i].AccountNo;
                cmdCashDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelVoucherDetailCollection[i].Description;
                cmdCashDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelVoucherDetailCollection[i].Amount;
                cmdCashDetail.ExecuteNonQuery();
                cmdCashDetail.Parameters.Clear();
            }
            return true;
        }
    }
}
