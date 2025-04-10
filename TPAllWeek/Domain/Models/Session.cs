using System.Collections.ObjectModel;
using TPAllWeek.Domain.Base;

namespace TPAllWeek.Domain.Models;

public class Session : BaseEntity
{
    public required string Title { get; set; }
    public string? Description { get; set; }
    public required DateTime Start { get; set; }
    public required DateTime End { get; set; }
    public int EventId { get; set; }
    public int? RoomId { get; set; }
    public Event Event { get; set; }
    public Room? Room { get; set; }
    public ICollection<UserInSession> SubscribedUsers = new Collection<UserInSession>();
    public ICollection<Rating> Ratings = new Collection<Rating>();
}