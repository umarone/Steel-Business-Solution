using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class JournalVoucherEL : VouchersEL
    {
        public Guid IdJVDetail { get; set; }
        public string JVType { get; set; }
    }
}
