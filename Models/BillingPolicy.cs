using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class BillingPolicy
    {
        public int BillingPolicyID { get; set; }
        public DateTime Date { get; set; }
        public InvoiceCreator InvoiceCreator { get; set; }
    }
}
