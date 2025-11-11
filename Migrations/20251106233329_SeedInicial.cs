using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedInicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clubes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clubes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Ligas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Clubes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Flamengo");

            migrationBuilder.UpdateData(
                table: "Clubes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Palmeiras");

            migrationBuilder.UpdateData(
                table: "Clubes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nome",
                value: "Manchester City");

            migrationBuilder.UpdateData(
                table: "Ligas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Campeonato Brasileiro");

            migrationBuilder.UpdateData(
                table: "Ligas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Champions League");

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[] { "Camisa oficial do Flamengo - modelo 2025", "/imagens/flamengo.jpg", "Camisa Flamengo 2025", 349.90m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClubeId", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[] { 2, "Camisa oficial do Palmeiras - modelo 2025", "/imagens/palmeiras.jpg", "Camisa Palmeiras 2025", 339.90m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClubeId", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[] { 3, "Camisa oficial do Real Madrid - modelo 2025", "/imagens/realmadrid.jpg", "Camisa Real Madrid 2025", 399.90m });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "ClubeId", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[] { 4, 4, "Camisa oficial do Manchester City - modelo 2025", "/imagens/mancity.jpg", "Camisa Manchester City 2025", 379.90m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Clubes",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Manchester City");

            migrationBuilder.UpdateData(
                table: "Clubes",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "Arsenal");

            migrationBuilder.UpdateData(
                table: "Clubes",
                keyColumn: "Id",
                keyValue: 4,
                column: "Nome",
                value: "Barcelona");

            migrationBuilder.UpdateData(
                table: "Ligas",
                keyColumn: "Id",
                keyValue: 1,
                column: "Nome",
                value: "Premier League");

            migrationBuilder.UpdateData(
                table: "Ligas",
                keyColumn: "Id",
                keyValue: 2,
                column: "Nome",
                value: "La Liga");

            migrationBuilder.InsertData(
                table: "Ligas",
                columns: new[] { "Id", "Nome" },
                values: new object[] { 3, "Brasileirão" });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[] { "Modelo titular oficial da temporada 2025.", "/img/produtos/mancity.jpg", "Camisa Manchester City 2025", 399.90m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClubeId", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[] { 3, "Versão dourada de colecionador.", "/img/produtos/realmadrid.jpg", "Camisa Real Madrid Edição Especial", 449.90m });

            migrationBuilder.UpdateData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClubeId", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[] { 5, "Oficial com escudo bordado e tecido dry-fit.", "/img/produtos/flamengo.jpg", "Camisa Flamengo 2025", 379.90m });

            migrationBuilder.InsertData(
                table: "Clubes",
                columns: new[] { "Id", "LigaId", "Nome" },
                values: new object[,]
                {
                    { 5, 3, "Flamengo" },
                    { 6, 3, "Palmeiras" }
                });
        }
    }
}
