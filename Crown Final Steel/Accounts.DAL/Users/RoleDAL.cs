using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Accounts.Common;
using Accounts.EL;

namespace Accounts.DAL
{
    public class RoleDAL
    {
        IDataReader objReader;
        public EntityoperationInfo CreateRole(RoleEL oelRole, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdRoles = new SqlCommand("[Users].[Proc_CreateRoles]", objConn))
            {
                cmdRoles.CommandType = CommandType.StoredProcedure;

                cmdRoles.Parameters.Add(new SqlParameter("@IdRole", DbType.Int64)).Value = oelRole.IdRole;
                cmdRoles.Parameters.Add(new SqlParameter("@RoleName", DbType.String)).Value = oelRole.RoleName;
                cmdRoles.Parameters.Add(new SqlParameter("@Description", DbType.Guid)).Value = oelRole.Discription;
                cmdRoles.Parameters.Add(new SqlParameter("@RoleType", DbType.Guid)).Value = oelRole.RoleType;
                
                if (cmdRoles.ExecuteNonQuery() > 0)
                {
                    infoResult.IsSuccess = true;
                }
                else
                {
                    infoResult.IsSuccess = false;
                }

            }
            return infoResult;
        }
        public EntityoperationInfo UpdateRole(RoleEL oelRole, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdRoles = new SqlCommand("[Users].[Proc_UpdateRoles]", objConn))
            {
                cmdRoles.CommandType = CommandType.StoredProcedure;

                cmdRoles.Parameters.Add(new SqlParameter("@IdRole", DbType.Int64)).Value = oelRole.IdRole;
                cmdRoles.Parameters.Add(new SqlParameter("@RoleName", DbType.String)).Value = oelRole.RoleName;
                cmdRoles.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelRole.Discription;
                cmdRoles.Parameters.Add(new SqlParameter("@RoleType", DbType.String)).Value = oelRole.RoleType;

                if (cmdRoles.ExecuteNonQuery() > 0)
                {
                    infoResult.IsSuccess = true;
                }
                else
                {
                    infoResult.IsSuccess = false;
                }

            }
            return infoResult;
        }
        public EntityoperationInfo DeleteRole(Int64? IdRole, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdRoles = new SqlCommand("[Users].[Proc_DeleteRoles]", objConn))
            {
                cmdRoles.CommandType = CommandType.StoredProcedure;

                cmdRoles.Parameters.Add(new SqlParameter("@IdRole", DbType.Int64)).Value = IdRole.Value;

                if (cmdRoles.ExecuteNonQuery() > 0)
                {
                    infoResult.IsSuccess = true;
                }
                else
                {
                    infoResult.IsSuccess = false;
                }

            }
            return infoResult;
        }
        public List<RoleEL> GetAllRoles(SqlConnection oConn)
        {
            List<RoleEL> oelRolesCollection = new List<RoleEL>();
            using (SqlCommand cmdRoles = new SqlCommand("[Users].[Proc_GetAllRoles]", oConn))
            {
                cmdRoles.CommandType = CommandType.StoredProcedure;
                objReader = cmdRoles.ExecuteReader();
                while (objReader.Read())
                {
                    RoleEL oelRole = new RoleEL();
                    oelRole.IdRole = Validation.GetSafeLong(objReader["Role_Id"]);
                    oelRole.RoleName = Validation.GetSafeString(objReader["Role_Name"]);

                    oelRolesCollection.Add(oelRole);
                }
            }
            return oelRolesCollection;
        }
    }
}
