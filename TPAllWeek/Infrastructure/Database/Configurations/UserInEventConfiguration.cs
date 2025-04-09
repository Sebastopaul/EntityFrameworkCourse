﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class UserInEventConfiguration : IEntityTypeConfiguration<UserInEvent>
{
    public void Configure(EntityTypeBuilder<UserInEvent> builder)
    {
        builder.ToTable(nameof(UserInEvent));
        builder.HasKey(uie => uie.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
        builder.Property(uie => uie.RegistrationDate).IsRequired().HasColumnType("datetime2").HasPrecision(0);
        builder.Property(uie => uie.AttendanceStatus).IsRequired();
        builder.HasOne(uie => uie.User).WithMany(u => u.SubscribedEvents).HasForeignKey(uie => uie.UserId).IsRequired();
        builder.HasOne(uie => uie.Event).WithMany(u => u.SubscribedUsers).HasForeignKey(uie => uie.EventId).IsRequired();
    }
}