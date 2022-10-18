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

    public class SamplesHeadBLL
    {
        SamplesHeadDAL dal;
        public SamplesHeadBLL()
        {
            dal = new SamplesHeadDAL();
        }
        //public bool InsertSales(VouchersEL oelVoucher, List<SaleDetailEL> oelSaleCollection, List<TransactionsEL> oelTransactionsCollection, List<StockReceiptEL> oelStockReceiptCollection)
        public bool InsertSamples(VouchersEL oelVoucher, List<VoucherDetailEL> oelSampleCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.InsertSales(oelVoucher, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.InsertSamples(oelVoucher, oelSampleCollection, objconn);
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
        //public bool UpdateSales(VouchersEL oelSaleMaster, List<SaleDetailEL> oelSaleCollection, List<TransactionsEL> oelTransactionsCollection, List<StockReceiptEL> oelStockReceiptCollection)
        public bool UpdateSamples(VouchersEL oelVoucher, List<VoucherDetailEL> oelSampleCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.UpdateSales(oelSaleMaster, oelSaleCollection, oelTransactionsCollection, oelStockReceiptCollection, objconn);
                return dal.UpdateSamples(oelVoucher, oelSampleCollection, objconn);
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
        public bool InsertSamplesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelSampleReturnCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                //return dal.InsertSalesReturn(oelVoucher, oelSaleCollection, oelTransactionsCollection, oelStockRecieptCollection, objconn);
                return dal.InsertSamplesReturn(oelVoucher, oelSampleReturnCollection, objconn);
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
        public bool UpdateSamplesReturn(VouchersEL oelVoucher, List<VoucherDetailEL> oelSampleReturnCollection)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();                
                return dal.UpdateSamplesReturn(oelVoucher, oelSampleReturnCollection, objconn);
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
        public bool DeleteSample(Int64? IdVoucher, string TransactionType, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.DeleteSample(IdVoucher, TransactionType, IdCompany, objconn);
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
        public bool DeleteSampleReturn(Int64? IdVoucher, string TransactionType, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.DeleteSampleReturn(IdVoucher, TransactionType, IdCompany, objconn);
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
        public bool CheckSamples(Int64 IdCompany, Int64 VoucherNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.CheckSamples(IdCompany, VoucherNo, objconn);
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
        public List<VouchersEL> GetSamplesDays(Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSamplesDays(IdCompany, objconn);
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
        public List<VouchersEL> GetSamplesDaysByDate(Int64 IdCompany, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSamplesDaysByDate(IdCompany, StartDate, EndDate, objconn);
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
        public List<VouchersEL> GetSamplesDaysByEmployess(Int64 IdCompany, string EmpCode)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSamplesDaysByEmployess(IdCompany, EmpCode, objconn);
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
        public List<VouchersEL> GetSamplesDaysByEmployeesByDate(Int64 IdCompany, string EmpCode, DateTime StartDate, DateTime EndDate)
        {

            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSamplesDaysByEmployeesByDate(IdCompany, EmpCode, StartDate, EndDate, objconn);
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
