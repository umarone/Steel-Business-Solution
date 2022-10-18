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
    public class CompanyDAL
    {
        IDataReader objReader;
        public CompanyDAL()
        { 
        
        }
        public EntityoperationInfo InsertCompany(CompanyEL oelCompany, SqlConnection objConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdCompany = new SqlCommand("[Setup].[Proc_CreateCompany]", objConn))
            {
                cmdCompany.CommandType = CommandType.StoredProcedure;

                cmdCompany.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelCompany.IdCompany;
                cmdCompany.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelCompany.UserId;
                cmdCompany.Parameters.Add(new SqlParameter("@CompanyName", DbType.String)).Value = oelCompany.CompanyName;
                cmdCompany.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelCompany.Discription;
                cmdCompany.Parameters.Add(new SqlParameter("@IsActive", DbType.String)).Value = oelCompany.IsActive;    
                cmdCompany.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelCompany.CreatedDateTime;

                if (cmdCompany.ExecuteNonQuery() > -1)
                {
                    InfoResult.IsSuccess = true;
                }
                else
                {
                    InfoResult.IsSuccess = false;
                }

            }
            return InfoResult;
        }
        public EntityoperationInfo UpdateCompany(CompanyEL oelCompany, SqlConnection objConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdCompany = new SqlCommand("[Setup].[Proc_UpdateCompany]", objConn))
            {
                cmdCompany.CommandType = CommandType.StoredProcedure;

                cmdCompany.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelCompany.IdCompany;
                cmdCompany.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelCompany.UserId;
                cmdCompany.Parameters.Add(new SqlParameter("@CompanyName", DbType.String)).Value = oelCompany.CompanyName;
                cmdCompany.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelCompany.Discription;
                cmdCompany.Parameters.Add(new SqlParameter("@IsActive", DbType.String)).Value = oelCompany.IsActive;    
                cmdCompany.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelCompany.CreatedDateTime;

                if (cmdCompany.ExecuteNonQuery() > -1)
                {
                    InfoResult.IsSuccess = true;
                }
                else
                {
                    InfoResult.IsSuccess = false;
                }

            }
            return InfoResult;
        }
        public EntityoperationInfo DeleteCompany(Int64? IdCompany, SqlConnection objConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdCompany = new SqlCommand("[Setup].[Proc_DeleteCompany]", objConn))
            {
                cmdCompany.CommandType = CommandType.StoredProcedure;
                cmdCompany.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany.Value;                
                
                if (cmdCompany.ExecuteNonQuery() > -1)
                {
                    InfoResult.IsSuccess = true;
                }
                else
                {
                    InfoResult.IsSuccess = false;
                }

            }
            return InfoResult;
        }
        public bool CheckCompanyNameDuplication(string CompanyName, SqlConnection objConn)
        {
            List<CompanyEL> list = new List<CompanyEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_CheckCompanyNameDuplication]", objConn);

            cmdCategory.Parameters.Add("@CompanyName", SqlDbType.VarChar).Value = CompanyName;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            objReader = cmdCategory.ExecuteReader();
            while (objReader.Read())
            {
                CompanyEL oelCompany = new CompanyEL();

                oelCompany.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                oelCompany.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                oelCompany.Discription = Validation.GetSafeString(objReader["Discription"]);
                oelCompany.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);

                list.Add(oelCompany);
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
        public List<CompanyEL> GetAllCompanies(SqlConnection objConn)
        {
            List<CompanyEL> list = new List<CompanyEL>();
            SqlCommand cmdParents = new SqlCommand("[Setup].[Proc_getAllCompanies]", objConn);
            cmdParents.CommandType = CommandType.StoredProcedure;
            objReader = cmdParents.ExecuteReader();
            while (objReader.Read())
            {
                CompanyEL oelCompany = new CompanyEL();

                oelCompany.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                oelCompany.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCompany.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                oelCompany.UserName = Validation.GetSafeString(objReader["UserName"]);
                oelCompany.Discription = Validation.GetSafeString(objReader["Discription"]);
                oelCompany.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                oelCompany.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                list.Add(oelCompany);
            }
            return list;
        }
        public List<CompanyEL> GetCompanyById(Int64? Id, SqlConnection objConn)
        {
            List<CompanyEL> list = new List<CompanyEL>();
            SqlCommand cmdCompany = new SqlCommand("[Setup].[Proc_GetCompanyById]", objConn);
            cmdCompany.CommandType = CommandType.StoredProcedure;
            
            cmdCompany.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = Id.Value;

            objReader = cmdCompany.ExecuteReader();
            while (objReader.Read())
            {
                CompanyEL oelCompany = new CompanyEL();

                oelCompany.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                oelCompany.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelCompany.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                oelCompany.UserName = Validation.GetSafeString(objReader["UserName"]);
                oelCompany.Discription = Validation.GetSafeString(objReader["Discription"]);
                oelCompany.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                oelCompany.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);

                list.Add(oelCompany);
            }
            return list;
        }
    }
}
