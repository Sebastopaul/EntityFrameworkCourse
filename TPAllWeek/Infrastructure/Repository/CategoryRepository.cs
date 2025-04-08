using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Database;

namespace TPAllWeek.Infrastructure.Repository;

public class CategoryRepository : BaseRepository<Category, CoreDbContext>
{
    public CategoryRepository(CoreDbContext databaseContext) : base(databaseContext)
    { }
}