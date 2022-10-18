using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class RoleEL : UsersEL
    {
        public Int64? IdRole 
        { 
            get; 
            set;
        }
        public string RoleName
        {
            get;
            set;
        }
        public string RoleType
        {
            get;
            set;
        }
    }
}
