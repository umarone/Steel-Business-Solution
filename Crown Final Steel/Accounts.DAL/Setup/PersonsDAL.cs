using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.EL;
using Accounts.Common;
using System.Data.SqlClient;
using System.Data;

namespace Accounts.DAL
{
    public class PersonsDAL
    {
       IDataReader objReader;
       public EntityoperationInfo InsertSuppliers(PersonsEL oelSuppliers, SqlConnection oConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdSuppliers = new SqlCommand("sp_insertSuppliers", oConn))
            {
                cmdSuppliers.CommandType = CommandType.StoredProcedure;
                cmdSuppliers.Parameters.Add(new SqlParameter("@SupplierNo", DbType.Int32)).Value = oelSuppliers.Number;
                cmdSuppliers.Parameters.Add(new SqlParameter("@SupplierName", DbType.String)).Value = oelSuppliers.PersonName;
                cmdSuppliers.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelSuppliers.Contact;
                cmdSuppliers.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelSuppliers.Address;
                cmdSuppliers.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelSuppliers.NTN;
                cmdSuppliers.Parameters.Add(new SqlParameter("@Balance", DbType.Decimal)).Value = oelSuppliers.Balance;

                if (cmdSuppliers.ExecuteNonQuery() > -1)
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
       public EntityoperationInfo UpdateSuppliers(PersonsEL oelSuppliers, SqlConnection oConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdSuppliers = new SqlCommand("sp_updateSuppliers", oConn))
            {
                cmdSuppliers.CommandType = CommandType.StoredProcedure;
                cmdSuppliers.Parameters.Add(new SqlParameter("@SupplierNo", DbType.Int32)).Value = oelSuppliers.Number;
                cmdSuppliers.Parameters.Add(new SqlParameter("@SupplierName", DbType.String)).Value = oelSuppliers.PersonName;
                cmdSuppliers.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelSuppliers.Contact;
                cmdSuppliers.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelSuppliers.Address;
                cmdSuppliers.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelSuppliers.NTN;
                cmdSuppliers.Parameters.Add(new SqlParameter("@Balance", DbType.Decimal)).Value = oelSuppliers.Balance;
                if (cmdSuppliers.ExecuteNonQuery() > -1)
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
       public EntityoperationInfo InsertPersonAccount(AccountsEL oelChartOfAccount, PersonsEL oelPerson, SqlConnection oConn)
        {
            lock (this)
            {
                EntityoperationInfo InfoResult = new EntityoperationInfo();
                SqlTransaction oTran = oConn.BeginTransaction();
                using (SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_CreateAccounts]"))
                {
                    SqlCommand cmdPerson = new SqlCommand();
                    cmdPerson.CommandText = "[Setup].[Proc_CreatePersons]";

                    cmdAccounts.Connection = oConn;
                    cmdAccounts.CommandType = CommandType.StoredProcedure;

                    cmdAccounts.Parameters.Add(new SqlParameter("@IdAccount", DbType.Int64)).Value = oelChartOfAccount.IdAccount;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdParent", DbType.Int64)).Value = oelChartOfAccount.IdParent;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelChartOfAccount.IdCompany;
                    cmdAccounts.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelChartOfAccount.AccountNo;
                    cmdAccounts.Parameters.Add(new SqlParameter("@AccountName", DbType.String)).Value = oelChartOfAccount.AccountName;
                    cmdAccounts.Parameters.Add(new SqlParameter("@AccountType", DbType.String)).Value = oelChartOfAccount.AccountType;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdLevel", DbType.Int32)).Value = oelChartOfAccount.IdLevel;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdHead", DbType.Int32)).Value = oelChartOfAccount.IdHead;
                    cmdAccounts.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelChartOfAccount.Discription;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelChartOfAccount.UserId;
                    cmdAccounts.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelChartOfAccount.IsActive;
                    cmdAccounts.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelChartOfAccount.CreatedDateTime;

                    cmdPerson.Connection = oConn;
                    cmdPerson.CommandType = CommandType.StoredProcedure;

                    cmdPerson.Parameters.Add(new SqlParameter("@IdPerson", DbType.Guid)).Value = oelPerson.IdAccount;
                    cmdPerson.Parameters.Add(new SqlParameter("@IdCompany", DbType.Guid)).Value = oelPerson.IdCompany;
                    cmdPerson.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelPerson.AccountNo;
                    cmdPerson.Parameters.Add(new SqlParameter("@PersonName", DbType.String)).Value = oelPerson.PersonName;
                    cmdPerson.Parameters.Add(new SqlParameter("@LastName", DbType.String)).Value = oelPerson.LastName;
                    cmdPerson.Parameters.Add(new SqlParameter("@ParentLevel", DbType.Int32)).Value = oelPerson.IdParent1;
                    cmdPerson.Parameters.Add(new SqlParameter("@NIC", DbType.Int32)).Value = oelPerson.Cnic;
                    cmdPerson.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelPerson.Contact;
                    cmdPerson.Parameters.Add(new SqlParameter("@Salary", DbType.String)).Value = oelPerson.Salary;
                    cmdPerson.Parameters.Add(new SqlParameter("@PersonPic", DbType.Binary)).Value = oelPerson.PersonPic;
                    cmdPerson.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelPerson.Address;
                    cmdPerson.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPerson.Discription;
                    cmdPerson.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelPerson.NTN;
                    cmdPerson.Parameters.Add(new SqlParameter("@PersonType", DbType.String)).Value = oelChartOfAccount.AccountType;

                    cmdAccounts.Transaction = oTran;
                    cmdPerson.Transaction = oTran;

                    if (cmdAccounts.ExecuteNonQuery() > -1 && cmdPerson.ExecuteNonQuery() > -1)
                    {
                        InfoResult.IsSuccess = true;
                        oTran.Commit();
                    }
                    else
                    {
                        InfoResult.IsSuccess = false;
                    }
                }
                return InfoResult;
            }           
        }
       public EntityoperationInfo UpdatePersonAccount(AccountsEL oelChartOfAccount, PersonsEL oelPerson, SqlConnection oConn)
       {
           EntityoperationInfo InfoResult = new EntityoperationInfo();
           SqlTransaction oTran = oConn.BeginTransaction();
           using (SqlCommand cmdAccounts = new SqlCommand("[Setup].[Proc_UpdateAccounts]"))
           {
               SqlCommand cmdPerson = new SqlCommand();
               cmdPerson.CommandText = "[Setup].[Proc_UpdatePersons]";
               cmdAccounts.Connection = oConn;
               cmdAccounts.CommandType = CommandType.StoredProcedure;
               
               cmdAccounts.Parameters.Add(new SqlParameter("@IdAccount", DbType.Int64)).Value = oelChartOfAccount.IdAccount;
               cmdAccounts.Parameters.Add(new SqlParameter("@IdParent", DbType.Int64)).Value = oelChartOfAccount.IdParent;
               cmdAccounts.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = oelChartOfAccount.IdCompany;
               cmdAccounts.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelChartOfAccount.AccountNo;
               cmdAccounts.Parameters.Add(new SqlParameter("@AccountName", DbType.String)).Value = oelChartOfAccount.AccountName;
               cmdAccounts.Parameters.Add(new SqlParameter("@AccountType", DbType.String)).Value = oelChartOfAccount.AccountType;
               cmdAccounts.Parameters.Add(new SqlParameter("@IdLevel", DbType.Int32)).Value = oelChartOfAccount.IdLevel;
               cmdAccounts.Parameters.Add(new SqlParameter("@IdHead", DbType.Int32)).Value = oelChartOfAccount.IdHead;
               cmdAccounts.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelChartOfAccount.Discription;
               cmdAccounts.Parameters.Add(new SqlParameter("@IdUser", DbType.Guid)).Value = oelChartOfAccount.UserId;
               cmdAccounts.Parameters.Add(new SqlParameter("@IsActive", DbType.Boolean)).Value = oelChartOfAccount.IsActive;
               cmdAccounts.Parameters.Add(new SqlParameter("@CreatedDateTime", DbType.DateTime)).Value = oelChartOfAccount.CreatedDateTime;

               cmdPerson.Connection = oConn;
               cmdPerson.CommandType = CommandType.StoredProcedure;

               cmdPerson.Parameters.Add(new SqlParameter("@IdPerson", DbType.Guid)).Value = oelPerson.IdAccount;
               cmdPerson.Parameters.Add(new SqlParameter("@IdCompany", DbType.Guid)).Value = oelPerson.IdCompany;
               cmdPerson.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelPerson.AccountNo;
               cmdPerson.Parameters.Add(new SqlParameter("@PersonName", DbType.String)).Value = oelPerson.PersonName;
               cmdPerson.Parameters.Add(new SqlParameter("@LastName", DbType.String)).Value = oelPerson.LastName;
               cmdPerson.Parameters.Add(new SqlParameter("@ParentLevel", DbType.Int32)).Value = oelPerson.IdParent1;
               cmdPerson.Parameters.Add(new SqlParameter("@NIC", DbType.Int32)).Value = oelPerson.Cnic;
               cmdPerson.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelPerson.Contact;
               cmdPerson.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelPerson.Address;
               cmdPerson.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPerson.Discription;
               cmdPerson.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelPerson.NTN;
               cmdPerson.Parameters.Add(new SqlParameter("@PersonType", DbType.String)).Value = oelChartOfAccount.AccountType;


               cmdAccounts.Transaction = oTran;
               cmdPerson.Transaction = oTran;

               if (cmdAccounts.ExecuteNonQuery() > -1 && cmdPerson.ExecuteNonQuery() > -1)
               {
                   InfoResult.IsSuccess = true;
                   oTran.Commit();
               }
               else
               {
                   InfoResult.IsSuccess = false;
               }
           }
           return InfoResult;
       }
       public EntityoperationInfo InsertCustomers(PersonsEL oelCustomers, SqlConnection oConn)
       {
           EntityoperationInfo InfoResult = new EntityoperationInfo();
           using (SqlCommand cmdCustomers = new SqlCommand("sp_insertCustomers", oConn))
           {
               cmdCustomers.CommandType = CommandType.StoredProcedure;
               cmdCustomers.Parameters.Add(new SqlParameter("@CustomerNo", DbType.Int32)).Value = oelCustomers.Number;
               cmdCustomers.Parameters.Add(new SqlParameter("@CustomerName", DbType.String)).Value = oelCustomers.PersonName;
               cmdCustomers.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelCustomers.Contact;
               cmdCustomers.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelCustomers.Address;
               cmdCustomers.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelCustomers.NTN;
               cmdCustomers.Parameters.Add(new SqlParameter("@Balance", DbType.Decimal)).Value = oelCustomers.Balance;

               if (cmdCustomers.ExecuteNonQuery() > -1)
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
       public EntityoperationInfo UpdateCustomers(PersonsEL oelCustomers, SqlConnection oConn)
        {
            EntityoperationInfo InfoResult = new EntityoperationInfo();
            using (SqlCommand cmdCustomers = new SqlCommand("sp_updateCustomers", oConn))
            {
                cmdCustomers.CommandType = CommandType.StoredProcedure;
                cmdCustomers.Parameters.Add(new SqlParameter("@CustomerNo", DbType.Int32)).Value = oelCustomers.Number;
                cmdCustomers.Parameters.Add(new SqlParameter("@CustomerName", DbType.String)).Value = oelCustomers.PersonName;
                cmdCustomers.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelCustomers.Contact;
                cmdCustomers.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelCustomers.Address;
                cmdCustomers.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelCustomers.NTN;
                cmdCustomers.Parameters.Add(new SqlParameter("@Balance", DbType.Decimal)).Value = oelCustomers.Balance;

                if (cmdCustomers.ExecuteNonQuery() > -1)
                {
                    InfoResult.IsSuccess = true;
                }
                else
                {
                    InfoResult.IsSuccess = false;
                }
                return InfoResult;

            }
        }
       public List<PersonsEL> VerifyAccount(Int64 IdProject, string Type, string AccountNo, SqlConnection objConn)
       {
           List<PersonsEL> list = new List<PersonsEL>();
           using (SqlCommand cmdVerifyAccount = new SqlCommand("[Setup].[Proc_VerifyAccount]", objConn))
           {
               cmdVerifyAccount.CommandType = CommandType.StoredProcedure;
               cmdVerifyAccount.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdVerifyAccount.Parameters.Add("@Type", SqlDbType.NVarChar).Value = Type;
               cmdVerifyAccount.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
               objReader = cmdVerifyAccount.ExecuteReader();
               while (objReader.Read())
               {
                   PersonsEL oelPerson = new PersonsEL();
                   if (Type == "Persons")
                   {
                       oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                       oelPerson.PersonName = Validation.GetSafeString(objReader["PersonName"]);
                       oelPerson.Contact = Validation.GetSafeString(objReader["Contact"]);
                       oelPerson.Address = Validation.GetSafeString(objReader["Address"]);
                       oelPerson.NTN = Validation.GetSafeString(objReader["NTN"]);
                       oelPerson.AccountType = Validation.GetSafeString(objReader["personType"]);
                   }
                   else
                   {
                       oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
                       oelPerson.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                   }
                   //else if (Type == "Suppliers")
                   //{
                   //    oelPerson.AccountNo = objReader["SupplierNo"].ToString();
                   //    oelPerson.PersonName = objReader["SupplierName"].ToString();
                   //    if (objReader["Contact"] != DBNull.Value)
                   //    {
                   //        oelPerson.Contact = objReader["Contact"].ToString();
                   //    }
                   //    else
                   //    {
                   //        oelPerson.Contact = "N/A";
                   //    }
                   //    if (objReader["Address"] != DBNull.Value)
                   //    {
                   //        oelPerson.Address = objReader["Address"].ToString();
                   //    }
                   //    else
                   //    {
                   //        oelPerson.Address = "N/A";
                   //    }
                   //    if (objReader["NTN"] != DBNull.Value)
                   //    {
                   //        oelPerson.NTN = objReader["NTN"].ToString();
                   //    }
                   //    else
                   //    {
                   //        oelPerson.NTN = "N/A";
                   //    }
                   //}
                   //else if (Type == "Employees")
                   //{
                   //    oelPerson.AccountNo = objReader["Employeeno"].ToString();
                   //    oelPerson.PersonName = objReader["EmployeeName"].ToString();
                   //}                   
                   list.Add(oelPerson);
               }
           }
           return list;
       }
       public List<PersonsEL> GetPersonByAccount(Int64 IdProject, string AccountNo,SqlConnection objConn)
       {
           List<PersonsEL> oelPersonCollection = new  List<PersonsEL>();
           using (SqlCommand cmdPersonByAccount = new SqlCommand("[Setup].[Proc_GetPersonByAccount]", objConn))
           {
               cmdPersonByAccount.CommandType = CommandType.StoredProcedure;
               cmdPersonByAccount.CommandTimeout = 0;
               cmdPersonByAccount.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
               cmdPersonByAccount.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;
               objReader = cmdPersonByAccount.ExecuteReader();
               while (objReader.Read())
               {
                   PersonsEL oelPerson = new PersonsEL();
                   oelPerson.PersonName = Validation.GetSafeString(objReader["PersonName"]);
                   oelPerson.AccountName = Validation.GetSafeString(objReader["AccountName"]);
                   oelPerson.Contact = Validation.GetSafeString(objReader["Contact"]);
                   oelPerson.Address = Validation.GetSafeString(objReader["Address"]);
                   oelPerson.NTN = Validation.GetSafeString(objReader["NTN"]);
                   oelPerson.AccountType = Validation.GetSafeString(objReader["PersonType"]);

                   oelPersonCollection.Add(oelPerson);
               }
           }
           return oelPersonCollection;
       }
       public List<PersonsEL> SearchPersonsByAccountNo(string AccountNo, Int64 IdCompany, SqlConnection objConn)
       {
           List<PersonsEL> list = new List<PersonsEL>();
           SqlCommand cmdSearchPerson = new SqlCommand("[Setup].[Proc_SearchPersonByAccountNo]", objConn);
           cmdSearchPerson.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
           cmdSearchPerson.Parameters.Add("@AccountNo", SqlDbType.BigInt).Value = AccountNo;
           cmdSearchPerson.CommandType = CommandType.StoredProcedure;
           objReader = cmdSearchPerson.ExecuteReader();
           while (objReader.Read())
           {
               PersonsEL oelPerson = new PersonsEL();
               oelPerson.IdAccount = Validation.GetSafeLong(objReader["Person_Id"]);
               oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
               oelPerson.PersonName= Validation.GetSafeString(objReader["PersonName"]);
               oelPerson.LastName = Validation.GetSafeString(objReader["LastName"]);
               oelPerson.Cnic = Validation.GetSafeString(objReader["NIC"]);
               oelPerson.Contact = Validation.GetSafeString(objReader["Contact"]);
               oelPerson.Address = Validation.GetSafeString(objReader["Address"]);
               oelPerson.Discription = Validation.GetSafeString(objReader["Discription"]);
               oelPerson.PersonType = Validation.GetSafeString(objReader["PersonType"]);

               list.Add(oelPerson);
           }
           return list;
       }
       public List<PersonsEL> SearchPersonByPersonName(string PersonName, Int64 IdCompany, SqlConnection objConn)
       {
           List<PersonsEL> list = new List<PersonsEL>();
           SqlCommand cmdSearchAccount = new SqlCommand("[Setup].[Proc_SearchPersonByPersonName]", objConn);
           cmdSearchAccount.Parameters.Add(new SqlParameter("@IdCompany", DbType.Int64)).Value = IdCompany;
           cmdSearchAccount.Parameters.Add("@PersonName", SqlDbType.VarChar).Value = PersonName;
           cmdSearchAccount.CommandType = CommandType.StoredProcedure;
           objReader = cmdSearchAccount.ExecuteReader();
           while (objReader.Read())
           {
               PersonsEL oelPerson = new PersonsEL();

               oelPerson.IdAccount = Validation.GetSafeLong(objReader["Person_Id"]);
               oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
               oelPerson.PersonName = Validation.GetSafeString(objReader["PersonName"]);
               oelPerson.LastName = Validation.GetSafeString(objReader["LastName"]);
               oelPerson.Cnic = Validation.GetSafeString(objReader["NIC"]);
               oelPerson.Contact = Validation.GetSafeString(objReader["Contact"]);
               oelPerson.Address = Validation.GetSafeString(objReader["Address"]);
               oelPerson.Discription = Validation.GetSafeString(objReader["Discription"]);
               oelPerson.PersonType = Validation.GetSafeString(objReader["PersonType"]);
               
               list.Add(oelPerson);
           }
           return list;
       }
       public List<PersonsEL> GetPersonById(Int64 IdPerson, SqlConnection objConn)
       {
           List<PersonsEL> list = new List<PersonsEL>();
           SqlCommand cmdPerson = new SqlCommand("[Setup].[Proc_GetPersonById]", objConn);

           cmdPerson.Parameters.Add("@IdPerson", SqlDbType.BigInt).Value = IdPerson;

           cmdPerson.CommandType = CommandType.StoredProcedure;
           objReader = cmdPerson.ExecuteReader();
           while (objReader.Read())
           {
               PersonsEL oelPerson = new PersonsEL();
               oelPerson.IdAccount = Validation.GetSafeLong(objReader["Person_Id"]);
               oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
               oelPerson.PersonName = Validation.GetSafeString(objReader["PersonName"]);
               oelPerson.LastName = Validation.GetSafeString(objReader["LastName"]);
               oelPerson.Cnic = Validation.GetSafeString(objReader["NIC"]);
               oelPerson.Contact = Validation.GetSafeString(objReader["Contact"]);
               oelPerson.Salary = Validation.GetSafeString(objReader["Salary"]);
               if (DBNull.Value != objReader["PersonPic"])
               {
                   oelPerson.PersonPic = (byte[])(objReader["PersonPic"]);
               }
               oelPerson.Address = Validation.GetSafeString(objReader["Address"]);
               oelPerson.Discription = Validation.GetSafeString(objReader["Discription"]);
               oelPerson.NTN = Validation.GetSafeString(objReader["NTN"]);
               oelPerson.IdParent1 = Validation.GetSafeInteger(objReader["Parent_Level"]);

               list.Add(oelPerson);
           }
           return list;
       }
       public List<PersonsEL> GetPersonByAccountNo(string AccountNo, Int64 IdProject, SqlConnection objConn)
       {
           List<PersonsEL> list = new List<PersonsEL>();
           SqlCommand cmdPerson = new SqlCommand("[Setup].[Proc_GetPersonByAccountNo]", objConn);

           cmdPerson.Parameters.Add("@IdProject", SqlDbType.BigInt).Value = IdProject;
           cmdPerson.Parameters.Add("@AccountNo", SqlDbType.VarChar).Value = AccountNo;

           cmdPerson.CommandType = CommandType.StoredProcedure;
           objReader = cmdPerson.ExecuteReader();
           while (objReader.Read())
           {
               PersonsEL oelPerson = new PersonsEL();
               oelPerson.IdAccount = Validation.GetSafeLong(objReader["Person_Id"]);
               oelPerson.AccountNo = Validation.GetSafeString(objReader["AccountNo"]);
               oelPerson.PersonName = Validation.GetSafeString(objReader["PersonName"]);
               oelPerson.LastName = Validation.GetSafeString(objReader["LastName"]);
               oelPerson.Cnic = Validation.GetSafeString(objReader["NIC"]);
               oelPerson.Contact = Validation.GetSafeString(objReader["Contact"]);
               oelPerson.Salary = Validation.GetSafeString(objReader["Salary"]);
               if (DBNull.Value != objReader["PersonPic"])
               {
                   oelPerson.PersonPic = (byte[])(objReader["PersonPic"]);
               }
               oelPerson.Address = Validation.GetSafeString(objReader["Address"]);
               oelPerson.Discription = Validation.GetSafeString(objReader["Discription"]);
               oelPerson.NTN = Validation.GetSafeString(objReader["NTN"]);
               oelPerson.IdParent1 = Validation.GetSafeInteger(objReader["Parent_Level"]);

               list.Add(oelPerson);
           }
           return list;
       }
       public EntityoperationInfo CreatePersons(PersonsEL oelPerson,SqlConnection objConn)
       {
           EntityoperationInfo InfoResult = new EntityoperationInfo();
           using (SqlCommand cmdPerson = new SqlCommand("[Setup].[Proc_CreatePersons]", objConn))
           {
               cmdPerson.CommandType = CommandType.StoredProcedure;
               cmdPerson.Parameters.Add(new SqlParameter("@IdPerson", DbType.Int64)).Value = oelPerson.IdAccount;
               cmdPerson.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelPerson.IdProject;
               cmdPerson.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelPerson.AccountNo;
               cmdPerson.Parameters.Add(new SqlParameter("@PersonName", DbType.String)).Value = oelPerson.PersonName;
               cmdPerson.Parameters.Add(new SqlParameter("@LastName", DbType.String)).Value = oelPerson.LastName;
               cmdPerson.Parameters.Add(new SqlParameter("@ParentLevel", DbType.Int32)).Value = oelPerson.IdParent1;
               cmdPerson.Parameters.Add(new SqlParameter("@NIC", DbType.Int32)).Value = oelPerson.Cnic;
               cmdPerson.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelPerson.Contact;
               cmdPerson.Parameters.Add(new SqlParameter("@Salary", DbType.String)).Value = oelPerson.Salary;
               cmdPerson.Parameters.Add(new SqlParameter("@PersonPic", DbType.Binary)).Value = oelPerson.PersonPic;
               cmdPerson.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelPerson.Address;
               cmdPerson.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPerson.Discription;
               cmdPerson.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelPerson.NTN;
               cmdPerson.Parameters.Add(new SqlParameter("@PersonType", DbType.String)).Value = oelPerson.PersonType;

               if (cmdPerson.ExecuteNonQuery() > -1)
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
       public EntityoperationInfo UpdatePerson(PersonsEL oelPerson, SqlConnection objConn)
       {
           EntityoperationInfo infoResult = new EntityoperationInfo();

           SqlCommand cmdPerson = new SqlCommand();
           cmdPerson.CommandText = "[Setup].[Proc_UpdatePersons]";

           cmdPerson.Connection = objConn;
           cmdPerson.CommandType = CommandType.StoredProcedure;

           cmdPerson.Parameters.Add(new SqlParameter("@IdPerson", DbType.Int64)).Value = oelPerson.IdAccount;
           cmdPerson.Parameters.Add(new SqlParameter("@IdProject", DbType.Int64)).Value = oelPerson.IdProject;
           cmdPerson.Parameters.Add(new SqlParameter("@AccountNo", DbType.String)).Value = oelPerson.AccountNo;
           cmdPerson.Parameters.Add(new SqlParameter("@PersonName", DbType.String)).Value = oelPerson.PersonName;
           cmdPerson.Parameters.Add(new SqlParameter("@LastName", DbType.String)).Value = oelPerson.LastName;
           cmdPerson.Parameters.Add(new SqlParameter("@ParentLevel", DbType.Int32)).Value = oelPerson.IdParent1;
           cmdPerson.Parameters.Add(new SqlParameter("@NIC", DbType.Int32)).Value = oelPerson.Cnic;
           cmdPerson.Parameters.Add(new SqlParameter("@Contact", DbType.String)).Value = oelPerson.Contact;
           cmdPerson.Parameters.Add(new SqlParameter("@Salary", DbType.String)).Value = oelPerson.Salary;
           cmdPerson.Parameters.Add(new SqlParameter("@PersonPic", DbType.Binary)).Value = oelPerson.PersonPic;
           cmdPerson.Parameters.Add(new SqlParameter("@Address", DbType.String)).Value = oelPerson.Address;
           cmdPerson.Parameters.Add(new SqlParameter("@Discription", DbType.String)).Value = oelPerson.Discription;
           cmdPerson.Parameters.Add(new SqlParameter("@NTN", DbType.String)).Value = oelPerson.NTN;
           cmdPerson.Parameters.Add(new SqlParameter("@PersonType", DbType.String)).Value = oelPerson.PersonType;


           if (cmdPerson.ExecuteNonQuery() > -1)
           {
               infoResult.IsSuccess = true;
           }
           else
           {
               infoResult.IsSuccess = false;
           }

           return infoResult;
       }
    }
    
}
