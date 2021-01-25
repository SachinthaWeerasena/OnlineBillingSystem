using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBillingSystem.Migrations
{
    public partial class ValidationRulesCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ValidationRules",
                columns: table => new
                {
                    ValidationRuleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValidationRules", x => x.ValidationRuleID);
                });

            migrationBuilder.CreateTable(
                name: "PaymentValidatorAndRules",
                columns: table => new
                {
                    PaymentValidatorAndRuleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ValidationRuleId = table.Column<int>(nullable: false),
                    PaymentValidatorId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentValidatorAndRules", x => x.PaymentValidatorAndRuleId);
                    table.ForeignKey(
                        name: "FK_PaymentValidatorAndRules_PaymentValidators_PaymentValidatorId",
                        column: x => x.PaymentValidatorId,
                        principalTable: "PaymentValidators",
                        principalColumn: "PaymentValidatorID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PaymentValidatorAndRules_ValidationRules_ValidationRuleId",
                        column: x => x.ValidationRuleId,
                        principalTable: "ValidationRules",
                        principalColumn: "ValidationRuleID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentValidatorAndRules_PaymentValidatorId",
                table: "PaymentValidatorAndRules",
                column: "PaymentValidatorId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentValidatorAndRules_ValidationRuleId",
                table: "PaymentValidatorAndRules",
                column: "ValidationRuleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentValidatorAndRules");

            migrationBuilder.DropTable(
                name: "ValidationRules");
        }
    }
}
