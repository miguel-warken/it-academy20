using DemoLojinha.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoLojinha.Database;

public class LojinhaContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Produto> Produtos { get; set; }
    public DbSet<Pedido> Pedidos { get; set; }
    //Não existe Item de fato, apenas dentro de Pedido ou de Produto
    //Produto - Item é uma relação identificadora indo ao Produto

    public LojinhaContext() { }

    public LojinhaContext(DbContextOptions<LojinhaContext> opcoes)
        : base(opcoes) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        //usar entity builder com um bloco que vai determinando como cada entidade será mapeada
        modelBuilder.Entity<Cliente>(eb =>
        {
            eb.Property(e => e.Nome).HasMaxLength(30);
            eb.Property(e => e.Email).HasMaxLength(50);
            eb.Property(e => e.Telefone).HasMaxLength(9);
        });

        modelBuilder.Entity<Produto>(eb =>
        {
            eb.Property(e => e.Nome).HasMaxLength(30);
            eb.Property(e => e.Descricao).HasMaxLength(200);
        });

        //Nao vou usar entity builder pois nao estou olhando propriedades agora
        modelBuilder.Entity<Pedido>()
                    .HasMany(pedido => pedido.Produtos)
                    .WithMany(produto => produto.Pedidos)
                    .UsingEntity<Item>();

    }
}

