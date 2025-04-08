using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class UserInEventConfiguration : IEntityTypeConfiguration<UserInEvent>
{
    public void Configure(EntityTypeBuilder<UserInEvent> builder)
    {
        builder.ToTable(nameof(UserInEvent));
        builder.HasKey(c => c.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
    }
}