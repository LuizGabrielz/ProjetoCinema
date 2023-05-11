using ProjetoCinema.Core.Helpers;

namespace ProjetoCinema.Core.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataContratado { get; set; }
        public double Salario { get; set; }      
   
        public bool IsValid(Notification notification)
        {
            if(string.IsNullOrEmpty(Nome))
            notification.Add("Nome do funcionario é obrigatório");

            if(Salario == default || Salario == 0)
            notification.Add("Salario do funcionario é obrigatório");

            return !notification.Any();
        }
    }
} 
