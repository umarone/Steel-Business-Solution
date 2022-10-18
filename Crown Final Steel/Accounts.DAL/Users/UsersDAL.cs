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
    public class UsersDAL
    {
        IDataReader objReader;
        public EntityoperationInfo CreateUsers(UsersEL oelUser, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdUsers = new SqlCommand("[Users].[Proc_CeateUsers]", objConn))
            {
                cmdUsers.CommandType = CommandType.StoredProcedure;

                cmdUsers.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUser.UserId;
                cmdUsers.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelUser.IdProject;                
                cmdUsers.Parameters.Add(new SqlParameter("@UserName", DbType.String)).Value = oelUser.UserName;
                cmdUsers.Parameters.Add(new SqlParameter("@Password", DbType.String)).Value = oelUser.Password;
                cmdUsers.Parameters.Add(new SqlParameter("@FirstName", DbType.String)).Value = oelUser.FirstName;
                cmdUsers.Parameters.Add(new SqlParameter("@LastName", DbType.String)).Value = oelUser.LastName;
                cmdUsers.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelUser.Contact;
                cmdUsers.Parameters.Add(new SqlParameter("@Cnic", DbType.String)).Value = oelUser.Cnic;
                cmdUsers.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelUser.Address;
                cmdUsers.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelUser.IsActive;
                cmdUsers.Parameters.Add(new SqlParameter("@CreationDateTime", DbType.DateTime)).Value = oelUser.CreatedDateTime;

                if (cmdUsers.ExecuteNonQuery() > 0)
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
        public EntityoperationInfo UpdateUsers(UsersEL oelUser, SqlConnection objConn)
        {
            EntityoperationInfo infoResult = new EntityoperationInfo();
            using (SqlCommand cmdUsers = new SqlCommand("[Users].[Proc_UpdateUsers]", objConn))
            {
                cmdUsers.CommandType = CommandType.StoredProcedure;

                cmdUsers.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUser.UserId;
                cmdUsers.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelUser.IdProject;
                cmdUsers.Parameters.Add(new SqlParameter("@UserName", DbType.String)).Value = oelUser.UserName;
                cmdUsers.Parameters.Add(new SqlParameter("@Password", DbType.String)).Value = oelUser.Password;
                cmdUsers.Parameters.Add(new SqlParameter("@FirstName", DbType.String)).Value = oelUser.FirstName;
                cmdUsers.Parameters.Add(new SqlParameter("@LastName", DbType.String)).Value = oelUser.LastName;
                cmdUsers.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelUser.Contact;
                cmdUsers.Parameters.Add(new SqlParameter("@Cnic", DbType.String)).Value = oelUser.Cnic;
                cmdUsers.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelUser.Address;
                cmdUsers.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelUser.IsActive;
                cmdUsers.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelUser.CreatedDateTime;

                //cmdUsers.ExecuteNonQuery();
                if (cmdUsers.ExecuteNonQuery() > 0)
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
        public bool CheckUserNameDuplication(Int64 IdProject, string UserName, SqlConnection objConn)
        {
            List<UsersEL> list = new List<UsersEL>();
            SqlCommand cmdProjects = new SqlCommand("[Users].[Proc_CheckUserNameDuplication]", objConn);

            cmdProjects.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
            cmdProjects.Parameters.Add("@UserName", SqlDbType.VarChar).Value = UserName;

            cmdProjects.CommandType = CommandType.StoredProcedure;
            objReader = cmdProjects.ExecuteReader();
            while (objReader.Read())
            {
                UsersEL oelUser = new UsersEL();

                oelUser.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelUser.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                //oelUser.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                //oelUser.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                //oelUser.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                oelUser.UserName = Validation.GetSafeString(objReader["UserName"]);
                oelUser.Password = Validation.GetSafeString(objReader["Password"]);
                oelUser.FirstName = Validation.GetSafeString(objReader["First_Name"]);
                oelUser.LastName = Validation.GetSafeString(objReader["Last_Name"]);
                oelUser.Contact = Validation.GetSafeString(objReader["Contact"]);
                oelUser.Cnic = Validation.GetSafeString(objReader["Cnic"]);
                oelUser.Address = Validation.GetSafeString(objReader["Address"]);
                oelUser.IsActive = Convert.ToBoolean(objReader["IsActive"]);
                oelUser.CreatedDateTime = Convert.ToDateTime(objReader["Created_DateTime"]);

                list.Add(oelUser);
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
        public List<UsersEL> GetAllUsers(SqlConnection oConn)
        {
            List<UsersEL> oelUsersCollection = new List<UsersEL>();
            using (SqlCommand cmdUsers = new SqlCommand("[Users].[Proc_GetAllUsers]", oConn))
            {
                cmdUsers.CommandType = CommandType.StoredProcedure;
                objReader = cmdUsers.ExecuteReader();
                while (objReader.Read())
                {
                    UsersEL oelUser = new UsersEL();
                    oelUser.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                    oelUser.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                    oelUser.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                    oelUser.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                    oelUser.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelUser.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelUser.Password = Validation.GetSafeString(objReader["Password"]);
                    oelUser.FirstName = Validation.GetSafeString(objReader["First_Name"]);
                    oelUser.LastName = Validation.GetSafeString(objReader["Last_Name"]);
                    oelUser.Contact = Validation.GetSafeString(objReader["Contact"]);
                    oelUser.Cnic = Validation.GetSafeString(objReader["Cnic"]);
                    oelUser.Address = Validation.GetSafeString(objReader["Address"]);
                    oelUser.IsActive = Convert.ToBoolean(objReader["IsActive"]);
                    oelUser.CreatedDateTime = Convert.ToDateTime(objReader["Created_DateTime"]);
                    oelUsersCollection.Add(oelUser);
                }
            }
            return oelUsersCollection;
        }
        public List<UsersEL> GetAllActiveUsers(SqlConnection oConn)
        {
            List<UsersEL> oelUsersCollection = new List<UsersEL>();
            using (SqlCommand cmdUsers = new SqlCommand("[Users].[Proc_GetAllActiveUsers]", oConn))
            {
                cmdUsers.CommandType = CommandType.StoredProcedure;
                objReader = cmdUsers.ExecuteReader();
                while (objReader.Read())
                {
                    UsersEL oelUser = new UsersEL();
                    oelUser.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                    oelUser.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                    //oelUser.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                    //oelUser.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                    //oelUser.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelUser.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelUser.Password = Validation.GetSafeString(objReader["Password"]);
                    oelUser.FirstName = Validation.GetSafeString(objReader["First_Name"]);
                    oelUser.LastName = Validation.GetSafeString(objReader["Last_Name"]);
                    oelUser.Contact = Validation.GetSafeString(objReader["Contact"]);
                    oelUser.Cnic = Validation.GetSafeString(objReader["Cnic"]);
                    oelUser.Address = Validation.GetSafeString(objReader["Address"]);
                    oelUser.IsActive = Convert.ToBoolean(objReader["IsActive"]);
                    oelUser.CreatedDateTime = Convert.ToDateTime(objReader["Created_DateTime"]);
                    oelUsersCollection.Add(oelUser);
                }
            }
            return oelUsersCollection;
        }
        public List<UsersEL> GetUserByProjectId(Int64 IdProject, SqlConnection objConn)
        {
            List<UsersEL> oelUsersCollection = new List<UsersEL>();
            using (SqlCommand cmdUsers = new SqlCommand("[Users].[Proc_GetUserByProjectId]", objConn))
            {
                cmdUsers.CommandType = CommandType.StoredProcedure;
                cmdUsers.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = IdProject;
                objReader = cmdUsers.ExecuteReader();
                while (objReader.Read())
                {
                    UsersEL oelUser = new UsersEL();
                    oelUser.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                    oelUser.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                    oelUser.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                    oelUser.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                    oelUser.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelUser.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelUser.Password = Validation.GetSafeString(objReader["Password"]);
                    oelUser.FirstName = Validation.GetSafeString(objReader["First_Name"]);
                    oelUser.LastName = Validation.GetSafeString(objReader["Last_Name"]);
                    oelUser.Contact = Validation.GetSafeString(objReader["Contact"]);
                    oelUser.Cnic = Validation.GetSafeString(objReader["Cnic"]);
                    oelUser.Address = Validation.GetSafeString(objReader["Address"]);
                    oelUser.IsActive = Convert.ToBoolean(objReader["IsActive"]);
                    oelUser.CreatedDateTime = Convert.ToDateTime(objReader["Created_DateTime"]);
                    oelUsersCollection.Add(oelUser);
                }
            }
            return oelUsersCollection;
        }
        public List<UsersEL> GetUserById(Int64 IdUser, SqlConnection objConn)
        {
            List<UsersEL> oelUsersCollection = new List<UsersEL>();
            using (SqlCommand cmdUsers = new SqlCommand("[Users].[Proc_GetUserById]", objConn))
            {
                cmdUsers.CommandType = CommandType.StoredProcedure;
                cmdUsers.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = IdUser;
                objReader = cmdUsers.ExecuteReader();
                while (objReader.Read())
                {
                    UsersEL oelUser = new UsersEL();
                    oelUser.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                    oelUser.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                    oelUser.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                    oelUser.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                    oelUser.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelUser.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelUser.Password = Validation.GetSafeString(objReader["Password"]);
                    oelUser.FirstName = Validation.GetSafeString(objReader["First_Name"]);
                    oelUser.LastName = Validation.GetSafeString(objReader["Last_Name"]);
                    oelUser.Contact = Validation.GetSafeString(objReader["Contact"]);
                    oelUser.Cnic = Validation.GetSafeString(objReader["Cnic"]);
                    oelUser.Address = Validation.GetSafeString(objReader["Address"]);
                    oelUser.IsActive = Convert.ToBoolean(objReader["IsActive"]);
                    oelUser.CreatedDateTime = Convert.ToDateTime(objReader["Created_DateTime"]);
                    oelUsersCollection.Add(oelUser);
                }
            }
            return oelUsersCollection;
        }
        public List<UsersEL> verifyUser(UsersEL oelUsers, SqlConnection oConnection)
        {
            List<UsersEL> oelUsersCollection = new List<UsersEL>();
            using (SqlCommand cmdVerifyUser = new SqlCommand("[Users].[Proc_VerifyUser]"))
            {

                cmdVerifyUser.CommandType = CommandType.StoredProcedure;
                cmdVerifyUser.Connection = oConnection;
                cmdVerifyUser.Parameters.Add(new SqlParameter("@IdProject", SqlDbType.BigInt)).Value = oelUsers.IdProject;
                cmdVerifyUser.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar)).Value = oelUsers.UserName;
                cmdVerifyUser.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar)).Value = oelUsers.Password;
                objReader = cmdVerifyUser.ExecuteReader();


                while (objReader.Read())
                {
                    UsersEL oelUser = new UsersEL();
                    oelUser.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                    oelUser.IdProject = Validation.GetSafeLong(objReader["Project_Id"]);
                    
                    oelUser.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                    oelUser.IdRole = Validation.GetSafeLong(objReader["Role_Id"]);
                    oelUser.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
                    oelUser.ProjectName = Validation.GetSafeString(objReader["Project_Name"]);
                    oelUser.ProjectInvoiceName = Validation.GetSafeString(objReader["ProjectInvoiceName"]);
                    oelUser.ProjectPurchaseInvoiceName = Validation.GetSafeString(objReader["ProjectPurchaseInvoiceName"]);
                    oelUser.ProjectConfiguration = Validation.GetSafeLong(objReader["ProjectConfiguration"]);
                    oelUser.UserName = Validation.GetSafeString(objReader["UserName"]);
                    oelUser.Password = Validation.GetSafeString(objReader["Password"]);
                    oelUser.FirstName = Validation.GetSafeString(objReader["First_Name"]);
                    oelUser.LastName = Validation.GetSafeString(objReader["Last_Name"]);
                    oelUser.Contact = Validation.GetSafeString(objReader["Contact"]);
                    oelUser.Cnic = Validation.GetSafeString(objReader["Cnic"]);
                    oelUser.Address = Validation.GetSafeString(objReader["Address"]);
                    oelUser.BookNo = Validation.GetSafeLong(objReader["BookNo"]);
                    oelUser.BookPeriod = Validation.GetSafeString(objReader["BookPeriod"]);
                    oelUser.IsActive = Convert.ToBoolean(objReader["IsActive"]);
                    oelUser.ProjectStatus = Validation.GetSafeBooleanNullable(objReader["ProjectStatus"]);
                    oelUser.CreatedDateTime = Convert.ToDateTime(objReader["Created_DateTime"]);
                    oelUsersCollection.Add(oelUser);
                }
            }

            return oelUsersCollection;
        }
        //public List<UserRolesEL> verifyUser(UserRolesEL oelUsers, SqlConnection oConnection)
        //{
        //    List<UserRolesEL> oelUsersCollection = new List<UserRolesEL>();
        //    using (SqlCommand cmdVerifyUser = new SqlCommand("[Users].[Proc_VerifyUser]"))
        //    {

        //        cmdVerifyUser.CommandType = CommandType.StoredProcedure;
        //        cmdVerifyUser.Connection = oConnection;
        //        cmdVerifyUser.Parameters.Add(new SqlParameter("@IdCompany", SqlDbType.UniqueIdentifier)).Value = oelUsers.IdCompany;
        //        cmdVerifyUser.Parameters.Add(new SqlParameter("@UserName", SqlDbType.VarChar)).Value = oelUsers.UserName;
        //        cmdVerifyUser.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar)).Value = oelUsers.Password;
        //        objReader = cmdVerifyUser.ExecuteReader();


        //        while (objReader.Read())
        //        {
        //            UserRolesEL oelUser = new UserRolesEL();
        //            oelUser.UserId = Validation.GetSafeGuid(objReader["User_Id"]);

        //            oelUser.IdCompany = Validation.GetSafeGuid(objReader["Company_Id"]);
        //            oelUser.IdRole = Validation.GetSafeGuid(objReader["Role_Id"]);
        //            //oelUser.CompanyName = Validation.GetSafeString(objReader["Company_Name"]);
        //            oelUser.UserName = Validation.GetSafeString(objReader["UserName"]);
        //            oelUser.Password = Validation.GetSafeString(objReader["Password"]);
        //            oelUser.FirstName = Validation.GetSafeString(objReader["First_Name"]);
        //            oelUser.LastName = Validation.GetSafeString(objReader["Last_Name"]);
        //            oelUser.Contact = Validation.GetSafeString(objReader["Contact"]);
        //            oelUser.Cnic = Validation.GetSafeString(objReader["Cnic"]);
        //            oelUser.Address = Validation.GetSafeString(objReader["Address"]);
        //            oelUser.IsActive = Convert.ToBoolean(objReader["IsActive"]);
        //            oelUser.CreatedDateTime = Convert.ToDateTime(objReader["Created_DateTime"]);
        //            oelUsersCollection.Add(oelUser);
        //        }
        //    }

        //    return oelUsersCollection;
        //}
        public EntityoperationInfo DeleteUsers(UsersEL oelUser, SqlConnection objConn)
        {
            EntityoperationInfo DeleteInfo = new EntityoperationInfo();
            using (SqlCommand cmdUsers = new SqlCommand("[Users].[Proc_DeleteUsers]", objConn))
            {
                cmdUsers.CommandType = CommandType.StoredProcedure;
                cmdUsers.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = oelUser.UserId;
                if (cmdUsers.ExecuteNonQuery() > 0)
                {
                    DeleteInfo.IsSuccess = true;
                }
                else
                {
                    DeleteInfo.IsSuccess = false;
                }

            }
            return DeleteInfo;
        }
        #region User Activity Logger Methods
        public List<AccountsEL> GetAllAccountsByUserAndDateForActivityLogger(Int64 IdUser, DateTime dt, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_GetAllAccountsByUserAndDateForActivityLogger]", objConn);
            cmdAccounts.CommandType = CommandType.StoredProcedure;

            cmdAccounts.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = IdUser;
            cmdAccounts.Parameters.Add(new SqlParameter("@CreatedDate", DbType.Guid)).Value = dt;

            objReader = cmdAccounts.ExecuteReader();
            while (objReader.Read())
            {
                AccountsEL oelAccounts = new AccountsEL();
                oelAccounts.IdAccount = Validation.GetSafeLong(objReader["Account_Id"]);
                oelAccounts.IdParent = Validation.GetSafeLong(objReader["Parent_Id"]);
                oelAccounts.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                oelAccounts.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                oelAccounts.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                oelAccounts.AccountType = Validation.GetSafeString(objReader["AccountType"]);
                oelAccounts.IdLevel = Validation.GetSafeInteger(objReader["Level_Id"]);
                oelAccounts.IdHead = Validation.GetSafeInteger(objReader["Head_Id"]);
                oelAccounts.Discription = Validation.GetSafeString(objReader["Discription"]);
                oelAccounts.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelAccounts.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelAccounts.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);

                list.Add(oelAccounts);
            }
            return list;
        }
        public List<AccountsEL> GetAllAccountsByUserForActivityLogger(Int64 IdUser, SqlConnection objConn)
        {
            List<AccountsEL> list = new List<AccountsEL>();
            SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_GetAllAccountsByUserForActivityLogger]", objConn);
            cmdAccounts.CommandType = CommandType.StoredProcedure;

            cmdAccounts.Parameters.Add(new SqlParameter("@IdUser", DbType.Int64)).Value = IdUser;

            objReader = cmdAccounts.ExecuteReader();
            while (objReader.Read())
            {
                AccountsEL oelAccounts = new AccountsEL();
                oelAccounts.IdAccount = Validation.GetSafeLong(objReader["Account_Id"]);
                oelAccounts.IdParent = Validation.GetSafeLong(objReader["Parent_Id"]);
                oelAccounts.IdCompany = Validation.GetSafeLong(objReader["Company_Id"]);
                oelAccounts.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                oelAccounts.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                oelAccounts.AccountType = Validation.GetSafeString(objReader["AccountType"]);
                oelAccounts.IdLevel = Validation.GetSafeInteger(objReader["Level_Id"]);
                oelAccounts.IdHead = Validation.GetSafeInteger(objReader["Head_Id"]);
                oelAccounts.Discription = Validation.GetSafeString(objReader["Discription"]);
                oelAccounts.IsActive = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                oelAccounts.UserId = Validation.GetSafeLong(objReader["User_Id"]);
                oelAccounts.CreatedDateTime = Validation.GetSafeDateTime(objReader["Created_DateTime"]);

                list.Add(oelAccounts);
            }
            return list;
        }
        public List<TransactionsEL> GetVouchersByUserAndDateForActivity(Int64 IdUser, Int64 IdProject, Int64 BookNo, DateTime ActivityDate, string VType, SqlConnection objConn)
        {
            List<TransactionsEL> list = new List<TransactionsEL>();
            using (SqlCommand cmdBalanceSheetAccounts = new SqlCommand("[Transactions].[Proc_GetVouchersByUserAndDateForActivity]", objConn))
            {
                cmdBalanceSheetAccounts.CommandType = CommandType.StoredProcedure;
                cmdBalanceSheetAccounts.Parameters.Add("@IdUser", SqlDbType.BigInt).Value = IdUser;
                cmdBalanceSheetAccounts.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdBalanceSheetAccounts.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdBalanceSheetAccounts.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = ActivityDate;
                cmdBalanceSheetAccounts.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VType;
                objReader = cmdBalanceSheetAccounts.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();

                    oelTransaction.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelTransaction.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelTransaction.CreatedDateTime = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelTransaction.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        public List<VouchersEL> GetStockVouchersByUserAndDateForActivity(Int64 IdUser, Int64 IdProject, Int64 BookNo, DateTime ActivityDate, string VType, SqlConnection objConn)
        {
            List<VouchersEL> list = new List<VouchersEL>();
            using (SqlCommand cmdBalanceSheetAccounts = new SqlCommand("[Transactions].[Proc_GetStockVouchersByUserAndDateForActivity]", objConn))
            {
                cmdBalanceSheetAccounts.CommandType = CommandType.StoredProcedure;
                cmdBalanceSheetAccounts.Parameters.Add("@IdUser", SqlDbType.BigInt).Value = IdUser;
                cmdBalanceSheetAccounts.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
                cmdBalanceSheetAccounts.Parameters.Add("@BookNo", SqlDbType.BigInt).Value = BookNo;
                cmdBalanceSheetAccounts.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = ActivityDate;
                cmdBalanceSheetAccounts.Parameters.Add("@VoucherType", SqlDbType.VarChar).Value = VType;
                objReader = cmdBalanceSheetAccounts.ExecuteReader();
                while (objReader.Read())
                {
                    TransactionsEL oelTransaction = new TransactionsEL();

                    oelTransaction.VoucherNo = Validation.GetSafeLong(objReader["VoucherNo"]);
                    oelTransaction.TotalAmount = Validation.GetSafeDecimal(objReader["TotalAmount"]);
                    oelTransaction.IsNetTransaction = Validation.GetSafeBooleanNullable(objReader["IsNetTransaction"]);
                    if (Convert.ToBoolean(objReader["IsNetTransaction"]))
                    {
                        oelTransaction.SettlementType = "Cash";
                    }
                    else
                    {
                        oelTransaction.SettlementType = "Credit";
                    }
                    oelTransaction.CreatedDateTime = Validation.GetSafeDateTime(objReader["VDate"]);
                    oelTransaction.Posted = Validation.GetSafeBooleanNullable(objReader["Posted"]);

                    list.Add(oelTransaction);
                }
            }
            return list;
        }
        #endregion
    }
}
