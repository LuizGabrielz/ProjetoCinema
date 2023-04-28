namespace ProjetoCinema.Data.Configurations.Application
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedido", "public");

            builder.HasKey(x => x.Id).HasName("pk_pedido");

            builder.Property(x => x.Id).ValueGeneratedNever().HasColumnName("id");
            builder.Property(x => x.IdCliente).HasColumnName("id_cliente");
            builder.Property(x => x.IdFilme).HasColumnName("id_Filme");
            builder.Property(x => x.DataPedido).HasColumnName("data_pedido");
            builder.Property(x => x.Quantidade).HasColumnName("quantidade");
            builder.Property(x => x.Preco).HasColumnName("preco");
        
            builder.HasOne(x => x.Cliente).WithMany(x => x.Pedidos).HasForeignKey(x => x.IdCliente);
        }  
    }
}
