using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.Common;
using Accounts.EL;
using Accounts.DAL;
using System.Data.SqlClient;

namespace Accounts.BLL
{
    public class RoleBLL
    {
        RoleDAL dal;
        public RoleBLL()
        {
            dal = new RoleDAL();
        }
        public EntityoperationInfo CreateRole(RoleEL oelRole)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.CreateRole(oelRole, objConn);
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
        public EntityoperationInfo UpdateRole(RoleEL oelRole)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.UpdateRole(oelRole, objConn);
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
        public EntityoperationInfo DeleteRole(Int64? IdRole)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.DeleteRole(IdRole, objConn);
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
        public List<RoleEL> GetAllRoles()
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAllRoles(objConn);
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
