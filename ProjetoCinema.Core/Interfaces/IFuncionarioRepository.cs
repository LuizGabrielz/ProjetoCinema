using ProjetoCinema.Core.Models;

namespace Core.Interfaces.Repositories;

public interface IFuncionarioRepository
{
    Task<IEnumerable<Funcionario>> BuscarFuncionarios();
    Task CadastrarFuncionario(Funcionario funcionario);
    Task ExcluirFuncionario(int id);
    Task EditarFuncionario(Funcionario funcionario);
    Task<Funcionario> BuscarFuncionarioPorId(int id);
}
