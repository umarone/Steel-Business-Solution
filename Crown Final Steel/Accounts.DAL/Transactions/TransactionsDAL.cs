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
    public class TransactionsDAL
    {
        IDataReader objReader;
        public static bool InsertTransactions(TransactionsEL oelTransactions, SqlConnection oConn)
        {
            using (SqlCommand cmdTransactions = new SqlCommand("sp_insertTransactions", oConn))
            {
                cmdTransactions.CommandType = CommandType.StoredProcedure;
                cmdTransactions.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelTransactions.AccountNo;
                cmdTransactions.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelTransactions.SubAccountNo;
                cmdTransactions.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelTransactions.Date;
                cmdTransactions.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelTransactions.Seq;
                cmdTransactions.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelTransactions.VoucherNo;
                cmdTransactions.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelTransactions.Description;
                cmdTransactions.Parameters.Add(new SqlParameter("@Amount", DbType.Decimal)).Value = oelTransactions.Amount;
                cmdTransactions.Parameters.Add(new SqlParameter("@Qty", DbType.Decimal)).Value = oelTransactions.Qty;
                cmdTransactions.Parameters.Add(new SqlParameter("@Type", DbType.String)).Value = oelTransactions.VoucherType;
                //cmdTransactions.Parameters.Add(new SqlParameter("@Posted", DbType.String)).Value = oelTransactions.Posted;
                cmdTransactions.ExecuteNonQuery();
                return true;

            }
        }
        public void InsertTransactions(List<TransactionsEL> oelTransactionsCollection, Int64? IdVoucher, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdTransactions = new SqlCommand("[Transactions].[Proc_CreateTransactions]", objConn);
            cmdTransactions.CommandType = CommandType.StoredProcedure;
            cmdTransactions.Transaction = objTran;
            for (int i = 0; i < oelTransactionsCollection.Count; i++)
            {
                cmdTransactions.Parameters.Add(new SqlParameter("@IdTransaction", DbType.Int64)).Value = oelTransactionsCollection[i].TransactionID;
                cmdTransactions.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelTransactionsCollection[i].IdCompany;
                if (IdVoucher == 0)
                {
                    cmdTransactions.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelTransactionsCollection[i].IdVoucher;
                }
                else
                {
                    cmdTransactions.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = IdVoucher;
                }
                cmdTransactions.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelTransactionsCollection[i].AccountNo;
                cmdTransactions.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelTransactionsCollection[i].SubAccountNo;
                cmdTransactions.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelTransactionsCollection[i].Date;
                cmdTransactions.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelTransactionsCollection[i].Seq;
                cmdTransactions.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelTransactionsCollection[i].Description;
                cmdTransactions.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelTransactionsCollection[i].Debit;
                cmdTransactions.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelTransactionsCollection[i].Credit;
                cmdTransactions.Parameters.Add(new SqlParameter("@VType", DbType.String)).Value = oelTransactionsCollection[i].VoucherType;
                cmdTransactions.Parameters.Add(new SqlParameter("@SettlementType", DbType.String)).Value = oelTransactionsCollection[i].SettlementType;
                cmdTransactions.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelTransactionsCollection[i].Posted;

                cmdTransactions.ExecuteNonQuery();
                cmdTransactions.Parameters.Clear();
            }
        }
        public void UpdateTransactions(List<TransactionsEL> oelTransactionsCollection, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdTransactions = new SqlCommand();
            cmdTransactions.CommandType = CommandType.StoredProcedure;
            cmdTransactions.Transaction = objTran;
            cmdTransactions.Connection = objConn;
            for (int i = 0; i < oelTransactionsCollection.Count; i++)
            {
                if (oelTransactionsCollection[i].IsNew)
                {
                    cmdTransactions.CommandText = "[Transactions].[Proc_CreateTransactions]";
                }
                else
                {
                    cmdTransactions.CommandText = "[Transactions].[Proc_UpdateTransactions]";
                }
                cmdTransactions.Parameters.Add(new SqlParameter("@IdTransaction", DbType.Int64)).Value = oelTransactionsCollection[i].TransactionID;
                cmdTransactions.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelTransactionsCollection[i].IdCompany;
                cmdTransactions.Parameters.Add(new SqlParameter("@IdVoucher", DbType.Int64)).Value = oelTransactionsCollection[i].IdVoucher;
                cmdTransactions.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelTransactionsCollection[i].AccountNo;
                cmdTransactions.Parameters.Add(new SqlParameter("@EmpCode", DbType.String)).Value = oelTransactionsCollection[i].SubAccountNo;
                cmdTransactions.Parameters.Add(new SqlParameter("@VDate", DbType.DateTime)).Value = oelTransactionsCollection[i].Date;
                cmdTransactions.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelTransactionsCollection[i].Seq;
                cmdTransactions.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelTransactionsCollection[i].Description;
                cmdTransactions.Parameters.Add(new SqlParameter("@Debit", DbType.Decimal)).Value = oelTransactionsCollection[i].Debit;
                cmdTransactions.Parameters.Add(new SqlParameter("@Credit", DbType.Decimal)).Value = oelTransactionsCollection[i].Credit;
                cmdTransactions.Parameters.Add(new SqlParameter("@VType", DbType.String)).Value = oelTransactionsCollection[i].VoucherType;
                cmdTransactions.Parameters.Add(new SqlParameter("@SettlementType", DbType.String)).Value = oelTransactionsCollection[i].SettlementType;
                cmdTransactions.Parameters.Add(new SqlParameter("@Posted", DbType.Boolean)).Value = oelTransactionsCollection[i].Posted;

                cmdTransactions.ExecuteNonQuery();
                cmdTransactions.Parameters.Clear();
            }
        }
        public static bool UpdateTransactions(TransactionsEL oelTransactions, SqlConnection oConn)
        {
            using (SqlCommand cmdTransactions = new SqlCommand("sp_updateTransactions", oConn))
            {
                cmdTransactions.CommandType = CommandType.StoredProcedure;
                cmdTransactions.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelTransactions.AccountNo;
                cmdTransactions.Parameters.Add(new SqlParameter("@Date", DbType.DateTime)).Value = oelTransactions.Date;
                cmdTransactions.Parameters.Add(new SqlParameter("@Seq", DbType.Int32)).Value = oelTransactions.Seq;
                cmdTransactions.Parameters.Add(new SqlParameter("@VoucherNo", DbType.Int64)).Value = oelTransactions.VoucherNo;
                cmdTransactions.Parameters.Add(new SqlParameter("@Description", DbType.String)).Value = oelTransactions.Description;
                cmdTransactions.Parameters.Add(new SqlParameter("@Ammount", DbType.Decimal)).Value = oelTransactions.Amount;
                cmdTransactions.Parameters.Add(new SqlParameter("@Qty", DbType.Decimal)).Value = oelTransactions.Qty;
                cmdTransactions.Parameters.Add(new SqlParameter("@Type", DbType.String)).Value = oelTransactions.VoucherType;
                cmdTransactions.Parameters.Add(new SqlParameter("@Posted", DbType.String)).Value = oelTransactions.Posted;
                cmdTransactions.ExecuteNonQuery();
                return true;

            }
        }
        public bool DeleteTransactions(Int64? IdVoucher, string TransactionType, Int64 IdCompany, SqlConnection objConn, SqlTransaction objTran)
        {
            SqlCommand cmdDeleteTransaction = new SqlCommand("[Transactions].[Proc_DeleteTransaction]", objConn, objTran);
            cmdDeleteTransaction.CommandType = CommandType.StoredProcedure;
          
            cmdDeleteTransaction.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
            cmdDeleteTransaction.Parameters.Add("@IdVoucher", SqlDbType.BigInt).Value = IdVoucher.Value;
            cmdDeleteTransaction.Parameters.Add("@TransactionType", SqlDbType.VarChar).Value = TransactionType;
            cmdDeleteTransaction.ExecuteNonQuery();

            //cmdDeleteTransaction.ExecuteNonQuery();
            
            return true;
        }
        
        public Int64 GetItemCount(string AccountNo, Int64 VoucherNo, string TransactionType, SqlConnection objconn)
        {
            SqlCommand cmdItemCount = new SqlCommand("sp_GetItemCount", objconn);
            cmdItemCount.CommandType = CommandType.StoredProcedure;
            cmdItemCount.Parameters.Add("@VoucherNo", SqlDbType.NVarChar).Value = VoucherNo;
            cmdItemCount.Parameters.Add("@AccountNo", SqlDbType.NVarChar).Value = AccountNo;
            cmdItemCount.Parameters.Add("@TransactionType", SqlDbType.NVarChar).Value = TransactionType;
            return Convert.ToInt64(cmdItemCount.ExecuteScalar());

        }
        public List<TransactionsEL> GetAccountInTransaction(String AccountNo, SqlConnection objConn)
        {
            List<TransactionsEL> oelTransactionCollection = new List<TransactionsEL>();
            using (SqlCommand cmdTransaction = new SqlCommand("sp_CheckAccountInTransaction", objConn))
            {
                try
                {
                    cmdTransaction.CommandType = CommandType.StoredProcedure;
                    cmdTransaction.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                    objReader = cmdTransaction.ExecuteReader();
                    while (objReader.Read())
                    {
                        TransactionsEL obj = new TransactionsEL();
                        obj.TransactionID = Validation.GetSafeLong(objReader["Transaction_Id"]);
                        obj.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);

                        oelTransactionCollection.Add(obj);
                    }
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return oelTransactionCollection;
        }
        public List<TransactionsEL> ListDailySale(DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdDailySale = new SqlCommand("sp_GetDailySale", objConn))
            {
                cmdDailySale.CommandType = CommandType.StoredProcedure;
                cmdDailySale.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdDailySale.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdDailySale.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();
                    obj.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
                    obj.Debit = Convert.ToInt64(objReader["Sale"]);
                    obj.Credit = Convert.ToInt64(objReader["CostOfGoods"]);
                    obj.Amount = Convert.ToInt64(objReader["Profit"]);

                    list.Add(obj);
                }
            }

            return list;
        }
        public List<TransactionsEL> GetHeadAccountTransactionId(Int64 VoucherNo, string VoucherType, string AccountNo, Int64 IdCompany, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdTransaction = new SqlCommand("[Transactions].[Proc_GetHeadAccountTransactionId]", objConn))
            {
                cmdTransaction.CommandType = CommandType.StoredProcedure;
                cmdTransaction.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdTransaction.Parameters.Add("@VoucherNo", SqlDbType.BigInt).Value = VoucherNo;
                cmdTransaction.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdTransaction.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VoucherType;
                objReader = cmdTransaction.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.TransactionID = Validation.GetSafeLong(objReader["transaction_id"]);
                    oelTransaction.Date = Convert.ToDateTime(objReader["Vdate"]);
                    list.Add(oelTransaction);
                }
            }
            return list;
        }
            
        
        public List<TransactionsEL> GetMiniTrialBalance(Int64 IdCompany, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdTrial = new SqlCommand("[Transactions].[Proc_GetMiniTrialBalance]", objConn))
            {
                cmdTrial.CommandType = CommandType.StoredProcedure;
                cmdTrial.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                objReader = cmdTrial.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelTransaction.ClosingBalance = oelTransaction.Debit - oelTransaction.Credit;
                    oelTransaction.VoucherType = Validation.GetSafeString(objReader["Type"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetDateWiseMiniTrialBalance(Int64 IdCompany, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdTrial = new SqlCommand("[Transactions].[Proc_GetDateWiseMiniTrialBalance]", objConn))
            {
                cmdTrial.CommandType = CommandType.StoredProcedure;
                cmdTrial.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdTrial.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdTrial.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdTrial.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    //oelTransaction.OpeningBalance = Validation.GetSafeDecimal(objReader["OpeningBalance"]);
                    oelTransaction.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelTransaction.OpeningBalance = Validation.GetSafeDecimal(objReader["OpeningDebit"]);
                    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelTransaction.Amount = Validation.GetSafeDecimal(objReader["OpeningCredit"]);
                    oelTransaction.ClosingBalance = (oelTransaction.Debit + oelTransaction.OpeningBalance) - (oelTransaction.Credit + oelTransaction.Amount);
                    oelTransaction.VoucherType = Validation.GetSafeString(objReader["Type"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetEmployeesTransactions(Int64 IdCompany, string EmpCode, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSalesMan = new SqlCommand("[Transactions].[Proc_GetEmployeesTransactions]", objConn))
            {
                cmdSalesMan.CommandType = CommandType.StoredProcedure;
                
                cmdSalesMan.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSalesMan.Parameters.Add("@EmpCode", SqlDbType.VarChar).Value = EmpCode;

                objReader = cmdSalesMan.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.TotalSales = Validation.GetSafeLong(objReader["TotalSales"]);
                    oelTransaction.TotalRecieveables = Validation.GetSafeLong(objReader["Receivables"]);
                    oelTransaction.TotalRecieved = Validation.GetSafeLong(objReader["TotalRecieved"]);
                    oelTransaction.TotalReturns = Validation.GetSafeLong(objReader["TotalReturns"]);
                    oelTransaction.TotalPayables = Validation.GetSafeLong(objReader["ReturnAmount"]);
                    oelTransaction.OpeningBalance = Validation.GetSafeLong(objReader["OpeningBalance"]);
                    oelTransaction.ClosingBalance = Validation.GetSafeLong(objReader["Closing"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetDateWiseEmployeesTransactions(Int64 IdCompany, string EmpCode, DateTime startDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSalesMan = new SqlCommand("[Transactions].[Proc_GetDateWiseEmployeesTransactions]", objConn))
            {
                cmdSalesMan.CommandType = CommandType.StoredProcedure;

                cmdSalesMan.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
                cmdSalesMan.Parameters.Add("@EmpCode", SqlDbType.VarChar).Value = EmpCode;
                cmdSalesMan.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
                cmdSalesMan.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;

                objReader = cmdSalesMan.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.OpeningBalance = Validation.GetSafeLong(objReader["Opening"]);
                    oelTransaction.TotalSales = Validation.GetSafeLong(objReader["TotalSales"]);
                    oelTransaction.TotalRecieveables = Validation.GetSafeLong(objReader["Receivables"]);
                    oelTransaction.TotalRecieved = Validation.GetSafeLong(objReader["TotalRecieved"]);
                    oelTransaction.TotalReturns = Validation.GetSafeLong(objReader["TotalReturns"]);
                    oelTransaction.TotalPayables = Validation.GetSafeLong(objReader["ReturnAmount"]);
                    oelTransaction.ClosingBalance = (oelTransaction.OpeningBalance + oelTransaction.TotalRecieveables) - (oelTransaction.TotalRecieved - oelTransaction.TotalPayables); 

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        #region Accounts Financial Ledger Reporting Section
        public List<TransactionsEL> GetClosingBalanceByAccount(Int64 IdProject, Int64 BookNo, string AccountNo, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdTrial = new SqlCommand("[Transactions].[Proc_GetClosingBalanceByAccount]", objConn))
            {
                cmdTrial.CommandType = CommandType.StoredProcedure;
                cmdTrial.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdTrial.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdTrial.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdTrial.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
                    oelTransaction.BalanceType = Validation.GetSafeString(objReader["BalanceType"]);
                    oelTransaction.TypedClosingBalance = oelTransaction.ClosingBalance + " " + oelTransaction.BalanceType;
                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetUnPostedClosingBalanceByAccount(Int64 IdProject, Int64 BookNo, string AccountNo, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdTrial = new SqlCommand("[Transactions].[Proc_GetUnPostedClosingBalanceByAccount]", objConn))
            {
                cmdTrial.CommandType = CommandType.StoredProcedure;
                cmdTrial.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdTrial.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdTrial.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdTrial.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
                    oelTransaction.BalanceType = Validation.GetSafeString(objReader["BalanceType"]);
                    oelTransaction.TypedClosingBalance = oelTransaction.ClosingBalance + " " + oelTransaction.BalanceType;
                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetAccountsBalance(string AccountType, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdAccountsBalance = new SqlCommand("[Reports].[Proc_GetClosingBalances]", objConn))
            {
                cmdAccountsBalance.CommandType = CommandType.StoredProcedure;
                cmdAccountsBalance.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdAccountsBalance.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdAccountsBalance.Parameters.Add("@AccountType", SqlDbType.VarChar).Value = AccountType;
                objReader = cmdAccountsBalance.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
                    oelTransaction.BalanceType = Validation.GetSafeString(objReader["BalanceType"]);
                    
                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetDateWiseAccountsBalance(string AccountType, Int64 IdProject, Int64 BookNo , DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdAccountsBalance = new SqlCommand("[Reports].[Proc_GetDateWiseClosingBalances]", objConn))
            {
                cmdAccountsBalance.CommandType = CommandType.StoredProcedure;
                cmdAccountsBalance.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdAccountsBalance.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdAccountsBalance.Parameters.Add("@AccountType", SqlDbType.VarChar).Value = AccountType;
                cmdAccountsBalance.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdAccountsBalance.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdAccountsBalance.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.OpeningBalance = Validation.GetSafeDecimal(objReader["Opening"]);
                    oelTransaction.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
                    oelTransaction.BalanceType = Validation.GetSafeString(objReader["BalanceType"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        //public List<TransactionsEL> GetLedgerByAccount(string AccountNo, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        public DataTable GetLedgerByAccount(string AccountNo, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdAccountLedger = new SqlCommand("[Reports].[Proc_GetLedgerByAccount]", objConn))
            {
                cmdAccountLedger.CommandType = CommandType.StoredProcedure;
                cmdAccountLedger.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdAccountLedger.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdAccountLedger.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdAccountLedger);
                da.Fill(dt);
                return dt;
                //objReader = cmdAccountLedger.ExecuteReader();
                //while (objReader.Read())
                //{
                //    TransactionsEL oelTransaction = new TransactionsEL();
                //    oelTransaction.TransactionID = Validation.GetSafeLong(objReader["VoucherDetail_Id"]);
                //    oelTransaction.Discription = Validation.GetSafeString(objReader["Narration"]);
                //    oelTransaction.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                //    oelTransaction.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                //    oelTransaction.VoucherType = Validation.GetSafeString(objReader["LedgerVoucherNo"]);
                //    oelTransaction.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                //    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                //    oelTransaction.Balance = Validation.GetSafeDecimal(objReader["RunningBalance"]);
                //    oelTransaction.TransactionMode = Validation.GetSafeString(objReader["BType"]);
                //    oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
                //    oelTransaction.BalanceType = Validation.GetSafeString(objReader["FinalBalanceType"]);

                    
                //    list.Add(oelTransaction);
                //}
            }
            //return list;
        }
        //public List<TransactionsEL> GetDateWiseLedgerByAccount(string AccountNo, Int64 IdProject, Int64 BookNo, DateTime StartPeriod, DateTime ToPeriod, SqlConnection objConn)
        public DataTable GetDateWiseLedgerByAccount(string AccountNo, Int64 IdProject, Int64 BookNo, DateTime StartPeriod, DateTime ToPeriod, SqlConnection objConn)
        {
            //List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdAccountLedger = new SqlCommand("[Reports].[Proc_GetDateWiseLedgerByAccount]", objConn))
            {
                cmdAccountLedger.CommandType = CommandType.StoredProcedure;               
                cmdAccountLedger.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdAccountLedger.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdAccountLedger.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdAccountLedger.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartPeriod;
                cmdAccountLedger.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = ToPeriod;
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmdAccountLedger);
                da.Fill(dt);
                return dt;
            //    objReader = cmdAccountLedger.ExecuteReader();
            //    while (objReader.Read())
            //    {
            //        TransactionsEL oelTransaction = new TransactionsEL();
            //        oelTransaction.Discription = Validation.GetSafeString(objReader["Narration"]);
            //        oelTransaction.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
            //        oelTransaction.VoucherType = Validation.GetSafeString(objReader["LedgerVoucherNo"]);
            //        oelTransaction.OpeningBalance = Validation.GetSafeDecimal(objReader["Opening"]);
            //        oelTransaction.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
            //        oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
            //        oelTransaction.Balance = Validation.GetSafeDecimal(objReader["RunningBalance"]);
            //        oelTransaction.TransactionMode = Validation.GetSafeString(objReader["BType"]);
            //        oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
            //        oelTransaction.BalanceType = Validation.GetSafeString(objReader["FinalBalanceType"]);
            //        list.Add(oelTransaction);
            //    }
            }
            //return list;
        }
        #endregion
        #region Accounts Financial Trial Balance Reporting Section
        public List<TransactionsEL> GetTrialBalance(Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdTrial = new SqlCommand("[Transactions].[Proc_GetTrialBalance]", objConn))
            {
                cmdTrial.CommandType = CommandType.StoredProcedure;
                cmdTrial.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdTrial.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                objReader = cmdTrial.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetDateWiseTrialBalance(Int64 IdProject, Int64 BookNo,DateTime StartPeriod, DateTime ToPeriod, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdDateWiseTrial = new SqlCommand("[Transactions].[Proc_GetDateWiseTrialBalance]", objConn))
            {
                cmdDateWiseTrial.CommandType = CommandType.StoredProcedure;
                cmdDateWiseTrial.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdDateWiseTrial.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdDateWiseTrial.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartPeriod;
                cmdDateWiseTrial.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = ToPeriod;
                objReader = cmdDateWiseTrial.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.OpeningBalance = Validation.GetSafeDecimal(objReader["OpeningBalance"]);
                    if (oelTransaction.OpeningBalance > 0)
                    {
                        oelTransaction.DebitX = oelTransaction.OpeningBalance;
                    }
                    else
                    {
                        oelTransaction.CreditX = oelTransaction.OpeningBalance;
                    }
                    oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
                    oelTransaction.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    list.Add(oelTransaction);
                }
            }
            return list;
        }  
        #endregion
        #region Accounts Financial Balance Sheet Section
        public List<TransactionsEL> GetBalanceSheetAccountsBalances(Int64 IdProject, Int64 BookNo, int IdHead, string AccountType, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdBalanceSheetAccounts = new SqlCommand("[Reports].[Proc_GetClosingBalancesByHead]", objConn))
            {
                cmdBalanceSheetAccounts.CommandType = CommandType.StoredProcedure;
                cmdBalanceSheetAccounts.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdBalanceSheetAccounts.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdBalanceSheetAccounts.Parameters.Add("@IdHead", SqlDbType.Int).Value = IdHead;
                cmdBalanceSheetAccounts.Parameters.Add("@AccountType", SqlDbType.VarChar).Value = AccountType;
                objReader = cmdBalanceSheetAccounts.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
                    oelTransaction.BalanceType = Validation.GetSafeString(objReader["BalanceType"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        #endregion
        #region Customers Financial Recovery Reports
        public List<TransactionsEL> GetCustomerRecoveryReport(Int64 IdProject, Int64 BookNo, string AccountNo, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdReoveryReport = new SqlCommand("[Transactions].[Proc_GetCustomerRecoveryReport]", objConn))
            {
                cmdReoveryReport.CommandType = CommandType.StoredProcedure;
                cmdReoveryReport.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdReoveryReport.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdReoveryReport.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                objReader = cmdReoveryReport.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.Credit = Convert.ToDecimal(objReader["Credit"]);
                    oelTransaction.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelTransaction.Description = objReader["Narration"].ToString();
                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetCustomerRecoveryReportByDate(Int64 IdProject, Int64 BookNo,string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdRecoveryReport = new SqlCommand("[Transactions].[Proc_GetCustomerRecoveryReportByDate]", objConn))
            {
                cmdRecoveryReport.CommandType = CommandType.StoredProcedure;
                cmdRecoveryReport.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdRecoveryReport.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdRecoveryReport.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdRecoveryReport.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdRecoveryReport.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdRecoveryReport.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    oelTransaction.Date = Convert.ToDateTime(objReader["VDate"]);
                    oelTransaction.Description = Validation.GetSafeString(objReader["Narration"]);
                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetAllCustomersRecoveryReport(Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdReoveryReport = new SqlCommand("[Transactions].[Proc_GetAllCustomersRecoveryReport]", objConn))
            {
                cmdReoveryReport.CommandType = CommandType.StoredProcedure;
                cmdReoveryReport.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdReoveryReport.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                objReader = cmdReoveryReport.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.Credit = Convert.ToDecimal(objReader["Credit"]);
                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetAllCustomersByRecoveryReportByDate(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdRecoveryReport = new SqlCommand("[Transactions].[Proc_GetAllCustomersRecoveryReportByDate]", objConn))
            {
                cmdRecoveryReport.CommandType = CommandType.StoredProcedure;
                cmdRecoveryReport.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdRecoveryReport.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdRecoveryReport.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdRecoveryReport.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdRecoveryReport.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.Credit = Convert.ToDecimal(objReader["Credit"]);
                    list.Add(oelTransaction);
                }
            }
            return list;
        }

        #endregion
        #region Expenses Reports
        public List<TransactionsEL> ListExpenses(Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetExpensesDetail]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();
                    obj.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    obj.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    obj.Debit = Validation.GetSafeDecimal(objReader["Debit"]);

                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> ListExpensesByDate(DateTime StartDate, DateTime EndDate, Int64 IdProject, Int64 BookNo, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetExpensesDetailByDate]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                //cmdExpenses.Parameters.Add("@AccountNo", SqlDbType.NVarChar).Value = AccountNo;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdExpenses.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();
                    obj.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    //obj.VoucherNo = Convert.ToInt64(objReader["VoucherNo"]);
                    obj.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    obj.Description = Validation.GetSafeString(objReader["Discription"]);
                    obj.VDate = Convert.ToDateTime(objReader["VDate"]);
                    list.Add(obj);
                }
            }
            return list;
        }

        public List<TransactionsEL> GetSubHeadWiseExpenseReport(Int64 IdProject, Int64 BookNo, string AccountType, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetSubHeadWiseExpenseReport]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@AccountType", SqlDbType.VarChar).Value = AccountType;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();
                    obj.IdAccount = Validation.GetSafeInteger(objReader["Account_Id"]);
                    obj.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    obj.Amount = Validation.GetSafeDecimal(objReader["Debit"]);
                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetDateWiseSubHeadWiseExpenseReport(Int64 IdProject, Int64 BookNo, string AccountType, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetDateWiseSubHeadWiseExpenseReport]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdExpenses.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                cmdExpenses.Parameters.Add("@AccountType", SqlDbType.VarChar).Value = AccountType;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();
                    obj.IdAccount = Validation.GetSafeInteger(objReader["Account_Id"]);
                    obj.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    obj.Amount = Validation.GetSafeDecimal(objReader["Debit"]);
                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetSubHeadWiseDetailExpenseReport(Int64 IdAccount, Int64 IdProject, Int64 BookNo, string AccountType, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetSubHeadWiseDetailExposeReport]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdAccount", SqlDbType.BigInt).Value = IdAccount;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@AccountType", SqlDbType.VarChar).Value = AccountType;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();
                    obj.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    obj.AccountName = Validation.GetSafeString(objReader["Accountname"]);
                    obj.Amount = Validation.GetSafeDecimal(objReader["Debit"]);
                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetDateWiseSubHeadWiseDetailExpenseReport(Int64 IdAccount, Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, string AccountType, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetDateWiseSubHeadWiseDetailExposeReport]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdAccount", SqlDbType.BigInt).Value = IdAccount;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdExpenses.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                cmdExpenses.Parameters.Add("@AccountType", SqlDbType.VarChar).Value = AccountType;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();
                    obj.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    obj.AccountName = Validation.GetSafeString(objReader["Accountname"]);
                    obj.Amount = Validation.GetSafeDecimal(objReader["Debit"]);
                    list.Add(obj);
                }
            }
            return list;
        }
        #endregion
        #region Aging Reports
        public List<TransactionsEL> GetAgingReport(Int64 IdProject, Int64 BookNo, DateTime startDate, DateTime EndDate, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdSalesMan = new SqlCommand("[Transactions].[Proc_GetAgingReport]", objConn))
            {
                cmdSalesMan.CommandType = CommandType.StoredProcedure;

                cmdSalesMan.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdSalesMan.Parameters.Add("@BookNo", SqlDbType.VarChar).Value = BookNo;
                cmdSalesMan.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = startDate;
                cmdSalesMan.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;

                objReader = cmdSalesMan.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();
                    oelTransaction.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelTransaction.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    oelTransaction.Address = Validation.GetSafeString(objReader["CustomerAddress"]);
                    oelTransaction.TotalSales = Validation.GetSafeDecimal(objReader["TotalSales"]);
                    oelTransaction.ClosingBalance = Validation.GetSafeDecimal(objReader["ClosingBalance"]);
                    oelTransaction.CreatedDateTime = Validation.GetSafeNullableDateTime(objReader["LastInvoiceDate"]);
                    oelTransaction.VDate = Validation.GetSafeNullableDateTime(objReader["LastPaymentDate"]);
                    oelTransaction.Credit = Validation.GetSafeDecimal(objReader["LastPaymentAmount"]);
                    oelTransaction.Transactiondays = Validation.GetSafeLong(objReader["LateDays"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        #endregion
        #region Business Volume Reports
        public List<TransactionsEL> DayStartBusinessVolume(Int64 IdProject, Int64 BookNo, DateTime StartDate, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_DayStartBusinessVolume]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();

                    obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                    obj.Amount = Validation.GetSafeDecimal(objReader["Amount"]);                    

                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> DayEndBusinessVolume(Int64 IdProject, Int64 BookNo, DateTime StartDate, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_DayEndBusinessVolume]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();

                    obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                    obj.Amount = Validation.GetSafeDecimal(objReader["Amount"]);

                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetDayBookByDate(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetDayBookByDate]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdExpenses.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();

                    obj.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    obj.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                    obj.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    obj.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    obj.SeqNo = Validation.GetSafeInteger(objReader["SerialNo"]);
                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetDayBookDetailByDate(Int64 IdProject, Int64 BookNo, DateTime StartDate, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetDayBookDetailByDate]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();

                    //obj.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    //obj.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    obj.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                    obj.VoucherType = Validation.GetSafeString(objReader["TransactionType"]);
                    obj.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    obj.Debit = Validation.GetSafeDecimal(objReader["Debit"]);
                    obj.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    obj.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    obj.SeqNo = Validation.GetSafeInteger(objReader["SerialNo"]);
                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetCashBookDetailByDate(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetCashBookDetailByDate]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdExpenses.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();

                    obj.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    obj.VDate = Validation.GetSafeDateTime(objReader["VDate"]);
                    obj.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                    obj.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    obj.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);
                    obj.SeqNo = Validation.GetSafeInteger(objReader["SerialNo"]);
                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetCashPaidExpenseByDate(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetCashPaidExpenseByDate]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdExpenses.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();


                    obj.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    obj.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    list.Add(obj);
                }
            }
            return list;
        }
        #endregion
        #region Daily Business Activity Reports
        public List<TransactionsEL> GetDailyBusinessStockActivity(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetDailyBusinessStockActivity]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdExpenses.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();

                    obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                    obj.Debit = Validation.GetSafeDecimal(objReader["Net"]);
                    obj.DebitCount = Validation.GetSafeLong(objReader["NetCount"]);
                    obj.Credit = Validation.GetSafeDecimal(objReader["Credit"]);
                    obj.CreditCount = Validation.GetSafeLong(objReader["Creditcount"]);
                    obj.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);

                    list.Add(obj);
                }
            }
            return list;
        }
        public List<TransactionsEL> GetDailyBusinessFinancialActivity(Int64 IdProject, Int64 BookNo, DateTime StartDate, DateTime EndDate, SqlConnection objConn)
        {

            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdExpenses = new SqlCommand("[Transactions].[Proc_GetDailyBusinessFinancialActivity]", objConn))
            {
                cmdExpenses.CommandType = CommandType.StoredProcedure;
                cmdExpenses.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdExpenses.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdExpenses.Parameters.Add("@StartDate", SqlDbType.DateTime).Value = StartDate;
                cmdExpenses.Parameters.Add("@EndDate", SqlDbType.DateTime).Value = EndDate;
                objReader = cmdExpenses.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL obj = new TransactionsEL();

                    obj.Discription = Validation.GetSafeString(objReader["Discription"]);
                    obj.Amount = Validation.GetSafeDecimal(objReader["TotalPayment"]);
                    obj.CreditCount = Validation.GetSafeLong(objReader["PaymentCount"]);
                    obj.TotalAmount = Validation.GetSafeDecimal(objReader["TotalReceipts"]);
                    obj.DebitCount = Validation.GetSafeLong(objReader["ReceiptsCount"]);

                    list.Add(obj);
                }
            }
            return list;
        }
        #endregion
    }
}
