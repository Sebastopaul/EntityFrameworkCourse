using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Database;

namespace TPAllWeek.Infrastructure.Repository;

public class SessionRepository : BaseRepository<Session, CoreDbContext>
{
    public SessionRepository(CoreDbContext databaseContext) : base(databaseContext)
    { }
}