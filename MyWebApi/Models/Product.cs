using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class Product
{
    [Key]
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [Column(Order = 1)]
    [ForeignKey("CategoryId")]
    public required Category Category { get; set; }
    [Required]
    [Column(Order = 2, TypeName = "nvarchar(255)")]
    public required string Name { get; set; }
    [Required]
    [Range(0, double.MaxValue)]
    public double Price { get; set; }
    [InverseProperty("Product")]
    public ICollection<OrderItem> OrderItems { get; set; } = new Collection<OrderItem>();
    [InverseProperty("Product")]
    public ICollection<Rating> Rating { get; set; } = new Collection<Rating>();
    [InverseProperty("Product")]
    public ICollection<PriceHistory> PriceHistory { get; set; } = new Collection<PriceHistory>();

    [InverseProperty("Product")]
    public ICollection<ProductInWarehouse> ProductsInWarehouse { get; set; } = new Collection<ProductInWarehouse>();
}