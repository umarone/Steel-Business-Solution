using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.DAL;
using Accounts.Common;
using Accounts.EL;
using System.Data.SqlClient;
using System.Data;

namespace Accounts.BLL
{
    public class SampleDetailBLL
    {
         SamplesDetailDAL dal;
        public SampleDetailBLL()
        {
            dal = new SamplesDetailDAL();
        }
        public List<VoucherDetailEL> GetSampleWithSampleNumber(Int64 SampleNumber, Int64 IdCompany)
         {
             SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
             try
             {
                 objconn.Open();
                 return dal.GetSampleWithSampleNumber(SampleNumber, IdCompany, objconn);
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
        public List<VoucherDetailEL> GetSamplesReturnWithSampleNumber(Int64 SampleNumber, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSamplesReturnWithSampleNumber(SampleNumber, IdCompany, objconn);
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
        public List<VoucherDetailEL> GetCustomerSamples(Int64 AccountNo, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetCustomerSamples(AccountNo, IdCompany, objconn);
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
        public List<VoucherDetailEL> GetCustomerSamplesByDate(string AccountNo, Int64 IdCompany, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetCustomerSamplesByDate(AccountNo, StartDate, EndDate, IdCompany, objconn);
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
        public List<VoucherDetailEL> GetProductsTotalSalmples(Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetProductsTotalSalmples(IdCompany, objconn);
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
        public List<VoucherDetailEL> GetProductsTotalSamplesByDate(DateTime StartDate, DateTime EndDate, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetProductsTotalSamplesByDate(StartDate, EndDate, IdCompany, objconn);
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
        public List<VoucherDetailEL> GetProductDetailSampling(Int64 AccountNo, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetProductDetailSampling(AccountNo, IdCompany, objconn);
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
        public List<VoucherDetailEL> GetProductDetailSamplingByDate(Int64 AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdCompany)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetProductDetailSamplingByDate(AccountNo, StartDate, EndDate, IdCompany, objconn);
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
