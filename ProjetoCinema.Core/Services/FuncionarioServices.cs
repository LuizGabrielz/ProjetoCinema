using ProjetoCinema.Core.Helpers;

namespace ProjetoCinema.Core.Services;

public class FuncionarioService : IFuncionarioService
{
    private readonly IFuncionarioRepository _funcionarioRepository;
    private readonly Notification _notification;

    public FuncionarioService(IFuncionarioRepository funcionarioRepository, Notification notification)
    {
        _funcionarioRepository = funcionarioRepository;
        _notification = notification;
    }

    public async Task ReceberDados(Funcionario model)
    {
        var existe = await _funcionarioRepository.BuscarFuncionarios(model);

        if(existe.Any())
            _notification.Add("Já existe funcionario com esse nome");
        else
            await _funcionarioRepository.CadastrarFuncionario(model);
    } 

}
