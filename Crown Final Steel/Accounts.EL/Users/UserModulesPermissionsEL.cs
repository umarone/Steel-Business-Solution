using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class UserModulesPermissionsEL : UserModulesEL
    {
        public Int64? IdMoudlePermission 
        { 
            get; 
            set; 
        }
        public Boolean? Saving 
        {
            get; 
            set; 
        }
        public Boolean? Updating
        {
            get;
            set;
        }
        public Boolean? Deleting
        {
            get;
            set;
        }
        public Boolean? Viewing
        {
            get;
            set;
        }
        public Boolean? Posting
        {
            get;
            set;
        }
        public Boolean? Printing
        {
            get;
            set;
        }
    }
}
