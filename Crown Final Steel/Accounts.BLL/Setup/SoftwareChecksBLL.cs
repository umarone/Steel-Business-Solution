using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using Accounts.EL;
using Accounts.DAL;
using Accounts.Common;

namespace Accounts.BLL
{
    public class SoftwareChecksBLL
    {
        SoftwareChecksDAL dal;
        EntityoperationInfo infoResult;
        public SoftwareChecksBLL()
        {
            dal = new SoftwareChecksDAL();
            infoResult = new EntityoperationInfo();
        }
        public static List<SoftwareChecksEL> List()
        {
            var manager = new SoftwareChecksDAL();
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return manager.List(objConn);
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
