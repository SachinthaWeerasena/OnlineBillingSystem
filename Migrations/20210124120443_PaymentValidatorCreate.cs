using Microsoft.EntityFrameworkCore.Migrations;

namespace OnlineBillingSystem.Migrations
{
    public partial class PaymentValidatorCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClientID",
                table: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "PaymentValidatorID",
                table: "Payments",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "PaymentValidators",
                columns: table => new
                {
                    PaymentValidatorID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentValidators", x => x.PaymentValidatorID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentValidatorID",
                table: "Payments",
                column: "PaymentValidatorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentValidators_PaymentValidatorID",
                table: "Payments",
                column: "PaymentValidatorID",
                principalTable: "PaymentValidators",
                principalColumn: "PaymentValidatorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentValidators_PaymentValidatorID",
                table: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentValidators");

            migrationBuilder.DropIndex(
                name: "IX_Payments_PaymentValidatorID",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "PaymentValidatorID",
                table: "Payments");

            migrationBuilder.AddColumn<int>(
                name: "ClientID",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
