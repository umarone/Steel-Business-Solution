using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class OutSourceWorkTypeEL : AccountsEL
    {
        public Int64? IdOutSourceWorkType { get; set; }
        public string OutSourceWorkTypeCode { get; set; }
        public string OutSourceWorkTypeName { get; set; }
    }
}
