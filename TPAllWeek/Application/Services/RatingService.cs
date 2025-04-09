using TPAllWeek.Application.Base;
using TPAllWeek.Domain.Models;
using TPAllWeek.Infrastructure.Repository;

namespace TPAllWeek.Application.Services;

public class RatingService : BaseService<RatingRepository, Rating>
{
    public RatingService(RatingRepository repository) : base(repository)
    { }
}