using TPAllWeek.Application.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Application.Services;

public class RoomService : BaseService<RoomRepository, Room>
{
    public RoomService(RoomRepository repository) : base(repository)
    { }
}