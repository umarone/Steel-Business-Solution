using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data;
using System.Data.SqlClient;
using Accounts.Common;
using Accounts.DAL;
using Accounts.EL;

namespace Accounts.BLL
{
    public class PrescriberSampleDetailVoucherBLL
    {
        PrescriberSampleDetailDAL dal;
        public PrescriberSampleDetailVoucherBLL()
        {
            dal = new PrescriberSampleDetailDAL();
        }
        public List<PrescriberSampleDetailEL> GetPrescriberSampleDetailWithSampleNumber(Int64 SampleNumber)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetPrescriberSampleDetailWithSampleNumber(SampleNumber, objconn);
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
        public List<PrescriberSampleDetailEL> GetSamplePrescriber(Int64 SampleNumber, string AccountNo)
        {
            SqlConnection objconn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objconn.Open();
                return dal.GetSamplePrescriber(SampleNumber, AccountNo, objconn);
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
