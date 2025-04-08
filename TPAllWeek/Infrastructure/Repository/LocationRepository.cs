using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Database;

namespace TPAllWeek.Infrastructure.Repository;

public class LocationRepository : BaseRepository<Location, CoreDbContext>
{
    public LocationRepository(CoreDbContext databaseContext) : base(databaseContext)
    { }
}