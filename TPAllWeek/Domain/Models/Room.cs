using TPAllWeek.Domain.Base;
using TPAllWeek.Domain.Models.Owned;

namespace TPAllWeek.Domain.Models;

public class Room : BaseEntity
{
    public required string Name { get; set; }
    public required int Capacity { get; set; }
    public required Location Location { get; set; }
}