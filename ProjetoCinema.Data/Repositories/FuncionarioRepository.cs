namespace ProjetoCinema.Data.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public FuncionarioRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<IEnumerable<Funcionario>> BuscarFuncionarios()
        {
            return await _dbContext.Funcionarios

                .ToListAsync();
        }       
        public async Task CadastrarFuncionario(Funcionario funcionario)
        {
            await _dbContext.Funcionarios.AddAsync(funcionario);
            await _dbContext.SaveChangesAsync();
        }
    }
}
