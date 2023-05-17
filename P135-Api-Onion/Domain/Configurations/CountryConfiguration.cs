using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            builder.Property(m => m.Name).IsRequired().HasMaxLength(100);
            builder.Property(m => m.SoftDelete).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.CreatedAt).IsRequired().HasDefaultValue(DateTime.UtcNow);
        }
    }
}
