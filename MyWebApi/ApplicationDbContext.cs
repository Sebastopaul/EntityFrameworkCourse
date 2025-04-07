using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; } // Represents the "Products" table
}