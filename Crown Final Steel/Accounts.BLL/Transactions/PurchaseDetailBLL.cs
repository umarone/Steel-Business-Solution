using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;
using System.Data.SqlClient;
using System.Data;

namespace Accounts.BLL
{
    public class PurchaseDetailBLL
    {
        PurchaseDetailDAL dal;
        public PurchaseDetailBLL()
        {
            dal = new PurchaseDetailDAL();
        }
        public List<PurchaseDetailEL> GetSupplierPurchase(string AccountNo, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSupplierPurchase(AccountNo, IdProject, objconn);
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
        public List<PurchaseDetailEL> GetSupplierPurchaseByDate(string AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSupplierPurchaseByDate(AccountNo, StartDate, EndDate, IdProject, objconn);
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
        public List<PurchaseDetailEL> GetProductsTotalPurchase(Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetProductsTotalPurchase(IdProject, objconn);
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
        public List<PurchaseDetailEL> GetProductsTotalPurchaseByDate(DateTime StartDate, DateTime EndDate, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetProductsTotalPurchaseByDate(StartDate, EndDate, IdProject, objconn);
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
        public List<PurchaseDetailEL> GetProductDetailPurchase(Int64 AccountNo, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetProductDetailPurchase(AccountNo, IdProject, objconn);
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
        public List<PurchaseDetailEL> GetProductDetailPurchaseByDate(string AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetProductDetailPurchaseByDate(AccountNo, StartDate, EndDate, IdProject, objconn);
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
        public List<TransactionsEL> GetMonthlyPurchases(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMonthlyPurchases(IdProject, BookNo, IsNetTransaction, StartDate, EndDate, objconn);
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
        public List<TransactionsEL> GetMonthlyPurchasesWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMonthlyPurchasesWithDetail(IdProject, BookNo, AccountNo, IsNetTransaction, StartDate, EndDate, objconn);
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

        public List<TransactionsEL> GetMonthlyStraightPurchases(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMonthlyStraightPurchases(IdProject, BookNo, StartDate, EndDate, objconn);
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
        public List<TransactionsEL> GetMonthlyStraightPurchasesWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMonthlyStraightPurchasesWithDetail(IdProject, BookNo, AccountNo, StartDate, EndDate, objconn);
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

        public List<TransactionsEL> GetMonthlyPurchasesReturn(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMonthlyPurchasesReturn(IdProject, BookNo, IsNetTransaction, StartDate, EndDate, objconn);
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
        public List<TransactionsEL> GetMonthlyPurchasesReturnWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, bool IsNetTransaction, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMonthlyPurchasesReturnWithDetail(IdProject, BookNo, AccountNo, IsNetTransaction, StartDate, EndDate, objconn);
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
        public List<TransactionsEL> GetMonthlyStraightPurchasesReturn(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMonthlyStraightPurchasesReturn(IdProject, BookNo, StartDate, EndDate, objconn);
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
        public List<TransactionsEL> GetMonthlyStraightPurchasesReturnWithDetail(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMonthlyStraightPurchasesReturnWithDetail(IdProject, BookNo, AccountNo, StartDate, EndDate, objconn);
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
