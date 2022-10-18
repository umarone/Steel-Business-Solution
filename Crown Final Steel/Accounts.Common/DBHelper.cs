using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Configuration;

namespace Accounts.Common
{
    public class DBHelper
    {
        public static string DataConnection
        {
            get { return ConfigurationManager.ConnectionStrings["Feroz"].ConnectionString; }
        }
                 
    }
}
