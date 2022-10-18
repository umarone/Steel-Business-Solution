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
    public class VoucherDAL
    {
        #region Variables
        IDataReader objReader;
        TransactionsDAL Tdal;
        VouchersDetailDAL VDal;
        Int64? Identity = 0;
        #endregion
        public VoucherDAL()
        {
            Tdal = new TransactionsDAL();
            VDal = new VouchersDetailDAL();
        }
        public EntityoperationInfo InsertVouchersHead(VouchersEL oelVoucher, List<VoucherDetailEL> oelDetailCollection, SqlConnection objConn)
        {
            lock (this)
            {
                EntityoperationInfo infoResult = new EntityoperationInfo();
                SqlTransaction objTran = objConn.BeginTransaction();
                SqlCommand cmdVoucherHead = new SqlCommand("[Transactions].[Proc_CreateVouchersHead]", objConn);
                try
                {
                    cmdVoucherHead.Transaction = objTran;
                    cmdVoucherHead.CommandType = CommandType.StoredProcedure;

                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@SheetNo", DbType.Int64)).Value = oelVoucher.SheetNo;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelVoucher.BookNo;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@ChequeNo", DbType.String)).Value = oelVoucher.ChequeNo;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelVoucher.Description;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@VType", DbType.String)).Value = oelVoucher.VoucherType;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    Identity = Validation.GetSafeLong(cmdVoucherHead.ExecuteScalar());

                    // Insert Vouchers Detail

                    VDal.InsertVouchersDetail(oelDetailCollection, Identity, objConn, objTran);

                    // Insert Vouchers Transactions
                    //Tdal.InsertTransactions(oelTransactionsCollection, Identity, objConn, objTran);

                    objTran.Commit();
                    infoResult.IntID = Identity.Value;
                    //infoResult.VoucherNo = GetTransactionalVoucherNumberById(Identity.Value, oelVoucher.IdProject.Value, oelVoucher.BookNo, objConn, objTran);
                    infoResult.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }

                return infoResult;
            }
        }
        public Int64 GetTransactionalVoucherNumberById(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdVoucher = new SqlCommand("[Transactions].[Proc_GetVoucherNumberById]", objConn, objTran);
            cmdVoucher.CommandType = CommandType.StoredProcedure;
            cmdVoucher.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
            cmdVoucher.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdVoucher.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            return Validation.GetSafeLong(cmdVoucher.ExecuteScalar());
        }
        public EntityoperationInfo UpdateVouchersHead(VouchersEL oelVoucher, List<VoucherDetailEL> oelDetailCollection, SqlConnection objConn)
        {
            lock (this)
            {
                EntityoperationInfo infoResult = new EntityoperationInfo();
                SqlTransaction objTran = objConn.BeginTransaction();
                SqlCommand cmdVoucherHead = new SqlCommand("[Transactions].[Proc_UpdateVouchersHead]", objConn);
                try
                {
                    cmdVoucherHead.Transaction = objTran;
                    cmdVoucherHead.CommandType = CommandType.StoredProcedure;

                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelVoucher.IdVoucher;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelVoucher.IdProject;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelVoucher.IdUser;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdEditedUser", DbType.Int64)).Value = oelVoucher.EditedByUserId;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@IdPostedUser", DbType.Int64)).Value = oelVoucher.PostedByUserId;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@SheetNo", DbType.Int64)).Value = oelVoucher.SheetNo;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelVoucher.BookNo;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@TerminalNo", DbType.Int64)).Value = oelVoucher.TerminalNumber;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelVoucher.SubAccountNo;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelVoucher.Date;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@EditedDateTime", DbType.DateTime)).Value = oelVoucher.EditedDateTime;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@PostedDateTime", DbType.DateTime)).Value = oelVoucher.PostedDateTime;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@ChequeNo", DbType.String)).Value = oelVoucher.ChequeNo;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@Narration", DbType.String)).Value = oelVoucher.Description;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@TotalAmount", DbType.Decimal)).Value = oelVoucher.TotalAmount;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@VType", DbType.String)).Value = oelVoucher.VoucherType;
                    cmdVoucherHead.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelVoucher.Posted;
                    cmdVoucherHead.ExecuteNonQuery();

                    // Insert Vouchers Detail

                    VDal.UpdateVouchersDetail(oelDetailCollection, oelVoucher.IdVoucher, objConn, objTran);

                    // Insert Vouchers Transactions
                    //Tdal.UpdateTransactions(oelTransactionsCollection, objConn, objTran);

                    objTran.Commit();
                    infoResult.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }

                return infoResult;
            }
        }
        public List<VoucherDetailEL> GetTransactionalVouchersByType(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, string VoucherType, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetTransactionalVouchersByType]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;

                cmdVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                objReader = cmdVouchers.ExecuteReader();

                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();

                    /// Fetching Header Information
                    oelVoucherDetail.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucherDetail.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                    oelVoucherDetail.IdUser = Validation.GetSafeLong(objReader["User_Id"]);
                    oelVoucherDetail.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                    oelVoucherDetail.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucherDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucherDetail.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucherDetail.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucherDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelVoucherDetail.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                    oelVoucherDetail.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                    oelVoucherDetail.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelVoucherDetail.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucherDetail.TotalAmount = Validation.GetSafeLong(objReader["TotalAmount"]);
                    oelVoucherDetail.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucherDetail.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    /// Fetching Header AccountName
                    oelVoucherDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucherDetail.AccountType = Validation.GetSafeString(objReader["AccountType"]);
                    oelVoucherDetail.IdHead = Validation.GetSafeInteger(objReader["Head_Id"]);

                    /// Fetching Detail Information
                    oelVoucherDetail.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelVoucherDetail.IdAccount = Validation.GetSafeLong(objReader["Account_Id"]);
                    oelVoucherDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucherDetail.Narration = Validation.GetSafeString(objReader["Narration"]);
                    oelVoucherDetail.ClosingBalance = Validation.GetSafeLong(objReader["ClosingBalance"]);
                    oelVoucherDetail.Debit = Validation.GetSafeLong(objReader["Debit"]);
                    oelVoucherDetail.Credit = Validation.GetSafeLong(objReader["Credit"]);

                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }
        public List<VoucherDetailEL> GetTransactionalVouchersByTypeAndNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo, string VoucherType, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetTransactionalVouchersByTypeAndNumber]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;

                cmdVouchers.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                objReader = cmdVouchers.ExecuteReader();

                while (objReader.Read())
                {
                    VoucherDetailEL oelVoucherDetail = new VoucherDetailEL();

                    /// Fetching Header Information
                    oelVoucherDetail.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucherDetail.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                    oelVoucherDetail.IdUser = Validation.GetSafeLong(objReader["User_Id"]);
                    oelVoucherDetail.SheetNo = Validation.GetSafeLong(objReader["SheetNo"]);
                    oelVoucherDetail.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucherDetail.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucherDetail.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucherDetail.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelVoucherDetail.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    oelVoucherDetail.EditedDateTime = Validation.GetSafeNullableDateTime(objReader["EditedDateTime"]);
                    oelVoucherDetail.PostedDateTime = Validation.GetSafeNullableDateTime(objReader["PostedDateTime"]);
                    oelVoucherDetail.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelVoucherDetail.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucherDetail.TotalAmount = Validation.GetSafeLong(objReader["TotalAmount"]);
                    oelVoucherDetail.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucherDetail.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);

                    /// Fetching Header AccountName
                    oelVoucherDetail.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucherDetail.AccountType = Validation.GetSafeString(objReader["AccountType"]);
                    oelVoucherDetail.IdHead = Validation.GetSafeInteger(objReader["Head_Id"]);

                    /// Fetching Detail Information
                    oelVoucherDetail.IdVoucherDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                    oelVoucherDetail.IdAccount = Validation.GetSafeLong(objReader["Account_Id"]);
                    oelVoucherDetail.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelVoucherDetail.Narration = Validation.GetSafeString(objReader["Narration"]);
                    oelVoucherDetail.ClosingBalance = Validation.GetSafeLong(objReader["ClosingBalance"]);
                    oelVoucherDetail.Debit = Validation.GetSafeLong(objReader["Debit"]);
                    oelVoucherDetail.Credit = Validation.GetSafeLong(objReader["Credit"]);

                    list.Add(oelVoucherDetail);
                }
            }
            return list;
        }


        public bool DeleteVouchers(Int64? IdVoucher, Int64 VoucherNo, string TransactionType, Int64 IdCompany, SqlConnection objConn)
        {
            using (SqlTransaction objTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteVouchers = new SqlCommand("[Transactions].[Proc_DeleteVoucherWithtransaction]", objConn);
                    cmdDeleteVouchers.CommandType = CommandType.StoredProcedure;
                    cmdDeleteVouchers.Transaction = objTran;
                    cmdDeleteVouchers.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                    cmdDeleteVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher.Value;
                    cmdDeleteVouchers.Parameters.Add("@TransactionType", SqlDbType.VarChar).Value = TransactionType;
                    cmdDeleteVouchers.ExecuteNonQuery();
                    cmdDeleteVouchers.Parameters.Clear();

                    Tdal.DeleteTransactions(IdVoucher, TransactionType, IdCompany, objConn, objTran);

                    objTran.Commit();
                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
            }
            return true;
        }
        public bool DeleteFinancialVouchers(Int64? IdVoucher, string TransactionType, Int64 IdProject, SqlConnection objConn)
        {
            using (SqlTransaction objTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteVouchers = new SqlCommand("[Transactions].[Proc_DeleteFinancialVouchers]", objConn);
                    cmdDeleteVouchers.CommandType = CommandType.StoredProcedure;
                    cmdDeleteVouchers.Transaction = objTran;
                    cmdDeleteVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                    cmdDeleteVouchers.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher.Value;
                    cmdDeleteVouchers.Parameters.Add("@TransactionType", SqlDbType.VarChar).Value = TransactionType;
                    cmdDeleteVouchers.ExecuteNonQuery();

                    objTran.Commit();

                }
                catch (Exception ex)
                {
                    objTran.Rollback();
                    throw ex;
                }
            }
            return true;
        }
        public bool DeleteChildRecords(Int64 Id, string VoucherType, SqlConnection objConn)
        {
            SqlCommand cmdDeleteDetail = new SqlCommand();
            cmdDeleteDetail.CommandType = CommandType.StoredProcedure;
            cmdDeleteDetail.Connection = objConn;

            cmdDeleteDetail.CommandText = "[Transactions].[Proc_DeleteChildRecords]";
            cmdDeleteDetail.Parameters.Add(new SqlParameter("@IdVoucherDetail", DbType.Int64)).Value = Id;
            cmdDeleteDetail.Parameters.Add(new SqlParameter("@VoucherType", DbType.String)).Value = VoucherType;
            cmdDeleteDetail.ExecuteNonQuery();
            return true;
        }
        public List<VouchersEL> GetAllTransactionalVoucherByTypeAndDate(Int64 IdProject,Int64 BookNo, string VoucherType, DateTime VoucherDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllTransactionalVoucherByTypeAndDate]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                cmdVouchers.Parameters.Add("@VDate", SqlDbType.DateTime).Value = VoucherDate;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetAllTransactionalVoucherByTypeAndEditedDate(Int64 IdProject, Int64 BookNo, string VoucherType, DateTime VoucherDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllTransactionalVoucherByTypeAndEditedDate]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                cmdVouchers.Parameters.Add("@VDate", SqlDbType.DateTime).Value = VoucherDate;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetAllTransactionalVoucherByTypeAndAccountNo(Int64 IdProject, Int64 BookNo, string AccountNo, string VoucherType, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllTransactionalVoucherByTypeAndAccountNo]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;

                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetAllTransactionalVoucherByType(Int64 IdProject, Int64 BookNo, string VoucherType, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllTransactionalVoucherByType]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;

                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetVouchersByTypeAndDate(Int64 IdProject, string VoucherType, DateTime VoucherDate, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            return list;
        }
        public List<VouchersEL> GetVouchersByTypeAndVoucherNumber(Int64 IdProject, string VoucherType, Int64 VoucherNo, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetVoucherByTypeAndVoucherNo]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                cmdVouchers.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    if (VoucherType == "StockReceiptVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "StockReceiptVoucher";
                        oelVoucher.IsImport = Convert.ToBoolean(objReader["IsImportPurchase"]);
                        oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                        oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATAmount"]);
                    }
                    else if (VoucherType == "PurchaseReturnVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "PurchaseReturnVoucher";
                        oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                        oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATAmount"]);
                    }
                    else if (VoucherType == "CashReceiptVoucher")
                    {
                        //oelVoucher.AccountNo = Validation.GetSafeLong(objReader["AccountNo"]);
                        oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                        oelVoucher.VoucherType = "Receipt Voucher";
                        oelVoucher.Description = Validation.GetSafeString(objReader["Description"]);
                    }
                    else if (VoucherType == "PaymentVoucher")
                    {
                        //oelVoucher.AccountNo = Validation.GetSafeLong(objReader["AccountNo"]);
                        oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                        oelVoucher.VoucherType = "Payment Voucher";
                        oelVoucher.Description = Validation.GetSafeString(objReader["Description"]);
                    }
                    else if (VoucherType == "SaleInvoiceVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.MemoSaleNo = Validation.GetSafeString(objReader["MemoSaleNo"]);
                        oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);
                        oelVoucher.SampleNo = Validation.GetSafeLong(objReader["SampleNo"]);
                        oelVoucher.Transactiondays = Validation.GetSafeLong(objReader["CreditDays"]);
                        oelVoucher.IsRecieved = Validation.GetSafeBooleanNullable(objReader["IsRecieved"]);
                        oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                        oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATAmount"]);
                        oelVoucher.VoucherType = "Invoice Voucher";
                    }
                    else if (VoucherType == "SampleVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.DemandNo = Validation.GetSafeString(objReader["DemandNo"]);
                        oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);
                        oelVoucher.Transactiondays = Validation.GetSafeLong(objReader["SampleDays"]);
                        oelVoucher.IsRecieved = Validation.GetSafeBooleanNullable(objReader["IsRecieved"]);
                        if (DBNull.Value != objReader["IsSold"])
                        {
                            oelVoucher.IsSold = Convert.ToBoolean(objReader["IsSold"]);
                        }
                        else
                        {
                            oelVoucher.IsSold = false;
                        }
                        oelVoucher.VoucherType = "Sample Voucher";
                    }
                    else if (VoucherType == "SampleReturnVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.InWardGatePassNo = Validation.GetSafeString(objReader["InWardGatePassNo"]);
                        oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);
                        oelVoucher.VoucherType = "Sample Return Voucher";
                    }
                    else if (VoucherType == "SalesReturnVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.InWardGatePassNo = Validation.GetSafeString(objReader["InWardGatePassNo"]);
                        oelVoucher.OutWardGatePassNo = Validation.GetSafeString(objReader["OutWardGatePassNo"]);
                        oelVoucher.ReturnType = Validation.GetSafeInteger(objReader["ReturnType"]);
                        oelVoucher.VoucherType = "SalesReturnVoucher";
                        oelVoucher.VAT = Validation.GetSafeDecimal(objReader["VAT"]);
                        oelVoucher.VATAmount = Validation.GetSafeDecimal(objReader["VATAmount"]);
                    }
                    else if (VoucherType == "BankPaymentVoucher")
                    {
                        //oelVoucher.AccountNo = Validation.GetSafeLong(objReader["AccountNo"]);
                        oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                        oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                        oelVoucher.VoucherType = "BankPaymentVoucher";
                        oelVoucher.Description = Validation.GetSafeString(objReader["Description"]);
                    }
                    else if (VoucherType == "BankReceiptVoucher")
                    {
                        //oelVoucher.AccountNo = Validation.GetSafeLong(objReader["AccountNo"]);
                        oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                        oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                        oelVoucher.Description = Validation.GetSafeString(objReader["Description"]);
                        oelVoucher.VoucherType = "BankReceiptVoucher";
                    }
                    else if (VoucherType == "PrescriberSampleVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "PrescriberSampleVoucher";
                    }
                    else if (VoucherType == "PrescriberSampleVoucher")
                    {
                        oelVoucher.VoucherType = "JournalVoucher";
                    }
                    else if (VoucherType == "JournalVoucher")
                    {
                        oelVoucher.Description = Convert.ToString(objReader["Description"] ?? "");
                        oelVoucher.VoucherType = "JournalVoucher";
                    }
                    if (VoucherType != "PaymentVoucher" && VoucherType != "CashReceiptVoucher" && VoucherType != "SaleInvoiceVoucher" && VoucherType != "SalesReturnVoucher" && VoucherType != "BankPaymentVoucher" && VoucherType != "BankReceiptVoucher" && VoucherType != "PrescriberSampleVoucher" && VoucherType != "JournalVoucher" && VoucherType != "SampleVoucher" && VoucherType != "SampleReturnVoucher")
                    {
                        if (objReader["BillNo"] != DBNull.Value)
                        {
                            oelVoucher.BillNo = objReader["BillNo"].ToString();
                        }
                        else
                        {
                            oelVoucher.BillNo = "";
                        }
                    }
                    if (VoucherType != "JournalVoucher")
                    {
                        //oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    }
                    if (VoucherType == "PrescriberSampleVoucher")
                    {
                        oelVoucher.Description = Convert.ToString(objReader["Discription"] ?? "");
                    }
                    else
                    {
                        if (VoucherType != "JournalVoucher")
                        {
                            oelVoucher.Description = Convert.ToString(objReader["Description"] ?? "");
                        }
                    }
                    oelVoucher.Amount = Convert.ToInt64(objReader["Amount"]);
                    oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetVouchersByTypeAndAccountNo(Int64 IdCompany, string VoucherType, string AccountNo, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetVoucherByTypeAndAccountNo]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                cmdVouchers.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();
                    oelVoucher.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    if (VoucherType == "StockReceiptVoucher")
                    {
                        //oelVoucher.PersonName = Convert.ToString(objReader["SupplierNo"]);
                        oelVoucher.PersonName = Convert.ToString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "StockReceiptVoucher";
                    }
                    else if (VoucherType == "CashReceiptVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "Receipt Voucher";
                    }
                    else if (VoucherType == "PaymentVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "Payment Voucher";
                    }
                    else if (VoucherType == "SaleInvoiceVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "Invoice Voucher";
                    }
                    else if (VoucherType == "SalesReturnVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["CustomerNo"]);
                        oelVoucher.VoucherType = "SalesReturnVoucher";
                    }
                    else if (VoucherType == "BankPaymentVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "BankPaymentVoucher";
                    }
                    else if (VoucherType == "BankReceiptVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "BankReceiptVoucher";
                    }
                    else if (VoucherType == "PrescriberSampleVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "PrescriberSampleVoucher";
                    }
                    else if (VoucherType == "PrescriberSampleVoucher")
                    {
                        oelVoucher.VoucherType = "JournalVoucher";
                    }
                    if (VoucherType != "PaymentVoucher" && VoucherType != "CashReceiptVoucher" && VoucherType != "SaleInvoiceVoucher" && VoucherType != "SalesReturnVoucher" && VoucherType != "BankPaymentVoucher" && VoucherType != "BankReceiptVoucher" && VoucherType != "PrescriberSampleVoucher" && VoucherType != "JournalVoucher")
                    {
                        if (objReader["BillNo"] != DBNull.Value)
                        {
                            oelVoucher.BillNo = objReader["BillNo"].ToString();
                        }
                        else
                        {
                            oelVoucher.BillNo = "";
                        }
                    }
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    if (VoucherType == "PrescriberSampleVoucher")
                    {
                        oelVoucher.Description = Convert.ToString(objReader["Discription"] ?? "");
                    }
                    else
                    {
                        if (VoucherType != "JournalVoucher")
                        {
                            oelVoucher.Description = Convert.ToString(objReader["Description"] ?? "");
                        }
                    }
                    oelVoucher.Amount = Convert.ToInt64(objReader["Amount"]);
                    oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetAllVouchersByType(Int64 IdCompany, string VoucherType, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllVouchersByType]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
                    oelVoucher.Date = Convert.ToDateTime(objReader["VDate"]);
                    if (VoucherType == "StockReceiptVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                        oelVoucher.VoucherType = "StockReceiptVoucher";
                    }
                    else if (VoucherType == "CashReceiptVoucher")
                    {
                        //oelVoucher.AccountNo = Validation.GetSafeLong(objReader["AccountNo"]);
                        oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                        oelVoucher.VoucherType = "Receipt Voucher";
                    }
                    else if (VoucherType == "PaymentVoucher")
                    {
                        //oelVoucher.AccountNo = Validation.GetSafeLong(objReader["AccountNo"]);
                        oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                        oelVoucher.VoucherType = "Payment Voucher";
                    }
                    else if (VoucherType == "SaleInvoiceVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                        oelVoucher.MemoSaleNo = Validation.GetSafeString(objReader["MemoSaleNo"]);
                        oelVoucher.VoucherType = "Invoice Voucher";
                    }
                    else if (VoucherType == "SalesReturnVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                        oelVoucher.VoucherType = "SalesReturnVoucher";
                    }
                    else if (VoucherType == "BankPaymentVoucher")
                    {
                        //oelVoucher.AccountNo = Validation.GetSafeLong(objReader["AccountNo"]);
                        oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                        oelVoucher.VoucherType = "BankPaymentVoucher";
                    }
                    else if (VoucherType == "BankReceiptVoucher")
                    {
                        //oelVoucher.AccountNo = Validation.GetSafeLong(objReader["AccountNo"]);
                        oelVoucher.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                        oelVoucher.VoucherType = "BankReceiptVoucher";
                    }
                    else if (VoucherType == "PrescriberSampleVoucher")
                    {
                        oelVoucher.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        oelVoucher.VoucherType = "PrescriberSampleVoucher";
                    }
                    else if (VoucherType == "PrescriberSampleVoucher")
                    {
                        oelVoucher.VoucherType = "JournalVoucher";
                    }
                    if (VoucherType != "PaymentVoucher" && VoucherType != "CashReceiptVoucher" && VoucherType != "SaleInvoiceVoucher" && VoucherType != "SalesReturnVoucher" && VoucherType != "BankPaymentVoucher" && VoucherType != "BankReceiptVoucher" && VoucherType != "PrescriberSampleVoucher" && VoucherType != "JournalVoucher")
                    {
                        if (objReader["BillNo"] != DBNull.Value)
                        {
                            oelVoucher.BillNo = objReader["BillNo"].ToString();
                        }
                        else
                        {
                            oelVoucher.BillNo = "";
                        }
                    }
                    if (VoucherType != "JournalVoucher")
                    {
                        //oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    }
                    if (VoucherType == "PrescriberSampleVoucher")
                    {
                        oelVoucher.Description = Convert.ToString(objReader["Discription"] ?? "");
                    }
                    else
                    {
                        if (VoucherType != "JournalVoucher")
                        {
                            oelVoucher.Description = Convert.ToString(objReader["Description"] ?? "");
                        }
                    }
                    oelVoucher.Amount = Convert.ToInt64(objReader["Amount"]);
                    oelVoucher.Posted = Convert.ToBoolean(objReader["Posted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public Int64 GetTotalTransactionalVouchersByType(Int64 IdProject, Int64 BookNo, string VoucherType, SqlConnection objConn)
        {
            SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetTotalTransactionalVouchersByType]", objConn);

            cmdVouchers.CommandType = CommandType.StoredProcedure;
            cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
            return Validation.GetSafeLong(cmdVouchers.ExecuteScalar());
        }
        public string GetMaxVoucherNumber(string VoucherType, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetMaxVoucherNumber]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.NVarChar).Value = VoucherType;
                return cmdVouchers.ExecuteScalar().ToString();
            }
        }
        public List<PersonsEL> GetStockSupplier(string AccountNo, Int64 VoucherNo, Int64 IdCompany, SqlConnection objConn)
        {
            List<PersonsEL> oelPersonCollection = new List<PersonsEL>();
            using (SqlCommand cmdTransaction = new SqlCommand("[Transactions].[Proc_GetStockSupplier]", objConn))
            {
                cmdTransaction.CommandType = CommandType.StoredProcedure;
                cmdTransaction.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdTransaction.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
                cmdTransaction.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdTransaction.ExecuteReader();
                while (objReader.Read())
                {
                    PersonsEL oelPerson = new PersonsEL();
                    oelPerson.PAccountId = Validation.GetSafeLong(objReader["transaction_id"]);
                    oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPerson.PersonName = objReader["PersonName"].ToString();
                    oelPerson.Contact = objReader["Contact"].ToString();
                    oelPerson.Address = objReader["Address"].ToString();
                    oelPerson.NTN = objReader["NTN"].ToString();
                    //oelTransaction.TransactionID = new Guid(objReader["Transaction_Id"].ToString());
                    //oelTransaction.AccountNo = objReader["AccountNo"].ToString();
                    //oelTransaction.Date = Convert.ToDateTime(objReader["Date"]);
                    //oelTransaction.VoucherNo = Convert.ToInt32(objReader["VoucherNo"]);
                    //oelTransaction.Qty = Convert.ToInt32(objReader["qty"]);                   
                    //oelTransaction.Debit = Convert.ToDecimal(objReader["Debit"]);
                    //oelTransaction.Credit = Convert.ToDecimal(objReader["Credit"]);
                    //oelTransaction.Description = objReader["Description"].ToString();


                    oelPersonCollection.Add(oelPerson);
                }
            }
            return oelPersonCollection;
        }
        public List<PersonsEL> GetSaleCustomer(Int64? IdVoucher, string AccountNo, Int64 IdCompany, SqlConnection objConn)
        {
            List<PersonsEL> list = new List<PersonsEL>();
            using (SqlCommand cmdSaleCustomer = new SqlCommand("[Transactions].[Proc_GetSaleCustomer]", objConn))
            {
                cmdSaleCustomer.CommandType = CommandType.StoredProcedure;
                cmdSaleCustomer.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSaleCustomer.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher;
                cmdSaleCustomer.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdSaleCustomer.ExecuteReader();
                while (objReader.Read())
                {
                    PersonsEL oelPerson = new PersonsEL();
                    oelPerson.PAccountId = Validation.GetSafeLong(objReader["transaction_id"]);
                    oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPerson.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelPerson.PersonName = objReader["PersonName"].ToString();
                    oelPerson.Contact = objReader["Contact"].ToString();
                    oelPerson.Address = objReader["Address"].ToString();
                    oelPerson.NTN = objReader["NTN"].ToString();
                    oelPerson.Balance = Validation.GetSafeDecimal(objReader["Amount"]);
                    list.Add(oelPerson);
                }
            }
            return list;
        }
        public List<PersonsEL> GetSalesReturnCustomer(Int64? IdVoucher, string AccountNo, Int64 IdCompany, SqlConnection objConn)
        {
            List<PersonsEL> list = new List<PersonsEL>();
            using (SqlCommand cmdSaleCustomer = new SqlCommand("[Transactions].[Proc_GetSalesReturnCustomer]", objConn))
            {
                cmdSaleCustomer.CommandType = CommandType.StoredProcedure;
                cmdSaleCustomer.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSaleCustomer.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher.Value;
                cmdSaleCustomer.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdSaleCustomer.ExecuteReader();
                while (objReader.Read())
                {
                    PersonsEL oelPerson = new PersonsEL();
                    oelPerson.PAccountId = Validation.GetSafeLong(objReader["transaction_id"]);
                    oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPerson.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelPerson.PersonName = objReader["PersonName"].ToString();
                    oelPerson.Contact = objReader["Contact"].ToString();
                    oelPerson.Address = objReader["Address"].ToString();
                    oelPerson.NTN = objReader["NTN"].ToString();
                    oelPerson.Balance = Validation.GetSafeDecimal(objReader["Amount"]);

                    list.Add(oelPerson);
                }
            }
            return list;
        }
        public List<PersonsEL> GetSampleCustomer(Int64 SampleNumber, string AccountNo, string Transactiontype, Int64 IdCompany, SqlConnection objConn)
        {
            List<PersonsEL> list = new List<PersonsEL>();
            using (SqlCommand cmdSaleCustomer = new SqlCommand("[Transactions].[Proc_GetSampleCustomer]", objConn))
            {
                cmdSaleCustomer.CommandType = CommandType.StoredProcedure;
                cmdSaleCustomer.Parameters.Add("@IdCompany", SqlDbType.VarChar).Value = IdCompany;
                cmdSaleCustomer.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = SampleNumber;
                cmdSaleCustomer.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdSaleCustomer.Parameters.Add("@TransactionType", SqlDbType.VarChar).Value = Transactiontype;
                objReader = cmdSaleCustomer.ExecuteReader();
                while (objReader.Read())
                {
                    PersonsEL oelPerson = new PersonsEL();
                    oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelPerson.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelPerson.PersonName = objReader["PersonName"].ToString();
                    oelPerson.Contact = objReader["Contact"].ToString();
                    oelPerson.Address = objReader["Address"].ToString();
                    oelPerson.NTN = objReader["NTN"].ToString();
                    oelPerson.Balance = Validation.GetSafeDecimal(objReader["Amount"]);
                    list.Add(oelPerson);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetTransactionsByVoucherAndType(Int64 IdCompany, Int64? IdVoucher, Int64 VoucherNo, string VoucherType, SqlConnection objConn)
        {
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            using (SqlCommand cmdTransaction = new SqlCommand("[Transactions].[Proc_GetTransactionsByVoucherAndType]", objConn))
            {
                cmdTransaction.CommandType = CommandType.StoredProcedure;
                cmdTransaction.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdTransaction.Parameters.Add("@IdVoucher", SqlDbType.UniqueIdentifier).Value = IdVoucher;
                cmdTransaction.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
                cmdTransaction.Parameters.Add("@VoucherType", SqlDbType.NVarChar).Value = VoucherType;
                objReader = cmdTransaction.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    //oelTransaction.TransactionID = new Guid(objReader["Transaction_Id"].ToString());

                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = objReader["AccountName"].ToString();
                    //oelTransaction.Date = Convert.ToDateTime(objReader["VDate"]);
                    //oelTransaction.VoucherNo = Convert.ToInt32(objReader["VoucherNo"]);

                    oelTransaction.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    //oelTransaction.Description = objReader["Description"].ToString();
                    // oelTransaction.Amount = Convert.ToDecimal(objReader["Amount"]);                   
                    if (VoucherType == "StockReceiptVoucher")
                    {
                        if (objReader["VoucherDetail_Id"] != DBNull.Value)
                        {

                            oelTransaction.IdDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"].ToString());
                            oelTransaction.Discription = Validation.GetSafeString(objReader["Discription"]);
                            oelTransaction.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                            //oelTransaction.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                            oelTransaction.Qty = Validation.GetSafeInteger(objReader["units"]);
                            //oelTransaction.Bonus = Validation.GetSafeLong(objReader["Bonus"]);
                            oelTransaction.unitprice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                            oelTransaction.Discount = Validation.GetSafeDecimal(objReader["Disc"]);
                            //oelTransaction.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                            oelTransaction.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                        }
                        oelTransaction.IdAccount = Validation.GetSafeLong(objReader["Item_Id"]);
                        //oelTransaction.unitprice = Convert.ToDecimal(objReader["unitprice"]);
                    }
                    if (VoucherType == "PurchaseReturnVoucher")
                    {
                        if (objReader["VoucherDetail_Id"] != DBNull.Value)
                        {

                            oelTransaction.IdDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"].ToString());
                            oelTransaction.Discription = Validation.GetSafeString(objReader["Discription"]);
                            oelTransaction.PackingSize = Validation.GetSafeString(objReader["PackingSize"]);
                            //oelTransaction.BatchNo = Validation.GetSafeString(objReader["BatchNo"]);
                            oelTransaction.Qty = Validation.GetSafeInteger(objReader["units"]);
                            //oelTransaction.Bonus = Validation.GetSafeLong(objReader["Bonus"]);
                            oelTransaction.unitprice = Validation.GetSafeDecimal(objReader["UnitPrice"]);
                            oelTransaction.Discount = Validation.GetSafeDecimal(objReader["Disc"]);
                            //oelTransaction.Expiry = Validation.GetSafeString(objReader["Expiry"]);
                            oelTransaction.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                        }
                        oelTransaction.IdAccount = Validation.GetSafeLong(objReader["Item_Id"]);
                        //oelTransaction.unitprice = Convert.ToDecimal(objReader["unitprice"]);
                    }
                    else if (VoucherType == "JournalVoucher" || VoucherType == "PaymentVoucher" || VoucherType == "CashReceiptVoucher" || VoucherType == VoucherTypes.BankPaymentVoucher.ToString() || VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
                    {
                        oelTransaction.IdDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                        oelTransaction.TransactionID = Validation.GetSafeLong(objReader["Transaction_Id"]);
                        oelTransaction.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                        oelTransaction.IdAccount = Validation.GetSafeLong(objReader["Account_Id"]);
                        oelTransaction.Debit = Convert.ToDecimal(objReader["Debit"]);
                        oelTransaction.Credit = Convert.ToDecimal(objReader["Credit"]);
                        oelTransaction.Discription = Validation.GetSafeString(objReader["Description"]);
                    }
                    //oelTransaction.PersonName = objReader["PersonName"].ToString();
                    oelTransactionCollection.Add(oelTransaction);
                }
            }
            return oelTransactionCollection;
        }
        public List<TransactionsEL> GetAlternateTransactionsByVoucherAndType(Int64 IdCompany, Int64? IdVoucher, Int64 VoucherNo, string VoucherType, SqlConnection objConn)
        {
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            using (SqlCommand cmdTransaction = new SqlCommand("[Transactions].[Proc_GetAlternateTransactionsByVoucherAndType]", objConn))
            {
                cmdTransaction.CommandType = CommandType.StoredProcedure;
                cmdTransaction.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdTransaction.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher.Value;
                cmdTransaction.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
                cmdTransaction.Parameters.Add("@VoucherType", SqlDbType.NVarChar).Value = VoucherType;
                objReader = cmdTransaction.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    //oelTransaction.TransactionID = new Guid(objReader["Transaction_Id"].ToString());

                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = objReader["AccountName"].ToString();
                    //oelTransaction.Date = Convert.ToDateTime(objReader["VDate"]);
                    //oelTransaction.VoucherNo = Convert.ToInt32(objReader["VoucherNo"]);

                    oelTransaction.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                    //oelTransaction.Description = objReader["Description"].ToString();
                    // oelTransaction.Amount = Convert.ToDecimal(objReader["Amount"]);                   
                    if (VoucherType == "JournalVoucher" || VoucherType == "PaymentVoucher" || VoucherType == "CashReceiptVoucher" || VoucherType == VoucherTypes.BankPaymentVoucher.ToString() || VoucherType == VoucherTypes.BankReceiptVoucher.ToString())
                    {
                        oelTransaction.IdDetail = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                        oelTransaction.TransactionID = Validation.GetSafeLong(objReader["Transaction_Id"]);
                        oelTransaction.Amount = Validation.GetSafeDecimal(objReader["Amount"]);
                        oelTransaction.IdAccount = Validation.GetSafeLong(objReader["Account_Id"]);
                        oelTransaction.Debit = Convert.ToDecimal(objReader["Debit"]);
                        oelTransaction.Credit = Convert.ToDecimal(objReader["Credit"]);
                        oelTransaction.Discription = Validation.GetSafeString(objReader["Description"]);
                    }
                    //oelTransaction.PersonName = objReader["PersonName"].ToString();
                    oelTransactionCollection.Add(oelTransaction);
                }
            }
            return oelTransactionCollection;
        }
        public List<VouchersEL> GetUnPostedVouchers(Int64 IdCompany, string VoucherType, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdUnPostedVouchers = new SqlCommand("[Transactions].[Proc_GetUnPostedVouchers]", objConn))
            {
                cmdUnPostedVouchers.CommandType = CommandType.StoredProcedure;
                cmdUnPostedVouchers.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdUnPostedVouchers.Parameters.Add("@VoucherType", SqlDbType.NVarChar).Value = VoucherType;
                objReader = cmdUnPostedVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL obj = new VouchersEL();
                    obj.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
                    obj.Date = Convert.ToDateTime(objReader["VDate"]);
                    if (VoucherType != "JournalVoucher" && VoucherType != "BankPaymentVoucher" && VoucherType != "BankReceiptVoucher" && VoucherType != "PaymentVoucher"
                        && VoucherType != "CashReceiptVoucher")
                    {
                        obj.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                        obj.PersonName = Convert.ToString(objReader["AccountName"]);
                    }
                    obj.Amount = Convert.ToDecimal(objReader["Amount"]);
                    if (VoucherType == "BankPaymentVoucher")
                    {
                        //obj.ChequeNo = objReader["ChequeNo"].ToString();
                    }
                    else if (VoucherType == "BankReceiptVoucher")
                    {
                        //obj.ChequeNo = objReader["ChequeNo"].ToString();
                    }
                    list.Add(obj);
                }
            }
            return list;
        }
        public EntityoperationInfo PostUnPostedVouchers(string VoucherType, Int64 VoucherNo, Int64 IdCompany, SqlConnection objConn)
        {
            int status;
            EntityoperationInfo resultInfo = new EntityoperationInfo();
            using (SqlCommand cmdPostVoucher = new SqlCommand("[Transactions].[Proc_PostUnpostedVouchers]", objConn))
            {
                try
                {
                    cmdPostVoucher.CommandType = CommandType.StoredProcedure;
                    cmdPostVoucher.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                    cmdPostVoucher.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = VoucherNo;
                    cmdPostVoucher.Parameters.Add(new SqlParameter("@VoucherType", DbType.Int64)).Value = VoucherType;
                    status = cmdPostVoucher.ExecuteNonQuery();
                    if (status > -1)
                    {
                        resultInfo.IsSuccess = true;
                    }
                    else
                    {
                        resultInfo.IsSuccess = false;
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return resultInfo;
        }
        public List<TransactionsEL> GetTransactions(Int64? IdVoucher, string VoucherType, Int64 IdCompany, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSaleCustomer = new SqlCommand("[Transactions].[Proc_GetTransactions]", objConn))
            {
                cmdSaleCustomer.CommandType = CommandType.StoredProcedure;
                cmdSaleCustomer.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSaleCustomer.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher.Value;
                cmdSaleCustomer.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                objReader = cmdSaleCustomer.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.TransactionID = Validation.GetSafeLong(objReader["transaction_id"]);
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.SubAccountNo = Validation.GetSafeString(objReader["EmpCode"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public EntityoperationInfo UpdateDaysStatus(VouchersEL oelVoucher, int IsSale, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlTransaction objTran = objConn.BeginTransaction();
            SqlCommand cmdVoucherHead = new SqlCommand("[Transactions].[Proc_UpdateDaysStatus]", objConn);
            try
            {
                cmdVoucherHead.Transaction = objTran;
                cmdVoucherHead.CommandType = CommandType.StoredProcedure;


                cmdVoucherHead.Parameters.Add(new SqlParameter("@IdCompany", DbType.Guid)).Value = oelVoucher.IdCompany;
                cmdVoucherHead.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelVoucher.VoucherNo;
                cmdVoucherHead.Parameters.Add(new SqlParameter("@IsSale", DbType.Int32)).Value = IsSale;

                cmdVoucherHead.ExecuteNonQuery();

                objTran.Commit();

                infoResult.IsSuccess = true;
            }
            catch (Exception ex)
            {
                objTran.Rollback();
                throw ex;
            }



            return infoResult;
        }
        public bool CheckVoucherNo(Int64? IdCompany, Int64 VoucherNo, string VoucherType, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            SqlCommand cmdVoucherHead = new SqlCommand("[Transactions].[Proc_CheckVoucherNo]", objConn);
            cmdVoucherHead.CommandType = CommandType.StoredProcedure;
            List<VouchersEL> list = new List<VouchersEL>();

            cmdVoucherHead.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany.Value;
            cmdVoucherHead.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = VoucherNo;
            cmdVoucherHead.Parameters.Add(new SqlParameter("@VoucherType", DbType.Int32)).Value = VoucherType;
            objReader = cmdVoucherHead.ExecuteReader();
            while (objReader.Read())
            {
                VouchersEL oelVoucher = new VouchersEL();
                oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                list.Add(oelVoucher);
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
        public List<VouchersEL> GetFirstVoucherTransactionByType(Int64 IdProject, Int64 BookNo, string VoucherType, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetFirstVoucherTransactionByType]", objConn);

            cmdVouchers.CommandType = CommandType.StoredProcedure;
            cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
            objReader = cmdVouchers.ExecuteReader();
            while (objReader.Read())
            {
                VouchersEL oelVoucher = new VouchersEL();

                oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                //oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                //oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                //oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                //oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                //oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                //oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                //oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                list.Add(oelVoucher);
            }
            return list;
        }
        public List<VouchersEL> GetLastVoucherTransactionByType(Int64 IdProject, Int64 BookNo, string VoucherType, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetLastVoucherTransactionByType]", objConn);

            cmdVouchers.CommandType = CommandType.StoredProcedure;
            cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
            objReader = cmdVouchers.ExecuteReader();
            while (objReader.Read())
            {
                VouchersEL oelVoucher = new VouchersEL();

                oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                //oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                //oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                //oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                //oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                //oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                //oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                //oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                list.Add(oelVoucher);
            }
            return list;
        }
        public Int64 GetTransactionalVoucherIdByVoucherNoForPaging(Int64 IdProject, Int64 BookNo, Int64 VoucherNo, string VoucherType, SqlConnection objConn)
        {
            SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetTransactionalVoucherIdByVoucherNo]", objConn);

            cmdVouchers.CommandType = CommandType.StoredProcedure;
            cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdVouchers.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
            cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
            return Validation.GetSafeLong(cmdVouchers.ExecuteScalar());

        }

        #region All Stock Vouchers
        public List<VouchersEL> GetAllStockTransactionalVouchersByTypeAndDate(Int64 IdProject, Int64 BookNo, string VoucherType, DateTime VoucherDate, bool? IsNetTransaction, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllStockTransactionalVouchersByTypeAndDate]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                cmdVouchers.Parameters.Add("@VDate", SqlDbType.DateTime).Value = VoucherDate;
                cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Address = Validation.GetSafeString(objReader["Address"]);
                    oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetAllStockTransactionalVouchersByTypeAndEditedDate(Int64 IdProject, Int64 BookNo, string VoucherType, DateTime VoucherDate, bool? IsNetTransaction, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllStockTransactionalVouchersByTypeAndEditedDate]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                cmdVouchers.Parameters.Add("@VDate", SqlDbType.DateTime).Value = VoucherDate;
                cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Address = Validation.GetSafeString(objReader["Address"]);
                    oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetAllStockTransactionalVoucherByTypeAndAccountNo(Int64 IdProject, Int64 BookNo, string AccountNo, string VoucherType, bool? IsNetTransaction, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllStockTransactionalVoucherByTypeAndAccountNo]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;

                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Address = Validation.GetSafeString(objReader["CustomerAddress"]);
                    oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelVoucher.VDiscription = Validation.GetSafeString(objReader["VDiscription"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public List<VouchersEL> GetAllStockTransactionalVoucherByType(Int64 IdProject, Int64 BookNo, string VoucherType, bool? IsNetTransaction, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllStockTransactionalVoucherByType]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;

                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VouchersEL oelVoucher = new VouchersEL();

                    oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                    oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelVoucher.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelVoucher.Address = Validation.GetSafeString(objReader["CustomerAddress"]);
                    //oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                    oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    oelVoucher.IsDeleted = Validation.GetSafeBooleanNullable(objReader["IsDeleted"]);
                    list.Add(oelVoucher);
                }
            }
            return list;
        }
        public Int64 GetAllStockTotalTransactionalVouchersByType(Int64 IdProject, Int64 BookNo, string VoucherType, bool? IsNetTransaction, SqlConnection objConn)
        {
            SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetAllStockTotalTransactionalVouchersByType]", objConn);

            cmdVouchers.CommandType = CommandType.StoredProcedure;
            cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
            //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
            return Validation.GetSafeLong(cmdVouchers.ExecuteScalar());
        }
        public List<VouchersEL> GetStockLastVoucherTransactionByType(Int64 IdProject, Int64 BookNo, string VoucherType, bool? IsNetTransaction, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetStockLastVoucherTransactionByType]", objConn);

            cmdVouchers.CommandType = CommandType.StoredProcedure;
            cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
            cmdVouchers.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
            //cmdVouchers.Parameters.Add("@IsNetTransaction", SqlDbType.Bit).Value = IsNetTransaction;
            objReader = cmdVouchers.ExecuteReader();
            while (objReader.Read())
            {
                VouchersEL oelVoucher = new VouchersEL();

                oelVoucher.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                oelVoucher.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                oelVoucher.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                //oelVoucher.TerminalNumber = Validation.GetSafeInteger(objReader["TerminalNo"]);
                //oelVoucher.UserName = Validation.GetSafeString(objReader["UserName"]);
                //oelVoucher.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                //oelVoucher.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                //oelVoucher.ChequeNo = Validation.GetSafeString(objReader["ChequeNo"]);
                //oelVoucher.Discription = Validation.GetSafeString(objReader["Discription"]);
                //oelVoucher.Amount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                //oelVoucher.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                list.Add(oelVoucher);
            }
            return list;
        }
        #endregion
        #region Customers Invoices
        public List<VoucherDetailEL> GetCustomersInvoices(string AccountNo, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<VoucherDetailEL> list = new List<VoucherDetailEL>();
            using (SqlCommand cmdVouchers = new SqlCommand("[Transactions].[Proc_GetCustomersActiveInvoices]", objConn))
            {
                cmdVouchers.CommandType = CommandType.StoredProcedure;
                cmdVouchers.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdVouchers.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdVouchers.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdVouchers.ExecuteReader();
                while (objReader.Read())
                {
                    VoucherDetailEL obj = new VoucherDetailEL();
                    obj.IdVoucher = Validation.GetSafeLong(objReader["Voucher_Id"]);
                    obj.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    obj.VDate = Validation.GetSafeNullableDateTime(objReader["VDate"]);
                    obj.DueDate = Validation.GetSafeNullableDateTime(objReader["DueDate"]);
                    obj.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    obj.Balance = Validation.GetSafeDecimal(objReader["PreviousBalance"]);
                    obj.VoucherType = Validation.GetSafeString(objReader["InvoiceType"]);

                    list.Add(obj);
                }
            }
            return list;
        }
        public EntityoperationInfo UpdateCustomerInvoicePreviousBalance(Int64 IdVoucher, decimal NewBalance, SqlConnection objConn)
        {
            lock (this)
            {
                EntityoperationInfo infoResult = new EntityoperationInfo();
                SqlCommand cmdVoucher = new SqlCommand("[Transactions].[Proc_UpdateCustomerInvoicePreviousBalance]", objConn);
                try
                {
                    cmdVoucher.CommandType = CommandType.StoredProcedure;

                    cmdVoucher.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = IdVoucher;
                    cmdVoucher.Parameters.Add(new SqlParameter("@NewBalance", DbType.Decimal)).Value = NewBalance;

                    cmdVoucher.ExecuteNonQuery();

                    infoResult.IsSuccess = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }

                return infoResult;
            }
        }
        #endregion
    }
}
