using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class ProductInWarehouse
{
    [Key]
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [Range(0, int.MaxValue)]
    public int Quantity { get; set; }
    [Required]
    [ForeignKey("WarehouseId")]
    public required Warehouse Warehouse { get; set; }
    [Required]
    [ForeignKey("ProductId")]
    public required Product Product { get; set; }
}