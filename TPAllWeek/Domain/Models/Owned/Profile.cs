using Microsoft.EntityFrameworkCore;

namespace TPAllWeek.Domain.Models.Owned;

[Owned]
public class Profile
{
    public byte[]? Image { get; set; }
    public required string Name { get; set; }
    public string? Description { get; set; }
}