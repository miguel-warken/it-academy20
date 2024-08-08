using System.Data.Common;
using Microsoft.EntityFrameworkCore;

public class BloggingContext : DbContext
{
    public DbSet<Blog> Blogs { get; set; } = null!;
    public DbSet<Post> Posts { get; set; } = null!;
    public DbSet<Comentario> ComentariosS { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(@"Server=localhost;Database=blogging;Trusted_Connection=True");
        optionsBuilder.EnableSensitiveDataLogging()
            .LogTo(Console.Write);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Comentario>()
            .Property(c => c.ComentarioId)
            .ValueGeneratedOnAdd();
    }
}