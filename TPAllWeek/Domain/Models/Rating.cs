using TPAllWeek.Domain.Base;

namespace TPAllWeek.Domain.Models;

public class Rating : BaseEntity
{
    public required int Mark { get; set; }
    public string? Comment { get; set; }
    public required DateTime Date { get; set; }
    public required User User { get; set; }
    public required Session Session { get; set; }
}