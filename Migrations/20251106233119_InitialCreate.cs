using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ligas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ligas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clubes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LigaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clubes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Clubes_Ligas_LigaId",
                        column: x => x.LigaId,
                        principalTable: "Ligas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClubeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Clubes_ClubeId",
                        column: x => x.ClubeId,
                        principalTable: "Clubes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Ligas",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { 1, "Premier League" },
                    { 2, "La Liga" },
                    { 3, "Brasileirão" }
                });

            migrationBuilder.InsertData(
                table: "Clubes",
                columns: new[] { "Id", "LigaId", "Nome" },
                values: new object[,]
                {
                    { 1, 1, "Manchester City" },
                    { 2, 1, "Arsenal" },
                    { 3, 2, "Real Madrid" },
                    { 4, 2, "Barcelona" },
                    { 5, 3, "Flamengo" },
                    { 6, 3, "Palmeiras" }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "ClubeId", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, 1, "Modelo titular oficial da temporada 2025.", "/img/produtos/mancity.jpg", "Camisa Manchester City 2025", 399.90m },
                    { 2, 3, "Versão dourada de colecionador.", "/img/produtos/realmadrid.jpg", "Camisa Real Madrid Edição Especial", 449.90m },
                    { 3, 5, "Oficial com escudo bordado e tecido dry-fit.", "/img/produtos/flamengo.jpg", "Camisa Flamengo 2025", 379.90m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Clubes_LigaId",
                table: "Clubes",
                column: "LigaId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_ClubeId",
                table: "Produtos",
                column: "ClubeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Clubes");

            migrationBuilder.DropTable(
                name: "Ligas");
        }
    }
}
