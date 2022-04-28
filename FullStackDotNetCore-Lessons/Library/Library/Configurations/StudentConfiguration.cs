using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Configurations
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(x => x.FirstName).IsRequired().HasColumnType("varchar(50)");
            builder.Property(x => x.LastName).IsRequired();
            builder.HasOne(s => s.StudentDetail).WithOne(sd => sd.Student).HasForeignKey<StudentDetail>(sd => sd.StudentId);
        }
    }
}
