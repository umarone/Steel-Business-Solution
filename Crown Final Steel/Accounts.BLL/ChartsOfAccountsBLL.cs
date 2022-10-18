using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;
namespace Accounts.BLL
{
    public class ChartsOfAccountsBLL
    {
        ChartsOfAccountsDAL dal;
        EntityoperationInfo infoResult;
        public ChartsOfAccountsBLL()
        {
            dal = new ChartsOfAccountsDAL();
            infoResult = new EntityoperationInfo();
        }
        public EntityoperationInfo InsertChartsOfAccounts(ChartsOfAccountsEL oelChartsOfAccounts)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                infoResult = dal.InsertChartsOfAccounts(oelChartsOfAccounts,objConn);
            }
            catch
            {
                objConn.Close();
                objConn.Dispose();
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
        public EntityoperationInfo UpdateChartsOfAccounts(ChartsOfAccountsEL oelChartsOfAccounts)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                infoResult = dal.UpdateChartsOfAccounts(oelChartsOfAccounts, objConn);
            }
            catch
            {
                objConn.Close();
                objConn.Dispose();
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
        public  string GetAccountType(string AccountType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            string AccountNo = "";
            try
            {
                objConn.Open();
                AccountNo = dal.GetAccountType(AccountType, objConn);
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
            return AccountNo;
        }
        public List<ChartsOfAccountsEL> GetAccountSubCategory(int Id)
        {
            SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                oConn.Open();
                return dal.GetAccountSubCategory(Id,oConn);
            }
            catch (Exception ex)
            {
                oConn.Close();
                oConn.Dispose();
                throw ex;
            }
            finally
            {
                if (oConn.State == System.Data.ConnectionState.Open)
                {
                    oConn.Close();
                    oConn.Dispose();

                }
            }
        }
        public List<ChartsOfAccountsEL> GetAccountsByCategory(int Id)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAccountsByCategory(Id,objConn);
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
        public List<ChartsOfAccountsEL> SearchAccountByAccountNo(string AccountNo)
        {
            SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                oConn.Open();
                return dal.SearchAccountByAccountNo(AccountNo, oConn);
            }
            catch (Exception ex)
            {
                oConn.Close();
                oConn.Dispose();
                throw ex;
            }
            finally
            {
                if (oConn.State == System.Data.ConnectionState.Open)
                {
                    oConn.Close();
                    oConn.Dispose();

                }
            }
        }
        public List<ChartsOfAccountsEL> SearchAccountByAccountName(string AccountName)
        {
            SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                oConn.Open();
                return dal.SearchAccountByAccountName(AccountName, oConn);
            }
            catch (Exception ex)
            {
                oConn.Close();
                oConn.Dispose();
                throw ex;
            }
            finally
            {
                if (oConn.State == System.Data.ConnectionState.Open)
                {
                    oConn.Close();
                    oConn.Dispose();

                }
            }
        }
        public List<ItemsEL> SearchStockAccountByAccountNo(string AccountNo)
        {
            SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                oConn.Open();
                return dal.SearchStockAccountByAccountNo(AccountNo, oConn);
            }
            catch (Exception ex)
            {
                oConn.Close();
                oConn.Dispose();
                throw ex;
            }
            finally
            {
                if (oConn.State == System.Data.ConnectionState.Open)
                {
                    oConn.Close();
                    oConn.Dispose();

                }
            }
        }
        public List<ItemsEL> SearchStockAccountByAccountName(string AccountName)
        {
            SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                oConn.Open();
                return dal.SearchStockAccountByAccountName(AccountName, oConn);
            }
            catch (Exception ex)
            {
                oConn.Close();
                oConn.Dispose();
                throw ex;
            }
            finally
            {
                if (oConn.State == System.Data.ConnectionState.Open)
                {
                    oConn.Close();
                    oConn.Dispose();

                }
            }
        }
        public List<ChartsOfAccountsEL> GetAllSubCategory()
        {
            SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                oConn.Open();
                return dal.GetAllSubCategory(oConn);
            }
            catch (Exception ex)
            {
                oConn.Close();
                oConn.Dispose();
                throw ex;
            }
            finally
            {
                if (oConn.State == System.Data.ConnectionState.Open)
                {
                    oConn.Close();
                    oConn.Dispose();

                }
            }
        }
        public bool CheckAccount(string AccountNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.CheckAccount(AccountNo,objConn);
            }
            catch(Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if(objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<ChartsOfAccountsEL> GetAccount(String AccountNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAccount(AccountNo, objConn);
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
        public EntityoperationInfo DeleteChartOfAccount(string AccountNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeleteChartOfAccount(AccountNo, objConn);
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
        public bool DeletePersonAccount(string AccountNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeletePersonAccount(AccountNo, objConn);
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
        public bool DeleteItemAccount(string AccountNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeleteItemAccount(AccountNo, objConn);
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
