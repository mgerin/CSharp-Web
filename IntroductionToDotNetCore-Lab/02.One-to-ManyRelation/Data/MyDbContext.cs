using Microsoft.EntityFrameworkCore;
using _02.One_to_ManyRelation.Models;

namespace _02.One_to_ManyRelation.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=MyTestDb;Integrated Security=True;");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .HasMany(d => d.Employees)
                .WithOne(d => d.Department)
                .HasForeignKey(e => e.DepartmentId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
