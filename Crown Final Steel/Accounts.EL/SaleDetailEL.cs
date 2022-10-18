using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
   public class SaleDetailEL : VouchersEL
   {
       #region SaleDetail
       public Guid IdSales
       {
           get;
           set;
       }
       public Guid IdSalesReturn
       {
           get;
           set;
       }
       public Guid IdTransaction
       {
           get;
           set;
       }
       public Guid IdPrescriberTransaction
       {
           get;
           set;
       }

        public int Seq
        {
            get;
            set;
        }
        public string ItemNo
        {
            get;
            set;
        }
        public string ItemName
        {
            get;
            set;
        }
        public string Power
        {
            get;
            set;
        }
        public string ColorTemprature
        {
            get;
            set;
        }
        public string PrescriberAccountNo
        {
            get;
            set;
        }
        public decimal CommissionPercentage
        {
            get;
            set;
        }
        public decimal TotalCommissionAmount
        {
            get;
            set;
        }
        public bool? IsPrescriber 
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
        public Int64 Bonus
        {
            get;
            set;
        }
        public decimal UnitPrice
        {
            get;
            set;
        }
        //public decimal Discount
        //{
        //    get;
        //    set;
        //}        
        #endregion
    }
}
