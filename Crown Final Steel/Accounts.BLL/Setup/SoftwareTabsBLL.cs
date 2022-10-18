using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.SqlClient;
using Accounts.Common;
using Accounts.EL;
using Accounts.DAL;

namespace Accounts.BLL
{
    public class SoftwareTabsBLL
    {
        SoftwareTabsDAL dal;
        public SoftwareTabsBLL()
        {
            dal = new SoftwareTabsDAL();
        }
        public List<TabsEL> GetAllSoftwareTabs()
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAllSoftwareTabs(objConn);
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
        }       
    }
}
