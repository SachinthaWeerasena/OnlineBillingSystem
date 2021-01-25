using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class InvoiceCreatorEmployee
    {
        public int InvoiceCreatorEmployeeID { get; set; }
        public int InvoiceCreatorID { get; set; }
        public InvoiceCreator InvoiceCreator { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
    }
}
