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
    public class UOMDAL
    {
        IDataReader objReader;
        public UOMDAL()
        { 
            
        }
        public EntityoperationInfo CreateUOM(UOMEL oelUOM, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdUOM = new SqlCommand("[Setup].[Proc_CreateUOM]", objConn))
            {
                cmdUOM.CommandType = CommandType.StoredProcedure;
                cmdUOM.Parameters.Add(new SqlParameter("@IdUOM", DbType.Int64)).Value = oelUOM.IdUOM;
                cmdUOM.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUOM.UserId;
                cmdUOM.Parameters.Add(new SqlParameter("@UOMName", DbType.String)).Value = oelUOM.UOMName;
                cmdUOM.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelUOM.IsActive;
                cmdUOM.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.Int64)).Value = oelUOM.CreatedDateTime;

                if (cmdUOM.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo UpdateUOM(UOMEL oelUOM, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdUOM = new SqlCommand("[Setup].[Proc_UpdateUOM]", objConn))
            {
                cmdUOM.CommandType = CommandType.StoredProcedure;
                cmdUOM.Parameters.Add(new SqlParameter("@IdUOM", DbType.Int64)).Value = oelUOM.IdUOM;
                cmdUOM.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUOM.UserId;
                cmdUOM.Parameters.Add(new SqlParameter("@UOMName", DbType.String)).Value = oelUOM.UOMName;
                cmdUOM.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelUOM.IsActive;
                cmdUOM.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.Int64)).Value = oelUOM.CreatedDateTime;

                if (cmdUOM.ExecuteNonQuery() > -1)
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
        public List<UOMEL> GetAllUOMS(SqlConnection objConn)
        {
            List<UOMEL> list = new List<UOMEL>();
            SqlCommand cmdUOM = new SqlCommand("[Setup].[Proc_GetAllUOMS]", objConn);
            cmdUOM.CommandType = CommandType.StoredProcedure;
            objReader = cmdUOM.ExecuteReader();
            while (objReader.Read())
            {
                UOMEL oelUom = new UOMEL();
                oelUom.IdUOM = Validation.GetSafeLong(objReader["Uom_Id"]);
                oelUom.UOMName = Validation.GetSafeString(objReader["Uom_Name"]);
                oelUom.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelUom.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelUom.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelUom);
            }
            return list;
        }
        public List<UOMEL> GetAllActiveUOMS(SqlConnection objConn)
        {
            List<UOMEL> list = new List<UOMEL>();
            SqlCommand cmdUOM = new SqlCommand("[Setup].[Proc_GetAllActiveUOMS]", objConn);
            cmdUOM.CommandType = CommandType.StoredProcedure;
            objReader = cmdUOM.ExecuteReader();
            while (objReader.Read())
            {
                UOMEL oelUom = new UOMEL();
                oelUom.IdUOM = Validation.GetSafeLong(objReader["Uom_Id"]);
                oelUom.UOMName = Validation.GetSafeString(objReader["Uom_Name"]);
                oelUom.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelUom.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelUom.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);
                list.Add(oelUom);
            }
            return list;
        }

    }
}
