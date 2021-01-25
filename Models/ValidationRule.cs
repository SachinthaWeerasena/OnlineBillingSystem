using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class ValidationRule
    {
        public int ValidationRuleID { get; set; }
        public DateTime Date { get; set; }
        public ICollection<PaymentValidatorAndRule> PaymentValidatorAndRules { get; set; }
        public ICollection<InvoiceValidatorAndRuleValidator> InvoiceValidatorAndRuleValidators { get; set; }
    }
}