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
    public ICollection<UserInEvent> SubscribedEvents { get; set; }
    public ICollection<UserInSession> SubscribedSessions { get; set; }
}