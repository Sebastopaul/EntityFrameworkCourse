using System.Collections.ObjectModel;
using TPAllWeek.Domain.Base;
using TPAllWeek.Domain.Models.Owned;

namespace TPAllWeek.Domain.Models;

public class User : BaseEntity
{
    public required Profile Profile { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public required string Password { get; set; }
    public string? JobTitle { get; set; }
    public required ICollection<UserInEvent> SubscribedEvents { get; set; } = new Collection<UserInEvent>();
    public required ICollection<UserInSession> SubscribedSessions { get; set; } = new Collection<UserInSession>();
    public required ICollection<Rating> SessionRatings { get; set; } = new Collection<Rating>();
}