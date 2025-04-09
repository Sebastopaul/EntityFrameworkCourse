using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPAllWeek.Domain.Models;
using TPAllWeek.Domain.Models.Enums;

namespace TPAllWeek.Infrastructure.Database.Configurations;

// public required string Title { get; set; }
// public string? Description { get; set; }
// public required DateTime StartDate { get; set; }
// public required DateTime EndDate { get; set; }
// public required EventStatus Status { get; set; }
// public required Category Category { get; set; }
// public required Location Location { get; set; }
// public required ICollection<UserInEvent> SubscribedUsers { get; set; } = new Collection<UserInEvent>();
// public required ICollection<Session> Sessions { get; set; } = new Collection<Session>();


public class EventConfiguration : IEntityTypeConfiguration<Event>
{
    public void Configure(EntityTypeBuilder<Event> builder)
    {
        builder.ToTable(nameof(Event));
        builder.HasKey(e => e.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
        builder.Property(e => e.Title).IsRequired().HasMaxLength(64);
        builder.Property(e => e.Description).HasMaxLength(1024).IsUnicode();
        builder.Property(e => e.StartDate).IsRequired();
        builder.Property(e => e.EndDate).IsRequired();
        builder.Property(e => e.Status).IsRequired().HasConversion(new EnumToStringConverter<EventStatus>()).HasMaxLength(16);
        builder.HasOne(e => e.Category).WithMany(c => c.Events).HasForeignKey(e => e.CategoryId);
        builder.HasOne(e => e.Location).WithMany(l => l.Events).HasForeignKey(e => e.LocationId);
        builder.HasMany(e => e.SubscribedUsers).WithOne(e => e.Event).HasForeignKey(e => e.EventId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(e => e.Sessions).WithOne(e => e.Event).HasForeignKey(e => e.EventId).OnDelete(DeleteBehavior.Cascade);
    }
}