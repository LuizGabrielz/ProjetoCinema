namespace ProjetoCinema.Data
{
    public class ApplicationDbContext : BaseDbContext
    {
        public ApplicationDbContext(AppSettings appSettings) : base(appSettings, "Application")
        {

        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
