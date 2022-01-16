using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lesson_5_Homework_5.Abstract;
using Lesson_5_Homework_5.Entities;

namespace Lesson_5_Homework_5.Concrete
{
    internal class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine("Oyun Eklendi : " + game.GameName);
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun Silindi : " + game.GameName);
        }

        public void Update(Game game)
        {
            Console.WriteLine("Oyun Güncellendi : " + game.GameName);
        }
    }
}
