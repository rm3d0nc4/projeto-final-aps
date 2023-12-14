using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_final_aps.Migrations
{
    public partial class FixNotaDeVendaModelAddingDataPropertyFIX : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_NotaDeVenda_NotaDeVendaId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Clientes_ClienteId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Transportadoras_TransportadoraId",
                table: "NotaDeVenda");

            migrationBuilder.DropForeignKey(
                name: "FK_NotaDeVenda_Vendedores_VendedorId",
                table: "NotaDeVenda");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotaDeVenda",
                table: "NotaDeVenda");

            migrationBuilder.RenameTable(
                name: "NotaDeVenda",
                newName: "NotasDeVendas");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_VendedorId",
                table: "NotasDeVendas",
                newName: "IX_NotasDeVendas_VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_TransportadoraId",
                table: "NotasDeVendas",
                newName: "IX_NotasDeVendas_TransportadoraId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_TipoDePagamentoId",
                table: "NotasDeVendas",
                newName: "IX_NotasDeVendas_TipoDePagamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_NotaDeVenda_ClienteId",
                table: "NotasDeVendas",
                newName: "IX_NotasDeVendas_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotasDeVendas",
                table: "NotasDeVendas",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_NotasDeVendas_NotaDeVendaId",
                table: "Items",
                column: "NotaDeVendaId",
                principalTable: "NotasDeVendas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVendas_Clientes_ClienteId",
                table: "NotasDeVendas",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVendas_TiposDePagamento_TipoDePagamentoId",
                table: "NotasDeVendas",
                column: "TipoDePagamentoId",
                principalTable: "TiposDePagamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVendas_Transportadoras_TransportadoraId",
                table: "NotasDeVendas",
                column: "TransportadoraId",
                principalTable: "Transportadoras",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotasDeVendas_Vendedores_VendedorId",
                table: "NotasDeVendas",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_NotasDeVendas_NotaDeVendaId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVendas_Clientes_ClienteId",
                table: "NotasDeVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVendas_TiposDePagamento_TipoDePagamentoId",
                table: "NotasDeVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVendas_Transportadoras_TransportadoraId",
                table: "NotasDeVendas");

            migrationBuilder.DropForeignKey(
                name: "FK_NotasDeVendas_Vendedores_VendedorId",
                table: "NotasDeVendas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_NotasDeVendas",
                table: "NotasDeVendas");

            migrationBuilder.RenameTable(
                name: "NotasDeVendas",
                newName: "NotaDeVenda");

            migrationBuilder.RenameIndex(
                name: "IX_NotasDeVendas_VendedorId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_VendedorId");

            migrationBuilder.RenameIndex(
                name: "IX_NotasDeVendas_TransportadoraId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_TransportadoraId");

            migrationBuilder.RenameIndex(
                name: "IX_NotasDeVendas_TipoDePagamentoId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_TipoDePagamentoId");

            migrationBuilder.RenameIndex(
                name: "IX_NotasDeVendas_ClienteId",
                table: "NotaDeVenda",
                newName: "IX_NotaDeVenda_ClienteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_NotaDeVenda",
                table: "NotaDeVenda",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_NotaDeVenda_NotaDeVendaId",
                table: "Items",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Clientes_ClienteId",
                table: "NotaDeVenda",
                column: "ClienteId",
                principalTable: "Clientes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_TiposDePagamento_TipoDePagamentoId",
                table: "NotaDeVenda",
                column: "TipoDePagamentoId",
                principalTable: "TiposDePagamento",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Transportadoras_TransportadoraId",
                table: "NotaDeVenda",
                column: "TransportadoraId",
                principalTable: "Transportadoras",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_NotaDeVenda_Vendedores_VendedorId",
                table: "NotaDeVenda",
                column: "VendedorId",
                principalTable: "Vendedores",
                principalColumn: "Id");
        }
    }
}
