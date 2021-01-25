using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
