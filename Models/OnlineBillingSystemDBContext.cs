using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OnlineBillingSystem.Models
{
    public class OnlineBillingSystemDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<PaymentValidator> PaymentValidators { get; set; }
        public DbSet<ValidationRule> ValidationRules { get; set; }
        public DbSet<PaymentValidatorAndRule> PaymentValidatorAndRules { get; set; }
        public DbSet<InvoiceValidator> InvoiceValidators { get; set; }
        public DbSet<InvoiceValidatorAndRuleValidator> InvoiceValidatorAndRuleValidators { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<EmployeeInvoice> EmployeeInvoices { get; set; }
        public DbSet<EmployeeWithInvoiceValidator> EmployeeWithInvoiceValidators { get; set; }
        public DbSet<PaymentValidatorWithEmployee> PaymentValidatorWithEmployees { get; set; }
        public DbSet<InvoiceCreator> InvoiceCreators { get; set; }
        public DbSet<InvoiceCreatorEmployee> InvoiceCreatorEmployees { get; set; }
        public DbSet<BillingPolicy> BillingPolicies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.\sqlexpress;Initial Catalog=OnlineBillingSystemDB;Integrated Security=True"); 
        }
    }
}
