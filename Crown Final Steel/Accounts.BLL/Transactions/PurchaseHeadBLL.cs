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
    public class PurchaseHeadBLL
    {
        #region Variables
        PurchaseHeadDAL dal;
        public PurchaseHeadBLL()
        {
            dal = new PurchaseHeadDAL();
        }
        #endregion
        #region Purchases Methods
        public Int64 GetMaxPurchaseNumber(Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetMaxPurchaseNumber(IdProject, BookNo, IsNetTransaction, objConn);
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
        public EntityoperationInfo InsertPurchases(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseDetailCollection, List<TransactionsEL> oelTransactionsCollection,
                                                  List<VoucherDetailEL> oelPurchaseTransactionsCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                infoResult = dal.InsertPurchases(oelVoucher, oelPurchaseDetailCollection, oelTransactionsCollection, oelPurchaseTransactionsCollection, objConn);
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
        public EntityoperationInfo UpdatePurchases(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseDetailCollection, List<TransactionsEL> oelTransactionsCollection, List<VoucherDetailEL> oelPurchaseTransactionsCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                infoResult = dal.UpdatePurchases(oelVoucher, oelPurchaseDetailCollection, oelTransactionsCollection, oelPurchaseTransactionsCollection, objConn);
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
        public List<VoucherDetailEL> GetPurchasesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetPurchases)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetPurchasesTransactions(IdVoucher, IdProject, BookNo, IsNetPurchases, objConn);
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
        public List<VoucherDetailEL> GetPurchasesTransactionsByNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetPurchasesTransactionsByNumber(VoucherNo, IdProject, BookNo, IsNetTransaction, objConn);
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
        public List<VoucherDetailEL> GetPOSPurchasesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetPOSPurchasesTransactions(IdVoucher, IdProject, BookNo, objConn);
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
        public List<VoucherDetailEL> GetPOSPurchasesTransactionsByNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetPOSPurchasesTransactionsByNumber(VoucherNo, IdProject, BookNo, objConn);
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
        public List<VoucherDetailEL> GetPurchasesSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetPurchasesSubTransactions(IdVoucher, IdProject, BookNo, IsNetTransaction, objConn);
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
        public bool DeletePurchasesByVoucher(Int64 IdVoucher, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeletePurchasesByVoucher(IdVoucher, IdProject, objConn);
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
        #region Purchases Return Method
        public Int64 GetMaxPurchaseReturnNumber(Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetMaxPurchaseReturnNumber(IdProject, BookNo, IsNetTransaction, objConn);
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
        public EntityoperationInfo InsertPurchasesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseDetailCollection, List<VoucherDetailEL> oelPurchaseTransactionsCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                infoResult = dal.InsertPurchasesReturn(oelVoucher, oelPurchaseDetailCollection, oelPurchaseTransactionsCollection, objConn);
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
        public EntityoperationInfo UpdatePurchasesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelPurchaseDetailCollection, List<VoucherDetailEL> oelPurchaseTransactionsCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                infoResult = dal.UpdatePurchasesReturn(oelVoucher, oelPurchaseDetailCollection, oelPurchaseTransactionsCollection, objConn);
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
        public List<VoucherDetailEL> GetPurchasesReturnTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetPurchasesReturn)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetPurchasesReturnTransactions(IdVoucher, IdProject, BookNo, IsNetPurchasesReturn, objConn);
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
        public List<VoucherDetailEL> GetPurchasesReturnTransactionsByNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetPurchasesReturnTransactionsByNumber(VoucherNo, IdProject, BookNo, IsNetTransaction, objConn);
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
        public List<VoucherDetailEL> GetPurchasesReturnSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            EntityoperationInfo infoResult = new EntityoperationInfo();
            try
            {
                objConn.Open();
                return dal.GetPurchasesReturnSubTransactions(IdVoucher, IdProject, BookNo, IsNetTransaction, objConn);
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
        public bool DeletePurchasesReturnByVoucher(Int64 IdVoucher, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeletePurchasesReturnByVoucher(IdVoucher, IdProject, objConn);
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
        public bool UpdateStockitems(List<TransactionsEL> oelItemQuatityCollection,string ActionType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.UpdateStockItems(oelItemQuatityCollection, ActionType , objConn);
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
