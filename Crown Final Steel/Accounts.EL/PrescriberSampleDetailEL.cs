using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class PrescriberSampleDetailEL : VouchersEL
    {
        #region PrescriberDetail
        public Guid IdProductSample
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
        public decimal UnitPrice
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
