using System.Reflection;
using Microsoft.EntityFrameworkCore;
using TPAllWeek.Domain.Models;
using TPAllWeek.Domain.Models.Owned;

namespace TPAllWeek.Infrastructure.Database;

public class CoreDbContext : DbContext
{
    public DbSet<Category> Category { get; set; }
    public DbSet<Event> Event { get; set; }
    public DbSet<Location> Location { get; set; }
    public DbSet<Rating> Rating { get; set; }
    public DbSet<Room> Room { get; set; }
    public DbSet<Session> Session { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserInEvent> UserInEvent { get; set; }
    public DbSet<UserInSession> UserInSession { get; set; }

    public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
