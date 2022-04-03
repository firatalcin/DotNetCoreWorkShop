using GRSYKitapEvi_Entities.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRSYKitapEvi_DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-MVQ36J3\\SQLEXPRESS; Database=DbGursoyKitapEvi; Trusted_Connection = True");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Type> Types { get; set; }
    }
}
