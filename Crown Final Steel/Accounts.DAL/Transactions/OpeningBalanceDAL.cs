using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

using Accounts.EL;
using Accounts.Common;

namespace Accounts.DAL
{
    public class OpeningBalanceDAL
    {
        IDataReader objReader;
        TransactionsDAL dal;
        Int64? IdVoucher = 0;
        public OpeningBalanceDAL()
        {
            dal = new TransactionsDAL();
        }        
        public EntityoperationInfo InsertOpeningBalance(List<OpeningBalanceEL> oelOpeninBalanceCollection, SqlConnection objConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            SqlCommand cmdOpeningBalance = new SqlCommand("[Transactions].[Proc_CreateOpeningBalance]", objConn);
            try
            {
                oTran = objConn.BeginTransaction();
                for (int i = 0; i < oelOpeninBalanceCollection.Count; i++)
                {
                    cmdOpeningBalance.Transaction = oTran;
                    cmdOpeningBalance.CommandType = CommandType.StoredProcedure;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdOpeningBalance", DbType.Int64)).Value = oelOpeninBalanceCollection[i].IdOpeningBalance;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelOpeninBalanceCollection[i].IdProject;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelOpeninBalanceCollection[i].UserId;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelOpeninBalanceCollection[i].BookNo;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelOpeninBalanceCollection[i].AccountNo;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelOpeninBalanceCollection[i].EmpCode;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelOpeninBalanceCollection[i].Discription;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelOpeninBalanceCollection[i].Amount;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelOpeninBalanceCollection[i].Debit;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelOpeninBalanceCollection[i].Credit;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@TransactionMode", DbType.Decimal)).Value = oelOpeninBalanceCollection[i].TransactionMode;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelOpeninBalanceCollection[i].OpeningBalanceDate;
                    cmdOpeningBalance.ExecuteNonQuery();
                    cmdOpeningBalance.Parameters.Clear();
                    
                }

                //dal.InsertTransactions(oelTransactionsCollection,0, objConn, oTran);

                oTran.Commit();
                InfoResult.IsSuccess = true;
            }
            catch (Exception ex)
            {
                oTran.Rollback();
                throw ex;
            }



