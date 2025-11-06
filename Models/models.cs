namespace WebApplication1.Models
{
    public class Liga
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public List<Clube> Clubes { get; set; } = new List<Clube>();
    }
}

    public class Clube
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public List<Produto> Produtos { get; set; } = new List<Produto>();
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Descricao { get; set; } = null!;
        public decimal Preco { get; set; }
        public string ImagemUrl { get; set; } = null!;
    }

