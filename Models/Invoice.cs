using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBillingSystem.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string ItemsBought { get; set; }
        public string TotalAmount { get; set; }
        public Double Discounts { get; set; }
        public ICollection<Payment> Payments { get; set; }
        public InvoiceValidator InvoiceValidator { get; set; }
        public ICollection<EmployeeInvoice> EmployeeInvoices { get; set; }
        public InvoiceCreator InvoiceCreatory { get; set; }
    }
}
