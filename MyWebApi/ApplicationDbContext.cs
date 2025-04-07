using Microsoft.EntityFrameworkCore;
using MyWebApi.Models;

namespace MyWebApi;

public class ApplicationDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderItem> OrderItems { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<PriceHistory> PriceHistories { get; set; }
    public DbSet<Rating> Ratings { get; set; }
    public DbSet<ProductInWarehouse> ProductsInWarehouse { get; set; }
    public DbSet<Warehouse> Warehouses { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}