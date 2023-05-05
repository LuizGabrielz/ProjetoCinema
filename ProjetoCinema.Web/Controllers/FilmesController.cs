using ProjetoCinema.Data;

namespace ProjetoCinema.Web.Controllers;

public class FilmesController : Controller
{
    private readonly ApplicationDbContext _dbContext;
     private readonly IFilmeRepository _filmeRepository;

    public FilmesController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
         
    }
    public IActionResult Index() => View(_dbContext.Filmes.ToList()); 
} 
 