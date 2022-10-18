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
    public class SoftwareTypesDAL
    {
        IDataReader objReader;
        public SoftwareTypesDAL()
        { 
        
        }
        public List<SoftwareTypesEL> List(SqlConnection objConn)
        {
            string sProcedure = "[Setup].[Proc_GetAllSoftwareTypes]";
            SqlCommand cmdSoftTypes = new SqlCommand(sProcedure, objConn);
            List<SoftwareTypesEL> list = new List<SoftwareTypesEL>();
            objReader = cmdSoftTypes.ExecuteReader();
            while (objReader.Read())
            {

                SoftwareTypesEL obj = new SoftwareTypesEL();
                obj.IdSoftwareType = Validation.GetSafeLong(objReader["SoftwareType_Id"]);
                obj.SoftwareType = Validation.GetSafeString(objReader["SoftwareType"]);
                obj.SoftwareDiscription = Validation.GetSafeString(objReader["SoftwareDiscription"]);
                obj.ActiveSoftware = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                                
                list.Add(obj);
            }
            return list;
        }
    }
}
