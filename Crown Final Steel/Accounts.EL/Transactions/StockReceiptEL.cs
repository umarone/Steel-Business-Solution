using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class StockReceiptEL : VouchersEL
    {
        public Guid IdStockReceipt
        {
            get;
            set;
        }
        public Guid IdUser
        {
            get;
            set;
        }
        public string ItemNo
        {
            get;
            set;
        }
        public string Power
        {
           get;
           set;
        }
        public string ColorTemperature
        {
            get;
            set;
        }
        public string PackingSize
        {
            get;
            set;
        }
        public string BatchNo
        {
            get;
            set;
        } 
        public Int64 Units
        {
            get;
            set;
        }
        public Int64 RemainingUnits
        {
            get;
            set;
        }
        public DateTime StockDate
        {
            get;
            set;
        }
        public string ActionType
        {
            get;
            set;
        }
        public decimal Opening
        {
            get;
            set;
        }
        public decimal Purchases
        {
            get;
            set;
        }
        public decimal PurchasesReturn
        {
            get;
            set;
        }
        public decimal Returns
        {
            get;
            set;
        }
        public decimal Sales
        {
            get;
            set;
        }
        public Int64 Samples
        {
            get;
            set;
        }
        public Int64 SamplesReturn
        {
            get;
            set;
        }
        public Int64 JvIn
        {
            get;
            set;
        }
        public Int64 JvOut
        {
            get;
            set;
        }
        public decimal Closing
        {
            get;
            set;
        }
        public decimal NVR
        {
            get;
            set;
        }
        public decimal AVR
        {
            get;
            set;
        }
    }
}
