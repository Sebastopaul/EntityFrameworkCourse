using System.Collections.ObjectModel;
using TPAllWeek.Domain.Base;
using TPAllWeek.Domain.Models.Owned;
using TPAllWeek.Domain.Models.Enums;

namespace TPAllWeek.Domain.Models;

public class Event : BaseEntity
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required DateTime StartDate { get; set; }
    public required DateTime EndDate { get; set; }
    public required EventStatus Status { get; set; }
    public required Category Category { get; set; }
    public required Location Location { get; set; }
    public required ICollection<UserInEvent> SubscribedUsers { get; set; } = new Collection<UserInEvent>();
    public required ICollection<Session> Sessions { get; set; } = new Collection<Session>();
}