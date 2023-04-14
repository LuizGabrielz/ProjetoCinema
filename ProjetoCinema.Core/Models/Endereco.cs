namespace ProjetoCinema.Core.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set;}
        public int Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
} 