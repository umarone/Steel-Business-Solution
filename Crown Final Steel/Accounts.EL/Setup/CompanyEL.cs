using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class CompanyEL : TerminalsEL
    {
        public Int64? IdCompany 
        { 
            get; 
            set; 
        }
        public Int64 UserId
        {
            get;
            set;
        }
        public string CompanyName 
        { 
            get; 
            set; 
        }
        public string UserName
        {
            get;
            set;
        }
        public Int64 BookNo
        {
            get;
            set;
        }
        public string BookPeriod
        {
            get;
            set;
        }
        public bool? IsActive 
        { 
            get; 
            set; 
        }
        public string Discription
        {
            get;
            set;
        }
        public DateTime? CreatedDateTime
        {
            get;
            set;
        }
    }
}
