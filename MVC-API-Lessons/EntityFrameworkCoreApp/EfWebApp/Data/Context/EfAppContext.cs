using EfWebApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfWebApp.Data.Context
{
    public class EfAppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<SaleHistory> SaleHistories { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
        public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-MVQ36J3\SQLEXPRESS;Database=EfCoreApp;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employees");

            modelBuilder.Entity<ProductCategory>().HasOne(p => p.Product).WithMany(x => x.ProductCategories).HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<ProductCategory>().HasOne(c => c.Category).WithMany(x => x.ProductCategories).HasForeignKey(x => x.CategoryId);
            modelBuilder.Entity<ProductCategory>().HasKey(x => new { x.ProductId, x.CategoryId});

            modelBuilder.Entity<SaleHistory>().HasOne(x => x.Product).WithMany(x => x.SaleHistories).HasForeignKey(x => x.ProductId);
            modelBuilder.Entity<Product>().HasMany(x => x.SaleHistories).WithOne(x => x.Product).HasForeignKey(x => x.ProductId);

            modelBuilder.Entity<Product>().HasOne(x => x.ProductDetail).WithOne(x => x.Product).HasForeignKey<ProductDetail>(x => x.ProductId);

            modelBuilder.Entity<Category>().ToTable(name: "Category",schema: "dbo");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasColumnName("product_name");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Product>().HasIndex(x => x.Name).IsUnique(true);
            modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValueSql("'Urun bilgisi girilmemistir.'");
            modelBuilder.Entity<Product>().Property(x => x.Name).HasDefaultValueSql("getdate()");


            modelBuilder.Entity<Customer>().HasKey(c => c.CustomerId);
        }
    }
}
