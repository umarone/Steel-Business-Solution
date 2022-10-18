using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;

namespace Accounts.BLL
{
   public class PaymentVoucherBLL
    {
       PaymentMasterDAL dal;
       public PaymentVoucherBLL()
       {
           dal = new PaymentMasterDAL();
       }
       public EntityoperationInfo InsertPayment(VouchersEL oelVoucher, List<PaymentDetailEL> oelPaymentDetailCollection, List<TransactionsEL> oelTransactionsCollection)
       {
           SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
           EntityoperationInfo infoResult = new EntityoperationInfo();
           try
           {
               objConn.Open();
               infoResult = dal.InsertPayment(oelVoucher, oelPaymentDetailCollection, oelTransactionsCollection, objConn);
           }
           catch (Exception ex)
           {
               objConn.Close();
               objConn.Dispose();
               throw ex;

           }
           finally
           {
               if (objConn.State == System.Data.ConnectionState.Open)
               {
                   objConn.Close();
                   objConn.Dispose();
               }
           }
           return infoResult;
       }
       public EntityoperationInfo UpdatePayment(VouchersEL oelVoucher, List<PaymentDetailEL> oelPaymentDetailCollection, List<TransactionsEL> oelTransactionsCollection)
       {
           SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
           EntityoperationInfo infoResult = new EntityoperationInfo();
           try
           {
               objConn.Open();
               infoResult = dal.UpdatePayment(oelVoucher, oelPaymentDetailCollection, oelTransactionsCollection, objConn);
           }
           catch (Exception ex)
           {
               objConn.Close();
               objConn.Dispose();
               throw ex;

           }
           finally
           {
               if (objConn.State == System.Data.ConnectionState.Open)
               {
                   objConn.Close();
                   objConn.Dispose();
               }
           }
           return infoResult;
       }
       public bool DeletePayment(Int64 VoucherNo, string TransactionType)
       {
           SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
           try
           {
               objConn.Open();
               return dal.DeletePayment(VoucherNo, TransactionType, objConn);
           }
           catch (Exception ex)
           {
               objConn.Close();
               objConn.Dispose();
               throw ex;
           }
           finally
           {
               if (objConn.State == System.Data.ConnectionState.Open)
               {
                   objConn.Close();
                   objConn.Dispose();
               }
           }
       }
        
    }
}
