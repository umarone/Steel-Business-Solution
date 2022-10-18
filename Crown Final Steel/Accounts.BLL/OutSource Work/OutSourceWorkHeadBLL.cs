using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;
using System.Data.SqlClient;

namespace Accounts.BLL
{
    public class OutSourceWorkHeadBLL
    {
        #region Variables
        OutSourceWorkHeadDAL dal;
        #endregion
        public OutSourceWorkHeadBLL()
        {
            dal = new OutSourceWorkHeadDAL();
        }
        #region OutSource Methods
        public Int64 GetMaxOutSourceWorkNumber(Int64 IdProject, Int64 BookNo, Int32 WorkType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetMaxOutSourceWorkNumber(IdProject, BookNo, WorkType, objConn);
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
        public EntityoperationInfo CreateOutSourceWork(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseDetailCollection,List<VoucherDetailEL> oelPurchaseTransactionsCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                infoResult = dal.CreateOutSourceWork(oelVoucher, oelPurchaseDetailCollection, oelPurchaseTransactionsCollection, objConn);
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
        public EntityoperationInfo UpdateOutSourceWork(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseDetailCollection,List<VoucherDetailEL> oelPurchaseTransactionsCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                infoResult = dal.UpdateOutSourceWork(oelVoucher, oelPurchaseDetailCollection, oelPurchaseTransactionsCollection, objConn);
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
        public List<VoucherDetailEL> GetOutSourceWorkTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, int WorkType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetOutSourceWorkTransactions(IdVoucher, IdProject, BookNo, WorkType, objConn);
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
        public List<VoucherDetailEL> GetOutSourceWorkTransactionsByNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo, int WorkType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetOutSourceWorkTransactionsByNumber(VoucherNo, IdProject, BookNo, WorkType, objConn);
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
        public List<VoucherDetailEL> GetOutSourceWorkSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, int WorkType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetOutSourceWorkSubTransactions(IdVoucher, IdProject, BookNo, WorkType, objConn);
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
        public bool DeleteOutSourceWorkByVoucher(Int64 IdVoucher, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeleteOutSourceWorkByVoucher(IdVoucher, IdProject, objConn);
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
        #endregion
    }
}
