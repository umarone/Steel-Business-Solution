using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;
using System.Data;

namespace Accounts.BLL
{
    public class JournalVoucherBLL
    {
        JournalVoucherMasterDAL dal;
        public JournalVoucherBLL()
        {
            dal = new JournalVoucherMasterDAL();
        }
        public EntityoperationInfo InsertJournalVoucherMaster(VouchersEL oelVoucher, List<JournalVoucherEL> oelJVDetailCollection, List<TransactionsEL> oelTransactionsCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                infoResult = dal.InsertJournalVoucherMaster(oelVoucher, oelJVDetailCollection, oelTransactionsCollection, objConn);
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
        public EntityoperationInfo UpdateJournalVoucherMaster(VouchersEL oelVoucher, List<JournalVoucherEL> oelJVDetailCollection, List<TransactionsEL> oelTransactionsCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                infoResult = dal.UpdateJournalVoucherMaster(oelVoucher, oelJVDetailCollection, oelTransactionsCollection, objConn);
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
        public bool DeleteJournalVoucher(Int64 VoucherNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.DeleteJournalVoucher(VoucherNo, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
    }
}
