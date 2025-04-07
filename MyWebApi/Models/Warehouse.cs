using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class Warehouse
{
    [Key]
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public required Address Address { get; set; }
    [InverseProperty("Warehouse")]
    public ICollection<ProductInWarehouse> ProductsInWarehouse { get; set; }
}