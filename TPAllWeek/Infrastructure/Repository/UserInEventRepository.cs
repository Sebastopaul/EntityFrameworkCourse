using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Database;

namespace TPAllWeek.Infrastructure.Repository;

public class UserInEventRepository : BaseRepository<UserInEvent, CoreDbContext>
{
    public UserInEventRepository(CoreDbContext databaseContext) : base(databaseContext)
    { }
}