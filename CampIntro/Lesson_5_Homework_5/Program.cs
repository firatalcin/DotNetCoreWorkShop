using Lesson_5_Homework_5.Adapters;
using Lesson_5_Homework_5.Concrete;
using Lesson_5_Homework_5.Entities;
using System;

namespace Lesson_5_Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Sadece doğru bilgiler girildiğinde çalışır, girilen değerler deneme amaçlıdır.
            Gamer gamer1 = new Gamer { Id = 1, FirstName = "Fırat", LastName = "Alçın", NationalityId = 1234567890, BirthYear = 1998 };
            
            //---------------------------------------------------------------------

            Game game1 = new Game { Id = 1, GameName = "Last of us", Price = 36.5 };


            Campaign campaign1 = new Campaign { Id = 1, CampaignName = "Yaz İndirimleri" };
            Campaign campaign2 = new Campaign { Id = 2, CampaignName = "Kış İndirimleri" };



            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            gamerManager.Add(gamer1);
            SalesManager salesManager = new SalesManager();


            salesManager.Sales(gamer1, game1, campaign1);




        }
    }
}
