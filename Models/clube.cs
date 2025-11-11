namespace WebApplication1.Models
{
    public class Clube
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public int LigaId { get; set; }     // 🔹 FK
        public Liga Liga { get; set; } = null!;
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }
}
