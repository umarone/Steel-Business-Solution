using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Accounts.EL;
using Accounts.Common;

namespace Accounts.DAL
{
    public class TradingDAL
    {
        public TradingDAL()
        { 
            
        }
        IDataReader ObjReader;
        public EntityoperationInfo InsertTradingCo(TradingEL oelTrading, SqlConnection objConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdTradingCo = new SqlCommand("[Setup].[Proc_CreateTradingCo]", objConn))
            {
                cmdTradingCo.CommandType = CommandType.StoredProcedure;
                cmdTradingCo.Parameters.Add(new SqlParameter("@IdTrading", DbType.Int64)).Value = oelTrading.IdTrading;
                cmdTradingCo.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelTrading.IdProject;
                cmdTradingCo.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelTrading.UserId;
                cmdTradingCo.Parameters.Add(new SqlParameter("@TradingCode", DbType.Int64)).Value = oelTrading.TradingCode;
                cmdTradingCo.Parameters.Add(new SqlParameter("@TradingName", DbType.String)).Value = oelTrading.TradingName;
                cmdTradingCo.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelTrading.TradingDiscription;
                cmdTradingCo.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelTrading.IsActive;
                cmdTradingCo.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelTrading.CreatedDateTime;

                if (cmdTradingCo.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo UpdateTradingCo(TradingEL oelTrading, SqlConnection objConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdTradingCo = new SqlCommand("[Setup].[Proc_UpdateTradingCo]", objConn))
            {
                cmdTradingCo.CommandType = CommandType.StoredProcedure;
                cmdTradingCo.Parameters.Add(new SqlParameter("@IdTrading", DbType.Int64)).Value = oelTrading.IdTrading;
                cmdTradingCo.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelTrading.IdProject;
                cmdTradingCo.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelTrading.UserId;
                cmdTradingCo.Parameters.Add(new SqlParameter("@TradingCode", DbType.Int64)).Value = oelTrading.TradingCode;
                cmdTradingCo.Parameters.Add(new SqlParameter("@TradingName", DbType.String)).Value = oelTrading.TradingName;
                cmdTradingCo.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelTrading.TradingDiscription;
                cmdTradingCo.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelTrading.IsActive;
                cmdTradingCo.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelTrading.CreatedDateTime;

                if (cmdTradingCo.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo DeleteTradingCo(Int64 IdTrading, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_DeleteTradingCo]", objConn))
            {
                cmdCategory.CommandType = CommandType.StoredProcedure;
                cmdCategory.Parameters.Add(new SqlParameter("@IdTradingCo", DbType.Int64)).Value = IdTrading;

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
        public Int64 GetMaxTradingCode(Int64 IdCompany, SqlConnection objConn)
        {
            SqlCommand cmdAccount = new SqlCommand("[Setup].[Proc_GetMaxTradingCode]", objConn);
            cmdAccount.CommandType = CommandType.StoredProcedure;
            cmdAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Guid)).Value = IdCompany;
            return Validation.GetSafeLong(cmdAccount.ExecuteScalar());

        }
        public List<TradingEL> GetAllTradingCo(Int64 IdProject, SqlConnection objConn)
        {
            List<TradingEL> list = new List<TradingEL>();
            SqlCommand cmdTradingCo = new SqlCommand("[Setup].[Proc_GetAllTradingCo]", objConn);
            cmdTradingCo.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdTradingCo.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdTradingCo.ExecuteReader();
            while (ObjReader.Read())
            {
                TradingEL objTrading = new TradingEL();

                objTrading.IdTrading = Validation.GetSafeLong(ObjReader["Trading_Id"]);
                objTrading.IdProject = Validation.GetSafeLong(ObjReader["Project_Id"]);
                objTrading.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                objTrading.TradingCode = Validation.GetSafeLong(ObjReader["Trading_Code"]);
                objTrading.TradingName = Validation.GetSafeString(ObjReader["Trading_Name"]);
                objTrading.TradingDiscription = Validation.GetSafeString(ObjReader["Discription"]);
                objTrading.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                objTrading.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);

                list.Add(objTrading);
            }
            return list;
        }
        public List<TradingEL> GetTradingCoById(Int64? Id,SqlConnection objConn)
        {
            List<TradingEL> list = new List<TradingEL>();
            SqlCommand cmdTradingCo = new SqlCommand("[Setup].[Proc_GetTradingCoById]", objConn);
            cmdTradingCo.Parameters.Add(new SqlParameter("@IdTradingCo", DbType.Int64)).Value = Id.Value;
            cmdTradingCo.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdTradingCo.ExecuteReader();
            while (ObjReader.Read())
            {
                TradingEL objTrading = new TradingEL();

                objTrading.IdTrading = Validation.GetSafeLong(ObjReader["Trading_Id"]);
                objTrading.IdProject = Validation.GetSafeLong(ObjReader["Project_Id"]);
                objTrading.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                objTrading.TradingCode = Validation.GetSafeLong(ObjReader["Trading_Code"]);
                objTrading.TradingName = Validation.GetSafeString(ObjReader["Trading_Name"]);
                objTrading.TradingDiscription = Validation.GetSafeString(ObjReader["Discription"]);
                objTrading.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                objTrading.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);

                list.Add(objTrading);
            }
            return list;
        }
        public bool CheckTradingNameDuplication(string TradingName, SqlConnection objConn)
        {
            List<TradingEL> list = new List<TradingEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_CheckTradingNameDuplication]", objConn);

            cmdCategory.Parameters.Add("@TradingName", SqlDbType.VarChar).Value = TradingName;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdCategory.ExecuteReader();
            while (ObjReader.Read())
            {
                TradingEL objTrading = new TradingEL();

                objTrading.IdTrading = Validation.GetSafeLong(ObjReader["Trading_Id"]);
                objTrading.IdProject = Validation.GetSafeLong(ObjReader["Project_Id"]);
                objTrading.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                objTrading.TradingCode = Validation.GetSafeLong(ObjReader["Trading_Code"]);
                objTrading.TradingName = Validation.GetSafeString(ObjReader["Trading_Name"]);
                objTrading.TradingDiscription = Validation.GetSafeString(ObjReader["Discription"]);
                objTrading.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                objTrading.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);

                list.Add(objTrading);
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
        public bool CheckTradingCodeDuplication(Int64 TradingCode, SqlConnection objConn)
        {
            List<TradingEL> list = new List<TradingEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_CheckTradingCodeDuplication]", objConn);

            cmdCategory.Parameters.Add("@TradingCode", SqlDbType.BigInt).Value = TradingCode;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdCategory.ExecuteReader();
            while (ObjReader.Read())
            {
                TradingEL objTrading = new TradingEL();

                objTrading.IdTrading = Validation.GetSafeLong(ObjReader["Trading_Id"]);
                objTrading.IdProject = Validation.GetSafeLong(ObjReader["Project_Id"]);
                objTrading.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                objTrading.TradingCode = Validation.GetSafeLong(ObjReader["Trading_Code"]);
                objTrading.TradingName = Validation.GetSafeString(ObjReader["Trading_Name"]);
                objTrading.TradingDiscription = Validation.GetSafeString(ObjReader["Discription"]);
                objTrading.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                objTrading.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);

                list.Add(objTrading);
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
        public List<TradingEL> SearchTradingByTradingCode(Int64 IdProject, Int64 TradingCode, SqlConnection objConn)
        {
            List<TradingEL> list = new List<TradingEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_SearchTradingByTradingCode]", objConn);

            cmdCategory.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdCategory.Parameters.Add("@TradingCode", SqlDbType.BigInt).Value = TradingCode;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdCategory.ExecuteReader();
            while (ObjReader.Read())
            {
                TradingEL objTrading = new TradingEL();

                objTrading.IdTrading = Validation.GetSafeLong(ObjReader["Trading_Id"]);
                objTrading.IdProject = Validation.GetSafeLong(ObjReader["Project_Id"]);
                objTrading.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                objTrading.TradingCode = Validation.GetSafeLong(ObjReader["Trading_Code"]);
                objTrading.TradingName = Validation.GetSafeString(ObjReader["Trading_Name"]);
                objTrading.TradingDiscription = Validation.GetSafeString(ObjReader["Discription"]);
                objTrading.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                objTrading.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);

                list.Add(objTrading);
            }
            return list;
        }
        public List<TradingEL> SearchTradingByTradingName(Int64 IdProject, string TradingName, SqlConnection objConn)
        {
            List<TradingEL> list = new List<TradingEL>();
            SqlCommand cmdCategory = new SqlCommand("[Setup].[Proc_SearchTradingByTradingName]", objConn);

            cmdCategory.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdCategory.Parameters.Add("@TradingName", SqlDbType.VarChar).Value = TradingName;

            cmdCategory.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdCategory.ExecuteReader();
            while (ObjReader.Read())
            {
                TradingEL objTrading = new TradingEL();

                objTrading.IdTrading = Validation.GetSafeLong(ObjReader["Trading_Id"]);
                objTrading.IdProject = Validation.GetSafeLong(ObjReader["Project_Id"]);
                objTrading.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                objTrading.TradingCode = Validation.GetSafeLong(ObjReader["Trading_Code"]);
                objTrading.TradingName = Validation.GetSafeString(ObjReader["Trading_Name"]);
                objTrading.TradingDiscription = Validation.GetSafeString(ObjReader["Discription"]);
                objTrading.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                objTrading.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);

                list.Add(objTrading);
            }
            return list;
        }
    }
}
