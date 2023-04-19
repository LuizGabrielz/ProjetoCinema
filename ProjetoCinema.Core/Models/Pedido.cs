namespace ProjetoCinema.Core.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public int IdFilme { get; set; }       
        public DateTime DataPedido { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Cliente Cliente { get; set; }
        public Filme Filme { get; set; }
    }
} 
