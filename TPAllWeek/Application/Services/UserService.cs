using TPAllWeek.Application.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Application.Services;

public class UserService : BaseService<UserRepository, User>
{
    public UserService(UserRepository repository) : base(repository)
    { }
}