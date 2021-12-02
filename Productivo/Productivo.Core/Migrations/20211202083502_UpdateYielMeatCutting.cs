using Microsoft.EntityFrameworkCore.Migrations;

namespace Productivo.Core.Migrations
{
    public partial class UpdateYielMeatCutting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YieldMeatCuts_CutsOfMeats_MeatCuttingId",
                table: "YieldMeatCuts");

            migrationBuilder.DropIndex(
                name: "IX_YieldMeatCuts_MeatCuttingId",
                table: "YieldMeatCuts");

            migrationBuilder.DropColumn(
                name: "MeatCuttingId",
                table: "YieldMeatCuts");

            migrationBuilder.DropColumn(
                name: "Yield",
                table: "YieldMeatCuts");

            migrationBuilder.AddColumn<int>(
                name: "ChannelCategoryId",
                table: "YieldMeatCuts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ChannelId",
                table: "YieldMeatCuts",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_YieldMeatCuts_ChannelCategoryId",
                table: "YieldMeatCuts",
                column: "ChannelCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_YieldMeatCuts_ChannelId",
                table: "YieldMeatCuts",
                column: "ChannelId");

            migrationBuilder.AddForeignKey(
                name: "FK_YieldMeatCuts_ChannelCategories_ChannelCategoryId",
                table: "YieldMeatCuts",
                column: "ChannelCategoryId",
                principalTable: "ChannelCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_YieldMeatCuts_Channels_ChannelId",
                table: "YieldMeatCuts",
                column: "ChannelId",
                principalTable: "Channels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_YieldMeatCuts_ChannelCategories_ChannelCategoryId",
                table: "YieldMeatCuts");

            migrationBuilder.DropForeignKey(
                name: "FK_YieldMeatCuts_Channels_ChannelId",
                table: "YieldMeatCuts");

            migrationBuilder.DropIndex(
                name: "IX_YieldMeatCuts_ChannelCategoryId",
                table: "YieldMeatCuts");

            migrationBuilder.DropIndex(
                name: "IX_YieldMeatCuts_ChannelId",
                table: "YieldMeatCuts");

            migrationBuilder.DropColumn(
                name: "ChannelCategoryId",
                table: "YieldMeatCuts");

            migrationBuilder.DropColumn(
                name: "ChannelId",
                table: "YieldMeatCuts");

            migrationBuilder.AddColumn<int>(
                name: "MeatCuttingId",
                table: "YieldMeatCuts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Yield",
                table: "YieldMeatCuts",
                type: "decimal(18, 2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.CreateIndex(
                name: "IX_YieldMeatCuts_MeatCuttingId",
                table: "YieldMeatCuts",
                column: "MeatCuttingId");

            migrationBuilder.AddForeignKey(
                name: "FK_YieldMeatCuts_CutsOfMeats_MeatCuttingId",
                table: "YieldMeatCuts",
                column: "MeatCuttingId",
                principalTable: "CutsOfMeats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
