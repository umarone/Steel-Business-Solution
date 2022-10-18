using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
   public class PurchaseMasterEL : VouchersEL
   {
       #region PurchaseMaster      
        public string SupplierNo
        {
            get;
            set;
        }
        public string BillNo
        {
            get;
            set;
        }
        public decimal TotalAmount
        {
            get;
            set;
        }
        public decimal CashPaid
        {
            get;
            set;
        }
        public string PaidAccountNo
        {
            get;
            set;
        }
        public string PaidAccountDescription
        {
            get;
            set;
        }
        public decimal Balance
        {
            get;
            set;
        }
        #endregion
    }
}
