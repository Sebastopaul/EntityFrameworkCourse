using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class Customer
{
    [Key]
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [Column(Order = 1)]
    [MinLength(0), MaxLength(255)]
    public required string LastName { get; set; }
    [Required]
    [Column(Order = 2)]
    [MinLength(0), MaxLength(255)]
    public required string FirstName { get; set; }
    [Required]
    [MinLength(0), MaxLength(255)]
    public required string Email { get; set; }
    [Required]
    [MinLength(0), MaxLength(255)]
    public required string Password { get; set; }
    public DateOnly BirthDate { get; set; }
    [InverseProperty("Customer")]
    public ICollection<Order> Orders { get; set; } = new Collection<Order>();
    public Address? ShippingAddress { get; set; }
    public Address? BillingAddress { get; set; }
}