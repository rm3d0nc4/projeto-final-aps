using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_final_aps.Migrations
{
    public partial class FixNotaDeVendaModelAddingDataProperty : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Data",
                table: "NotaDeVenda",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Data",
                table: "NotaDeVenda");
        }
    }
}
