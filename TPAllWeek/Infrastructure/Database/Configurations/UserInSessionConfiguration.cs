using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TPAllWeek.Domain.Models;
using TPAllWeek.Domain.Models.Enums;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class UserInSessionConfiguration : IEntityTypeConfiguration<UserInSession>
{
    public void Configure(EntityTypeBuilder<UserInSession> builder)
    {
        builder.ToTable(nameof(UserInSession));
        builder.HasKey(uis => uis.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
        builder.Property(uis => uis.RegistrationDate).IsRequired().HasColumnType("datetime2").HasPrecision(0);
        builder.Property(uis => uis.Role).IsRequired().HasConversion(new EnumToStringConverter<UserInSessionRole>()).HasMaxLength(16);
        builder.Property(uis => uis.AttendanceStatus).IsRequired().HasConversion(new EnumToStringConverter<UserInSessionStatus>()).HasMaxLength(16);
        builder.HasOne(uie => uie.User).WithMany(u => u.SubscribedSessions).HasForeignKey(uie => uie.UserId).IsRequired();
        builder.HasOne(uie => uie.Session).WithMany(u => u.SubscribedUsers).HasForeignKey(uie => uie.SessionId).IsRequired();
    }
}