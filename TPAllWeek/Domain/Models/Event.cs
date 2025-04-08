using TPAllWeek.Domain.Base;
using TPAllWeek.Domain.Models.Owned;
using TPAllWeek.Domain.Models.Enums;

namespace TPAllWeek.Domain.Models;

public class Event : BaseEntity
{
    public required Location Location { get; set; }
    public required DateTime Date { get; set; }
    public required Category Category { get; set; }
    public required EventStatuses Status { get; set; }
}