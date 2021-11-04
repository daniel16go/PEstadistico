using Microsoft.EntityFrameworkCore.Migrations;

namespace Productivo.Core.Migrations
{
    public partial class chageStructure : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Reference",
                table: "Strips",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "StrippingDetails",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18, 2)");

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "StrippingDetails",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reference",
                table: "Strips");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "StrippingDetails");

            migrationBuilder.AlterColumn<decimal>(
                name: "Quantity",
                table: "StrippingDetails",
                type: "decimal(18, 2)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
