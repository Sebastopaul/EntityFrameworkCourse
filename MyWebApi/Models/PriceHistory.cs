using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class PriceHistory
{
    [Key]
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [ForeignKey("ProductId")]
    public required Product Product { get; set; }
    [Required]
    public DateTime Date { get; set; }
    [Required]
    [Range(0, double.MaxValue)]
    public double Price { get; set; }
}