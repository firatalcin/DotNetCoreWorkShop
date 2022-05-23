using EfWebApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfWebApp.Data.Context
{
    public class EfAppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-MVQ36J3\SQLEXPRESS;Database=EfCoreApp;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Category>().ToTable(name: "Category",schema: "dbo");
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("product_name");
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100).IsRequired();

            //modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique(true);
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValueSql("'Urun bilgisi girilmemistir.'");
            //modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValueSql("getdate()");


            //modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);
        }
    }
}
