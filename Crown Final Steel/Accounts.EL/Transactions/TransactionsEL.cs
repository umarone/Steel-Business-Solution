using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
   public class TransactionsEL : VoucherDetailEL
   {
       #region Transactions
       public Int64 TransactionID
       {
           get;
           set;
       }
       public Int64 IdDetail
       {
           get;
           set;
       }
       //public string AccountName
       //{
       //    get;
       //    set;
       //}
       //public string AccountType
       //{
       //    get;
       //    set;
       //}
       //public long TotalSales
       //{
       //    get;
       //    set;
       //}
       public decimal TotalRecieveables
       {
           get;
           set;
       }
       public decimal TotalRecieved
       {
           get;
           set;
       }
       public decimal TotalReturns
       {
           get;
           set;
       }
       public decimal TotalPayables
       {
           get;
           set;
       }
       //public int Seq
       // {
       //     get;
       //     set;
       // }
       public decimal OpeningBalance
       {
           get;
           set;
       }
       //public decimal ClosingBalance
       //{
       //    get;
       //    set;
       //}
       //public string TypedClosingBalance
       //{
       //    get;
       //    set;
       //}
       public string BalanceType
       {
           get;
           set;
       }
       public decimal unitprice
       {
           get;
           set;
       }
        public decimal Qty
        {
            get;
            set;
        }
        public bool IsNew { get; set; }
      #endregion
    }
}
