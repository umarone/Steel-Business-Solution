using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
   public class AccountsEL : AccountsLevels
   {
       #region ChartsOfAccounts
       public Int64 IdAccount 
       { 
           get; 
           set; 
       }
       public Int64 IdParent
       {
           get;
           set;
       }
       public string AccountNo
        {
            get;
            set;
        }
       public string PersonalAccountNo { get; set; }
       public string TransactionAccountNo
       {
           get;
           set;
       }
       public string SubAccountNo
       {
           get;
           set;
       }
       public string CashAccountNo
       {
           get;
           set;
       }
       public string EmployeeAccountNo 
       {
           get; 
           set; 
       }
       public string AccountName
       {
            get;
            set;
       }
       public string CashAccountName
       {
           get;
           set;
       }
       public string TradingCode
       {
           get;
           set;
       }
       public string SubCategoryName
       {
           get;
           set;
       }
       public int IdLevel
       {
           get;
           set;
       }
       public int IdHead
       {
           get;
           set;
       }
       public string AccountType
       {
           get;
           set;
       }
       public string Discription
       {
           get;
           set;
       }
       public bool? IsSystemAccount
       {
           get;
           set;
       }
       public bool? IsActive 
       {
           get;
           set; 
       }
       //public int HeaderAccount
       //{
       //    get;
       //    set;
       //}
       //public int Catagory
       // {
       //     get;
       //     set;
       // }
       //public int SubCategory
       //{
       //    get;
       //    set;
       //}
       public bool? IsPrescriber { get; set; }
        #endregion
   }
}
