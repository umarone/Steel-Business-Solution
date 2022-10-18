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
    public class StockAdjustmentsDAL
    {
        public bool CreateStockAdjustmentTypes(StockAdjustmentsEL oelStockAdjustment, SqlConnection objConn)
        {
            lock (this)
            {
                EntityoperationInfo infoResult = new EntityoperationInfo();
                try
                {
                    SqlCommand cmdAdjustment = new SqlCommand("[Setup].[Proc_CreateStockAdjustmentTypes]", objConn);

                    cmdAdjustment.CommandType = CommandType.StoredProcedure;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@IdStockAdjustmentType", DbType.Int64)).Value = oelStockAdjustment.IdStockAdjustmentType;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@StockAdjustmentName", DbType.Int64)).Value = oelStockAdjustment.StockAdjustmentName;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@StockAdjustmentType", DbType.Int64)).Value = oelStockAdjustment.StockAdjustmentType;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@IsMeasureAble", DbType.Int64)).Value = oelStockAdjustment.IsMeasureAble;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelStockAdjustment.IsActive;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.Int64)).Value = oelStockAdjustment.CreatedDateTime;
                    cmdAdjustment.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    objConn.Dispose();
                    return false;
                }
                finally
                {
                    objConn.Dispose();
                }
                return true;
            }

        }
        public bool UpdateStockAdjustmentTypes(StockAdjustmentsEL oelStockAdjustment, SqlConnection objConn)
        {
            lock (this)
            {
                EntityoperationInfo infoResult = new EntityoperationInfo();
                try
                {
                    SqlCommand cmdAdjustment = new SqlCommand("[Setup].[Proc_UpdateStockAdjustmentTypes]", objConn);

                    cmdAdjustment.CommandType = CommandType.StoredProcedure;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@IdStockAdjustmentType", DbType.Int64)).Value = oelStockAdjustment.IdStockAdjustmentType;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@StockAdjustmentName", DbType.Int64)).Value = oelStockAdjustment.StockAdjustmentName;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@StockAdjustmentType", DbType.Int64)).Value = oelStockAdjustment.StockAdjustmentType;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@IsMeasureAble", DbType.Int64)).Value = oelStockAdjustment.IsMeasureAble;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelStockAdjustment.IsActive;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.Int64)).Value = oelStockAdjustment.CreatedDateTime;
                    cmdAdjustment.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    objConn.Dispose();
                    return false;
                }
                finally
                {
                    objConn.Dispose();
                }
                return true;
            }

        }
        public bool DeleteStockAdjustmentTypes(Int64? Id, SqlConnection objConn)
        {
            lock (this)
            {
                EntityoperationInfo infoResult = new EntityoperationInfo();
                try
                {
                    SqlCommand cmdAdjustment = new SqlCommand("[Setup].[Proc_DeleteStockAdjustmentTypes]", objConn);

                    cmdAdjustment.CommandType = CommandType.StoredProcedure;
                    cmdAdjustment.Parameters.Add(new SqlParameter("@IdStockAdjustmentType", DbType.Int64)).Value = Id.Value;
                    cmdAdjustment.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    objConn.Dispose();
                    return false;
                }
                finally
                {
                    objConn.Dispose();
                }
                return true;
            }

        }
        public List<StockAdjustmentsEL> GetStockAdjustmentsByType(Int64 AdjustmentType, SqlConnection objConn)
        {
            List<StockAdjustmentsEL> list = new List<StockAdjustmentsEL>();
            SqlCommand cmdAdjustment = new SqlCommand("[Setup].[Proc_GetStockAdjustmentsByType]", objConn);

            cmdAdjustment.Parameters.Add("@StockAdjustmentType", SqlDbType.BigInt).Value = AdjustmentType;

            cmdAdjustment.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdAdjustment.ExecuteReader();
            while (oReader.Read())
            {
                StockAdjustmentsEL oelStockAdjustment = new StockAdjustmentsEL();
                oelStockAdjustment.IdStockAdjustmentType = Validation.GetSafeLong(oReader["StockAdjustmentType_Id"]);
                oelStockAdjustment.StockAdjustmentName = Validation.GetSafeString(oReader["StockAdjustmentName"]);
                oelStockAdjustment.StockAdjustmentType = Validation.GetSafeInteger(oReader["StockAdjustmentType"]);
                oelStockAdjustment.IsMeasureAble = Validation.GetSafeBooleanNullable(oReader["IsMeasureAble"]);
                oelStockAdjustment.CreatedDateTime = Validation.GetSafeDateTime(oReader["Created_Datetime"]);

                list.Add(oelStockAdjustment);
            }
            return list;
        }
    }
}
