using TPAllWeek.Application.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Application.Services;

public class UserInSessionService : BaseService<UserInSessionRepository, UserInSession>
{
    public UserInSessionService(UserInSessionRepository repository) : base(repository)
    { }
}