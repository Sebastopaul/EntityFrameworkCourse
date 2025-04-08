using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Database;

namespace TPAllWeek.Infrastructure.Repository;

public class EventRepository : BaseRepository<Event, CoreDbContext>
{
    public EventRepository(CoreDbContext databaseContext) : base(databaseContext)
    { }
}