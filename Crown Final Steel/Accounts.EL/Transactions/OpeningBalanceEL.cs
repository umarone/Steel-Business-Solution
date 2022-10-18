using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class OpeningBalanceEL : UsersEL
    {
        public Int64 IdOpeningBalance { get; set; }
        public Int64 IdTransaction { get; set; }
        public Int64 IdStockReceipt { get; set; }
        public string AccountNo { get; set; }
        public string AccountName { get; set; }
        public string SettlementType { get; set; }
        public Int32 IdHead { get; set; }
        public string EmpCode { get; set; }
        public Int64 Units { get; set; }
        public decimal Amount { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public string TransactionMode { get; set; }
        public bool IsNew { get; set; }
        public bool IsCurrent {get; set;}
        public string Description { get; set; }
        public DateTime OpeningBalanceDate { get; set; }
    }
}
