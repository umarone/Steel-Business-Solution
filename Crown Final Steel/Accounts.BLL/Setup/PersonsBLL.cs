using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;

namespace Accounts.BLL
{
    public class PersonsBLL
    {
        EntityoperationInfo objOperationInfo;
        PersonsEL oePersons;
        PersonsDAL dal;
        public PersonsBLL()
        {
            oePersons = new PersonsEL();
            objOperationInfo = new EntityoperationInfo();
            dal = new PersonsDAL();
        }
        public EntityoperationInfo InsertPersonAccount(PersonsEL oelPerson, AccountsEL oelChartOfAccount)
        {
            SqlConnection oConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                oConn.Open();
                return dal.InsertPersonAccount(oelChartOfAccount, oelPerson, oConn);
            }
            catch (Exception ex)
            {
                oConn.Close();
                oConn.Dispose();
                throw ex;
            }
            finally
            {
                if (oConn.State == System.Data.ConnectionState.Open)
                {
                    oConn.Close();
                    oConn.Dispose();
                }
            }
        }
        public EntityoperationInfo UpdatePersonAccount(AccountsEL oelChartOfAccount, PersonsEL oelPerson)
        {

            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.UpdatePersonAccount(oelChartOfAccount, oelPerson, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public EntityoperationInfo InsertPerson(PersonsEL oePersons, AccountsEL oelChartsOfAccounts)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                if (dal.InsertCustomers(oePersons, objConn).IsSuccess == true)
                {
                    if (oePersons.IsCustomer)
                    {
                        objOperationInfo = dal.InsertCustomers(oePersons, objConn);
                    }
                    else
                    {
                        objOperationInfo = dal.InsertSuppliers(oePersons, objConn);
                    }
                }
            }
            catch (Exception ex)
            {
                objConn.Close();
                throw ex;
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }
            return objOperationInfo;
        }
        public EntityoperationInfo CreatePersons(PersonsEL oelPerson)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                objOperationInfo = dal.CreatePersons(oelPerson, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                throw ex;
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }
            return objOperationInfo;
        }
        public EntityoperationInfo UpdatePerson(PersonsEL oePersons, AccountsEL oelChartsOfAccounts)
        {

            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();

                if (oePersons.IsCustomer)
                {
                    objOperationInfo = dal.UpdateCustomers(oePersons, objConn);
                }
                else
                {
                    objOperationInfo = dal.UpdateSuppliers(oePersons, objConn);
                }
            }
            catch (Exception ex)
            {
                objConn.Close();
                throw ex;
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }
            return objOperationInfo;
        }
        public List<PersonsEL> VerifyAccount(Int64 IdProject, string Type, string AccountNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.VerifyAccount(IdProject, Type, AccountNo, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<PersonsEL> GetPersonByAccount(Int64 IdProject, string AccountNo)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetPersonByAccount(IdProject, AccountNo, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<PersonsEL> SearchPersonsByAccountNo(string AccountNo, Int64 IdCompany)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.SearchPersonsByAccountNo(AccountNo, IdCompany, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<PersonsEL> SearchPersonByPersonName(string PersonName, Int64 IdCompany)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.SearchPersonByPersonName(PersonName, IdCompany, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<PersonsEL> GetPersonByAccountNo(string AccountNo, Int64 IdProject)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetPersonByAccountNo(AccountNo, IdProject, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<PersonsEL> GetPersonById(Int64 IdPerson)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetPersonById(IdPerson, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public EntityoperationInfo UpdatePerson(PersonsEL oelPerson)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.UpdatePerson(oelPerson, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == System.Data.ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
    }
}


