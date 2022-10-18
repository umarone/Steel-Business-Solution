using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Accounts.EL;

namespace Accounts.DAL
{
   public class PaymentDetailDAL
    {
       public bool InsertPaymentDetail(List<PaymentDetailEL> oelPaymentDetailCollection, SqlConnection objConn,SqlTransaction oTran)
       {
           SqlCommand cmdPaymentDetail = new SqlCommand("sp_insertPaymentDetail", objConn);
           cmdPaymentDetail.CommandType = CommandType.StoredProcedure;
           cmdPaymentDetail.CommandTimeout = 0;
           cmdPaymentDetail.Transaction = oTran;
           for (int i = 0; i < oelPaymentDetailCollection.Count; i++)
           {
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@IdPaymentDetail", DbType.Guid)).Value = oelPaymentDetailCollection[i].IdPaymentDetail;
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelPaymentDetailCollection[i].VoucherNo;
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelPaymentDetailCollection[i].AccountNo;
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelPaymentDetailCollection[i].Description;
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPaymentDetailCollection[i].Amount;
               cmdPaymentDetail.ExecuteNonQuery();
               cmdPaymentDetail.Parameters.Clear();
           }
           return true;
       }
       public bool UpdatePaymentDetail(List<PaymentDetailEL> oelPaymentDetailCollection, SqlConnection objConn, SqlTransaction oTran)
       {
           SqlCommand cmdPaymentDetail = new SqlCommand();
           cmdPaymentDetail.CommandType = CommandType.StoredProcedure;
           cmdPaymentDetail.CommandTimeout = 0;
           cmdPaymentDetail.Connection = objConn;
           cmdPaymentDetail.Transaction = oTran;
           for (int i = 0; i < oelPaymentDetailCollection.Count; i++)
           {
               if (oelPaymentDetailCollection[i].IsNew)
               {
                   cmdPaymentDetail.CommandText = "sp_insertPaymentDetail";
               }
               else
               {
                   cmdPaymentDetail.CommandText = "sp_updatePaymentDetail";
               }
               cmdPaymentDetail.CommandType = CommandType.StoredProcedure;
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@IdPaymentDetail", DbType.Guid)).Value = oelPaymentDetailCollection[i].IdPaymentDetail;
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelPaymentDetailCollection[i].VoucherNo;
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelPaymentDetailCollection[i].AccountNo;
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelPaymentDetailCollection[i].Description;
               cmdPaymentDetail.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelPaymentDetailCollection[i].Amount;
               cmdPaymentDetail.ExecuteNonQuery();
               cmdPaymentDetail.Parameters.Clear();
           }
           return true;
       }
    }
}
