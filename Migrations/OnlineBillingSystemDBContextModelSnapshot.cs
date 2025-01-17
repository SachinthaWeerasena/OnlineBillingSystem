﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineBillingSystem.Models;

namespace OnlineBillingSystem.Migrations
{
    [DbContext(typeof(OnlineBillingSystemDBContext))]
    partial class OnlineBillingSystemDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineBillingSystem.Models.BillingPolicy", b =>
                {
                    b.Property<int>("BillingPolicyID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("InvoiceCreatorID")
                        .HasColumnType("int");

                    b.HasKey("BillingPolicyID");

                    b.HasIndex("InvoiceCreatorID");

                    b.ToTable("BillingPolicies");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.Employee", b =>
                {
                    b.Property<int>("EmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("EmployeeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.EmployeeInvoice", b =>
                {
                    b.Property<int>("EmployeeInvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeInvoiceID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("InvoiceID");

                    b.ToTable("EmployeeInvoices");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.EmployeeWithInvoiceValidator", b =>
                {
                    b.Property<int>("EmployeeWithInvoiceValidatorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceValidatorID")
                        .HasColumnType("int");

                    b.HasKey("EmployeeWithInvoiceValidatorID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("InvoiceValidatorID");

                    b.ToTable("EmployeeWithInvoiceValidators");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<double>("Discounts")
                        .HasColumnType("float");

                    b.Property<int?>("InvoiceCreatoryInvoiceCreatorID")
                        .HasColumnType("int");

                    b.Property<int?>("InvoiceValidatorID")
                        .HasColumnType("int");

                    b.Property<string>("ItemsBought")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Time")
                        .HasColumnType("datetime2");

                    b.Property<string>("TotalAmount")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvoiceID");

                    b.HasIndex("InvoiceCreatoryInvoiceCreatorID");

                    b.HasIndex("InvoiceValidatorID");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.InvoiceCreator", b =>
                {
                    b.Property<int>("InvoiceCreatorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("type")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvoiceCreatorID");

                    b.ToTable("InvoiceCreators");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.InvoiceCreatorEmployee", b =>
                {
                    b.Property<int>("InvoiceCreatorEmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("InvoiceCreatorID")
                        .HasColumnType("int");

                    b.HasKey("InvoiceCreatorEmployeeID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("InvoiceCreatorID");

                    b.ToTable("InvoiceCreatorEmployees");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.InvoiceValidator", b =>
                {
                    b.Property<int>("InvoiceValidatorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsValidInvoice")
                        .HasColumnType("bit");

                    b.HasKey("InvoiceValidatorID");

                    b.ToTable("InvoiceValidators");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.InvoiceValidatorAndRuleValidator", b =>
                {
                    b.Property<int>("InvoiceValidatorAndRuleValidatorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceValidatorID")
                        .HasColumnType("int");

                    b.Property<int>("ValidationRuleID")
                        .HasColumnType("int");

                    b.HasKey("InvoiceValidatorAndRuleValidatorID");

                    b.HasIndex("InvoiceValidatorID");

                    b.HasIndex("ValidationRuleID");

                    b.ToTable("InvoiceValidatorAndRuleValidators");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.Property<int?>("InvoiceID")
                        .HasColumnType("int");

                    b.Property<int?>("PaymentValidatorID")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("InvoiceID");

                    b.HasIndex("PaymentValidatorID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.PaymentValidator", b =>
                {
                    b.Property<int>("PaymentValidatorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("PaymentValidatorID");

                    b.ToTable("PaymentValidators");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.PaymentValidatorAndRule", b =>
                {
                    b.Property<int>("PaymentValidatorAndRuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("PaymentValidatorId")
                        .HasColumnType("int");

                    b.Property<int>("ValidationRuleId")
                        .HasColumnType("int");

                    b.HasKey("PaymentValidatorAndRuleId");

                    b.HasIndex("PaymentValidatorId");

                    b.HasIndex("ValidationRuleId");

                    b.ToTable("PaymentValidatorAndRules");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.PaymentValidatorWithEmployee", b =>
                {
                    b.Property<int>("PaymentValidatorWithEmployeeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("EmployeeID")
                        .HasColumnType("int");

                    b.Property<int>("PaymentValidatorID")
                        .HasColumnType("int");

                    b.HasKey("PaymentValidatorWithEmployeeID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("PaymentValidatorID");

                    b.ToTable("PaymentValidatorWithEmployees");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.ValidationRule", b =>
                {
                    b.Property<int>("ValidationRuleID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.HasKey("ValidationRuleID");

                    b.ToTable("ValidationRules");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.BillingPolicy", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.InvoiceCreator", "InvoiceCreator")
                        .WithMany("BillingPolicies")
                        .HasForeignKey("InvoiceCreatorID");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.EmployeeInvoice", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.Employee", "Employee")
                        .WithMany("EmployeeInvoces")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBillingSystem.Models.Invoice", "Invoice")
                        .WithMany("EmployeeInvoices")
                        .HasForeignKey("InvoiceID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.EmployeeWithInvoiceValidator", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.Employee", "Employee")
                        .WithMany("EmployeeWithInvoiceValidators")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBillingSystem.Models.InvoiceValidator", "InvoiceValidator")
                        .WithMany("EmployeeWithInvoiceValidators")
                        .HasForeignKey("InvoiceValidatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.Invoice", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.InvoiceCreator", "InvoiceCreatory")
                        .WithMany("Invoices")
                        .HasForeignKey("InvoiceCreatoryInvoiceCreatorID");

                    b.HasOne("OnlineBillingSystem.Models.InvoiceValidator", "InvoiceValidator")
                        .WithMany("Invoices")
                        .HasForeignKey("InvoiceValidatorID");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.InvoiceCreatorEmployee", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.Employee", "Employee")
                        .WithMany("InvoiceCreatorEmployees")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBillingSystem.Models.InvoiceCreator", "InvoiceCreator")
                        .WithMany("InvoiceCreatorEmployees")
                        .HasForeignKey("InvoiceCreatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.InvoiceValidatorAndRuleValidator", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.InvoiceValidator", "InvoiceValidator")
                        .WithMany("InvoiceValidatorAndRuleValidators")
                        .HasForeignKey("InvoiceValidatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBillingSystem.Models.ValidationRule", "ValidationRule")
                        .WithMany("InvoiceValidatorAndRuleValidators")
                        .HasForeignKey("ValidationRuleID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.Payment", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerID");

                    b.HasOne("OnlineBillingSystem.Models.Invoice", "Invoice")
                        .WithMany("Payments")
                        .HasForeignKey("InvoiceID");

                    b.HasOne("OnlineBillingSystem.Models.PaymentValidator", "PaymentValidator")
                        .WithMany("Payments")
                        .HasForeignKey("PaymentValidatorID");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.PaymentValidatorAndRule", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.PaymentValidator", "PaymentValidator")
                        .WithMany("PaymentValidatorAndRules")
                        .HasForeignKey("PaymentValidatorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBillingSystem.Models.ValidationRule", "ValidationRule")
                        .WithMany("PaymentValidatorAndRules")
                        .HasForeignKey("ValidationRuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.PaymentValidatorWithEmployee", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.Employee", "Employee")
                        .WithMany("PaymentValidatorWithEmployees")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("OnlineBillingSystem.Models.PaymentValidator", "PaymentValidator")
                        .WithMany("PaymentValidatorWithEmployees")
                        .HasForeignKey("PaymentValidatorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
