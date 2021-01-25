using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBillingSystem.Migrations
{
    public partial class InvoiceCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "InvoiceID",
                table: "Payments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    Time = table.Column<DateTime>(nullable: false),
                    ItemsBought = table.Column<string>(nullable: true),
                    TotalAmount = table.Column<string>(nullable: true),
                    Discounts = table.Column<double>(nullable: false),
                    InvoiceValidatorID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceID);
                    table.ForeignKey(
                        name: "FK_Invoices_InvoiceValidators_InvoiceValidatorID",
                        column: x => x.InvoiceValidatorID,
                        principalTable: "InvoiceValidators",
                        principalColumn: "InvoiceValidatorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_InvoiceID",
                table: "Payments",
                column: "InvoiceID");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_InvoiceValidatorID",
                table: "Invoices",
                column: "InvoiceValidatorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Invoices_InvoiceID",
                table: "Payments",
                column: "InvoiceID",
                principalTable: "Invoices",
                principalColumn: "InvoiceID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Invoices_InvoiceID",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropIndex(
                name: "IX_Payments_InvoiceID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "InvoiceID",
                table: "Payments");
        }
    }
}
