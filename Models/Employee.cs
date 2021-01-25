using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public ICollection<EmployeeInvoice> EmployeeInvoces { get; set; }
        public ICollection<EmployeeWithInvoiceValidator> EmployeeWithInvoiceValidators { get; set; }
        public ICollection<PaymentValidatorWithEmployee> PaymentValidatorWithEmployees { get; set; }
        public ICollection<InvoiceCreatorEmployee> InvoiceCreatorEmployees { get; set; }
    }
}
