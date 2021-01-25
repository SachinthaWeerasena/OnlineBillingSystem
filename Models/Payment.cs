using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class Payment
    {
        public int PaymentID { get; set; }
        public Customer Customer { get; set; }
        public PaymentValidator PaymentValidator { get; set; }
        public Invoice Invoice { get; set; }
    }
}
