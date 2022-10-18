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
    public class ChartsOfAccountsDAL
    {
        public  EntityoperationInfo InsertChartsOfAccounts(ChartsOfAccountsEL oelChartsOfAccounts, SqlConnection oConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdChartsOfAccounts = new SqlCommand("Proc_CreateAccounts", oConn))
            {
                cmdChartsOfAccounts.CommandType = CommandType.StoredProcedure;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@IdAccount", DbType.Guid)).Value = oelChartsOfAccounts.IdAccount;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelChartsOfAccounts.AccountNo;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@AccountName", DbType.String)).Value = oelChartsOfAccounts.AccountName;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@AccountType", DbType.String)).Value = oelChartsOfAccounts.AccountType;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@IdParent1", DbType.Int32)).Value = oelChartsOfAccounts.IdParent1;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@IdParent2", DbType.Int32)).Value = oelChartsOfAccounts.IdParent2;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelChartsOfAccounts.UserId;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelChartsOfAccounts.IsActive;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelChartsOfAccounts.CreatedDateTime;

                if (cmdChartsOfAccounts.ExecuteNonQuery() > -1)
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
        public EntityoperationInfo UpdateChartsOfAccounts(ChartsOfAccountsEL oelChartsOfAccounts, SqlConnection oConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdChartsOfAccounts = new SqlCommand("sp_updateCOA", oConn))
            {
                cmdChartsOfAccounts.CommandType = CommandType.StoredProcedure;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelChartsOfAccounts.AccountNo;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@AccountName", DbType.String)).Value = oelChartsOfAccounts.AccountName;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@AccountType", DbType.String)).Value = oelChartsOfAccounts.AccountType;
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@HeaderAccount", DbType.String)).Value = oelChartsOfAccounts.HeaderAccount;               
                cmdChartsOfAccounts.Parameters.Add(new SqlParameter("@Catagory", DbType.String)).Value = oelChartsOfAccounts.Catagory;
                cmdChartsOfAccounts.ExecuteNonQuery();
                if (cmdChartsOfAccounts.ExecuteNonQuery() > -1)
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
        public string GetAccountType(string AccountType, SqlConnection objConn)
        {
            using (SqlCommand cmdChartOfAccounts = new SqlCommand())
            {
                if (AccountType == AccountTypes.Customers.ToString())
                {
                    cmdChartOfAccounts.CommandText = "sp_GetMaxCustomerAccountNumber";
                }
                else if (AccountType == AccountTypes.Suppliers.ToString())
                {
                    cmdChartOfAccounts.CommandText = "sp_GetMaxSupplierAccountNumber";
                }
                else if (AccountType == AccountTypes.Items.ToString())
                {
                    cmdChartOfAccounts.CommandText = "sp_GetMaxItemAccountNumber";
                }
                cmdChartOfAccounts.CommandType = CommandType.StoredProcedure;
                cmdChartOfAccounts.Connection = objConn;
                return cmdChartOfAccounts.ExecuteScalar().ToString();
            }

        }
        public List<ChartsOfAccountsEL> GetAccountSubCategory(int Id, SqlConnection oConn)
        {
            List<ChartsOfAccountsEL> list = new List<ChartsOfAccountsEL>();
            SqlCommand cmdSubCategory = new SqlCommand("sp_getSubCategory", oConn);
            cmdSubCategory.CommandType = CommandType.StoredProcedure;
            cmdSubCategory.Parameters.Add("@IdCategory", SqlDbType.Int).Value = Id;
            SqlDataReader oReader = cmdSubCategory.ExecuteReader();
            while (oReader.Read())
            {
                ChartsOfAccountsEL ChartofAccounts = new ChartsOfAccountsEL();
                ChartofAccounts.SubCategoryName = Validation.GetSafeString(oReader["Name"]);
                ChartofAccounts.SubCategory = Validation.GetSafeInteger(oReader["SubCategoryNo"]);
                list.Add(ChartofAccounts);
            }
            return list;
        }
        public List<ChartsOfAccountsEL> GetAccountsByCategory(int Id, SqlConnection oConn)
        {
            List<ChartsOfAccountsEL> list = new List<ChartsOfAccountsEL>();
            SqlCommand cmdSubCategory = new SqlCommand("sp_getAccountsByCategory", oConn);
            cmdSubCategory.CommandType = CommandType.StoredProcedure;
            cmdSubCategory.Parameters.Add("@IdCategory", SqlDbType.Int).Value = Id;
            using (SqlDataReader oReader = cmdSubCategory.ExecuteReader())
            {
                while (oReader.Read())
                {
                    ChartsOfAccountsEL ChartofAccounts = new ChartsOfAccountsEL();
                    ChartofAccounts.AccountName = Validation.GetSafeString(oReader["AccountName"]);
                    ChartofAccounts.AccountNo = Validation.GetSafeString(oReader["AccountNo"]);
                    ChartofAccounts.AccountType = Validation.GetSafeString(oReader["AccountType"]);
                    ChartofAccounts.HeaderAccount = Validation.GetSafeInteger(oReader["HeaderAccount"]);
                    list.Add(ChartofAccounts);
                }
            }
            return list;
        }
        public List<ChartsOfAccountsEL> GetAllSubCategory(SqlConnection oConn)
        {
            List<ChartsOfAccountsEL> list = new List<ChartsOfAccountsEL>();
            SqlCommand cmdSubCategory = new SqlCommand("sp_GetAllSubCategories", oConn);
            cmdSubCategory.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSubCategory.ExecuteReader();
            while (oReader.Read())
            {
                ChartsOfAccountsEL ChartofAccounts = new ChartsOfAccountsEL();
                ChartofAccounts.SubCategory =Validation.GetSafeInteger(oReader["SubCategoryNo"]);
                ChartofAccounts.SubCategoryName = Validation.GetSafeString(oReader["Name"]);
                list.Add(ChartofAccounts);
            }
            return list;
        }
        public List<ChartsOfAccountsEL> SearchAccountByAccountNo(string AccountNo, SqlConnection objConn)
        {
            List<ChartsOfAccountsEL> list = new List<ChartsOfAccountsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("sp_SearchByAccountNo", objConn);
            cmdSearchAccount.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchAccount.ExecuteReader();
            while (oReader.Read())
            {
                ChartsOfAccountsEL ChartofAccounts = new ChartsOfAccountsEL();
                ChartofAccounts.AccountNo = Validation.GetSafeString(oReader["AccountNo"]);
                ChartofAccounts.AccountName = Validation.GetSafeString(oReader["AccountName"]);
                ChartofAccounts.AccountType = Validation.GetSafeString(oReader["AccountType"]);
                ChartofAccounts.HeaderAccount = Validation.GetSafeInteger(oReader["HeaderAccount"]);
                list.Add(ChartofAccounts);
            }
            return list;
        }
        public List<ChartsOfAccountsEL> SearchAccountByAccountName(string AccountName, SqlConnection objConn)
        {
            List<ChartsOfAccountsEL> list = new List<ChartsOfAccountsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("sp_SearchByAccountName", objConn);
            cmdSearchAccount.Parameters.Add("@AccountName", SqlDbType.VarChar).Value = AccountName;
            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchAccount.ExecuteReader();
            while (oReader.Read())
            {
                ChartsOfAccountsEL ChartofAccounts = new ChartsOfAccountsEL();
                ChartofAccounts.AccountNo = Validation.GetSafeString(oReader["AccountNo"]);
                ChartofAccounts.AccountName = Validation.GetSafeString(oReader["AccountName"]);
                ChartofAccounts.AccountType = Validation.GetSafeString(oReader["AccountType"]);
                ChartofAccounts.HeaderAccount = Validation.GetSafeInteger(oReader["HeaderAccount"]);
                list.Add(ChartofAccounts);
            }
            return list;
        }
        public List<ItemsEL> SearchStockAccountByAccountNo(string AccountNo, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("sp_SearchStockByAccountNo", objConn);
            cmdSearchAccount.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchAccount.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL oelItems = new ItemsEL();
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
        public List<ItemsEL> SearchStockAccountByAccountName(string AccountName, SqlConnection objConn)
        {
            List<ItemsEL> list = new List<ItemsEL>();
            SqlCommand cmdSearchAccount = new SqlCommand("sp_SearchStockByAccountName", objConn);
            cmdSearchAccount.Parameters.Add("@AccountName", SqlDbType.VarChar).Value = AccountName;
            cmdSearchAccount.CommandType = CommandType.StoredProcedure;
            SqlDataReader oReader = cmdSearchAccount.ExecuteReader();
            while (oReader.Read())
            {
                ItemsEL  oelItems = new ItemsEL();
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
        public bool CheckAccount(string AccountNo, SqlConnection objConn)
        {
            List<ChartsOfAccountsEL> list = new List<ChartsOfAccountsEL>();
            using (SqlCommand cmdCheckAccount = new SqlCommand("sp_checkAccount", objConn))
            {
                cmdCheckAccount.Parameters.Add("@AccountNo", SqlDbType.NVarChar).Value = AccountNo;
                cmdCheckAccount.CommandType = CommandType.StoredProcedure;
                SqlDataReader objReader = cmdCheckAccount.ExecuteReader();
                while (objReader.Read())
                {
                    ChartsOfAccountsEL oelChartOfAccount = new ChartsOfAccountsEL();
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
        public List<ChartsOfAccountsEL> GetAccount(String AccountNo,SqlConnection objConn)
        {
            List<ChartsOfAccountsEL> list = new List<ChartsOfAccountsEL>();
            SqlCommand cmdSubCategory = new SqlCommand("sp_GetAccount", objConn);
            cmdSubCategory.CommandType = CommandType.StoredProcedure;
            cmdSubCategory.Parameters.Add("@AccountNo", SqlDbType.NVarChar).Value = AccountNo;
            SqlDataReader oReader = cmdSubCategory.ExecuteReader();
            while (oReader.Read())
            {
                ChartsOfAccountsEL ChartofAccounts = new ChartsOfAccountsEL();
                ChartofAccounts.AccountNo = Validation.GetSafeString(oReader["AccountNo"]);
                ChartofAccounts.AccountName = Validation.GetSafeString(oReader["AccountName"]);
                ChartofAccounts.SubCategoryName = oReader["AccountName"].ToString();
                ChartofAccounts.AccountType = Validation.GetSafeString(oReader["AccountType"]);
                if (oReader["HeaderAccount"] != DBNull.Value)
                {
                    ChartofAccounts.HeaderAccount = Validation.GetSafeInteger(oReader["HeaderAccount"]);
                }
                ChartofAccounts.Catagory = Validation.GetSafeInteger(oReader["Catagory"]);
                list.Add(ChartofAccounts);
            }
            return list;
        }
        public EntityoperationInfo DeleteChartOfAccount(string AccountNo, SqlConnection objConn)
        {
            EntityoperationInfo deleteInfo = new EntityoperationInfo();
            int rowsEffected = -1;
            using (SqlCommand cmdDeleteAccount = new SqlCommand("sp_deleteCOA", objConn))
            {
                cmdDeleteAccount.CommandType = CommandType.StoredProcedure;
                cmdDeleteAccount.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
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
        public bool DeletePersonAccount(string AccountNo, SqlConnection objConn)
        {
            using (SqlTransaction oTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteAccount = new SqlCommand("sp_deleteCOA", objConn);
                    cmdDeleteAccount.Transaction = oTran;
                    cmdDeleteAccount.CommandType = CommandType.StoredProcedure;
                    cmdDeleteAccount.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                    cmdDeleteAccount.ExecuteNonQuery();

                    SqlCommand cmdDeletePerson = new SqlCommand();
                    cmdDeletePerson.CommandText = "sp_deletePersons";
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
                    cmdDeletePerson.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                    cmdDeletePerson.ExecuteNonQuery();

                    oTran.Commit();
                }
                catch(Exception ex)
                {
                    oTran.Rollback();
                    throw ex;
                }
            }
            return true;
        }
        public bool DeleteItemAccount(string AccountNo, SqlConnection objConn)
        {
            using (SqlTransaction oTran = objConn.BeginTransaction())
            {
                try
                {
                    SqlCommand cmdDeleteAccount = new SqlCommand("sp_deleteCOA", objConn);
                    cmdDeleteAccount.Transaction = oTran;
                    cmdDeleteAccount.CommandType = CommandType.StoredProcedure;
                    cmdDeleteAccount.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
                    cmdDeleteAccount.ExecuteNonQuery();

                    SqlCommand cmdDeleteItem = new SqlCommand("sp_deleteItems", objConn);                   
                    cmdDeleteItem.Connection = objConn;
                    cmdDeleteItem.CommandType = CommandType.StoredProcedure;
                    cmdDeleteItem.Transaction = oTran;
                    cmdDeleteItem.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
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