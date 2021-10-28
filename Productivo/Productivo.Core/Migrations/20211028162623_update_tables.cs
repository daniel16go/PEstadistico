using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Productivo.Core.Migrations
{
    public partial class update_tables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Strips",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Strips",
                type: "datetime",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);
        }
    }
}
