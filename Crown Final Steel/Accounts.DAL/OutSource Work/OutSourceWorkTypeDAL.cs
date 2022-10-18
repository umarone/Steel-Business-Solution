using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Accounts.EL;
using Accounts.Common;

namespace Accounts.DAL
{
    public class OutSourceWorkTypeDAL
    {
        IDataReader objReader;
        public EntityoperationInfo CreateOutSourceWorkType(OutSourceWorkTypeEL oelOutSourceWorkType, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdOutSourceWorkType = new SqlCommand("[Setup].[Proc_CreateOutSourceWorkType]", objConn))
            {
                cmdOutSourceWorkType.CommandType = CommandType.StoredProcedure;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IdOutSourceWorkType", DbType.Int64)).Value = oelOutSourceWorkType.IdOutSourceWorkType;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@OutSourceWorkTypeCode", DbType.Int64)).Value = oelOutSourceWorkType.OutSourceWorkTypeCode;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@OutSourceWorkTypeName", DbType.String)).Value = oelOutSourceWorkType.OutSourceWorkTypeName;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@OutSourceWorkDiscription", DbType.String)).Value = oelOutSourceWorkType.Discription;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelOutSourceWorkType.IdProject;                
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelOutSourceWorkType.UserId;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelOutSourceWorkType.IsActive;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelOutSourceWorkType.CreatedDateTime;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdOutSourceWorkType.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo UpdateOutSourceWorkType(OutSourceWorkTypeEL oelOutSourceWorkType, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdOutSourceWorkType = new SqlCommand("[Setup].[Proc_UpdateOutSourceWorkType]", objConn))
            {
                cmdOutSourceWorkType.CommandType = CommandType.StoredProcedure;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IdOutSourceWorkType", DbType.Int64)).Value = oelOutSourceWorkType.IdOutSourceWorkType;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@OutSourceWorkTypeCode", DbType.Int64)).Value = oelOutSourceWorkType.OutSourceWorkTypeCode;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@OutSourceWorkTypeName", DbType.String)).Value = oelOutSourceWorkType.OutSourceWorkTypeName;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@OutSourceWorkDiscription", DbType.String)).Value = oelOutSourceWorkType.Discription;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelOutSourceWorkType.IdProject;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelOutSourceWorkType.UserId;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelOutSourceWorkType.IsActive;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelOutSourceWorkType.CreatedDateTime;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdOutSourceWorkType.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo DeleteOutSourceWorkType(Int64 IdOutSourceWorkType, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdOutSourceWorkType = new SqlCommand("[Setup].[Proc_DeleteOutSourceWorkType]", objConn))
            {
                cmdOutSourceWorkType.CommandType = CommandType.StoredProcedure;
                cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IdOutSourceWorkType", DbType.Int64)).Value = IdOutSourceWorkType;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdOutSourceWorkType.ExecuteNonQuery() > -1)
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
        public Int64 GetMaxOutSourceWorkTypeCode(Int64 IdProject, SqlConnection objConn)
        {
            SqlCommand cmdAccount = new SqlCommand("[Setup].[Proc_GetMaxOutSouceWorkTypeCode]", objConn);
            cmdAccount.CommandType = CommandType.StoredProcedure;
            cmdAccount.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            return Validation.GetSafeLong(cmdAccount.ExecuteScalar());

        }
        public List<OutSourceWorkTypeEL> GetOutSourceWorkTypeById(Int64 IdOutSourceWorkType, SqlConnection objConn)
        {
            List<OutSourceWorkTypeEL> list = new List<OutSourceWorkTypeEL>();
            SqlCommand cmdOutSourceWorkType = new SqlCommand("[Setup].[Proc_GetOutSourceWorkTypeById]", objConn);

            cmdOutSourceWorkType.Parameters.Add("@IdOutSourceWorkType", SqlDbType.BigInt).Value = IdOutSourceWorkType;

            cmdOutSourceWorkType.CommandType = CommandType.StoredProcedure;
            objReader = cmdOutSourceWorkType.ExecuteReader();
            while (objReader.Read())
            {
                OutSourceWorkTypeEL oelOutSourceWorktype = new OutSourceWorkTypeEL();
                oelOutSourceWorktype.IdOutSourceWorkType = Validation.GetSafeLong(objReader["OutSourceWorkType_Id"]);
                oelOutSourceWorktype.OutSourceWorkTypeCode = Validation.GetSafeString(objReader["OutSourceWorkType_Code"]);
                oelOutSourceWorktype.OutSourceWorkTypeName = Validation.GetSafeString(objReader["OutSourceWorkType_Name"]);
                oelOutSourceWorktype.Discription = Validation.GetSafeString(objReader["OutSourceWorkType_Discription"]);
                oelOutSourceWorktype.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelOutSourceWorktype.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelOutSourceWorktype.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelOutSourceWorktype);
            }
            return list;
        }
        public List<OutSourceWorkTypeEL> GetAllOutSourceWorkTypes(Int64 IdProject, SqlConnection objConn)
        {
            List<OutSourceWorkTypeEL> list = new List<OutSourceWorkTypeEL>();
            SqlCommand cmdOutSourceWorkType = new SqlCommand("[Setup].[Proc_GetAllOutSourceWorkTypes]", objConn);
            cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdOutSourceWorkType.CommandType = CommandType.StoredProcedure;
            objReader = cmdOutSourceWorkType.ExecuteReader();
            while (objReader.Read())
            {
                OutSourceWorkTypeEL oelOutSourceWorkType = new OutSourceWorkTypeEL();
                oelOutSourceWorkType.IdOutSourceWorkType = Validation.GetSafeLong(objReader["OutSourceWorkType_Id"]);
                oelOutSourceWorkType.OutSourceWorkTypeCode = Validation.GetSafeString(objReader["OutSourceWorkType_Code"]);
                oelOutSourceWorkType.OutSourceWorkTypeName = Validation.GetSafeString(objReader["OutSourceWorkType_Name"]);
                oelOutSourceWorkType.Discription = Validation.GetSafeString(objReader["OutSourceWorkType_Discription"]);
                oelOutSourceWorkType.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelOutSourceWorkType.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelOutSourceWorkType.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelOutSourceWorkType);
            }
            return list;
        }
        public bool CheckOutSourceWorkTypeNameDuplication(string OutSourceWorkTypeName, SqlConnection objConn)
        {
            List<CategoryEL> list = new List<CategoryEL>();
            SqlCommand cmdOutSourceWorkType = new SqlCommand("[Setup].[Proc_CheckOutSourceWorkTypeNameDuplication]", objConn);

            cmdOutSourceWorkType.Parameters.Add("@OutSourceWorkTypeName", SqlDbType.VarChar).Value = OutSourceWorkTypeName;

            cmdOutSourceWorkType.CommandType = CommandType.StoredProcedure;
            objReader = cmdOutSourceWorkType.ExecuteReader();
            while (objReader.Read())
            {
                CategoryEL oelCategory = new CategoryEL();
                oelCategory.IdCategory = Validation.GetSafeLong(objReader["OutSourceWorkType_Id"]);
                oelCategory.CategoryCode = Validation.GetSafeString(objReader["OutSourceWorkType_Code"]);
                oelCategory.CategoryName = Validation.GetSafeString(objReader["OutSourceWorkType_Name"]);
                oelCategory.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCategory.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelCategory.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelCategory);
            }
            if (list.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool CheckOutSourceWorkTypeCodeDuplication(Int64 OutSourceWorkTypeCode, SqlConnection objConn)
        {
            List<OutSourceWorkTypeEL> list = new List<OutSourceWorkTypeEL>();
            SqlCommand cmdOutSourceWorkType = new SqlCommand("[Setup].[Proc_CheckOutSourceWorkTypeCodeDuplication]", objConn);

            cmdOutSourceWorkType.Parameters.Add("@OutSourceWorkTypeCode", SqlDbType.BigInt).Value = OutSourceWorkTypeCode;

            cmdOutSourceWorkType.CommandType = CommandType.StoredProcedure;
            objReader = cmdOutSourceWorkType.ExecuteReader();
            while (objReader.Read())
            {
                OutSourceWorkTypeEL oelOutSourceWorkType = new OutSourceWorkTypeEL();
                oelOutSourceWorkType.IdOutSourceWorkType = Validation.GetSafeLong(objReader["OutSourceWorkType_Id"]);
                oelOutSourceWorkType.OutSourceWorkTypeCode = Validation.GetSafeString(objReader["OutSourceWorkType_Code"]);
                oelOutSourceWorkType.OutSourceWorkTypeName = Validation.GetSafeString(objReader["OutSourceWorkType_Name"]);
                oelOutSourceWorkType.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelOutSourceWorkType.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelOutSourceWorkType.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelOutSourceWorkType);
            }
            if (list.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<OutSourceWorkTypeEL> SearchOutSourceWorkTypeByOutSourceWorkTypeCode(Int64 IdProject, Int64 OutSourceWorkTypeCode, SqlConnection objConn)
        {
            List<OutSourceWorkTypeEL> list = new List<OutSourceWorkTypeEL>();
            SqlCommand cmdOutSourceWorkType = new SqlCommand("[Setup].[Proc_SearchOutSourceWorkTypeByOutSourceWorkTypeCode]", objConn);

            cmdOutSourceWorkType.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdOutSourceWorkType.Parameters.Add("@OutSourceWorkTypeCode", SqlDbType.BigInt).Value = OutSourceWorkTypeCode;

            cmdOutSourceWorkType.CommandType = CommandType.StoredProcedure;
            objReader = cmdOutSourceWorkType.ExecuteReader();
            while (objReader.Read())
            {
                OutSourceWorkTypeEL oelOutSourceWorkType = new OutSourceWorkTypeEL();
                oelOutSourceWorkType.IdOutSourceWorkType = Validation.GetSafeLong(objReader["OutSourceWorkType_Id"]);
                oelOutSourceWorkType.OutSourceWorkTypeCode = Validation.GetSafeString(objReader["OutSourceWorkType_Code"]);
                oelOutSourceWorkType.OutSourceWorkTypeName = Validation.GetSafeString(objReader["OutSourceWorkType_Name"]);
                oelOutSourceWorkType.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelOutSourceWorkType.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelOutSourceWorkType.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelOutSourceWorkType);
            }
            return list;
        }
        public List<OutSourceWorkTypeEL> SearchOutSourceWorkTypeByOutSourceWorkTypeByName(Int64 IdProject, string OutSourceWorkTypeName, SqlConnection objConn)
        {
            List<OutSourceWorkTypeEL> list = new List<OutSourceWorkTypeEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_SearchOutSourceWorkTypeByOutSourceWorkName]", objConn);

            cmdCategory.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdCategory.Parameters.Add("@OutSourceWorkTypeName", SqlDbType.VarChar).Value = OutSourceWorkTypeName;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            objReader = cmdCategory.ExecuteReader();
            while (objReader.Read())
            {
                OutSourceWorkTypeEL oelOutSourceWorkType = new OutSourceWorkTypeEL();
                oelOutSourceWorkType.IdOutSourceWorkType = Validation.GetSafeLong(objReader["OutSourceWorkType_Id"]);
                oelOutSourceWorkType.OutSourceWorkTypeCode = Validation.GetSafeString(objReader["OutSourceWorkType_Code"]);
                oelOutSourceWorkType.OutSourceWorkTypeName = Validation.GetSafeString(objReader["OutSourceWorkType_Name"]);
                oelOutSourceWorkType.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelOutSourceWorkType.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelOutSourceWorkType.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);

                list.Add(oelOutSourceWorkType);
            }
            return list;
        }
    }
}
