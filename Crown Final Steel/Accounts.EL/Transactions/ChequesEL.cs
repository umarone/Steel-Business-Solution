using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class ChequesEL : VouchersEL
    {
        public Int64 IdCheque { get; set; }
        public string BankName { get; set; }
        public Int32 ChequeType { get; set; }
        public string ChequeTypeHeader { get; set; }
        public Int32 ChequeStatus { get; set; }
        public string ChequeStatusHeader { get; set; }
        public Int32 ChequeDaysRemaining { get; set; }
        public DateTime ChequeGivenTakenDate { get; set; }
        public DateTime ChequeWithDrawlDate { get; set; }
    }
}
