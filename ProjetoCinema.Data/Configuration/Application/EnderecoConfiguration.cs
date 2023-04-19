namespace ProjetoCinema.Data.Configuration.Application
{
    public class EnderecoConfiguration : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("endereco", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_endereco");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.IdCliente).HasColumnName("id_cliente");
            builder.Property(x => x.Rua).HasColumnName("rua");
            builder.Property(x => x.Numero).HasColumnName("numero");
            builder.Property(x => x.Complemento).HasColumnName("complemento");
            builder.Property(x => x.Cep).HasColumnName("cep");
            builder.Property(x => x.Cidade).HasColumnName("cidade");
            builder.Property(x => x.Estado).HasColumnName("estado");
        
            builder.HasOne(x => x.Cliente).WithMany(x => x.Enderecos).HasForeignKey(x => x.IdCliente);
        }
    }
}
