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
    public class UserRolesDAL
    {
        IDataReader objReader;
        public EntityoperationInfo AssignRoles(List<UserRolesEL> oelUserRolesCollection, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction objTran = objConn.BeginTransaction();
            try
            {
                for (int i = 0; i < oelUserRolesCollection.Count; i++)
                {
                    if (oelUserRolesCollection[i].RoleAction == "Assign")
                    {
                        infoResult.IsSuccess = CreateUserRoles(oelUserRolesCollection[i], objConn, objTran);
                    }
                    else if (oelUserRolesCollection[i].RoleAction == "Remove")
                    {
                        infoResult.IsSuccess = DeleteUserRoles(oelUserRolesCollection[i], objConn, objTran);
                    }
                }
                objTran.Commit();
                return infoResult;
            }
            catch (Exception ex)
            {
                objTran.Rollback();
                throw ex;
            }
        }
        public bool CreateUserRoles(UserRolesEL oelUserRole, SqlConnection objConn, SqlTransaction objTran)
        {
            //if (!(GetUserRoleById(oelUserRole.IdUserRole, objConn, objTran)))
            {
                SqlCommand cmdUserRoles = new SqlCommand("[Users].[Proc_CreateUserRole]", objConn, objTran);

                cmdUserRoles.CommandType = CommandType.StoredProcedure;

                cmdUserRoles.Parameters.Add(new SqlParameter("@IdRole", DbType.Int64)).Value = oelUserRole.IdRole;
                cmdUserRoles.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUserRole.UserId;
                cmdUserRoles.Parameters.Add(new SqlParameter("@IsRoleActive", DbType.Boolean)).Value = oelUserRole.IsActive;

                cmdUserRoles.ExecuteNonQuery();
            }
            return true;
        }
        public EntityoperationInfo CreateUserRoles(UserRolesEL oelUserRole, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdUserRoles = new SqlCommand("[Users].[Proc_CreateUserRole]", objConn))
            {
                cmdUserRoles.CommandType = CommandType.StoredProcedure;

                cmdUserRoles.Parameters.Add(new SqlParameter("@IdRole", DbType.Int64)).Value = oelUserRole.IdRole;
                cmdUserRoles.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUserRole.UserId;
                cmdUserRoles.Parameters.Add(new SqlParameter("@IsRoleActive", DbType.Boolean)).Value = oelUserRole.IsActive;

                if (cmdUserRoles.ExecuteNonQuery() > 0)
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
        public EntityoperationInfo UpdateUserRoles(UserRolesEL oelUserRole, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdUserRoles = new SqlCommand("[Users].[Proc_UpdateUserRole]", objConn))
            {
                cmdUserRoles.CommandType = CommandType.StoredProcedure;

                cmdUserRoles.Parameters.Add(new SqlParameter("@IdUserRole", DbType.Int64)).Value = oelUserRole.IdUserRole;
                cmdUserRoles.Parameters.Add(new SqlParameter("@IdRole", DbType.Int64)).Value = oelUserRole.IdRole;
                cmdUserRoles.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUserRole.UserId;

                if (cmdUserRoles.ExecuteNonQuery() > 0)
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
        public bool DeleteUserRoles(UserRolesEL oelUserRole, SqlConnection objConn, SqlTransaction objTran)
        {
            if (GetUserRoleById(oelUserRole.IdUserRole,objConn,objTran))
            {
                SqlCommand cmdUserRoles = new SqlCommand("[Users].[Proc_DeleteUserRole]", objConn, objTran);

                cmdUserRoles.CommandType = CommandType.StoredProcedure;
                cmdUserRoles.Parameters.Add(new SqlParameter("@IdUserRole", DbType.Int64)).Value = oelUserRole.IdUserRole;

                cmdUserRoles.ExecuteNonQuery();
            }
            return true;            
        }
        public EntityoperationInfo DeleteUserRoles(Guid? IdUserRole, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdRoles = new SqlCommand("[Users].[Proc_DeleteUserRole]", objConn))
            {
                cmdRoles.CommandType = CommandType.StoredProcedure;

                cmdRoles.Parameters.Add(new SqlParameter("@IdUserRole", DbType.Int64)).Value = IdUserRole.Value;

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
        public bool GetUserRoleById(Int64? Id, SqlConnection objConn, SqlTransaction objTran)
        {
            bool status = false;
            SqlCommand cmdUserRoles = new SqlCommand("[Users].[Proc_GetUserRoleById]", objConn, objTran);

            cmdUserRoles.CommandType = CommandType.StoredProcedure;

            cmdUserRoles.Parameters.Add(new SqlParameter("@IdUserRole", DbType.Int64)).Value = Id.Value;

            objReader = cmdUserRoles.ExecuteReader();
            while (objReader.Read())
            {
                status = true;
                break;
            }
            objReader.Close();
            return status;

        }
        public List<UserRolesEL> GetUserRolesById(Int64? Id, SqlConnection objConn)
        {
            List<UserRolesEL> list = new List<UserRolesEL>();
            SqlCommand cmdUserRoles = new SqlCommand("[Users].[Proc_GetUserRolesById]", objConn);

            cmdUserRoles.CommandType = CommandType.StoredProcedure;

            cmdUserRoles.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = Id.Value;

            objReader = cmdUserRoles.ExecuteReader();
            while (objReader.Read())
            {
                UserRolesEL oelUserRole = new UserRolesEL();
                oelUserRole.IdUserRole = Validation.GetSafeLong(objReader["User_Role_Id"]);
                oelUserRole.IdRole = Validation.GetSafeLong(objReader["Role_Id"]);
                oelUserRole.RoleName = Validation.GetSafeString(objReader["Role_Name"]);
                oelUserRole.IsActive = Validation.GetSafeBooleanNullable(objReader["IsRoleActive"]);

                list.Add(oelUserRole);
            }
            return list;
        }
    }
}
