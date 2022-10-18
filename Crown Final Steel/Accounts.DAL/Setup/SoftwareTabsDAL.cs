using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Accounts.Common;
using Accounts.EL;
using System.Data.SqlClient;
using System.Data;

namespace Accounts.DAL
{
    public class SoftwareTabsDAL
    {
        IDataReader objReader;
        public List<TabsEL> GetAllSoftwareTabs(SqlConnection oConn)
        {
            List<TabsEL> oelTabsCollection = new List<TabsEL>();
            using (SqlCommand cmdUsers = new SqlCommand("[Setup].[Proc_GetAllSoftwareTabs]", oConn))
            {
                cmdUsers.CommandType = CommandType.StoredProcedure;
                objReader = cmdUsers.ExecuteReader();
                while (objReader.Read())
                {
                    TabsEL oelTab = new TabsEL();
                    oelTab.IdTab = Validation.GetSafeLong(objReader["SoftwareTab_Id"]);
                    oelTab.TabName = Validation.GetSafeString(objReader["SoftwareTabName"]);
                    oelTab.IsEnabled = Validation.GetSafeBooleanNullable(objReader["IsActive"]);
                    oelTabsCollection.Add(oelTab);
                }
            }
            return oelTabsCollection;
        }
    }
}
