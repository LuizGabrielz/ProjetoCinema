namespace ProjetoCinema.Data.Configuration.Application
{
    public class FuncionarioConfiguration : IEntityTypeConfiguration<Funcionario>
    {
        public void Configure(EntityTypeBuilder<Funcionario> builder)
        {
            builder.ToTable("funcionario", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_funcionario");

            builder.Property(x => x.Id).ValueGeneratedOnAdd().HasColumnName("id");
            builder.Property(x => x.DataContratado).HasColumnName("datacontratado");
            builder.Property(x => x.Salario).HasColumnName("salario");
            
            builder.HasMany(x => x.Vendas).WithOne(x => x.Funcionario).HasForeignKey(x => x.IdFuncionario);
        }
    }
}