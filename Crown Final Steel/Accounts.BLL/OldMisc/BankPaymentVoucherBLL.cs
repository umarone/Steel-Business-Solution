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
    public class BankPaymentVoucherBLL
    {
        BankPaymentVoucherDAL dal;
        public BankPaymentVoucherBLL()
       {
           dal = new BankPaymentVoucherDAL();
       }
       public EntityoperationInfo InsertBankPayment(VouchersEL oelVoucher, List<TransactionsEL> oelTransactionsCollection)
       {
           SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
           EntityoperationInfo infoResult = new EntityoperationInfo();
           try
           {
               objConn.Open();
               infoResult = dal.InsertBankPayment(oelVoucher, oelTransactionsCollection, objConn);
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
       public EntityoperationInfo UpdateBankPayment(VouchersEL oelVoucher, List<TransactionsEL> oelTransactionsCollection)
       {
           SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
           EntityoperationInfo infoResult = new EntityoperationInfo();
           try
           {
               objConn.Open();
               infoResult = dal.UpdateBankPayment(oelVoucher, oelTransactionsCollection, objConn);
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
       public bool DeleteBankPayment(Int64 VoucherNo, string TransactionType)
       {
           SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
           try
           {
               objConn.Open();
               return dal.DeleteBankPayment(VoucherNo, TransactionType, objConn);
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
