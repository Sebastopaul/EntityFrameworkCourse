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
        builder.HasKey(r => r.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
        builder.Property(r => r.Name).HasMaxLength(64);
        builder.HasIndex(r => new {r.Name, r.LocationId}).IsUnique();
        builder.Property(l => l.Capacity).IsRequired();
        builder.HasOne(r => r.Location).WithMany(l => l.Rooms).HasForeignKey(r => r.LocationId);
        builder.HasMany(r => r.Sessions).WithOne(s => s.Room).HasForeignKey(r => r.RoomId).OnDelete(DeleteBehavior.Restrict);
        builder.HasData([
            new Room()
            {
                Id = 1,
                Name = "Room 1",
                Capacity = 10,
                LocationId = 1
            },
            new Room()
            {
                Id = 2,
                Name = "Room 1",
                Capacity = 10,
                LocationId = 2
            },
        ]);
    }
}