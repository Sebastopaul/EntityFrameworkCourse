using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.ToTable(nameof(Category));
        builder.HasKey(c => c.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
        builder.Property(c => c.Name).IsRequired().HasMaxLength(64);
        builder.HasIndex(c => c.Name).IsUnique();
        builder.HasMany(e => e.Events).WithOne(e => e.Category).HasForeignKey(e => e.CategoryId).OnDelete(DeleteBehavior.Restrict);
    }
}