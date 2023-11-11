using HumorHub.Models;
using Microsoft.EntityFrameworkCore;
namespace HumorHub.Data;

public class HumorContext : DbContext
{
    public HumorContext(DbContextOptions<HumorContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>()
            .HasMany(e => e.Jokes)
            .WithOne(e => e.Category)
            .HasForeignKey(e => e.CategoryId)
            .HasPrincipalKey(e => e.Id)
            .OnDelete(DeleteBehavior.Restrict);
    }
    
    public DbSet<Joke> Jokes { get; set; }
    public DbSet<Category> Categories { get; set; }
}