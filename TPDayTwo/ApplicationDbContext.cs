using Microsoft.EntityFrameworkCore;
using TPDayTwo.Models;

namespace TPDayTwo;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
}