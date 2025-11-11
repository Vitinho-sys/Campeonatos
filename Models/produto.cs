namespace WebApplication1.Models
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; } = null!;

        public int ClubeId { get; set; }     // 🔹 FK
        public Clube Clube { get; set; } = null!;
    }
}
