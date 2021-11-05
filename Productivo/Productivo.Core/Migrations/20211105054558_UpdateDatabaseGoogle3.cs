using Microsoft.EntityFrameworkCore.Migrations;

namespace Productivo.Core.Migrations
{
    public partial class UpdateDatabaseGoogle3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "CutsOfMeats",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "CutsOfMeats");
        }
    }
}
