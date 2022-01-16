using Lesson_5_Homework_5.Abstract;
using Lesson_5_Homework_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Homework_5.Concrete
{
    internal class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi : " + campaign.CampaignName);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi : " + campaign.CampaignName);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi : " + campaign.CampaignName);
        }
    }
}
