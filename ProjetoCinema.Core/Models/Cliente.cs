namespace ProjetoCinema.Core.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public int IdEndereco { get; set; }
        public string Nome { get; set;}
        public int Telefone { get; set;}        
    
        public IEnumerable<Endereco> Enderecos { get; set; }
        public IEnumerable<Pedido> Pedidos { get; set; }
    }
}  
