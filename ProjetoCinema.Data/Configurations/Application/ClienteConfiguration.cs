namespace ProjetoCinema.Data.Configurations.Application
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("cliente", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_cliente");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome").HasMaxLength(60);
            builder.Property(x => x.Telefone).HasColumnName("telefone").HasMaxLength(12);

            builder.HasMany(x => x.Enderecos).WithOne(x => x.Cliente);
        }
    }
}
 