            return InfoResult;
        }      
        public EntityoperationInfo UpdateOpeningBalance(List<OpeningBalanceEL> oelOpeningBalanceCollection, SqlConnection objConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            SqlCommand cmdOpeningBalance = new SqlCommand("[Transactions].[Proc_UpdateOpeningBalance]", objConn);
            
                try
                {
                    oTran = objConn.BeginTransaction();
                    cmdOpeningBalance.Transaction = oTran;
                    for (int i = 0; i < oelOpeningBalanceCollection.Count; i++)
                    {
                        if (oelOpeningBalanceCollection[i].IsNew)
                        {
                            cmdOpeningBalance.CommandText = "[Transactions].[Proc_CreateOpeningBalance]";
                        }
                        else
                        { 
                            cmdOpeningBalance.CommandText = "[Transactions].[Proc_UpdateOpeningBalance]";
                        }
                        cmdOpeningBalance.CommandType = CommandType.StoredProcedure;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdOpeningBalance", DbType.Int64)).Value = oelOpeningBalanceCollection[i].IdOpeningBalance;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelOpeningBalanceCollection[i].IdProject;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelOpeningBalanceCollection[i].UserId;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelOpeningBalanceCollection[i].BookNo;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelOpeningBalanceCollection[i].AccountNo;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelOpeningBalanceCollection[i].EmpCode;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelOpeningBalanceCollection[i].Discription;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelOpeningBalanceCollection[i].Amount;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelOpeningBalanceCollection[i].Debit;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelOpeningBalanceCollection[i].Credit;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@TransactionMode", DbType.Decimal)).Value = oelOpeningBalanceCollection[i].TransactionMode;
                        cmdOpeningBalance.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelOpeningBalanceCollection[i].OpeningBalanceDate;
                        
                        cmdOpeningBalance.ExecuteNonQuery();
                        
                        cmdOpeningBalance.Parameters.Clear();

                    }                  
                    oTran.Commit();                    
                }
                catch (Exception ex)
                {
                    oTran.Rollback();
                    throw ex;
                }
                InfoResult.IsSuccess = true;            

            return InfoResult;
        }
        public EntityoperationInfo InsertUpdateOpeningBalance(List<OpeningBalanceEL> oelOpeningBalanceCollection, SqlConnection objConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            SqlTransaction oTran = null;
            SqlCommand cmdOpeningBalance = new SqlCommand("[Transactions].[Proc_UpdateOpeningBalance]", objConn);

            try
            {
                oTran = objConn.BeginTransaction();
                cmdOpeningBalance.Transaction = oTran;
                for (int i = 0; i < oelOpeningBalanceCollection.Count; i++)
                {
                    if (oelOpeningBalanceCollection[i].IsNew)
                    {
                        cmdOpeningBalance.CommandText = "[Transactions].[Proc_CreateOpeningBalance]";
                    }
                    else
                    {
                        cmdOpeningBalance.CommandText = "[Transactions].[Proc_UpdateOpeningBalance]";
                    }
                    cmdOpeningBalance.CommandType = CommandType.StoredProcedure;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdOpeningBalance", DbType.Int64)).Value = oelOpeningBalanceCollection[i].IdOpeningBalance;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelOpeningBalanceCollection[i].IdProject;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelOpeningBalanceCollection[i].UserId;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = oelOpeningBalanceCollection[i].BookNo;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelOpeningBalanceCollection[i].AccountNo;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelOpeningBalanceCollection[i].EmpCode;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelOpeningBalanceCollection[i].Discription;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelOpeningBalanceCollection[i].Amount;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelOpeningBalanceCollection[i].Debit;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelOpeningBalanceCollection[i].Credit;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@TransactionMode", DbType.Decimal)).Value = oelOpeningBalanceCollection[i].TransactionMode;
                    cmdOpeningBalance.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelOpeningBalanceCollection[i].OpeningBalanceDate;

                    cmdOpeningBalance.ExecuteNonQuery();

                    cmdOpeningBalance.Parameters.Clear();

                }
                oTran.Commit();
            }
            catch (Exception ex)
            {
                oTran.Rollback();
                throw ex;
            }
            InfoResult.IsSuccess = true;

            return InfoResult;
        }
        public List<OpeningBalanceEL> GetOpeningBalance(Int64 IdProject, Int64 BookNo, string AccountNo, SqlConnection objConn)
        {
            List<OpeningBalanceEL> list = new List<OpeningBalanceEL>();
            using (SqlCommand cmdOpeningBalance = new SqlCommand("[Transactions].[Proc_GetOpeningBalance]", objConn))
            {
                cmdOpeningBalance.CommandType = CommandType.StoredProcedure;
                cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
                cmdOpeningBalance.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = BookNo;
                cmdOpeningBalance.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdOpeningBalance.ExecuteReader();
                while (objReader.Read())
                {
                    OpeningBalanceEL oelOpeningBalance = new OpeningBalanceEL();
                    oelOpeningBalance.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelOpeningBalance.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelOpeningBalance.Amount = Convert.ToDecimal(objReader["Amount"]);
                    oelOpeningBalance.IdOpeningBalance = Validation.GetSafeLong(objReader["OpeningBalance_Id"]);
                    oelOpeningBalance.IdHead = Validation.GetSafeInteger(objReader["Head_Id"]);
                    oelOpeningBalance.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelOpeningBalance.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelOpeningBalance.OpeningBalanceDate = Convert.ToDateTime(objReader["VDate"]);
                    oelOpeningBalance.Discription = Validation.GetSafeString(objReader["Discription"]);
                    list.Add(oelOpeningBalance);
                }
            }
            return list;
        }
        public List<OpeningBalanceEL> GetOpeningBalancesByType(Int64 IdProject, Int64 BookNo, string OpeningType, SqlConnection objConn)
        {
            List<OpeningBalanceEL> list = new List<OpeningBalanceEL>();
            using (SqlCommand cmdOpeningBalance = new SqlCommand("[Transactions].[proc_GetOpeningBalancesByType]", objConn))
            {
                cmdOpeningBalance.CommandType = CommandType.StoredProcedure;
                cmdOpeningBalance.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
                cmdOpeningBalance.Parameters.Add(new SqlParameter("@BookNo", DbType.Int64)).Value = BookNo;
                cmdOpeningBalance.Parameters.Add("@Type", SqlDbType.NVarChar).Value = OpeningType;
                objReader = cmdOpeningBalance.ExecuteReader();
                while (objReader.Read())
                {
                    OpeningBalanceEL oelOpeningBalance = new OpeningBalanceEL();
                    oelOpeningBalance.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelOpeningBalance.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelOpeningBalance.Amount = Convert.ToDecimal(objReader["Amount"]);
                    //oelOpeningBalance.Discription = Validation.GetSafeString(objReader["Discription"]);
                    oelOpeningBalance.Discription = Validation.GetSafeString(objReader["PersonAddress"]);
                    oelOpeningBalance.TransactionMode = Validation.GetSafeString(objReader["TransactionMode"]);
                    list.Add(oelOpeningBalance);
                }
            }
            return list;
        }
        public EntityoperationInfo DeleteOpeningBalance(string AccountNo, Guid IdTransaction, Int64 IdCompany, SqlConnection objConn)
        {
            EntityoperationInfo DeleteInfo = new EntityoperationInfo();
            int rowseffected = -1;
            using (SqlTransaction oTran = objConn.BeginTransaction())
            {
                SqlCommand cmdDelete = new SqlCommand("[Transactions].[Proc_deleteOpeningBalance]", objConn);
                cmdDelete.CommandType = CommandType.StoredProcedure;
                cmdDelete.Transaction = oTran;
                cmdDelete.Parameters.Add("@IdTransaction", SqlDbType.UniqueIdentifier).Value = IdTransaction;
                cmdDelete.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdDelete.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;

                rowseffected = cmdDelete.ExecuteNonQuery();

                if (rowseffected > -1)
                {
                    oTran.Commit();
                    DeleteInfo.IsSuccess = true;
                }
                else
                {
                    oTran.Rollback();
                    DeleteInfo.IsSuccess = false;
                }
            }
            return DeleteInfo;
        }
    }
}
