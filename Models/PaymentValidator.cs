using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class PaymentValidator
    {
        public int PaymentValidatorID { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public ICollection<PaymentValidatorAndRule> PaymentValidatorAndRules { get; set; }
        public ICollection<PaymentValidatorWithEmployee> PaymentValidatorWithEmployees { get; set; }
    }
}
