using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_5_Homework_5.Entities;

namespace Lesson_5_Homework_5.Abstract
{
    internal interface ICampaignService
    {
        void Add(Campaign campaign); 
        void Delete(Campaign campaign); 
        void Update(Campaign campaign); 
    }
}
