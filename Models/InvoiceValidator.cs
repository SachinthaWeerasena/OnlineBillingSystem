using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class InvoiceValidator
    {
        public int InvoiceValidatorID { get; set; }
        public Boolean IsValidInvoice { get; set; }
        public ICollection<InvoiceValidatorAndRuleValidator> InvoiceValidatorAndRuleValidators { get; set; }
        public ICollection<Invoice> Invoices { get; set; }
        public ICollection<EmployeeWithInvoiceValidator> EmployeeWithInvoiceValidators { get; set; }
    }
}
