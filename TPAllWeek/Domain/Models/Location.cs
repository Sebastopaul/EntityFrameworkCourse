using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using TPAllWeek.Domain.Base;

namespace TPAllWeek.Domain.Models.Owned;

public class Location : BaseEntity
{
    public required string Name { get; set; }
    public required int Capacity { get; set; }
    public required Address Address { get; set; }
    public required ICollection<Room> Rooms { get; set; } = new Collection<Room>();
}