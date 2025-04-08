using TPAllWeek.Applications.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Applications.Services;

public class RoomService : BaseService<RoomRepository, Room>
{
    public RoomService(RoomRepository repository) : base(repository)
    { }
}