using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Accounts.EL;
using System.Data.SqlClient;
using System.Data;
using Accounts.Common;

namespace Accounts.DAL
{
    public class UserModulesPermissionsDAL
    {
        IDataReader objReader;
        public EntityoperationInfo AssignPermissions(List<UserModulesPermissionsEL> oelUserModulesPermissionCollection, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction objTran = objConn.BeginTransaction();
            try
            {
                for (int i = 0; i < oelUserModulesPermissionCollection.Count; i++)
                {
                    if (oelUserModulesPermissionCollection[i].ModuleAction == "Assign")
                    {                        
                        infoResult.IsSuccess = CreateUsersModulesPermission(oelUserModulesPermissionCollection[i], objConn, objTran);
                    }
                    else if (oelUserModulesPermissionCollection[i].ModuleAction == "Update")
                    {
                        infoResult.IsSuccess = UpdateUsersModulesPermission(oelUserModulesPermissionCollection[i], objConn, objTran);
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
        public bool CreateUsersModulesPermission(UserModulesPermissionsEL oelUserModulesPermissions, SqlConnection objConn, SqlTransaction objTran)
        {
            if (!(GetUserModulePermissionById(oelUserModulesPermissions.IdMoudlePermission, objConn, objTran)))
            {
                SqlCommand cmdUserModulesPermissions = new SqlCommand("[Users].[Proc_CreateModulesPermission]", objConn, objTran);

                cmdUserModulesPermissions.CommandType = CommandType.StoredProcedure;

                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@IdModulePermission", DbType.Int64)).Value = oelUserModulesPermissions.IdMoudlePermission;
                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@IdModule", DbType.Int64)).Value = oelUserModulesPermissions.IdModule;
                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUserModulesPermissions.UserId;
                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Adding", DbType.Boolean)).Value = oelUserModulesPermissions.Saving;
                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Updating", DbType.Boolean)).Value = oelUserModulesPermissions.Updating;
                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Deleting", DbType.Boolean)).Value = oelUserModulesPermissions.Deleting;
                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Viewing", DbType.Boolean)).Value = oelUserModulesPermissions.Viewing;
                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Posting", DbType.Boolean)).Value = oelUserModulesPermissions.Posting;
                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Printing", DbType.Boolean)).Value = oelUserModulesPermissions.Printing;
                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelUserModulesPermissions.CreatedDateTime;

                cmdUserModulesPermissions.ExecuteNonQuery();
            }
            return true;
        }
        public bool UpdateUsersModulesPermission(UserModulesPermissionsEL oelUserModulesPermissions, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdUserModulesPermissions = new SqlCommand("[Users].[Proc_UpdateModulesPermission]", objConn, objTran);

            cmdUserModulesPermissions.CommandType = CommandType.StoredProcedure;

            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@IdModulePermission", DbType.Int64)).Value = oelUserModulesPermissions.IdMoudlePermission;
            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@IdModule", DbType.Int64)).Value = oelUserModulesPermissions.IdModule;
            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUserModulesPermissions.UserId;
            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Adding", DbType.Boolean)).Value = oelUserModulesPermissions.Saving;
            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Updating", DbType.Boolean)).Value = oelUserModulesPermissions.Updating;
            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Deleting", DbType.Boolean)).Value = oelUserModulesPermissions.Deleting;
            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Viewing", DbType.Boolean)).Value = oelUserModulesPermissions.Viewing;
            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Posting", DbType.Boolean)).Value = oelUserModulesPermissions.Posting;
            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@Printing", DbType.Boolean)).Value = oelUserModulesPermissions.Printing;
            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("CreatedDateTime", DbType.DateTime)).Value = oelUserModulesPermissions.CreatedDateTime;

            cmdUserModulesPermissions.ExecuteNonQuery();

            return true;
        }
        public EntityoperationInfo DeleteUserModulesPermissions(Int64? IdPermission, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdUserModulesPermissions = new SqlCommand("[Users].[Proc_DeleteModulesPermission]", objConn))
            {
                cmdUserModulesPermissions.CommandType = CommandType.StoredProcedure;

                cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@IdModulePermission", DbType.Int64)).Value = IdPermission.Value;

                if (cmdUserModulesPermissions.ExecuteNonQuery() > 0)
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
        public bool GetUserModulePermissionById(Int64? IdModulePermission, SqlConnection objConn,SqlTransaction objTran)
        {
            bool status = false;
            
            SqlCommand cmdUserModulesPermissions = new SqlCommand("[Users].[Proc_GetUserPermissionById]", objConn, objTran);

            cmdUserModulesPermissions.CommandType = CommandType.StoredProcedure;

            cmdUserModulesPermissions.Parameters.Add(new SqlParameter("@IdModulePermission", DbType.Int64)).Value = IdModulePermission.Value;

            objReader = cmdUserModulesPermissions.ExecuteReader();
            while (objReader.Read())
            {
                status = true;
                break;
            }
            objReader.Close();
            return status;
        }
        public List<UserModulesPermissionsEL> GetUserModulePermissionsById(Int64? Id, SqlConnection objConn)
        {
            List<UserModulesPermissionsEL> list = new List<UserModulesPermissionsEL>();
            SqlCommand cmdUserModules = new SqlCommand("[Users].[Proc_GetUserPermissionsById]", objConn);

            cmdUserModules.CommandType = CommandType.StoredProcedure;

            cmdUserModules.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = Id.Value;

            objReader = cmdUserModules.ExecuteReader();
            while (objReader.Read())
            {
                UserModulesPermissionsEL oelUserModuelPermission = new UserModulesPermissionsEL();
                oelUserModuelPermission.IdMoudlePermission = Validation.GetSafeLong(objReader["ModulePermission_Id"]);
                oelUserModuelPermission.IdUserModule = Validation.GetSafeLong(objReader["UserModule_Id"]);
                oelUserModuelPermission.IdModule = Validation.GetSafeLong(objReader["Module_Id"]);
                oelUserModuelPermission.ModuleName = Validation.GetSafeString(objReader["Module_Name"]);
                oelUserModuelPermission.Saving = Validation.GetSafeBooleanNullable(objReader["Adding"]);
                oelUserModuelPermission.Updating = Validation.GetSafeBooleanNullable(objReader["Updating"]);
                oelUserModuelPermission.Deleting = Validation.GetSafeBooleanNullable(objReader["Deleting"]);
                oelUserModuelPermission.Viewing = Validation.GetSafeBooleanNullable(objReader["Viewing"]);
                oelUserModuelPermission.Posting = Validation.GetSafeBooleanNullable(objReader["Posting"]);
                oelUserModuelPermission.Printing = Validation.GetSafeBooleanNullable(objReader["Printing"]);


                list.Add(oelUserModuelPermission);
            }
            return list;
        }
        public List<UserModulesPermissionsEL> GetUserModulePermissionsByUserAndModuleId(Int64? IdUser, Int64? IdModule, SqlConnection objConn)
        {
            List<UserModulesPermissionsEL> list = new List<UserModulesPermissionsEL>();
            SqlCommand cmdUserModules = new SqlCommand("[Users].[Proc_GetUserPermissionsOnModule]", objConn);

            cmdUserModules.CommandType = CommandType.StoredProcedure;

            cmdUserModules.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = IdUser.Value;
            cmdUserModules.Parameters.Add(new SqlParameter("@IdModule", DbType.Int64)).Value = IdModule.Value;

            objReader = cmdUserModules.ExecuteReader();
            while (objReader.Read())
            {
                UserModulesPermissionsEL oelUserModuelPermission = new UserModulesPermissionsEL();
                oelUserModuelPermission.Saving = Validation.GetSafeBooleanNullable(objReader["Adding"]);
                oelUserModuelPermission.Updating = Validation.GetSafeBooleanNullable(objReader["Updating"]);
                oelUserModuelPermission.Deleting = Validation.GetSafeBooleanNullable(objReader["Deleting"]);
                oelUserModuelPermission.Viewing = Validation.GetSafeBooleanNullable(objReader["Viewing"]);
                oelUserModuelPermission.Posting = Validation.GetSafeBooleanNullable(objReader["Posting"]);
                oelUserModuelPermission.Printing = Validation.GetSafeBooleanNullable(objReader["Printing"]);


                list.Add(oelUserModuelPermission);
            }
            return list;
        }
    }
}
