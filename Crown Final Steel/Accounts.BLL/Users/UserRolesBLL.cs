using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

using Accounts.Common;
using Accounts.DAL;
using Accounts.EL;

namespace Accounts.BLL
{
    public class UserRolesBLL
    {
        UserRolesDAL dal;
        public UserRolesBLL()
        {
            dal = new UserRolesDAL();
        }
        public EntityoperationInfo AssignRoles(List<UserRolesEL> oelUserRolesCollection)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.AssignRoles(oelUserRolesCollection, objConn);
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
        public EntityoperationInfo CreateUserRole(UserRolesEL oelUserRole)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.CreateUserRoles(oelUserRole, objConn);
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
        public EntityoperationInfo UpdateRole(UserRolesEL oelUserRole)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.UpdateUserRoles(oelUserRole, objConn);
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
        public EntityoperationInfo DeleteRole(Guid? IdUserRole)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeleteUserRoles(IdUserRole, objConn);
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
        public List<UserRolesEL> GetUserRolesById(Int64? Id)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetUserRolesById(Id, objConn);
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
