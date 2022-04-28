using Library.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Library.Configurations
{
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {
            builder.Ignore(x => x.Id);
            builder.HasKey(x => new { x.StudentId, x.BookId });
            builder.ToTable("Operasyonlar");
            builder.Property(x => x.StartDate).HasColumnType("datetime");
            builder.HasOne(o => o.Book).WithMany(b => b.Operations).HasForeignKey(o => o.BookId);
            builder.HasOne(o => o.Student).WithMany(b => b.Operations).HasForeignKey(o => o.StudentId);
        }
    }
}
