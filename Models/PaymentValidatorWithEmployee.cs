using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class PaymentValidatorWithEmployee
    {
        public int PaymentValidatorWithEmployeeID { get; set; }
        public int PaymentValidatorID { get; set; }
        public PaymentValidator PaymentValidator { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
