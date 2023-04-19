namespace ProjetoCinema.Data.Configuration.Application
{
    public class FilmeConfiguration : IEntityTypeConfiguration<Filme>
    {
        public void Configure(EntityTypeBuilder<Filme> builder)
        {
            builder.ToTable("Filme", "dbo");

            builder.HasKey(x => x.Id).HasName("id_filme");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.Sinopse).HasColumnName("sinopse"); 

            builder.HasOne(x => x.Categoria).WithMany(x => x.Filme).HasForeignKey(x => x.Categoria);
            builder.HasMany(x => x.Vendas).WithOne(x => x.Filme).HasForeignKey(x => x.IdFuncionario);

        }
    }
}
