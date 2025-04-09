using System.Collections.ObjectModel;
using TPAllWeek.Domain.Base;
using TPAllWeek.Domain.Models.Owned;
using TPAllWeek.Domain.Models.Enums;

namespace TPAllWeek.Domain.Models;

public class Event : BaseEntity
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required DateOnly StartDate { get; set; }
    public required DateOnly EndDate { get; set; }
    public required EventStatus Status { get; set; }
    public int? CategoryId { get; set; }
    public int? LocationId { get; set; }

    public Category? Category { get; set; }
    public Location? Location { get; set; }
    public ICollection<UserInEvent> SubscribedUsers { get; set; } = new Collection<UserInEvent>();
    public ICollection<Session> Sessions { get; set; } = new Collection<Session>();
}