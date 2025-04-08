using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Database;

namespace TPAllWeek.Infrastructure.Repository;

public class UserInSessionRepository : BaseRepository<UserInSession, CoreDbContext>
{
    public UserInSessionRepository(CoreDbContext databaseContext) : base(databaseContext)
    { }
}