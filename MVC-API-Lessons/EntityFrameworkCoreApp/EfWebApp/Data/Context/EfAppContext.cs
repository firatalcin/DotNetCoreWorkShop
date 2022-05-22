using EfWebApp.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfWebApp.Data.Context
{
    public class EfAppContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=DESKTOP-MVQ36J3\SQLEXPRESS;Database=EfCoreApp;Trusted_Connection=True");
        }
    }
}
