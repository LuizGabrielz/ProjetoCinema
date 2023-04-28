namespace ProjetoCinema.Web.Controllers
{
    [Route("[controller]")]
    public class CadastrarController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
