using Lesson_5_Homework_5.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_5_Homework_5.Abstract
{
    internal interface IGamerCheckService
    {
        bool CheckGamerService(Gamer gamer);
    }
}
