using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Accounts.EL;

namespace Accounts.DAL
{
    public class JournalVoucherDetailDAL
    {
        public bool InsertJournalVoucherDetail(List<JournalVoucherEL> oelJVDetailCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdJVDetail = new SqlCommand("sp_insertJournalVoucherDetail", objConn);
            cmdJVDetail.CommandType = CommandType.StoredProcedure;
            cmdJVDetail.CommandTimeout = 0;
            cmdJVDetail.Transaction = oTran;
            for (int i = 0; i < oelJVDetailCollection.Count; i++)
            {
                cmdJVDetail.Parameters.Add(new SqlParameter("@IdJVDetail ", DbType.Guid)).Value = oelJVDetailCollection[i].IdJVDetail;
                cmdJVDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelJVDetailCollection[i].VoucherNo;
                cmdJVDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelJVDetailCollection[i].AccountNo;
                cmdJVDetail.Parameters.Add(new SqlParameter("@JVType", DbType.String)).Value = oelJVDetailCollection[i].JVType;
                cmdJVDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelJVDetailCollection[i].Description;
                cmdJVDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelJVDetailCollection[i].Amount;
                cmdJVDetail.ExecuteNonQuery();
                cmdJVDetail.Parameters.Clear();
            }
            return true;
        }
        public bool UpdateJournalVoucherDetail(List<JournalVoucherEL> oelJVDetailCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdJVDetail = new SqlCommand();
            cmdJVDetail.CommandText = "sp_UpdateJournalVoucherDetail";
            cmdJVDetail.CommandType = CommandType.StoredProcedure;
            cmdJVDetail.CommandTimeout = 0;
            cmdJVDetail.Connection = objConn;
            cmdJVDetail.Transaction = oTran;
            for (int i = 0; i < oelJVDetailCollection.Count; i++)
            {
                cmdJVDetail.Parameters.Add(new SqlParameter("@IdJVDetail ", DbType.Guid)).Value = oelJVDetailCollection[i].IdJVDetail;
                cmdJVDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelJVDetailCollection[i].AccountNo;
                cmdJVDetail.Parameters.Add(new SqlParameter("@JVType", DbType.String)).Value = oelJVDetailCollection[i].AccountNo;
                cmdJVDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelJVDetailCollection[i].Description;
                cmdJVDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelJVDetailCollection[i].Amount;
                cmdJVDetail.ExecuteNonQuery();
                cmdJVDetail.Parameters.Clear();
            }
            return true;
        }
    }
}