using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_5_Homework_5.Entities;

namespace Lesson_5_Homework_5.Abstract
{
    internal interface ISalesService
    {
        void Sales(Gamer gamer, Game game, Campaign campaign);
    }
}
