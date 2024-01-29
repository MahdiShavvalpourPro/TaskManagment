using Microsoft.EntityFrameworkCore;
using TaskManagement.Domain.Entities.Persons;
using TaskManagement.Domain.Entities.Projects;
using TaskManagement.Infrastructure.DbContextConfiguration.PersonConfiguration;
using TaskManagement.Infrastructure.DbContextConfiguration.ProjectConfiguration;

namespace TaskManagement.Infrastructure;
public class TaskManagementDbContext : DbContext
{
    public TaskManagementDbContext(DbContextOptions options) : base(options)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PersonConfig());
        modelBuilder.ApplyConfiguration(new ProjectConfig());
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Person> Tbl_Persons { get; set; }
    public DbSet<Project> Tbl_Projects { get; set; }

}
