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
    public class ChequesDAL
    {
        #region Variables
        IDataReader objReader;
        Int64? Identity;
        #endregion
        public ChequesDAL()
        {
        
        }
        public Int64 GetMaxPostDatedChequeNo(Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            using (SqlCommand cmdCheques = new SqlCommand("[Transactions].[Proc_GetMaxChequeAutoNumber]", objConn))
            {
                cmdCheques.CommandType = CommandType.StoredProcedure;
                cmdCheques.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdCheques.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                return Validation.GetSafeLong(cmdCheques.ExecuteScalar());
            }
        }
        public EntityoperationInfo CreatePostDatedCheque(ChequesEL oelChque, SqlConnection objConn)
        {
            EntityoperationInfo info = new EntityoperationInfo();
            lock (this)
            {
                SqlTransaction objTran = objConn.BeginTransaction();
                try
                {
                    SqlCommand cmdCheque = new SqlCommand();

                    cmdCheque.CommandText = "[Transactions].[Proc_CreatePostDatedCheques]";
                    cmdCheque.Connection = objConn;
                    cmdCheque.CommandType = CommandType.StoredProcedure;
                    cmdCheque.Transaction = objTran;

                    cmdCheque.Parameters.Add(new SqlParameter("@IdCheque", DbType.Int64)).Value = oelChque.IdCheque;
                    cmdCheque.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelChque.IdUser;
                    cmdCheque.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelChque.IdProject;
                    cmdCheque.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelChque.BookNo;
                    cmdCheque.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelChque.TerminalNumber;
                    cmdCheque.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelChque.AccountNo;
                    cmdCheque.Parameters.Add(new SqlParameter("@ChequeNo", DbType.String)).Value = oelChque.ChequeNo;
                    cmdCheque.Parameters.Add(new SqlParameter("@BankName", DbType.String)).Value = oelChque.BankName;
                    cmdCheque.Parameters.Add(new SqlParameter("@ChequeType", DbType.Int32)).Value = oelChque.ChequeType;
                    cmdCheque.Parameters.Add(new SqlParameter("@ChequeStatus", DbType.Int32)).Value = oelChque.ChequeStatus;
                    cmdCheque.Parameters.Add(new SqlParameter("@GivenTakenDate", DbType.DateTime)).Value = oelChque.ChequeGivenTakenDate;
                    cmdCheque.Parameters.Add(new SqlParameter("@WithDrawlDate", DbType.DateTime)).Value = oelChque.ChequeWithDrawlDate;
                    cmdCheque.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelChque.CreatedDateTime;
                    cmdCheque.Parameters.Add(new SqlParameter("@ChequeAmount", DbType.DateTime)).Value = oelChque.TotalAmount;
 
                    
                    Identity = Validation.GetSafeLong(cmdCheque.ExecuteScalar());
            

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
        public EntityoperationInfo UpdatePostDatedCheque(ChequesEL oelChque, SqlConnection objConn)
        {
            EntityoperationInfo info = new EntityoperationInfo();
            lock (this)
            {
               try
                {
                    SqlCommand cmdCheque = new SqlCommand();

                    cmdCheque.CommandText = "[Transactions].[Proc_UpdatePostDatedCheques]";
                    
                    cmdCheque.Connection = objConn;
                    cmdCheque.CommandType = CommandType.StoredProcedure;
    
                    cmdCheque.Parameters.Add(new SqlParameter("@IdCheque", DbType.Int64)).Value = oelChque.IdCheque;
                    cmdCheque.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelChque.IdUser;
                    cmdCheque.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelChque.IdProject;
                    cmdCheque.Parameters.Add(new SqlParameter("@BookNo", DbType.String)).Value = oelChque.BookNo;
                    cmdCheque.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelChque.TerminalNumber;
                    cmdCheque.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelChque.AccountNo;
                    cmdCheque.Parameters.Add(new SqlParameter("@ChequeNo", DbType.String)).Value = oelChque.ChequeNo;
                    cmdCheque.Parameters.Add(new SqlParameter("@BankName", DbType.String)).Value = oelChque.BankName;
                    cmdCheque.Parameters.Add(new SqlParameter("@ChequeType", DbType.Int32)).Value = oelChque.ChequeType;
                    cmdCheque.Parameters.Add(new SqlParameter("@ChequeStatus", DbType.Int32)).Value = oelChque.ChequeStatus;
                    cmdCheque.Parameters.Add(new SqlParameter("@GivenTakenDate", DbType.DateTime)).Value = oelChque.ChequeGivenTakenDate;
                    cmdCheque.Parameters.Add(new SqlParameter("@WithDrawlDate", DbType.DateTime)).Value = oelChque.ChequeWithDrawlDate;
                    cmdCheque.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelChque.CreatedDateTime;
                    cmdCheque.Parameters.Add(new SqlParameter("@ChequeAmount", DbType.DateTime)).Value = oelChque.TotalAmount;

                    info.IntID = cmdCheque.ExecuteNonQuery();
                    info.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {

                }
                return info;
            }
        }
        public EntityoperationInfo DeletePostDatedCheque(Int64 IdCheque, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdCheque = new SqlCommand("[Transactions].[Proc_DeletePostDatedCheques]", objConn))
            {
                cmdCheque.CommandType = CommandType.StoredProcedure;
                cmdCheque.Parameters.Add(new SqlParameter("@IdCheque", DbType.Int64)).Value = IdCheque;

                if (cmdCheque.ExecuteNonQuery() > -1)
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
        public List<ChequesEL> GetChequeById(Int64 IdCheque, SqlConnection objConn)
        {
            List<ChequesEL> list = new List<ChequesEL>();
            using (SqlCommand cmdChequesDetail = new SqlCommand("[Transactions].[Proc_GetChequeById]", objConn))
            {
                cmdChequesDetail.CommandType = CommandType.StoredProcedure;
                cmdChequesDetail.Parameters.Add("@IdCheque", SqlDbType.BigInt).Value = IdCheque;
                objReader = cmdChequesDetail.ExecuteReader();
                while (objReader.Read())
                {
                    ChequesEL oelCheque = new ChequesEL();
                    oelCheque.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelCheque.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelCheque.IdCheque = Validation.GetSafeLong(objReader["Cheque_Id"]);
                    oelCheque.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelCheque.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelCheque.BankName = Validation.GetSafeString(objReader["BankName"]);
                    oelCheque.ChequeType = Validation.GetSafeInteger(objReader["ChequeType"]);
                    oelCheque.ChequeTypeHeader = Validation.GetSafeString(objReader["ChequeTypeHeader"]);
                    oelCheque.ChequeStatus = Validation.GetSafeInteger(objReader["ChequeStatus"]);
                    oelCheque.ChequeStatusHeader = Validation.GetSafeString(objReader["ChequeStatusHeader"]);
                    oelCheque.ChequeDaysRemaining = Validation.GetSafeInteger(objReader["RemainingDays"]);
                    oelCheque.ChequeGivenTakenDate = Convert.ToDateTime(objReader["GivenTakenDate"]);
                    oelCheque.ChequeWithDrawlDate = Convert.ToDateTime(objReader["WithDrawlDate"]);
                    oelCheque.TotalAmount = Validation.GetSafeDecimal(objReader["ChequeAmount"]);
                    oelCheque.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelCheque);
                }
            }
            return list;
        }
        public List<ChequesEL> GetChequeByVoucher(Int64 VoucherNo, SqlConnection objConn)
        {
            List<ChequesEL> list = new List<ChequesEL>();
            using (SqlCommand cmdChequesDetail = new SqlCommand("[Transactions].[Proc_GetChequeByVoucher]", objConn))
            {
                cmdChequesDetail.CommandType = CommandType.StoredProcedure;
                cmdChequesDetail.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
                objReader = cmdChequesDetail.ExecuteReader();
                while (objReader.Read())
                {
                    ChequesEL oelCheque = new ChequesEL();
                    oelCheque.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelCheque.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelCheque.IdCheque = Validation.GetSafeLong(objReader["Cheque_Id"]);
                    oelCheque.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelCheque.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelCheque.BankName = Validation.GetSafeString(objReader["BankName"]);
                    oelCheque.ChequeType = Validation.GetSafeInteger(objReader["ChequeType"]);
                    oelCheque.ChequeTypeHeader = Validation.GetSafeString(objReader["ChequeTypeHeader"]);
                    oelCheque.ChequeStatus = Validation.GetSafeInteger(objReader["ChequeStatus"]);
                    oelCheque.ChequeStatusHeader = Validation.GetSafeString(objReader["ChequeStatusHeader"]);
                    oelCheque.ChequeDaysRemaining = Validation.GetSafeInteger(objReader["RemainingDays"]);
                    oelCheque.ChequeGivenTakenDate = Convert.ToDateTime(objReader["GivenTakenDate"]);
                    oelCheque.ChequeWithDrawlDate = Convert.ToDateTime(objReader["WithDrawlDate"]);
                    oelCheque.TotalAmount = Validation.GetSafeDecimal(objReader["ChequeAmount"]);
                    oelCheque.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelCheque);
                }
            }
            return list;
        }
        public List<ChequesEL> GetAllChequesByInitialStatus(Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<ChequesEL> list = new List<ChequesEL>();
            using (SqlCommand cmdChequesDetail = new SqlCommand("[Transactions].[Proc_GetAllChequesByInitialStatus]", objConn))
            {
                cmdChequesDetail.CommandType = CommandType.StoredProcedure;
                cmdChequesDetail.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdChequesDetail.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                objReader = cmdChequesDetail.ExecuteReader();
                while (objReader.Read())
                {
                    ChequesEL oelCheque = new ChequesEL();
                    oelCheque.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelCheque.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelCheque.IdCheque = Validation.GetSafeLong(objReader["Cheque_Id"]);
                    oelCheque.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelCheque.BankName = Validation.GetSafeString(objReader["BankName"]);
                    oelCheque.ChequeTypeHeader = Validation.GetSafeString(objReader["ChequeTypeHeader"]);
                    oelCheque.ChequeStatusHeader = Validation.GetSafeString(objReader["ChequeStatusHeader"]);
                    oelCheque.ChequeDaysRemaining = Validation.GetSafeInteger(objReader["RemainingDays"]);
                    oelCheque.ChequeGivenTakenDate = Convert.ToDateTime(objReader["GivenTakenDate"]);
                    oelCheque.ChequeWithDrawlDate = Convert.ToDateTime(objReader["WithDrawlDate"]);
                    oelCheque.TotalAmount = Validation.GetSafeDecimal(objReader["ChequeAmount"]);

                    list.Add(oelCheque);
                }
            }
            return list;
        }
        public List<ChequesEL> GetAllChequesByBadStatus(Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<ChequesEL> list = new List<ChequesEL>();
            using (SqlCommand cmdChequesDetail = new SqlCommand("[Transactions].[Proc_GetAllChequesByBadStatus]", objConn))
            {
                cmdChequesDetail.CommandType = CommandType.StoredProcedure;
                cmdChequesDetail.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdChequesDetail.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                objReader = cmdChequesDetail.ExecuteReader();
                while (objReader.Read())
                {
                    ChequesEL oelCheque = new ChequesEL();
                    oelCheque.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelCheque.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelCheque.IdCheque = Validation.GetSafeLong(objReader["Cheque_Id"]);
                    oelCheque.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelCheque.BankName = Validation.GetSafeString(objReader["BankName"]);
                    oelCheque.ChequeTypeHeader = Validation.GetSafeString(objReader["ChequeTypeHeader"]);
                    oelCheque.ChequeStatusHeader = Validation.GetSafeString(objReader["ChequeStatusHeader"]);
                    oelCheque.ChequeDaysRemaining = Validation.GetSafeInteger(objReader["RemainingDays"]);
                    oelCheque.ChequeGivenTakenDate = Convert.ToDateTime(objReader["GivenTakenDate"]);
                    oelCheque.ChequeWithDrawlDate = Convert.ToDateTime(objReader["WithDrawlDate"]);
                    oelCheque.TotalAmount = Validation.GetSafeDecimal(objReader["ChequeAmount"]);

                    list.Add(oelCheque);
                }
            }
            return list;
        }
        public List<ChequesEL> GetAllChequesByCashedStatus(Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<ChequesEL> list = new List<ChequesEL>();
            using (SqlCommand cmdChequesDetail = new SqlCommand("[Transactions].[Proc_GetAllChequesByCashedStatus]", objConn))
            {
                cmdChequesDetail.CommandType = CommandType.StoredProcedure;
                cmdChequesDetail.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdChequesDetail.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                objReader = cmdChequesDetail.ExecuteReader();
                while (objReader.Read())
                {
                    ChequesEL oelCheque = new ChequesEL();
                    oelCheque.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelCheque.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelCheque.IdCheque = Validation.GetSafeLong(objReader["Cheque_Id"]);
                    oelCheque.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelCheque.BankName = Validation.GetSafeString(objReader["BankName"]);
                    oelCheque.ChequeTypeHeader = Validation.GetSafeString(objReader["ChequeTypeHeader"]);
                    oelCheque.ChequeStatusHeader = Validation.GetSafeString(objReader["ChequeStatusHeader"]);
                    oelCheque.ChequeDaysRemaining = Validation.GetSafeInteger(objReader["RemainingDays"]);
                    oelCheque.ChequeGivenTakenDate = Convert.ToDateTime(objReader["GivenTakenDate"]);
                    oelCheque.ChequeWithDrawlDate = Convert.ToDateTime(objReader["WithDrawlDate"]);
                    oelCheque.TotalAmount = Validation.GetSafeDecimal(objReader["ChequeAmount"]);

                    list.Add(oelCheque);
                }
            }
            return list;
        }
    }
}
