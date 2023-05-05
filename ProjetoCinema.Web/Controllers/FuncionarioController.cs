namespace ProjetoCinema.Web.Controllers
{
    [Route("funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly IFuncionarioRepository _funcionarioRepository;
        public FuncionarioController(IFuncionarioRepository funcionarioRepository)
        {
            _funcionarioRepository = funcionarioRepository;
        }
        public ActionResult Index() => View();

        [HttpGet("listar")]
        public async Task<IActionResult> Listar() => View("_listar", await _funcionarioRepository.BuscarFuncionarios());
    
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
    }
}
