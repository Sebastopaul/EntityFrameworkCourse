using TPAllWeek.Domain.Base;

namespace TPAllWeek.Domain.Models;

public class Category : BaseEntity
{
    public required string Name { get; set; }
}