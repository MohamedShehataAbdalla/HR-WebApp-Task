using HRAppExample.Models;
using Microsoft.EntityFrameworkCore;

namespace HRAppExample.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Employee>().ToTable("Employees", "HR");

            modelBuilder.Entity<Department>().HasData(Repository.LoadDepartments());
            modelBuilder.Entity<Employee>().HasData(Repository.LoadEmployees());
        }

        protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {

            builder.Properties<DateOnly>()
                .HaveConversion<DateOnlyConverter>()
                .HaveColumnType("DATE");

            base.ConfigureConventions(builder);

        }
    }
}
