using TPAllWeek.Applications.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Applications.Services;

public class UserInEventService : BaseService<UserInEventRepository, UserInEvent>
{
    public UserInEventService(UserInEventRepository repository) : base(repository)
    { }
}