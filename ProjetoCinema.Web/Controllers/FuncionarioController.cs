

namespace ProjetoCinema.Web.Controllers
{
    [Route("funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        private readonly IFuncionarioService _funcionarioService;
        private readonly Notification _notification;
       
        public FuncionarioController(IFuncionarioRepository funcionarioRepository, IFuncionarioService funcionarioService, Notification notification)
        {
            _funcionarioRepository = funcionarioRepository;
            _funcionarioService = funcionarioService;
            _notification = notification;
        }
        public ActionResult Index() => View();

        [HttpPost("listar")]
        public async Task<IActionResult> Buscar(Funcionario model) 
        {
            var resultado = await _funcionarioRepository.BuscarFuncionarios(model);
            
            if(resultado.Count() == 0)
                return BadRequest("funcionario não cadastrado");
            
            return View("_listar", resultado);
        } 
    
        [HttpPost("cadastrar")]
        public async Task<IActionResult> Cadastrar(Funcionario model)
        {  
            if (model == null)
                return BadRequest("nome do funcionario é obrigatório");
       
            if (!model.IsValid(_notification))
                return BadRequest(_notification.Get());

           var funcionario = new Funcionario{
                Nome = model.Nome,
                DataContratado = DateTime.Now.ToUniversalTime(),
                Salario = model.Salario
            };

             await _funcionarioService.ReceberDados(funcionario);

            if (_notification.Any())
                return BadRequest(string.Join(", ", _notification.Get()));

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
