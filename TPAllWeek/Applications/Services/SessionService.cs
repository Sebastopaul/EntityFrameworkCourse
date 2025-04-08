using TPAllWeek.Applications.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Applications.Services;

public class SessionService : BaseService<SessionRepository, Session>
{
    public SessionService(SessionRepository repository) : base(repository)
    { }
}