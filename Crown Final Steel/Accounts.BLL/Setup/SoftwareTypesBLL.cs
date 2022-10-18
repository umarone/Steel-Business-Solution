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
    public class SoftwareTypesBLL
    {
        SoftwareTypesDAL dal;
        EntityoperationInfo infoResult;
        public SoftwareTypesBLL()
        {
            dal = new SoftwareTypesDAL();
            infoResult = new EntityoperationInfo();
        }
        public static List<SoftwareTypesEL> List()
        {
            var manager = new SoftwareTypesDAL();
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
