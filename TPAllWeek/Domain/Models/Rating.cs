using System.ComponentModel.DataAnnotations;
using TPAllWeek.Domain.Base;

namespace TPAllWeek.Domain.Models;

public class Rating : BaseEntity
{
    [Range(0, 5)]
    public required int Mark { get; set; }
    public string? Comment { get; set; }
    public required DateTime Date { get; set; }
    public int? UserId { get; set; }
    public int SessionId { get; set; }
    public User? User { get; set; }
    public Session Session { get; set; }
}