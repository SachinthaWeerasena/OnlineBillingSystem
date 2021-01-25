using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class EmployeeInvoice
    {
        public int EmployeeInvoiceID { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int InvoiceID { get; set; }
        public Invoice Invoice { get; set; }
    }
}
