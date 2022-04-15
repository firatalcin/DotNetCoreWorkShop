using Encapsulation.Models;
using System;

namespace Encapsulation
{
    public class Program
    {
        public static void Main()
        {
            Account account = new Account();
            Console.Write("Kullanıcı adını giriniz: ");
            account.UserName =  Console.ReadLine();
            Console.Write("Şifrenizi giriniz: ");
            account.Password = Console.ReadLine();
            Console.WriteLine($"Kullanıcı başarıyla oluşturulmuştur. Kullanıcı Adı: {account.UserName}");
        }
    }
}
