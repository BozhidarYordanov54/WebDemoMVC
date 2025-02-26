using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebDemo.Infrastructure.Data.Models;

namespace WebDemo.Infrastrucutre.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>()
            .Property(c => c.Color)
            .HasConversion<string>();

        modelBuilder.Entity<Car>()
            .Property(c => c.Type)
            .HasConversion<string>();

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Car> Cars { get; set; } = null!;
    public DbSet<Engine> Engines { get; set; } = null!;
    public DbSet<Make> Makes { get; set; } = null!;
    public DbSet<Model> Models { get; set; } = null!;
    public DbSet<Country> Countries { get; set; } = null!;
}
