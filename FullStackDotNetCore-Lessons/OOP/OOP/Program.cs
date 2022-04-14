using OOP.Models;
using System;

namespace OOP
{
    public class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();

            user1.UserName = "Fırat";
            user1.Password = "1234";
            user1.Age = 23;
            user1.Job = "Computer Engineering";

            User user2 = new User()
            {
                UserName = "Cemal",
                Password = "1456",
                Age = 24,
                Job =  "Lawyer"
            };

            user2.Selamla(user2.UserName);

            //Kullanıcı Girişi Örneği

            Console.WriteLine("Please enter UserName: ");
            string userNameCheck = Console.ReadLine();
            Console.WriteLine("Please enter Password: ");
            string passwordCheck = Console.ReadLine();

            if(userNameCheck == user1.UserName & passwordCheck == user1.Password)
            {
                Console.WriteLine("Kullanıcı girişi başarılı!");
            }
            else
            {
                Console.WriteLine("Kullanıcı bilgileri yanlış");
            }
        }
    }
}
