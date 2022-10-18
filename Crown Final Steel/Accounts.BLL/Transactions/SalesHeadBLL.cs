using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using System.Data;
using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;

namespace Accounts.BLL
{
    public class SalesHeadBLL
    {
        #region Variables
        SalesHeadDAL dal;
        public SalesHeadBLL()
        {
            dal = new SalesHeadDAL();
        }
        #endregion
        #region Sales Related Methods
        public Int64 GetMaxSalesInvoiceNumberBySaleType(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, int SaleType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.GetMaxSalesInvoiceNumberBySaleType(IdProject, BookNo, IsNetTransaction, SaleType, objconn);
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
        public EntityoperationInfo InsertSales(VouchersEL oelVoucher, List<VoucherDetailEL> oelSaleCollection, List<VoucherDetailEL> oelProductsProfitLoss, List<VoucherDetailEL> oelSalesTransactionsCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.InsertSales(oelVoucher, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.InsertSales(oelVoucher, oelSaleCollection, oelProductsProfitLoss, oelSalesTransactionsCollection, objconn);
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
        public EntityoperationInfo UpdateSales(VouchersEL oelVoucher, List<VoucherDetailEL> oelSaleCollection, List<VoucherDetailEL> oelProductsProfitLossCollection, List<VoucherDetailEL> oelSalesTransactionsCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.UpdateSales(oelVoucher, oelSaleCollection, oelProductsProfitLossCollection, oelSalesTransactionsCollection, objconn);
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
        public EntityoperationInfo UpdateInvoicesAndReturnsDates(Int64 IdVoucher, DateTime ChangedDate, Int32 Type)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.UpdateInvoicesAndReturnsDates(IdVoucher, ChangedDate, Type, objconn);
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
        public List<VoucherDetailEL> GetSalesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.GetSalesTransactions(IdVoucher, IdProject, BookNo, IsNetTransaction, objconn);
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
        public DataSet GetRdlcSalesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetRdlcSalesTransactions(IdVoucher, IdProject, BookNo, IsNetTransaction, objconn);
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
        public List<VoucherDetailEL> GetDistributionSalesTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.GetDistributionSalesTransactions(IdVoucher, IdProject, BookNo, objconn);
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
        public List<VoucherDetailEL> GetDistributionSalesTransactionsByNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.GetDistributionSalesTransactionsByNumber(IdVoucher, IdProject, BookNo, objconn);
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
        public List<VoucherDetailEL> GetSalesTransactionsByNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.GetSalesTransactionsByNumber(IdVoucher, IdProject, BookNo, IsNetTransaction, objconn);
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
        public List<VoucherDetailEL> GetSalesSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSalesSubTransactions(IdVoucher, IdProject, BookNo, IsNetTransaction, objconn);
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
        public List<VoucherDetailEL> GetDistributionSalesSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetDistributionSalesSubTransactions(IdVoucher, IdProject, BookNo, objconn);
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
        public List<VouchersEL> GetCustomersSalesUnpostedVouchers(Int64 IdProject, Int64 BookNo, string AccountNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetCustomersSalesUnpostedVouchers(IdProject, BookNo, AccountNo, objconn);
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
        public List<VoucherDetailEL> GetAllProjectWiseDatedSales(Int64 IdProject, Int64 BookNo, string AccountNo, DateTime StartDate, DateTime EndDate, bool IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.GetAllProjectWiseDatedSales(IdProject, BookNo, AccountNo, StartDate, EndDate, IsNetTransaction, objconn);
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
        public bool DeleteSalesByVoucher(Int64 IdVoucher, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.DeleteSalesByVoucher(IdVoucher, IdProject, objconn);
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
        #region Sales Return Related Methods
        public Int64 GetMaxSalesReturnInvoiceNumberBySaleReturnType(Int64 IdProject, Int64 BookNo, bool IsNetTransaction, int SaleType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.GetMaxSalesReturnInvoiceNumberBySaleReturnType(IdProject, BookNo, IsNetTransaction, SaleType, objconn);
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
        public EntityoperationInfo InsertSalesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelSaleCollection, List<VoucherDetailEL> oelTransactionsCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.InsertSalesReturn(oelVoucher, oelSaleCollection, oelTransactionsCollection, oelStockRecieptCollection, objconn);
                return dal.InsertSalesReturn(oelVoucher, oelSaleCollection, oelTransactionsCollection, objconn);
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
        public EntityoperationInfo UpdateSalesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelSaleCollection, List<VoucherDetailEL> oelTransactionsCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSalesReturn(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.UpdateSalesReturn(oelVoucher, oelSaleCollection, oelTransactionsCollection, objconn);
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
        public List<VoucherDetailEL> GetSalesReturnTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSalesReturnTransactions(IdVoucher, IdProject, BookNo, IsNetTransaction, objconn);
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
        public List<VoucherDetailEL> GetSalesReturnTransactionsByNumber(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSalesReturnTransactionsByNumber(IdVoucher, IdProject, BookNo, IsNetTransaction, objconn);
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
        public List<VoucherDetailEL> GetSalesReturnTransactionsOnInvoiceBasis(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSalesReturnTransactionsOnInvoiceBasis(IdVoucher, IdProject, BookNo, IsNetTransaction, objconn);
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
        public List<VoucherDetailEL> GetSalesReturnSubTransactions(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, bool? IsNetTransaction)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSalesReturnSubTransactions(IdVoucher, IdProject, BookNo, IsNetTransaction, objconn);
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
        public bool DeleteSalesReturnByVoucher(Int64 IdVoucher, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.DeleteSalesReturnByVoucher(IdVoucher, IdProject, objconn);
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
        public bool UpdateSamplesHeadForSales(Int64? IdVoucher, bool IsSold)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.UpdateSamplesHeadForSales(IdVoucher, IsSold, objconn);
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
        public bool CheckSales(Int64 IdCompany, Int64 VoucherNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.CheckSales(IdCompany,VoucherNo, objconn);
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
        public List<VouchersEL> GetSaleDays(Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSaleDays(IdCompany, objconn);
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
        public List<VouchersEL> GetSaleDaysByDate(Int64 IdCompany, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSaleDaysByDate(IdCompany, StartDate, EndDate, objconn);
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
        public List<VouchersEL> GetSaleDaysByEmployees(Int64 IdCompany, string EmpCode)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSaleDaysByEmployees(IdCompany, EmpCode, objconn);
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
        public List<VouchersEL> GetSaleDaysByEmployeesByDate(Int64 IdCompany, string EmpCode, DateTime StartDate, DateTime EndDate)
        {

            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSaleDaysByEmployeesByDate(IdCompany, EmpCode, StartDate, EndDate, objconn);
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
        public List<VouchersEL> GetDateWiseSalesReport(Int64 IdProject, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetDateWiseSalesReport(IdProject, StartDate, EndDate, objconn);
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
        public List<VouchersEL> GetDateAndEmployeeWiseSalesReport(Int64 IdCompany, string EmpCode, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetDateAndEmployeeWiseSalesReport(IdCompany, EmpCode, StartDate, EndDate, objconn);
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
        public List<VouchersEL> GetDateWiseClaimReturnReport(Int64 IdProject, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetDateWiseClaimReturnReport(IdProject, StartDate, EndDate, objconn);
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
        public List<VouchersEL> GetClaimedVouchersByAccountNo(Int64 IdCompany, string AccountNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetClaimedVouchersByAccountNo(IdCompany, AccountNo, objconn);
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
        public List<VoucherDetailEL> GetClaimedVouchersDetail(Guid IdVoucher)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetClaimedVouchersDetail(IdVoucher, objconn);
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
   }
}
