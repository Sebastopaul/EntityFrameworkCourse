﻿using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class LocationConfiguration : IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable(nameof(Location));
        builder.HasKey(l => l.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
        builder.Property(l => l.Name).IsRequired().HasMaxLength(64);
        builder.HasIndex(l => l.Name).IsUnique();
        builder.Property(l => l.Capacity).IsRequired();
        builder.HasMany(l => l.Events).WithOne(e => e.Location).HasForeignKey(e => e.LocationId).OnDelete(DeleteBehavior.Restrict);
        builder.HasMany(l => l.Rooms).WithOne(r => r.Location).HasForeignKey(r => r.LocationId).OnDelete(DeleteBehavior.Cascade);
        builder.HasData([
            new Location
            {
                Id = 1,
                Name = "Location 1",
                Capacity = 100,
            },
            new Location
            {
                Id = 2,
                Name = "Location 2",
                Capacity = 200,
            },
        ]);
        builder.OwnsOne(l => l.Address, addressBuilder =>
        {
            addressBuilder.Property(a => a.Street).IsRequired().HasMaxLength(128);
            addressBuilder.Property(a => a.City).IsRequired().HasMaxLength(64);
            addressBuilder.Property(a => a.ZipCode).IsRequired().HasMaxLength(16);
            addressBuilder.Property(a => a.Country).IsRequired().HasMaxLength(64);
        }).HasData([
            new {
                LocationId = 1,
                City = "London",
                Country = "USA",
                Street = "123 Main Street",
                ZipCode = "12345"
            },
            new {
                LocationId = 2,
                City = "London",
                Country = "USA",
                Street = "123 Main Street",
                ZipCode = "12345"
            }
        ]);
    }
}