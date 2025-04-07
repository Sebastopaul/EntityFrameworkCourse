using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class OrderItem
{
    [Key]
    [Column(Order = 0)]
    public int Id { get; set; }
    [Required]
    [Column(Order = 1, TypeName = "nvarchar(255)")]
    public required string OrderNumber { get; set; }
    [Required]
    [ForeignKey("OrderId")]
    public required Order Order { get; set; }
    [Required]
    [ForeignKey("ProductId")]
    public required Product Product { get; set; }
}