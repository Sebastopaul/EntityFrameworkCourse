using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.ToTable(nameof(Room));
        builder.HasKey(c => c.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
    }
}