namespace ProjetoCinema.Core.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public int IdFuncionario { get; set; }
        public int IdFilme { get; set; }
        public DateTime DataVenda { get; set; }
        public int Preco { get; set; }

        public Funcionario Funcionario { get; set; }
        public Filme Filme { get; set; }
    }
} 
