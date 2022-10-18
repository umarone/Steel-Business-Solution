using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class UserRolesEL : RoleEL
    {
        public Int64? IdUserRole 
        { 
            get; 
            set; 
        }
        public string RoleAction
        {
            get;
            set;
        }
    }
}
