using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;

namespace Accounts.BLL
{
    public class OpeningBalanceBLL
    {
        OpeningBalanceDAL dal;
        public OpeningBalanceBLL()
        {
            dal = new OpeningBalanceDAL();
        }

        //public EntityoperationInfo InsertOpeningBalance(List<OpeningBalanceEL> oelOpeninBalanceCollection, List<TransactionsEL> oelTransactionsCollection, List<StockReceiptEL> oelOpeningStockCollection)
        //{
        //    SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
        //    try
        //    {
        //        objConn.Open();
        //        return dal.InsertOpeningBalance(oelOpeninBalanceCollection, oelTransactionsCollection,oelOpeningStockCollection, objConn);
        //    }
        //    catch (Exception ex)
        //    {
        //        objConn.Close();
        //        objConn.Dispose();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (objConn.State == ConnectionState.Open)
        //        {
        //            objConn.Close();
        //            objConn.Dispose();
        //        }
        //    }
        //}
        public EntityoperationInfo InsertOpeningBalance(List<OpeningBalanceEL> oelOpeninBalanceCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.InsertOpeningBalance(oelOpeninBalanceCollection, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        //public EntityoperationInfo UpdateOpeningBalance(OpeningBalanceEL oelOpeninBalance, List<TransactionsEL> oelTransactionsCollection,List<StockReceiptEL> oelOpeningStockCollection)
        //{
        //    SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
        //    try
        //    {
        //        objConn.Open();
        //        return dal.UpdateOpeningBalance(oelOpeninBalance, oelTransactionsCollection,oelOpeningStockCollection, objConn);
        //    }
        //    catch (Exception ex)
        //    {
        //        objConn.Close();
        //        objConn.Dispose();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (objConn.State == ConnectionState.Open)
        //        {
        //            objConn.Close();
        //            objConn.Dispose();
        //        }
        //    }
        //}
        public EntityoperationInfo UpdateOpeningBalance(List<OpeningBalanceEL> oelOpeninBalanceCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.UpdateOpeningBalance(oelOpeninBalanceCollection, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public EntityoperationInfo InsertUpdateOpeningBalance(List<OpeningBalanceEL> oelOpeningBalanceCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.InsertUpdateOpeningBalance(oelOpeningBalanceCollection, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<OpeningBalanceEL> GetOpeningBalance(Int64 IdProject, Int64 BookNo, string AccountNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetOpeningBalance(IdProject, BookNo, AccountNo, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<OpeningBalanceEL> GetOpeningBalancesByType(Int64 IdProject, Int64 BookNo, string OpeningType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetOpeningBalancesByType(IdProject, BookNo, OpeningType, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public EntityoperationInfo DeleteOpeningBalance(string AccountNo, Guid IdTransaction, Int64 IdCompany)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeleteOpeningBalance(AccountNo, IdTransaction, IdCompany, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
    }
}
