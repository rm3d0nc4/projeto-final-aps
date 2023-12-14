using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projeto_final_aps.Migrations
{
    public partial class AddNewModels3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "NotaDeVendaId",
                table: "Items",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "NotaDeVenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Tipo = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ClienteId = table.Column<int>(type: "int", nullable: true),
                    VendedorId = table.Column<int>(type: "int", nullable: true),
                    TransportadoraId = table.Column<int>(type: "int", nullable: true),
                    TipoDePagamentoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaDeVenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaDeVenda_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotaDeVenda_TiposDePagamento_TipoDePagamentoId",
                        column: x => x.TipoDePagamentoId,
                        principalTable: "TiposDePagamento",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotaDeVenda_Transportadoras_TransportadoraId",
                        column: x => x.TransportadoraId,
                        principalTable: "Transportadoras",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_NotaDeVenda_Vendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "Vendedores",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Items_NotaDeVendaId",
                table: "Items",
                column: "NotaDeVendaId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaDeVenda_ClienteId",
                table: "NotaDeVenda",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaDeVenda_TipoDePagamentoId",
                table: "NotaDeVenda",
                column: "TipoDePagamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaDeVenda_TransportadoraId",
                table: "NotaDeVenda",
                column: "TransportadoraId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaDeVenda_VendedorId",
                table: "NotaDeVenda",
                column: "VendedorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_NotaDeVenda_NotaDeVendaId",
                table: "Items",
                column: "NotaDeVendaId",
                principalTable: "NotaDeVenda",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_NotaDeVenda_NotaDeVendaId",
                table: "Items");

            migrationBuilder.DropTable(
                name: "NotaDeVenda");

            migrationBuilder.DropIndex(
                name: "IX_Items_NotaDeVendaId",
                table: "Items");

            migrationBuilder.DropColumn(
                name: "NotaDeVendaId",
                table: "Items");
        }
    }
}
