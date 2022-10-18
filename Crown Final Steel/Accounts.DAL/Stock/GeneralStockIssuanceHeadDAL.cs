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
    public class GeneralStockIssuanceHeadDAL
    {
        #region Variables
        Int64? Identity;
        GeneralStockIssuanceDetailDAL dal;
        IDataReader objReader;
        #endregion
        public GeneralStockIssuanceHeadDAL()
        {
            dal = new GeneralStockIssuanceDetailDAL();
        }
        public Int64 GetMaxGeneralStoreStockNumber(Int64 IdProject, Int64 BookNo, Int32 StoreType, SqlConnection objConn)
        {
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetMaxGeneralStoreStockNumber]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@StoreType", SqlDbType.Int).Value = StoreType;
                return Validation.GetSafeLong(cmdVouchers.ExecuteScalar());
            }
        }
        public EntityoperationInfo CreateGeneralStockIssuance(VouchersEL oelVoucher, List<VoucherDetailEL> oelIssuanceDetail, SqlConnection objConn)
        {
            EntityoperationInfo info = new EntityoperationInfo();
            lock (this)
            {
                SqlTransaction objTran = objConn.BeginTransaction();
                try
                {
                    //// Insert Sale Voucher
                    SqlCommand cmdIssuanceHead = new SqlCommand("[Transactions].[Proc_CreateGeneralInventoryIssuanceHead]", objConn);

                    cmdIssuanceHead.CommandType = CommandType.StoredProcedure;
                    cmdIssuanceHead.Transaction = objTran;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelVoucher.BookNo;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@DemandNo", DbType.String)).Value = oelVoucher.DemandNo;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.VDiscription;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@StoreType", DbType.Int32)).Value = oelVoucher.StoreType;
                    cmdIssuanceHead.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    Identity = Validation.GetSafeLong(cmdIssuanceHead.ExecuteScalar());

                    //// Insert Detail Sales In Sale Record
                    dal.CreateGeneralInventoryIssuanceDetail(oelIssuanceDetail, Identity, objConn, objTran);

                    info.VoucherNo = GetIssuanceNumber(Identity.Value, oelVoucher.IdProject.Value, oelVoucher.BookNo, oelVoucher.StoreType, objConn, objTran);

                    objTran.Commit();
                    
                    info.IntID = Identity.Value;
                    info.IsSuccess = true;
                   
                    return info;
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
            }
        }
        public bool UpdateGeneralStockIssuance(VouchersEL oelVoucher, List<VoucherDetailEL> oelIssuanceDetail, SqlConnection objConn)
        {
            lock (this)
            {
                SqlTransaction objTran = objConn.BeginTransaction();
                try
                {
                    SqlCommand cmdIssuance = new SqlCommand("[Transactions].[Proc_UpdateGeneralInventoryIssuanceHead]", objConn);
                    cmdIssuance.CommandType = CommandType.StoredProcedure;
                    cmdIssuance.Transaction = objTran;

                    cmdIssuance.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                    cmdIssuance.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                    cmdIssuance.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelVoucher.IdUser;
                    cmdIssuance.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelVoucher.BookNo;
                    cmdIssuance.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;

                    cmdIssuance.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.VDate;
                    cmdIssuance.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelVoucher.AccountNo;
                    cmdIssuance.Parameters.Add(new SqlParameter("@VDiscription", DbType.String)).Value = oelVoucher.VDiscription;
                    cmdIssuance.Parameters.Add(new SqlParameter("@DemandNo", DbType.String)).Value = oelVoucher.DemandNo;
                    cmdIssuance.Parameters.Add(new SqlParameter("@OutWardGatePassNo", DbType.String)).Value = oelVoucher.OutWardGatePassNo;
                    cmdIssuance.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdIssuance.Parameters.Add(new SqlParameter("@StoreType", DbType.Int32)).Value = oelVoucher.StoreType;
                    cmdIssuance.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdIssuance.ExecuteNonQuery();


                    dal.UpdateGeneralInventoryIssuanceDetail(oelIssuanceDetail, objConn, objTran);

             

                    objTran.Commit();
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
                finally
                {

                }
                return true;
            }
        }
        public Int64 GetIssuanceNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, Int64 StoreType, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdSales = new SqlCommand("[Transactions].[Proc_GetIssuanceNumberByVoucher]", objConn, objTran);
            cmdSales.CommandType = CommandType.StoredProcedure;
            cmdSales.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
            cmdSales.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdSales.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdSales.Parameters.Add("@StoreType", SqlDbType.BigInt).Value = StoreType;
            return Validation.GetSafeLong(cmdSales.ExecuteScalar());
        }
        public List<VoucherDetailEL> GetGeneralStockIssuance(Int64 IdIssuance, Int64 IdProject, Int64 BookNo, Int32 StoreType, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdIssuance = new SqlCommand("[Transactions].[Proc_GetGeneralStockIssuance]", objConn))
            {
                cmdIssuance.CommandType = CommandType.StoredProcedure;
                cmdIssuance.CommandTimeout = 0;
                cmdIssuance.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = IdIssuance;
                cmdIssuance.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
                cmdIssuance.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = BookNo;
                cmdIssuance.Parameters.Add(new SqlParameter("@StoreType", DbType.Int32)).Value = StoreType;
                objReader = cmdIssuance.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelIssuanceDetail = new VoucherDetailEL();

                    // Head Entries
                    oelIssuanceDetail.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelIssuanceDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelIssuanceDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelIssuanceDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelIssuanceDetail.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelIssuanceDetail.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    // Accounts Entries
                    oelIssuanceDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelIssuanceDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    
                    /// Detailed Entries

                    oelIssuanceDetail.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelIssuanceDetail.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelIssuanceDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelIssuanceDetail.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    oelIssuanceDetail.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelIssuanceDetail.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                    oelIssuanceDetail.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    oelIssuanceDetail.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    oelIssuanceDetail.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                    oelIssuanceDetail.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                    oelIssuanceDetail.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelIssuanceDetail.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                    oelIssuanceDetail.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                    oelIssuanceDetail.ColorCode = Validation.GetSafeInteger(objReader["ColorCode"]);
                    oelIssuanceDetail.CurrentStock = Validation.GetSafeDecimal(objReader["CurrentStock"]);
                    oelIssuanceDetail.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelIssuanceDetail.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    oelIssuanceDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);

                    list.Add(oelIssuanceDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetGeneralStockIssuanceWithIssuanceNumber(Int64 IssuanceNo, Int64 IdProject, Int64 BookNo, Int32 StoreType, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdIssuance = new SqlCommand("[Transactions].[Proc_GetGeneralIssuanceWithIssuanceNumber]", objConn))
            {
                cmdIssuance.CommandType = CommandType.StoredProcedure;
                cmdIssuance.CommandTimeout = 0;
                cmdIssuance.Parameters.Add(new SqlParameter("@IssuanceNo ", DbType.Int64)).Value = IssuanceNo;
                cmdIssuance.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
                cmdIssuance.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = BookNo;
                cmdIssuance.Parameters.Add(new SqlParameter("@StoreType", DbType.Int32)).Value = StoreType;
                objReader = cmdIssuance.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL oelIssuanceDetail = new VoucherDetailEL();

                    // Head Entries
                    oelIssuanceDetail.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelIssuanceDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelIssuanceDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelIssuanceDetail.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelIssuanceDetail.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelIssuanceDetail.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    // Accounts Entries
                    oelIssuanceDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelIssuanceDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);

                    /// Detailed Entries

                    oelIssuanceDetail.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelIssuanceDetail.IdItem = Validation.GetSafeLong(objReader["Item_Id"]);
                    oelIssuanceDetail.ItemName = Validation.GetSafeString(objReader["ItemName"]);
                    oelIssuanceDetail.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                    oelIssuanceDetail.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelIssuanceDetail.TotalCartons = Validation.GetSafeLong(objReader["TotalCartons"]);
                    oelIssuanceDetail.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                    oelIssuanceDetail.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                    oelIssuanceDetail.EngineNo = Validation.GetSafeString(objReader["EngineNo"]);
                    oelIssuanceDetail.ChasisNo = Validation.GetSafeString(objReader["ChasisNo"]);
                    oelIssuanceDetail.VehicleNo = Validation.GetSafeString(objReader["VehicleNo"]);
                    oelIssuanceDetail.FirstIMEI = Validation.GetSafeString(objReader["FirstIMEI"]);
                    oelIssuanceDetail.SecondIMEI = Validation.GetSafeString(objReader["SecondIMEI"]);
                    oelIssuanceDetail.ColorCode = Validation.GetSafeInteger(objReader["ColorCode"]);
                    oelIssuanceDetail.CurrentStock = Validation.GetSafeDecimal(objReader["CurrentStock"]);
                    oelIssuanceDetail.Units = Validation.GetSafeDecimal(objReader["Units"]);
                    oelIssuanceDetail.UnitPrice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                    oelIssuanceDetail.Amount = Validation.GetSafeDecimal(objReader["Amount"]);

                    list.Add(oelIssuanceDetail);
                }
            }
            return list;
        }
    }
}
