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
    public class GeneralStockIssuanceHeadBLL
    {
        GeneralStockIssuanceHeadDAL dal;
        public GeneralStockIssuanceHeadBLL()
        {
            dal = new GeneralStockIssuanceHeadDAL();
        }
        public Int64 GetMaxGeneralStoreStockNumber(Int64 IdProject, Int64 BookNo, Int32 StoreType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetMaxGeneralStoreStockNumber(IdProject, BookNo, StoreType, objconn);
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
        public EntityoperationInfo CreateGeneralStockIssuance(VouchersEL oelVoucher, List<VoucherDetailEL> oelIssuanceDetail)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.CreateGeneralStockIssuance(oelVoucher, oelIssuanceDetail, objconn);
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
        public bool UpdateGeneralStockIssuance(VouchersEL oelVoucher, List<VoucherDetailEL> oelIssuanceDetail)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.UpdateGeneralStockIssuance(oelVoucher, oelIssuanceDetail, objconn);
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
        public List<VoucherDetailEL> GetGeneralStockIssuance(Int64 IdIssuance, Int64 IdProject, Int64 BookNo, Int32 StoreType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetGeneralStockIssuance(IdIssuance, IdProject, BookNo, StoreType, objconn);
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
        public List<VoucherDetailEL> GetGeneralStockIssuanceWithIssuanceNumber(Int64 IssuanceNo, Int64 IdProject, Int64 BookNo, Int32 StoreType)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetGeneralStockIssuanceWithIssuanceNumber(IssuanceNo, IdProject, BookNo, StoreType, objconn);
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
