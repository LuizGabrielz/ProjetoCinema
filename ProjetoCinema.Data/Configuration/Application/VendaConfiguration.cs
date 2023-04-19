namespace ProjetoCinema.Data.Configuration.Application
{
    public class VendaConfiguration : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder)
        {
            builder.ToTable("venda", "dbo");

            builder.HasKey(x => x.Id).HasName("pk_venda");

            builder.Property(x => x.Id).ValueGeneratedNever().HasColumnName("id");
            builder.Property(x => x.IdFuncionario).HasColumnName("id_funcionario");
            builder.Property(x => x.IdFilme).HasColumnName("id_filme");
            builder.Property(x => x.DataVenda).HasColumnName("data_venda");
            builder.Property(x => x.Preco).HasColumnName("preco");
        
            builder.HasOne(x => x.Funcionario).WithMany(x => x.Vendas).HasForeignKey(x => x.IdFuncionario);
            builder.HasOne(x => x.Filme).WithMany(x => x.Vendas).HasForeignKey(x => x.IdFilme);
        }
    }
}
