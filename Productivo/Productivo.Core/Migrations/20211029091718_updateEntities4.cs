using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Productivo.Core.Migrations
{
    public partial class updateEntities4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubCuts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MainCutId = table.Column<int>(nullable: false),
                    SubCutId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SubCuts_CutsOfMeats_MainCutId",
                        column: x => x.MainCutId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubCuts_CutsOfMeats_SubCutId",
                        column: x => x.SubCutId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubCuts_MainCutId",
                table: "SubCuts",
                column: "MainCutId");

            migrationBuilder.CreateIndex(
                name: "IX_SubCuts_SubCutId",
                table: "SubCuts",
                column: "SubCutId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubCuts");
        }
    }
}
