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
    public class AccountsDAL
    {
        IDataReader ObjReader;
        public EntityoperationInfo InsertChartsOfAccounts(AccountsEL oelChartsOfAccounts, SqlConnection oConn)
        {
            lock (this)
            {
                EntityoperationInfo InfoResult = new EntityoperationInfo();
                using (SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_CreateAccounts]", oConn))
                {
                    cmdAccounts.CommandType = CommandType.StoredProcedure;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdAccount", DbType.Int64)).Value = oelChartsOfAccounts.IdAccount;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdParent", DbType.Int64)).Value = oelChartsOfAccounts.IdParent;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelChartsOfAccounts.IdCompany;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelChartsOfAccounts.IdProject;
                    cmdAccounts.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelChartsOfAccounts.AccountNo;
                    cmdAccounts.Parameters.Add(new SqlParameter("@PersonalAccountNo", DbType.String)).Value = oelChartsOfAccounts.PersonalAccountNo;
                    cmdAccounts.Parameters.Add(new SqlParameter("@AccountName", DbType.String)).Value = oelChartsOfAccounts.AccountName;
                    cmdAccounts.Parameters.Add(new SqlParameter("@AccountType", DbType.String)).Value = oelChartsOfAccounts.AccountType;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdLevel", DbType.Int32)).Value = oelChartsOfAccounts.IdLevel;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdHead", DbType.Int32)).Value = oelChartsOfAccounts.IdHead;
                    cmdAccounts.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelChartsOfAccounts.Discription;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelChartsOfAccounts.UserId;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IsSystemHead", DbType.Boolean)).Value = oelChartsOfAccounts.IsSystemAccount;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelChartsOfAccounts.IsActive;
                    cmdAccounts.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelChartsOfAccounts.CreatedDateTime;

                    if (cmdAccounts.ExecuteNonQuery() > -1)
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
        }
        public EntityoperationInfo UpdateChartsOfAccounts(AccountsEL oelChartsOfAccounts, SqlConnection oConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_UpdateAccounts]", oConn))
            {
                cmdAccounts.CommandType = CommandType.StoredProcedure;
                cmdAccounts.Parameters.Add(new SqlParameter("@IdAccount", DbType.Int64)).Value = oelChartsOfAccounts.IdAccount;
                cmdAccounts.Parameters.Add(new SqlParameter("@IdParent", DbType.Int64)).Value = oelChartsOfAccounts.IdParent;
                cmdAccounts.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelChartsOfAccounts.IdCompany;
                cmdAccounts.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelChartsOfAccounts.IdProject;
                cmdAccounts.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelChartsOfAccounts.AccountNo;
                cmdAccounts.Parameters.Add(new SqlParameter("@PersonalAccountNo", DbType.String)).Value = oelChartsOfAccounts.PersonalAccountNo;
                cmdAccounts.Parameters.Add(new SqlParameter("@AccountName", DbType.String)).Value = oelChartsOfAccounts.AccountName;
                cmdAccounts.Parameters.Add(new SqlParameter("@AccountType", DbType.String)).Value = oelChartsOfAccounts.AccountType;
                cmdAccounts.Parameters.Add(new SqlParameter("@IdLevel", DbType.Int32)).Value = oelChartsOfAccounts.IdLevel;
                cmdAccounts.Parameters.Add(new SqlParameter("@IdHead", DbType.Int32)).Value = oelChartsOfAccounts.IdHead;
                cmdAccounts.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelChartsOfAccounts.Discription;
                cmdAccounts.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelChartsOfAccounts.UserId;
                cmdAccounts.Parameters.Add(new SqlParameter("@IsSystemHead", DbType.Boolean)).Value = oelChartsOfAccounts.IsSystemAccount;
                cmdAccounts.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelChartsOfAccounts.IsActive;
                cmdAccounts.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelChartsOfAccounts.CreatedDateTime;
                //cmdAccounts.ExecuteNonQuery();
                if (cmdAccounts.ExecuteNonQuery() > -1)
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
        public List<AccountsEL> GetAccountsByParent(Int64? IdParent, Int64? IdProject, Int64 IdCompany, int IdLevel, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_GetAccountsByParent]", objConn);
            cmdAccounts.CommandType = CommandType.StoredProcedure;
            cmdAccounts.Parameters.Add("@IdParent", SqlDbType.BigInt).Value = IdParent;
            cmdAccounts.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
            cmdAccounts.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdAccounts.Parameters.Add("@IdLevel", SqlDbType.Int).Value = IdLevel;
            ObjReader = cmdAccounts.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccounts = new AccountsEL();
                oelAccounts.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccounts.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccounts.IdCompany = Validation.GetSafeLong(ObjReader["Company_Id"]);
                oelAccounts.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccounts.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccounts.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccounts.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccounts.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccounts.Discription = Validation.GetSafeString(ObjReader["Discription"]);
                oelAccounts.IsSystemAccount = Validation.GetSafeBooleanNullable(ObjReader["IsSystemAccount"]);
                oelAccounts.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                oelAccounts.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                oelAccounts.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);


                list.Add(oelAccounts);
            }
            return list;
        }
        public List<AccountsEL> GetAccountByLevel(int IdLevel, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdAsset = new SqlCommand("[Setup].[Proc_GetAccountsByLevel]", objConn);
            cmdAsset.CommandType = CommandType.StoredProcedure;
            cmdAsset.Parameters.Add("@IdLevel", SqlDbType.Int).Value = IdLevel;
            ObjReader = cmdAsset.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccounts = new AccountsEL();
                oelAccounts.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccounts.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccounts.IdCompany = Validation.GetSafeLong(ObjReader["Company_Id"]);
                oelAccounts.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccounts.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccounts.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccounts.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccounts.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccounts.Discription = Validation.GetSafeString(ObjReader["Discription"]);
                oelAccounts.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                oelAccounts.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                oelAccounts.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);


                list.Add(oelAccounts);

            }
            return list;
        }
        public List<AccountsEL> GetAccountsById(Int64? IdAccount, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdAsset = new SqlCommand("[Setup].[Proc_GetAccountById]", objConn);
            cmdAsset.CommandType = CommandType.StoredProcedure;
            cmdAsset.Parameters.Add("@IdAccount", SqlDbType.BigInt).Value = IdAccount;
            ObjReader = cmdAsset.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccounts = new AccountsEL();
                oelAccounts.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccounts.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccounts.IdCompany = Validation.GetSafeLong(ObjReader["Company_Id"]);
                oelAccounts.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccounts.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccounts.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccounts.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccounts.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccounts.Discription = Validation.GetSafeString(ObjReader["Discription"]);
                oelAccounts.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                oelAccounts.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                oelAccounts.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);


                list.Add(oelAccounts);
            }
            return list;
        }
        public List<AccountsEL> GetAccountsByType(string AccountType, Int64 IdCompany, Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdAsset = new SqlCommand("[Setup].[Proc_getAccountByAccountType]", objConn);
            cmdAsset.CommandType = CommandType.StoredProcedure;
            cmdAsset.Parameters.Add("@AccountType", SqlDbType.VarChar).Value = AccountType;
            cmdAsset.Parameters.Add("@IdCompany", SqlDbType.BigInt).Value = IdCompany;
            cmdAsset.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            ObjReader = cmdAsset.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccounts = new AccountsEL();
                oelAccounts.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccounts.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccounts.IdCompany = Validation.GetSafeLong(ObjReader["Company_Id"]);
                oelAccounts.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccounts.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccounts.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccounts.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccounts.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccounts.Discription = Validation.GetSafeString(ObjReader["Discription"]);
                oelAccounts.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                oelAccounts.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                oelAccounts.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);


                list.Add(oelAccounts);

            }
            return list;
        }
        public List<AccountsLevels> GetParentHeads(SqlConnection objConn)
        {
            List<AccountsLevels> list = new List<AccountsLevels>();
            SqlCommand cmdParents = new SqlCommand("[Setup].[Proc_GetParentHeads]", objConn);
            cmdParents.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdParents.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsLevels objlevel = new AccountsLevels();
                objlevel.IdParent1 = Validation.GetSafeInteger(ObjReader["Parent1_Id"]);
                objlevel.Parent1_Name = Validation.GetSafeString(ObjReader["Parent1_Name"]);
                list.Add(objlevel);
            }
            return list;
        }
        public List<AccountsLevels> GetCategoryHeadsByParent(int IdParent, SqlConnection objConn)
        {
            List<AccountsLevels> list = new List<AccountsLevels>();
            SqlCommand cmdParent = new SqlCommand("[Setup].[Proc_GetCategoryHeadsByParent]", objConn);
            cmdParent.CommandType = CommandType.StoredProcedure;
            cmdParent.Parameters.Add(new SqlParameter("@IdParent", DbType.Int32)).Value = IdParent;
            ObjReader = cmdParent.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsLevels objLevel = new AccountsLevels();
                objLevel.IdParent2 = Validation.GetSafeInteger(ObjReader["Parent2_Id"]);
                objLevel.Parent2_Name = Validation.GetSafeString(ObjReader["Parent2_Name"]);
                list.Add(objLevel);
            }
            return list;
        }       
        public string GetMaxAccountNo(int IdParent1, int IdParent2, int IdParent3, int IdLevel,Int64 IdProject, Int64 IdParent, SqlConnection objConn)
        {
            SqlCommand cmdAccount = new SqlCommand("[Setup].[Proc_GetMaxAccountNo]", objConn);
            cmdAccount.CommandType = CommandType.StoredProcedure;
            cmdAccount.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdAccount.Parameters.Add(new SqlParameter("@IdParent", DbType.Int64)).Value = IdParent;
            cmdAccount.Parameters.Add("@IdParent1", SqlDbType.Int).Value = IdParent1;
            cmdAccount.Parameters.Add("@IdParent2", SqlDbType.Int).Value = IdParent2;
            cmdAccount.Parameters.Add("@IdParent3", SqlDbType.Int).Value = IdParent3;
            cmdAccount.Parameters.Add("@IdLevel", SqlDbType.Int).Value = IdLevel;
            return Validation.GetSafeString(cmdAccount.ExecuteScalar());

        }
        public List<AccountsEL> SearchAccountsByAccountNo(Int64 AccountNo,Int64 IdCompany, Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("[Setup].[Proc_SearchAccountsByAccountNo]", objConn);
            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdSearchAccount.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdSearchAccount.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccount = new AccountsEL();
                oelAccount.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccount.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccount.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccount.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccount.Address = Validation.GetSafeString(ObjReader["Address"]);
                oelAccount.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccount.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccount.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccount.Discription = Validation.GetSafeString(ObjReader["Discription"]);

                list.Add(oelAccount);
            }
            return list;
        }
        public List<AccountsEL> SearchAccountsByPersonalAccountNo(Int64 AccountNo, Int64 IdCompany, Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("[Setup].[Proc_SearchAccountsByPersonalAccountNo]", objConn);
            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdSearchAccount.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdSearchAccount.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccount = new AccountsEL();
                oelAccount.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccount.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccount.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccount.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccount.Address = Validation.GetSafeString(ObjReader["Address"]);
                oelAccount.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccount.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccount.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccount.Discription = Validation.GetSafeString(ObjReader["Discription"]);

                list.Add(oelAccount);
            }
            return list;
        }
        public List<AccountsEL> SearchAccountByAccountName(string AccountName, Int64 IdCompany, Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("[Setup].[Proc_SearchAccountsByAccountName]", objConn);
            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdSearchAccount.Parameters.Add("@AccountName", SqlDbType.VarChar).Value = AccountName;
            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            ObjReader = cmdSearchAccount.ExecuteReader();
            while (ObjReader.Read())
            {
                
                AccountsEL oelAccount = new AccountsEL();
                oelAccount.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccount.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccount.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccount.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccount.Address = Validation.GetSafeString(ObjReader["Address"]);
                oelAccount.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccount.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccount.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccount.Discription = Validation.GetSafeString(ObjReader["Discription"]);

                list.Add(oelAccount);
            }
            return list;
        }
        public List<ItemsEL> SearchStockAccountByAccountNo(Int64 AccountNo,Guid IdCompany, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("[Setup].[Proc_SearchStockAccountsByAccountNo]", objConn);
           
            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Guid)).Value = IdCompany;
            cmdSearchAccount.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
            
            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchAccount.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdAccount = Validation.GetSafeLong(oReader["Account_Id"]);
                oelItems.AccountNo = Validation.GetSafeString(oReader["AccountNo"]);
                oelItems.AccountName = Validation.GetSafeString(oReader["AccountName"]);
                oelItems.AccountType = Validation.GetSafeString(oReader["AccountType"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;
        }
        public List<ItemsEL> SearchStockAccountByAccountName(string AccountName, Guid IdCompany, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("[Setup].[Proc_SearchStockAccountsByAccountName]", objConn);

            cmdSearchAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Guid)).Value = IdCompany;
            cmdSearchAccount.Parameters.Add("@AccountName", SqlDbType.VarChar).Value = AccountName;
            
            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchAccount.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
                oelItems.IdAccount = Validation.GetSafeLong(oReader["Account_Id"]);
                oelItems.AccountNo = Validation.GetSafeString(oReader["AccountNo"]);
                oelItems.AccountName = Validation.GetSafeString(oReader["AccountName"]);
                oelItems.AccountType = Validation.GetSafeString(oReader["AccountType"]);
                if (oReader["packingsize"] != DBNull.Value)
                {
                    oelItems.PackingSize = Validation.GetSafeString(oReader["packingsize"]);
                }
                else
                {
                    oelItems.PackingSize = "N/A";
                }
                list.Add(oelItems);
            }
            return list;            
        }
        public bool CheckAccount(Int64 AccountNo,Int64 IdCompany, Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            using (SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_CheckAccount]", objConn))
            {
                cmdAccounts.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
                cmdAccounts.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
                cmdAccounts.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;

                cmdAccounts.CommandType = CommandType.StoredProcedure;
                SqlDataReader objReader = cmdAccounts.ExecuteReader();
                while (objReader.Read())
                {
                    AccountsEL oelChartOfAccount = new AccountsEL();
                    oelChartOfAccount.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                    oelChartOfAccount.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                    list.Add(oelChartOfAccount);
                }
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
        public List<AccountsEL> GetAccount(string AccountNo,Int64 IdCompany, Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdSubCategory = new SqlCommand("[Setup].[Proc_GetAccount]", objConn);
            cmdSubCategory.CommandType = CommandType.StoredProcedure;

            cmdSubCategory.Parameters.Add(new SqlParameter("@IdCompany", DbType.String)).Value = IdCompany;
            cmdSubCategory.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdSubCategory.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;

            ObjReader = cmdSubCategory.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccount = new AccountsEL();
                oelAccount.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccount.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccount.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccount.PersonalAccountNo = Validation.GetSafeString(ObjReader["PersonalAccountNo"]);
                oelAccount.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccount.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccount.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccount.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccount.Discription = Validation.GetSafeString(ObjReader["Discription"]);
                oelAccount.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);

                list.Add(oelAccount);
            }
            return list;
        }
        public List<AccountsEL> GetAccountsById(int IdParent, Int64 IdCompany, Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdSubCategory = new SqlCommand("[Setup].[Proc_GetAccountsById]", objConn);
            cmdSubCategory.CommandType = CommandType.StoredProcedure;

            cmdSubCategory.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            cmdSubCategory.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
            cmdSubCategory.Parameters.Add("@IdParent", SqlDbType.BigInt).Value = IdParent;

            ObjReader = cmdSubCategory.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccount = new AccountsEL();
                oelAccount.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccount.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccount.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccount.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccount.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccount.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccount.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccount.Discription = Validation.GetSafeString(ObjReader["Discription"]);

                list.Add(oelAccount);
            }
            return list;
        }
        public List<AccountsEL> GetAllAccounts(Int64 IdCompany, Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_GetAllAccounts]", objConn);
            cmdAccounts.CommandType = CommandType.StoredProcedure;

            cmdAccounts.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            cmdAccounts.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;

            ObjReader = cmdAccounts.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccounts = new AccountsEL();
                oelAccounts.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccounts.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccounts.IdCompany = Validation.GetSafeLong(ObjReader["Company_Id"]);
                oelAccounts.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccounts.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccounts.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccounts.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccounts.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccounts.Discription = Validation.GetSafeString(ObjReader["Discription"]);
                oelAccounts.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                oelAccounts.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                oelAccounts.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);

                list.Add(oelAccounts);
            }
            return list;
        }
        public List<AccountsEL> GetAllInActiveAccounts(Int64 IdCompany, Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_GetAllInActiveAccounts]", objConn);
            cmdAccounts.CommandType = CommandType.StoredProcedure;

            cmdAccounts.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
            cmdAccounts.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;

            ObjReader = cmdAccounts.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccounts = new AccountsEL();
                oelAccounts.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccounts.IdParent = Validation.GetSafeLong(ObjReader["Parent_Id"]);
                oelAccounts.IdCompany = Validation.GetSafeLong(ObjReader["Company_Id"]);
                oelAccounts.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
                oelAccounts.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccounts.AccountType = Validation.GetSafeString(ObjReader["AccountType"]);
                oelAccounts.IdLevel = Validation.GetSafeInteger(ObjReader["Level_Id"]);
                oelAccounts.IdHead = Validation.GetSafeInteger(ObjReader["Head_Id"]);
                oelAccounts.Discription = Validation.GetSafeString(ObjReader["Discription"]);
                oelAccounts.IsActive = Validation.GetSafeBooleanNullable(ObjReader["IsActive"]);
                oelAccounts.UserId = Validation.GetSafeLong(ObjReader["User_Id"]);
                oelAccounts.CreatedDateTime = Validation.GetSafeDateTime(ObjReader["Created_DateTime"]);

                list.Add(oelAccounts);
            }
            return list;
        }
        public List<AccountsEL> GetEmployeesAccounts(Int64 IdProject, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdAccount = new SqlCommand("[Setup].[Proc_GetEmployeesAccounts]", objConn);
            cmdAccount.CommandType = CommandType.StoredProcedure;

            cmdAccount.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;


            ObjReader = cmdAccount.ExecuteReader();
            while (ObjReader.Read())
            {
                AccountsEL oelAccounts = new AccountsEL();
               
                oelAccounts.IdAccount = Validation.GetSafeLong(ObjReader["Account_Id"]);
                oelAccounts.AccountNo = Validation.GetSafeString(ObjReader["AccountNo"]);
                oelAccounts.AccountName = Validation.GetSafeString(ObjReader["AccountName"]);
               
                list.Add(oelAccounts);
            }
            return list;
        }
        public EntityoperationInfo DeleteChartOfAccount(Int64 IdAccount, SqlConnection objConn)
        {
            EntityoperationInfo deleteInfo = new EntityoperationInfo();
            int rowsEffected = -1;
            using (SqlCommand cmdDeleteAccount = new SqlCommand("[Setup].[Proc_DeleteAccount]", objConn))
            {
                cmdDeleteAccount.CommandType = CommandType.StoredProcedure;
                cmdDeleteAccount.Parameters.Add("@IdAccount", SqlDbType.BigInt).Value = IdAccount;
                rowsEffected = Convert.ToInt32(cmdDeleteAccount.ExecuteNonQuery());
                if (rowsEffected > -1)
                {
                    deleteInfo.IsSuccess = true;
                }
                else
                {
                    deleteInfo.IsSuccess = false;
                }
            }
            return deleteInfo;
        }
        public bool DeletePersonAccount(Int32 IdAccount, SqlConnection objConn)
        {
            using (SqlTransaction oTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteAccount = new SqlCommand("[Setup].[Proc_DeleteAccount]", objConn);
                    cmdDeleteAccount.Transaction = oTran;
                    cmdDeleteAccount.CommandType = CommandType.StoredProcedure;
                    cmdDeleteAccount.Parameters.Add("@IdAccount", SqlDbType.BigInt).Value = IdAccount;
                    cmdDeleteAccount.ExecuteNonQuery();

                    SqlCommand cmdDeletePerson = new SqlCommand();
                    cmdDeletePerson.CommandText = "[Setup].[Proc_DeletePersons]";
                    //if (PersonType == 1)
                    //{
                    //    cmdDeletePerson.CommandText = "sp_deleteCustomers";
                    //}
                    //else if (PersonType == 2)
                    //{
                    //    cmdDeletePerson.CommandText = "sp_deleteSuppliers";
                    //}
                    //else
                    //{
                    //    cmdDeletePerson.CommandText = "sp_deleteEmployees";
                    //}
                    cmdDeletePerson.Connection = objConn;
                    cmdDeletePerson.CommandType = CommandType.StoredProcedure;
                    cmdDeletePerson.Transaction = oTran;
                    cmdDeletePerson.Parameters.Add("@IdAccount", SqlDbType.UniqueIdentifier).Value = IdAccount;
                    cmdDeletePerson.ExecuteNonQuery();

                    oTran.Commit();
                }
                catch (Exception ex)
                {
                    oTran.Rollback();
                    throw ex;
                }
            }
            return true;
        }
        public bool DeleteItemAccount(Guid IdAccount, SqlConnection objConn)
        {
            using (SqlTransaction oTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteAccount = new SqlCommand("[Setup].[Proc_DeleteAccount]", objConn);
                    cmdDeleteAccount.Transaction = oTran;
                    cmdDeleteAccount.CommandType = CommandType.StoredProcedure;
                    cmdDeleteAccount.Parameters.Add("@IdAccount", SqlDbType.UniqueIdentifier).Value = IdAccount;
                    cmdDeleteAccount.ExecuteNonQuery();

                    SqlCommand cmdDeleteItem = new SqlCommand("[Setup].[Proc_deleteItems]", objConn);
                    cmdDeleteItem.Connection = objConn;
                    cmdDeleteItem.CommandType = CommandType.StoredProcedure;
                    cmdDeleteItem.Transaction = oTran;
                    cmdDeleteItem.Parameters.Add("@IdAccount", SqlDbType.UniqueIdentifier).Value = IdAccount;
                    cmdDeleteItem.ExecuteNonQuery();

                    oTran.Commit();
                }
                catch (Exception ex)
                {
                    oTran.Rollback();
                    throw ex;
                }
            }
            return true;
        }
    }
}
