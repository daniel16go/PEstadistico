using Microsoft.EntityFrameworkCore.Migrations;

namespace Productivo.Core.Migrations
{
    public partial class AddMainCutInMeatCut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MainCutId",
                table: "CutsOfMeats",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CutsOfMeats_MainCutId",
                table: "CutsOfMeats",
                column: "MainCutId");

            migrationBuilder.AddForeignKey(
                name: "FK_CutsOfMeats_CutsOfMeats_MainCutId",
                table: "CutsOfMeats",
                column: "MainCutId",
                principalTable: "CutsOfMeats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CutsOfMeats_CutsOfMeats_MainCutId",
                table: "CutsOfMeats");

            migrationBuilder.DropIndex(
                name: "IX_CutsOfMeats_MainCutId",
                table: "CutsOfMeats");

            migrationBuilder.DropColumn(
                name: "MainCutId",
                table: "CutsOfMeats");
        }
    }
}
