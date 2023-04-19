namespace ProjetoCinema.Core.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    
        public IEnumerable<Filme> Filme { get; set; }
    }
}
 