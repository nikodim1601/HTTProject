using HTTApp.Models;
using Microsoft.EntityFrameworkCore;

namespace HTTApp;

public class HTTDbContext : DbContext
{
    public HTTDbContext(DbContextOptions<HTTDbContext> options) : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasOne(p => p.Category)
            .WithMany(c => c.Products)
            .OnDelete(DeleteBehavior.Cascade);

        base.OnModelCreating(modelBuilder);
    }
}