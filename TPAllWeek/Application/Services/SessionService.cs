using TPAllWeek.Application.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Application.Services;

public class SessionService : BaseService<SessionRepository, Session>
{
    public SessionService(SessionRepository repository) : base(repository)
    { }
}