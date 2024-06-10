using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SchoolSystem.Api.Data.Configuration;
using SchoolSystem.Api.Domain;

namespace SchoolSystem.Api.Data
{
    public class SchoolSystemContext : DbContext
    {
        public SchoolSystemContext(DbContextOptions<SchoolSystemContext> options) : base(options)
        {
        }
        // Add DbSet for Student and Grade to allow EF Core to create tables for these entities and further allow us to perform CRUD operations on these entities and track the changes
        public DbSet<Student> Student { get; set; }
        public DbSet<Grade> Grade { get; set; }

        // Override OnModelCreating method to apply our own configurations for the entities we created earlier
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new GradeConfiguration());
        }
    }
}
