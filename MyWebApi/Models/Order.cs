using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class Order
{
    [Key]
    [Column(Order = 0)]
    public int Id { get; set; }
    [Required]
    [Column(Order = 1, TypeName = "nvarchar(255)")]
    public required string OrderNumber { get; set; }
    [Required]
    [ForeignKey("CustomerId")]
    public required Customer Customer { get; set; }
    [InverseProperty("Order")]
    public ICollection<OrderItem> OrderItems { get; set; } = new Collection<OrderItem>();
}