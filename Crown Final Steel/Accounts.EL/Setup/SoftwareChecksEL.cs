using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class SoftwareChecksEL
    {
        public Int64 IdSoftwareCheck { get; set; }
        public string SoftwareCheckName { get; set; }
        public string FormName { get; set; }
        public string ModuleName { get; set; }
        public bool? IsMust { get; set; }
    }
}
