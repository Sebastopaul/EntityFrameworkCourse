using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace MyWebApi.Models;

public class Rating
{
    [Key]
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [Range(0, 5)]
    public int Mark { get; set; }
    [MinLength(0), MaxLength(1024)]
    public string? Comment { get; set; }
    [Required]
    [ForeignKey("ProductId")]
    public required Product Product { get; set; }
}