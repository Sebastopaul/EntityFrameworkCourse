using TPAllWeek.Applications.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Applications.Services;

public class UserService : BaseService<UserRepository, User>
{
    public UserService(UserRepository repository) : base(repository)
    { }
}