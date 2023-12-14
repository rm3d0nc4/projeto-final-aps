using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_final_aps.Migrations
{
    public partial class ChangedModels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_NotasDeVendas_NotaDeVendaId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "NotaDeVendaId",
                table: "Items",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_NotasDeVendas_NotaDeVendaId",
                table: "Items",
                column: "NotaDeVendaId",
                principalTable: "NotasDeVendas",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_NotasDeVendas_NotaDeVendaId",
                table: "Items");

            migrationBuilder.AlterColumn<int>(
                name: "NotaDeVendaId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Items_NotasDeVendas_NotaDeVendaId",
                table: "Items",
                column: "NotaDeVendaId",
                principalTable: "NotasDeVendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
