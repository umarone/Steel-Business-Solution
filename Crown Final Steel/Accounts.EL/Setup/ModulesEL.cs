using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class ModulesEL : UsersEL
    {
        public Int64 IdModule 
        { 
            get; 
            set; 
        }
        public string ModuleName
        {
            get;
            set;
        }
        public string ModuleType
        {
            get;
            set;
        }
        public string ModuleHeader 
        { 
            get; 
            set; 
        }
        public string ModuleCategory
        {
            get;
            set;
        }
        public decimal ModuleCost
        {
            get;
            set;
        }
        public bool? IsEnabled
        {
            get;
            set;
        }       

    }
}
