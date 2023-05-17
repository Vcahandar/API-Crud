using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Configurations
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.Property(m => m.FullName).HasMaxLength(100).IsRequired(false);
            builder.Property(m => m.SoftDelete).IsRequired().HasDefaultValue(false);
            builder.Property(m => m.Address).IsRequired().HasMaxLength(250);
            builder.Property(m => m.Age).IsRequired();
        }
    }
}
