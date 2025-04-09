using TPAllWeek.Application.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Application.Services;

public class LocationService : BaseService<LocationRepository, Location>
{
    public LocationService(LocationRepository repository) : base(repository)
    { }
}