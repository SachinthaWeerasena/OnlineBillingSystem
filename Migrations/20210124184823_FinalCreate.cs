using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBillingSystem.Migrations
{
    public partial class FinalCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceCreatoryInvoiceCreatorID",
                table: "Invoices",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceCreators",
                columns: table => new
                {
                    InvoiceCreatorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceCreators", x => x.InvoiceCreatorID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInvoices",
                columns: table => new
                {
                    EmployeeInvoiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    InvoiceID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInvoices", x => x.EmployeeInvoiceID);
                    table.ForeignKey(
                        name: "FK_EmployeeInvoices_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInvoices_Invoices_InvoiceID",
                        column: x => x.InvoiceID,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeWithInvoiceValidators",
                columns: table => new
                {
                    EmployeeWithInvoiceValidatorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeID = table.Column<int>(nullable: false),
                    InvoiceValidatorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeWithInvoiceValidators", x => x.EmployeeWithInvoiceValidatorID);
                    table.ForeignKey(
                        name: "FK_EmployeeWithInvoiceValidators_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeWithInvoiceValidators_InvoiceValidators_InvoiceValidatorID",
                        column: x => x.InvoiceValidatorID,
                        principalTable: "InvoiceValidators",
                        principalColumn: "InvoiceValidatorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PaymentValidatorWithEmployees",
                columns: table => new
                {
                    PaymentValidatorWithEmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentValidatorID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentValidatorWithEmployees", x => x.PaymentValidatorWithEmployeeID);
                    table.ForeignKey(
                        name: "FK_PaymentValidatorWithEmployees_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentValidatorWithEmployees_PaymentValidators_PaymentValidatorID",
                        column: x => x.PaymentValidatorID,
                        principalTable: "PaymentValidators",
                        principalColumn: "PaymentValidatorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BillingPolicies",
                columns: table => new
                {
                    BillingPolicyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    InvoiceCreatorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BillingPolicies", x => x.BillingPolicyID);
                    table.ForeignKey(
                        name: "FK_BillingPolicies_InvoiceCreators_InvoiceCreatorID",
                        column: x => x.InvoiceCreatorID,
                        principalTable: "InvoiceCreators",
                        principalColumn: "InvoiceCreatorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceCreatorEmployees",
                columns: table => new
                {
                    InvoiceCreatorEmployeeID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceCreatorID = table.Column<int>(nullable: false),
                    EmployeeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceCreatorEmployees", x => x.InvoiceCreatorEmployeeID);
                    table.ForeignKey(
                        name: "FK_InvoiceCreatorEmployees_Employees_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "Employees",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceCreatorEmployees_InvoiceCreators_InvoiceCreatorID",
                        column: x => x.InvoiceCreatorID,
                        principalTable: "InvoiceCreators",
                        principalColumn: "InvoiceCreatorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoiceCreatoryInvoiceCreatorID",
                table: "Invoices",
                column: "InvoiceCreatoryInvoiceCreatorID");

            migrationBuilder.CreateIndex(
                name: "IX_BillingPolicies_InvoiceCreatorID",
                table: "BillingPolicies",
                column: "InvoiceCreatorID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInvoices_EmployeeID",
                table: "EmployeeInvoices",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInvoices_InvoiceID",
                table: "EmployeeInvoices",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWithInvoiceValidators_EmployeeID",
                table: "EmployeeWithInvoiceValidators",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeWithInvoiceValidators_InvoiceValidatorID",
                table: "EmployeeWithInvoiceValidators",
                column: "InvoiceValidatorID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreatorEmployees_EmployeeID",
                table: "InvoiceCreatorEmployees",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceCreatorEmployees_InvoiceCreatorID",
                table: "InvoiceCreatorEmployees",
                column: "InvoiceCreatorID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentValidatorWithEmployees_EmployeeID",
                table: "PaymentValidatorWithEmployees",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentValidatorWithEmployees_PaymentValidatorID",
                table: "PaymentValidatorWithEmployees",
                column: "PaymentValidatorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_InvoiceCreators_InvoiceCreatoryInvoiceCreatorID",
                table: "Invoices",
                column: "InvoiceCreatoryInvoiceCreatorID",
                principalTable: "InvoiceCreators",
                principalColumn: "InvoiceCreatorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_InvoiceCreators_InvoiceCreatoryInvoiceCreatorID",
                table: "Invoices");

            migrationBuilder.DropTable(
                name: "BillingPolicies");

            migrationBuilder.DropTable(
                name: "EmployeeInvoices");

            migrationBuilder.DropTable(
                name: "EmployeeWithInvoiceValidators");

            migrationBuilder.DropTable(
                name: "InvoiceCreatorEmployees");

            migrationBuilder.DropTable(
                name: "PaymentValidatorWithEmployees");

            migrationBuilder.DropTable(
                name: "InvoiceCreators");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_InvoiceCreatoryInvoiceCreatorID",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "InvoiceCreatoryInvoiceCreatorID",
                table: "Invoices");
        }
    }
}
