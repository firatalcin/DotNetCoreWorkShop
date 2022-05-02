using Library.Configurations;
using Library.Initializer;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Context
{
    public class MyDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-MVQ36J3\\SQLEXPRESS;database=Library;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DataInitializer.Seed(modelBuilder);


            //Operation

            modelBuilder.ApplyConfiguration(new OperationConfiguration());


            //Authors

            modelBuilder.ApplyConfiguration(new AuthorConfiguration());


            //Student

            modelBuilder.ApplyConfiguration(new StudentConfiguration());


            //Book

            modelBuilder.ApplyConfiguration(new BookConfiguration());



        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookType> BookTypes { get; set; }
        public DbSet<Operation> Operations { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentDetail> StudentDetails { get; set; }
        public DbSet<AppUser> Users { get; set; }
    }
}
