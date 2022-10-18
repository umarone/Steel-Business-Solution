using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.EL;
using Accounts.DAL;
using System.Data.SqlClient;
using Accounts.Common;

namespace Accounts.BLL
{
    public class UserModulesBLL
    {
        UserModulesDAL dal;
        public UserModulesBLL()
        {
            dal = new UserModulesDAL();
        }
        public EntityoperationInfo AssignModules(List<UserModulesEL> oelUserModulesCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.AssignModules(oelUserModulesCollection, objConn);
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
        public List<UserModulesEL> GetUserModulesById(Int64? Id)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetUserModulesById(Id, objConn);
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
        //public EntityoperationInfo CreateUserModules(UserModulesEL oelUserModule)
        //{
        //    SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
        //    try
        //    {
        //        objConn.Open();
        //        return dal.CreateUserModules(oelUserModule, objConn);
        //    }
        //    catch (Exception ex)
        //    {
        //        objConn.Close();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        objConn.Close();
        //        objConn.Dispose();
        //    }  
        //}
        //public EntityoperationInfo UpdateUserModules(UserModulesEL oelUserModule)
        //{
        //    SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
        //    try
        //    {
        //        objConn.Open();
        //        return dal.UpdateUserModules(oelUserModule, objConn);
        //    }
        //    catch (Exception ex)
        //    {
        //        objConn.Close();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        objConn.Close();
        //        objConn.Dispose();
        //    }  
        //}
        //public EntityoperationInfo DeleteUserModules(UserModulesEL oelUserModule)
        //{
        //    SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
        //    try
        //    {
        //        objConn.Open();
        //        return dal.DeleteUserModules(oelUserModule, objConn);
        //    }
        //    catch (Exception ex)
        //    {
        //        objConn.Close();
        //        throw ex;
        //    }
        //    finally
        //    {
        //        objConn.Close();
        //        objConn.Dispose();
        //    }  
        //}
        public List<UserModulesEL> GetUserModuleRightsByIdAndForm(Int64? Id, string FormName)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetUserModuleRightsByIdAndForm(Id,FormName, objConn);
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
    }
}
