using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class SeedCamisetas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: 22);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "ClubeId", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 5, 5, "Camisa oficial do Atlético Mineiro 2025, conforto e estilo garantidos", "/imagens/clubes/atleticomg1.jpg", "Camisa Atlético MG 2025", 329.90m },
                    { 6, 6, "Camisa oficial do São Paulo 2025, feita para torcedores apaixonados", "/imagens/clubes/saopaulo1.jpg", "Camisa São Paulo 2025", 319.90m },
                    { 7, 7, "Camisa oficial do Corinthians, modelo 2025, com tecido respirável", "/imagens/clubes/corinthians1.jpg", "Camisa Corinthians 2025", 329.90m },
                    { 8, 8, "Camisa oficial do Athletico Paranaense, modelo 2025, tecido respirável", "/imagens/clubes/athleticopr1.jpg", "Camisa Athletico PR 2025", 319.90m },
                    { 9, 9, "Camisa oficial do Ceará 2025, design moderno e confortável", "/imagens/clubes/ceara1.jpg", "Camisa Ceará 2025", 299.90m },
                    { 10, 10, "Camisa oficial do Fortaleza 2025, perfeita para torcer na arquibancada", "/imagens/clubes/fortaleza1.jpg", "Camisa Fortaleza 2025", 299.90m },
                    { 11, 11, "Camisa oficial do Bahia 2025, confortável e estilosa", "/imagens/clubes/bahia1.jpg", "Camisa Bahia 2025", 299.90m },
                    { 12, 12, "Camisa oficial do Coritiba 2025, design moderno e leve", "/imagens/clubes/coritiba1.jpg", "Camisa Coritiba 2025", 289.90m },
                    { 13, 13, "Camisa oficial do América Mineiro 2025, conforto e estilo", "/imagens/clubes/americamg1.jpg", "Camisa América MG 2025", 289.90m },
                    { 14, 14, "Camisa oficial do Goiás 2025, perfeita para torcedores", "/imagens/clubes/goias1.jpg", "Camisa Goiás 2025", 279.90m },
                    { 15, 15, "Camisa oficial do Botafogo 2025, design clássico e confortável", "/imagens/clubes/botafogo1.jpg", "Camisa Botafogo 2025", 319.90m },
                    { 16, 16, "Camisa oficial do Atlético Goianiense 2025, moderna e leve", "/imagens/clubes/atleticogo1.jpg", "Camisa Atlético GO 2025", 289.90m },
                    { 17, 17, "Camisa oficial do Juventude 2025, confortável e estilosa", "/imagens/clubes/juventude1.jpg", "Camisa Juventude 2025", 279.90m },
                    { 18, 18, "Camisa oficial do Vasco 2025, clássica e resistente", "/imagens/clubes/vasco1.jpg", "Camisa Vasco 2025", 309.90m },
                    { 19, 19, "Camisa oficial do Grêmio 2025, confortável e moderna", "/imagens/clubes/gremio1.jpg", "Camisa Grêmio 2025", 309.90m },
                    { 20, 20, "Camisa oficial do São Bento 2025, leve e resistente", "/imagens/clubes/saobento1.jpg", "Camisa São Bento 2025", 279.90m },
                    { 21, 21, "Camisa oficial do Internacional, modelo 2025, confortável e resistente", "/imagens/clubes/internacional1.jpg", "Camisa Internacional 2025", 319.90m },
                    { 22, 22, "Camisa oficial do Santos, modelo 2025, perfeita para torcer em grande estilo", "/imagens/clubes/santos1.jpg", "Camisa Santos 2025", 309.90m }
                });
        }
    }
}
