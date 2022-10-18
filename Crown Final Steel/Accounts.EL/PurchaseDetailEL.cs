using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
   public class PurchaseDetailEL : PurchaseMasterEL
   {
       #region PurchaseDetail
       public Guid IdPurchaseDetail 
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
       public string Expiry
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
       public decimal UnitPrice
        {
            get;
            set;
        }
       public decimal Amount
        {
            get;
            set;
        }   
        #endregion
    }
}
