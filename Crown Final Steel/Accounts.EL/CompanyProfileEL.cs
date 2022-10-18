using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
   public class CompanyProfileEL
   {
       #region CompanyProfile
       public int CompanyNo
        {
            get;
            set;
        }
       public string CompanyName
        {
            get;
            set;
        }
       public string Contact
        {
            get;
            set;
        }
       public string Address
       {
           get;
           set;
       }
       public string NTN
       {
           get;
           set;
       }
       public DateTime StartDate
       {
           get;
           set;
       }
       public DateTime EndDate
       {
           get;
           set;
       }
        #endregion

    }
}
