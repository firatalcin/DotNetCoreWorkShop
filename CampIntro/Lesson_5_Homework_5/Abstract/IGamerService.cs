using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_5_Homework_5.Entities;

namespace Lesson_5_Homework_5.Abstract
{
    internal interface IGamerService
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
