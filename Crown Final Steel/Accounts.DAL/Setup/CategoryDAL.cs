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
    public class CategoryDAL
    {
        IDataReader objReader;
        public EntityoperationInfo CreateCategory(CategoryEL oelCategory, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_CreateCategory]", objConn))
            {
                cmdCategory.CommandType = CommandType.StoredProcedure;
                cmdCategory.Parameters.Add(new SqlParameter("@IdCategory", DbType.Int64)).Value = oelCategory.IdCategory;
                cmdCategory.Parameters.Add(new SqlParameter("@CategoryCode", DbType.Int64)).Value = oelCategory.CategoryCode;
                cmdCategory.Parameters.Add(new SqlParameter("@CategoryName", DbType.String)).Value = oelCategory.CategoryName;
                cmdCategory.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelCategory.IdProject;                
                cmdCategory.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelCategory.UserId;
                cmdCategory.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelCategory.IsActive;
                cmdCategory.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelCategory.CreatedDateTime;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdCategory.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo UpdateCategory(CategoryEL oelCategory, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_UpdateCategory]", objConn))
            {
                cmdCategory.CommandType = CommandType.StoredProcedure;
                cmdCategory.Parameters.Add(new SqlParameter("@IdCategory", DbType.Int64)).Value = oelCategory.IdCategory;
                cmdCategory.Parameters.Add(new SqlParameter("@CategoryCode", DbType.Int64)).Value = oelCategory.CategoryCode;
                cmdCategory.Parameters.Add(new SqlParameter("@CategoryName", DbType.String)).Value = oelCategory.CategoryName;
                cmdCategory.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelCategory.IdProject;
                cmdCategory.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelCategory.UserId;
                cmdCategory.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelCategory.IsActive;
                cmdCategory.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelCategory.CreatedDateTime;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdCategory.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo DeleteCategory(Int64 IdCategory, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_DeleteCategory]", objConn))
            {
                cmdCategory.CommandType = CommandType.StoredProcedure;
                cmdCategory.Parameters.Add(new SqlParameter("@IdCategory", DbType.Int64)).Value = IdCategory;

                //if (cmdItems.ExecuteNonQuery() > -1 && cmdAccounts.ExecuteNonQuery() > -1)
                if (cmdCategory.ExecuteNonQuery() > -1)
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
        public Int64 GetMaxCategoryCode(Int64 IdCompany, SqlConnection objConn)
        {
            SqlCommand cmdAccount = new SqlCommand("[Setup].[Proc_GetMaxCategoryCode]", objConn);
            cmdAccount.CommandType = CommandType.StoredProcedure;
            cmdAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            return Validation.GetSafeLong(cmdAccount.ExecuteScalar());

        }
        public List<CategoryEL> GetCategoryById(Int64 IdCategory, SqlConnection objConn)
        {
            List<CategoryEL> list = new List<CategoryEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_GetCategoryById]", objConn);

            cmdCategory.Parameters.Add("@IdCategory", SqlDbType.BigInt).Value = IdCategory;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            objReader = cmdCategory.ExecuteReader();
            while (objReader.Read())
            {
                CategoryEL oelCategory = new CategoryEL();
                oelCategory.IdCategory = Validation.GetSafeLong(objReader["Category_Id"]);
                oelCategory.CategoryCode = Validation.GetSafeString(objReader["Category_Code"]);
                oelCategory.CategoryName = Validation.GetSafeString(objReader["Category_Name"]);
                oelCategory.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCategory.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelCategory.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelCategory);
            }
            return list;
        }
        public List<CategoryEL> GetAllCategories(Int64 IdProject, SqlConnection objConn)
        {
            List<CategoryEL> list = new List<CategoryEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_GetAllCategories]", objConn);
            cmdCategory.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdCategory.CommandType = CommandType.StoredProcedure;
            objReader = cmdCategory.ExecuteReader();
            while (objReader.Read())
            {
                CategoryEL oelCategory = new CategoryEL();
                oelCategory.IdCategory = Validation.GetSafeLong(objReader["Category_Id"]);
                oelCategory.CategoryCode = Validation.GetSafeString(objReader["Category_Code"]);
                oelCategory.CategoryName = Validation.GetSafeString(objReader["Category_Name"]);
                oelCategory.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCategory.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelCategory.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelCategory);
            }
            return list;
        }
        public bool CheckCategoryNameDuplication(string CategoryName, SqlConnection objConn)
        {
            List<CategoryEL> list = new List<CategoryEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_CheckCategoryNameDuplication]", objConn);

            cmdCategory.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = CategoryName;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            objReader = cmdCategory.ExecuteReader();
            while (objReader.Read())
            {
                CategoryEL oelCategory = new CategoryEL();
                oelCategory.IdCategory = Validation.GetSafeLong(objReader["Category_Id"]);
                oelCategory.CategoryCode = Validation.GetSafeString(objReader["Category_Code"]);
                oelCategory.CategoryName = Validation.GetSafeString(objReader["Category_Name"]);
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
        public bool CheckCategoryCodeDuplication(Int64 CategoryCode, SqlConnection objConn)
        {
            List<CategoryEL> list = new List<CategoryEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_CheckCategoryCodeDuplication]", objConn);

            cmdCategory.Parameters.Add("@CategoryCode", SqlDbType.BigInt).Value = CategoryCode;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            objReader = cmdCategory.ExecuteReader();
            while (objReader.Read())
            {
                CategoryEL oelCategory = new CategoryEL();
                oelCategory.IdCategory = Validation.GetSafeLong(objReader["Category_Id"]);
                oelCategory.CategoryCode = Validation.GetSafeString(objReader["Category_Code"]);
                oelCategory.CategoryName = Validation.GetSafeString(objReader["Category_Name"]);
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
        public List<CategoryEL> SearchCategoryByCategoryCode(Int64 IdProject, Int64 CategoryCode, SqlConnection objConn)
        {
            List<CategoryEL> list = new List<CategoryEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_SearchCategoryByCategoryCode]", objConn);

            cmdCategory.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdCategory.Parameters.Add("@CategoryCode", SqlDbType.BigInt).Value = CategoryCode;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            objReader = cmdCategory.ExecuteReader();
            while (objReader.Read())
            {
                CategoryEL oelCategory = new CategoryEL();
                oelCategory.IdCategory = Validation.GetSafeLong(objReader["Category_Id"]);
                oelCategory.CategoryCode = Validation.GetSafeString(objReader["Category_Code"]);
                oelCategory.CategoryName = Validation.GetSafeString(objReader["Category_Name"]);
                oelCategory.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCategory.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelCategory.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelCategory);
            }
            return list;
        }
        public List<CategoryEL> SearchCategoryByCategoryByName(Int64 IdProject, string CategoryName, SqlConnection objConn)
        {
            List<CategoryEL> list = new List<CategoryEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_SearchCategoryByCategoryName]", objConn);

            cmdCategory.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdCategory.Parameters.Add("@CategoryName", SqlDbType.VarChar).Value = CategoryName;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            objReader = cmdCategory.ExecuteReader();
            while (objReader.Read())
            {
                CategoryEL oelCategory = new CategoryEL();
                oelCategory.IdCategory = Validation.GetSafeLong(objReader["Category_Id"]);
                oelCategory.CategoryCode = Validation.GetSafeString(objReader["Category_Code"]);
                oelCategory.CategoryName = Validation.GetSafeString(objReader["Category_Name"]);
                oelCategory.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCategory.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelCategory.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);

                list.Add(oelCategory);
            }
            return list;
        }
    }
}
