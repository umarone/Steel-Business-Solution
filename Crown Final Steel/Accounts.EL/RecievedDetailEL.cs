using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
   public class RecievedDetailEL : RecievedMasterEL
   {
       #region RecievedDetail
       public Guid IdRecievedDetail 
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
