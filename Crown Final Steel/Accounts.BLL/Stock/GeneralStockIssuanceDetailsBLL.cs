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
    public class GeneralStockIssuanceDetailsBLL
    {
        GeneralStockIssuanceDetailDAL dal;
        public GeneralStockIssuanceDetailsBLL()
        {
            dal = new GeneralStockIssuanceDetailDAL();
        }
        public List<VoucherDetailEL> GetEmployeeIssuanceReport(string AccountNo, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetEmployeeIssuanceReport(AccountNo, IdProject, objconn);
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
        public List<VoucherDetailEL> GetEmployeeIssuanceReportByDate(string AccountNo, DateTime StartDate, DateTime EndDate, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetEmployeeIssuanceReportByDate(AccountNo, StartDate, EndDate, IdProject, objconn);
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
        public List<VoucherDetailEL> GetGeneralProductsTotalIssuance(Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetGeneralProductsTotalIssuance(IdProject, objconn);
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
        public List<VoucherDetailEL> GetGeneralProductsTotalIssuanceByDate(DateTime StartDate, DateTime EndDate, Int64 IdProject)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetGeneralProductsTotalIssuanceByDate(StartDate, EndDate, IdProject, objconn);
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
        public List<VoucherDetailEL> GetGeneralProductDetailIssuance(Int64 IdProject, Int64 IdItem)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetGeneralProductDetailIssuance(IdItem, IdProject, objconn);
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
        public List<VoucherDetailEL> GetGeneralProductDetailIssuanceByDate(Int64 IdProject, Int64 IdItem, DateTime StartDate, DateTime EndDate)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetGeneralProductDetailIssuanceByDate(IdProject, IdItem, StartDate, EndDate, objconn);
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
        public decimal GetItemUnPostedIssuanceQuantity(Int64 IdVoucher, Int64 IdProject, Int64 BookNo, Int64 IdItem)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetItemUnPostedIssuanceQuantity(IdVoucher, IdProject, BookNo, IdItem, objconn);
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
