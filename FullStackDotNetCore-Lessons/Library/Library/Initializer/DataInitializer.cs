using Library.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Library.Initializer
{
    public static class DataInitializer
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            string password1 = BCrypt.Net.BCrypt.HashPassword("123");
            string password2 = BCrypt.Net.BCrypt.HashPassword("1234");
            modelBuilder.Entity<AppUser>().HasData(
                new AppUser() { Id = 1, UserName = "administrator", Password = password1, Role = Enums.Role.admin },
                new AppUser() { Id = 2, UserName = "firat", Password = password2, Role = Enums.Role.user }
                );

            modelBuilder.Entity<Student>().HasData(
                new Student() { Id = 1, FirstName = "Fırat", LastName = "Alçın", Gender = Enums.Gender.Erkek },
                new Student() { Id = 2, FirstName = "Enes", LastName = "Çiçek", Gender = Enums.Gender.Erkek },
                new Student() { Id = 3, FirstName = "Sibel", LastName = "Doruk", Gender = Enums.Gender.Kadın },
                new Student() { Id = 4, FirstName = "Hatice", LastName = "Akkoçan", Gender = Enums.Gender.Kadın }
                );

            modelBuilder.Entity<StudentDetail>().HasData(
                new StudentDetail() { Id = 1, StudentId = 1, SchoolNumber = "100", BirthDay = new DateTime(1998, 04, 16) },
                new StudentDetail() { Id = 2, StudentId = 2, SchoolNumber = "101", BirthDay = new DateTime(1998, 05, 18) },
                new StudentDetail() { Id = 3, StudentId = 3, SchoolNumber = "102", BirthDay = new DateTime(1998, 11, 15) },
                new StudentDetail() { Id = 4, StudentId = 4, SchoolNumber = "103", BirthDay = new DateTime(1998, 12, 19) }
                );
        }
    }
}
