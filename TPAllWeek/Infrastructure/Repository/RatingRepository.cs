using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Database;

namespace TPAllWeek.Infrastructure.Repository;

public class RatingRepository : BaseRepository<Rating, CoreDbContext>
{
    public RatingRepository(CoreDbContext databaseContext) : base(databaseContext)
    { }
}