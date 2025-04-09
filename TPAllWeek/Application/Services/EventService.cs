using TPAllWeek.Application.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Application.Services;

public class EventService : BaseService<EventRepository, Event>
{
    public EventService(EventRepository repository) : base(repository)
    { }
}