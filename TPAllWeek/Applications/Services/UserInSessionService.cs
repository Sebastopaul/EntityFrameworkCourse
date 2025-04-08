using TPAllWeek.Applications.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Applications.Services;

public class UserInSessionService : BaseService<UserInSessionRepository, UserInSession>
{
    public UserInSessionService(UserInSessionRepository repository) : base(repository)
    { }
}