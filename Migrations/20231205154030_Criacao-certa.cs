using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Projeto_final.Migrations
{
    public partial class Criacaocerta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioId",
                table: "Usuario",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TipoSaidaId",
                table: "TipoSaida",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "TipoProdutoId",
                table: "TipoProduto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "SaidaProdutoId",
                table: "SaidaProduto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "Produto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "PaisId",
                table: "Pais",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "FornecedorId",
                table: "Fornecedor",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EstadoId",
                table: "Estado",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "EntradaProdutoId",
                table: "EntradaProduto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Cliente",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CidadeId",
                table: "Cidade",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Usuario",
                newName: "UsuarioId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TipoSaida",
                newName: "TipoSaidaId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TipoProduto",
                newName: "TipoProdutoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "SaidaProduto",
                newName: "SaidaProdutoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Produto",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Pais",
                newName: "PaisId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Fornecedor",
                newName: "FornecedorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Estado",
                newName: "EstadoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "EntradaProduto",
                newName: "EntradaProdutoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cliente",
                newName: "ClienteId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Cidade",
                newName: "CidadeId");
        }
    }
}
