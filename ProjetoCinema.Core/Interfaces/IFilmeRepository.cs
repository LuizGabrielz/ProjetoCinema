using ProjetoCinema.Core.Models;

namespace Core.Interfaces.Repositories;

public interface IFilmeRepository
{
    Task<IEnumerable<Filme>> BuscarFilmesAsynce(Categoria categoria);
}
 