using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Accounts.EL;


namespace Accounts.DAL
{
   public class RecievedDetailDAL
    {
       public bool InsertRecievedDetail(List<RecievedDetailEL> oelRecievedDetailCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdRecievedDetail = new SqlCommand("sp_insertRecievedDetail", objConn);
            cmdRecievedDetail.CommandType = CommandType.StoredProcedure;
            cmdRecievedDetail.CommandTimeout = 0;
            cmdRecievedDetail.Transaction = oTran;
            for (int i = 0; i <oelRecievedDetailCollection.Count; i++)
            {
                cmdRecievedDetail.CommandType = CommandType.StoredProcedure;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@IdRecievedDetail", DbType.Guid)).Value = oelRecievedDetailCollection[i].IdRecievedDetail;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelRecievedDetailCollection[i].VoucherNo;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelRecievedDetailCollection[i].AccountNo;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelRecievedDetailCollection[i].Description;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelRecievedDetailCollection[i].Amount;
                cmdRecievedDetail.ExecuteNonQuery();
                cmdRecievedDetail.Parameters.Clear();
            }
            return true;
        }
       public bool UpdateRecievedDetail(List<RecievedDetailEL> oelRecievedDetailCollection, SqlConnection objConn, SqlTransaction oTran)
        {
            SqlCommand cmdRecievedDetail = new SqlCommand();
            cmdRecievedDetail.CommandType = CommandType.StoredProcedure;
            cmdRecievedDetail.CommandTimeout = 0;
            cmdRecievedDetail.Connection = objConn;
            cmdRecievedDetail.Transaction = oTran;
            for (int i = 0; i <oelRecievedDetailCollection.Count; i++)
            {
                if (oelRecievedDetailCollection[i].IsNew)
                {
                    cmdRecievedDetail.CommandText = "sp_insertRecievedDetail";
                }
                else
                {
                    cmdRecievedDetail.CommandText = "sp_updateRecievedDetail";
                }
                cmdRecievedDetail.CommandType = CommandType.StoredProcedure;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@IdRecievedDetail", DbType.Guid)).Value = oelRecievedDetailCollection[i].IdRecievedDetail;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelRecievedDetailCollection[i].VoucherNo;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelRecievedDetailCollection[i].AccountNo;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelRecievedDetailCollection[i].Description;
                cmdRecievedDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelRecievedDetailCollection[i].Amount;
                cmdRecievedDetail.ExecuteNonQuery();
                cmdRecievedDetail.Parameters.Clear();
            }
            return true;
        }
    }
}
