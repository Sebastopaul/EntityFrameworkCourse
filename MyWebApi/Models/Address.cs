using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyWebApi.Models;

[Owned]
public class Address
{
    [Required]
    [MinLength(0), MaxLength(255)]
    public required string Street { get; set; }
    [Required]
    [MinLength(0), MaxLength(255)]
    public required string City { get; set; }
    [Required]
    [MinLength(0), MaxLength(10)]
    public required string ZipCode { get; set; }
    [Required]
    [MinLength(0), MaxLength(255)]
    public required string Country { get; set; }
}