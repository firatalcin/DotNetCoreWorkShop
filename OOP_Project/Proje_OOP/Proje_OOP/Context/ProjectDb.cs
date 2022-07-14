using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.Context
{
    public class ProjectDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MVQ36J3\\SQLEXPRESS;database=OOPCoreDb;Trusted_Connection=True;");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}