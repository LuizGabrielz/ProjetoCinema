namespace ProjetoCinema.Data.Configurations.Application
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("filme", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_filme");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.IdCategoria).HasColumnName("id_categoria");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Sinopse).HasColumnName("sinopse");
           
            builder.HasOne(x => x.Categoria).WithMany(x => x.Filmes).HasForeignKey(x => x.IdCategoria);
            builder.HasMany(x => x.Vendas).WithOne(x => x.Filme);

        }
    }
}
 