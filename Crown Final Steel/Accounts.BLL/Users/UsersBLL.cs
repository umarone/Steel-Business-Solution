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
    public class UsersBLL
    {
        UsersDAL dal;
        public UsersBLL()
        {
            dal = new UsersDAL();
        }
        public EntityoperationInfo CreateUsers(UsersEL oelUser)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();               
                return dal.CreateUsers(oelUser, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                throw ex;
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }            
        }
        public EntityoperationInfo UpdateUsers(UsersEL oelUser)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.UpdateUsers(oelUser, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
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
        public bool CheckUserNameDuplication(Int64 IdProject, string UserName)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.CheckUserNameDuplication(IdProject,UserName, objConn);
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
        public List<UsersEL> GetAllUsers()
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            List<UsersEL> oelUsersCollection = null;
            try
            {
                objConn.Open();
                oelUsersCollection = dal.GetAllUsers(objConn);
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
            return oelUsersCollection;
        }
        public List<UsersEL> GetAllActiveUsers()
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            List<UsersEL> oelUsersCollection = null;
            try
            {
                objConn.Open();
                oelUsersCollection = dal.GetAllActiveUsers(objConn);
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
            return oelUsersCollection;
        }
        public List<UsersEL> GetUserByProjectId(Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetUserByProjectId(IdProject, objConn);
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
        public List<UsersEL> GetUserById(Int64 IdUser)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetUserById(IdUser, objConn);
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
        public List<UsersEL> verifyUser(UsersEL oelUsers)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);            
            try
            {
                objConn.Open();
                return dal.verifyUser(oelUsers, objConn);
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
        //public List<UserRolesEL> verifyUser(UserRolesEL oelUsers, SqlConnection oConnection)
        //{
        //    SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
        //    try
        //    {
        //        objConn.Open();
        //        return dal.verifyUser(oelUsers, objConn);
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
        public EntityoperationInfo DeleteUsers(UsersEL oelUser)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();               
                return dal.DeleteUsers(oelUser, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                throw ex;
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }
        }
        #region User Activity Logger Methods
        public List<AccountsEL> GetAllAccountsByUserAndDateForActivityLogger(Int64 IdUser, DateTime dt)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAllAccountsByUserAndDateForActivityLogger(IdUser, dt, objConn);
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
        public List<AccountsEL> GetAllAccountsByUserForActivityLogger(Int64 IdUser)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAllAccountsByUserForActivityLogger(IdUser, objConn);
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
        public List<TransactionsEL> GetVouchersByUserAndDateForActivity(Int64 IdUser, Int64 IdProject, Int64 BookNo, DateTime ActivityDate, string VType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetVouchersByUserAndDateForActivity(IdUser, IdProject, BookNo, ActivityDate, VType, objConn);
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
        public List<VouchersEL> GetStockVouchersByUserAndDateForActivity(Int64 IdUser, Int64 IdProject, Int64 BookNo, DateTime ActivityDate, string VType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetStockVouchersByUserAndDateForActivity(IdUser, IdProject, BookNo, ActivityDate, VType, objConn);
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
