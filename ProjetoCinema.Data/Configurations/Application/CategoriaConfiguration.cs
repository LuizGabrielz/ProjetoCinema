namespace ProjetoCinema.Data.Configurations.Application
{
    public class CategoriaConfiguration : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("categoria", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_categoria");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");

            builder.HasMany(x => x.Filmes).WithOne(x => x.Categoria);
        }
    }
}
