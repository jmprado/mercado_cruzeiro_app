using Microsoft.EntityFrameworkCore;

namespace MercadoApp.Entities;

public class MercadoAppDbContext : DbContext
{
    public DbSet<TipoLoja> TiposLoja { get; set; }
    public DbSet<Loja> Lojas { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<UnidadeProduto> UnidadesProduto { get; set; }
    public DbSet<Estoque> Estoque { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    public DbSet<PedidoProduto> PedidoProdutos { get; set; }
    public DbSet<EntradaProduto> EntradaProdutos { get; set; }
    public DbSet<ImagemProduto> ImagensProduto { get; set; }

    public MercadoAppDbContext(DbContextOptions<MercadoAppDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TipoLoja>(entity =>
        {
            entity.ToTable("tipo_loja");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired();
        });

        modelBuilder.Entity<Loja>(entity =>
        {
            entity.ToTable("loja");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired();
            entity.Property(e => e.NomeProprietario).IsRequired();
            entity.Property(e => e.Email);
            entity.Property(e => e.Telefone);
            entity.Property(e => e.Whatsapp).IsRequired();
            entity.Property(e => e.Descricao).IsRequired();
            entity.Property(e => e.ImagemLoja).IsRequired();
            entity.Property(e => e.Delivery).IsRequired();
            entity.HasOne(e => e.TipoLoja)
                  .WithMany(t => t.Lojas)
                  .HasForeignKey(e => e.IdTipoLoja);
        });

        modelBuilder.Entity<Produto>(entity =>
        {
            entity.ToTable("produto");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired();
            entity.Property(e => e.Preco).IsRequired();
        });

        modelBuilder.Entity<UnidadeProduto>(entity =>
        {
            entity.ToTable("unidade_produto");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired();
        });

        modelBuilder.Entity<Estoque>(entity =>
        {
            entity.ToTable("estoque");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Quantidade).IsRequired();
            entity.HasOne(e => e.Produto)
                  .WithMany(p => p.Estoques)
                  .HasForeignKey(e => e.IdProduto);
            entity.HasOne(e => e.Loja)
                  .WithMany(l => l.Estoques)
                  .HasForeignKey(e => e.IdLoja);
            entity.HasOne(e => e.UnidadeProduto)
                  .WithMany(u => u.Estoques)
                  .HasForeignKey(e => e.IdUnidade);
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.ToTable("cliente");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Nome).IsRequired();
            entity.Property(e => e.Email).IsRequired();
            entity.Property(e => e.Telefone).IsRequired();
            entity.Property(e => e.Logradouro).IsRequired();
            entity.Property(e => e.Numero).IsRequired();
            entity.Property(e => e.Complemento);
            entity.Property(e => e.Bairro).IsRequired();
            entity.Property(e => e.Cep).IsRequired();
        });

        modelBuilder.Entity<Pedido>(entity =>
        {
            entity.ToTable("pedido");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.DataPedido).IsRequired().HasDefaultValueSql("CURRENT_TIMESTAMP");
            entity.HasOne(e => e.Loja)
                  .WithMany(l => l.Pedidos)
                  .HasForeignKey(e => e.IdLoja);
            entity.HasOne(e => e.Cliente)
                  .WithMany(c => c.Pedidos)
                  .HasForeignKey(e => e.IdCliente);
        });

        modelBuilder.Entity<PedidoProduto>(entity =>
        {
            entity.ToTable("pedido_produto");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Quantidade).IsRequired();
            entity.HasOne(e => e.Pedido)
                  .WithMany(p => p.PedidoProdutos)
                  .HasForeignKey(e => e.IdPedido);
            entity.HasOne(e => e.Produto)
                  .WithMany(p => p.PedidoProdutos)
                  .HasForeignKey(e => e.IdProduto);
        });

        modelBuilder.Entity<EntradaProduto>(entity =>
        {
            entity.ToTable("entrada_produto");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Quantidade).IsRequired();
            entity.Property(e => e.DataOperacao).IsRequired().HasDefaultValueSql("CURRENT_TIMESTAMP");
            entity.HasOne(e => e.Produto)
                  .WithMany(p => p.EntradaProdutos)
                  .HasForeignKey(e => e.IdProduto);
        });

        modelBuilder.Entity<ImagemProduto>(entity =>
        {
            entity.ToTable("imagem_produto");
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Path).IsRequired();
            entity.HasOne(e => e.Produto)
                  .WithMany(p => p.ImagemProdutos)
                  .HasForeignKey(e => e.IdProduto);
        });
    }
}
