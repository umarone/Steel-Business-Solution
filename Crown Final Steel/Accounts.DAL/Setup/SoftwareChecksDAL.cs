using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Data.Common;
using Accounts.EL;
using System.Data.SqlClient;
using Accounts.Common;
using System.Data;

namespace Accounts.DAL
{
    public class SoftwareChecksDAL
    {
        IDataReader objReader;
        public SoftwareChecksDAL()
        { 
        
        }
        public List<SoftwareChecksEL> List(SqlConnection objConn)
        {
            string sProcedure = "[Setup].[Proc_GetAllSoftwareChecks]";
            SqlCommand cmdSoftTypes = new SqlCommand(sProcedure, objConn);
            List<SoftwareChecksEL> list = new List<SoftwareChecksEL>();
            objReader = cmdSoftTypes.ExecuteReader();
            while (objReader.Read())
            {

                SoftwareChecksEL obj = new SoftwareChecksEL();
                obj.IdSoftwareCheck = Validation.GetSafeLong(objReader["Check_Id"]);
                obj.SoftwareCheckName = Validation.GetSafeString(objReader["CheckName"]);
                obj.FormName = Validation.GetSafeString(objReader["FormName"]);
                obj.ModuleName = Validation.GetSafeString(objReader["ModuleName"]);
                obj.IsMust = Validation.GetSafeBooleanNullable(objReader["IsMust"]);

                list.Add(obj);
            }
            return list;
        }
    }
}
