using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TPAllWeek.Domain.Models.Owned;

[Owned]
public class Location
{
    [Required]
    [MaxLength(255)]
    public required string Street { get; set; }
    [Required]
    [MaxLength(255)]
    public required string City { get; set; }
    [Required]
    [MaxLength(10)]
    public required string ZipCode { get; set; }
    [Required]
    [MaxLength(255)]
    public required string Country { get; set; }

}