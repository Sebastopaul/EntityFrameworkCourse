using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyWebApi.Models;

public class Category
{
    [Key]
    [Column(Order = 0)]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    [Required]
    [Column(Order = 1, TypeName = "nvarchar(255)")]
    public required string Name { get; set; }
    [InverseProperty("Category")]
    public ICollection<Product> Products { get; set; } = new Collection<Product>();
    [ForeignKey("ParentCategoryId")]
    public Category? ParentCategory { get; set; }
    [InverseProperty("ParentCategory")]
    public ICollection<Category> ChildCategories { get; set; } = new Collection<Category>();

}