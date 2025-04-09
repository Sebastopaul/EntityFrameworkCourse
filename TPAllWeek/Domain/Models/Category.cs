using System.Collections.ObjectModel;
using TPAllWeek.Domain.Base;

namespace TPAllWeek.Domain.Models;

public class Category : BaseEntity
{
    public required string Name { get; set; }
    public ICollection<Event> Events { get; set; } = new Collection<Event>();
}