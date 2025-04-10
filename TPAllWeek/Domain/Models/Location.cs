using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TPAllWeek.Domain.Base;
using TPAllWeek.Domain.Models.Owned;

namespace TPAllWeek.Domain.Models;

public class Location : BaseEntity
{
    public required string Name { get; set; }
    [Range(0, int.MaxValue)]
    public required int Capacity { get; set; }
    public Address Address { get; set; }
    public ICollection<Event> Events { get; set; } = new Collection<Event>();
    public ICollection<Room> Rooms { get; set; } = new Collection<Room>();
}