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
    public class AccountsBLL
    {
        AccountsDAL dal;
        EntityoperationInfo infoResult;
        public AccountsBLL()
        {
            dal = new AccountsDAL();
            infoResult = new EntityoperationInfo();
        }
        public EntityoperationInfo InsertChartsOfAccounts(AccountsEL oelChartsOfAccounts)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                infoResult = dal.InsertChartsOfAccounts(oelChartsOfAccounts, objConn);
            }
            catch(Exception ex)
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
        public EntityoperationInfo UpdateChartsOfAccounts(AccountsEL oelChartsOfAccounts)
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
        //public string GetAccountType(Int64 AccountType)
        //{
        //    SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
        //    string AccountNo = "";
        //    try
        //    {
        //        objConn.Open();
        //        AccountNo = dal.GetAccountType(AccountType, objConn);
        //    }
        //    catch (Exception ex)
        //    {
        //        objConn.Close();
        //        objConn.Dispose();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (objConn.State == System.Data.ConnectionState.Open)
        //        {
        //            objConn.Close();
        //            objConn.Dispose();
        //        }
        //    }
        //    return AccountNo;
        //}
        //public List<AccountsEL> GetAccountSubCategory(int Id)
        //{
        //    SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
        //    try
        //    {
        //        oConn.Open();
        //        return dal.GetAccountSubCategory(Id, oConn);
        //    }
        //    catch (Exception ex)
        //    {
        //        oConn.Close();
        //        oConn.Dispose();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (oConn.State == System.Data.ConnectionState.Open)
        //        {
        //            oConn.Close();
        //            oConn.Dispose();

        //        }
        //    }
        //}
        //public List<AccountsEL> GetAccountsByCategory(int Id)
        //{
        //    SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
        //    try
        //    {
        //        objConn.Open();
        //        return dal.GetAccountsByCategory(Id, objConn);
        //    }
        //    catch (Exception ex)
        //    {
        //        objConn.Close();
        //        objConn.Dispose();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (objConn.State == System.Data.ConnectionState.Open)
        //        {
        //            objConn.Close();
        //            objConn.Dispose();
        //        }
        //    }
        //}
        public List<AccountsEL> GetAccountsByParent(Int64? IdParent,Int64 IdProject, Int64 IdCompany, int IdLevel)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAccountsByParent(IdParent, IdProject, IdCompany, IdLevel, objConn);
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
        public List<AccountsEL> GetAccountByLevel(int IdLevel)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAccountByLevel(IdLevel, objConn);
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
        public List<AccountsEL> GetAccountsById(Int64? IdAccount)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAccountsById(IdAccount, objConn);
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
        public List<AccountsEL> GetAccountsByType(string AccountType, Int64 IdCompany, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAccountsByType(AccountType, IdCompany, IdProject, objConn);
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
        public string GetMaxAccountNo(int IdParent1, int IdParent2, int IdParent3, int IdLevel, Int64 IdCompany, Int64 IdParent)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetMaxAccountNo(IdParent1, IdParent2, IdParent3, IdLevel, IdCompany, IdParent, objConn);
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
        public List<AccountsLevels> GetParentHeads()
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetParentHeads(objConn);
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
        public List<AccountsLevels> GetCategoryHeadsByParent(int IdParent)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetCategoryHeadsByParent(IdParent,objConn);
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
        public List<AccountsEL> SearchAccountByAccountNo(Int64 AccountNo, Int64 IdCompany, Int64 IdProject)
        {
            SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                oConn.Open();
                return dal.SearchAccountsByAccountNo(AccountNo, IdCompany, IdProject, oConn);
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
        public List<AccountsEL> SearchAccountsByPersonalAccountNo(Int64 AccountNo, Int64 IdCompany, Int64 IdProject)
        {
            SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                oConn.Open();
                return dal.SearchAccountsByPersonalAccountNo(AccountNo, IdCompany, IdProject, oConn);
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
        public List<AccountsEL> SearchAccountByAccountName(string AccountName, Int64 IdCompany, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.SearchAccountByAccountName(AccountName, IdCompany, IdProject, objConn);
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
        public List<ItemsEL> SearchStockAccountByAccountNo(Int64 AccountNo, Guid IdCompany, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.SearchStockAccountByAccountNo(AccountNo,IdCompany, objConn);
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
        public List<ItemsEL> SearchStockAccountByAccountName(string AccountName, Guid IdCompany)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.SearchStockAccountByAccountName(AccountName, IdCompany, objConn);
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
        //public List<AccountsEL> GetAllSubCategory()
        //{
        //    SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
        //    try
        //    {
        //        oConn.Open();
        //        return dal.GetAllSubCategory(oConn);
        //    }
        //    catch (Exception ex)
        //    {
        //        oConn.Close();
        //        oConn.Dispose();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        if (oConn.State == System.Data.ConnectionState.Open)
        //        {
        //            oConn.Close();
        //            oConn.Dispose();

        //        }
        //    }
        //}
        public bool CheckAccount(Int64 AccountNo, Int64 IdCompany, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.CheckAccount(AccountNo, IdCompany, IdProject, objConn);
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
        public List<AccountsEL> GetAccount(string AccountNo, Int64 IdCompany, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAccount(AccountNo, IdCompany, IdProject, objConn);
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
        public List<AccountsEL> GetAccountsById(int IdParent, Int64 IdCompany, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAccountsById(IdParent, IdCompany, IdProject, objConn);
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
        public List<AccountsEL> GetAllAccounts(Int64 IdCompany, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAllAccounts(IdCompany, IdProject, objConn);
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
        public List<AccountsEL> GetAllInActiveAccounts(Int64 IdCompany, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAllInActiveAccounts(IdCompany, IdProject, objConn);
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
        public List<AccountsEL> GetEmployeesAccounts(Int64 IdCompany)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetEmployeesAccounts(IdCompany, objConn);
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
        public EntityoperationInfo DeleteChartOfAccount(Int64 IdAccount)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeleteChartOfAccount(IdAccount, objConn);
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
        public bool DeletePersonAccount(Int32 IdAccount)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeletePersonAccount(IdAccount, objConn);
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
        public bool DeleteItemAccount(Guid IdAccount)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeleteItemAccount(IdAccount, objConn);
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
