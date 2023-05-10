using ProjetoCinema.Core.Helpers;

namespace ProjetoCinema.Web.Controllers
{
    [Route("funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly Notification _notification;
        public FuncionarioController(IFuncionarioRepository funcionarioRepository, Notification notification)
        {
            _funcionarioRepository = funcionarioRepository;
            _notification = notification;
        }
        public ActionResult Index() => View();

        [HttpPost("listar")]
        public async Task<IActionResult> Buscar(Funcionario model) => View("_listar", await _funcionarioRepository.BuscarFuncionarios(model));

        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(Funcionario model)
        {   
           var funcionario = new Funcionario{
                Nome = model.Nome,
                DataContratado = DateTime.Now.ToUniversalTime(),
                Salario = model.Salario
            };

            await _funcionarioRepository.CadastrarFuncionario(funcionario);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost("excluir")]
        public async Task<IActionResult> Excluir(int id)
        {
            await _funcionarioRepository.ExcluirFuncionario(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet("editar")]
        public async Task<IActionResult> Editar(int id)
        {
            var funcionarioSelecionado = await _funcionarioRepository.BuscarFuncionarioPorId(id);

            return View("_editar", funcionarioSelecionado);
        }
       
       [HttpPost("editar")]
       public async Task<IActionResult> EditarFuncionario(Funcionario funcionario)
       {
            await _funcionarioRepository.EditarFuncionario(new Funcionario { 
                Id = funcionario.Id,
                Nome = funcionario.Nome,
                DataContratado = DateTime.Now.ToUniversalTime(),
                Salario = funcionario.Salario
            });
            return Ok();
       }
    }
}
