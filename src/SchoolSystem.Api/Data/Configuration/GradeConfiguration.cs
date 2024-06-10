using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SchoolSystem.Api.Domain;

namespace SchoolSystem.Api.Data.Configuration
{
    internal class GradeConfiguration : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> modelBuilder)
        {
            modelBuilder.ToTable("Grade");
            modelBuilder.HasKey(x => x.Id);
            modelBuilder.HasMany(x => x.Students).WithOne(x => x.Grade).HasForeignKey(x => x.GradeId);
        }
    }
}
