using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class VoucherDetailEL : VouchersEL
    {
        public Int64? IdVoucherDetail 
        { 
            get; 
            set; 
        }
        public Int64? IdTransactionDetail 
        { 
            get; 
            set; 
        }
        public int SeqNo
        {
            get;
            set;
        }       
        public string ColorTemprature
        {
            get;
            set;
        }
        //public string EngineNo
        //{
        //    get;
        //    set;
        //}
        //public string ChasisNo
        //{
        //    get;
        //    set;
        //}
        //public string VehicleModel
        //{
        //    get;
        //    set;
        //}
        //public string VehicleNo
        //{
        //    get;
        //    set;
        //}
        //public string FirstIMEI
        //{
        //    get;
        //    set;
        //}
        //public string SecondIMEI
        //{
        //    get;
        //    set;
        //}
        //public int ColorCode
        //{
        //    get;
        //    set;
        //}
        //public Int64 TotalCartons
        //{
        //    get;
        //    set;
        //}
        public decimal Units
        {
            get;
            set;
        }
        public decimal CurrentStock
        {
            get;
            set;
        }
        public decimal Bonus
        {
            get;
            set;
        }
        public Int64 TotalUnits
        {
            get;
            set;
        }
        public decimal RemainingUnits
        {
            get;
            set;
        }
        public Int64 ClosingUnits
        {
            get;
            set;
        }
        //public decimal UnitPrice
        //{
        //    get;
        //    set;
        //} 
    }
}
