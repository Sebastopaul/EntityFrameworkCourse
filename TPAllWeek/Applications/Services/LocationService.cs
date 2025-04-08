using TPAllWeek.Applications.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Applications.Services;

public class LocationService : BaseService<LocationRepository, Location>
{
    public LocationService(LocationRepository repository) : base(repository)
    { }
}