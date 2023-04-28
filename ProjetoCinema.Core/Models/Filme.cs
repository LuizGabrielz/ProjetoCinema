namespace ProjetoCinema.Core.Models
{
    public class Filme
    {
        public int Id { get; set; }
        public int IdCategoria{ get; set; }
        public string Nome { get; set; }
        public string Sinopse { get; set; }

        public Categoria Categoria { get; set; }
    
        public IEnumerable<Venda> Vendas { get; set; }
    }
}
 