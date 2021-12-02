using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Productivo.Core.Migrations
{
    public partial class AddCutsRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CutsRelations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MainCutMeatId = table.Column<int>(nullable: false),
                    SubCutMeatId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CutsRelations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CutsRelations_CutsOfMeats_MainCutMeatId",
                        column: x => x.MainCutMeatId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CutsRelations_CutsOfMeats_SubCutMeatId",
                        column: x => x.SubCutMeatId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CutsRelations_MainCutMeatId",
                table: "CutsRelations",
                column: "MainCutMeatId");

            migrationBuilder.CreateIndex(
                name: "IX_CutsRelations_SubCutMeatId",
                table: "CutsRelations",
                column: "SubCutMeatId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CutsRelations");
        }
    }
}
