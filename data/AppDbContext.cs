using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Liga> Ligas { get; set; }
        public DbSet<Clube> Clubes { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Define precisão da coluna Preco
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(10, 2);

            // 🔹 Dados iniciais de Ligas
            modelBuilder.Entity<Liga>().HasData(
                new Liga { Id = 1, Nome = "Campeonato Brasileiro" },
                new Liga { Id = 2, Nome = "Champions League" }
            );

            // 🔹 Dados iniciais de Clubes
            modelBuilder.Entity<Clube>().HasData(
                new Clube { Id = 1, Nome = "Flamengo", LigaId = 1 },
                new Clube { Id = 2, Nome = "Palmeiras", LigaId = 1 },
                new Clube { Id = 3, Nome = "Real Madrid", LigaId = 2 },
                new Clube { Id = 4, Nome = "Manchester City", LigaId = 2 }
            );

            // 🔹 Dados iniciais de Produtos
            modelBuilder.Entity<Produto>().HasData(
                new Produto
                {
                    Id = 1,
                    Nome = "Camisa Flamengo 2025",
                    Descricao = "Camisa oficial do Flamengo - modelo 2025",
                    Preco = 349.90m,
                    ImagemUrl = "/imagens/flamengo.jpg",
                    ClubeId = 1
                },
                new Produto
                {
                    Id = 2,
                    Nome = "Camisa Palmeiras 2025",
                    Descricao = "Camisa oficial do Palmeiras - modelo 2025",
                    Preco = 339.90m,
                    ImagemUrl = "/imagens/palmeiras.jpg",
                    ClubeId = 2
                },
                new Produto
                {
                    Id = 3,
                    Nome = "Camisa Real Madrid 2025",
                    Descricao = "Camisa oficial do Real Madrid - modelo 2025",
                    Preco = 399.90m,
                    ImagemUrl = "/imagens/realmadrid.jpg",
                    ClubeId = 3
                },
                new Produto
                {
                    Id = 4,
                    Nome = "Camisa Manchester City 2025",
                    Descricao = "Camisa oficial do Manchester City - modelo 2025",
                    Preco = 379.90m,
                    ImagemUrl = "/imagens/mancity.jpg",
                    ClubeId = 4
                }
            );
        }
    }
}
