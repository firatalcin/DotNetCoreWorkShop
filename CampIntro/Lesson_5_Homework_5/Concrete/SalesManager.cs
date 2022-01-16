using Lesson_5_Homework_5.Abstract;
using Lesson_5_Homework_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Homework_5.Concrete
{
    internal class SalesManager : ISalesService
    {
        public void Sales(Gamer gamer, Game game, Campaign campaign)
        {
            Console.WriteLine(
                game.GameName + 
                " adlı oyun " + 
                gamer.FirstName +
                " " +
                gamer.LastName +
                " kişisine " + 
                campaign.CampaignName +
                " kampanyası dahilinde " +
                game.Price +
                " fiyatına satılmıştır.");
        }
    }
}
