using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;
using System.Data.SqlClient;

namespace Accounts.BLL
{
    public class VoucherBLL
    {
        VoucherDAL dal;
        public VoucherBLL()
        {
            dal = new VoucherDAL();
        }
        public EntityoperationInfo InsertVouchersHead(VouchersEL oelVoucher, List<VoucherDetailEL> oelDetailCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.InsertVouchersHead(oelVoucher, oelDetailCollection,objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public EntityoperationInfo UpdateVouchersHead(VouchersEL oelVoucher, List<VoucherDetailEL> oelDetailCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.UpdateVouchersHead(oelVoucher, oelDetailCollection, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VoucherDetailEL> GetTransactionalVouchersByType(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetTransactionalVouchersByType(IdVoucher, IdProject, BookNo, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VoucherDetailEL> GetTransactionalVouchersByTypeAndNumber(Int64 VoucherNo, Int64 IdProject, Int64 BookNo, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetTransactionalVouchersByTypeAndNumber(VoucherNo, IdProject, BookNo, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }        
        public bool DeleteVouchers(Int64? IdVoucher, Int64 VoucherNo, string TransactionType, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.DeleteVouchers(IdVoucher,VoucherNo,TransactionType,IdCompany, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public bool DeleteFinancialVouchers(Int64? IdVoucher, string TransactionType, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.DeleteFinancialVouchers(IdVoucher, TransactionType, IdProject, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public bool DeleteChildRecords(Int64 Id, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.DeleteChildRecords(Id, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetAllTransactionalVoucherByTypeAndDate(Int64 IdProject, Int64 BookNo, string VoucherType, DateTime VoucherDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllTransactionalVoucherByTypeAndDate(IdProject, BookNo, VoucherType, VoucherDate, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetAllTransactionalVoucherByTypeAndEditedDate(Int64 IdProject, Int64 BookNo, string VoucherType, DateTime VoucherDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllTransactionalVoucherByTypeAndEditedDate(IdProject, BookNo, VoucherType, VoucherDate, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }

        public List<VouchersEL> GetAllTransactionalVoucherByTypeAndAccountNo(Int64 IdProject, Int64 BookNo, string AccountNo, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllTransactionalVoucherByTypeAndAccountNo(IdProject, BookNo, AccountNo, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }  
        }
        public List<VouchersEL> GetAllTransactionalVoucherByType(Int64 IdProject, Int64 BookNo, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllTransactionalVoucherByType(IdProject, BookNo, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }  
        }
        public List<VouchersEL> GetVouchersByTypeAndDate(Int64 IdCompany, string VoucherType, DateTime VoucherDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetVouchersByTypeAndDate(IdCompany, VoucherType, VoucherDate, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetVouchersByTypeAndVoucherNumber(Int64 IdCompany, string VoucherType, Int64 VoucherNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetVouchersByTypeAndVoucherNumber(IdCompany, VoucherType, VoucherNo, objconn);
            } 
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetVouchersByTypeAndAccountNo(Int64 IdCompany, string VoucherType, string AccountNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetVouchersByTypeAndAccountNo(IdCompany, VoucherType, AccountNo, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetAllVouchersByType(Int64 IdCompany, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllVouchersByType(IdCompany, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public Int64 GetTotalTransactionalVouchersByType(Int64 IdProject, Int64 BookNo, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetTotalTransactionalVouchersByType(IdProject, BookNo, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public string GetMaxVoucherNumber(string VoucherType, Int64 IdProject, Int64 BookNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMaxVoucherNumber(VoucherType, IdProject, BookNo, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;                
            }
            finally
            { 
                if(objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<PersonsEL> GetStockSupplier(string AccountNo, Int64 VoucherNo, Int64 IdCompany)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetStockSupplier(AccountNo, VoucherNo, IdCompany, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }

        }
        public List<PersonsEL> GetSaleCustomer(Int64? IdVoucher, string AccountNo, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSaleCustomer(IdVoucher, AccountNo, IdCompany, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<PersonsEL> GetSalesReturnCustomer(Int64? IdVoucher, string AccountNo, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSalesReturnCustomer(IdVoucher, AccountNo, IdCompany, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<PersonsEL> GetSampleCustomer(Int64 SampleNumber, string AccountNo, string Transactiontype, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSampleCustomer(SampleNumber, AccountNo, Transactiontype, IdCompany, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<TransactionsEL> GetTransactionsByVoucherAndType(Int64 IdCompany, Int64? IdVoucher, Int64 VoucherNo, string VoucherType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetTransactionsByVoucherAndType(IdCompany, IdVoucher, VoucherNo, VoucherType, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<TransactionsEL> GetAlternateTransactionsByVoucherAndType(Int64 IdCompany, Int64? IdVoucher, Int64 VoucherNo, string VoucherType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAlternateTransactionsByVoucherAndType(IdCompany, IdVoucher, VoucherNo, VoucherType, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetUnPostedVouchers(Int64 IdCompany, string VoucherType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetUnPostedVouchers(IdCompany, VoucherType, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public EntityoperationInfo PostUnPostedVouchers(string VoucherType, Int64 VoucherNo, Int64 IdCompany)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.PostUnPostedVouchers(VoucherType, VoucherNo, IdCompany, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public List<TransactionsEL> GetTransactions(Int64? IdVoucher, string VoucherType, Int64 IdCompany)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetTransactions(IdVoucher, VoucherType, IdCompany, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public EntityoperationInfo UpdateDaysStatus(VouchersEL oelVoucher, int IsSale)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.UpdateDaysStatus(oelVoucher, IsSale, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }
        public bool CheckVoucherNo(Int64? IdCompany, Int64 VoucherNo, string VoucherType)
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.CheckVoucherNo(IdCompany, VoucherNo, VoucherType, objConn);
            }
            catch (Exception ex)
            {
                objConn.Close();
                objConn.Dispose();
                throw ex;
            }
            finally
            {
                if (objConn.State == ConnectionState.Open)
                {
                    objConn.Close();
                    objConn.Dispose();
                }
            }
        }

        public List<VouchersEL> GetLastVoucherTransactionByType(Int64 IdProject, Int64 BookNo, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetLastVoucherTransactionByType(IdProject, BookNo, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetFirstVoucherTransactionByType(Int64 IdProject, Int64 BookNo, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetFirstVoucherTransactionByType(IdProject, BookNo, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }

        public Int64 GetTransactionalVoucherIdByVoucherNoForPaging(Int64 IdProject, Int64 BookNo, Int64 VoucherNo, string VoucherType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetTransactionalVoucherIdByVoucherNoForPaging(IdProject, BookNo, VoucherNo, VoucherType, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        #region All Stock Vouchers
        public List<VouchersEL> GetAllStockTransactionalVouchersByTypeAndDate(Int64 IdProject, Int64 BookNo, string VoucherType, DateTime VoucherDate, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllStockTransactionalVouchersByTypeAndDate(IdProject, BookNo, VoucherType, VoucherDate, IsNetTransaction, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetAllStockTransactionalVouchersByTypeAndEditedDate(Int64 IdProject, Int64 BookNo, string VoucherType, DateTime VoucherDate, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllStockTransactionalVouchersByTypeAndEditedDate(IdProject, BookNo, VoucherType, VoucherDate, IsNetTransaction, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
            public List<VouchersEL> GetAllStockTransactionalVoucherByTypeAndAccountNo(Int64 IdProject, Int64 BookNo, string AccountNo, string VoucherType, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllStockTransactionalVoucherByTypeAndAccountNo(IdProject, BookNo, AccountNo, VoucherType, IsNetTransaction, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetAllStockTransactionalVoucherByType(Int64 IdProject, Int64 BookNo, string VoucherType, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllStockTransactionalVoucherByType(IdProject, BookNo, VoucherType, IsNetTransaction, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public Int64 GetAllStockTotalTransactionalVouchersByType(Int64 IdProject, Int64 BookNo, string VoucherType, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetAllStockTotalTransactionalVouchersByType(IdProject, BookNo, VoucherType, IsNetTransaction, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public List<VouchersEL> GetStockLastVoucherTransactionByType(Int64 IdProject, Int64 BookNo, string VoucherType, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetStockLastVoucherTransactionByType(IdProject, BookNo, VoucherType, IsNetTransaction, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        #endregion
        #region Customers Invoices
        public List<VoucherDetailEL> GetCustomersInvoices(string AccountNo, Int64 IdProject, Int64 BookNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetCustomersInvoices(AccountNo, IdProject, BookNo, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        public EntityoperationInfo UpdateCustomerInvoicePreviousBalance(Int64 IdVoucher, decimal NewBalance)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.UpdateCustomerInvoicePreviousBalance(IdVoucher, NewBalance, objconn);
            }
            catch (Exception ex)
            {
                objconn.Close();
                objconn.Dispose();
                throw ex;
            }
            finally
            {
                if (objconn.State == ConnectionState.Open)
                {
                    objconn.Close();
                    objconn.Dispose();
                }
            }
        }
        #endregion
    }
}
