using Microsoft.EntityFrameworkCore;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database;

public class CoreDbContext : DbContext
{
    public DbSet<Event> Events { get; set; }
    public DbSet<Category> Categories { get; set; }
    
    public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
