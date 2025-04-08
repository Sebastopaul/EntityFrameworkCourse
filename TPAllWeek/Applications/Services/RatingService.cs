using TPAllWeek.Applications.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Applications.Services;

public class RatingService : BaseService<RatingRepository, Rating>
{
    public RatingService(RatingRepository repository) : base(repository)
    { }
}