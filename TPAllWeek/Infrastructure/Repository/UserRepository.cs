using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Base;
using TPAllWeek.Infrastructure.Database;

namespace TPAllWeek.Infrastructure.Repository;

public class UserRepository : BaseRepository<User, CoreDbContext>
{
    public UserRepository(CoreDbContext databaseContext) : base(databaseContext)
    { }
}