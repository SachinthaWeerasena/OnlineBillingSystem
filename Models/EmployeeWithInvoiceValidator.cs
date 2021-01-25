using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class EmployeeWithInvoiceValidator
    {
        public int EmployeeWithInvoiceValidatorID { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int InvoiceValidatorID { get; set; }
        public InvoiceValidator InvoiceValidator { get; set; }
    }
}
