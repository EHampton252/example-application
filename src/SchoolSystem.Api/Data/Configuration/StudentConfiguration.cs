using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Api.Domain;

namespace SchoolSystem.Api.Data.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> modelBuilder)
        {
            modelBuilder.ToTable("Student");
            modelBuilder.HasKey(x => x.Id);
            modelBuilder.HasOne(x => x.Grade).WithMany(x => x.Students).HasForeignKey(x => x.GradeId);
        }
    }
}
