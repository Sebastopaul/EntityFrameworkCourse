using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class Customer
{
    [Key]
    [Column(Order = 0)]
    public int Id { get; set; }
    [Required]
    [Column(Order = 1, TypeName = "nvarchar(255)")]
    public required string LastName { get; set; }
    [Required]
    [Column(Order = 2, TypeName = "nvarchar(255)")]
    public required string FirstName { get; set; }
    [Required]
    [Column(Order = 3, TypeName = "nvarchar(255)")]
    public required string Email { get; set; }
    public DateOnly BirthDate { get; set; }
    [InverseProperty("Customer")]
    public ICollection<Order> Orders { get; set; } = new Collection<Order>();
}