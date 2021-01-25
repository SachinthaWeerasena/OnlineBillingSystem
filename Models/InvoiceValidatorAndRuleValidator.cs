using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class InvoiceValidatorAndRuleValidator
    {
        public int InvoiceValidatorAndRuleValidatorID { get; set; }
        public int ValidationRuleID { get; set; }
        public ValidationRule ValidationRule { get; set; }
        public int InvoiceValidatorID { get; set; }
        public InvoiceValidator InvoiceValidator { get; set; }
    }
}
