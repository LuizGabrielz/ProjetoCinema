namespace ProjetoCinema.Data.Repositories
{
    public class FilmeRepository : IFilmeRepository 
    {
        private readonly ApplicationDbContext _dbContext;

        public FilmeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Filme>> BuscarFilmesAsynce(Categoria categoria)
        {
            return await _dbContext.Filmes
                .Include(x => x.Categoria)
                .Where(x => x.Categoria.Id == categoria.Id )
                .Select( x => new Filme 
                { 
                    Id = x.Id,
                    IdCategoria = x.Id,
                    Nome = x.Nome,
                    Sinopse = x.Sinopse,
                    Categoria = new Categoria 
                    {
                        Id = x.Categoria.Id,
                        Nome = x.Categoria.Nome
                    }
                }).ToListAsync();
        }
    }
}
