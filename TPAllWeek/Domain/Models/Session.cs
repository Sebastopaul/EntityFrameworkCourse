using System.Collections.ObjectModel;
using TPAllWeek.Domain.Base;

namespace TPAllWeek.Domain.Models;

public class Session : BaseEntity
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required DateTime Start { get; set; }
    public required DateTime End { get; set; }
    public required Event Event { get; set; }
    public required Room Room { get; set; }
    public required ICollection<UserInSession> SubscribedUsers = new Collection<UserInSession>();
    public required ICollection<Rating> Ratings = new Collection<Rating>();
}