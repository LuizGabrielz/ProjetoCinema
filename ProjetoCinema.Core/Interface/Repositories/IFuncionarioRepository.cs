namespace ProjetoCinema.Core.Interfaces;

public interface IFuncionarioRepository
{
    Task<IEnumerable<Funcionario>> BuscarFuncionarios(Funcionario model);
    Task CadastrarFuncionario(Funcionario funcionario);
    Task ExcluirFuncionario(int id);
    Task EditarFuncionario(Funcionario funcionario);
    Task<Funcionario> BuscarFuncionarioPorId(int id);
}
