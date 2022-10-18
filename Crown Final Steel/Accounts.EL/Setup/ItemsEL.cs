using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
   public class ItemsEL : CategoryEL
    {
        #region items
       public Int64? IdItem { get; set; }
       public Int64? IdTradingCo { get; set; }
       public string ItemNo
        {
            get;
            set;
        }
       public Int64? IdCurrentStock
       {
           get;
           set;
       }
       public string Mfg
       {
           get;
           set;
       }
       public string Expiry
       {
           get;
           set;
       }
       public Int32 Seq
       {
           get;
           set;
       }
       public string ProductCode
       {
           get;
           set;
       }
       public string InventoryAccount
       {
           get;
           set;
       }
       public string COGSAccount
       {
           get;
           set;
       }
       public string SalesAccount
       {
           get;
           set;
       }

       public string ItemName
        {
            get;
            set;
        }
       public string BrandName
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
       public string BarCode
       {
           get;
           set;
       }
       public Decimal MRP
       {
           get;
           set;
       }
       public Decimal UnitPrice
       {
           get;
           set;
       }
       public Decimal AVGEvaluationUnitPrice
       {
           get;
           set;
       }
       public Decimal CurrentUnitPrice
       {
           get;
           set;
       }
       public decimal LastPurchaseRate { get; set; }
       public decimal ClosingStock { get; set; }

        public decimal ItemWeight { get; set; }

        public Int32 ReorderLevel
       {
           get;
           set;
       }
       public Int32 StockOnHand
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
       public string EngineNo
       {
           get;
           set;
       }
       public string ChasisNo
       {
           get;
           set;
       }
       public string VehicleModel
       {
           get;
           set;
       }
       public string VehicleNo
       {
           get;
           set;
       }
       public string FirstIMEI
       {
           get;
           set;
       }
       public string SecondIMEI
       {
           get;
           set;
       }
       public int ColorCode
       {
           get;
           set;
       }
       public Int64 TotalCartons
       {
           get;
           set;
       }
       public string Description
        {
            get;
            set;
        }
       public string ProductRegNo
        {
            get;
            set;
        }
       public decimal Qty
        {
            get;
            set;
        }
       public decimal Bonus { get; set; }
       public decimal Balance
       {
           get;
           set;
       }
       public decimal TotalAmount
       {
           get;
           set;
       }
       public DateTime StockOnHandDate
       {
           get;
           set;
       }
       public bool IsNew
       {
           get;
           set;
       }
        public int AutoWeightItemIndex
        {
            get;
            set;
        }
        #endregion
    }
}
