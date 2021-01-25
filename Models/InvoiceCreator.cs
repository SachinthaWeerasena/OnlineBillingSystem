using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class InvoiceCreator
    {
        public int InvoiceCreatorID { get; set; }
        public string type { get; set; }
        public ICollection<InvoiceCreatorEmployee> InvoiceCreatorEmployees { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<BillingPolicy> BillingPolicies { get; set; }
    }
}
