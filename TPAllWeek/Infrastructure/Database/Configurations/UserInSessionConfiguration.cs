using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TPAllWeek.Domain.Models;

namespace TPAllWeek.Infrastructure.Database.Configurations;

public class UserInSessionConfiguration : IEntityTypeConfiguration<UserInSession>
{
    public void Configure(EntityTypeBuilder<UserInSession> builder)
    {
        builder.ToTable(nameof(UserInSession));
        builder.HasKey(c => c.Id).HasAnnotation("DatabaseGenerated", DatabaseGeneratedOption.Identity);
    }
}