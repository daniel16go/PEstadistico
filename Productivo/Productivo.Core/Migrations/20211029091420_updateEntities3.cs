using System;
using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Productivo.Core.Migrations
{
    public partial class updateEntities3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PriceCuts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MeatCuttingId = table.Column<int>(nullable: false),
                    MalePrice = table.Column<decimal>(nullable: false),
                    FemalePrice = table.Column<decimal>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PriceCuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PriceCuts_CutsOfMeats_MeatCuttingId",
                        column: x => x.MeatCuttingId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuantitySaleTops",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MeatCuttingId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuantitySaleTops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuantitySaleTops_CutsOfMeats_MeatCuttingId",
                        column: x => x.MeatCuttingId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YieldMeatCuts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    MeatCuttingId = table.Column<int>(nullable: false),
                    Yield = table.Column<decimal>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreateUserId = table.Column<string>(nullable: true),
                    UpdateUserId = table.Column<string>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YieldMeatCuts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_YieldMeatCuts_CutsOfMeats_MeatCuttingId",
                        column: x => x.MeatCuttingId,
                        principalTable: "CutsOfMeats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PriceCuts_MeatCuttingId",
                table: "PriceCuts",
                column: "MeatCuttingId");

            migrationBuilder.CreateIndex(
                name: "IX_QuantitySaleTops_MeatCuttingId",
                table: "QuantitySaleTops",
                column: "MeatCuttingId");

            migrationBuilder.CreateIndex(
                name: "IX_YieldMeatCuts_MeatCuttingId",
                table: "YieldMeatCuts",
                column: "MeatCuttingId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PriceCuts");

            migrationBuilder.DropTable(
                name: "QuantitySaleTops");

            migrationBuilder.DropTable(
                name: "YieldMeatCuts");
        }
    }
}
