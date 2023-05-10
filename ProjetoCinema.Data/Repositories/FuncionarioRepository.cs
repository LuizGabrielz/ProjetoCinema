namespace ProjetoCinema.Data.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public FuncionarioRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public async Task<IEnumerable<Funcionario>> BuscarFuncionarios(Funcionario model)
        {
            if (string.IsNullOrEmpty(model.Nome))
                return await _dbContext.Funcionarios.ToListAsync();
            else
                return await _dbContext.Funcionarios.Where(x => x.Nome == model.Nome).ToListAsync();
        }

        public async Task<Funcionario> BuscarFuncionarioPorId(int id)
        {
            return await _dbContext.Funcionarios
                .Where(x => x.Id == id).FirstOrDefaultAsync();
        }

        public async Task CadastrarFuncionario(Funcionario funcionario)
        {
            await _dbContext.Funcionarios.AddAsync(funcionario);
            await _dbContext.SaveChangesAsync();
        }
        public async Task ExcluirFuncionario(int id)
        {
            var funcionario = await _dbContext.Funcionarios.FirstOrDefaultAsync(x => x.Id == id);
            if (funcionario != null)
            {
                _dbContext.Funcionarios.Remove(funcionario);
                await _dbContext.SaveChangesAsync();
            }
        }
        public async Task EditarFuncionario(Funcionario funcionario)
        {
            _dbContext.Funcionarios
                    .Update(funcionario);
            await _dbContext.SaveChangesAsync();
        }
    }
}
