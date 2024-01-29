using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaskManagement.Domain.Entities.Projects;

namespace TaskManagement.Infrastructure.DbContextConfiguration.ProjectConfiguration;
public class ProjectConfig : IEntityTypeConfiguration<Project>
{
    public void Configure(EntityTypeBuilder<Project> builder)
    {
        builder.Property(x => x.Name)
            .IsRequired()
            .HasMaxLength(100);


    }
}
