using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.EL;
using Accounts.Common;
using System.Data.SqlClient;
using System.Data;

namespace Accounts.DAL
{
    public class UserModulesDAL
    {
        IDataReader objReader;
        public EntityoperationInfo AssignModules(List<UserModulesEL> oelUserModulesCollection, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction objTran = objConn.BeginTransaction();
            try
            {
                for (int i = 0; i < oelUserModulesCollection.Count; i++)
                {
                    if (oelUserModulesCollection[i].ModuleAction == "Assign")
                    {
                        infoResult.IsSuccess = CreateUserModules(oelUserModulesCollection[i], objConn, objTran);
                    }
                    else if (oelUserModulesCollection[i].ModuleAction == "Remove")
                    {
                        infoResult.IsSuccess = DeleteUserModules(oelUserModulesCollection[i], objConn, objTran);
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
        public bool CreateUserModules(UserModulesEL oelUserModule, SqlConnection objConn, SqlTransaction objTran)
        {
            if (!(GetUserModuleById(oelUserModule.IdUserModule,objConn,objTran)))
            {
                SqlCommand cmdUserModules = new SqlCommand("[Users].[Proc_CreateUserModules]", objConn, objTran);

                cmdUserModules.CommandType = CommandType.StoredProcedure;

                cmdUserModules.Parameters.Add(new SqlParameter("@IdUserModule", DbType.Int64)).Value = oelUserModule.IdUserModule;
                cmdUserModules.Parameters.Add(new SqlParameter("@IdModule", DbType.Int64)).Value = oelUserModule.IdModule;
                cmdUserModules.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUserModule.UserId;
                cmdUserModules.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelUserModule.CreatedDateTime;

                cmdUserModules.ExecuteNonQuery();
            }
            return true;
        }
        public EntityoperationInfo UpdateUserModules(UserModulesEL oelUserModule, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdUserModules = new SqlCommand("[Users].[Proc_UpdateUserModules]", objConn))
            {
                cmdUserModules.CommandType = CommandType.StoredProcedure;

                cmdUserModules.Parameters.Add(new SqlParameter("@IdUserModule", DbType.Int64)).Value = oelUserModule.IdUserModule;
                cmdUserModules.Parameters.Add(new SqlParameter("@IdModule", DbType.Int64)).Value = oelUserModule.IdModule;
                cmdUserModules.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUserModule.UserId;
                cmdUserModules.Parameters.Add(new SqlParameter("@CreationDateTime", DbType.DateTime)).Value = oelUserModule.CreatedDateTime;

                if (cmdUserModules.ExecuteNonQuery() > 0)
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
        public bool DeleteUserModules(UserModulesEL oelUserModule, SqlConnection objConn, SqlTransaction objTran)
        {
            if (GetUserModuleById(oelUserModule.IdUserModule, objConn, objTran))
            {
                SqlCommand cmdUserModules = new SqlCommand("[Users].[Proc_DeleteUserModules]", objConn, objTran);

                cmdUserModules.CommandType = CommandType.StoredProcedure;

                cmdUserModules.Parameters.Add(new SqlParameter("@IdUserModule", DbType.Int64)).Value = oelUserModule.IdUserModule;

                cmdUserModules.ExecuteNonQuery();
            }

            return true;
        }
        public bool GetUserModuleById(Int64? Id, SqlConnection objConn, SqlTransaction objTran)
        {
            bool status = false;
            SqlCommand cmdUserModules = new SqlCommand("[Users].[Proc_GetModuleById]", objConn, objTran);

            cmdUserModules.CommandType = CommandType.StoredProcedure;

            cmdUserModules.Parameters.Add(new SqlParameter("@IdUserModule", DbType.Int64)).Value = Id.Value;

            objReader = cmdUserModules.ExecuteReader();
            while (objReader.Read())
            {
                status = true;                
                break;
            }
            objReader.Close();
            return status;

        }
        public List<UserModulesEL> GetUserModulesById(Int64? Id, SqlConnection objConn)
        {
            List<UserModulesEL> list = new List<UserModulesEL>();
            SqlCommand cmdUserModules = new SqlCommand("[Users].[Proc_GetUserModulesById]", objConn);

            cmdUserModules.CommandType = CommandType.StoredProcedure;

            cmdUserModules.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = Id.Value;

            objReader = cmdUserModules.ExecuteReader();
            while (objReader.Read())
            {
                UserModulesEL oelUserModule = new UserModulesEL();
                oelUserModule.IdUserModule = Validation.GetSafeLong(objReader["UserModule_Id"]);
                oelUserModule.IdModule = Validation.GetSafeLong(objReader["Module_Id"]);
                oelUserModule.ModuleName = Validation.GetSafeString(objReader["Module_Name"]);
                oelUserModule.IsEnabled = Validation.GetSafeBooleanNullable(objReader["IsEnabled"]);
                
                list.Add(oelUserModule);
            }
            return list;
        }
        public List<UserModulesEL> GetUserModuleRightsByIdAndForm(Int64? Id,string FormName, SqlConnection objConn)
        {
            List<UserModulesEL> list = new List<UserModulesEL>();
            SqlCommand cmdUserModules = new SqlCommand("[Users].[Proc_GetUserModulesRightByIdAndForm]", objConn);

            cmdUserModules.CommandType = CommandType.StoredProcedure;

            cmdUserModules.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = Id.Value;
            cmdUserModules.Parameters.Add(new SqlParameter("@FormName", DbType.String)).Value = FormName;

            objReader = cmdUserModules.ExecuteReader();
            while (objReader.Read())
            {
                UserModulesEL oelUserModule = new UserModulesEL();
                oelUserModule.IdModule = Validation.GetSafeLong(objReader["Module_Id"]);

                list.Add(oelUserModule);
                
            }
            return list;
        }
    }
}
