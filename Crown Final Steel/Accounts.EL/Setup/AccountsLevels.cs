using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class AccountsLevels : UsersEL
    {
        public Int32 IdParent1 { get; set; }
        public string Parent1_Name { get; set; }

        public Int32 IdParent2 { get; set; }
        public string Parent2_Name { get; set; }
    }
}
