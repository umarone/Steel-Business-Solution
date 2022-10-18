using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class SoftwareTypesEL
    {
        public Int64 IdSoftwareType { get; set; }
        public string SoftwareType { get; set; }
        public string SoftwareDiscription { get; set; }
        public bool? ActiveSoftware { get; set; }
    }
}
