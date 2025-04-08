using TPAllWeek.Applications.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Applications.Services;

public class EventService : BaseService<EventRepository, Event>
{
    public EventService(EventRepository repository) : base(repository)
    { }
}