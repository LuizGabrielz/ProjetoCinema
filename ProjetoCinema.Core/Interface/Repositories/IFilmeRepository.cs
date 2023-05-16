namespace ProjetoCinema.Core.Interfaces;

public interface IFilmeRepository
{
    Task<IEnumerable<Filme>> BuscarFilmesAsynce(Categoria categoria);
}
