using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

using Accounts.EL;
using System.Data.Common;

namespace Accounts.DAL
{
    public class BackupDAL
    {
        public bool DbBackUp(SqlConnection objConn,string Path)
        { 
            EntityoperationInfo backupInfo = new EntityoperationInfo();
            bool Status = false;
            int rowsEffected = -1;
            string DataBaseName = string.Empty;
            DbConnectionStringBuilder connectionBuilder = new DbConnectionStringBuilder();
            connectionBuilder.ConnectionString = objConn.ConnectionString;            
            DataBaseName = connectionBuilder["initial catalog"].ToString();
            //string Query = @"backup database " + "DeeJhons" + " to disk ='" + Path + ".bak' with init,stats=10;";
            string Query = @"backup database " + DataBaseName + " to disk ='" + Path + ".bak' with init,stats=10;";
            using (SqlCommand cmdBackup = new SqlCommand(Query, objConn))
            {
                try
                {
                    cmdBackup.CommandType = CommandType.Text;
                    cmdBackup.ExecuteNonQuery();
                    Status = true;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Status;
        }
    }
}
