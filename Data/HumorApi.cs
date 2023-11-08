using HumorHub.Models;
using Microsoft.EntityFrameworkCore;
namespace HumorHub.Data;

public class HumorContext : DbContext
{
    public HumorContext(DbContextOptions<HumorContext> options) : base(options)
    {
        
    }
    
    public DbSet<Joke> Jokes { get; set; }
}