using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using TPAllWeek.Application.Utils;
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
    public string StoredPassword { get; set; } = String.Empty;
    [NotMapped]
    public required string Password {
        get { return StoredPassword; }
        set { StoredPassword = Hash.GetHashString(value); }
    }
    public string? JobTitle { get; set; }
    public required ICollection<UserInEvent> SubscribedEvents { get; set; } = new Collection<UserInEvent>();
    public required ICollection<UserInSession> SubscribedSessions { get; set; } = new Collection<UserInSession>();
    public required ICollection<Rating> SessionRatings { get; set; } = new Collection<Rating>();
}