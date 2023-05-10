namespace ProjetoCinema.Data.Configurations.Application
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("funcionario", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_funcionario");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.Nome).HasColumnName("nome");
            builder.Property(x => x.DataContratado).HasColumnName("data_contratado");
            builder.Property(x => x.Salario).HasColumnName("salario");
        }
    }
}
