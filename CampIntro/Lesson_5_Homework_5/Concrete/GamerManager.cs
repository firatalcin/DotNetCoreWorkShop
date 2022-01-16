using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_5_Homework_5.Abstract;
using Lesson_5_Homework_5.Entities;

namespace Lesson_5_Homework_5.Concrete
{
    internal class GamerManager : IGamerService
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerService(gamer))
            {
                Console.WriteLine("Oyuncu Eklendi " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Türkiye Cumhuriyeti Devletinde " + gamer.NationalityId + " kimlik numarası ve " + gamer.FirstName + " " + gamer.LastName + " adında biri bulunmamaktadır.");
            }
            ;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi " + gamer.FirstName + " " + gamer.LastName);
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
