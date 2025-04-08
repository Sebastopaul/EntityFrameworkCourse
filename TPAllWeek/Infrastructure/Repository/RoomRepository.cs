using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Database;

namespace TPAllWeek.Infrastructure.Repository;

public class RoomRepository : BaseRepository<Room, CoreDbContext>
{
    public RoomRepository(CoreDbContext databaseContext) : base(databaseContext)
    { }
}