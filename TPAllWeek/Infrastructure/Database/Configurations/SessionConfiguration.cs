using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class SessionConfiguration : IEntityTypeConfiguration<Session>
{
    public void Configure(EntityTypeBuilder<Session> builder)
    {
        builder.ToTable(nameof(Session));
        builder.HasKey(s => s.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
        builder.Property(s => s.Title).IsRequired().HasMaxLength(64);
        builder.HasIndex(s => new {s.Title, s.EventId}).IsUnique();
        builder.Property(s => s.Description).HasMaxLength(1024);
        builder.Property(s => s.Start).IsRequired().HasColumnType("datetime2");
        builder.Property(s => s.End).IsRequired().HasColumnType("datetime2");
        builder.HasOne(s => s.Event).WithMany(e => e.Sessions).HasForeignKey(s => s.EventId);
        builder.HasOne(s => s.Room).WithMany(r => r.Sessions).HasForeignKey(s => s.RoomId);
        builder.HasMany(s => s.SubscribedUsers).WithOne(uis => uis.Session).HasForeignKey(uis => uis.SessionId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(s => s.Ratings).WithOne(r => r.Session).HasForeignKey(r => r.SessionId).OnDelete(DeleteBehavior.Cascade);
    }
}