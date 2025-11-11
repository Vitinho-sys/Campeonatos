namespace WebApplication1.Models
{
    public class Liga
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        // Se quiser associar clubes depois:
        public List<Clube>? Clubes { get; set; }
    }
}
