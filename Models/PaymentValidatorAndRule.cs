using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class PaymentValidatorAndRule
    {
        public int PaymentValidatorAndRuleId { get; set; }
        public int ValidationRuleId { get; set; }
        public ValidationRule ValidationRule { get; set; }
        public int PaymentValidatorId { get; set; }
        public PaymentValidator PaymentValidator { get; set; }
    }
}
