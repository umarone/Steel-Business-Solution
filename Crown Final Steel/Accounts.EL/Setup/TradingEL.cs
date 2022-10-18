using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class TradingEL : AccountsEL
    {
        public Int64 IdTrading 
        {
            get;
            set;
        }
        public Int64 TradingCode 
        { 
            get;
            set; 
        }
        public string TradingName 
        { 
            get; 
            set;
        }
        public string TradingDiscription
        {
            get;
            set;
        }
    }
}
