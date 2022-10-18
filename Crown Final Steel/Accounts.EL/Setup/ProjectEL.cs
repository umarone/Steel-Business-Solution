using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Accounts.EL
{
    public class ProjectEL : CompanyEL
    {
        public Int64? IdProject { get; set; }
        public string SiteAddress { get; set; }
        public string Description { get; set; }
        public string ProjectName { get; set; }
        public string ProjectInvoiceName { get; set; }
        public string ProjectPurchaseInvoiceName { get; set; }
        public Int64 ProjectConfiguration { get; set; }
        public Int64 ProjectCode { get; set; }
        public string City { get; set; }
        public bool? Status { get; set; }
        public bool? HeadOffice { get; set; }
        public bool? Store { get; set; }
        public bool? ProjectStatus { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? ClosedDate { get; set; }

        public ProjectEL()
        {
            this.IdProject = 0;
            ProjectName = string.Empty;
            ProjectInvoiceName = string.Empty;
            ProjectPurchaseInvoiceName = string.Empty;
        }
    }
}
