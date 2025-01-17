﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnlineBillingSystem.Models;

namespace OnlineBillingSystem.Migrations
{
    [DbContext(typeof(OnlineBillingSystemDBContext))]
    [Migration("20210124113941_PaymentCreate")]
    partial class PaymentCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnlineBillingSystem.Models.Customer", b =>
                {
                    b.Property<int>("CustomerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.HasKey("CustomerID");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.Payment", b =>
                {
                    b.Property<int>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClientID")
                        .HasColumnType("int");

                    b.Property<int?>("CustomerID")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("CustomerID");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("OnlineBillingSystem.Models.Payment", b =>
                {
                    b.HasOne("OnlineBillingSystem.Models.Customer", "Customer")
                        .WithMany("Payments")
                        .HasForeignKey("CustomerID");
                });
#pragma warning restore 612, 618
        }
    }
}
