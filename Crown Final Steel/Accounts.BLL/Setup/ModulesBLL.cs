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
    public class ModulesBLL
    {
        ModulesDAL dal;
        public ModulesBLL()
        {
            dal = new ModulesDAL();
        }
        public List<ModulesEL> GetAllModules()
        {
            SqlConnection objConn = new SqlConnection(DBHelper.DataConnection);
            try
            {
                objConn.Open();
                return dal.GetAllModules(objConn);
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
