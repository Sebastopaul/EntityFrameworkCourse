using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using TPAllWeek.Domain.Base;
using TPAllWeek.Domain.Models.Owned;

namespace TPAllWeek.Domain.Models;

public class Room : BaseEntity
{
    public required string Name { get; set; }
    [Range(0, int.MaxValue)]
    public required int Capacity { get; set; }
    public required int LocationId { get; set; }
    public required Location Location { get; set; }
    public ICollection<Session> Sessions { get; set; } = new Collection<Session>();
}