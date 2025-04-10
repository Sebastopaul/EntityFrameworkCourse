using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable(nameof(User));
        builder.HasKey(u => u.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
        builder.Property(u => u.FirstName).IsRequired().HasMaxLength(64);
        builder.Property(u => u.LastName).IsRequired().HasMaxLength(64);
        builder.Property(u => u.Email).HasMaxLength(64);
        builder.HasIndex(u => u.Email).IsUnique();
        builder.Property(u => u.Phone).HasMaxLength(16);
        builder.HasIndex(u => u.Phone).IsUnique();
        builder.Property(u => u.StoredPassword).HasColumnName("Password").IsRequired().HasMaxLength(256);
        builder.Property(u => u.JobTitle).HasMaxLength(64);
        builder.HasMany(u => u.SubscribedEvents).WithOne(e => e.User).HasForeignKey(e => e.UserId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(u => u.SubscribedSessions).WithOne(s => s.User).HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(u => u.SessionRatings).WithOne(r => r.User).HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.NoAction);
        builder.HasData([
            new User
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@gmail.com",
                Password = "myPassword",
            },
            new User
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@gmail.com",
                Password = "myPassword",
            },
        ]);
        builder.OwnsOne(u => u.Profile, profileBuilder =>
        {
            profileBuilder.Property(p => p.Image);
            profileBuilder.Property(p => p.Name).IsRequired().HasMaxLength(64);
            profileBuilder.Property(p => p.Description).HasMaxLength(1024);
        }).HasData([
            new {
                UserId = 1,
                Name = "john Doe",
            },
            new {
                UserId = 2,
                Name = "John Doe",
            }
        ]);

    }
}