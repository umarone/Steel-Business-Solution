using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.EL;
using Accounts.Common;
using System.Data.SqlClient;
using System.Data;

namespace Accounts.DAL
{
    public class VouchersDetailDAL
    {
        public bool InsertVouchersDetail(List<VoucherDetailEL> oelDetailCollection, Int64? IdVoucher, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdVoucherDetail = new SqlCommand("[Transactions].[Proc_CreateVouchersDetail]", objConn);
            cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
            cmdVoucherDetail.CommandTimeout = 0;
            cmdVoucherDetail.Transaction = objTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = oelDetailCollection[i].IdVoucherDetail.Value;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = IdVoucher.Value;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdAccount", DbType.Int64)).Value = oelDetailCollection[i].IdAccount;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@ClosingBalance", DbType.Decimal)).Value = oelDetailCollection[i].ClosingBalance;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelDetailCollection[i].Debit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelDetailCollection[i].Credit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.Decimal)).Value = oelDetailCollection[i].CreatedDateTime;
                cmdVoucherDetail.ExecuteNonQuery();
                cmdVoucherDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateVouchersDetail(List<VoucherDetailEL> oelDetailCollection, Int64? IdVoucher, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdVoucherDetail = new SqlCommand();
            cmdVoucherDetail.Connection = objConn;
            cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
            cmdVoucherDetail.CommandTimeout = 0;
            cmdVoucherDetail.Transaction = objTran;
            for (int i = 0; i < oelDetailCollection.Count; i++)
            {
                if (oelDetailCollection[i].IsNew)
                {
                    cmdVoucherDetail.CommandText = "[Transactions].[Proc_CreateVouchersDetail]";
                }
                else
                {
                    cmdVoucherDetail.CommandText = "[Transactions].[Proc_UpdateVouchersDetail]";
                }
                cmdVoucherDetail.CommandType = CommandType.StoredProcedure;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Guid)).Value = oelDetailCollection[i].IdVoucherDetail;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Guid)).Value = IdVoucher;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@IdAccount", DbType.Int64)).Value = oelDetailCollection[i].IdAccount;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelDetailCollection[i].AccountNo;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelDetailCollection[i].Description;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@ClosingBalance", DbType.Decimal)).Value = oelDetailCollection[i].ClosingBalance;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelDetailCollection[i].Debit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelDetailCollection[i].Credit;
                cmdVoucherDetail.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.Decimal)).Value = oelDetailCollection[i].CreatedDateTime;
                cmdVoucherDetail.ExecuteNonQuery();
                cmdVoucherDetail.Parameters.Clear();
            }
            return true;
        }
    }
}
