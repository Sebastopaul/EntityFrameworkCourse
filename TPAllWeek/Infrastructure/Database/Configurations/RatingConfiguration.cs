using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class RatingConfiguration : IEntityTypeConfiguration<Rating>
{
    public void Configure(EntityTypeBuilder<Rating> builder)
    {
        builder.ToTable(nameof(Rating));
        builder.HasKey(r => r.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
        builder.Property(r => r.Mark).IsRequired();
        builder.Property(r => r.Comment).HasMaxLength(1024);
        builder.Property(r => r.Date).IsRequired().HasColumnType("datetime2").HasPrecision(0);
        builder.HasOne(r => r.User).WithMany(u => u.SessionRatings).HasForeignKey(r => r.UserId);
        builder.HasOne(r => r.Session).WithMany(s => s.Ratings).HasForeignKey(r => r.SessionId);
    }
}