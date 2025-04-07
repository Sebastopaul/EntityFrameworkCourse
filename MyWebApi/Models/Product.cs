using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class Product
{
    [Key]
    [Column(Order = 0)]
    public int Id { get; set; }
    [Required]
    [Column(Order = 1)]
    [ForeignKey("CategoryId")]
    public required Category Category { get; set; }
    [Required]
    [Column(Order = 2, TypeName = "nvarchar(255)")]
    public required string Name { get; set; }
    public int Quantity { get; set; }
    [Range(0, Int32.MaxValue)]
    public int Price { get; set; }
    [InverseProperty("Product")]
    public ICollection<OrderItem> OrderItems { get; set; } = new Collection<OrderItem>();
}