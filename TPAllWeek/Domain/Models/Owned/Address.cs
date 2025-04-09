using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TPAllWeek.Domain.Models.Owned;

public class Address
{
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string ZipCode { get; set; }
    public required string Country { get; set; }
}