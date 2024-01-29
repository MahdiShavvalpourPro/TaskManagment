using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Domain.Entities.Persons;

namespace TaskManagement.Infrastructure.DbContextConfiguration.PersonConfiguration;
public class PersonConfig : IEntityTypeConfiguration<Person>
{
    public void Configure(EntityTypeBuilder<Person> builder)
    {
        builder.Property(x => x.FirstName).IsRequired();
        builder.Property(x => x.FirstName).HasMaxLength(50);

        builder.Property(x => x.LastName).IsRequired();
        builder.Property(x => x.LastName).HasMaxLength(150);

        builder.Property(x => x.Email).IsRequired();
        builder.Property(x => x.Email).HasMaxLength(150);

        builder.Property(x => x.PhoneNumber).HasMaxLength(11);
    }
}
