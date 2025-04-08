using Microsoft.EntityFrameworkCore;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database;

public class CoreDbContext : DbContext
{
    public DbSet<Category> Categories { get; set; }
    public DbSet<Event> Events { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Session> Sessions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserInEvent> UsersInEvents { get; set; }
    public DbSet<UserInSession> UsersInSessions { get; set; }
    
    public CoreDbContext(DbContextOptions<CoreDbContext> options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    }
}
