using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBillingSystem.Migrations
{
    public partial class InvoiceValidatorCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "InvoiceValidators",
                columns: table => new
                {
                    InvoiceValidatorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsValidInvoice = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceValidators", x => x.InvoiceValidatorID);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceValidatorAndRuleValidators",
                columns: table => new
                {
                    InvoiceValidatorAndRuleValidatorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidationRuleID = table.Column<int>(nullable: false),
                    InvoiceValidatorID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceValidatorAndRuleValidators", x => x.InvoiceValidatorAndRuleValidatorID);
                    table.ForeignKey(
                        name: "FK_InvoiceValidatorAndRuleValidators_InvoiceValidators_InvoiceValidatorID",
                        column: x => x.InvoiceValidatorID,
                        principalTable: "InvoiceValidators",
                        principalColumn: "InvoiceValidatorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InvoiceValidatorAndRuleValidators_ValidationRules_ValidationRuleID",
                        column: x => x.ValidationRuleID,
                        principalTable: "ValidationRules",
                        principalColumn: "ValidationRuleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceValidatorAndRuleValidators_InvoiceValidatorID",
                table: "InvoiceValidatorAndRuleValidators",
                column: "InvoiceValidatorID");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceValidatorAndRuleValidators_ValidationRuleID",
                table: "InvoiceValidatorAndRuleValidators",
                column: "ValidationRuleID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InvoiceValidatorAndRuleValidators");

            migrationBuilder.DropTable(
                name: "InvoiceValidators");
        }
    }
}
