using Microsoft.EntityFrameworkCore.Migrations;

namespace Productivo.Core.Migrations
{
    public partial class updatedatabase3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CutsOfMeat_Channels_ChannelId",
                table: "CutsOfMeat");

            migrationBuilder.DropForeignKey(
                name: "FK_CutsOfMeat_CutsOfMeat_MainCutId",
                table: "CutsOfMeat");

            migrationBuilder.DropForeignKey(
                name: "FK_StrippingDetail_Channels_ChannelId",
                table: "StrippingDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_StrippingDetail_Strips_StrippingId",
                table: "StrippingDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StrippingDetail",
                table: "StrippingDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CutsOfMeat",
                table: "CutsOfMeat");

            migrationBuilder.RenameTable(
                name: "StrippingDetail",
                newName: "StrippingDetails");

            migrationBuilder.RenameTable(
                name: "CutsOfMeat",
                newName: "CutsOfMeats");

            migrationBuilder.RenameIndex(
                name: "IX_StrippingDetail_StrippingId",
                table: "StrippingDetails",
                newName: "IX_StrippingDetails_StrippingId");

            migrationBuilder.RenameIndex(
                name: "IX_StrippingDetail_ChannelId",
                table: "StrippingDetails",
                newName: "IX_StrippingDetails_ChannelId");

            migrationBuilder.RenameIndex(
                name: "IX_CutsOfMeat_MainCutId",
                table: "CutsOfMeats",
                newName: "IX_CutsOfMeats_MainCutId");

            migrationBuilder.RenameIndex(
                name: "IX_CutsOfMeat_ChannelId",
                table: "CutsOfMeats",
                newName: "IX_CutsOfMeats_ChannelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StrippingDetails",
                table: "StrippingDetails",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CutsOfMeats",
                table: "CutsOfMeats",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CutsOfMeats_Channels_ChannelId",
                table: "CutsOfMeats",
                column: "ChannelId",
                principalTable: "Channels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CutsOfMeats_CutsOfMeats_MainCutId",
                table: "CutsOfMeats",
                column: "MainCutId",
                principalTable: "CutsOfMeats",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StrippingDetails_Channels_ChannelId",
                table: "StrippingDetails",
                column: "ChannelId",
                principalTable: "Channels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StrippingDetails_Strips_StrippingId",
                table: "StrippingDetails",
                column: "StrippingId",
                principalTable: "Strips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CutsOfMeats_Channels_ChannelId",
                table: "CutsOfMeats");

            migrationBuilder.DropForeignKey(
                name: "FK_CutsOfMeats_CutsOfMeats_MainCutId",
                table: "CutsOfMeats");

            migrationBuilder.DropForeignKey(
                name: "FK_StrippingDetails_Channels_ChannelId",
                table: "StrippingDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_StrippingDetails_Strips_StrippingId",
                table: "StrippingDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StrippingDetails",
                table: "StrippingDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CutsOfMeats",
                table: "CutsOfMeats");

            migrationBuilder.RenameTable(
                name: "StrippingDetails",
                newName: "StrippingDetail");

            migrationBuilder.RenameTable(
                name: "CutsOfMeats",
                newName: "CutsOfMeat");

            migrationBuilder.RenameIndex(
                name: "IX_StrippingDetails_StrippingId",
                table: "StrippingDetail",
                newName: "IX_StrippingDetail_StrippingId");

            migrationBuilder.RenameIndex(
                name: "IX_StrippingDetails_ChannelId",
                table: "StrippingDetail",
                newName: "IX_StrippingDetail_ChannelId");

            migrationBuilder.RenameIndex(
                name: "IX_CutsOfMeats_MainCutId",
                table: "CutsOfMeat",
                newName: "IX_CutsOfMeat_MainCutId");

            migrationBuilder.RenameIndex(
                name: "IX_CutsOfMeats_ChannelId",
                table: "CutsOfMeat",
                newName: "IX_CutsOfMeat_ChannelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StrippingDetail",
                table: "StrippingDetail",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CutsOfMeat",
                table: "CutsOfMeat",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CutsOfMeat_Channels_ChannelId",
                table: "CutsOfMeat",
                column: "ChannelId",
                principalTable: "Channels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CutsOfMeat_CutsOfMeat_MainCutId",
                table: "CutsOfMeat",
                column: "MainCutId",
                principalTable: "CutsOfMeat",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StrippingDetail_Channels_ChannelId",
                table: "StrippingDetail",
                column: "ChannelId",
                principalTable: "Channels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StrippingDetail_Strips_StrippingId",
                table: "StrippingDetail",
                column: "StrippingId",
                principalTable: "Strips",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
