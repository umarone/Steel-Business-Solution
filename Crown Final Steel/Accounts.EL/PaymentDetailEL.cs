using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
   public class PaymentDetailEL : PaymentMasterEL
   {

       #region PaymentDetail
       public Guid IdPaymentDetail
       {
           get;
           set;
       }
       public bool IsNew
       {
           get;
           set;
       }
       #endregion
   }
}
